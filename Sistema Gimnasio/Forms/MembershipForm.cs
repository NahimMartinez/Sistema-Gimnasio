using Business;
using Data;
using Entities;
using FontAwesome.Sharp;
using Sistema_Gimnasio.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;



namespace Sistema_Gimnasio.Forms
{
    public partial class MembershipForm : Form
    {
        // Servicios que uso en el formulario.
        private readonly ClassService classService = new ClassService();                 // Trae clases activas.
        private readonly List<dynamic> classMembership = new List<dynamic>();           // (reservado) vínculo clase-membresía si lo necesito.
        private readonly List<dynamic> selectedClasses = new List<dynamic>();           // Clases elegidas por el usuario.
        private readonly MembershipService membershipService = new MembershipService(); // Alta y consulta de membresías.
        private readonly PaymentService paymentService = new PaymentService();          // Generar comprobantes y métodos de pago.
        private readonly PartnerService partnerService = new PartnerService();          // Alta de socio+persona en flujo completo.

        private bool fReady;                    // Flag para no ejecutar cálculos mientras cargo combos.
        private readonly int currentPartnerId;  // Si >0, es renovación/alta para socio existente.
        private Partner currentPartner;         // Socio en alta completa.
        private Person currentPerson;           // Persona en alta completa.

        // Estado visual por fila de clases: true/false alterna el ícono y color.
        private readonly Dictionary<int, bool> iconState = new Dictionary<int, bool>();

        // Ctor para renovar/crear membresía de un socio existente por Id.
        public MembershipForm(int pIdPartner)
        {
            InitializeComponent();           // Inicializa controles de WinForms.
            currentPartnerId = pIdPartner;   // Guardo el socio actual.
            LoadData();                      // Cargo grilla de clases disponibles.
            SetupActionIcons();              // Preparo íconos de selección por fila.
            this.Load += MembershipForm_Load; // Suscribo evento Load del form.
        }

        // Ctor para alta completa: primero persona+socio, luego membresía.
        public MembershipForm(Person pPerson, Partner pPartner)
        {
            InitializeComponent();

            currentPartner = pPartner;       // Socio que voy a crear.
            currentPerson = pPerson;         // Persona que voy a crear.
            currentPartnerId = 0;            // 0 indica flujo de alta completa.
            LoadData();                      // Clases disponibles.
            SetupActionIcons();              // Íconos por fila.
            this.Load += MembershipForm_Load; // Evento Load.
        }

        // Al cargar el form, lleno combos y engancho eventos.
        private void MembershipForm_Load(object sender, EventArgs e)
        {
            LoadMembershipTypes(); // Tipos de membresía (Diario/Semanal/Mensual).
            LoadPayMethods();      // Métodos de pago.

            // Cuando cambie el tipo de membresía recalculo total y filtro clases.
            CBMembership.SelectedIndexChanged += (s, ev) =>
            {
                if (fReady) UpdateTotalLabel(); // Solo si ya terminé de cargar.
                ApplyFilters();                  // Filtra por día si es Diario.
            };
        }

        // Suma precios de clases seleccionadas y aplica descuento según duración.
        private decimal UpdateTotalLabel()
        {
            decimal total = 0m;                                   // Acumulador.
            var item = CBMembership.SelectedItem as MembershipType; // Tipo elegido.

            // Sumo el precio de cada clase seleccionada.
            foreach (var c in selectedClasses)
            {
                var price = c.Precio;                             // dynamic -> leo propiedad.
                if (price != null) total += Convert.ToDecimal(price);
            }

            // Multiplico por días y descuento según regla.
            int dias = item.DuracionDias;
            switch (dias)
            {
                case 1: total *= dias; break;        // Diario 1x.
                case 7: total *= dias * 0.9m; break;        // Semanal 10% off.
                case 30: total *= dias * 0.8m; break;        // Mensual 20% off.
            }

            // Muestro total con 2 decimales.
            LTotalSum.Text = total.ToString("0.00");
            return total;
        }

        // Trae clases activas y, si hay socio, excluye las ya inscriptas en membresías activas.
        private List<dynamic> GetAvailableClasses()
        {
            var classes = classService.GetAllClassesActive(); // Todas activas.

            if (currentPartnerId > 0)
            {
                // Ids de clases donde ya está inscripto con membresía activa.
                var active = membershipService.GetActiveClassesByPartner(currentPartnerId); // List<int>
                if (active?.Count > 0)
                    classes = classes.Where(c => !active.Contains(c.IdClase)).ToList();     // Saco duplicadas.
            }

            // Proyecto a un anónimo “plano” para bindear en la grilla.
            return classes.Select(c => new
            {
                c.IdClase,
                Name = c.NombreActividad,
                Cupo = c.Cupo.ToString(),
                Dia = c.Dias,
                c.Horario,
                Precio = c.Precio.ToString("0.00"),
            }).ToList<dynamic>();
        }

        // Seteo inicial de la grilla de clases.
        private void LoadData()
        {
            BoardClass.AutoGenerateColumns = false; // Uso columnas diseñadas.
            BoardClass.DataSource = GetAvailableClasses(); // Enlazo data.
        }

        // Prepara íconos y comportamiento de selección por fila.
        private void SetupActionIcons()
        {
            // Íconos para alternar selección.
            Bitmap bmpCheck = IconChar.Check.ToBitmap(Color.Black, 30); // Seleccionar.
            Bitmap bmpCross = IconChar.Times.ToBitmap(Color.Black, 30); // Quitar.

            // Columna de acción muestra el ícono.
            colAdd.Image = bmpCheck;

            // Formateo de celda: decide qué ícono y color va en cada fila.
            BoardClass.CellFormatting += (s, e) =>
            {
                if (e.RowIndex < 0 || e.ColumnIndex != BoardClass.Columns["colAdd"].Index) return;

                // Leo estado guardado para esa fila. true/false alterna.
                bool isCross = iconState.ContainsKey(e.RowIndex) && iconState[e.RowIndex];

                // Seteo el valor visual del ícono.
                e.Value = isCross ? bmpCross : bmpCheck;
                e.FormattingApplied = true;

                // También seteo el valor directo de la celda para evitar parpadeos.
                var row = BoardClass.Rows[e.RowIndex];
                row.Cells["colAdd"].Value = isCross ? bmpCheck : bmpCross;

                // Color de fondo según si está seleccionada.
                if (isCross)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                    row.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
                }
            };

            // Click en la columna de acción: agrega o quita la clase de la lista.
            BoardClass.CellClick += (s, e) =>
            {
                if (e.RowIndex < 0 || e.ColumnIndex != BoardClass.Columns["colAdd"].Index) return;

                // Leo si estaba seleccionada.
                bool isSelected = iconState.ContainsKey(e.RowIndex) && iconState[e.RowIndex];

                // Obtengo el objeto enlazado a la fila.
                dynamic item = BoardClass.Rows[e.RowIndex].DataBoundItem;
                int id = (int)item.IdClase;

                if (!isSelected)
                {
                    // Si no está en la lista, la agrego.
                    if (!selectedClasses.Any(x => (int)x.IdClase == id))
                        selectedClasses.Add(item);
                }
                else
                {
                    // Si estaba, la quito.
                    var rem = selectedClasses.FirstOrDefault(x => (int)x.IdClase == id);
                    if (rem != null) selectedClasses.Remove(rem);
                }

                // Invierto el estado visual y refresco la fila.
                iconState[e.RowIndex] = !isSelected;
                BoardClass.InvalidateRow(e.RowIndex);

                // Recalculo total.
                UpdateTotalLabel();
            };
        }

        // Guardar: alta completa o registro para socio existente, y generar recibo.
        private void BSave_Click(object sender, EventArgs e)
        {
            // Validaciones mínimas.
            if (selectedClasses.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una clase.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (CBPayMethod.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un metodo de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Leo datos del formulario.
            var tipoMembresia = (MembershipType)CBMembership.SelectedItem;
            var tipoPago = (PaymentMethod)CBPayMethod.SelectedItem;
            var clasesIds = selectedClasses.Select(c => (int)c.IdClase).ToList();
            var total = decimal.Parse(LTotalSum.Text);
            var fechaInicio = DateTime.Today;
            int duracionDias = tipoMembresia.DuracionDias;

            var service = new MembershipService();     // Servicio para registrar membresía.
            string nameMembership = tipoMembresia.Nombre;

            // Flujo A: alta completa (persona+socio+membresía+pago).
            if (currentPartnerId == 0)
            {
                try
                {
                    var result = partnerService.RegisterFull(
                        persona: currentPerson,
                        socio: currentPartner,
                        usuarioId: Program.CurrentUser.IdPersona,
                        tipoMembresiaId: tipoMembresia.IdTipo,
                        tipoPagoId: tipoPago.IdMetodoPago,
                        clasesIds: clasesIds,
                        fechaInicio: fechaInicio,
                        duracionDias: duracionDias,
                        total: total
                    );

                    // Intento generar e imprimir el comprobante.
                    try
                    {
                        paymentService.GenerateReceipt(result.pagoId, autoPrint: true);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Error en imprimir el pdf: " + ex.Message);
                    }

                    // Mensaje de éxito con datos.
                    string nameComplete = $"{currentPerson.Nombre} {currentPerson.Apellido}";
                    MessageBox.Show(
                        $"Socio {nameComplete}, Membresía {nameMembership} y pago #{result.pagoId} registrados correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    this.DialogResult = DialogResult.OK; // Devuelvo OK al caller.
                    this.Close();                        // Cierro el form.
                }
                catch (Business.Exceptions.DuplicateFieldException ex)
                {
                    // Caso de campo duplicado controlado por la capa de negocio.
                    MessageBox.Show($"Error: {ex.Message}", "Campo duplicado",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    // Errores no esperados.
                    MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Flujo B: socio ya existe. Solo registro membresía+pago.
            else
            {
                try
                {
                    var result = service.Register(
                        socioId: currentPartnerId,
                        usuarioId: Program.CurrentUser.IdPersona,
                        tipoMembresiaId: tipoMembresia.IdTipo,
                        tipoPagoId: tipoPago.IdMetodoPago,
                        clasesIds: clasesIds,
                        fechaInicio: fechaInicio,
                        duracionDias: duracionDias,
                        total: total
                    );

                    // Genero e intento imprimir.
                    try
                    {
                        paymentService.GenerateReceipt(result.pagoId, autoPrint: true);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Error en imprimir el pdf: " + ex.Message);
                    }

                    // OK para renovación/alta sobre socio existente.
                    MessageBox.Show(
                        $"Membresía {nameMembership} y pago #{result.pagoId} registrados correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al registrar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Cancelar: cierra sin guardar.
        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Llena el combo de métodos de pago.
        private void LoadPayMethods()
        {
            var paymentMethods = paymentService.GetPaymentMethods(); // Trae lista.
            CBPayMethod.DataSource = null;              // Limpio por dudas.
            CBPayMethod.DisplayMember = "Nombre";       // Propiedad a mostrar.
            CBPayMethod.ValueMember = "IdMetodoPago";   // Valor interno.
            CBPayMethod.DataSource = paymentMethods;    // Enlazo.
            CBPayMethod.SelectedIndex = -1;             // Nada seleccionado.
        }

        // Llena el combo de tipos de membresía.
        private void LoadMembershipTypes()
        {
            fReady = false;                                      // Pauso cálculos.
            var types = membershipService.GetMembershipType();   // Trae lista.
            CBMembership.DataSource = null;                      // Limpio.
            CBMembership.DisplayMember = "Nombre";               // Texto visible.
            CBMembership.ValueMember = "DuracionDias";           // Valor interno.
            CBMembership.DataSource = types;                     // Enlazo.
            CBMembership.SelectedIndex = 2;                      // Por defecto “Mensual” (índice 2).
            fReady = true;                                       // Listo para calcular.
        }

        // Filtra clases según tipo de membresía. Si es “Diario”, muestro las de HOY.
        private void ApplyFilters()
        {
            // Si aún no hay selección válida, salgo.
            if (CBMembership.SelectedItem == null || !(CBMembership.SelectedItem is MembershipType))
                return;

            MembershipType m = (MembershipType)CBMembership.SelectedItem;
            var allMembershipClass = GetAvailableClasses(); // Todas las disponibles.

            if (m.Nombre.Equals("Diario", StringComparison.OrdinalIgnoreCase))
            {
                // Día de la semana en español para cruzar con “Dias” de la clase.
                var culture = System.Globalization.CultureInfo.GetCultureInfo("es-ES");
                string today = DateTime.Now.ToString("dddd", culture); // ej: "lunes"

                // Me quedo con las clases que incluyan el día actual.
                var filtered = allMembershipClass
                    .Where(c => c.Dia.IndexOf(today, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();

                BoardClass.DataSource = filtered; // Muestro solo las de hoy.
            }
            else
            {
                // Semanal o Mensual: muestro todas las activas.
                BoardClass.DataSource = allMembershipClass;
            }

            // Reinicio selección e iconos para no dejar basura visual.
            selectedClasses.Clear();
            iconState.Clear();
            BoardClass.ClearSelection();

            // Recalculo total con selección vacía.
            UpdateTotalLabel();
        }
    }
}
