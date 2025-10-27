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
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.colView = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.typeSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TSearchSupplier = new System.Windows.Forms.TextBox();
            this.BNewSupplier = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.LStatus = new System.Windows.Forms.Label();
            this.BSearchPurcharse = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnNextPage = new FontAwesome.Sharp.IconButton();
            this.btnPrevPage = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.BoardSupplier)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LTilteSupplier
            // 
            this.LTilteSupplier.AutoSize = true;
            this.LTilteSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.LTilteSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.LTilteSupplier.Location = new System.Drawing.Point(15, 12);
            this.LTilteSupplier.Name = "LTilteSupplier";
            this.LTilteSupplier.Size = new System.Drawing.Size(149, 32);
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
            this.BoardSupplier.RowHeadersWidth = 51;
            this.BoardSupplier.RowTemplate.Height = 36;
            this.BoardSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BoardSupplier.Size = new System.Drawing.Size(762, 450);
            this.BoardSupplier.TabIndex = 1;
            // 
            // name
            // 
            this.name.DataPropertyName = "Nombre";
            this.name.HeaderText = "Nombre";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // cuit
            // 
            this.cuit.DataPropertyName = "Cuit";
            this.cuit.HeaderText = "CUIT";
            this.cuit.MinimumWidth = 6;
            this.cuit.Name = "cuit";
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            // 
            // phone
            // 
            this.phone.DataPropertyName = "Telefono";
            this.phone.HeaderText = "Telefono";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            // 
            // status
            // 
            this.status.DataPropertyName = "Estado";
            this.status.HeaderText = "Estado";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
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
            // typeSupplier
            // 
            this.typeSupplier.MinimumWidth = 6;
            this.typeSupplier.Name = "typeSupplier";
            this.typeSupplier.Width = 125;
            // 
            // TSearchSupplier
            // 
            this.TSearchSupplier.BackColor = System.Drawing.Color.White;
            this.TSearchSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TSearchSupplier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TSearchSupplier.ForeColor = System.Drawing.Color.Gray;
            this.TSearchSupplier.Location = new System.Drawing.Point(15, 66);
            this.TSearchSupplier.Name = "TSearchSupplier";
            this.TSearchSupplier.Size = new System.Drawing.Size(145, 27);
            this.TSearchSupplier.TabIndex = 2;
            this.TSearchSupplier.Text = "Buscar proveedor...";
            // 
            // BNewSupplier
            // 
            this.BNewSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BNewSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            this.BNewSupplier.FlatAppearance.BorderSize = 0;
            this.BNewSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNewSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BNewSupplier.ForeColor = System.Drawing.Color.White;
            this.BNewSupplier.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BNewSupplier.IconColor = System.Drawing.Color.White;
            this.BNewSupplier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BNewSupplier.IconSize = 20;
            this.BNewSupplier.Location = new System.Drawing.Point(579, 65);
            this.BNewSupplier.Name = "BNewSupplier";
            this.BNewSupplier.Size = new System.Drawing.Size(169, 26);
            this.BNewSupplier.TabIndex = 1;
            this.BNewSupplier.Text = "Nuevo Proveedor";
            this.BNewSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BNewSupplier.UseVisualStyleBackColor = false;
            this.BNewSupplier.Click += new System.EventHandler(this.BNewSupplier_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.CBStatus);
            this.panel1.Controls.Add(this.LStatus);
            this.panel1.Controls.Add(this.LTilteSupplier);
            this.panel1.Controls.Add(this.BNewSupplier);
            this.panel1.Controls.Add(this.TSearchSupplier);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 100);
            this.panel1.TabIndex = 2;
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
            this.CBStatus.Location = new System.Drawing.Point(166, 65);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(130, 28);
            this.CBStatus.TabIndex = 7;
            // 
            // LStatus
            // 
            this.LStatus.AutoSize = true;
            this.LStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LStatus.Location = new System.Drawing.Point(163, 47);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(54, 20);
            this.LStatus.TabIndex = 8;
            this.LStatus.Text = "Estado";
            // 
            // BSearchPurcharse
            // 
            this.BSearchPurcharse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BSearchPurcharse.Location = new System.Drawing.Point(15, 330);
            this.BSearchPurcharse.Name = "BSearchPurcharse";
            this.BSearchPurcharse.Size = new System.Drawing.Size(145, 22);
            this.BSearchPurcharse.TabIndex = 9;
            this.BSearchPurcharse.Text = "Buscar Orden de Compra...";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPageInfo);
            this.panel2.Controls.Add(this.btnNextPage);
            this.panel2.Controls.Add(this.btnPrevPage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 489);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 61);
            this.panel2.TabIndex = 11;
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblPageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.lblPageInfo.Location = new System.Drawing.Point(490, 4);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(196, 41);
            this.lblPageInfo.TabIndex = 12;
            this.lblPageInfo.Text = "Página 1 de 1";
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextPage.BackColor = System.Drawing.Color.White;
            this.btnNextPage.FlatAppearance.BorderSize = 0;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.btnNextPage.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnNextPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNextPage.IconSize = 40;
            this.btnNextPage.Location = new System.Drawing.Point(724, 19);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(26, 26);
            this.btnNextPage.TabIndex = 11;
            this.btnNextPage.UseVisualStyleBackColor = false;
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevPage.BackColor = System.Drawing.Color.White;
            this.btnPrevPage.FlatAppearance.BorderSize = 0;
            this.btnPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevPage.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.btnPrevPage.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnPrevPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrevPage.IconSize = 40;
            this.btnPrevPage.Location = new System.Drawing.Point(692, 19);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(26, 26);
            this.btnPrevPage.TabIndex = 10;
            this.btnPrevPage.UseVisualStyleBackColor = false;
            // 
            // SupplierView
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BoardSupplier);
            this.Controls.Add(this.panel1);
            this.Name = "SupplierView";
            this.Size = new System.Drawing.Size(762, 550);
            ((System.ComponentModel.ISupportInitialize)(this.BoardSupplier)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LTilteSupplier;
        private System.Windows.Forms.DataGridView BoardSupplier;
        private System.Windows.Forms.TextBox TSearchSupplier;
        private FontAwesome.Sharp.IconButton BNewSupplier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox BSearchPurcharse;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewImageColumn colEdit;
        private System.Windows.Forms.DataGridViewImageColumn colView;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
        private System.Windows.Forms.ComboBox CBStatus;
        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPageInfo;
        private FontAwesome.Sharp.IconButton btnNextPage;
        private FontAwesome.Sharp.IconButton btnPrevPage;
    }
}
