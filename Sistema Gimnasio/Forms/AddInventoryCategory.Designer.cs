namespace Sistema_Gimnasio.Forms
{
    partial class AddInventoryCategory
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
            this.BCancel = new FontAwesome.Sharp.IconButton();
            this.BSave = new FontAwesome.Sharp.IconButton();
            this.txtNewClassCategory = new System.Windows.Forms.TextBox();
            this.LNewClassCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BCancel
            // 
            this.BCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.BCancel.FlatAppearance.BorderSize = 0;
            this.BCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BCancel.ForeColor = System.Drawing.Color.White;
            this.BCancel.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.BCancel.IconColor = System.Drawing.Color.White;
            this.BCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BCancel.IconSize = 24;
            this.BCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCancel.Location = new System.Drawing.Point(232, 111);
            this.BCancel.Name = "BCancel";
            this.BCancel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BCancel.Size = new System.Drawing.Size(100, 27);
            this.BCancel.TabIndex = 19;
            this.BCancel.Text = "Cancelar";
            this.BCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCancel.UseVisualStyleBackColor = false;
            // 
            // BSave
            // 
            this.BSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.BSave.FlatAppearance.BorderSize = 0;
            this.BSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSave.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BSave.ForeColor = System.Drawing.Color.White;
            this.BSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BSave.IconColor = System.Drawing.Color.White;
            this.BSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BSave.IconSize = 24;
            this.BSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSave.Location = new System.Drawing.Point(53, 111);
            this.BSave.Name = "BSave";
            this.BSave.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BSave.Size = new System.Drawing.Size(98, 27);
            this.BSave.TabIndex = 20;
            this.BSave.Text = "Guardar";
            this.BSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSave.UseVisualStyleBackColor = false;
            // 
            // txtNewClassCategory
            // 
            this.txtNewClassCategory.Location = new System.Drawing.Point(99, 46);
            this.txtNewClassCategory.Name = "txtNewClassCategory";
            this.txtNewClassCategory.Size = new System.Drawing.Size(243, 20);
            this.txtNewClassCategory.TabIndex = 18;
            // 
            // LNewClassCategory
            // 
            this.LNewClassCategory.AutoSize = true;
            this.LNewClassCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LNewClassCategory.Location = new System.Drawing.Point(24, 46);
            this.LNewClassCategory.Name = "LNewClassCategory";
            this.LNewClassCategory.Size = new System.Drawing.Size(69, 17);
            this.LNewClassCategory.TabIndex = 17;
            this.LNewClassCategory.Text = "Categoría";
            // 
            // AddInventoryCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 160);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.txtNewClassCategory);
            this.Controls.Add(this.LNewClassCategory);
            this.Name = "AddInventoryCategory";
            this.Text = "Nueva Categoria de Inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BCancel;
        private FontAwesome.Sharp.IconButton BSave;
        private System.Windows.Forms.TextBox txtNewClassCategory;
        private System.Windows.Forms.Label LNewClassCategory;
    }
}