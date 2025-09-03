using System.Windows.Forms;

namespace Sistema_Gimnasio
{
    partial class PartnersView
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            // Estilos reutilizables para celdas del DataGridView
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            // Controles de la vista
            this.LTiltePartne = new System.Windows.Forms.Label();           // Título "Gestión de Socios" (nota: el nombre está mal tipeado)
            this.BoardMember = new System.Windows.Forms.DataGridView();     // Grilla de socios
                                                                            // Columnas de la grilla (definidas a mano, uso de DataPropertyName para binding)
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membership = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.CBStatus = new System.Windows.Forms.ComboBox();            // Filtro por estado
            this.CBMembership = new System.Windows.Forms.ComboBox();        // Filtro por tipo de membresía
            this.BFilter = new System.Windows.Forms.Button();               // Botón "Filtrar"
            this.TSearch = new System.Windows.Forms.TextBox();              // Búsqueda por texto
            this.LStatus = new System.Windows.Forms.Label();                // Etiqueta "Estado"
            this.LMembership = new System.Windows.Forms.Label();            // Etiqueta "Membresía"
            this.BNewMember = new System.Windows.Forms.Button();            // Botón "Nuevo socio"
            this.panel1 = new System.Windows.Forms.Panel();                 // Barra superior con filtros y título

            ((System.ComponentModel.ISupportInitialize)(this.BoardMember)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();

            // ------------------ Label de título ------------------
            this.LTiltePartne.AutoSize = true;
            this.LTiltePartne.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.LTiltePartne.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.LTiltePartne.Location = new System.Drawing.Point(14, 12);
            this.LTiltePartne.Name = "LTiltePartne"; // sugerencia: renombrar a LTitlePartner
            this.LTiltePartne.Size = new System.Drawing.Size(166, 25);
            this.LTiltePartne.TabIndex = 0;
            this.LTiltePartne.Text = "Gestión de Socios";

            // ------------------ DataGridView ------------------
            this.BoardMember.AllowUserToAddRows = false;            // No permitir filas nuevas desde UI
            this.BoardMember.AllowUserToDeleteRows = false;         // No borrar desde UI
            this.BoardMember.AllowUserToResizeRows = false;         // Altura de filas fija

            // Estilo para filas alternadas (zebra)
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.BoardMember.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;

            this.BoardMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; // Columnas ocupan ancho
            this.BoardMember.BackgroundColor = System.Drawing.Color.White;
            this.BoardMember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoardMember.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BoardMember.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            // Estilo de cabecera
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BoardMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;

            this.BoardMember.ColumnHeadersHeight = 38;
            this.BoardMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Agrego las columnas visibles
            this.BoardMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
    this.name, this.dni, this.contact, this.membership, this.status, this.Actions
});

            // Estilo de celdas por defecto
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BoardMember.DefaultCellStyle = dataGridViewCellStyle3;

            this.BoardMember.Dock = System.Windows.Forms.DockStyle.Fill;           // Ocupa todo bajo el panel superior
            this.BoardMember.EnableHeadersVisualStyles = false;                    // Usar estilos custom en cabecera
            this.BoardMember.GridColor = System.Drawing.Color.FromArgb(241, 243, 245);
            this.BoardMember.Location = new System.Drawing.Point(0, 100);
            this.BoardMember.MultiSelect = false;                                  // Selección de una fila
            this.BoardMember.Name = "BoardMember";
            this.BoardMember.ReadOnly = true;                                      // Solo lectura (se edita en formularios aparte)
            this.BoardMember.RowHeadersVisible = false;                            // Oculta encabezado lateral
            this.BoardMember.RowTemplate.Height = 36;                              // Altura estándar de fila
            this.BoardMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; // Selección por fila
            this.BoardMember.Size = new System.Drawing.Size(762, 450);
            this.BoardMember.TabIndex = 1;

            // ------------------ Definición de columnas ------------------
            // Cada DataPropertyName debe coincidir con el nombre del campo en el origen de datos (binding)
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            this.name.ReadOnly = true;

            this.dni.DataPropertyName = "dni";
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;

            this.contact.DataPropertyName = "contact";
            this.contact.HeaderText = "Contacto";
            this.contact.Name = "contact";
            this.contact.ReadOnly = true;

            this.membership.DataPropertyName = "membership";
            this.membership.HeaderText = "Membresía";
            this.membership.Name = "membership";
            this.membership.ReadOnly = true;

            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Estado";
            this.status.Name = "status";
            this.status.ReadOnly = true;

            this.Actions.DataPropertyName = "Actions";            // Sugerencia: usar un botón o iconos en vez de texto
            this.Actions.HeaderText = "Acciones";
            this.Actions.Name = "Actions";
            this.Actions.ReadOnly = true;

            // ------------------ ComboBox de Estado ------------------
            this.CBStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; // Evita texto libre
            this.CBStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CBStatus.FormattingEnabled = true;
            this.CBStatus.Items.AddRange(new object[] { "Todos", "Activo", "Inactivo" });
            this.CBStatus.Location = new System.Drawing.Point(168, 66);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(130, 23);
            this.CBStatus.TabIndex = 2;

            // ------------------ ComboBox de Membresía ------------------
            this.CBMembership.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMembership.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CBMembership.FormattingEnabled = true;
            this.CBMembership.Items.AddRange(new object[] { "Todos", "Mensual", "Semanal", "Día" });
            this.CBMembership.Location = new System.Drawing.Point(304, 66);
            this.CBMembership.Name = "CBMembership";
            this.CBMembership.Size = new System.Drawing.Size(130, 23);
            this.CBMembership.TabIndex = 3;

            // ------------------ Botón Filtrar ------------------
            this.BFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right))); // Se pega a la derecha al redimensionar
            this.BFilter.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.BFilter.FlatAppearance.BorderSize = 0;
            this.BFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BFilter.ForeColor = System.Drawing.Color.White;
            this.BFilter.Location = new System.Drawing.Point(560, 64);
            this.BFilter.Name = "BFilter";
            this.BFilter.Size = new System.Drawing.Size(84, 26);
            this.BFilter.TabIndex = 4;
            this.BFilter.Text = "Filtrar";
            this.BFilter.UseVisualStyleBackColor = false;
            // evento Click esperado: aplicar filtros a la fuente de datos

            // ------------------ Caja de búsqueda ------------------
            this.TSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right))); // Se estira horizontalmente
            this.TSearch.BackColor = System.Drawing.Color.White;
            this.TSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TSearch.ForeColor = System.Drawing.Color.Gray; // PlaceHolder "visual" (no nativo en WinForms)
            this.TSearch.Location = new System.Drawing.Point(18, 66);
            this.TSearch.Name = "TSearch";
            this.TSearch.Size = new System.Drawing.Size(144, 23);
            this.TSearch.TabIndex = 5;
            this.TSearch.Text = "Buscar socio..."; // Sugerencia: limpiar en Enter/Click

            // ------------------ Etiquetas ------------------
            this.LStatus.AutoSize = true;
            this.LStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LStatus.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.LStatus.Location = new System.Drawing.Point(165, 48);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(46, 15);
            this.LStatus.TabIndex = 6;
            this.LStatus.Text = "Estado";

            this.LMembership.AutoSize = true;
            this.LMembership.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LMembership.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.LMembership.Location = new System.Drawing.Point(301, 48);
            this.LMembership.Name = "LMembership";
            this.LMembership.Size = new System.Drawing.Size(67, 15);
            this.LMembership.TabIndex = 7;
            this.LMembership.Text = "Membresía";
            this.LMembership.Click += new System.EventHandler(this.LMembership_Click); // Handler opcional

            // ------------------ Botón Nuevo socio ------------------
            this.BNewMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BNewMember.BackColor = System.Drawing.Color.FromArgb(255, 112, 67);
            this.BNewMember.FlatAppearance.BorderSize = 0;
            this.BNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNewMember.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BNewMember.ForeColor = System.Drawing.Color.White;
            this.BNewMember.Location = new System.Drawing.Point(650, 64);
            this.BNewMember.Name = "BNewMember";
            this.BNewMember.Size = new System.Drawing.Size(100, 26);
            this.BNewMember.TabIndex = 8;
            this.BNewMember.Text = "Nuevo socio";
            this.BNewMember.UseVisualStyleBackColor = false;
            this.BNewMember.Click += new System.EventHandler(this.BNewMember_Click); // Abre formulario/UC para alta

            // ------------------ Panel superior (toolbar) ------------------
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LTiltePartne);
            this.panel1.Controls.Add(this.BNewMember);
            this.panel1.Controls.Add(this.TSearch);
            this.panel1.Controls.Add(this.LMembership);
            this.panel1.Controls.Add(this.CBStatus);
            this.panel1.Controls.Add(this.LStatus);
            this.panel1.Controls.Add(this.CBMembership);
            this.panel1.Controls.Add(this.BFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;            // Se ancla arriba
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panel1.Size = new System.Drawing.Size(762, 100);
            this.panel1.TabIndex = 9;

            // ------------------ UserControl contenedor ------------------
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250); // Fondo general gris claro
            this.Controls.Add(this.BoardMember);    // Orden importa: primero grilla, luego panel arriba
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "PartnersView";
            this.Size = new System.Drawing.Size(762, 550);
            this.DoubleBuffered = true;             // Reduce flicker en repintado

            ((System.ComponentModel.ISupportInitialize)(this.BoardMember)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LTiltePartne;
        private System.Windows.Forms.DataGridView BoardMember;
        private System.Windows.Forms.ComboBox CBStatus;
        private System.Windows.Forms.ComboBox CBMembership;
        private System.Windows.Forms.Button BFilter;
        private System.Windows.Forms.TextBox TSearch;
        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.Label LMembership;
        private System.Windows.Forms.Button BNewMember;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn membership;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actions;
    }
}
