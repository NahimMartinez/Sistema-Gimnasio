namespace Sistema_Gimnasio
{
    partial class inventario
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
            this.LTituloInventaryManagment = new System.Windows.Forms.Label();
            this.BoardMember = new System.Windows.Forms.DataGridView();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.BFilter = new System.Windows.Forms.Button();
            this.TSearch = new System.Windows.Forms.TextBox();
            this.LStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BNewItem = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BoardMember)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LTituloInventaryManagment
            // 
            this.LTituloInventaryManagment.AutoSize = true;
            this.LTituloInventaryManagment.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloInventaryManagment.Location = new System.Drawing.Point(11, 13);
            this.LTituloInventaryManagment.Name = "LTituloInventaryManagment";
            this.LTituloInventaryManagment.Size = new System.Drawing.Size(208, 22);
            this.LTituloInventaryManagment.TabIndex = 0;
            this.LTituloInventaryManagment.Text = "Gestión de Inventario";
            // 
            // BoardMember
            // 
            this.BoardMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BoardMember.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.BoardMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BoardMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.cantidad,
            this.fecha_ingreso,
            this.categoria,
            this.status});
            this.BoardMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoardMember.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.BoardMember.Location = new System.Drawing.Point(0, 100);
            this.BoardMember.Name = "BoardMember";
            this.BoardMember.Size = new System.Drawing.Size(762, 450);
            this.BoardMember.TabIndex = 1;
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
            this.TSearch.Text = "Buscar Item...";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.BNewItem);
            this.panel1.Controls.Add(this.LTituloInventaryManagment);
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
            // BNewItem
            // 
            this.BNewItem.BackColor = System.Drawing.Color.Coral;
            this.BNewItem.FlatAppearance.BorderSize = 0;
            this.BNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNewItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BNewItem.Location = new System.Drawing.Point(629, 65);
            this.BNewItem.Name = "BNewItem";
            this.BNewItem.Size = new System.Drawing.Size(92, 23);
            this.BNewItem.TabIndex = 9;
            this.BNewItem.Text = "Nuevo Item";
            this.BNewItem.UseVisualStyleBackColor = false;
            this.BNewItem.Click += new System.EventHandler(this.BNewItem_Click);
            // 
            // name
            // 
            this.name.DataPropertyName = "nombre";
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // fecha_ingreso
            // 
            this.fecha_ingreso.HeaderText = "Fecha Ingreso";
            this.fecha_ingreso.Name = "fecha_ingreso";
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoría";
            this.categoria.Name = "categoria";
            // 
            // status
            // 
            this.status.DataPropertyName = "estado";
            this.status.HeaderText = "Estado";
            this.status.Name = "status";
            // 
            // inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BoardMember);
            this.Controls.Add(this.panel1);
            this.Name = "inventario";
            this.Size = new System.Drawing.Size(762, 550);
            ((System.ComponentModel.ISupportInitialize)(this.BoardMember)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LTituloInventaryManagment;
        private System.Windows.Forms.DataGridView BoardMember;
        private System.Windows.Forms.ComboBox CBStatus;
        private System.Windows.Forms.Button BFilter;
        private System.Windows.Forms.TextBox TSearch;
        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.Label LMembership;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Button BNewItem;
    }
}
