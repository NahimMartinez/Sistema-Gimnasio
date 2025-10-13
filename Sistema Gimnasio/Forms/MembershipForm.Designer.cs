namespace Sistema_Gimnasio.Forms
{
    partial class MembershipForm
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
            this.LTypeMemb = new System.Windows.Forms.Label();
            this.LClass = new System.Windows.Forms.Label();
            this.LTotal = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LTotalSum = new System.Windows.Forms.Label();
            this.BSave = new FontAwesome.Sharp.IconButton();
            this.BCancel = new FontAwesome.Sharp.IconButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LTypeMemb
            // 
            this.LTypeMemb.AutoSize = true;
            this.LTypeMemb.Location = new System.Drawing.Point(12, 9);
            this.LTypeMemb.Name = "LTypeMemb";
            this.LTypeMemb.Size = new System.Drawing.Size(114, 15);
            this.LTypeMemb.TabIndex = 0;
            this.LTypeMemb.Text = "Tipo de Membresia";
            // 
            // LClass
            // 
            this.LClass.AutoSize = true;
            this.LClass.Location = new System.Drawing.Point(12, 59);
            this.LClass.Name = "LClass";
            this.LClass.Size = new System.Drawing.Size(44, 15);
            this.LClass.TabIndex = 1;
            this.LClass.Text = "Clases";
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Location = new System.Drawing.Point(12, 316);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(34, 15);
            this.LTotal.TabIndex = 2;
            this.LTotal.Text = "Total";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // LTotalSum
            // 
            this.LTotalSum.AutoSize = true;
            this.LTotalSum.Location = new System.Drawing.Point(78, 316);
            this.LTotalSum.Name = "LTotalSum";
            this.LTotalSum.Size = new System.Drawing.Size(33, 15);
            this.LTotalSum.TabIndex = 5;
            this.LTotalSum.Text = "Sum";
            // 
            // BSave
            // 
            this.BSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BSave.IconColor = System.Drawing.Color.Black;
            this.BSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BSave.Location = new System.Drawing.Point(81, 399);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(75, 23);
            this.BSave.TabIndex = 6;
            this.BSave.Text = "Guardar";
            this.BSave.UseVisualStyleBackColor = true;
            // 
            // BCancel
            // 
            this.BCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BCancel.IconColor = System.Drawing.Color.Black;
            this.BCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BCancel.Location = new System.Drawing.Point(355, 398);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.TabIndex = 7;
            this.BCancel.Text = "Cancelar";
            this.BCancel.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(15, 90);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // MembershipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.LTotalSum);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LTotal);
            this.Controls.Add(this.LClass);
            this.Controls.Add(this.LTypeMemb);
            this.Name = "MembershipForm";
            this.Text = "MembershipForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTypeMemb;
        private System.Windows.Forms.Label LClass;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LTotalSum;
        private FontAwesome.Sharp.IconButton BSave;
        private FontAwesome.Sharp.IconButton BCancel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}