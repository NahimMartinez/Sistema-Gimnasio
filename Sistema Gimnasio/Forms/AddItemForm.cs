using Business;
using Business.Exceptions;
using Entities;
using System;
using System.Windows.Forms;

namespace Sistema_Gimnasio.Forms
{
    public partial class AddItemForm : Form
    {
        private readonly InventoryService _inventoryService = new InventoryService();
        private readonly InventoryCategoryService _categoryService = new InventoryCategoryService();

        private Inventory _editableItem;

        public AddItemForm()
        {
            InitializeComponent();
            ConfigureValidations();
            LoadCategories();
            this.Text = "Nuevo Artículo"; // Cambia el título de la ventana
        }

        // NUEVO CONSTRUCTOR PARA EDITAR
        public AddItemForm(int idToEdit)
        {
            InitializeComponent();
            ConfigureValidations();
            LoadCategories();
            this.Text = "Editar Artículo"; // Cambia el título de la ventana

            // Buscamos el artículo en la BD y lo cargamos en el formulario
            try
            {
                _editableItem = _inventoryService.GetInventoryById(idToEdit);
                if (_editableItem != null)
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
            txtNombre.Text = _editableItem.Nombre;
            txtCantidad.Text = _editableItem.Cantidad.ToString();

            // Seleccionamos la categoría correcta en el ComboBox
            CBCategoria.SelectedValue = _editableItem.IdInventarioCategoria;

            // La fecha de ingreso no se suele editar, la dejamos como está.
            DTFechaIngreso.Value = _editableItem.FechaIngreso;
            DTFechaIngreso.Enabled = false; // Deshabilitamos para que no se pueda cambiar
        }

        private void LoadCategories()
        {
            try
            {
                CBCategoria.DataSource = _categoryService.GetAllCategories();
                CBCategoria.DisplayMember = "Nombre";
                CBCategoria.ValueMember = "IdInventarioCategoria";
                CBCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las categorías: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (_editableItem == null)
                {
                    var newItem = new Inventory
                    {
                        Nombre = txtNombre.Text.Trim(),
                        Cantidad = int.Parse(txtCantidad.Text),
                        IdInventarioCategoria = (int)CBCategoria.SelectedValue
                    };
                    _inventoryService.CreateInventory(newItem);
                    MessageBox.Show("Artículo guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Si NO es NULL, estamos actualizando el existente
                else
                {
                    // Actualizamos el objeto que ya teníamos
                    _editableItem.Nombre = txtNombre.Text.Trim();
                    _editableItem.Cantidad = int.Parse(txtCantidad.Text);
                    _editableItem.IdInventarioCategoria = (int)CBCategoria.SelectedValue;

                    _inventoryService.UpdateInventory(_editableItem);
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
    }
}