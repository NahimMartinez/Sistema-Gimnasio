using FontAwesome.Sharp;

namespace Sistema_Gimnasio.Controls
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cardMembers = new System.Windows.Forms.Panel();
            this.labelMembersCount = new System.Windows.Forms.Label();
            this.labelMembersTitle = new System.Windows.Forms.Label();
            this.iconPartner = new FontAwesome.Sharp.IconPictureBox();
            this.cardClasses = new System.Windows.Forms.Panel();
            this.labelClassesCount = new System.Windows.Forms.Label();
            this.labelClassesTitle = new System.Windows.Forms.Label();
            this.iconClass = new FontAwesome.Sharp.IconPictureBox();
            this.cardRevenue = new System.Windows.Forms.Panel();
            this.labelRevenueAmount = new System.Windows.Forms.Label();
            this.labelRevenueTitle = new System.Windows.Forms.Label();
            this.iconIncome = new FontAwesome.Sharp.IconPictureBox();
            this.panelCharts = new System.Windows.Forms.Panel();
            this.LChartPie = new System.Windows.Forms.Label();
            this.CPMemberships = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartIngresosMensuales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelChartTitle = new System.Windows.Forms.Label();
            this.panelRecentActivity = new System.Windows.Forms.Panel();
            this.BoardRecent = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Membresia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_alta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelActivityTitle = new System.Windows.Forms.Label();
            this.listViewActivity = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.NewCategoryInventory = new FontAwesome.Sharp.IconButton();
            this.NewCategoryClass = new FontAwesome.Sharp.IconButton();
            this.panelHeader.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.cardMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPartner)).BeginInit();
            this.cardClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClass)).BeginInit();
            this.cardRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconIncome)).BeginInit();
            this.panelCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPMemberships)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIngresosMensuales)).BeginInit();
            this.panelRecentActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoardRecent)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelHeader.Size = new System.Drawing.Size(1324, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelTitle.Location = new System.Drawing.Point(15, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(120, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Dashboard";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.Controls.Add(this.cardMembers);
            this.flowLayoutPanel.Controls.Add(this.cardClasses);
            this.flowLayoutPanel.Controls.Add(this.cardRevenue);
            this.flowLayoutPanel.Location = new System.Drawing.Point(20, 85);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(684, 120);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // cardMembers
            // 
            this.cardMembers.BackColor = System.Drawing.Color.White;
            this.cardMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardMembers.Controls.Add(this.labelMembersCount);
            this.cardMembers.Controls.Add(this.labelMembersTitle);
            this.cardMembers.Controls.Add(this.iconPartner);
            this.cardMembers.Location = new System.Drawing.Point(3, 3);
            this.cardMembers.Margin = new System.Windows.Forms.Padding(3, 3, 75, 3);
            this.cardMembers.Name = "cardMembers";
            this.cardMembers.Padding = new System.Windows.Forms.Padding(15);
            this.cardMembers.Size = new System.Drawing.Size(170, 110);
            this.cardMembers.TabIndex = 0;
            // 
            // labelMembersCount
            // 
            this.labelMembersCount.AutoSize = true;
            this.labelMembersCount.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMembersCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelMembersCount.Location = new System.Drawing.Point(15, 15);
            this.labelMembersCount.Name = "labelMembersCount";
            this.labelMembersCount.Size = new System.Drawing.Size(54, 32);
            this.labelMembersCount.TabIndex = 2;
            this.labelMembersCount.Text = "248";
            // 
            // labelMembersTitle
            // 
            this.labelMembersTitle.AutoSize = true;
            this.labelMembersTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMembersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.labelMembersTitle.Location = new System.Drawing.Point(15, 55);
            this.labelMembersTitle.Name = "labelMembersTitle";
            this.labelMembersTitle.Size = new System.Drawing.Size(41, 15);
            this.labelMembersTitle.TabIndex = 1;
            this.labelMembersTitle.Text = "Socios";
            // 
            // iconPartner
            // 
            this.iconPartner.BackColor = System.Drawing.Color.White;
            this.iconPartner.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPartner.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPartner.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPartner.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPartner.Location = new System.Drawing.Point(120, 15);
            this.iconPartner.Name = "iconPartner";
            this.iconPartner.Size = new System.Drawing.Size(32, 32);
            this.iconPartner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPartner.TabIndex = 0;
            this.iconPartner.TabStop = false;
            // 
            // cardClasses
            // 
            this.cardClasses.BackColor = System.Drawing.Color.White;
            this.cardClasses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardClasses.Controls.Add(this.labelClassesCount);
            this.cardClasses.Controls.Add(this.labelClassesTitle);
            this.cardClasses.Controls.Add(this.iconClass);
            this.cardClasses.Location = new System.Drawing.Point(251, 3);
            this.cardClasses.Margin = new System.Windows.Forms.Padding(3, 3, 75, 3);
            this.cardClasses.Name = "cardClasses";
            this.cardClasses.Padding = new System.Windows.Forms.Padding(15);
            this.cardClasses.Size = new System.Drawing.Size(170, 110);
            this.cardClasses.TabIndex = 1;
            // 
            // labelClassesCount
            // 
            this.labelClassesCount.AutoSize = true;
            this.labelClassesCount.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClassesCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelClassesCount.Location = new System.Drawing.Point(15, 15);
            this.labelClassesCount.Name = "labelClassesCount";
            this.labelClassesCount.Size = new System.Drawing.Size(41, 32);
            this.labelClassesCount.TabIndex = 3;
            this.labelClassesCount.Text = "24";
            // 
            // labelClassesTitle
            // 
            this.labelClassesTitle.AutoSize = true;
            this.labelClassesTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClassesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.labelClassesTitle.Location = new System.Drawing.Point(15, 55);
            this.labelClassesTitle.Name = "labelClassesTitle";
            this.labelClassesTitle.Size = new System.Drawing.Size(40, 15);
            this.labelClassesTitle.TabIndex = 2;
            this.labelClassesTitle.Text = "Clases";
            // 
            // iconClass
            // 
            this.iconClass.BackColor = System.Drawing.Color.White;
            this.iconClass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconClass.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconClass.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconClass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconClass.Location = new System.Drawing.Point(120, 15);
            this.iconClass.Name = "iconClass";
            this.iconClass.Size = new System.Drawing.Size(32, 32);
            this.iconClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconClass.TabIndex = 1;
            this.iconClass.TabStop = false;
            // 
            // cardRevenue
            // 
            this.cardRevenue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardRevenue.BackColor = System.Drawing.Color.White;
            this.cardRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardRevenue.Controls.Add(this.labelRevenueAmount);
            this.cardRevenue.Controls.Add(this.labelRevenueTitle);
            this.cardRevenue.Controls.Add(this.iconIncome);
            this.cardRevenue.Location = new System.Drawing.Point(499, 3);
            this.cardRevenue.Name = "cardRevenue";
            this.cardRevenue.Padding = new System.Windows.Forms.Padding(15);
            this.cardRevenue.Size = new System.Drawing.Size(170, 110);
            this.cardRevenue.TabIndex = 2;
            // 
            // labelRevenueAmount
            // 
            this.labelRevenueAmount.AutoSize = true;
            this.labelRevenueAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRevenueAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelRevenueAmount.Location = new System.Drawing.Point(8, 15);
            this.labelRevenueAmount.Name = "labelRevenueAmount";
            this.labelRevenueAmount.Size = new System.Drawing.Size(80, 25);
            this.labelRevenueAmount.TabIndex = 4;
            this.labelRevenueAmount.Text = "$12,450";
            // 
            // labelRevenueTitle
            // 
            this.labelRevenueTitle.AutoSize = true;
            this.labelRevenueTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.labelRevenueTitle.Location = new System.Drawing.Point(10, 55);
            this.labelRevenueTitle.Name = "labelRevenueTitle";
            this.labelRevenueTitle.Size = new System.Drawing.Size(65, 15);
            this.labelRevenueTitle.TabIndex = 3;
            this.labelRevenueTitle.Text = "Ingresos M";
            // 
            // iconIncome
            // 
            this.iconIncome.BackColor = System.Drawing.Color.White;
            this.iconIncome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconIncome.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconIncome.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconIncome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconIncome.Location = new System.Drawing.Point(120, 15);
            this.iconIncome.Name = "iconIncome";
            this.iconIncome.Size = new System.Drawing.Size(32, 32);
            this.iconIncome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconIncome.TabIndex = 2;
            this.iconIncome.TabStop = false;
            // 
            // panelCharts
            // 
            this.panelCharts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCharts.BackColor = System.Drawing.Color.White;
            this.panelCharts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCharts.Controls.Add(this.LChartPie);
            this.panelCharts.Controls.Add(this.CPMemberships);
            this.panelCharts.Controls.Add(this.chartIngresosMensuales);
            this.panelCharts.Controls.Add(this.labelChartTitle);
            this.panelCharts.Location = new System.Drawing.Point(24, 220);
            this.panelCharts.Name = "panelCharts";
            this.panelCharts.Padding = new System.Windows.Forms.Padding(15);
            this.panelCharts.Size = new System.Drawing.Size(1297, 354);
            this.panelCharts.TabIndex = 2;
            // 
            // LChartPie
            // 
            this.LChartPie.AutoSize = true;
            this.LChartPie.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LChartPie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.LChartPie.Location = new System.Drawing.Point(803, 15);
            this.LChartPie.Name = "LChartPie";
            this.LChartPie.Size = new System.Drawing.Size(173, 21);
            this.LChartPie.TabIndex = 3;
            this.LChartPie.Text = "Socios por membresia";
            // 
            // CPMemberships
            // 
            this.CPMemberships.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.CPMemberships.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CPMemberships.Legends.Add(legend1);
            this.CPMemberships.Location = new System.Drawing.Point(808, 34);
            this.CPMemberships.Name = "CPMemberships";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.CPMemberships.Series.Add(series1);
            this.CPMemberships.Size = new System.Drawing.Size(469, 300);
            this.CPMemberships.TabIndex = 2;
            this.CPMemberships.Text = "chart1";
            // 
            // chartIngresosMensuales
            // 
            chartArea2.Name = "ChartArea1";
            this.chartIngresosMensuales.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartIngresosMensuales.Legends.Add(legend2);
            this.chartIngresosMensuales.Location = new System.Drawing.Point(18, 46);
            this.chartIngresosMensuales.Name = "chartIngresosMensuales";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartIngresosMensuales.Series.Add(series2);
            this.chartIngresosMensuales.Size = new System.Drawing.Size(784, 300);
            this.chartIngresosMensuales.TabIndex = 1;
            this.chartIngresosMensuales.Text = "chart1";
            // 
            // labelChartTitle
            // 
            this.labelChartTitle.AutoSize = true;
            this.labelChartTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelChartTitle.Location = new System.Drawing.Point(15, 15);
            this.labelChartTitle.Name = "labelChartTitle";
            this.labelChartTitle.Size = new System.Drawing.Size(154, 21);
            this.labelChartTitle.TabIndex = 0;
            this.labelChartTitle.Text = "Ingresos Mensuales";
            // 
            // panelRecentActivity
            // 
            this.panelRecentActivity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRecentActivity.BackColor = System.Drawing.Color.White;
            this.panelRecentActivity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRecentActivity.Controls.Add(this.BoardRecent);
            this.panelRecentActivity.Controls.Add(this.labelActivityTitle);
            this.panelRecentActivity.Controls.Add(this.listViewActivity);
            this.panelRecentActivity.Location = new System.Drawing.Point(20, 671);
            this.panelRecentActivity.Name = "panelRecentActivity";
            this.panelRecentActivity.Padding = new System.Windows.Forms.Padding(15);
            this.panelRecentActivity.Size = new System.Drawing.Size(1301, 354);
            this.panelRecentActivity.TabIndex = 3;
            // 
            // BoardRecent
            // 
            this.BoardRecent.AllowUserToAddRows = false;
            this.BoardRecent.AllowUserToDeleteRows = false;
            this.BoardRecent.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.BoardRecent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BoardRecent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BoardRecent.BackgroundColor = System.Drawing.Color.White;
            this.BoardRecent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoardRecent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BoardRecent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BoardRecent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BoardRecent.ColumnHeadersHeight = 38;
            this.BoardRecent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BoardRecent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Membresia,
            this.Fecha_alta});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BoardRecent.DefaultCellStyle = dataGridViewCellStyle3;
            this.BoardRecent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoardRecent.EnableHeadersVisualStyles = false;
            this.BoardRecent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.BoardRecent.Location = new System.Drawing.Point(15, 15);
            this.BoardRecent.MultiSelect = false;
            this.BoardRecent.Name = "BoardRecent";
            this.BoardRecent.RowHeadersVisible = false;
            this.BoardRecent.RowHeadersWidth = 51;
            this.BoardRecent.RowTemplate.Height = 36;
            this.BoardRecent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BoardRecent.Size = new System.Drawing.Size(1269, 322);
            this.BoardRecent.TabIndex = 2;
            this.BoardRecent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BoardClass_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            // 
            // Membresia
            // 
            this.Membresia.HeaderText = "Membresia";
            this.Membresia.MinimumWidth = 6;
            this.Membresia.Name = "Membresia";
            // 
            // Fecha_alta
            // 
            this.Fecha_alta.HeaderText = "Fecha Ingreso";
            this.Fecha_alta.MinimumWidth = 6;
            this.Fecha_alta.Name = "Fecha_alta";
            // 
            // labelActivityTitle
            // 
            this.labelActivityTitle.AutoSize = true;
            this.labelActivityTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActivityTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelActivityTitle.Location = new System.Drawing.Point(15, 15);
            this.labelActivityTitle.Name = "labelActivityTitle";
            this.labelActivityTitle.Size = new System.Drawing.Size(147, 21);
            this.labelActivityTitle.TabIndex = 1;
            this.labelActivityTitle.Text = "Actividad Reciente";
            // 
            // listViewActivity
            // 
            this.listViewActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewActivity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewActivity.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewActivity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewActivity.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewActivity.HideSelection = false;
            this.listViewActivity.Location = new System.Drawing.Point(15, 45);
            this.listViewActivity.Name = "listViewActivity";
            this.listViewActivity.Size = new System.Drawing.Size(1269, 284);
            this.listViewActivity.TabIndex = 0;
            this.listViewActivity.UseCompatibleStateImageBehavior = false;
            this.listViewActivity.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label1.Location = new System.Drawing.Point(734, 619);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Socios Recientes";
            // 
            // NewCategoryInventory
            // 
            this.NewCategoryInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            this.NewCategoryInventory.ForeColor = System.Drawing.Color.Black;
            this.NewCategoryInventory.IconChar = FontAwesome.Sharp.IconChar.None;
            this.NewCategoryInventory.IconColor = System.Drawing.Color.Black;
            this.NewCategoryInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NewCategoryInventory.Location = new System.Drawing.Point(710, 85);
            this.NewCategoryInventory.Name = "NewCategoryInventory";
            this.NewCategoryInventory.Size = new System.Drawing.Size(135, 57);
            this.NewCategoryInventory.TabIndex = 3;
            this.NewCategoryInventory.Text = "Nueva Categoría Inventario";
            this.NewCategoryInventory.UseVisualStyleBackColor = false;
            this.NewCategoryInventory.Click += new System.EventHandler(this.NewCategoryInventory_Click);
            // 
            // NewCategoryClass
            // 
            this.NewCategoryClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            this.NewCategoryClass.ForeColor = System.Drawing.Color.Black;
            this.NewCategoryClass.IconChar = FontAwesome.Sharp.IconChar.None;
            this.NewCategoryClass.IconColor = System.Drawing.Color.Black;
            this.NewCategoryClass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NewCategoryClass.Location = new System.Drawing.Point(710, 148);
            this.NewCategoryClass.Name = "NewCategoryClass";
            this.NewCategoryClass.Size = new System.Drawing.Size(135, 57);
            this.NewCategoryClass.TabIndex = 6;
            this.NewCategoryClass.Text = "Nueva Categoría Clase";
            this.NewCategoryClass.UseVisualStyleBackColor = false;
            this.NewCategoryClass.Click += new System.EventHandler(this.NewCategoryClass_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.NewCategoryClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelRecentActivity);
            this.Controls.Add(this.NewCategoryInventory);
            this.Controls.Add(this.panelCharts);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1324, 765);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.flowLayoutPanel.ResumeLayout(false);
            this.cardMembers.ResumeLayout(false);
            this.cardMembers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPartner)).EndInit();
            this.cardClasses.ResumeLayout(false);
            this.cardClasses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClass)).EndInit();
            this.cardRevenue.ResumeLayout(false);
            this.cardRevenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconIncome)).EndInit();
            this.panelCharts.ResumeLayout(false);
            this.panelCharts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPMemberships)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIngresosMensuales)).EndInit();
            this.panelRecentActivity.ResumeLayout(false);
            this.panelRecentActivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoardRecent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel cardMembers;
        private System.Windows.Forms.Panel cardClasses;
        private System.Windows.Forms.Panel cardRevenue;
        private System.Windows.Forms.Panel panelCharts;
        private System.Windows.Forms.Panel panelRecentActivity;
        private System.Windows.Forms.Label labelMembersTitle;
        private FontAwesome.Sharp.IconPictureBox iconPartner;
        private System.Windows.Forms.Label labelMembersCount;
        private System.Windows.Forms.Label labelClassesCount;
        private System.Windows.Forms.Label labelClassesTitle;
        private FontAwesome.Sharp.IconPictureBox iconClass;
        private System.Windows.Forms.Label labelRevenueAmount;
        private System.Windows.Forms.Label labelRevenueTitle;
        private FontAwesome.Sharp.IconPictureBox iconIncome;
        private System.Windows.Forms.Label labelChartTitle;
        private System.Windows.Forms.Label labelActivityTitle;
        private System.Windows.Forms.ListView listViewActivity;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.DataGridView BoardRecent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Membresia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_alta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIngresosMensuales;
        private FontAwesome.Sharp.IconButton NewCategoryInventory;
        private FontAwesome.Sharp.IconButton NewCategoryClass;
        private System.Windows.Forms.Label LChartPie;
        private System.Windows.Forms.DataVisualization.Charting.Chart CPMemberships;
    }
}