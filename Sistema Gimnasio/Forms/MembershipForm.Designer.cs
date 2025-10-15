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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LClass = new System.Windows.Forms.Label();
            this.LTotal = new System.Windows.Forms.Label();
            this.LTotalSum = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LMembership = new System.Windows.Forms.Label();
            this.CBMembership = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LPayMethod = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BCancel = new FontAwesome.Sharp.IconButton();
            this.BSave = new FontAwesome.Sharp.IconButton();
            this.BoardClass = new System.Windows.Forms.DataGridView();
            this.id_clase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdd = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoardClass)).BeginInit();
            this.SuspendLayout();
            // 
            // LClass
            // 
            this.LClass.AutoSize = true;
            this.LClass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LClass.Location = new System.Drawing.Point(12, 72);
            this.LClass.Name = "LClass";
            this.LClass.Size = new System.Drawing.Size(40, 15);
            this.LClass.TabIndex = 1;
            this.LClass.Text = "Clases";
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LTotal.Location = new System.Drawing.Point(557, 3);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(45, 15);
            this.LTotal.TabIndex = 2;
            this.LTotal.Text = "Total: $";
            // 
            // LTotalSum
            // 
            this.LTotalSum.AutoSize = true;
            this.LTotalSum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LTotalSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LTotalSum.Location = new System.Drawing.Point(620, 3);
            this.LTotalSum.Name = "LTotalSum";
            this.LTotalSum.Size = new System.Drawing.Size(22, 15);
            this.LTotalSum.TabIndex = 5;
            this.LTotalSum.Text = "0,0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LMembership);
            this.panel1.Controls.Add(this.CBMembership);
            this.panel1.Controls.Add(this.LClass);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 10;
            // 
            // LMembership
            // 
            this.LMembership.AutoSize = true;
            this.LMembership.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LMembership.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LMembership.Location = new System.Drawing.Point(12, 11);
            this.LMembership.Name = "LMembership";
            this.LMembership.Size = new System.Drawing.Size(66, 15);
            this.LMembership.TabIndex = 9;
            this.LMembership.Text = "Membresía";
            // 
            // CBMembership
            // 
            this.CBMembership.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMembership.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CBMembership.FormattingEnabled = true;            
            this.CBMembership.Location = new System.Drawing.Point(12, 34);
            this.CBMembership.Name = "CBMembership";
            this.CBMembership.Size = new System.Drawing.Size(130, 23);
            this.CBMembership.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.LPayMethod);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.BCancel);
            this.panel4.Controls.Add(this.BSave);
            this.panel4.Controls.Add(this.LTotalSum);
            this.panel4.Controls.Add(this.LTotal);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 350);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 100);
            this.panel4.TabIndex = 12;
            // 
            // LPayMethod
            // 
            this.LPayMethod.AutoSize = true;
            this.LPayMethod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LPayMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LPayMethod.Location = new System.Drawing.Point(557, 33);
            this.LPayMethod.Name = "LPayMethod";
            this.LPayMethod.Size = new System.Drawing.Size(95, 15);
            this.LPayMethod.TabIndex = 13;
            this.LPayMethod.Text = "Metodo de Pago";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta Debito",
            "Tarjeta Credito",
            "Transferencia"});
            this.comboBox1.Location = new System.Drawing.Point(557, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 23);
            this.comboBox1.TabIndex = 12;
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
            this.BCancel.Location = new System.Drawing.Point(420, 61);
            this.BCancel.Name = "BCancel";
            this.BCancel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BCancel.Size = new System.Drawing.Size(100, 27);
            this.BCancel.TabIndex = 21;
            this.BCancel.Text = "Cancelar";
            this.BCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCancel.UseVisualStyleBackColor = false;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
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
            this.BSave.Location = new System.Drawing.Point(241, 61);
            this.BSave.Name = "BSave";
            this.BSave.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BSave.Size = new System.Drawing.Size(98, 27);
            this.BSave.TabIndex = 22;
            this.BSave.Text = "Guardar";
            this.BSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSave.UseVisualStyleBackColor = false;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // BoardClass
            // 
            this.BoardClass.AllowUserToAddRows = false;
            this.BoardClass.AllowUserToDeleteRows = false;
            this.BoardClass.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.BoardClass.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.BoardClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BoardClass.BackgroundColor = System.Drawing.Color.White;
            this.BoardClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoardClass.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BoardClass.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BoardClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.BoardClass.ColumnHeadersHeight = 38;
            this.BoardClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BoardClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_clase,
            this.name,
            this.cupo,
            this.dia,
            this.hora,
            this.colAdd});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BoardClass.DefaultCellStyle = dataGridViewCellStyle6;
            this.BoardClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoardClass.EnableHeadersVisualStyles = false;
            this.BoardClass.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.BoardClass.Location = new System.Drawing.Point(0, 100);
            this.BoardClass.MultiSelect = false;
            this.BoardClass.Name = "BoardClass";
            this.BoardClass.ReadOnly = true;
            this.BoardClass.RowHeadersVisible = false;
            this.BoardClass.RowHeadersWidth = 51;
            this.BoardClass.RowTemplate.Height = 36;
            this.BoardClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BoardClass.Size = new System.Drawing.Size(800, 250);
            this.BoardClass.TabIndex = 13;
            // 
            // id_clase
            // 
            this.id_clase.HeaderText = "ID";
            this.id_clase.MinimumWidth = 6;
            this.id_clase.Name = "id_clase";
            this.id_clase.ReadOnly = true;
            this.id_clase.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Nombre";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // cupo
            // 
            this.cupo.DataPropertyName = "cupo";
            this.cupo.HeaderText = "Cupo";
            this.cupo.MinimumWidth = 6;
            this.cupo.Name = "cupo";
            this.cupo.ReadOnly = true;
            // 
            // dia
            // 
            this.dia.DataPropertyName = "dia";
            this.dia.HeaderText = "Día";
            this.dia.MinimumWidth = 6;
            this.dia.Name = "dia";
            this.dia.ReadOnly = true;
            // 
            // hora
            // 
            this.hora.DataPropertyName = "Horario";
            this.hora.HeaderText = "Hora";
            this.hora.MinimumWidth = 6;
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            // 
            // colAdd
            // 
            this.colAdd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colAdd.HeaderText = "";
            this.colAdd.MinimumWidth = 6;
            this.colAdd.Name = "colAdd";
            this.colAdd.ReadOnly = true;
            this.colAdd.Width = 50;
            // 
            // MembershipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BoardClass);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "MembershipForm";
            this.Text = "Membresia";
            this.Load += new System.EventHandler(this.MembershipForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoardClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LClass;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.Label LTotalSum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView BoardClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_clase;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewImageColumn colAdd;
        private System.Windows.Forms.Label LMembership;
        private System.Windows.Forms.ComboBox CBMembership;
        private FontAwesome.Sharp.IconButton BCancel;
        private FontAwesome.Sharp.IconButton BSave;
        private System.Windows.Forms.Label LPayMethod;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}