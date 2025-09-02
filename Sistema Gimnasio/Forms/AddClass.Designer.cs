namespace Sistema_Gimnasio.Forms
{
    partial class AddClass
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.LDiasClases = new System.Windows.Forms.Label();
            this.LCupo = new System.Windows.Forms.Label();
            this.LCategoria = new System.Windows.Forms.Label();
            this.CBLunes = new System.Windows.Forms.CheckBox();
            this.CBMartes = new System.Windows.Forms.CheckBox();
            this.CBMiercoles = new System.Windows.Forms.CheckBox();
            this.CBJueves = new System.Windows.Forms.CheckBox();
            this.CBViernes = new System.Windows.Forms.CheckBox();
            this.CBSabado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Musculacion",
            "Crossfit",
            "Funcional"});
            this.comboBox1.Location = new System.Drawing.Point(169, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 34;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(169, 106);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 20);
            this.txtCantidad.TabIndex = 32;
            // 
            // LDiasClases
            // 
            this.LDiasClases.AutoSize = true;
            this.LDiasClases.Location = new System.Drawing.Point(334, 95);
            this.LDiasClases.Name = "LDiasClases";
            this.LDiasClases.Size = new System.Drawing.Size(28, 13);
            this.LDiasClases.TabIndex = 31;
            this.LDiasClases.Text = "Dias";
            // 
            // LCupo
            // 
            this.LCupo.AutoSize = true;
            this.LCupo.Location = new System.Drawing.Point(88, 109);
            this.LCupo.Name = "LCupo";
            this.LCupo.Size = new System.Drawing.Size(32, 13);
            this.LCupo.TabIndex = 30;
            this.LCupo.Text = "Cupo";
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Location = new System.Drawing.Point(88, 72);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(54, 13);
            this.LCategoria.TabIndex = 29;
            this.LCategoria.Text = "Categoría";
            // 
            // CBLunes
            // 
            this.CBLunes.AutoSize = true;
            this.CBLunes.Location = new System.Drawing.Point(396, 36);
            this.CBLunes.Name = "CBLunes";
            this.CBLunes.Size = new System.Drawing.Size(55, 17);
            this.CBLunes.TabIndex = 35;
            this.CBLunes.Text = "Lunes";
            this.CBLunes.UseVisualStyleBackColor = true;
            // 
            // CBMartes
            // 
            this.CBMartes.AutoSize = true;
            this.CBMartes.Location = new System.Drawing.Point(396, 59);
            this.CBMartes.Name = "CBMartes";
            this.CBMartes.Size = new System.Drawing.Size(58, 17);
            this.CBMartes.TabIndex = 36;
            this.CBMartes.Text = "Martes";
            this.CBMartes.UseVisualStyleBackColor = true;
            // 
            // CBMiercoles
            // 
            this.CBMiercoles.AutoSize = true;
            this.CBMiercoles.Location = new System.Drawing.Point(396, 82);
            this.CBMiercoles.Name = "CBMiercoles";
            this.CBMiercoles.Size = new System.Drawing.Size(71, 17);
            this.CBMiercoles.TabIndex = 37;
            this.CBMiercoles.Text = "Miercoles";
            this.CBMiercoles.UseVisualStyleBackColor = true;
            // 
            // CBJueves
            // 
            this.CBJueves.AutoSize = true;
            this.CBJueves.Location = new System.Drawing.Point(396, 105);
            this.CBJueves.Name = "CBJueves";
            this.CBJueves.Size = new System.Drawing.Size(60, 17);
            this.CBJueves.TabIndex = 38;
            this.CBJueves.Text = "Jueves";
            this.CBJueves.UseVisualStyleBackColor = true;
            // 
            // CBViernes
            // 
            this.CBViernes.AutoSize = true;
            this.CBViernes.Location = new System.Drawing.Point(396, 128);
            this.CBViernes.Name = "CBViernes";
            this.CBViernes.Size = new System.Drawing.Size(61, 17);
            this.CBViernes.TabIndex = 39;
            this.CBViernes.Text = "Viernes";
            this.CBViernes.UseVisualStyleBackColor = true;
            // 
            // CBSabado
            // 
            this.CBSabado.AutoSize = true;
            this.CBSabado.Location = new System.Drawing.Point(396, 151);
            this.CBSabado.Name = "CBSabado";
            this.CBSabado.Size = new System.Drawing.Size(63, 17);
            this.CBSabado.TabIndex = 40;
            this.CBSabado.Text = "Sabado";
            this.CBSabado.UseVisualStyleBackColor = true;
            // 
            // AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 221);
            this.Controls.Add(this.CBSabado);
            this.Controls.Add(this.CBViernes);
            this.Controls.Add(this.CBJueves);
            this.Controls.Add(this.CBMiercoles);
            this.Controls.Add(this.CBMartes);
            this.Controls.Add(this.CBLunes);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.LDiasClases);
            this.Controls.Add(this.LCupo);
            this.Controls.Add(this.LCategoria);
            this.Name = "AddClass";
            this.Text = "Nueva Clase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label LDiasClases;
        private System.Windows.Forms.Label LCupo;
        private System.Windows.Forms.Label LCategoria;
        private System.Windows.Forms.CheckBox CBLunes;
        private System.Windows.Forms.CheckBox CBMartes;
        private System.Windows.Forms.CheckBox CBMiercoles;
        private System.Windows.Forms.CheckBox CBJueves;
        private System.Windows.Forms.CheckBox CBViernes;
        private System.Windows.Forms.CheckBox CBSabado;
    }
}