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
            this.LTilteSupplier = new System.Windows.Forms.Label();
            this.BoardSupplier = new System.Windows.Forms.DataGridView();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.BFilter = new System.Windows.Forms.Button();
            this.TSearchSupplier = new System.Windows.Forms.TextBox();
            this.LStatus = new System.Windows.Forms.Label();
            this.BNewSupplier = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BNewPurchase = new System.Windows.Forms.Button();
            this.BSearchPurcharse = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BoardSupplier)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LTilteSupplier
            // 
            this.LTilteSupplier.AutoSize = true;
            this.LTilteSupplier.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTilteSupplier.Location = new System.Drawing.Point(11, 13);
            this.LTilteSupplier.Name = "LTilteSupplier";
            this.LTilteSupplier.Size = new System.Drawing.Size(130, 22);
            this.LTilteSupplier.TabIndex = 0;
            this.LTilteSupplier.Text = "Proveedores";
            // 
            // BoardSupplier
            // 
            this.BoardSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BoardSupplier.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.BoardSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BoardSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.cuit,
            this.typeSupplier,
            this.email,
            this.phone,
            this.status,
            this.Actions});
            this.BoardSupplier.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.BoardSupplier.Location = new System.Drawing.Point(0, 100);
            this.BoardSupplier.Name = "BoardSupplier";
            this.BoardSupplier.Size = new System.Drawing.Size(762, 149);
            this.BoardSupplier.TabIndex = 1;
            // 
            // CBStatus
            // 
            this.CBStatus.FormattingEnabled = true;
            this.CBStatus.Items.AddRange(new object[] {
            "Abierta",
            "Recibida",
            "Cancelada"});
            this.CBStatus.Location = new System.Drawing.Point(165, 329);
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
            this.BFilter.Location = new System.Drawing.Point(166, 66);
            this.BFilter.Name = "BFilter";
            this.BFilter.Size = new System.Drawing.Size(84, 20);
            this.BFilter.TabIndex = 4;
            this.BFilter.Text = "Filtrar";
            this.BFilter.UseVisualStyleBackColor = false;
            // 
            // TSearchSupplier
            // 
            this.TSearchSupplier.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TSearchSupplier.Location = new System.Drawing.Point(15, 66);
            this.TSearchSupplier.Name = "TSearchSupplier";
            this.TSearchSupplier.Size = new System.Drawing.Size(145, 20);
            this.TSearchSupplier.TabIndex = 5;
            this.TSearchSupplier.Text = "Buscar Proveedor...";
            // 
            // LStatus
            // 
            this.LStatus.AutoSize = true;
            this.LStatus.Location = new System.Drawing.Point(162, 308);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(40, 13);
            this.LStatus.TabIndex = 6;
            this.LStatus.Text = "Estado";
            // 
            // BNewSupplier
            // 
            this.BNewSupplier.BackColor = System.Drawing.Color.Coral;
            this.BNewSupplier.FlatAppearance.BorderSize = 0;
            this.BNewSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNewSupplier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BNewSupplier.Location = new System.Drawing.Point(607, 66);
            this.BNewSupplier.Name = "BNewSupplier";
            this.BNewSupplier.Size = new System.Drawing.Size(120, 20);
            this.BNewSupplier.TabIndex = 8;
            this.BNewSupplier.Text = "Nuevo Proveedor";
            this.BNewSupplier.UseVisualStyleBackColor = false;
            this.BNewSupplier.Click += new System.EventHandler(this.BNewMember_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.LTilteSupplier);
            this.panel1.Controls.Add(this.BNewSupplier);
            this.panel1.Controls.Add(this.TSearchSupplier);
            this.panel1.Controls.Add(this.BFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 100);
            this.panel1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(0, 354);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(762, 196);
            this.dataGridView1.TabIndex = 10;
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
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(292, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 20);
            this.button2.TabIndex = 9;
            this.button2.Text = "Filtrar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idOrden";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Orden";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "supplier";
            this.dataGridViewTextBoxColumn2.HeaderText = "Proveedor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "status";
            this.dataGridViewTextBoxColumn5.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Actions";
            this.dataGridViewTextBoxColumn6.HeaderText = "Acciones";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
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
            // Actions
            // 
            this.Actions.DataPropertyName = "Actions";
            this.Actions.HeaderText = "Acciones";
            this.Actions.Name = "Actions";
            // 
            // SupplierView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BSearchPurcharse);
            this.Controls.Add(this.BNewPurchase);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BoardSupplier);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LStatus);
            this.Controls.Add(this.CBStatus);
            this.Name = "SupplierView";
            this.Size = new System.Drawing.Size(762, 550);
            ((System.ComponentModel.ISupportInitialize)(this.BoardSupplier)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTilteSupplier;
        private System.Windows.Forms.DataGridView BoardSupplier;
        private System.Windows.Forms.ComboBox CBStatus;
        private System.Windows.Forms.Button BFilter;
        private System.Windows.Forms.TextBox TSearchSupplier;
        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.Button BNewSupplier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BNewPurchase;
        private System.Windows.Forms.TextBox BSearchPurcharse;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actions;
    }
}
