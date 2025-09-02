namespace Sistema_Gimnasio.Forms
{
    partial class AddItemForm
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
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.LFechaIngresoItem = new System.Windows.Forms.Label();
            this.LCantidad = new System.Windows.Forms.Label();
            this.LCategoria = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.DTFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.BCrear = new System.Windows.Forms.Button();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(106, 96);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(184, 20);
            this.txtCantidad.TabIndex = 21;
            // 
            // LFechaIngresoItem
            // 
            this.LFechaIngresoItem.AutoSize = true;
            this.LFechaIngresoItem.Location = new System.Drawing.Point(25, 133);
            this.LFechaIngresoItem.Name = "LFechaIngresoItem";
            this.LFechaIngresoItem.Size = new System.Drawing.Size(75, 13);
            this.LFechaIngresoItem.TabIndex = 19;
            this.LFechaIngresoItem.Text = "Fecha Ingreso";
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Location = new System.Drawing.Point(25, 99);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(49, 13);
            this.LCantidad.TabIndex = 17;
            this.LCantidad.Text = "Cantidad";
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Location = new System.Drawing.Point(332, 65);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(54, 13);
            this.LCategoria.TabIndex = 16;
            this.LCategoria.Text = "Categoría";
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(25, 65);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(44, 13);
            this.LName.TabIndex = 15;
            this.LName.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(106, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(184, 20);
            this.txtNombre.TabIndex = 13;
            // 
            // DTFechaIngreso
            // 
            this.DTFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFechaIngreso.Location = new System.Drawing.Point(106, 130);
            this.DTFechaIngreso.Name = "DTFechaIngreso";
            this.DTFechaIngreso.Size = new System.Drawing.Size(184, 20);
            this.DTFechaIngreso.TabIndex = 25;
            // 
            // CBCategoria
            // 
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Items.AddRange(new object[] {
            "Mancuerna",
            "Maquina",
            "Barra"});
            this.CBCategoria.Location = new System.Drawing.Point(392, 61);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(121, 21);
            this.CBCategoria.TabIndex = 26;
            // 
            // BCrear
            // 
            this.BCrear.Location = new System.Drawing.Point(106, 192);
            this.BCrear.Name = "BCrear";
            this.BCrear.Size = new System.Drawing.Size(75, 23);
            this.BCrear.TabIndex = 27;
            this.BCrear.Text = "Crear";
            this.BCrear.UseVisualStyleBackColor = true;
            this.BCrear.Click += new System.EventHandler(this.BCrear_Click);
            // 
            // BLimpiar
            // 
            this.BLimpiar.Location = new System.Drawing.Point(335, 192);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BLimpiar.TabIndex = 28;
            this.BLimpiar.Text = "Limpiar";
            this.BLimpiar.UseVisualStyleBackColor = true;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.BCrear);
            this.Controls.Add(this.CBCategoria);
            this.Controls.Add(this.DTFechaIngreso);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.LFechaIngresoItem);
            this.Controls.Add(this.LCantidad);
            this.Controls.Add(this.LCategoria);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.txtNombre);
            this.Name = "AddItemForm";
            this.Text = "Nuevo Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label LFechaIngresoItem;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.Label LCategoria;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker DTFechaIngreso;
        private System.Windows.Forms.ComboBox CBCategoria;
        private System.Windows.Forms.Button BCrear;
        private System.Windows.Forms.Button BLimpiar;
    }
}