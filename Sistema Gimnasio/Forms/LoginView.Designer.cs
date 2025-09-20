using System.Windows.Forms;
using FontAwesome.Sharp;
using Presentation;
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
            this.BLogin = new FontAwesome.Sharp.IconButton();
            this.LPass = new System.Windows.Forms.Label();
            this.TUser = new System.Windows.Forms.TextBox();
            this.TPass = new System.Windows.Forms.TextBox();
            this.BClose = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // LUsuer
            // 
            this.LUsuer.AutoSize = true;
            this.LUsuer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuer.Location = new System.Drawing.Point(85, 64);
            this.LUsuer.Name = "LUsuer";
            this.LUsuer.Size = new System.Drawing.Size(67, 20);
            this.LUsuer.TabIndex = 0;
            this.LUsuer.Text = "Usuario";
            // 
            // BLogin
            // 
            this.BLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.BLogin.FlatAppearance.BorderSize = 0;
            this.BLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLogin.ForeColor = System.Drawing.Color.White;
            this.BLogin.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.BLogin.IconColor = System.Drawing.Color.White;
            this.BLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BLogin.IconSize = 20;
            this.BLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BLogin.Location = new System.Drawing.Point(119, 199);
            this.BLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(133, 28);
            this.BLogin.TabIndex = 1;
            this.BLogin.Text = "Iniciar Sesion";
            this.BLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BLogin.UseVisualStyleBackColor = false;
            this.BLogin.Click += new System.EventHandler(this.BLogin_Click);
            // 
            // LPass
            // 
            this.LPass.AutoSize = true;
            this.LPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPass.Location = new System.Drawing.Point(85, 135);
            this.LPass.Name = "LPass";
            this.LPass.Size = new System.Drawing.Size(95, 20);
            this.LPass.TabIndex = 2;
            this.LPass.Text = "Contraseña";
            // 
            // TUser
            // 
            this.TUser.Location = new System.Drawing.Point(228, 64);
            this.TUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TUser.Name = "TUser";
            this.TUser.Size = new System.Drawing.Size(199, 22);
            this.TUser.TabIndex = 3;
            // 
            // TPass
            // 
            this.TPass.Location = new System.Drawing.Point(228, 135);
            this.TPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPass.Name = "TPass";
            this.TPass.PasswordChar = '*';
            this.TPass.Size = new System.Drawing.Size(199, 22);
            this.TPass.TabIndex = 4;
            // 
            // BClose
            // 
            this.BClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.BClose.FlatAppearance.BorderSize = 0;
            this.BClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BClose.ForeColor = System.Drawing.Color.White;
            this.BClose.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.BClose.IconColor = System.Drawing.Color.White;
            this.BClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BClose.IconSize = 20;
            this.BClose.Location = new System.Drawing.Point(291, 199);
            this.BClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(124, 28);
            this.BClose.TabIndex = 5;
            this.BClose.Text = "Cerrar";
            this.BClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BClose.UseVisualStyleBackColor = false;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(548, 293);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.TPass);
            this.Controls.Add(this.TUser);
            this.Controls.Add(this.LPass);
            this.Controls.Add(this.BLogin);
            this.Controls.Add(this.LUsuer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LUsuer;
        private FontAwesome.Sharp.IconButton BLogin;
        private System.Windows.Forms.Label LPass;
        private System.Windows.Forms.TextBox TUser;
        private System.Windows.Forms.TextBox TPass;
        private FontAwesome.Sharp.IconButton BClose;
    }
}