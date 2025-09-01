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
            this.LGestionUsuarios = new System.Windows.Forms.Label();
            this.BCrear = new System.Windows.Forms.Button();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.CBVerContraseña = new System.Windows.Forms.CheckBox();
            this.DGVUsuarios = new System.Windows.Forms.DataGridView();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LTablaUsuarios = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LEditarUsuario = new System.Windows.Forms.Label();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.BBuscarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // LUserName
            // 
            this.LUserName.AutoSize = true;
            this.LUserName.Location = new System.Drawing.Point(58, 67);
            this.LUserName.Name = "LUserName";
            this.LUserName.Size = new System.Drawing.Size(43, 13);
            this.LUserName.TabIndex = 0;
            this.LUserName.Text = "Usuario";
            // 
            // LUserPass
            // 
            this.LUserPass.AutoSize = true;
            this.LUserPass.Location = new System.Drawing.Point(58, 93);
            this.LUserPass.Name = "LUserPass";
            this.LUserPass.Size = new System.Drawing.Size(61, 13);
            this.LUserPass.TabIndex = 1;
            this.LUserPass.Text = "Contraseña";
            // 
            // LUserRol
            // 
            this.LUserRol.AutoSize = true;
            this.LUserRol.Location = new System.Drawing.Point(58, 147);
            this.LUserRol.Name = "LUserRol";
            this.LUserRol.Size = new System.Drawing.Size(23, 13);
            this.LUserRol.TabIndex = 2;
            this.LUserRol.Text = "Rol";
            // 
            // LUserPass2
            // 
            this.LUserPass2.AutoSize = true;
            this.LUserPass2.Location = new System.Drawing.Point(58, 123);
            this.LUserPass2.Name = "LUserPass2";
            this.LUserPass2.Size = new System.Drawing.Size(97, 13);
            this.LUserPass2.TabIndex = 3;
            this.LUserPass2.Text = "Repetir contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(161, 64);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(161, 90);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '●';
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 5;
            // 
            // txtContraseña2
            // 
            this.txtContraseña2.Location = new System.Drawing.Point(161, 118);
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
            this.CBRol.Location = new System.Drawing.Point(161, 144);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(100, 21);
            this.CBRol.TabIndex = 7;
            // 
            // LGestionUsuarios
            // 
            this.LGestionUsuarios.AutoSize = true;
            this.LGestionUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LGestionUsuarios.Location = new System.Drawing.Point(56, 32);
            this.LGestionUsuarios.Name = "LGestionUsuarios";
            this.LGestionUsuarios.Size = new System.Drawing.Size(119, 20);
            this.LGestionUsuarios.TabIndex = 8;
            this.LGestionUsuarios.Text = "Nuevo Usuario";
            this.LGestionUsuarios.Click += new System.EventHandler(this.label1_Click);
            // 
            // BCrear
            // 
            this.BCrear.Location = new System.Drawing.Point(61, 182);
            this.BCrear.Name = "BCrear";
            this.BCrear.Size = new System.Drawing.Size(75, 23);
            this.BCrear.TabIndex = 9;
            this.BCrear.Text = "Crear";
            this.BCrear.UseVisualStyleBackColor = true;
            // 
            // BLimpiar
            // 
            this.BLimpiar.Location = new System.Drawing.Point(186, 182);
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
            this.CBVerContraseña.Location = new System.Drawing.Point(267, 102);
            this.CBVerContraseña.Name = "CBVerContraseña";
            this.CBVerContraseña.Size = new System.Drawing.Size(38, 17);
            this.CBVerContraseña.TabIndex = 13;
            this.CBVerContraseña.Text = "👁️";
            this.CBVerContraseña.UseVisualStyleBackColor = true;
            this.CBVerContraseña.CheckedChanged += new System.EventHandler(this.CBVerContraseña1_CheckedChanged);
            // 
            // DGVUsuarios
            // 
            this.DGVUsuarios.AllowUserToOrderColumns = true;
            this.DGVUsuarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario,
            this.Rol,
            this.Estado});
            this.DGVUsuarios.Location = new System.Drawing.Point(60, 304);
            this.DGVUsuarios.Name = "DGVUsuarios";
            this.DGVUsuarios.Size = new System.Drawing.Size(344, 150);
            this.DGVUsuarios.TabIndex = 14;
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
            // LTablaUsuarios
            // 
            this.LTablaUsuarios.AutoSize = true;
            this.LTablaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LTablaUsuarios.Location = new System.Drawing.Point(56, 267);
            this.LTablaUsuarios.Name = "LTablaUsuarios";
            this.LTablaUsuarios.Size = new System.Drawing.Size(144, 20);
            this.LTablaUsuarios.TabIndex = 15;
            this.LTablaUsuarios.Text = "Usuarios Creados";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // LEditarUsuario
            // 
            this.LEditarUsuario.AutoSize = true;
            this.LEditarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LEditarUsuario.Location = new System.Drawing.Point(452, 32);
            this.LEditarUsuario.Name = "LEditarUsuario";
            this.LEditarUsuario.Size = new System.Drawing.Size(116, 20);
            this.LEditarUsuario.TabIndex = 16;
            this.LEditarUsuario.Text = "Editar Usuario";
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.AccessibleDescription = "";
            this.txtBuscarUsuario.Location = new System.Drawing.Point(456, 67);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(131, 20);
            this.txtBuscarUsuario.TabIndex = 17;
            this.txtBuscarUsuario.Tag = "";
            this.txtBuscarUsuario.Text = "nombre usuario";
            // 
            // BBuscarUsuario
            // 
            this.BBuscarUsuario.Location = new System.Drawing.Point(456, 102);
            this.BBuscarUsuario.Name = "BBuscarUsuario";
            this.BBuscarUsuario.Size = new System.Drawing.Size(75, 23);
            this.BBuscarUsuario.TabIndex = 18;
            this.BBuscarUsuario.Text = "Buscar";
            this.BBuscarUsuario.UseVisualStyleBackColor = true;
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.BBuscarUsuario);
            this.Controls.Add(this.txtBuscarUsuario);
            this.Controls.Add(this.LEditarUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LTablaUsuarios);
            this.Controls.Add(this.DGVUsuarios);
            this.Controls.Add(this.CBVerContraseña);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.BCrear);
            this.Controls.Add(this.LGestionUsuarios);
            this.Controls.Add(this.CBRol);
            this.Controls.Add(this.txtContraseña2);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.LUserPass2);
            this.Controls.Add(this.LUserRol);
            this.Controls.Add(this.LUserPass);
            this.Controls.Add(this.LUserName);
            this.Name = "users";
            this.Size = new System.Drawing.Size(667, 480);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).EndInit();
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
        private System.Windows.Forms.Label LGestionUsuarios;
        private System.Windows.Forms.Button BCrear;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.CheckBox CBVerContraseña;
        private System.Windows.Forms.DataGridView DGVUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label LTablaUsuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LEditarUsuario;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.Button BBuscarUsuario;
    }
}
