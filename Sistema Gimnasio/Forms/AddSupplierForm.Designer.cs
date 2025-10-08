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
            this.LName = new System.Windows.Forms.Label();
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
            this.TName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.TName.Location = new System.Drawing.Point(82, 28);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(210, 20);
            this.TName.TabIndex = 0;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.LName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.LName.Location = new System.Drawing.Point(27, 31);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(59, 19);
            this.LName.TabIndex = 2;
            this.LName.Text = "Nombre";
            // 
            // LPhone
            // 
            this.LPhone.AutoSize = true;
            this.LPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.LPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.LPhone.Location = new System.Drawing.Point(13, 138);
            this.LPhone.Name = "LPhone";
            this.LPhone.Size = new System.Drawing.Size(60, 19);
            this.LPhone.TabIndex = 5;
            this.LPhone.Text = "Telefono";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.LEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.LEmail.Location = new System.Drawing.Point(27, 101);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(41, 19);
            this.LEmail.TabIndex = 6;
            this.LEmail.Text = "Email";
            // 
            // TPhone
            // 
            this.TPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.TPhone.Location = new System.Drawing.Point(79, 138);
            this.TPhone.Name = "TPhone";
            this.TPhone.Size = new System.Drawing.Size(213, 20);
            this.TPhone.TabIndex = 10;
            // 
            // TEmail
            // 
            this.TEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.TEmail.Location = new System.Drawing.Point(79, 101);
            this.TEmail.Name = "TEmail";
            this.TEmail.Size = new System.Drawing.Size(213, 20);
            this.TEmail.TabIndex = 11;
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
            this.BSave.Location = new System.Drawing.Point(31, 186);
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
            this.BClean.Location = new System.Drawing.Point(190, 186);
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
            this.TCuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.TCuit.Location = new System.Drawing.Point(79, 64);
            this.TCuit.Name = "TCuit";
            this.TCuit.Size = new System.Drawing.Size(213, 20);
            this.TCuit.TabIndex = 12;
            this.TCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TCuit_KeyPress);
            // 
            // LCuit
            // 
            this.LCuit.AutoSize = true;
            this.LCuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.LCuit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LCuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.LCuit.Location = new System.Drawing.Point(27, 67);
            this.LCuit.Name = "LCuit";
            this.LCuit.Size = new System.Drawing.Size(39, 19);
            this.LCuit.TabIndex = 7;
            this.LCuit.Text = "CUIT";
            // 
            // AddSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(328, 239);
            this.Controls.Add(this.BClean);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.TCuit);
            this.Controls.Add(this.TEmail);
            this.Controls.Add(this.TPhone);
            this.Controls.Add(this.LCuit);
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.LPhone);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.TName);
            this.Name = "AddSupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TName;
        private System.Windows.Forms.Label LName;
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