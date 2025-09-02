namespace Sistema_Gimnasio
{
    partial class AddUsersForm
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
            this.BCrear = new System.Windows.Forms.Button();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.CBVerContraseña = new System.Windows.Forms.CheckBox();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.LTelefono = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LUserName
            // 
            this.LUserName.AutoSize = true;
            this.LUserName.Location = new System.Drawing.Point(452, 65);
            this.LUserName.Name = "LUserName";
            this.LUserName.Size = new System.Drawing.Size(43, 13);
            this.LUserName.TabIndex = 0;
            this.LUserName.Text = "Usuario";
            // 
            // LUserPass
            // 
            this.LUserPass.AutoSize = true;
            this.LUserPass.Location = new System.Drawing.Point(452, 91);
            this.LUserPass.Name = "LUserPass";
            this.LUserPass.Size = new System.Drawing.Size(61, 13);
            this.LUserPass.TabIndex = 1;
            this.LUserPass.Text = "Contraseña";
            // 
            // LUserRol
            // 
            this.LUserRol.AutoSize = true;
            this.LUserRol.Location = new System.Drawing.Point(452, 145);
            this.LUserRol.Name = "LUserRol";
            this.LUserRol.Size = new System.Drawing.Size(23, 13);
            this.LUserRol.TabIndex = 2;
            this.LUserRol.Text = "Rol";
            // 
            // LUserPass2
            // 
            this.LUserPass2.AutoSize = true;
            this.LUserPass2.Location = new System.Drawing.Point(452, 119);
            this.LUserPass2.Name = "LUserPass2";
            this.LUserPass2.Size = new System.Drawing.Size(97, 13);
            this.LUserPass2.TabIndex = 3;
            this.LUserPass2.Text = "Repetir contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(555, 62);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(149, 20);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(555, 88);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '●';
            this.txtContraseña.Size = new System.Drawing.Size(149, 20);
            this.txtContraseña.TabIndex = 5;
            // 
            // txtContraseña2
            // 
            this.txtContraseña2.Location = new System.Drawing.Point(555, 116);
            this.txtContraseña2.Name = "txtContraseña2";
            this.txtContraseña2.PasswordChar = '●';
            this.txtContraseña2.Size = new System.Drawing.Size(149, 20);
            this.txtContraseña2.TabIndex = 6;
            // 
            // CBRol
            // 
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Items.AddRange(new object[] {
            "Administrador",
            "Coach",
            "Recepcionista"});
            this.CBRol.Location = new System.Drawing.Point(555, 142);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(149, 21);
            this.CBRol.TabIndex = 7;
            // 
            // BCrear
            // 
            this.BCrear.Location = new System.Drawing.Point(160, 258);
            this.BCrear.Name = "BCrear";
            this.BCrear.Size = new System.Drawing.Size(75, 23);
            this.BCrear.TabIndex = 9;
            this.BCrear.Text = "Crear";
            this.BCrear.UseVisualStyleBackColor = true;
            // 
            // BLimpiar
            // 
            this.BLimpiar.Location = new System.Drawing.Point(506, 258);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BLimpiar.TabIndex = 10;
            this.BLimpiar.Text = "Limpiar";
            this.BLimpiar.UseVisualStyleBackColor = true;
            // 
            // CBVerContraseña
            // 
            this.CBVerContraseña.AutoSize = true;
            this.CBVerContraseña.Location = new System.Drawing.Point(713, 103);
            this.CBVerContraseña.Name = "CBVerContraseña";
            this.CBVerContraseña.Size = new System.Drawing.Size(38, 17);
            this.CBVerContraseña.TabIndex = 13;
            this.CBVerContraseña.Text = "👁️";
            this.CBVerContraseña.UseVisualStyleBackColor = true;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(45, 65);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(44, 13);
            this.LNombre.TabIndex = 14;
            this.LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(45, 91);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(44, 13);
            this.LApellido.TabIndex = 15;
            this.LApellido.Text = "Apellido";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(45, 119);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(26, 13);
            this.LDni.TabIndex = 16;
            this.LDni.Text = "DNI";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Location = new System.Drawing.Point(45, 145);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(32, 13);
            this.LEmail.TabIndex = 17;
            this.LEmail.Text = "Email";
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Location = new System.Drawing.Point(45, 169);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(49, 13);
            this.LTelefono.TabIndex = 18;
            this.LTelefono.Text = "Teléfono";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(95, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(342, 20);
            this.txtNombre.TabIndex = 19;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(95, 88);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(342, 20);
            this.txtApellido.TabIndex = 20;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(95, 114);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(342, 20);
            this.txtDni.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(95, 140);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(342, 20);
            this.txtEmail.TabIndex = 22;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(95, 166);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(342, 20);
            this.txtTelefono.TabIndex = 23;
            // 
            // AddUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.LTelefono);
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.LDni);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBVerContraseña);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.BCrear);
            this.Controls.Add(this.CBRol);
            this.Controls.Add(this.txtContraseña2);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.LUserPass2);
            this.Controls.Add(this.LUserRol);
            this.Controls.Add(this.LUserPass);
            this.Controls.Add(this.LUserName);
            this.Name = "AddUsersForm";
            this.Text = "Nuevo Usuario";
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
        private System.Windows.Forms.Button BCrear;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.CheckBox CBVerContraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LEditarUsuario;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.Button BBuscarUsuario;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
    }
}