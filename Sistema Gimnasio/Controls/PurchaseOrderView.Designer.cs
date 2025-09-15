namespace Sistema_Gimnasio
{
    partial class PurchaseOrderView
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
            this.LOrderPurcharse = new System.Windows.Forms.Label();
            this.BoardOrderP = new System.Windows.Forms.DataGridView();
            this.Id_Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BFilter = new System.Windows.Forms.Button();
            this.TOrdPurcharse = new System.Windows.Forms.TextBox();
            this.BNewSupplier = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.colView = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BoardOrderP)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LOrderPurcharse
            // 
            this.LOrderPurcharse.AutoSize = true;
            this.LOrderPurcharse.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.LOrderPurcharse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.LOrderPurcharse.Location = new System.Drawing.Point(15, 12);
            this.LOrderPurcharse.Name = "LOrderPurcharse";
            this.LOrderPurcharse.Size = new System.Drawing.Size(172, 25);
            this.LOrderPurcharse.TabIndex = 0;
            this.LOrderPurcharse.Text = "Orden de Compras";
            // 
            // BoardOrderP
            // 
            this.BoardOrderP.AllowUserToAddRows = false;
            this.BoardOrderP.AllowUserToDeleteRows = false;
            this.BoardOrderP.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.BoardOrderP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BoardOrderP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BoardOrderP.BackgroundColor = System.Drawing.Color.White;
            this.BoardOrderP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoardOrderP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BoardOrderP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.BoardOrderP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BoardOrderP.ColumnHeadersHeight = 38;
            this.BoardOrderP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BoardOrderP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Orden,
            this.Supplier,
            this.Date,
            this.Status,
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
            this.BoardOrderP.DefaultCellStyle = dataGridViewCellStyle3;
            this.BoardOrderP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoardOrderP.EnableHeadersVisualStyles = false;
            this.BoardOrderP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.BoardOrderP.Location = new System.Drawing.Point(0, 100);
            this.BoardOrderP.Name = "BoardOrderP";
            this.BoardOrderP.RowHeadersVisible = false;
            this.BoardOrderP.RowTemplate.Height = 36;
            this.BoardOrderP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BoardOrderP.Size = new System.Drawing.Size(762, 450);
            this.BoardOrderP.TabIndex = 1;
            // 
            // Id_Orden
            // 
            this.Id_Orden.HeaderText = "Id Orden";
            this.Id_Orden.Name = "Id_Orden";
            // 
            // Supplier
            // 
            this.Supplier.HeaderText = "Proveedor";
            this.Supplier.Name = "Supplier";
            // 
            // Date
            // 
            this.Date.HeaderText = "Fecha ";
            this.Date.Name = "Date";
            // 
            // Status
            // 
            this.Status.HeaderText = "Estado";
            this.Status.Name = "Status";            
            // 
            // BFilter
            // 
            this.BFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.BFilter.FlatAppearance.BorderSize = 0;
            this.BFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BFilter.ForeColor = System.Drawing.Color.White;
            this.BFilter.Location = new System.Drawing.Point(166, 66);
            this.BFilter.Name = "BFilter";
            this.BFilter.Size = new System.Drawing.Size(84, 26);
            this.BFilter.TabIndex = 4;
            this.BFilter.Text = "Filtrar";
            this.BFilter.UseVisualStyleBackColor = false;
            // 
            // TOrdPurcharse
            // 
            this.TOrdPurcharse.BackColor = System.Drawing.Color.White;
            this.TOrdPurcharse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TOrdPurcharse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TOrdPurcharse.ForeColor = System.Drawing.Color.Gray;
            this.TOrdPurcharse.Location = new System.Drawing.Point(15, 66);
            this.TOrdPurcharse.Name = "TOrdPurcharse";
            this.TOrdPurcharse.Size = new System.Drawing.Size(145, 23);
            this.TOrdPurcharse.TabIndex = 2;
            this.TOrdPurcharse.Text = "Buscar orden de compra...";
            // 
            // BNewSupplier
            // 
            this.BNewSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            this.BNewSupplier.FlatAppearance.BorderSize = 0;
            this.BNewSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNewSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BNewSupplier.ForeColor = System.Drawing.Color.White;
            this.BNewSupplier.Location = new System.Drawing.Point(574, 64);
            this.BNewSupplier.Name = "BNewSupplier";
            this.BNewSupplier.Size = new System.Drawing.Size(153, 26);
            this.BNewSupplier.TabIndex = 1;
            this.BNewSupplier.Text = "Nueva Orden de Compra";
            this.BNewSupplier.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LOrderPurcharse);
            this.panel1.Controls.Add(this.BNewSupplier);
            this.panel1.Controls.Add(this.TOrdPurcharse);
            this.panel1.Controls.Add(this.BFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 100);
            this.panel1.TabIndex = 2;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEdit.Width = 50;
            // 
            // colView
            // 
            this.colView.HeaderText = "";
            this.colView.Name = "colView";
            this.colView.ReadOnly = true;
            this.colView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colView.Width = 50;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDelete.Width = 50;
            // 
            // PurcharseOrderView
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.BoardOrderP);
            this.Controls.Add(this.panel1);
            this.Name = "PurcharseOrderView";
            this.Size = new System.Drawing.Size(762, 550);
            ((System.ComponentModel.ISupportInitialize)(this.BoardOrderP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Label LOrderPurcharse;
        private System.Windows.Forms.DataGridView BoardOrderP;
        private System.Windows.Forms.Button BFilter;
        private System.Windows.Forms.TextBox TOrdPurcharse;
        private System.Windows.Forms.Button BNewSupplier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewImageColumn colEdit;
        private System.Windows.Forms.DataGridViewImageColumn colView;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
    }
}
