using System.Windows.Forms;

namespace Sistema_Gimnasio
{
    partial class PartnersView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LTiltePartne = new System.Windows.Forms.Label();
            this.BoardMember = new System.Windows.Forms.DataGridView();
            this.idPartner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membership = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoMembresia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.colView = new System.Windows.Forms.DataGridViewImageColumn();
            this.colViewPdf = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.CBMembership = new System.Windows.Forms.ComboBox();
            this.TSearchPartner = new System.Windows.Forms.TextBox();
            this.LStatus = new System.Windows.Forms.Label();
            this.LMembership = new System.Windows.Forms.Label();
            this.BNewMember = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnNextPage = new FontAwesome.Sharp.IconButton();
            this.btnPrevPage = new FontAwesome.Sharp.IconButton();
            this.BRenovation = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.BoardMember)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LTiltePartne
            // 
            this.LTiltePartne.AutoSize = true;
            this.LTiltePartne.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.LTiltePartne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.LTiltePartne.Location = new System.Drawing.Point(14, 12);
            this.LTiltePartne.Name = "LTiltePartne";
            this.LTiltePartne.Size = new System.Drawing.Size(206, 32);
            this.LTiltePartne.TabIndex = 0;
            this.LTiltePartne.Text = "Gestión de Socios";
            // 
            // BoardMember
            // 
            this.BoardMember.AllowUserToAddRows = false;
            this.BoardMember.AllowUserToDeleteRows = false;
            this.BoardMember.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.BoardMember.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.BoardMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BoardMember.BackgroundColor = System.Drawing.Color.White;
            this.BoardMember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoardMember.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BoardMember.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BoardMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.BoardMember.ColumnHeadersHeight = 38;
            this.BoardMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BoardMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPartner,
            this.name,
            this.lastName,
            this.dni,
            this.Telefono,
            this.membership,
            this.fechaVencimiento,
            this.estadoMembresia,
            this.status,
            this.colEdit,
            this.colView,
            this.colViewPdf,
            this.colDelete});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BoardMember.DefaultCellStyle = dataGridViewCellStyle6;
            this.BoardMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoardMember.EnableHeadersVisualStyles = false;
            this.BoardMember.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.BoardMember.Location = new System.Drawing.Point(0, 100);
            this.BoardMember.MultiSelect = false;
            this.BoardMember.Name = "BoardMember";
            this.BoardMember.ReadOnly = true;
            this.BoardMember.RowHeadersVisible = false;
            this.BoardMember.RowHeadersWidth = 51;
            this.BoardMember.RowTemplate.Height = 36;
            this.BoardMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BoardMember.Size = new System.Drawing.Size(762, 450);
            this.BoardMember.TabIndex = 1;
            // 
            // idPartner
            // 
            this.idPartner.DataPropertyName = "IdPersona";
            this.idPartner.MinimumWidth = 6;
            this.idPartner.Name = "idPartner";
            this.idPartner.ReadOnly = true;
            this.idPartner.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "Nombre";
            this.name.HeaderText = "Nombre";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.DataPropertyName = "Apellido";
            this.lastName.HeaderText = "Apellido";
            this.lastName.MinimumWidth = 6;
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // dni
            // 
            this.dni.DataPropertyName = "dni";
            this.dni.HeaderText = "DNI";
            this.dni.MinimumWidth = 6;
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // membership
            // 
            this.membership.DataPropertyName = "Membresia";
            this.membership.HeaderText = "Membresía";
            this.membership.MinimumWidth = 6;
            this.membership.Name = "membership";
            this.membership.ReadOnly = true;
            // 
            // fechaVencimiento
            // 
            this.fechaVencimiento.DataPropertyName = "FechaVencimiento";
            this.fechaVencimiento.HeaderText = "Vencimiento";
            this.fechaVencimiento.MinimumWidth = 6;
            this.fechaVencimiento.Name = "fechaVencimiento";
            this.fechaVencimiento.ReadOnly = true;
            // 
            // estadoMembresia
            // 
            this.estadoMembresia.DataPropertyName = "EstadoMembresia";
            this.estadoMembresia.HeaderText = "Estado Membresía";
            this.estadoMembresia.MinimumWidth = 6;
            this.estadoMembresia.Name = "estadoMembresia";
            this.estadoMembresia.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "Estado";
            this.status.HeaderText = "Estado";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // colEdit
            // 
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEdit.HeaderText = "";
            this.colEdit.MinimumWidth = 6;
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Width = 50;
            // 
            // colView
            // 
            this.colView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colView.HeaderText = "";
            this.colView.MinimumWidth = 6;
            this.colView.Name = "colView";
            this.colView.ReadOnly = true;
            this.colView.Width = 50;
            // 
            // colViewPdf
            // 
            this.colViewPdf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colViewPdf.HeaderText = "";
            this.colViewPdf.MinimumWidth = 6;
            this.colViewPdf.Name = "colViewPdf";
            this.colViewPdf.ReadOnly = true;
            this.colViewPdf.Width = 50;
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDelete.HeaderText = "";
            this.colDelete.MinimumWidth = 6;
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Width = 50;
            // 
            // CBStatus
            // 
            this.CBStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CBStatus.FormattingEnabled = true;
            this.CBStatus.Items.AddRange(new object[] {
            "Todos",
            "Activo",
            "Inactivo"});
            this.CBStatus.Location = new System.Drawing.Point(168, 66);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(130, 28);
            this.CBStatus.TabIndex = 2;
            // 
            // CBMembership
            // 
            this.CBMembership.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMembership.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CBMembership.FormattingEnabled = true;
            this.CBMembership.Items.AddRange(new object[] {
            "Todos",
            "Vigente",
            "Vencida"});
            this.CBMembership.Location = new System.Drawing.Point(304, 66);
            this.CBMembership.Name = "CBMembership";
            this.CBMembership.Size = new System.Drawing.Size(130, 28);
            this.CBMembership.TabIndex = 3;
            // 
            // TSearchPartner
            // 
            this.TSearchPartner.BackColor = System.Drawing.Color.White;
            this.TSearchPartner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TSearchPartner.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TSearchPartner.ForeColor = System.Drawing.Color.Gray;
            this.TSearchPartner.Location = new System.Drawing.Point(18, 66);
            this.TSearchPartner.Name = "TSearchPartner";
            this.TSearchPartner.Size = new System.Drawing.Size(144, 27);
            this.TSearchPartner.TabIndex = 5;
            this.TSearchPartner.Text = "Buscar socio...";
            // 
            // LStatus
            // 
            this.LStatus.AutoSize = true;
            this.LStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LStatus.Location = new System.Drawing.Point(165, 48);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(54, 20);
            this.LStatus.TabIndex = 6;
            this.LStatus.Text = "Estado";
            // 
            // LMembership
            // 
            this.LMembership.AutoSize = true;
            this.LMembership.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LMembership.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.LMembership.Location = new System.Drawing.Point(301, 48);
            this.LMembership.Name = "LMembership";
            this.LMembership.Size = new System.Drawing.Size(83, 20);
            this.LMembership.TabIndex = 7;
            this.LMembership.Text = "Membresía";
            // 
            // BNewMember
            // 
            this.BNewMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BNewMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            this.BNewMember.FlatAppearance.BorderSize = 0;
            this.BNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNewMember.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BNewMember.ForeColor = System.Drawing.Color.White;
            this.BNewMember.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BNewMember.IconColor = System.Drawing.Color.White;
            this.BNewMember.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BNewMember.IconSize = 20;
            this.BNewMember.Location = new System.Drawing.Point(613, 64);
            this.BNewMember.Name = "BNewMember";
            this.BNewMember.Size = new System.Drawing.Size(137, 26);
            this.BNewMember.TabIndex = 8;
            this.BNewMember.Text = "Nuevo socio";
            this.BNewMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BNewMember.UseVisualStyleBackColor = false;
            this.BNewMember.Click += new System.EventHandler(this.BNewMember_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblPageInfo);
            this.panel1.Controls.Add(this.btnNextPage);
            this.panel1.Controls.Add(this.btnPrevPage);
            this.panel1.Controls.Add(this.BRenovation);
            this.panel1.Controls.Add(this.LTiltePartne);
            this.panel1.Controls.Add(this.BNewMember);
            this.panel1.Controls.Add(this.TSearchPartner);
            this.panel1.Controls.Add(this.LMembership);
            this.panel1.Controls.Add(this.CBStatus);
            this.panel1.Controls.Add(this.LStatus);
            this.panel1.Controls.Add(this.CBMembership);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panel1.Size = new System.Drawing.Size(762, 100);
            this.panel1.TabIndex = 9;
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.lblPageInfo.Location = new System.Drawing.Point(344, 67);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(98, 20);
            this.lblPageInfo.TabIndex = 12;
            this.lblPageInfo.Text = "Página 1 de 1";
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextPage.BackColor = System.Drawing.Color.White;
            this.btnNextPage.FlatAppearance.BorderSize = 0;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.btnNextPage.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnNextPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNextPage.IconSize = 18;
            this.btnNextPage.Location = new System.Drawing.Point(480, 64);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(26, 26);
            this.btnNextPage.TabIndex = 11;
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevPage.BackColor = System.Drawing.Color.White;
            this.btnPrevPage.FlatAppearance.BorderSize = 0;
            this.btnPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevPage.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.btnPrevPage.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnPrevPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrevPage.IconSize = 18;
            this.btnPrevPage.Location = new System.Drawing.Point(448, 64);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(26, 26);
            this.btnPrevPage.TabIndex = 10;
            this.btnPrevPage.UseVisualStyleBackColor = false;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // BRenovation
            // 
            this.BRenovation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BRenovation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            this.BRenovation.FlatAppearance.BorderSize = 0;
            this.BRenovation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRenovation.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BRenovation.ForeColor = System.Drawing.Color.White;
            this.BRenovation.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.BRenovation.IconColor = System.Drawing.Color.White;
            this.BRenovation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BRenovation.IconSize = 20;
            this.BRenovation.Location = new System.Drawing.Point(507, 64);
            this.BRenovation.Name = "BRenovation";
            this.BRenovation.Size = new System.Drawing.Size(100, 26);
            this.BRenovation.TabIndex = 9;
            this.BRenovation.Text = "Renovar ";
            this.BRenovation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BRenovation.UseVisualStyleBackColor = false;
            this.BRenovation.Click += new System.EventHandler(this.BRenovation_Click);
            // 
            // PartnersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.BoardMember);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "PartnersView";
            this.Size = new System.Drawing.Size(762, 550);
            ((System.ComponentModel.ISupportInitialize)(this.BoardMember)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LTiltePartne;
        private System.Windows.Forms.DataGridView BoardMember;
        private System.Windows.Forms.ComboBox CBStatus;
        private System.Windows.Forms.ComboBox CBMembership;
        private System.Windows.Forms.TextBox TSearchPartner;
        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.Label LMembership;
        private FontAwesome.Sharp.IconButton BNewMember;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn membership;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoMembresia;
        private System.Windows.Forms.DataGridViewImageColumn colEdit;
        private System.Windows.Forms.DataGridViewImageColumn colView;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
        private System.Windows.Forms.DataGridViewImageColumn colViewPdf;
        private DataGridViewTextBoxColumn idPartner;
        private DataGridViewTextBoxColumn Telefono;
        private FontAwesome.Sharp.IconButton BRenovation;
        private FontAwesome.Sharp.IconButton btnPrevPage;
        private FontAwesome.Sharp.IconButton btnNextPage;
        private System.Windows.Forms.Label lblPageInfo;
    }
}
