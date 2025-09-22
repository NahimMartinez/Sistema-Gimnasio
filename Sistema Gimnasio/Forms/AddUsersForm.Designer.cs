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
            this.BSave = new FontAwesome.Sharp.IconButton();
            this.BLimpiar = new FontAwesome.Sharp.IconButton();
            this.CBVerContraseña = new System.Windows.Forms.CheckBox();
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
            this.LUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LUserName.Location = new System.Drawing.Point(452, 36);
            this.LUserName.Name = "LUserName";
            this.LUserName.Size = new System.Drawing.Size(62, 20);
            this.LUserName.TabIndex = 0;
            this.LUserName.Text = "Usuario:";
            // 
            // LUserPass
            // 
            this.LUserPass.AutoSize = true;
            this.LUserPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LUserPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LUserPass.Location = new System.Drawing.Point(452, 85);
            this.LUserPass.Name = "LUserPass";
            this.LUserPass.Size = new System.Drawing.Size(86, 20);
            this.LUserPass.TabIndex = 1;
            this.LUserPass.Text = "Contraseña:";
            // 
            // LUserRol
            // 
            this.LUserRol.AutoSize = true;
            this.LUserRol.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LUserRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LUserRol.Location = new System.Drawing.Point(452, 176);
            this.LUserRol.Name = "LUserRol";
            this.LUserRol.Size = new System.Drawing.Size(34, 20);
            this.LUserRol.TabIndex = 2;
            this.LUserRol.Text = "Rol:";
            // 
            // LUserPass2
            // 
            this.LUserPass2.AutoSize = true;
            this.LUserPass2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LUserPass2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LUserPass2.Location = new System.Drawing.Point(452, 129);
            this.LUserPass2.Name = "LUserPass2";
            this.LUserPass2.Size = new System.Drawing.Size(136, 20);
            this.LUserPass2.TabIndex = 3;
            this.LUserPass2.Text = "Repetir contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsuario.Location = new System.Drawing.Point(589, 34);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(200, 27);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContraseña.Location = new System.Drawing.Point(589, 83);
            this.txtContraseña.MaxLength = 50;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '●';
            this.txtContraseña.Size = new System.Drawing.Size(200, 27);
            this.txtContraseña.TabIndex = 5;
            // 
            // txtContraseña2
            // 
            this.txtContraseña2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContraseña2.Location = new System.Drawing.Point(589, 127);
            this.txtContraseña2.MaxLength = 50;
            this.txtContraseña2.Name = "txtContraseña2";
            this.txtContraseña2.PasswordChar = '●';
            this.txtContraseña2.Size = new System.Drawing.Size(200, 27);
            this.txtContraseña2.TabIndex = 6;
            // 
            // CBRol
            // 
            this.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRol.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Location = new System.Drawing.Point(589, 174);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(200, 28);
            this.CBRol.TabIndex = 7;
            // 
            // BSave
            // 
            this.BSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.BSave.FlatAppearance.BorderSize = 0;
            this.BSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BSave.ForeColor = System.Drawing.Color.White;
            this.BSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BSave.IconColor = System.Drawing.Color.White;
            this.BSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BSave.IconSize = 24;
            this.BSave.Location = new System.Drawing.Point(306, 272);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(110, 30);
            this.BSave.TabIndex = 9;
            this.BSave.Text = "Guardar";
            this.BSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BSave.UseVisualStyleBackColor = false;
            this.BSave.Click += new System.EventHandler(this.BSave_Click_1);
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.BLimpiar.FlatAppearance.BorderSize = 0;
            this.BLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BLimpiar.ForeColor = System.Drawing.Color.White;
            this.BLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.BLimpiar.IconColor = System.Drawing.Color.White;
            this.BLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BLimpiar.IconSize = 24;
            this.BLimpiar.Location = new System.Drawing.Point(456, 272);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(110, 30);
            this.BLimpiar.TabIndex = 10;
            this.BLimpiar.Text = "Limpiar";
            this.BLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click_1);
            // 
            // CBVerContraseña
            // 
            this.CBVerContraseña.Appearance = System.Windows.Forms.Appearance.Button;
            this.CBVerContraseña.FlatAppearance.BorderSize = 0;
            this.CBVerContraseña.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.CBVerContraseña.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CBVerContraseña.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CBVerContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBVerContraseña.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CBVerContraseña.ForeColor = System.Drawing.Color.Gray;
            this.CBVerContraseña.Location = new System.Drawing.Point(795, 107);
            this.CBVerContraseña.Name = "CBVerContraseña";
            this.CBVerContraseña.Size = new System.Drawing.Size(40, 23);
            this.CBVerContraseña.TabIndex = 13;
            this.CBVerContraseña.Text = "👁️";
            this.CBVerContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CBVerContraseña.UseVisualStyleBackColor = true;
            this.CBVerContraseña.CheckedChanged += new System.EventHandler(this.CBVerContraseña_CheckedChanged);
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LNombre.Location = new System.Drawing.Point(45, 34);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(67, 20);
            this.LNombre.TabIndex = 14;
            this.LNombre.Text = "Nombre:";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LApellido.Location = new System.Drawing.Point(45, 84);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(69, 20);
            this.LApellido.TabIndex = 15;
            this.LApellido.Text = "Apellido:";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LDni.Location = new System.Drawing.Point(45, 129);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(38, 20);
            this.LDni.TabIndex = 16;
            this.LDni.Text = "DNI:";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LEmail.Location = new System.Drawing.Point(45, 176);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(49, 20);
            this.LEmail.TabIndex = 17;
            this.LEmail.Text = "Email:";
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LTelefono.Location = new System.Drawing.Point(45, 225);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(70, 20);
            this.LTelefono.TabIndex = 18;
            this.LTelefono.Text = "Teléfono:";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.Location = new System.Drawing.Point(124, 33);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 27);
            this.txtNombre.TabIndex = 19;
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtApellido.Location = new System.Drawing.Point(124, 83);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(300, 27);
            this.txtApellido.TabIndex = 20;
            // 
            // txtDni
            // 
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDni.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDni.Location = new System.Drawing.Point(124, 126);
            this.txtDni.MaxLength = 15;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(300, 27);
            this.txtDni.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(124, 173);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 27);
            this.txtEmail.TabIndex = 22;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelefono.Location = new System.Drawing.Point(124, 222);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(300, 27);
            this.txtTelefono.TabIndex = 23;
            // 
            // AddUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(850, 327);
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
            this.Controls.Add(this.CBVerContraseña);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.CBRol);
            this.Controls.Add(this.txtContraseña2);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.LUserPass2);
            this.Controls.Add(this.LUserRol);
            this.Controls.Add(this.LUserPass);
            this.Controls.Add(this.LUserName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(866, 339);
            this.Name = "AddUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Usuario";
            this.Load += new System.EventHandler(this.AddUsersForm_Load);
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
        private FontAwesome.Sharp.IconButton BSave;
        private FontAwesome.Sharp.IconButton BLimpiar;
        private System.Windows.Forms.CheckBox CBVerContraseña;
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