namespace Sistema_Gimnasio.Forms
{
    partial class BackupForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.BSave = new FontAwesome.Sharp.IconButton();
            this.txtRoad = new System.Windows.Forms.TextBox();
            this.BRoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.label1.Location = new System.Drawing.Point(146, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copia de Seguridad";
            // 
            // BSave
            // 
            this.BSave.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.BSave.IconColor = System.Drawing.Color.Black;
            this.BSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BSave.IconSize = 20;
            this.BSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSave.Location = new System.Drawing.Point(190, 220);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(146, 44);
            this.BSave.TabIndex = 1;
            this.BSave.Text = "Generar Copia";
            this.BSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // txtRoad
            // 
            this.txtRoad.Location = new System.Drawing.Point(49, 160);
            this.txtRoad.Name = "txtRoad";
            this.txtRoad.Size = new System.Drawing.Size(384, 22);
            this.txtRoad.TabIndex = 2;
            // 
            // BRoad
            // 
            this.BRoad.Location = new System.Drawing.Point(454, 156);
            this.BRoad.Name = "BRoad";
            this.BRoad.Size = new System.Drawing.Size(75, 31);
            this.BRoad.TabIndex = 3;
            this.BRoad.Text = "Ruta";
            this.BRoad.UseVisualStyleBackColor = true;
            this.BRoad.Click += new System.EventHandler(this.BRoad_Click);
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 276);
            this.Controls.Add(this.BRoad);
            this.Controls.Add(this.txtRoad);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.label1);
            this.Name = "BackupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copia de Seguridad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BSave;
        private System.Windows.Forms.TextBox txtRoad;
        private System.Windows.Forms.Button BRoad;
    }
}