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
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCantidad.Location = new System.Drawing.Point(120, 96);
            this.txtCantidad.MaxLength = 5;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(200, 23);
            this.txtCantidad.TabIndex = 21;
            // 
            // LFechaIngresoItem
            // 
            this.LFechaIngresoItem.AutoSize = true;
            this.LFechaIngresoItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LFechaIngresoItem.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.LFechaIngresoItem.Location = new System.Drawing.Point(30, 133);
            this.LFechaIngresoItem.Name = "LFechaIngresoItem";
            this.LFechaIngresoItem.Size = new System.Drawing.Size(84, 15);
            this.LFechaIngresoItem.TabIndex = 19;
            this.LFechaIngresoItem.Text = "Fecha Ingreso:";
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LCantidad.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.LCantidad.Location = new System.Drawing.Point(30, 99);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(58, 15);
            this.LCantidad.TabIndex = 17;
            this.LCantidad.Text = "Cantidad:";
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LCategoria.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.LCategoria.Location = new System.Drawing.Point(390, 65);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(61, 15);
            this.LCategoria.TabIndex = 16;
            this.LCategoria.Text = "Categoría:";
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LName.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.LName.Location = new System.Drawing.Point(30, 65);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(54, 15);
            this.LName.TabIndex = 15;
            this.LName.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.Location = new System.Drawing.Point(120, 62);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 23);
            this.txtNombre.TabIndex = 13;
            // 
            // DTFechaIngreso
            // 
            this.DTFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFechaIngreso.Location = new System.Drawing.Point(120, 130);
            this.DTFechaIngreso.Name = "DTFechaIngreso";
            this.DTFechaIngreso.Size = new System.Drawing.Size(200, 23);
            this.DTFechaIngreso.TabIndex = 25;
            // 
            // CBCategoria
            // 
            this.CBCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCategoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Items.AddRange(new object[] {
            "Mancuernas",
            "Máquinas",
            "Barras",
            "Discos",
            "Accesorios"});
            this.CBCategoria.Location = new System.Drawing.Point(457, 62);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(200, 23);
            this.CBCategoria.TabIndex = 26;
            // 
            // BCrear
            // 
            this.BCrear.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.BCrear.FlatAppearance.BorderSize = 0;
            this.BCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCrear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BCrear.ForeColor = System.Drawing.Color.White;
            this.BCrear.Location = new System.Drawing.Point(120, 180);
            this.BCrear.Name = "BCrear";
            this.BCrear.Size = new System.Drawing.Size(110, 30);
            this.BCrear.TabIndex = 27;
            this.BCrear.Text = "Crear";
            this.BCrear.UseVisualStyleBackColor = false;
            this.BCrear.Click += new System.EventHandler(this.BCrear_Click);
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.BLimpiar.FlatAppearance.BorderSize = 0;
            this.BLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BLimpiar.ForeColor = System.Drawing.Color.White;
            this.BLimpiar.Location = new System.Drawing.Point(300, 180);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(110, 30);
            this.BLimpiar.TabIndex = 28;
            this.BLimpiar.Text = "Limpiar";
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(700, 250);
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
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(716, 289);
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