using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gimnasio.Forms
{
    public partial class BackupForm : Form
    {

        public BackupForm()
        {
            InitializeComponent();

            this.MaximizeBox = false;  // Esto quita el botón del cuadrado (maximizar)
            this.MinimizeBox = true;
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            string backupPath = txtRoad.Text.Trim();
            if (string.IsNullOrEmpty(backupPath))
            {
                MessageBox.Show("Seleccione la ruta donde guardar la copia de seguridad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string databaseName = "GymDB"; 

            // Usar la cadena de conexión del proyecto, pero con InitialCatalog = master
            var builder = new SqlConnectionStringBuilder(Connection.chain);
            builder.InitialCatalog = "master";
            string connectionString = builder.ToString();

            string backupQuery = $"BACKUP DATABASE [{databaseName}] TO DISK = N'{backupPath}' WITH FORMAT, INIT, NAME = 'Backup completo', SKIP, NOREWIND, NOUNLOAD, STATS = 10";

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand(backupQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Copia de seguridad realizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la copia de seguridad:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BRoad_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Archivos de backup (*.bak)|*.bak|Todos los archivos|*.*";
            saveFile.Title = "Seleccionar ubicación de la copia de seguridad";
            saveFile.DefaultExt = "bak";
            saveFile.AddExtension = true;
            saveFile.FileName = $"GymDB_{DateTime.Now:yyyyMMdd}.bak"; 

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                txtRoad.Text = saveFile.FileName;
            }
        }
    }
}
