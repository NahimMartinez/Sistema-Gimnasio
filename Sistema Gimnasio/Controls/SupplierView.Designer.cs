namespace Sistema_Gimnasio
{
    partial class SupplierView
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
            this.LTilteSupplier = new System.Windows.Forms.Label();
            this.BoardSupplier = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.colView = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.BFilter = new System.Windows.Forms.Button();
            this.TSearchSupplier = new System.Windows.Forms.TextBox();
            this.BNewSupplier = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BNewPurchase = new System.Windows.Forms.Button();
            this.BSearchPurcharse = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BoardSupplier)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LTilteSupplier
            // 
            this.LTilteSupplier.AutoSize = true;
            this.LTilteSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.LTilteSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.LTilteSupplier.Location = new System.Drawing.Point(15, 12);
            this.LTilteSupplier.Name = "LTilteSupplier";
            this.LTilteSupplier.Size = new System.Drawing.Size(118, 25);
            this.LTilteSupplier.TabIndex = 0;
            this.LTilteSupplier.Text = "Proveedores";
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
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BoardSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BoardSupplier.ColumnHeadersHeight = 38;
            this.BoardSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BoardSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.cuit,
            this.typeSupplier,
            this.email,
            this.phone,
            this.status,
            this.colEdit,
            this.colView,
            this.colDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            // 
            // cuit
            // 
            this.cuit.DataPropertyName = "cuit";
            this.cuit.HeaderText = "CUIT";
            this.cuit.Name = "cuit";
            // 
            // typeSupplier
            // 
            this.typeSupplier.DataPropertyName = "typeSupplier";
            this.typeSupplier.HeaderText = "Rubro";
            this.typeSupplier.Name = "typeSupplier";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Telefono";
            this.phone.Name = "phone";
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Estado";
            this.status.Name = "status";            
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
            // TSearchSupplier
            //
            this.TSearchSupplier.BackColor = System.Drawing.Color.White;
            this.TSearchSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TSearchSupplier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TSearchSupplier.ForeColor = System.Drawing.Color.Gray;
            this.TSearchSupplier.Location = new System.Drawing.Point(15, 66);
            this.TSearchSupplier.Name = "TSearchSupplier";
            this.TSearchSupplier.Size = new System.Drawing.Size(145, 23);
            this.TSearchSupplier.TabIndex = 2;
            this.TSearchSupplier.Text = "Buscar Proveedor...";
            // 
            // BNewSupplier
            // 
            this.BNewSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            this.BNewSupplier.FlatAppearance.BorderSize = 0;
            this.BNewSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNewSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BNewSupplier.ForeColor = System.Drawing.Color.White;
            this.BNewSupplier.Location = new System.Drawing.Point(607, 64);
            this.BNewSupplier.Name = "BNewSupplier";
            this.BNewSupplier.Size = new System.Drawing.Size(120, 26);
            this.BNewSupplier.TabIndex = 1;
            this.BNewSupplier.Text = "Nuevo Proveedor";
            this.BNewSupplier.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LTilteSupplier);
            this.panel1.Controls.Add(this.BNewSupplier);
            this.panel1.Controls.Add(this.TSearchSupplier);
            this.panel1.Controls.Add(this.BFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 100);
            this.panel1.TabIndex = 2;
            // 
            // BNewPurchase
            // 
            this.BNewPurchase.BackColor = System.Drawing.Color.Coral;
            this.BNewPurchase.FlatAppearance.BorderSize = 0;
            this.BNewPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNewPurchase.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BNewPurchase.Location = new System.Drawing.Point(607, 325);
            this.BNewPurchase.Name = "BNewPurchase";
            this.BNewPurchase.Size = new System.Drawing.Size(120, 23);
            this.BNewPurchase.TabIndex = 9;
            this.BNewPurchase.Text = "Orden de compra";
            this.BNewPurchase.UseVisualStyleBackColor = false;
            // 
            // BSearchPurcharse
            // 
            this.BSearchPurcharse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BSearchPurcharse.Location = new System.Drawing.Point(15, 330);
            this.BSearchPurcharse.Name = "BSearchPurcharse";
            this.BSearchPurcharse.Size = new System.Drawing.Size(145, 20);
            this.BSearchPurcharse.TabIndex = 9;
            this.BSearchPurcharse.Text = "Buscar Orden de Compra...";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // SupplierView
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.BoardSupplier);
            this.Controls.Add(this.panel1);
            this.Name = "SupplierView";
            this.Size = new System.Drawing.Size(762, 550);
            ((System.ComponentModel.ISupportInitialize)(this.BoardSupplier)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LTilteSupplier;
        private System.Windows.Forms.DataGridView BoardSupplier;
        private System.Windows.Forms.Button BFilter;
        private System.Windows.Forms.TextBox TSearchSupplier;
        private System.Windows.Forms.Button BNewSupplier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BNewPurchase;
        private System.Windows.Forms.TextBox BSearchPurcharse;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewImageColumn colEdit;
        private System.Windows.Forms.DataGridViewImageColumn colView;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
    }
}
