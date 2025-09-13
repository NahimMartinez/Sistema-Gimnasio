namespace Sistema_Gimnasio
{
    partial class Inventory
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
            this.LTituloInventaryManagment = new System.Windows.Forms.Label();
            this.BoardInventory = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.colView = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.BFilter = new System.Windows.Forms.Button();
            this.TSearch = new System.Windows.Forms.TextBox();
            this.LStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.LCategoria = new System.Windows.Forms.Label();
            this.BNewItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BoardInventory)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LTituloInventaryManagment
            // 
            this.LTituloInventaryManagment.AutoSize = true;
            this.LTituloInventaryManagment.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.LTituloInventaryManagment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.LTituloInventaryManagment.Location = new System.Drawing.Point(14, 12);
            this.LTituloInventaryManagment.Name = "LTituloInventaryManagment";
            this.LTituloInventaryManagment.Size = new System.Drawing.Size(249, 32);
            this.LTituloInventaryManagment.TabIndex = 0;
            this.LTituloInventaryManagment.Text = "Gestión de Inventario";
            // 
            // BoardInventory
            // 
            this.BoardInventory.AllowUserToAddRows = false;
            this.BoardInventory.AllowUserToDeleteRows = false;
            this.BoardInventory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.BoardInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BoardInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BoardInventory.BackgroundColor = System.Drawing.Color.White;
            this.BoardInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoardInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BoardInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BoardInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BoardInventory.ColumnHeadersHeight = 38;
            this.BoardInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BoardInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.cantidad,
            this.fecha_ingreso,
            this.categoria,
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
            this.BoardInventory.DefaultCellStyle = dataGridViewCellStyle3;
            this.BoardInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoardInventory.EnableHeadersVisualStyles = false;
            this.BoardInventory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.BoardInventory.Location = new System.Drawing.Point(0, 100);
            this.BoardInventory.MultiSelect = false;
            this.BoardInventory.Name = "BoardInventory";
            this.BoardInventory.ReadOnly = true;
            this.BoardInventory.RowHeadersVisible = false;
            this.BoardInventory.RowHeadersWidth = 51;
            this.BoardInventory.RowTemplate.Height = 36;
            this.BoardInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BoardInventory.Size = new System.Drawing.Size(762, 450);
            this.BoardInventory.TabIndex = 1;
            // 
            // name
            // 
            this.name.DataPropertyName = "nombre";
            this.name.HeaderText = "Nombre";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // fecha_ingreso
            // 
            this.fecha_ingreso.DataPropertyName = "fecha_ingreso";
            this.fecha_ingreso.HeaderText = "Fecha Ingreso";
            this.fecha_ingreso.MinimumWidth = 6;
            this.fecha_ingreso.Name = "fecha_ingreso";
            this.fecha_ingreso.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "categoria";
            this.categoria.HeaderText = "Categoría";
            this.categoria.MinimumWidth = 6;
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
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
            "Inactivo"});
            this.CBStatus.Location = new System.Drawing.Point(168, 66);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(130, 28);
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
            this.TSearch.Size = new System.Drawing.Size(144, 27);
            this.TSearch.TabIndex = 5;
            this.TSearch.Text = "Buscar item...";
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
            this.panel1.Controls.Add(this.CBCategoria);
            this.panel1.Controls.Add(this.LCategoria);
            this.panel1.Controls.Add(this.LTituloInventaryManagment);
            this.panel1.Controls.Add(this.BNewItem);
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
            // CBCategoria
            // 
            this.CBCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCategoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Items.AddRange(new object[] {
            "Todos",
            "Maquinas",
            "Mancuernas",
            "Barras",
            "Discos",
            "Accesorios"});
            this.CBCategoria.Location = new System.Drawing.Point(304, 66);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(130, 28);
            this.CBCategoria.TabIndex = 11;
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LCategoria.Location = new System.Drawing.Point(301, 48);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(74, 20);
            this.LCategoria.TabIndex = 12;
            this.LCategoria.Text = "Categoría";
            // 
            // BNewItem
            // 
            this.BNewItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BNewItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            this.BNewItem.FlatAppearance.BorderSize = 0;
            this.BNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNewItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BNewItem.ForeColor = System.Drawing.Color.White;
            this.BNewItem.Location = new System.Drawing.Point(650, 64);
            this.BNewItem.Name = "BNewItem";
            this.BNewItem.Size = new System.Drawing.Size(100, 26);
            this.BNewItem.TabIndex = 9;
            this.BNewItem.Text = "Nuevo item";
            this.BNewItem.UseVisualStyleBackColor = false;
            this.BNewItem.Click += new System.EventHandler(this.BNewItem_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.BoardInventory);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(762, 550);
            ((System.ComponentModel.ISupportInitialize)(this.BoardInventory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LTituloInventaryManagment;
        private System.Windows.Forms.DataGridView BoardInventory;
        private System.Windows.Forms.ComboBox CBStatus;
        private System.Windows.Forms.Button BFilter;
        private System.Windows.Forms.TextBox TSearch;
        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BNewItem;
        private System.Windows.Forms.ComboBox CBCategoria;
        private System.Windows.Forms.Label LCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewImageColumn colEdit;
        private System.Windows.Forms.DataGridViewImageColumn colView;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
    }
}