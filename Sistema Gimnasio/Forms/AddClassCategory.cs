using Business;
using Business.Exceptions;
using Entities;
using System;
using System.Windows.Forms;

namespace Sistema_Gimnasio.Forms
{
    public partial class AddClassCategory : Form
    {
        // Creamos una instancia del servicio de actividades
        private readonly ActivityService _activityService = new ActivityService();

        public AddClassCategory()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = true;
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Creamos el objeto a guardar con el nombre del TextBox
                var newActivity = new Activity
                {
                    Nombre = txtNewClassCategory.Text.Trim()
                };

                // 2. Llamamos al servicio para que lo guarde
                _activityService.CreateActivity(newActivity);

                MessageBox.Show("Categoría de clase guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 3. Indicamos que se guardó correctamente y cerramos
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentException ex) // Captura error de nombre vacío
            {
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (DuplicateFieldException ex) // Captura error de nombre duplicado
            {
                MessageBox.Show(ex.Message, "Error: Categoría Duplicada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) // Captura cualquier otro error
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}