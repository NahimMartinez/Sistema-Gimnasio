namespace Sistema_Gimnasio
{
    partial class LoginView
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
            this.LUsuer = new System.Windows.Forms.Label();
            this.BLogin = new System.Windows.Forms.Button();
            this.LPass = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TPass = new System.Windows.Forms.TextBox();
            this.BCleanup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LUsuer
            // 
            this.LUsuer.AutoSize = true;
            this.LUsuer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuer.Location = new System.Drawing.Point(86, 64);
            this.LUsuer.Name = "LUsuer";
            this.LUsuer.Size = new System.Drawing.Size(67, 20);
            this.LUsuer.TabIndex = 0;
            this.LUsuer.Text = "Usuario";
            // 
            // BLogin
            // 
            this.BLogin.Location = new System.Drawing.Point(119, 199);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(114, 23);
            this.BLogin.TabIndex = 1;
            this.BLogin.Text = "Iniciar Sesion";
            this.BLogin.UseVisualStyleBackColor = true;
            // 
            // LPass
            // 
            this.LPass.AutoSize = true;
            this.LPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPass.Location = new System.Drawing.Point(86, 136);
            this.LPass.Name = "LPass";
            this.LPass.Size = new System.Drawing.Size(95, 20);
            this.LPass.TabIndex = 2;
            this.LPass.Text = "Contraseña";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 22);
            this.textBox1.TabIndex = 3;
            // 
            // TPass
            // 
            this.TPass.Location = new System.Drawing.Point(228, 136);
            this.TPass.Name = "TPass";
            this.TPass.PasswordChar = '*';
            this.TPass.Size = new System.Drawing.Size(199, 22);
            this.TPass.TabIndex = 4;
            // 
            // BCleanup
            // 
            this.BCleanup.Location = new System.Drawing.Point(290, 199);
            this.BCleanup.Name = "BCleanup";
            this.BCleanup.Size = new System.Drawing.Size(109, 23);
            this.BCleanup.TabIndex = 5;
            this.BCleanup.Text = "Limpiar";
            this.BCleanup.UseVisualStyleBackColor = true;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 293);
            this.Controls.Add(this.BCleanup);
            this.Controls.Add(this.TPass);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LPass);
            this.Controls.Add(this.BLogin);
            this.Controls.Add(this.LUsuer);
            this.Name = "LoginView";
            this.Text = "Iniciar Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LUsuer;
        private System.Windows.Forms.Button BLogin;
        private System.Windows.Forms.Label LPass;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TPass;
        private System.Windows.Forms.Button BCleanup;
    }
}