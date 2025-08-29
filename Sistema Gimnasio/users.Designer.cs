namespace Sistema_Gimnasio
{
    partial class users
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
            this.LUserName = new System.Windows.Forms.Label();
            this.LUserPass = new System.Windows.Forms.Label();
            this.LUserRol = new System.Windows.Forms.Label();
            this.LUserPass2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CBUserRol = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LUserName
            // 
            this.LUserName.AutoSize = true;
            this.LUserName.Location = new System.Drawing.Point(38, 88);
            this.LUserName.Name = "LUserName";
            this.LUserName.Size = new System.Drawing.Size(44, 13);
            this.LUserName.TabIndex = 0;
            this.LUserName.Text = "Nombre";
            // 
            // LUserPass
            // 
            this.LUserPass.AutoSize = true;
            this.LUserPass.Location = new System.Drawing.Point(38, 111);
            this.LUserPass.Name = "LUserPass";
            this.LUserPass.Size = new System.Drawing.Size(61, 13);
            this.LUserPass.TabIndex = 1;
            this.LUserPass.Text = "Contraseña";
            // 
            // LUserRol
            // 
            this.LUserRol.AutoSize = true;
            this.LUserRol.Location = new System.Drawing.Point(38, 164);
            this.LUserRol.Name = "LUserRol";
            this.LUserRol.Size = new System.Drawing.Size(23, 13);
            this.LUserRol.TabIndex = 2;
            this.LUserRol.Text = "Rol";
            // 
            // LUserPass2
            // 
            this.LUserPass2.AutoSize = true;
            this.LUserPass2.Location = new System.Drawing.Point(38, 135);
            this.LUserPass2.Name = "LUserPass2";
            this.LUserPass2.Size = new System.Drawing.Size(97, 13);
            this.LUserPass2.TabIndex = 3;
            this.LUserPass2.Text = "Repetir contraseña";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(141, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // CBUserRol
            // 
            this.CBUserRol.FormattingEnabled = true;
            this.CBUserRol.Items.AddRange(new object[] {
            "Administrador",
            "Coach",
            "Recepcionista"});
            this.CBUserRol.Location = new System.Drawing.Point(141, 161);
            this.CBUserRol.Name = "CBUserRol";
            this.CBUserRol.Size = new System.Drawing.Size(121, 21);
            this.CBUserRol.TabIndex = 7;
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CBUserRol);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LUserPass2);
            this.Controls.Add(this.LUserRol);
            this.Controls.Add(this.LUserPass);
            this.Controls.Add(this.LUserName);
            this.Name = "users";
            this.Size = new System.Drawing.Size(667, 410);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LUserName;
        private System.Windows.Forms.Label LUserPass;
        private System.Windows.Forms.Label LUserRol;
        private System.Windows.Forms.Label LUserPass2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox CBUserRol;
    }
}
