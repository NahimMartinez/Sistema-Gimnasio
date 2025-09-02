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
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.txtCupo = new System.Windows.Forms.TextBox();
            this.LDiasClases = new System.Windows.Forms.Label();
            this.LCupo = new System.Windows.Forms.Label();
            this.LCategoria = new System.Windows.Forms.Label();
            this.CBLunes = new System.Windows.Forms.CheckBox();
            this.CBMartes = new System.Windows.Forms.CheckBox();
            this.CBMiercoles = new System.Windows.Forms.CheckBox();
            this.CBJueves = new System.Windows.Forms.CheckBox();
            this.CBViernes = new System.Windows.Forms.CheckBox();
            this.CBSabado = new System.Windows.Forms.CheckBox();
            this.BCrear = new System.Windows.Forms.Button();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBCategoria
            // 
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Items.AddRange(new object[] {
            "Musculacion",
            "Crossfit",
            "Funcional"});
            this.CBCategoria.Location = new System.Drawing.Point(169, 69);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(121, 21);
            this.CBCategoria.TabIndex = 34;
            // 
            // txtCupo
            // 
            this.txtCupo.Location = new System.Drawing.Point(169, 106);
            this.txtCupo.Name = "txtCupo";
            this.txtCupo.Size = new System.Drawing.Size(121, 20);
            this.txtCupo.TabIndex = 32;
            // 
            // LDiasClases
            // 
            this.LDiasClases.AutoSize = true;
            this.LDiasClases.Location = new System.Drawing.Point(334, 95);
            this.LDiasClases.Name = "LDiasClases";
            this.LDiasClases.Size = new System.Drawing.Size(28, 13);
            this.LDiasClases.TabIndex = 31;
            this.LDiasClases.Text = "Dias";
            this.LDiasClases.Click += new System.EventHandler(this.LDiasClases_Click);
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
            // BCrear
            // 
            this.BCrear.Location = new System.Drawing.Point(129, 186);
            this.BCrear.Name = "BCrear";
            this.BCrear.Size = new System.Drawing.Size(75, 23);
            this.BCrear.TabIndex = 41;
            this.BCrear.Text = "Crear";
            this.BCrear.UseVisualStyleBackColor = true;
            this.BCrear.Click += new System.EventHandler(this.BCrear_Click);
            // 
            // BLimpiar
            // 
            this.BLimpiar.Location = new System.Drawing.Point(287, 186);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BLimpiar.TabIndex = 42;
            this.BLimpiar.Text = "Limpiar";
            this.BLimpiar.UseVisualStyleBackColor = true;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 221);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.BCrear);
            this.Controls.Add(this.CBSabado);
            this.Controls.Add(this.CBViernes);
            this.Controls.Add(this.CBJueves);
            this.Controls.Add(this.CBMiercoles);
            this.Controls.Add(this.CBMartes);
            this.Controls.Add(this.CBLunes);
            this.Controls.Add(this.CBCategoria);
            this.Controls.Add(this.txtCupo);
            this.Controls.Add(this.LDiasClases);
            this.Controls.Add(this.LCupo);
            this.Controls.Add(this.LCategoria);
            this.Name = "AddClass";
            this.Text = "Nueva Clase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBCategoria;
        private System.Windows.Forms.TextBox txtCupo;
        private System.Windows.Forms.Label LDiasClases;
        private System.Windows.Forms.Label LCupo;
        private System.Windows.Forms.Label LCategoria;
        private System.Windows.Forms.CheckBox CBLunes;
        private System.Windows.Forms.CheckBox CBMartes;
        private System.Windows.Forms.CheckBox CBMiercoles;
        private System.Windows.Forms.CheckBox CBJueves;
        private System.Windows.Forms.CheckBox CBViernes;
        private System.Windows.Forms.CheckBox CBSabado;
        private System.Windows.Forms.Button BCrear;
        private System.Windows.Forms.Button BLimpiar;
    }
}