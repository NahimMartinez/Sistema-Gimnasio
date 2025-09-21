namespace Sistema_Gimnasio.Controls
{
    partial class Clases
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LTituloClases = new System.Windows.Forms.Label();
            this.BoardClass = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.colView = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.TSearch = new System.Windows.Forms.TextBox();
            this.LStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBDia = new System.Windows.Forms.ComboBox();
            this.LDia = new System.Windows.Forms.Label();
            this.BNewClass = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.BoardClass)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LTituloClases
            // 
            this.LTituloClases.AutoSize = true;
            this.LTituloClases.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.LTituloClases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.LTituloClases.Location = new System.Drawing.Point(14, 12);
            this.LTituloClases.Name = "LTituloClases";
            this.LTituloClases.Size = new System.Drawing.Size(205, 32);
            this.LTituloClases.TabIndex = 0;
            this.LTituloClases.Text = "Gestión de Clases";
            // 
            // BoardClass
            // 
            this.BoardClass.AllowUserToAddRows = false;
            this.BoardClass.AllowUserToDeleteRows = false;
            this.BoardClass.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.BoardClass.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BoardClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BoardClass.BackgroundColor = System.Drawing.Color.White;
            this.BoardClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoardClass.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BoardClass.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BoardClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BoardClass.ColumnHeadersHeight = 38;
            this.BoardClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BoardClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.coach,
            this.cupo,
            this.dia,
            this.hora,
            this.status,
            this.colEdit,
            this.colView,
            this.colDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BoardClass.DefaultCellStyle = dataGridViewCellStyle3;
            this.BoardClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoardClass.EnableHeadersVisualStyles = false;
            this.BoardClass.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.BoardClass.Location = new System.Drawing.Point(0, 100);
            this.BoardClass.MultiSelect = false;
            this.BoardClass.Name = "BoardClass";
            this.BoardClass.ReadOnly = true;
            this.BoardClass.RowHeadersVisible = false;
            this.BoardClass.RowHeadersWidth = 51;
            this.BoardClass.RowTemplate.Height = 36;
            this.BoardClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BoardClass.Size = new System.Drawing.Size(762, 450);
            this.BoardClass.TabIndex = 1;
            // 
            // name
            // 
            this.name.DataPropertyName = "nombre";
            this.name.HeaderText = "Nombre";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // coach
            // 
            this.coach.HeaderText = "Coach";
            this.coach.MinimumWidth = 6;
            this.coach.Name = "coach";
            this.coach.ReadOnly = true;
            // 
            // cupo
            // 
            this.cupo.DataPropertyName = "cupo";
            this.cupo.HeaderText = "Cupo";
            this.cupo.MinimumWidth = 6;
            this.cupo.Name = "cupo";
            this.cupo.ReadOnly = true;
            // 
            // dia
            // 
            this.dia.DataPropertyName = "dia";
            this.dia.HeaderText = "Día";
            this.dia.MinimumWidth = 6;
            this.dia.Name = "dia";
            this.dia.ReadOnly = true;
            // 
            // hora
            // 
            this.hora.DataPropertyName = "hora";
            this.hora.HeaderText = "Hora";
            this.hora.MinimumWidth = 6;
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "estado";
            this.status.HeaderText = "Estado";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // colEdit
            // 
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEdit.HeaderText = "";
            this.colEdit.MinimumWidth = 6;
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Width = 50;
            // 
            // colView
            // 
            this.colView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colView.HeaderText = "";
            this.colView.MinimumWidth = 6;
            this.colView.Name = "colView";
            this.colView.ReadOnly = true;
            this.colView.Width = 50;
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDelete.HeaderText = "";
            this.colDelete.MinimumWidth = 6;
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Width = 50;
            // 
            // CBStatus
            // 
            this.CBStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CBStatus.FormattingEnabled = true;
            this.CBStatus.Items.AddRange(new object[] {
            "Todos",
            "Activo",
            "Inactivo",
            "Completo"});
            this.CBStatus.Location = new System.Drawing.Point(168, 66);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(130, 28);
            this.CBStatus.TabIndex = 2;
            // 
            // TSearch
            // 
            this.TSearch.BackColor = System.Drawing.Color.White;
            this.TSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TSearch.ForeColor = System.Drawing.Color.Gray;
            this.TSearch.Location = new System.Drawing.Point(18, 66);
            this.TSearch.Name = "TSearch";
            this.TSearch.Size = new System.Drawing.Size(144, 27);
            this.TSearch.TabIndex = 5;
            this.TSearch.Text = "Buscar clase...";
            // 
            // LStatus
            // 
            this.LStatus.AutoSize = true;
            this.LStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LStatus.Location = new System.Drawing.Point(165, 48);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(54, 20);
            this.LStatus.TabIndex = 6;
            this.LStatus.Text = "Estado";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.CBDia);
            this.panel1.Controls.Add(this.LDia);
            this.panel1.Controls.Add(this.LTituloClases);
            this.panel1.Controls.Add(this.BNewClass);
            this.panel1.Controls.Add(this.TSearch);
            this.panel1.Controls.Add(this.CBStatus);
            this.panel1.Controls.Add(this.LStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panel1.Size = new System.Drawing.Size(762, 100);
            this.panel1.TabIndex = 9;
            // 
            // CBDia
            // 
            this.CBDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CBDia.FormattingEnabled = true;
            this.CBDia.Items.AddRange(new object[] {
            "Todos",
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado"});
            this.CBDia.Location = new System.Drawing.Point(304, 66);
            this.CBDia.Name = "CBDia";
            this.CBDia.Size = new System.Drawing.Size(130, 28);
            this.CBDia.TabIndex = 11;
            // 
            // LDia
            // 
            this.LDia.AutoSize = true;
            this.LDia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LDia.Location = new System.Drawing.Point(301, 48);
            this.LDia.Name = "LDia";
            this.LDia.Size = new System.Drawing.Size(32, 20);
            this.LDia.TabIndex = 12;
            this.LDia.Text = "Día";
            // 
            // BNewClass
            // 
            this.BNewClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BNewClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            this.BNewClass.FlatAppearance.BorderSize = 0;
            this.BNewClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNewClass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BNewClass.ForeColor = System.Drawing.Color.White;
            this.BNewClass.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BNewClass.IconColor = System.Drawing.Color.White;
            this.BNewClass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BNewClass.IconSize = 20;
            this.BNewClass.Location = new System.Drawing.Point(614, 64);
            this.BNewClass.Name = "BNewClass";
            this.BNewClass.Size = new System.Drawing.Size(136, 26);
            this.BNewClass.TabIndex = 9;
            this.BNewClass.Text = "Nueva clase";
            this.BNewClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BNewClass.UseVisualStyleBackColor = false;
            this.BNewClass.Click += new System.EventHandler(this.BNewClass_Click);
            // 
            // Clases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.BoardClass);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Clases";
            this.Size = new System.Drawing.Size(762, 550);
            ((System.ComponentModel.ISupportInitialize)(this.BoardClass)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LTituloClases;
        private System.Windows.Forms.DataGridView BoardClass;
        private System.Windows.Forms.ComboBox CBStatus;
        private System.Windows.Forms.TextBox TSearch;
        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton BNewClass;
        private System.Windows.Forms.ComboBox CBDia;
        private System.Windows.Forms.Label LDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn coach;
        private System.Windows.Forms.DataGridViewTextBoxColumn cupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewImageColumn colEdit;
        private System.Windows.Forms.DataGridViewImageColumn colView;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
    }
}