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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtContraseña2 = new System.Windows.Forms.TextBox();
            this.CBRol = new System.Windows.Forms.ComboBox();
            this.LNewUser = new System.Windows.Forms.Label();
            this.BCrear = new System.Windows.Forms.Button();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.CBVerContraseña = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LUserName
            // 
            this.LUserName.AutoSize = true;
            this.LUserName.Location = new System.Drawing.Point(56, 65);
            this.LUserName.Name = "LUserName";
            this.LUserName.Size = new System.Drawing.Size(43, 13);
            this.LUserName.TabIndex = 0;
            this.LUserName.Text = "Usuario";
            // 
            // LUserPass
            // 
            this.LUserPass.AutoSize = true;
            this.LUserPass.Location = new System.Drawing.Point(56, 91);
            this.LUserPass.Name = "LUserPass";
            this.LUserPass.Size = new System.Drawing.Size(61, 13);
            this.LUserPass.TabIndex = 1;
            this.LUserPass.Text = "Contraseña";
            // 
            // LUserRol
            // 
            this.LUserRol.AutoSize = true;
            this.LUserRol.Location = new System.Drawing.Point(56, 145);
            this.LUserRol.Name = "LUserRol";
            this.LUserRol.Size = new System.Drawing.Size(23, 13);
            this.LUserRol.TabIndex = 2;
            this.LUserRol.Text = "Rol";
            // 
            // LUserPass2
            // 
            this.LUserPass2.AutoSize = true;
            this.LUserPass2.Location = new System.Drawing.Point(56, 121);
            this.LUserPass2.Name = "LUserPass2";
            this.LUserPass2.Size = new System.Drawing.Size(97, 13);
            this.LUserPass2.TabIndex = 3;
            this.LUserPass2.Text = "Repetir contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(159, 62);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(159, 88);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '●';
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 5;
            // 
            // txtContraseña2
            // 
            this.txtContraseña2.Location = new System.Drawing.Point(159, 116);
            this.txtContraseña2.Name = "txtContraseña2";
            this.txtContraseña2.PasswordChar = '●';
            this.txtContraseña2.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña2.TabIndex = 6;
            // 
            // CBRol
            // 
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Items.AddRange(new object[] {
            "Administrador",
            "Coach",
            "Recepcionista"});
            this.CBRol.Location = new System.Drawing.Point(159, 142);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(100, 21);
            this.CBRol.TabIndex = 7;
            // 
            // LNewUser
            // 
            this.LNewUser.AutoSize = true;
            this.LNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LNewUser.Location = new System.Drawing.Point(107, 20);
            this.LNewUser.Name = "LNewUser";
            this.LNewUser.Size = new System.Drawing.Size(119, 20);
            this.LNewUser.TabIndex = 8;
            this.LNewUser.Text = "Nuevo Usuario";
            this.LNewUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // BCrear
            // 
            this.BCrear.Location = new System.Drawing.Point(59, 180);
            this.BCrear.Name = "BCrear";
            this.BCrear.Size = new System.Drawing.Size(75, 23);
            this.BCrear.TabIndex = 9;
            this.BCrear.Text = "Crear";
            this.BCrear.UseVisualStyleBackColor = true;
            // 
            // BLimpiar
            // 
            this.BLimpiar.Location = new System.Drawing.Point(184, 180);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BLimpiar.TabIndex = 10;
            this.BLimpiar.Text = "Limpiar";
            this.BLimpiar.UseVisualStyleBackColor = true;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // CBVerContraseña
            // 
            this.CBVerContraseña.AutoSize = true;
            this.CBVerContraseña.Location = new System.Drawing.Point(265, 100);
            this.CBVerContraseña.Name = "CBVerContraseña";
            this.CBVerContraseña.Size = new System.Drawing.Size(38, 17);
            this.CBVerContraseña.TabIndex = 13;
            this.CBVerContraseña.Text = "👁️";
            this.CBVerContraseña.UseVisualStyleBackColor = true;
            this.CBVerContraseña.CheckedChanged += new System.EventHandler(this.CBVerContraseña1_CheckedChanged);
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CBVerContraseña);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.BCrear);
            this.Controls.Add(this.LNewUser);
            this.Controls.Add(this.CBRol);
            this.Controls.Add(this.txtContraseña2);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
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
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtContraseña2;
        private System.Windows.Forms.ComboBox CBRol;
        private System.Windows.Forms.Label LNewUser;
        private System.Windows.Forms.Button BCrear;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.CheckBox CBVerContraseña;
    }
}
