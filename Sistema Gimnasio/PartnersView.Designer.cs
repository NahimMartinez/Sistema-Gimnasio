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
            this.HighDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.CBMembership = new System.Windows.Forms.ComboBox();
            this.BFilter = new System.Windows.Forms.Button();
            this.TSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BoardMember)).BeginInit();
            this.SuspendLayout();
            // 
            // LTiltePartne
            // 
            this.LTiltePartne.AutoSize = true;
            this.LTiltePartne.Location = new System.Drawing.Point(11, 21);
            this.LTiltePartne.Name = "LTiltePartne";
            this.LTiltePartne.Size = new System.Drawing.Size(93, 13);
            this.LTiltePartne.TabIndex = 0;
            this.LTiltePartne.Text = "Gestión de Socios";
            this.LTiltePartne.Click += new System.EventHandler(this.LTiltePartne_Click);
            // 
            // BoardMember
            // 
            this.BoardMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BoardMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.dni,
            this.contact,
            this.membership,
            this.HighDate,
            this.status});
            this.BoardMember.Location = new System.Drawing.Point(14, 144);
            this.BoardMember.Name = "BoardMember";
            this.BoardMember.Size = new System.Drawing.Size(732, 387);
            this.BoardMember.TabIndex = 1;
            // 
            // name
            // 
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            // 
            // contact
            // 
            this.contact.HeaderText = "Contacto";
            this.contact.Name = "contact";
            // 
            // membership
            // 
            this.membership.HeaderText = "Membresia";
            this.membership.Name = "membership";
            // 
            // HighDate
            // 
            this.HighDate.HeaderText = "Fecha Alta";
            this.HighDate.Name = "HighDate";
            // 
            // status
            // 
            this.status.HeaderText = "Estado";
            this.status.Name = "status";
            // 
            // CBStatus
            // 
            this.CBStatus.FormattingEnabled = true;
            this.CBStatus.Location = new System.Drawing.Point(165, 118);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(121, 21);
            this.CBStatus.TabIndex = 2;
            this.CBStatus.Text = "Todos";
            // 
            // CBMembership
            // 
            this.CBMembership.FormattingEnabled = true;
            this.CBMembership.Location = new System.Drawing.Point(292, 118);
            this.CBMembership.Name = "CBMembership";
            this.CBMembership.Size = new System.Drawing.Size(121, 21);
            this.CBMembership.TabIndex = 3;
            this.CBMembership.Tag = "";
            this.CBMembership.Text = "Todos";
            // 
            // BFilter
            // 
            this.BFilter.Location = new System.Drawing.Point(419, 118);
            this.BFilter.Name = "BFilter";
            this.BFilter.Size = new System.Drawing.Size(84, 20);
            this.BFilter.TabIndex = 4;
            this.BFilter.Text = "Filtrar";
            this.BFilter.UseVisualStyleBackColor = true;
            // 
            // TSearch
            // 
            this.TSearch.Location = new System.Drawing.Point(14, 118);
            this.TSearch.Name = "TSearch";
            this.TSearch.Size = new System.Drawing.Size(145, 20);
            this.TSearch.TabIndex = 5;
            this.TSearch.Text = "Buscar Socio...";
            // 
            // PartnersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TSearch);
            this.Controls.Add(this.BFilter);
            this.Controls.Add(this.CBMembership);
            this.Controls.Add(this.CBStatus);
            this.Controls.Add(this.BoardMember);
            this.Controls.Add(this.LTiltePartne);
            this.Name = "PartnersView";
            this.Size = new System.Drawing.Size(762, 550);
            ((System.ComponentModel.ISupportInitialize)(this.BoardMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTiltePartne;
        private System.Windows.Forms.DataGridView BoardMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn membership;
        private System.Windows.Forms.DataGridViewTextBoxColumn HighDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.ComboBox CBStatus;
        private System.Windows.Forms.ComboBox CBMembership;
        private System.Windows.Forms.Button BFilter;
        private System.Windows.Forms.TextBox TSearch;
    }
}
