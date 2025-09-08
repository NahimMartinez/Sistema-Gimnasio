namespace Sistema_Gimnasio
{
    partial class UsersManagment
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
            this.LTituloUserManagment = new System.Windows.Forms.Label();
            this.BoardMember = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.BFilter = new System.Windows.Forms.Button();
            this.TSearch = new System.Windows.Forms.TextBox();
            this.LStatus = new System.Windows.Forms.Label();
            this.BNewUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBRol = new System.Windows.Forms.ComboBox();
            this.LRol = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BoardMember)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LTituloUserManagment
            // 
            this.LTituloUserManagment.AutoSize = true;
            this.LTituloUserManagment.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.LTituloUserManagment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.LTituloUserManagment.Location = new System.Drawing.Point(14, 12);
            this.LTituloUserManagment.Name = "LTituloUserManagment";
            this.LTituloUserManagment.Size = new System.Drawing.Size(181, 25);
            this.LTituloUserManagment.TabIndex = 0;
            this.LTituloUserManagment.Text = "Gestión de Usuarios";
            // 
            // BoardMember
            // 
            this.BoardMember.AllowUserToAddRows = false;
            this.BoardMember.AllowUserToDeleteRows = false;
            this.BoardMember.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.BoardMember.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BoardMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BoardMember.BackgroundColor = System.Drawing.Color.White;
            this.BoardMember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoardMember.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BoardMember.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BoardMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BoardMember.ColumnHeadersHeight = 38;
            this.BoardMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BoardMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.dni,
            this.contact,
            this.usuario,
            this.rol,
            this.status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BoardMember.DefaultCellStyle = dataGridViewCellStyle3;
            this.BoardMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoardMember.EnableHeadersVisualStyles = false;
            this.BoardMember.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
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
            // name
            // 
            this.name.DataPropertyName = "nombre";
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // dni
            // 
            this.dni.DataPropertyName = "dni";
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // contact
            // 
            this.contact.DataPropertyName = "telefono";
            this.contact.HeaderText = "Teléfono";
            this.contact.Name = "contact";
            this.contact.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // rol
            // 
            this.rol.DataPropertyName = "rol";
            this.rol.HeaderText = "Rol";
            this.rol.Name = "rol";
            this.rol.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "estado";
            this.status.HeaderText = "Estado";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // CBStatus
            // 
            this.CBStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CBStatus.FormattingEnabled = true;
            this.CBStatus.Items.AddRange(new object[] {
            "Todos",
            "Activo",
            "Inactivo"});
            this.CBStatus.Location = new System.Drawing.Point(168, 66);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(130, 23);
            this.CBStatus.TabIndex = 2;
            // 
            // BFilter
            // 
            this.BFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
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
            // 
            // TSearch
            // 
            this.TSearch.BackColor = System.Drawing.Color.White;
            this.TSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TSearch.ForeColor = System.Drawing.Color.Gray;
            this.TSearch.Location = new System.Drawing.Point(18, 66);
            this.TSearch.Name = "TSearch";
            this.TSearch.Size = new System.Drawing.Size(144, 23);
            this.TSearch.TabIndex = 5;
            this.TSearch.Text = "Buscar usuario...";
            // 
            // LStatus
            // 
            this.LStatus.AutoSize = true;
            this.LStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LStatus.Location = new System.Drawing.Point(165, 48);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(42, 15);
            this.LStatus.TabIndex = 6;
            this.LStatus.Text = "Estado";
            // 
            // BNewUser
            // 
            this.BNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            this.BNewUser.FlatAppearance.BorderSize = 0;
            this.BNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNewUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BNewUser.ForeColor = System.Drawing.Color.White;
            this.BNewUser.Location = new System.Drawing.Point(650, 64);
            this.BNewUser.Name = "BNewUser";
            this.BNewUser.Size = new System.Drawing.Size(100, 26);
            this.BNewUser.TabIndex = 8;
            this.BNewUser.Text = "Nuevo usuario";
            this.BNewUser.UseVisualStyleBackColor = false;
            this.BNewUser.Click += new System.EventHandler(this.BNewUser_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.CBRol);
            this.panel1.Controls.Add(this.LRol);
            this.panel1.Controls.Add(this.LTituloUserManagment);
            this.panel1.Controls.Add(this.BNewUser);
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
            // CBRol
            // 
            this.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRol.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Items.AddRange(new object[] {
            "Todos",
            "Administrador",
            "Coach",
            "Recepcionista"});
            this.CBRol.Location = new System.Drawing.Point(304, 66);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(130, 23);
            this.CBRol.TabIndex = 10;
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LRol.Location = new System.Drawing.Point(301, 48);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(24, 15);
            this.LRol.TabIndex = 11;
            this.LRol.Text = "Rol";
            // 
            // UsersManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.BoardMember);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "UsersManagment";
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
        private System.Windows.Forms.Button BNewUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.ComboBox CBRol;
        private System.Windows.Forms.Label LRol;
    }
}