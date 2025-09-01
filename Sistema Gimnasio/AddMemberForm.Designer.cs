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
            this.TName.Location = new System.Drawing.Point(82, 28);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(210, 20);
            this.TName.TabIndex = 0;
            // 
            // TLastName
            // 
            this.TLastName.Location = new System.Drawing.Point(461, 24);
            this.TLastName.Name = "TLastName";
            this.TLastName.Size = new System.Drawing.Size(298, 20);
            this.TLastName.TabIndex = 1;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(27, 31);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(44, 13);
            this.LName.TabIndex = 2;
            this.LName.Text = "Nombre";
            // 
            // LLastName
            // 
            this.LLastName.AutoSize = true;
            this.LLastName.Location = new System.Drawing.Point(334, 31);
            this.LLastName.Name = "LLastName";
            this.LLastName.Size = new System.Drawing.Size(44, 13);
            this.LLastName.TabIndex = 3;
            this.LLastName.Text = "Apellido";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(27, 65);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(26, 13);
            this.LDni.TabIndex = 4;
            this.LDni.Text = "DNI";
            // 
            // LPhone
            // 
            this.LPhone.AutoSize = true;
            this.LPhone.Location = new System.Drawing.Point(329, 69);
            this.LPhone.Name = "LPhone";
            this.LPhone.Size = new System.Drawing.Size(49, 13);
            this.LPhone.TabIndex = 5;
            this.LPhone.Text = "Telefono";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Location = new System.Drawing.Point(27, 102);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(32, 13);
            this.LEmail.TabIndex = 6;
            this.LEmail.Text = "Email";
            // 
            // LContactE
            // 
            this.LContactE.AutoSize = true;
            this.LContactE.Location = new System.Drawing.Point(329, 102);
            this.LContactE.Name = "LContactE";
            this.LContactE.Size = new System.Drawing.Size(126, 13);
            this.LContactE.TabIndex = 7;
            this.LContactE.Text = "Contacto de emergencia ";
            // 
            // LObservation
            // 
            this.LObservation.AutoSize = true;
            this.LObservation.Location = new System.Drawing.Point(27, 142);
            this.LObservation.Name = "LObservation";
            this.LObservation.Size = new System.Drawing.Size(78, 13);
            this.LObservation.TabIndex = 8;
            this.LObservation.Text = "Observaciones";
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(79, 62);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(213, 20);
            this.TDni.TabIndex = 9;
            // 
            // TPhone
            // 
            this.TPhone.Location = new System.Drawing.Point(461, 65);
            this.TPhone.Name = "TPhone";
            this.TPhone.Size = new System.Drawing.Size(298, 20);
            this.TPhone.TabIndex = 10;
            // 
            // TEmail
            // 
            this.TEmail.Location = new System.Drawing.Point(82, 99);
            this.TEmail.Name = "TEmail";
            this.TEmail.Size = new System.Drawing.Size(210, 20);
            this.TEmail.TabIndex = 11;
            // 
            // TContactE
            // 
            this.TContactE.Location = new System.Drawing.Point(461, 99);
            this.TContactE.Name = "TContactE";
            this.TContactE.Size = new System.Drawing.Size(298, 20);
            this.TContactE.TabIndex = 12;
            // 
            // TObservation
            // 
            this.TObservation.Location = new System.Drawing.Point(30, 168);
            this.TObservation.Multiline = true;
            this.TObservation.Name = "TObservation";
            this.TObservation.Size = new System.Drawing.Size(729, 200);
            this.TObservation.TabIndex = 13;
            // 
            // BSave
            // 
            this.BSave.Location = new System.Drawing.Point(187, 401);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(75, 23);
            this.BSave.TabIndex = 14;
            this.BSave.Text = "Guardar";
            this.BSave.UseVisualStyleBackColor = true;
            // 
            // BClean
            // 
            this.BClean.Location = new System.Drawing.Point(525, 401);
            this.BClean.Name = "BClean";
            this.BClean.Size = new System.Drawing.Size(75, 23);
            this.BClean.TabIndex = 15;
            this.BClean.Text = "Limpiar";
            this.BClean.UseVisualStyleBackColor = true;
            // 
            // AddMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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