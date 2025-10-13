using Business; 
using Business.Exceptions; 
using Entities; 
using System;
using System.Windows.Forms;

namespace Sistema_Gimnasio.Forms
{
    public partial class AddInventoryCategory : Form
    {
        private readonly InventoryCategoryService categoryService = new InventoryCategoryService();

        public AddInventoryCategory()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = true;
        }

        // Botón Guardar
        private void BSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Crea el objeto a guardar con los datos del formulario
                var newCategory = new InventoryCategory
                {
                    Nombre = txtNewClassCategory.Text.Trim() // Usamos Trim() para quitar espacios
                };

                // Llama al servicio para que agrege la nueva categoría
                categoryService.CreateCategory(newCategory);

                MessageBox.Show("Categoría guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Indicar que el formulario se cerró exitosamente
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            //Captura los errores
            catch (ArgumentException ex) // Error por nombre vacío
            {
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (DuplicateFieldException ex) // Error por nombre duplicado
            {
                MessageBox.Show(ex.Message, "Error: Campo Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) // Cualquier otro error inesperado
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón Cancelar
        private void BCancel_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}