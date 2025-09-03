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
            this.BoardMember = new System.Windows.Forms.DataGridView();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.BFilter = new System.Windows.Forms.Button();
            this.TSearch = new System.Windows.Forms.TextBox();
            this.LStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BNewClass = new System.Windows.Forms.Button();
            this.CBDia = new System.Windows.Forms.ComboBox();
            this.LDia = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)(this.BoardMember)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();

            // 
            // LTituloClases
            // 
            this.LTituloClases.AutoSize = true;
            this.LTituloClases.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.LTituloClases.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.LTituloClases.Location = new System.Drawing.Point(14, 12);
            this.LTituloClases.Name = "LTituloClases";
            this.LTituloClases.Size = new System.Drawing.Size(171, 25);
            this.LTituloClases.TabIndex = 0;
            this.LTituloClases.Text = "Gestión de Clases";
            // 
            // BoardMember
            // 
            this.BoardMember.AllowUserToAddRows = false;
            this.BoardMember.AllowUserToDeleteRows = false;
            this.BoardMember.AllowUserToResizeRows = false;

            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.BoardMember.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;

            this.BoardMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BoardMember.BackgroundColor = System.Drawing.Color.White;
            this.BoardMember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoardMember.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BoardMember.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

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
            this.BoardMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.cupo,
            this.dia,
            this.hora,
            this.status});

            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BoardMember.DefaultCellStyle = dataGridViewCellStyle3;

            this.BoardMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoardMember.EnableHeadersVisualStyles = false;
            this.BoardMember.GridColor = System.Drawing.Color.FromArgb(241, 243, 245);
            this.BoardMember.Location = new System.Drawing.Point(0, 100);
            this.BoardMember.MultiSelect = false;
            this.BoardMember.Name = "BoardMember";
            this.BoardMember.ReadOnly = true;
            this.BoardMember.RowHeadersVisible = false;
            this.BoardMember.RowTemplate.Height = 36;
            this.BoardMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BoardMember.Size = new System.Drawing.Size(762, 450);
            this.BoardMember.TabIndex = 1;
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
            this.CBStatus.Size = new System.Drawing.Size(130, 23);
            this.CBStatus.TabIndex = 2;
            // 
            // BFilter
            // 
            this.BFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BFilter.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.BFilter.FlatAppearance.BorderSize = 0;
            this.BFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BFilter.ForeColor = System.Drawing.Color.White;
            this.BFilter.Location = new System.Drawing.Point(480, 64);
            this.BFilter.Name = "BFilter";
            this.BFilter.Size = new System.Drawing.Size(84, 26);
            this.BFilter.TabIndex = 4;
            this.BFilter.Text = "Filtrar";
            this.BFilter.UseVisualStyleBackColor = false;
            // 
            // TSearch
            // 
            this.TSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TSearch.BackColor = System.Drawing.Color.White;
            this.TSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TSearch.ForeColor = System.Drawing.Color.Gray;
            this.TSearch.Location = new System.Drawing.Point(18, 66);
            this.TSearch.Name = "TSearch";
            this.TSearch.Size = new System.Drawing.Size(144, 23);
            this.TSearch.TabIndex = 5;
            this.TSearch.Text = "Buscar clase...";
            // 
            // LStatus
            // 
            this.LStatus.AutoSize = true;
            this.LStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LStatus.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.LStatus.Location = new System.Drawing.Point(165, 48);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(42, 15);
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
            this.panel1.Controls.Add(this.BFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panel1.Size = new System.Drawing.Size(762, 100);
            this.panel1.TabIndex = 9;
            // 
            // BNewClass
            // 
            this.BNewClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BNewClass.BackColor = System.Drawing.Color.FromArgb(255, 112, 67);
            this.BNewClass.FlatAppearance.BorderSize = 0;
            this.BNewClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNewClass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BNewClass.ForeColor = System.Drawing.Color.White;
            this.BNewClass.Location = new System.Drawing.Point(650, 64);
            this.BNewClass.Name = "BNewClass";
            this.BNewClass.Size = new System.Drawing.Size(100, 26);
            this.BNewClass.TabIndex = 9;
            this.BNewClass.Text = "Nueva clase";
            this.BNewClass.UseVisualStyleBackColor = false;
            this.BNewClass.Click += new System.EventHandler(this.BNewClass_Click);
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
            "Sábado",
            "Domingo"});
            this.CBDia.Location = new System.Drawing.Point(304, 66);
            this.CBDia.Name = "CBDia";
            this.CBDia.Size = new System.Drawing.Size(130, 23);
            this.CBDia.TabIndex = 11;
            // 
            // LDia
            // 
            this.LDia.AutoSize = true;
            this.LDia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LDia.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.LDia.Location = new System.Drawing.Point(301, 48);
            this.LDia.Name = "LDia";
            this.LDia.Size = new System.Drawing.Size(26, 15);
            this.LDia.TabIndex = 12;
            this.LDia.Text = "Día";
            // 
            // name
            // 
            this.name.DataPropertyName = "nombre";
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // cupo
            // 
            this.cupo.DataPropertyName = "cupo";
            this.cupo.HeaderText = "Cupo";
            this.cupo.Name = "cupo";
            this.cupo.ReadOnly = true;
            // 
            // dia
            // 
            this.dia.DataPropertyName = "dia";
            this.dia.HeaderText = "Día";
            this.dia.Name = "dia";
            this.dia.ReadOnly = true;
            // 
            // hora
            // 
            this.hora.DataPropertyName = "hora";
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "estado";
            this.status.HeaderText = "Estado";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // Clases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.Add(this.BoardMember);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Clases";
            this.Size = new System.Drawing.Size(762, 550);
            this.DoubleBuffered = true;
            ((System.ComponentModel.ISupportInitialize)(this.BoardMember)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LTituloClases;
        private System.Windows.Forms.DataGridView BoardMember;
        private System.Windows.Forms.ComboBox CBStatus;
        private System.Windows.Forms.Button BFilter;
        private System.Windows.Forms.TextBox TSearch;
        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BNewClass;
        private System.Windows.Forms.ComboBox CBDia;
        private System.Windows.Forms.Label LDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}