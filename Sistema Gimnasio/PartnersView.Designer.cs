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
            this.LTiltePartne = new System.Windows.Forms.Label();
            this.BoardMember = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membership = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.CBMembership = new System.Windows.Forms.ComboBox();
            this.BFilter = new System.Windows.Forms.Button();
            this.TSearch = new System.Windows.Forms.TextBox();
            this.LStatus = new System.Windows.Forms.Label();
            this.LMembership = new System.Windows.Forms.Label();
            this.BNewMember = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BoardMember)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LTiltePartne
            // 
            this.LTiltePartne.AutoSize = true;
            this.LTiltePartne.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTiltePartne.Location = new System.Drawing.Point(11, 13);
            this.LTiltePartne.Name = "LTiltePartne";
            this.LTiltePartne.Size = new System.Drawing.Size(179, 22);
            this.LTiltePartne.TabIndex = 0;
            this.LTiltePartne.Text = "Gestión de Socios";
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
            this.membership,
            this.status,
            this.Actions});
            this.BoardMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoardMember.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.BoardMember.Location = new System.Drawing.Point(0, 100);
            this.BoardMember.Name = "BoardMember";
            this.BoardMember.Size = new System.Drawing.Size(762, 450);
            this.BoardMember.TabIndex = 1;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
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
            this.contact.DataPropertyName = "contact";
            this.contact.HeaderText = "Contacto";
            this.contact.Name = "contact";
            // 
            // membership
            // 
            this.membership.DataPropertyName = "membership";
            this.membership.HeaderText = "Membresia";
            this.membership.Name = "membership";
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Estado";
            this.status.Name = "status";
            // 
            // Actions
            // 
            this.Actions.DataPropertyName = "Actions";
            this.Actions.HeaderText = "Acciones";
            this.Actions.Name = "Actions";
            // 
            // CBStatus
            // 
            this.CBStatus.FormattingEnabled = true;
            this.CBStatus.Location = new System.Drawing.Point(165, 67);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(121, 21);
            this.CBStatus.TabIndex = 2;
            this.CBStatus.Text = "Todos";
            // 
            // CBMembership
            // 
            this.CBMembership.FormattingEnabled = true;
            this.CBMembership.Location = new System.Drawing.Point(292, 67);
            this.CBMembership.Name = "CBMembership";
            this.CBMembership.Size = new System.Drawing.Size(121, 21);
            this.CBMembership.TabIndex = 3;
            this.CBMembership.Tag = "";
            this.CBMembership.Text = "Todos";
            // 
            // BFilter
            // 
            this.BFilter.BackColor = System.Drawing.Color.DodgerBlue;
            this.BFilter.FlatAppearance.BorderSize = 0;
            this.BFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BFilter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BFilter.Location = new System.Drawing.Point(419, 67);
            this.BFilter.Name = "BFilter";
            this.BFilter.Size = new System.Drawing.Size(84, 20);
            this.BFilter.TabIndex = 4;
            this.BFilter.Text = "Filtrar";
            this.BFilter.UseVisualStyleBackColor = false;
            // 
            // TSearch
            // 
            this.TSearch.Location = new System.Drawing.Point(14, 67);
            this.TSearch.Name = "TSearch";
            this.TSearch.Size = new System.Drawing.Size(145, 20);
            this.TSearch.TabIndex = 5;
            this.TSearch.Text = "Buscar Socio...";
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
            // LMembership
            // 
            this.LMembership.AutoSize = true;
            this.LMembership.Location = new System.Drawing.Point(289, 51);
            this.LMembership.Name = "LMembership";
            this.LMembership.Size = new System.Drawing.Size(58, 13);
            this.LMembership.TabIndex = 7;
            this.LMembership.Text = "Membresia";
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
            this.BNewMember.Text = "Nuevo Socio";
            this.BNewMember.UseVisualStyleBackColor = false;
            this.BNewMember.Click += new System.EventHandler(this.BNewMember_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LTiltePartne);
            this.panel1.Controls.Add(this.BNewMember);
            this.panel1.Controls.Add(this.TSearch);
            this.panel1.Controls.Add(this.LMembership);
            this.panel1.Controls.Add(this.CBStatus);
            this.panel1.Controls.Add(this.LStatus);
            this.panel1.Controls.Add(this.CBMembership);
            this.panel1.Controls.Add(this.BFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 100);
            this.panel1.TabIndex = 9;
            // 
            // PartnersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BoardMember);
            this.Controls.Add(this.panel1);
            this.Name = "PartnersView";
            this.Size = new System.Drawing.Size(762, 550);
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
