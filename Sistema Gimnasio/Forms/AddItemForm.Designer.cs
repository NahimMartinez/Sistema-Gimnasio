using Presentation;
using FontAwesome.Sharp;
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
            this.BSave = new FontAwesome.Sharp.IconButton();
            this.BLimpiar = new FontAwesome.Sharp.IconButton();
            this.NewCategoryInventory = new FontAwesome.Sharp.IconButton();
            this.CBProveedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txtCantidad.Location = new System.Drawing.Point(156, 100);
            this.txtCantidad.MaxLength = 5;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(200, 27);
            this.txtCantidad.TabIndex = 21;
            // 
            // LFechaIngresoItem
            // 
            this.LFechaIngresoItem.AutoSize = true;
            this.LFechaIngresoItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LFechaIngresoItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LFechaIngresoItem.Location = new System.Drawing.Point(30, 133);
            this.LFechaIngresoItem.Name = "LFechaIngresoItem";
            this.LFechaIngresoItem.Size = new System.Drawing.Size(120, 23);
            this.LFechaIngresoItem.TabIndex = 19;
            this.LFechaIngresoItem.Text = "Fecha Ingreso:";
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LCantidad.Location = new System.Drawing.Point(30, 100);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(83, 23);
            this.LCantidad.TabIndex = 17;
            this.LCantidad.Text = "Cantidad:";
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LCategoria.Location = new System.Drawing.Point(30, 172);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(88, 23);
            this.LCategoria.TabIndex = 16;
            this.LCategoria.Text = "Categoría:";
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LName.Location = new System.Drawing.Point(30, 67);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(77, 23);
            this.LName.TabIndex = 15;
            this.LName.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txtNombre.Location = new System.Drawing.Point(156, 67);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 27);
            this.txtNombre.TabIndex = 13;
            // 
            // DTFechaIngreso
            // 
            this.DTFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFechaIngreso.Location = new System.Drawing.Point(156, 133);
            this.DTFechaIngreso.Name = "DTFechaIngreso";
            this.DTFechaIngreso.Size = new System.Drawing.Size(200, 27);
            this.DTFechaIngreso.TabIndex = 25;
            // 
            // CBCategoria
            // 
            this.CBCategoria.BackColor = System.Drawing.Color.White;
            this.CBCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCategoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CBCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Items.AddRange(new object[] {
            "Mancuernas",
            "Máquinas",
            "Barras",
            "Discos",
            "Accesorios"});
            this.CBCategoria.Location = new System.Drawing.Point(156, 171);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(200, 28);
            this.CBCategoria.TabIndex = 26;
            // 
            // BSave
            // 
            this.BSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.BSave.FlatAppearance.BorderSize = 0;
            this.BSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSave.ForeColor = System.Drawing.Color.White;
            this.BSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BSave.IconColor = System.Drawing.Color.White;
            this.BSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BSave.IconSize = 24;
            this.BSave.Location = new System.Drawing.Point(34, 289);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(110, 30);
            this.BSave.TabIndex = 27;
            this.BSave.Text = "Guardar";
            this.BSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BSave.UseVisualStyleBackColor = false;
            this.BSave.Click += new System.EventHandler(this.BCrear_Click);
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.BLimpiar.FlatAppearance.BorderSize = 0;
            this.BLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiar.ForeColor = System.Drawing.Color.White;
            this.BLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.BLimpiar.IconColor = System.Drawing.Color.White;
            this.BLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BLimpiar.IconSize = 24;
            this.BLimpiar.Location = new System.Drawing.Point(246, 289);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(110, 30);
            this.BLimpiar.TabIndex = 28;
            this.BLimpiar.Text = "Limpiar";
            this.BLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // NewCategoryInventory
            // 
            this.NewCategoryInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            this.NewCategoryInventory.FlatAppearance.BorderSize = 0;
            this.NewCategoryInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewCategoryInventory.ForeColor = System.Drawing.Color.White;
            this.NewCategoryInventory.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.NewCategoryInventory.IconColor = System.Drawing.Color.White;
            this.NewCategoryInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NewCategoryInventory.IconSize = 24;
            this.NewCategoryInventory.Location = new System.Drawing.Point(362, 169);
            this.NewCategoryInventory.Name = "NewCategoryInventory";
            this.NewCategoryInventory.Size = new System.Drawing.Size(29, 30);
            this.NewCategoryInventory.TabIndex = 29;
            this.NewCategoryInventory.UseVisualStyleBackColor = false;
            this.NewCategoryInventory.Click += new System.EventHandler(this.NewCategoryInventory_Click);
            // 
            // CBProveedor
            // 
            this.CBProveedor.BackColor = System.Drawing.Color.White;
            this.CBProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBProveedor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CBProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.CBProveedor.FormattingEnabled = true;
            this.CBProveedor.Items.AddRange(new object[] {
            "Musculación",
            "Crossfit",
            "Funcional",
            "Yoga",
            "Spinning",
            "Pilates"});
            this.CBProveedor.Location = new System.Drawing.Point(156, 212);
            this.CBProveedor.Name = "CBProveedor";
            this.CBProveedor.Size = new System.Drawing.Size(200, 28);
            this.CBProveedor.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(30, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "Proveedor:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(407, 351);
            this.Controls.Add(this.CBProveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewCategoryInventory);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.CBCategoria);
            this.Controls.Add(this.DTFechaIngreso);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.LFechaIngresoItem);
            this.Controls.Add(this.LCantidad);
            this.Controls.Add(this.LCategoria);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.txtNombre);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "AddItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Item";
            this.Load += new System.EventHandler(this.AddItemForm_Load);
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
        private FontAwesome.Sharp.IconButton BSave;
        private FontAwesome.Sharp.IconButton BLimpiar;
        private IconButton NewCategoryInventory;
        private System.Windows.Forms.ComboBox CBProveedor;
        private System.Windows.Forms.Label label1;
    }
}