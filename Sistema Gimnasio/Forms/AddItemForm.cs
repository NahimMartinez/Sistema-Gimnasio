using Business;
using Business.Exceptions;
using Entities;
using System;
using System.Windows.Forms;
using static Sistema_Gimnasio.Form1;

namespace Sistema_Gimnasio.Forms
{
    public partial class AddItemForm : Form
    {
        private readonly InventoryService inventoryService = new InventoryService();
        private readonly InventoryCategoryService categoryService = new InventoryCategoryService();
        private readonly SupplierService supplierService = new SupplierService();
        public Roles CurrentRole { get; set; } = Roles.None;

        private Inventory editableItem;

        public AddItemForm()
        {
            InitializeComponent();
            ConfigureValidations();
            LoadCategories();
            LoadSuppliers();
            this.Text = "Nuevo Artículo"; // Cambia el título de la ventana
            this.Load += AddItemForm_Load;

        }

        // NUEVO CONSTRUCTOR PARA EDITAR
        public AddItemForm(int idToEdit)
        {
            InitializeComponent();
            ConfigureValidations();
            LoadCategories();
            LoadSuppliers();
            this.Text = "Editar Artículo"; // Cambia el título de la ventana

            // Buscamos el artículo en la BD y lo cargamos en el formulario
            try
            {
                editableItem = inventoryService.GetInventoryById(idToEdit);
                if (editableItem != null)
                {
                    LoadDataForEdit();
                }
                else
                {
                    MessageBox.Show("No se encontró el artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el artículo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        // MÉTODO para llenar el form con datos
        private void LoadDataForEdit()
        {
            txtNombre.Text = editableItem.Nombre;
            txtCantidad.Text = editableItem.Cantidad.ToString();

            // Seleccionamos la categoría correcta en el ComboBox
            CBCategoria.SelectedValue = editableItem.IdInventarioCategoria;

            // Seleccionamos el proveedor. Si el IdProveedor es 0 o no existe en la lista,
            // se mostrará el placeholder (IdProveedor = 0, Nombre = "----------").
            try
            {
                CBProveedor.SelectedValue = editableItem.IdProveedor;
            }
            catch
            {
                // en caso de algún desajuste por tipos, intentamos seleccionar 0 (placeholder)
                CBProveedor.SelectedValue = 0;
            }

            DTFechaIngreso.Value = editableItem.FechaIngreso;
            DTFechaIngreso.Enabled = false; // Deshabilitamos para que no se pueda cambiar
        }

        private void LoadCategories()
        {
            try
            {
                CBCategoria.DataSource = categoryService.GetAllCategories();
                CBCategoria.DisplayMember = "Nombre";
                CBCategoria.ValueMember = "IdInventarioCategoria";
                CBCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las categorías: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSuppliers()
        {
            try
            {
                var suppliers = supplierService.GetAllService();

                var placeholder = new Supplier { IdProveedor = 0, Nombre = "----------" };

                if (suppliers == null)
                {
                    suppliers = new System.Collections.Generic.List<Supplier>();
                }

                // Si no existe ya un proveedor con Id 0, insertamos el placeholder al inicio
                if (!suppliers.Exists(s => s.IdProveedor == 0))
                {
                    suppliers.Insert(0, placeholder);
                }

                CBProveedor.DataSource = suppliers;
                CBProveedor.DisplayMember = "Nombre";
                CBProveedor.ValueMember = "IdProveedor";
                CBProveedor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los proveedores: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BCrear_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            try
            {
                // Si _editableItem es NULL, estamos creando uno nuevo
                if (editableItem == null)
                {
                    var newItem = new Inventory
                    {
                        Nombre = txtNombre.Text.Trim(),
                        Cantidad = int.Parse(txtCantidad.Text),
                        IdInventarioCategoria = (int)CBCategoria.SelectedValue,
                        IdProveedor = (int)CBProveedor.SelectedValue,
                    };
                    inventoryService.CreateInventory(newItem);
                    MessageBox.Show("Artículo guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Si NO es NULL, estamos actualizando el existente
                else
                {
                    // Actualizamos el objeto que ya teníamos
                    editableItem.Nombre = txtNombre.Text.Trim();
                    editableItem.Cantidad = int.Parse(txtCantidad.Text);
                    editableItem.IdInventarioCategoria = (int)CBCategoria.SelectedValue;
                    editableItem.IdProveedor = (int)CBProveedor.SelectedValue;

                    inventoryService.UpdateInventory(editableItem);
                    MessageBox.Show("Artículo actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (DuplicateFieldException ex)
            {
                MessageBox.Show(ex.Message, "Error: Nombre Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor ingrese el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Por favor ingrese una Cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (CBCategoria.SelectedValue == null)
            {
                MessageBox.Show("Por favor seleccione una categoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (CBProveedor.SelectedValue == null)
            {
                MessageBox.Show("Por favor seleccione un proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void ConfigureValidations()
        {
            txtCantidad.KeyPress += TxtSoloNumeros_KeyPress;
        }
        private void TxtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos (del 0 al 9) y teclas de control (como Backspace).
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, se cancela el evento.
                e.Handled = true;
            }
        }
        private void BLimpiar_Click(object sender, EventArgs e)
        {
            // Limpia el contenido del TextBox de nombre.
            txtNombre.Clear();

            // Limpia el contenido del TextBox de cantidad.
            txtCantidad.Clear();

            // Deselecciona cualquier categoría en el ComboBox.
            CBCategoria.SelectedIndex = -1;

            // Restaura la fecha actual en el selector de fecha.
            DTFechaIngreso.Value = DateTime.Now;

            // Pone el foco (el cursor) de nuevo en el campo de nombre.
            txtNombre.Focus();
        }

        private void NewCategoryInventory_Click(object sender, EventArgs e)
        {
            //creo una instancia del formulario
            using (var fNewItem = new AddInventoryCategory())
            {
                //muestro el formulario como un cuadro de dialogo
                if (fNewItem.ShowDialog() == DialogResult.OK)
                {
                    LoadCategories();
                }
            }
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            if (CurrentRole != Roles.Admin)
            {
                NewCategoryInventory.Visible = false;
            }           
        }
    }
}