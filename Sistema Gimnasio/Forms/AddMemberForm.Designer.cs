namespace Sistema_Gimnasio
{
    partial class AddMemberForm
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
            this.TName = new System.Windows.Forms.TextBox();
            this.TLastName = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.Label();
            this.LLastName = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LPhone = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.LContactE = new System.Windows.Forms.Label();
            this.LObservation = new System.Windows.Forms.Label();
            this.TDni = new System.Windows.Forms.TextBox();
            this.TPhone = new System.Windows.Forms.TextBox();
            this.TEmail = new System.Windows.Forms.TextBox();
            this.TContactE = new System.Windows.Forms.TextBox();
            this.TObservation = new System.Windows.Forms.TextBox();
            this.BSave = new System.Windows.Forms.Button();
            this.BClean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TName
            // 
            this.TName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TName.Location = new System.Drawing.Point(40, 40);
            this.TName.MaxLength = 60;
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(300, 23);
            this.TName.TabIndex = 0;
            // 
            // TLastName
            // 
            this.TLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TLastName.Location = new System.Drawing.Point(430, 40);
            this.TLastName.MaxLength = 60;
            this.TLastName.Name = "TLastName";
            this.TLastName.Size = new System.Drawing.Size(330, 23);
            this.TLastName.TabIndex = 1;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LName.Location = new System.Drawing.Point(40, 20);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(51, 15);
            this.LName.TabIndex = 2;
            this.LName.Text = "Nombre";
            // 
            // LLastName
            // 
            this.LLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LLastName.AutoSize = true;
            this.LLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LLastName.Location = new System.Drawing.Point(430, 20);
            this.LLastName.Name = "LLastName";
            this.LLastName.Size = new System.Drawing.Size(51, 15);
            this.LLastName.TabIndex = 3;
            this.LLastName.Text = "Apellido";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LDni.Location = new System.Drawing.Point(40, 76);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(27, 15);
            this.LDni.TabIndex = 4;
            this.LDni.Text = "DNI";
            // 
            // LPhone
            // 
            this.LPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LPhone.AutoSize = true;
            this.LPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LPhone.Location = new System.Drawing.Point(430, 76);
            this.LPhone.Name = "LPhone";
            this.LPhone.Size = new System.Drawing.Size(53, 15);
            this.LPhone.TabIndex = 5;
            this.LPhone.Text = "Teléfono";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LEmail.Location = new System.Drawing.Point(40, 132);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(36, 15);
            this.LEmail.TabIndex = 6;
            this.LEmail.Text = "Email";
            // 
            // LContactE
            // 
            this.LContactE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LContactE.AutoSize = true;
            this.LContactE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LContactE.Location = new System.Drawing.Point(430, 132);
            this.LContactE.Name = "LContactE";
            this.LContactE.Size = new System.Drawing.Size(137, 15);
            this.LContactE.TabIndex = 7;
            this.LContactE.Text = "Contacto de emergencia";
            // 
            // LObservation
            // 
            this.LObservation.AutoSize = true;
            this.LObservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LObservation.Location = new System.Drawing.Point(40, 188);
            this.LObservation.Name = "LObservation";
            this.LObservation.Size = new System.Drawing.Size(84, 15);
            this.LObservation.TabIndex = 8;
            this.LObservation.Text = "Observaciones";
            // 
            // TDni
            // 
            this.TDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TDni.Location = new System.Drawing.Point(40, 94);
            this.TDni.MaxLength = 12;
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(300, 23);
            this.TDni.TabIndex = 9;
            // 
            // TPhone
            // 
            this.TPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TPhone.Location = new System.Drawing.Point(430, 94);
            this.TPhone.MaxLength = 20;
            this.TPhone.Name = "TPhone";
            this.TPhone.Size = new System.Drawing.Size(330, 23);
            this.TPhone.TabIndex = 10;
            // 
            // TEmail
            // 
            this.TEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEmail.Location = new System.Drawing.Point(40, 150);
            this.TEmail.MaxLength = 100;
            this.TEmail.Name = "TEmail";
            this.TEmail.Size = new System.Drawing.Size(300, 23);
            this.TEmail.TabIndex = 11;
            // 
            // TContactE
            // 
            this.TContactE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TContactE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TContactE.Location = new System.Drawing.Point(430, 150);
            this.TContactE.MaxLength = 100;
            this.TContactE.Name = "TContactE";
            this.TContactE.Size = new System.Drawing.Size(330, 23);
            this.TContactE.TabIndex = 12;
            // 
            // TObservation
            // 
            this.TObservation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TObservation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TObservation.Location = new System.Drawing.Point(40, 208);
            this.TObservation.MaxLength = 1000;
            this.TObservation.Multiline = true;
            this.TObservation.Name = "TObservation";
            this.TObservation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TObservation.Size = new System.Drawing.Size(720, 200);
            this.TObservation.TabIndex = 13;
            // 
            // BSave
            // 
            this.BSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.BSave.FlatAppearance.BorderSize = 0;
            this.BSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSave.ForeColor = System.Drawing.Color.White;
            this.BSave.Location = new System.Drawing.Point(240, 428);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(110, 30);
            this.BSave.TabIndex = 14;
            this.BSave.Text = "Guardar";
            this.BSave.UseVisualStyleBackColor = false;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // BClean
            // 
            this.BClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.BClean.FlatAppearance.BorderSize = 0;
            this.BClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BClean.ForeColor = System.Drawing.Color.White;
            this.BClean.Location = new System.Drawing.Point(470, 428);
            this.BClean.Name = "BClean";
            this.BClean.Size = new System.Drawing.Size(110, 30);
            this.BClean.TabIndex = 15;
            this.BClean.Text = "Limpiar";
            this.BClean.UseVisualStyleBackColor = false;
            this.BClean.Click += new System.EventHandler(this.BClean_Click);
            // 
            // AddMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(804, 481);
            this.Controls.Add(this.BClean);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.TObservation);
            this.Controls.Add(this.TContactE);
            this.Controls.Add(this.TEmail);
            this.Controls.Add(this.TPhone);
            this.Controls.Add(this.TDni);
            this.Controls.Add(this.LObservation);
            this.Controls.Add(this.LContactE);
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.LPhone);
            this.Controls.Add(this.LDni);
            this.Controls.Add(this.LLastName);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.TLastName);
            this.Controls.Add(this.TName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(820, 520);
            this.Name = "AddMemberForm";
            this.Text = "Nuevo Socio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TName;
        private System.Windows.Forms.TextBox TLastName;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label LLastName;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LPhone;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Label LContactE;
        private System.Windows.Forms.Label LObservation;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.TextBox TPhone;
        private System.Windows.Forms.TextBox TEmail;
        private System.Windows.Forms.TextBox TContactE;
        private System.Windows.Forms.TextBox TObservation;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.Button BClean;
    }
}