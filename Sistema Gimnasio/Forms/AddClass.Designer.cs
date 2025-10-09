using Presentation;

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
            this.BSave = new FontAwesome.Sharp.IconButton();
            this.BLimpiar = new FontAwesome.Sharp.IconButton();
            this.LHora = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.CBDomingo = new System.Windows.Forms.CheckBox();
            this.CBCoachs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CBCategoria
            // 
            this.CBCategoria.BackColor = System.Drawing.Color.White;
            this.CBCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCategoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CBCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Items.AddRange(new object[] {
            "Musculación",
            "Crossfit",
            "Funcional",
            "Yoga",
            "Spinning",
            "Pilates"});
            this.CBCategoria.Location = new System.Drawing.Point(167, 46);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(200, 28);
            this.CBCategoria.TabIndex = 34;
            // 
            // txtCupo
            // 
            this.txtCupo.BackColor = System.Drawing.Color.White;
            this.txtCupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCupo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCupo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txtCupo.Location = new System.Drawing.Point(167, 124);
            this.txtCupo.MaxLength = 3;
            this.txtCupo.Name = "txtCupo";
            this.txtCupo.Size = new System.Drawing.Size(100, 27);
            this.txtCupo.TabIndex = 32;
            // 
            // LDiasClases
            // 
            this.LDiasClases.AutoSize = true;
            this.LDiasClases.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LDiasClases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LDiasClases.Location = new System.Drawing.Point(419, 17);
            this.LDiasClases.Name = "LDiasClases";
            this.LDiasClases.Size = new System.Drawing.Size(46, 23);
            this.LDiasClases.TabIndex = 31;
            this.LDiasClases.Text = "Días:";
            // 
            // LCupo
            // 
            this.LCupo.AutoSize = true;
            this.LCupo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LCupo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LCupo.Location = new System.Drawing.Point(86, 126);
            this.LCupo.Name = "LCupo";
            this.LCupo.Size = new System.Drawing.Size(55, 23);
            this.LCupo.TabIndex = 30;
            this.LCupo.Text = "Cupo:";
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LCategoria.Location = new System.Drawing.Point(86, 49);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(88, 23);
            this.LCategoria.TabIndex = 29;
            this.LCategoria.Text = "Categoría:";
            // 
            // CBLunes
            // 
            this.CBLunes.AutoSize = true;
            this.CBLunes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CBLunes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.CBLunes.Location = new System.Drawing.Point(422, 37);
            this.CBLunes.Name = "CBLunes";
            this.CBLunes.Size = new System.Drawing.Size(68, 24);
            this.CBLunes.TabIndex = 35;
            this.CBLunes.Text = "Lunes";
            this.CBLunes.UseVisualStyleBackColor = true;
            // 
            // CBMartes
            // 
            this.CBMartes.AutoSize = true;
            this.CBMartes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CBMartes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.CBMartes.Location = new System.Drawing.Point(422, 62);
            this.CBMartes.Name = "CBMartes";
            this.CBMartes.Size = new System.Drawing.Size(76, 24);
            this.CBMartes.TabIndex = 36;
            this.CBMartes.Text = "Martes";
            this.CBMartes.UseVisualStyleBackColor = true;
            // 
            // CBMiercoles
            // 
            this.CBMiercoles.AutoSize = true;
            this.CBMiercoles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CBMiercoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.CBMiercoles.Location = new System.Drawing.Point(422, 87);
            this.CBMiercoles.Name = "CBMiercoles";
            this.CBMiercoles.Size = new System.Drawing.Size(95, 24);
            this.CBMiercoles.TabIndex = 37;
            this.CBMiercoles.Text = "Miércoles";
            this.CBMiercoles.UseVisualStyleBackColor = true;
            // 
            // CBJueves
            // 
            this.CBJueves.AutoSize = true;
            this.CBJueves.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CBJueves.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.CBJueves.Location = new System.Drawing.Point(422, 112);
            this.CBJueves.Name = "CBJueves";
            this.CBJueves.Size = new System.Drawing.Size(73, 24);
            this.CBJueves.TabIndex = 38;
            this.CBJueves.Text = "Jueves";
            this.CBJueves.UseVisualStyleBackColor = true;
            // 
            // CBViernes
            // 
            this.CBViernes.AutoSize = true;
            this.CBViernes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CBViernes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.CBViernes.Location = new System.Drawing.Point(422, 137);
            this.CBViernes.Name = "CBViernes";
            this.CBViernes.Size = new System.Drawing.Size(79, 24);
            this.CBViernes.TabIndex = 39;
            this.CBViernes.Text = "Viernes";
            this.CBViernes.UseVisualStyleBackColor = true;
            // 
            // CBSabado
            // 
            this.CBSabado.AutoSize = true;
            this.CBSabado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CBSabado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.CBSabado.Location = new System.Drawing.Point(422, 162);
            this.CBSabado.Name = "CBSabado";
            this.CBSabado.Size = new System.Drawing.Size(82, 24);
            this.CBSabado.TabIndex = 40;
            this.CBSabado.Text = "Sábado";
            this.CBSabado.UseVisualStyleBackColor = true;
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
            this.BSave.Location = new System.Drawing.Point(125, 232);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(110, 30);
            this.BSave.TabIndex = 41;
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
            this.BLimpiar.Location = new System.Drawing.Point(283, 232);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(110, 30);
            this.BLimpiar.TabIndex = 42;
            this.BLimpiar.Text = "Limpiar";
            this.BLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // LHora
            // 
            this.LHora.AutoSize = true;
            this.LHora.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LHora.Location = new System.Drawing.Point(86, 169);
            this.LHora.Name = "LHora";
            this.LHora.Size = new System.Drawing.Size(51, 23);
            this.LHora.TabIndex = 43;
            this.LHora.Text = "Hora:";
            // 
            // txtHora
            // 
            this.txtHora.BackColor = System.Drawing.Color.White;
            this.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHora.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txtHora.Location = new System.Drawing.Point(167, 166);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 27);
            this.txtHora.TabIndex = 44;
            // 
            // CBDomingo
            // 
            this.CBDomingo.AutoSize = true;
            this.CBDomingo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CBDomingo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.CBDomingo.Location = new System.Drawing.Point(422, 192);
            this.CBDomingo.Name = "CBDomingo";
            this.CBDomingo.Size = new System.Drawing.Size(94, 24);
            this.CBDomingo.TabIndex = 45;
            this.CBDomingo.Text = "Domingo";
            this.CBDomingo.UseVisualStyleBackColor = true;
            // 
            // CBCoachs
            // 
            this.CBCoachs.BackColor = System.Drawing.Color.White;
            this.CBCoachs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCoachs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CBCoachs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.CBCoachs.FormattingEnabled = true;
            this.CBCoachs.Items.AddRange(new object[] {
            "Musculación",
            "Crossfit",
            "Funcional",
            "Yoga",
            "Spinning",
            "Pilates"});
            this.CBCoachs.Location = new System.Drawing.Point(167, 83);
            this.CBCoachs.Name = "CBCoachs";
            this.CBCoachs.Size = new System.Drawing.Size(200, 28);
            this.CBCoachs.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(86, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = "Coach:";
            // 
            // AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(600, 289);
            this.Controls.Add(this.CBCoachs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBDomingo);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.LHora);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.BSave);
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
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(616, 289);
            this.Name = "AddClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Clase";
            this.Load += new System.EventHandler(this.AddClass_Load);
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
        private FontAwesome.Sharp.IconButton BSave;
        private FontAwesome.Sharp.IconButton BLimpiar;
        private System.Windows.Forms.Label LHora;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.CheckBox CBDomingo;
        private System.Windows.Forms.ComboBox CBCoachs;
        private System.Windows.Forms.Label label1;
    }
}