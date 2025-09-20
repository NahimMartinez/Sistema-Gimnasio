using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Sistema_Gimnasio
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Sidebar = new System.Windows.Forms.Panel();
            this.MenuFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.BDashboard = new FontAwesome.Sharp.IconButton();
            this.MenuIcons = new System.Windows.Forms.ImageList(this.components);
            this.BtnUsers = new FontAwesome.Sharp.IconButton();
            this.BtnPartners = new FontAwesome.Sharp.IconButton();
            this.BSupplier = new FontAwesome.Sharp.IconButton();
            this.PSubMenuSupplier = new System.Windows.Forms.Panel();
            this.BProvList = new System.Windows.Forms.Button();
            this.BPurchaseOrders = new System.Windows.Forms.Button();
            this.BActivity = new FontAwesome.Sharp.IconButton();
            this.BInventory = new FontAwesome.Sharp.IconButton();
            this.BReports = new FontAwesome.Sharp.IconButton();
            this.PanelUser = new System.Windows.Forms.Panel();
            this.LRole = new System.Windows.Forms.Label();
            this.LUser = new System.Windows.Forms.Label();
            this.PUser = new System.Windows.Forms.PictureBox();
            this.PanelBrand = new System.Windows.Forms.Panel();
            this.LBrand2 = new System.Windows.Forms.Label();
            this.LogoDot = new FontAwesome.Sharp.IconPictureBox();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.hideTimer = new System.Windows.Forms.Timer(this.components);
            this.Sidebar.SuspendLayout();
            this.MenuFlow.SuspendLayout();
            this.PSubMenuSupplier.SuspendLayout();
            this.PanelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PUser)).BeginInit();
            this.PanelBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoDot)).BeginInit();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.Sidebar.Controls.Add(this.MenuFlow);
            this.Sidebar.Controls.Add(this.PanelUser);
            this.Sidebar.Controls.Add(this.PanelBrand);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(338, 624);
            this.Sidebar.TabIndex = 0;
            // 
            // MenuFlow
            // 
            this.MenuFlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.MenuFlow.Controls.Add(this.BDashboard);
            this.MenuFlow.Controls.Add(this.BtnUsers);
            this.MenuFlow.Controls.Add(this.BtnPartners);
            this.MenuFlow.Controls.Add(this.BSupplier);
            this.MenuFlow.Controls.Add(this.PSubMenuSupplier);
            this.MenuFlow.Controls.Add(this.BActivity);
            this.MenuFlow.Controls.Add(this.BInventory);
            this.MenuFlow.Controls.Add(this.BReports);
            this.MenuFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MenuFlow.Location = new System.Drawing.Point(0, 113);
            this.MenuFlow.Name = "MenuFlow";
            this.MenuFlow.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.MenuFlow.Size = new System.Drawing.Size(338, 417);
            this.MenuFlow.TabIndex = 0;
            this.MenuFlow.WrapContents = false;
            // 
            // BDashboard
            // 
            this.BDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.BDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.BDashboard.FlatAppearance.BorderSize = 0;
            this.BDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BDashboard.ForeColor = System.Drawing.Color.White;
            this.BDashboard.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BDashboard.IconColor = System.Drawing.Color.Black;
            this.BDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BDashboard.ImageKey = "dashboard";
            this.BDashboard.ImageList = this.MenuIcons;
            this.BDashboard.Location = new System.Drawing.Point(3, 11);
            this.BDashboard.Name = "BDashboard";
            this.BDashboard.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BDashboard.Size = new System.Drawing.Size(332, 42);
            this.BDashboard.TabIndex = 0;
            this.BDashboard.Text = "    Dashboard";
            this.BDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BDashboard.UseVisualStyleBackColor = false;
            // 
            // MenuIcons
            // 
            this.MenuIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.MenuIcons.ImageSize = new System.Drawing.Size(20, 20);
            this.MenuIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // BtnUsers
            // 
            this.BtnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnUsers.FlatAppearance.BorderSize = 0;
            this.BtnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnUsers.ForeColor = System.Drawing.Color.White;
            this.BtnUsers.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnUsers.IconColor = System.Drawing.Color.Black;
            this.BtnUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsers.ImageKey = "users";
            this.BtnUsers.ImageList = this.MenuIcons;
            this.BtnUsers.Location = new System.Drawing.Point(3, 59);
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnUsers.Size = new System.Drawing.Size(332, 42);
            this.BtnUsers.TabIndex = 1;
            this.BtnUsers.Text = "    Usuarios";
            this.BtnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUsers.UseVisualStyleBackColor = true;
            // 
            // BtnPartners
            // 
            this.BtnPartners.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPartners.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPartners.FlatAppearance.BorderSize = 0;
            this.BtnPartners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPartners.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnPartners.ForeColor = System.Drawing.Color.White;
            this.BtnPartners.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnPartners.IconColor = System.Drawing.Color.Black;
            this.BtnPartners.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPartners.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPartners.ImageKey = "partners";
            this.BtnPartners.ImageList = this.MenuIcons;
            this.BtnPartners.Location = new System.Drawing.Point(3, 107);
            this.BtnPartners.Name = "BtnPartners";
            this.BtnPartners.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnPartners.Size = new System.Drawing.Size(332, 42);
            this.BtnPartners.TabIndex = 2;
            this.BtnPartners.Text = "    Socios";
            this.BtnPartners.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPartners.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPartners.UseVisualStyleBackColor = true;
            // 
            // BSupplier
            // 
            this.BSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.BSupplier.FlatAppearance.BorderSize = 0;
            this.BSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSupplier.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BSupplier.ForeColor = System.Drawing.Color.White;
            this.BSupplier.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BSupplier.IconColor = System.Drawing.Color.Black;
            this.BSupplier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSupplier.ImageKey = "payments";
            this.BSupplier.ImageList = this.MenuIcons;
            this.BSupplier.Location = new System.Drawing.Point(3, 155);
            this.BSupplier.Name = "BSupplier";
            this.BSupplier.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BSupplier.Size = new System.Drawing.Size(332, 42);
            this.BSupplier.TabIndex = 4;
            this.BSupplier.Text = "    Proveedores";
            this.BSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BSupplier.UseVisualStyleBackColor = true;
            this.BSupplier.MouseLeave += new System.EventHandler(this.BSupplier_MouseLeave);
            this.BSupplier.MouseHover += new System.EventHandler(this.BSupplier_MouseHover);
            // 
            // PSubMenuSupplier
            // 
            this.PSubMenuSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.PSubMenuSupplier.Controls.Add(this.BProvList);
            this.PSubMenuSupplier.Controls.Add(this.BPurchaseOrders);
            this.PSubMenuSupplier.Location = new System.Drawing.Point(0, 200);
            this.PSubMenuSupplier.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.PSubMenuSupplier.Name = "PSubMenuSupplier";
            this.PSubMenuSupplier.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.PSubMenuSupplier.Size = new System.Drawing.Size(338, 84);
            this.PSubMenuSupplier.TabIndex = 5;
            this.PSubMenuSupplier.Visible = false;
            this.PSubMenuSupplier.MouseLeave += new System.EventHandler(this.PSubMenuSupplier_MouseLeave);
            // 
            // BProvList
            // 
            this.BProvList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BProvList.FlatAppearance.BorderSize = 0;
            this.BProvList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BProvList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BProvList.ForeColor = System.Drawing.Color.White;
            this.BProvList.Location = new System.Drawing.Point(0, 0);
            this.BProvList.Name = "BProvList";
            this.BProvList.Size = new System.Drawing.Size(202, 40);
            this.BProvList.TabIndex = 0;
            this.BProvList.Text = "             Lista de proveedores";
            this.BProvList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BProvList.Click += new System.EventHandler(this.BProvList_Click);
            // 
            // BPurchaseOrders
            // 
            this.BPurchaseOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BPurchaseOrders.FlatAppearance.BorderSize = 0;
            this.BPurchaseOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BPurchaseOrders.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BPurchaseOrders.ForeColor = System.Drawing.Color.White;
            this.BPurchaseOrders.Location = new System.Drawing.Point(0, 42);
            this.BPurchaseOrders.Name = "BPurchaseOrders";
            this.BPurchaseOrders.Size = new System.Drawing.Size(202, 40);
            this.BPurchaseOrders.TabIndex = 1;
            this.BPurchaseOrders.Text = "             Órdenes de compra";
            this.BPurchaseOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BPurchaseOrders.Click += new System.EventHandler(this.BPurchaseOrders_Click);
            // 
            // BActivity
            // 
            this.BActivity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BActivity.Dock = System.Windows.Forms.DockStyle.Top;
            this.BActivity.FlatAppearance.BorderSize = 0;
            this.BActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BActivity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BActivity.ForeColor = System.Drawing.Color.White;
            this.BActivity.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BActivity.IconColor = System.Drawing.Color.Black;
            this.BActivity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BActivity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BActivity.ImageKey = "classes";
            this.BActivity.ImageList = this.MenuIcons;
            this.BActivity.Location = new System.Drawing.Point(3, 293);
            this.BActivity.Name = "BActivity";
            this.BActivity.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BActivity.Size = new System.Drawing.Size(332, 42);
            this.BActivity.TabIndex = 5;
            this.BActivity.Text = "    Clases";
            this.BActivity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BActivity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BActivity.UseVisualStyleBackColor = true;
            // 
            // BInventory
            // 
            this.BInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.BInventory.FlatAppearance.BorderSize = 0;
            this.BInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BInventory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BInventory.ForeColor = System.Drawing.Color.White;
            this.BInventory.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BInventory.IconColor = System.Drawing.Color.Black;
            this.BInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BInventory.ImageKey = "inventory";
            this.BInventory.ImageList = this.MenuIcons;
            this.BInventory.Location = new System.Drawing.Point(3, 341);
            this.BInventory.Name = "BInventory";
            this.BInventory.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BInventory.Size = new System.Drawing.Size(332, 42);
            this.BInventory.TabIndex = 6;
            this.BInventory.Text = "    Inventario";
            this.BInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BInventory.UseVisualStyleBackColor = true;
            // 
            // BReports
            // 
            this.BReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.BReports.FlatAppearance.BorderSize = 0;
            this.BReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BReports.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BReports.ForeColor = System.Drawing.Color.White;
            this.BReports.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BReports.IconColor = System.Drawing.Color.Black;
            this.BReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BReports.ImageKey = "reports";
            this.BReports.ImageList = this.MenuIcons;
            this.BReports.Location = new System.Drawing.Point(3, 389);
            this.BReports.Name = "BReports";
            this.BReports.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BReports.Size = new System.Drawing.Size(332, 42);
            this.BReports.TabIndex = 7;
            this.BReports.Text = "    Reportes";
            this.BReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BReports.UseVisualStyleBackColor = true;
            // 
            // PanelUser
            // 
            this.PanelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.PanelUser.Controls.Add(this.LRole);
            this.PanelUser.Controls.Add(this.LUser);
            this.PanelUser.Controls.Add(this.PUser);
            this.PanelUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelUser.Location = new System.Drawing.Point(0, 530);
            this.PanelUser.Name = "PanelUser";
            this.PanelUser.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.PanelUser.Size = new System.Drawing.Size(338, 94);
            this.PanelUser.TabIndex = 8;
            // 
            // LRole
            // 
            this.LRole.AutoSize = true;
            this.LRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LRole.ForeColor = System.Drawing.Color.Silver;
            this.LRole.Location = new System.Drawing.Point(60, 50);
            this.LRole.Name = "LRole";
            this.LRole.Size = new System.Drawing.Size(80, 15);
            this.LRole.TabIndex = 2;
            this.LRole.Text = "Administrator";
            // 
            // LUser
            // 
            this.LUser.AutoSize = true;
            this.LUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LUser.ForeColor = System.Drawing.Color.White;
            this.LUser.Location = new System.Drawing.Point(60, 31);
            this.LUser.Name = "LUser";
            this.LUser.Size = new System.Drawing.Size(82, 19);
            this.LUser.TabIndex = 1;
            this.LUser.Text = "Admin User";
            // 
            // PUser
            // 
            this.PUser.Location = new System.Drawing.Point(15, 24);
            this.PUser.Name = "PUser";
            this.PUser.Size = new System.Drawing.Size(34, 35);
            this.PUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PUser.TabIndex = 0;
            this.PUser.TabStop = false;
            // 
            // PanelBrand
            // 
            this.PanelBrand.Controls.Add(this.LBrand2);
            this.PanelBrand.Controls.Add(this.LogoDot);
            this.PanelBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBrand.Location = new System.Drawing.Point(0, 0);
            this.PanelBrand.Name = "PanelBrand";
            this.PanelBrand.Padding = new System.Windows.Forms.Padding(10, 14, 10, 14);
            this.PanelBrand.Size = new System.Drawing.Size(338, 113);
            this.PanelBrand.TabIndex = 0;
            // 
            // LBrand2
            // 
            this.LBrand2.AutoSize = true;
            this.LBrand2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LBrand2.ForeColor = System.Drawing.Color.White;
            this.LBrand2.Location = new System.Drawing.Point(48, 42);
            this.LBrand2.Name = "LBrand2";
            this.LBrand2.Size = new System.Drawing.Size(137, 21);
            this.LBrand2.TabIndex = 2;
            this.LBrand2.Text = "GymManager Pro";
            // 
            // LogoDot
            // 
            this.LogoDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.LogoDot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LogoDot.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            this.LogoDot.IconColor = System.Drawing.SystemColors.ControlText;
            this.LogoDot.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogoDot.IconSize = 29;
            this.LogoDot.Location = new System.Drawing.Point(13, 34);
            this.LogoDot.Name = "LogoDot";
            this.LogoDot.Size = new System.Drawing.Size(29, 29);
            this.LogoDot.TabIndex = 0;
            this.LogoDot.TabStop = false;
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(338, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(588, 624);
            this.contentPanel.TabIndex = 1;
            // 
            // hideTimer
            // 
            this.hideTimer.Interval = 150;
            this.hideTimer.Tick += new System.EventHandler(this.HideTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 624);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "GymManager Pro";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.Sidebar.ResumeLayout(false);
            this.MenuFlow.ResumeLayout(false);
            this.PSubMenuSupplier.ResumeLayout(false);
            this.PanelUser.ResumeLayout(false);
            this.PanelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PUser)).EndInit();
            this.PanelBrand.ResumeLayout(false);
            this.PanelBrand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoDot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.Panel PanelBrand;
        private FontAwesome.Sharp.IconPictureBox LogoDot;
        private FontAwesome.Sharp.IconButton BDashboard;
        private FontAwesome.Sharp.IconButton BtnUsers;
        private FontAwesome.Sharp.IconButton BtnPartners;
        private FontAwesome.Sharp.IconButton BSupplier;
        private FontAwesome.Sharp.IconButton BActivity;
        private FontAwesome.Sharp.IconButton BInventory;
        private FontAwesome.Sharp.IconButton BReports;
        private System.Windows.Forms.Panel PanelUser;
        private System.Windows.Forms.PictureBox PUser;
        private System.Windows.Forms.Label LUser;
        private System.Windows.Forms.Label LRole;
        private System.Windows.Forms.Label LBrand2;
        private System.Windows.Forms.ImageList MenuIcons;
        private Panel contentPanel;
        private System.Windows.Forms.FlowLayoutPanel MenuFlow;
        private System.Windows.Forms.Panel PSubMenuSupplier;
        private System.Windows.Forms.Button BProvList;
        private System.Windows.Forms.Button BPurchaseOrders;
        private System.Windows.Forms.Timer hideTimer;
    }
}

