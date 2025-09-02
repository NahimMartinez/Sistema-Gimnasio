namespace Sistema_Gimnasio
{
    partial class usersManagnent
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
            this.LTituloUserManagment = new System.Windows.Forms.Label();
            this.BoardMember = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.BFilter = new System.Windows.Forms.Button();
            this.TSearch = new System.Windows.Forms.TextBox();
            this.LStatus = new System.Windows.Forms.Label();
            this.BNewMember = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BoardMember)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LTituloUserManagment
            // 
            this.LTituloUserManagment.AutoSize = true;
            this.LTituloUserManagment.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloUserManagment.Location = new System.Drawing.Point(11, 13);
            this.LTituloUserManagment.Name = "LTituloUserManagment";
            this.LTituloUserManagment.Size = new System.Drawing.Size(198, 22);
            this.LTituloUserManagment.TabIndex = 0;
            this.LTituloUserManagment.Text = "Gestión de Usuarios";
            // 
            // BoardMember
            // 
            this.BoardMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BoardMember.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.BoardMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BoardMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.dni,
            this.contact,
            this.status,
            this.usuario});
            this.BoardMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoardMember.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.BoardMember.Location = new System.Drawing.Point(0, 100);
            this.BoardMember.Name = "BoardMember";
            this.BoardMember.Size = new System.Drawing.Size(762, 450);
            this.BoardMember.TabIndex = 1;
            // 
            // name
            // 
            this.name.DataPropertyName = "nombre";
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            // 
            // dni
            // 
            this.dni.DataPropertyName = "dni";
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            // 
            // contact
            // 
            this.contact.DataPropertyName = "telefono";
            this.contact.HeaderText = "Teléfono";
            this.contact.Name = "contact";
            // 
            // status
            // 
            this.status.DataPropertyName = "estado";
            this.status.HeaderText = "Estado";
            this.status.Name = "status";
            // 
            // CBStatus
            // 
            this.CBStatus.FormattingEnabled = true;
            this.CBStatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CBStatus.Location = new System.Drawing.Point(165, 67);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(121, 21);
            this.CBStatus.TabIndex = 2;
            this.CBStatus.Text = "Todos";
            // 
            // BFilter
            // 
            this.BFilter.BackColor = System.Drawing.Color.DodgerBlue;
            this.BFilter.FlatAppearance.BorderSize = 0;
            this.BFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BFilter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BFilter.Location = new System.Drawing.Point(332, 68);
            this.BFilter.Name = "BFilter";
            this.BFilter.Size = new System.Drawing.Size(84, 20);
            this.BFilter.TabIndex = 4;
            this.BFilter.Text = "Filtrar";
            this.BFilter.UseVisualStyleBackColor = false;
            // 
            // TSearch
            // 
            this.TSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TSearch.Location = new System.Drawing.Point(14, 67);
            this.TSearch.Name = "TSearch";
            this.TSearch.Size = new System.Drawing.Size(145, 20);
            this.TSearch.TabIndex = 5;
            this.TSearch.Text = "Buscar Usuario...";
            // 
            // LStatus
            // 
            this.LStatus.AutoSize = true;
            this.LStatus.Location = new System.Drawing.Point(162, 51);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(40, 13);
            this.LStatus.TabIndex = 6;
            this.LStatus.Text = "Estado";
            // 
            // BNewMember
            // 
            this.BNewMember.BackColor = System.Drawing.Color.Coral;
            this.BNewMember.FlatAppearance.BorderSize = 0;
            this.BNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNewMember.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BNewMember.Location = new System.Drawing.Point(635, 66);
            this.BNewMember.Name = "BNewMember";
            this.BNewMember.Size = new System.Drawing.Size(92, 23);
            this.BNewMember.TabIndex = 8;
            this.BNewMember.Text = "Nuevo Usuario";
            this.BNewMember.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.LTituloUserManagment);
            this.panel1.Controls.Add(this.BNewMember);
            this.panel1.Controls.Add(this.TSearch);
            this.panel1.Controls.Add(this.CBStatus);
            this.panel1.Controls.Add(this.LStatus);
            this.panel1.Controls.Add(this.BFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 100);
            this.panel1.TabIndex = 9;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            // 
            // usersManagnent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BoardMember);
            this.Controls.Add(this.panel1);
            this.Name = "usersManagnent";
            this.Size = new System.Drawing.Size(762, 550);
            ((System.ComponentModel.ISupportInitialize)(this.BoardMember)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LTituloUserManagment;
        private System.Windows.Forms.DataGridView BoardMember;
        private System.Windows.Forms.ComboBox CBStatus;
        private System.Windows.Forms.Button BFilter;
        private System.Windows.Forms.TextBox TSearch;
        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.Label LMembership;
        private System.Windows.Forms.Button BNewMember;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
    }
}
