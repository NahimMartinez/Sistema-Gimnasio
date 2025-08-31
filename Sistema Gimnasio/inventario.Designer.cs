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
            this.LNuevoItem = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LCantidad = new System.Windows.Forms.Label();
            this.LFechaIngresoItem = new System.Windows.Forms.Label();
            this.CBCategoriaItem = new System.Windows.Forms.ComboBox();
            this.LCategoriaItem = new System.Windows.Forms.Label();
            this.DTFechaIngresoItem = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LNuevoItem
            // 
            this.LNuevoItem.AutoSize = true;
            this.LNuevoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LNuevoItem.Location = new System.Drawing.Point(71, 35);
            this.LNuevoItem.Name = "LNuevoItem";
            this.LNuevoItem.Size = new System.Drawing.Size(93, 20);
            this.LNuevoItem.TabIndex = 0;
            this.LNuevoItem.Text = "Nuevo Item";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(72, 81);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(44, 13);
            this.LNombre.TabIndex = 1;
            this.LNombre.Text = "Nombre";
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Location = new System.Drawing.Point(72, 114);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(49, 13);
            this.LCantidad.TabIndex = 2;
            this.LCantidad.Text = "Cantidad";
            // 
            // LFechaIngresoItem
            // 
            this.LFechaIngresoItem.AutoSize = true;
            this.LFechaIngresoItem.Location = new System.Drawing.Point(72, 181);
            this.LFechaIngresoItem.Name = "LFechaIngresoItem";
            this.LFechaIngresoItem.Size = new System.Drawing.Size(90, 13);
            this.LFechaIngresoItem.TabIndex = 3;
            this.LFechaIngresoItem.Text = "Fecha de Ingreso";
            // 
            // CBCategoriaItem
            // 
            this.CBCategoriaItem.FormattingEnabled = true;
            this.CBCategoriaItem.Items.AddRange(new object[] {
            "Mancuerna",
            "Maquina",
            "Barra",
            ""});
            this.CBCategoriaItem.Location = new System.Drawing.Point(171, 142);
            this.CBCategoriaItem.Name = "CBCategoriaItem";
            this.CBCategoriaItem.Size = new System.Drawing.Size(121, 21);
            this.CBCategoriaItem.TabIndex = 4;
            // 
            // LCategoriaItem
            // 
            this.LCategoriaItem.AutoSize = true;
            this.LCategoriaItem.Location = new System.Drawing.Point(72, 145);
            this.LCategoriaItem.Name = "LCategoriaItem";
            this.LCategoriaItem.Size = new System.Drawing.Size(54, 13);
            this.LCategoriaItem.TabIndex = 5;
            this.LCategoriaItem.Text = "Categoría";
            // 
            // DTFechaIngresoItem
            // 
            this.DTFechaIngresoItem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFechaIngresoItem.Location = new System.Drawing.Point(171, 181);
            this.DTFechaIngresoItem.Name = "DTFechaIngresoItem";
            this.DTFechaIngresoItem.Size = new System.Drawing.Size(121, 20);
            this.DTFechaIngresoItem.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 8;
            // 
            // inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DTFechaIngresoItem);
            this.Controls.Add(this.LCategoriaItem);
            this.Controls.Add(this.CBCategoriaItem);
            this.Controls.Add(this.LFechaIngresoItem);
            this.Controls.Add(this.LCantidad);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.LNuevoItem);
            this.Name = "inventario";
            this.Size = new System.Drawing.Size(655, 417);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNuevoItem;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.Label LFechaIngresoItem;
        private System.Windows.Forms.ComboBox CBCategoriaItem;
        private System.Windows.Forms.Label LCategoriaItem;
        private System.Windows.Forms.DateTimePicker DTFechaIngresoItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}
