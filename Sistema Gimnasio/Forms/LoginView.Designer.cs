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
            this.TUser = new System.Windows.Forms.TextBox();
            this.TPass = new System.Windows.Forms.TextBox();
            this.BCleanup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LUsuer
            // 
            this.LUsuer.AutoSize = true;
            this.LUsuer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuer.Location = new System.Drawing.Point(64, 52);
            this.LUsuer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LUsuer.Name = "LUsuer";
            this.LUsuer.Size = new System.Drawing.Size(57, 17);
            this.LUsuer.TabIndex = 0;
            this.LUsuer.Text = "Usuario";
            // 
            // BLogin
            // 
            this.BLogin.Location = new System.Drawing.Point(89, 162);
            this.BLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(86, 19);
            this.BLogin.TabIndex = 1;
            this.BLogin.Text = "Iniciar Sesion";
            this.BLogin.UseVisualStyleBackColor = true;
            this.BLogin.Click += new System.EventHandler(this.BLogin_Click);
            // 
            // LPass
            // 
            this.LPass.AutoSize = true;
            this.LPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPass.Location = new System.Drawing.Point(64, 110);
            this.LPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LPass.Name = "LPass";
            this.LPass.Size = new System.Drawing.Size(81, 17);
            this.LPass.TabIndex = 2;
            this.LPass.Text = "Contraseña";
            // 
            // TUser
            // 
            this.TUser.Location = new System.Drawing.Point(171, 52);
            this.TUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TUser.Name = "TUser";
            this.TUser.Size = new System.Drawing.Size(150, 20);
            this.TUser.TabIndex = 3;
            // 
            // TPass
            // 
            this.TPass.Location = new System.Drawing.Point(171, 110);
            this.TPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TPass.Name = "TPass";
            this.TPass.PasswordChar = '*';
            this.TPass.Size = new System.Drawing.Size(150, 20);
            this.TPass.TabIndex = 4;
            // 
            // BCleanup
            // 
            this.BCleanup.Location = new System.Drawing.Point(218, 162);
            this.BCleanup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BCleanup.Name = "BCleanup";
            this.BCleanup.Size = new System.Drawing.Size(82, 19);
            this.BCleanup.TabIndex = 5;
            this.BCleanup.Text = "Limpiar";
            this.BCleanup.UseVisualStyleBackColor = true;
            this.BCleanup.Click += new System.EventHandler(this.BCleanup_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 238);
            this.Controls.Add(this.BCleanup);
            this.Controls.Add(this.TPass);
            this.Controls.Add(this.TUser);
            this.Controls.Add(this.LPass);
            this.Controls.Add(this.BLogin);
            this.Controls.Add(this.LUsuer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginView";
            this.Text = "Iniciar Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LUsuer;
        private System.Windows.Forms.Button BLogin;
        private System.Windows.Forms.Label LPass;
        private System.Windows.Forms.TextBox TUser;
        private System.Windows.Forms.TextBox TPass;
        private System.Windows.Forms.Button BCleanup;
    }
}