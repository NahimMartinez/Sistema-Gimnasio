using FontAwesome.Sharp;
using Presentation;
using System.Windows.Forms;

namespace Sistema_Gimnasio
{
    partial class AddSupplierForm
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
            this.LPhone = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.TPhone = new System.Windows.Forms.TextBox();
            this.TEmail = new System.Windows.Forms.TextBox();
            this.BSave = new FontAwesome.Sharp.IconButton();
            this.BClean = new FontAwesome.Sharp.IconButton();
            this.TCuit = new System.Windows.Forms.TextBox();
            this.LCuit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TName
            // 
            this.TName.Location = new System.Drawing.Point(82, 28);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(210, 20);
            this.TName.TabIndex = 0;
            this.TName.BackColor = UITheme.Surface;
            // 
            // TLastName
            // 
            this.TLastName.Location = new System.Drawing.Point(82, 58);
            this.TLastName.Name = "TLastName";
            this.TLastName.Size = new System.Drawing.Size(210, 20);
            this.TLastName.TabIndex = 1;
            this.TLastName.BackColor = UITheme.Surface;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(27, 31);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(44, 13);
            this.LName.TabIndex = 2;
            this.LName.Text = "Nombre";
            this.LName.ForeColor = UITheme.Text.Default;
            this.LName.BackColor = UITheme.Surface;
            this.LName.Font = new System.Drawing.Font("Segoe UI", 10F);

            // 
            // LLastName
            // 
            this.LLastName.AutoSize = true;
            this.LLastName.Location = new System.Drawing.Point(27, 61);
            this.LLastName.Name = "LLastName";
            this.LLastName.Size = new System.Drawing.Size(44, 13);
            this.LLastName.TabIndex = 3;
            this.LLastName.Text = "Apellido";
            this.LLastName.ForeColor = UITheme.Text.Default;
            this.LLastName.BackColor = UITheme.Surface;
            this.LLastName.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // LPhone
            // 
            this.LPhone.AutoSize = true;
            this.LPhone.Location = new System.Drawing.Point(27, 166);
            this.LPhone.Name = "LPhone";
            this.LPhone.Size = new System.Drawing.Size(49, 13);
            this.LPhone.TabIndex = 5;
            this.LPhone.Text = "Telefono";
            this.LPhone.ForeColor = UITheme.Text.Default;
            this.LPhone.BackColor = UITheme.Surface;
            this.LPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Location = new System.Drawing.Point(27, 127);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(32, 13);
            this.LEmail.TabIndex = 6;
            this.LEmail.Text = "Email";
            this.LEmail.ForeColor = UITheme.Text.Default;
            this.LEmail.BackColor = UITheme.Surface;
            this.LEmail.Font = new System.Drawing.Font("Segoe UI", 10F);

            // 
            // TPhone
            // 
            this.TPhone.Location = new System.Drawing.Point(79, 163);
            this.TPhone.Name = "TPhone";
            this.TPhone.Size = new System.Drawing.Size(213, 20);
            this.TPhone.TabIndex = 10;
            this.TPhone.BackColor = UITheme.Surface;
            // 
            // TEmail
            // 
            this.TEmail.Location = new System.Drawing.Point(79, 127);
            this.TEmail.Name = "TEmail";
            this.TEmail.Size = new System.Drawing.Size(213, 20);
            this.TEmail.TabIndex = 11;
            this.TEmail.BackColor = UITheme.Surface;
            // 
            // BSave
            // 
            this.BSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.BSave.FlatAppearance.BorderSize = 0;
            this.BSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSave.ForeColor = System.Drawing.Color.White;
            this.BSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BSave.IconColor = System.Drawing.Color.White;
            this.BSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BSave.IconSize = 24;
            this.BSave.Location = new System.Drawing.Point(47, 219);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(84, 30);
            this.BSave.TabIndex = 14;
            this.BSave.Text = "Guardar";
            this.BSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BSave.UseVisualStyleBackColor = false;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // BClean
            // 
            this.BClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.BClean.FlatAppearance.BorderSize = 0;
            this.BClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BClean.ForeColor = System.Drawing.Color.White;
            this.BClean.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.BClean.IconColor = System.Drawing.Color.White;
            this.BClean.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BClean.IconSize = 24;
            this.BClean.Location = new System.Drawing.Point(184, 219);
            this.BClean.Name = "BClean";
            this.BClean.Size = new System.Drawing.Size(78, 30);
            this.BClean.TabIndex = 15;
            this.BClean.Text = "Limpiar";
            this.BClean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BClean.UseVisualStyleBackColor = false;
            this.BClean.Click += new System.EventHandler(this.BClean_Click);
            // 
            // TCuit
            // 
            this.TCuit.Location = new System.Drawing.Point(79, 90);
            this.TCuit.Name = "TCuit";
            this.TCuit.Size = new System.Drawing.Size(213, 20);
            this.TCuit.TabIndex = 12;
            this.TCuit.BackColor = UITheme.Surface;
            this.TCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TCuit_KeyPress);
            // 
            // LCuit
            // 
            this.LCuit.AutoSize = true;
            this.LCuit.Location = new System.Drawing.Point(27, 93);
            this.LCuit.Name = "LCuit";
            this.LCuit.Size = new System.Drawing.Size(32, 13);
            this.LCuit.TabIndex = 7;
            this.LCuit.Text = "CUIT";
            this.LCuit.ForeColor = UITheme.Text.Default;
            this.LCuit.BackColor = UITheme.Surface;
            this.LCuit.Font = new System.Drawing.Font("Segoe UI", 10F);

            // 
            // AddSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(337, 288);
            this.Controls.Add(this.BClean);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.TCuit);
            this.Controls.Add(this.TEmail);
            this.Controls.Add(this.TPhone);
            this.Controls.Add(this.LCuit);
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.LPhone);
            this.Controls.Add(this.LLastName);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.TLastName);
            this.Controls.Add(this.TName);
            this.Name = "AddSupplierForm";
            this.Text = "Nuevo Proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();
            //color del tema
            this.BackColor = UITheme.Surface;

        }

        #endregion

        private System.Windows.Forms.TextBox TName;
        private System.Windows.Forms.TextBox TLastName;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label LLastName;
        private System.Windows.Forms.Label LPhone;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.TextBox TPhone;
        private System.Windows.Forms.TextBox TEmail;
        private FontAwesome.Sharp.IconButton BSave;
        private FontAwesome.Sharp.IconButton BClean;
        private System.Windows.Forms.TextBox TCuit;
        private System.Windows.Forms.Label LCuit;
    }
}