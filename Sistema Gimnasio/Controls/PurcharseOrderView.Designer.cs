namespace Sistema_Gimnasio
{
    partial class PurcharseOrderView
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
            this.LPurcharseOrder = new System.Windows.Forms.Label();
            this.BoardSupplier = new System.Windows.Forms.DataGridView();
            this.BFilter = new System.Windows.Forms.Button();
            this.TOrdPurcharse = new System.Windows.Forms.TextBox();
            this.BNewSupplier = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Id_Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BoardSupplier)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LPurcharseOrder
            // 
            this.LPurcharseOrder.AutoSize = true;
            this.LPurcharseOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.LPurcharseOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.LPurcharseOrder.Location = new System.Drawing.Point(15, 12);
            this.LPurcharseOrder.Name = "LPurcharseOrder";
            this.LPurcharseOrder.Size = new System.Drawing.Size(118, 25);
            this.LPurcharseOrder.TabIndex = 0;
            this.LPurcharseOrder.Text = "Proveedores";
            // 
            // BoardSupplier
            // 
            this.BoardSupplier.AllowUserToAddRows = false;
            this.BoardSupplier.AllowUserToDeleteRows = false;
            this.BoardSupplier.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.BoardSupplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BoardSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BoardSupplier.BackgroundColor = System.Drawing.Color.White;
            this.BoardSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoardSupplier.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BoardSupplier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.BoardSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BoardSupplier.ColumnHeadersHeight = 38;
            this.BoardSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BoardSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Orden,
            this.Supplier,
            this.Date,
            this.Status,
            this.Actions});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BoardSupplier.DefaultCellStyle = dataGridViewCellStyle3;
            this.BoardSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoardSupplier.EnableHeadersVisualStyles = false;
            this.BoardSupplier.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.BoardSupplier.Location = new System.Drawing.Point(0, 100);
            this.BoardSupplier.Name = "BoardSupplier";
            this.BoardSupplier.RowHeadersVisible = false;
            this.BoardSupplier.RowTemplate.Height = 36;
            this.BoardSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BoardSupplier.Size = new System.Drawing.Size(762, 450);
            this.BoardSupplier.TabIndex = 1;
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
            this.panel1.Controls.Add(this.LPurcharseOrder);
            this.panel1.Controls.Add(this.BNewSupplier);
            this.panel1.Controls.Add(this.TOrdPurcharse);
            this.panel1.Controls.Add(this.BFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 100);
            this.panel1.TabIndex = 2;
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
            // Actions
            // 
            this.Actions.DataPropertyName = "Actions";
            this.Actions.HeaderText = "Acciones";
            this.Actions.Name = "Actions";
            // 
            // PurcharseOrderView
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.BoardSupplier);
            this.Controls.Add(this.panel1);
            this.Name = "PurcharseOrderView";
            this.Size = new System.Drawing.Size(762, 550);
            ((System.ComponentModel.ISupportInitialize)(this.BoardSupplier)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Label LPurcharseOrder;
        private System.Windows.Forms.DataGridView BoardSupplier;
        private System.Windows.Forms.Button BFilter;
        private System.Windows.Forms.TextBox TOrdPurcharse;
        private System.Windows.Forms.Button BNewSupplier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actions;
    }
}
