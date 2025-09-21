using Presentation;

namespace Sistema_Gimnasio.Forms
{
    partial class AddOrderPurchase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LTitulo = new System.Windows.Forms.Label();
            this.LId = new System.Windows.Forms.Label();
            this.TIdOrden = new System.Windows.Forms.TextBox();
            this.LProveedor = new System.Windows.Forms.Label();
            this.CBProveedor = new System.Windows.Forms.ComboBox();
            this.LFecha = new System.Windows.Forms.Label();
            this.DFecha = new System.Windows.Forms.DateTimePicker();
            this.LEstado = new System.Windows.Forms.Label();
            this.CEstado = new System.Windows.Forms.ComboBox();
            this.DItems = new System.Windows.Forms.DataGridView();
            this.id_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_tipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAddRow = new FontAwesome.Sharp.IconButton();
            this.BRemoveRow = new FontAwesome.Sharp.IconButton();
            this.LTotal = new System.Windows.Forms.Label();
            this.TTotal = new System.Windows.Forms.TextBox();
            this.BSave = new FontAwesome.Sharp.IconButton();
            this.BCancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DItems)).BeginInit();
            this.SuspendLayout();
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LTitulo.Location = new System.Drawing.Point(10, 8);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(144, 21);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Orden de Compra";
            // 
            // LId
            // 
            this.LId.AutoSize = true;
            this.LId.Location = new System.Drawing.Point(12, 39);
            this.LId.Name = "LId";
            this.LId.Size = new System.Drawing.Size(48, 13);
            this.LId.TabIndex = 1;
            this.LId.Text = "id_orden";
            // 
            // TIdOrden
            // 
            this.TIdOrden.Location = new System.Drawing.Point(15, 55);
            this.TIdOrden.Name = "TIdOrden";
            this.TIdOrden.ReadOnly = true;
            this.TIdOrden.Size = new System.Drawing.Size(103, 20);
            this.TIdOrden.TabIndex = 2;
            // 
            // LProveedor
            // 
            this.LProveedor.AutoSize = true;
            this.LProveedor.Location = new System.Drawing.Point(130, 39);
            this.LProveedor.Name = "LProveedor";
            this.LProveedor.Size = new System.Drawing.Size(69, 13);
            this.LProveedor.TabIndex = 3;
            this.LProveedor.Text = "proveedor_id";
            // 
            // CBProveedor
            // 
            this.CBProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBProveedor.FormattingEnabled = true;
            this.CBProveedor.Location = new System.Drawing.Point(133, 55);
            this.CBProveedor.Name = "CBProveedor";
            this.CBProveedor.Size = new System.Drawing.Size(223, 21);
            this.CBProveedor.TabIndex = 0;
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Location = new System.Drawing.Point(367, 39);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(34, 13);
            this.LFecha.TabIndex = 7;
            this.LFecha.Text = "fecha";
            // 
            // DFecha
            // 
            this.DFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DFecha.Location = new System.Drawing.Point(369, 55);
            this.DFecha.Name = "DFecha";
            this.DFecha.Size = new System.Drawing.Size(103, 20);
            this.DFecha.TabIndex = 2;
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.Location = new System.Drawing.Point(488, 39);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(39, 13);
            this.LEstado.TabIndex = 9;
            this.LEstado.Text = "estado";
            // 
            // CEstado
            // 
            this.CEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CEstado.FormattingEnabled = true;
            this.CEstado.Items.AddRange(new object[] {
            "Borrador",
            "Pendiente",
            "Recibida",
            "Cancelada"});
            this.CEstado.Location = new System.Drawing.Point(490, 55);
            this.CEstado.Name = "CEstado";
            this.CEstado.Size = new System.Drawing.Size(129, 21);
            this.CEstado.TabIndex = 3;
            // 
            // DItems
            // 
            this.DItems.AllowUserToAddRows = false;
            this.DItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DItems.BackgroundColor = System.Drawing.Color.White;
            this.DItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_item,
            this.item_tipo,
            this.cantidad,
            this.precio_compra,
            this.subtotal});
            this.DItems.Location = new System.Drawing.Point(15, 95);
            this.DItems.MultiSelect = false;
            this.DItems.Name = "DItems";
            this.DItems.RowHeadersVisible = false;
            this.DItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DItems.Size = new System.Drawing.Size(814, 322);
            this.DItems.TabIndex = 4;
            // 
            // id_item
            // 
            this.id_item.DataPropertyName = "id_item";
            this.id_item.HeaderText = "id_item";
            this.id_item.Name = "id_item";
            this.id_item.Visible = false;
            // 
            // item_tipo
            // 
            this.item_tipo.DataPropertyName = "item_tipo";
            this.item_tipo.HeaderText = "item_tipo";
            this.item_tipo.MinimumWidth = 160;
            this.item_tipo.Name = "item_tipo";
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // precio_compra
            // 
            this.precio_compra.DataPropertyName = "precio_compra";
            this.precio_compra.HeaderText = "precio_compra";
            this.precio_compra.Name = "precio_compra";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // BAddRow
            // 
            this.BAddRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BAddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            this.BAddRow.FlatAppearance.BorderSize = 0;
            this.BAddRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAddRow.ForeColor = System.Drawing.Color.White;
            this.BAddRow.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BAddRow.IconColor = System.Drawing.Color.White;
            this.BAddRow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BAddRow.IconSize = 20;
            this.BAddRow.Location = new System.Drawing.Point(15, 430);
            this.BAddRow.Name = "BAddRow";
            this.BAddRow.Size = new System.Drawing.Size(103, 24);
            this.BAddRow.TabIndex = 5;
            this.BAddRow.Text = "Agregar ítem";
            this.BAddRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BAddRow.UseVisualStyleBackColor = false;
            // 
            // BRemoveRow
            // 
            this.BRemoveRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BRemoveRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.BRemoveRow.FlatAppearance.BorderSize = 0;
            this.BRemoveRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRemoveRow.ForeColor = System.Drawing.Color.White;
            this.BRemoveRow.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.BRemoveRow.IconColor = System.Drawing.Color.White;
            this.BRemoveRow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BRemoveRow.IconSize = 20;
            this.BRemoveRow.Location = new System.Drawing.Point(124, 431);
            this.BRemoveRow.Name = "BRemoveRow";
            this.BRemoveRow.Size = new System.Drawing.Size(134, 24);
            this.BRemoveRow.TabIndex = 6;
            this.BRemoveRow.Text = "Quitar seleccionado";
            this.BRemoveRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BRemoveRow.UseVisualStyleBackColor = false;
            // 
            // LTotal
            // 
            this.LTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LTotal.AutoSize = true;
            this.LTotal.Location = new System.Drawing.Point(508, 436);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(31, 13);
            this.LTotal.TabIndex = 20;
            this.LTotal.Text = "Total";
            // 
            // TTotal
            // 
            this.TTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TTotal.Location = new System.Drawing.Point(541, 433);
            this.TTotal.Name = "TTotal";
            this.TTotal.ReadOnly = true;
            this.TTotal.Size = new System.Drawing.Size(103, 20);
            this.TTotal.TabIndex = 7;
            this.TTotal.Text = "0,00";
            this.TTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BSave
            // 
            this.BSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.BSave.FlatAppearance.BorderSize = 0;
            this.BSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSave.ForeColor = System.Drawing.Color.White;
            this.BSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BSave.IconColor = System.Drawing.Color.White;
            this.BSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BSave.IconSize = 20;
            this.BSave.Location = new System.Drawing.Point(650, 429);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(85, 28);
            this.BSave.TabIndex = 8;
            this.BSave.Text = "Guardar";
            this.BSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BSave.UseVisualStyleBackColor = false;
            // 
            // BCancelar
            // 
            this.BCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.BCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BCancelar.FlatAppearance.BorderSize = 0;
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.ForeColor = System.Drawing.Color.White;
            this.BCancelar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.BCancelar.IconColor = System.Drawing.Color.White;
            this.BCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BCancelar.IconSize = 20;
            this.BCancelar.Location = new System.Drawing.Point(741, 430);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(88, 27);
            this.BCancelar.TabIndex = 10;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BCancelar.UseVisualStyleBackColor = false;
            // 
            // AddOrderPurchase
            // 
            this.AcceptButton = this.BSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BCancelar;
            this.ClientSize = new System.Drawing.Size(843, 469);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.TTotal);
            this.Controls.Add(this.LTotal);
            this.Controls.Add(this.BRemoveRow);
            this.Controls.Add(this.BAddRow);
            this.Controls.Add(this.DItems);
            this.Controls.Add(this.CEstado);
            this.Controls.Add(this.LEstado);
            this.Controls.Add(this.DFecha);
            this.Controls.Add(this.LFecha);
            this.Controls.Add(this.CBProveedor);
            this.Controls.Add(this.LProveedor);
            this.Controls.Add(this.TIdOrden);
            this.Controls.Add(this.LId);
            this.Controls.Add(this.LTitulo);
            this.MinimumSize = new System.Drawing.Size(774, 456);
            this.Name = "AddOrderPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Orden de Compra";
            ((System.ComponentModel.ISupportInitialize)(this.DItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LId;
        private System.Windows.Forms.TextBox TIdOrden;
        private System.Windows.Forms.Label LProveedor;
        private System.Windows.Forms.ComboBox CBProveedor;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.DateTimePicker DFecha;
        private System.Windows.Forms.Label LEstado;
        private System.Windows.Forms.ComboBox CEstado;
        private System.Windows.Forms.DataGridView DItems;
        private FontAwesome.Sharp.IconButton BAddRow;
        private FontAwesome.Sharp.IconButton BRemoveRow;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.TextBox TTotal;
        private FontAwesome.Sharp.IconButton BSave;
        private FontAwesome.Sharp.IconButton BCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_item;
        private System.Windows.Forms.DataGridViewComboBoxColumn item_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}