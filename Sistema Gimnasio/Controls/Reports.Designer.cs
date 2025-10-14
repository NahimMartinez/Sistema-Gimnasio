namespace Sistema_Gimnasio.Controls
{
    partial class Reports
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 20D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 15D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 25D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 30D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartRadarClases = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRadarInventario = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRadarClases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRadarInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chartRadarClases, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartRadarInventario, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1348, 798);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chartRadarClases
            // 
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DarkSlateGray;
            chartArea1.AxisY.Interval = 5D;
            chartArea1.AxisY.LabelStyle.Format = "#";
            chartArea1.AxisY.Maximum = 35D;
            chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.LightGray;
            chartArea1.ShadowOffset = 2;
            this.chartRadarClases.ChartAreas.Add(chartArea1);
            this.chartRadarClases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartRadarClases.Location = new System.Drawing.Point(3, 3);
            this.chartRadarClases.Name = "chartRadarClases";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
            series1.Color = System.Drawing.Color.SteelBlue;
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.SteelBlue;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.LabelFormat = "# alumnos";
            series1.MarkerColor = System.Drawing.Color.DarkBlue;
            series1.MarkerSize = 8;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Capacidad";
            dataPoint1.AxisLabel = "Crossfit";
            dataPoint2.AxisLabel = "Yoga";
            dataPoint3.AxisLabel = "Pilates";
            dataPoint4.AxisLabel = "Zumba";
            dataPoint5.AxisLabel = "Spinning";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            this.chartRadarClases.Series.Add(series1);
            this.chartRadarClases.Size = new System.Drawing.Size(668, 792);
            this.chartRadarClases.TabIndex = 0;
            this.chartRadarClases.Text = "chart1";
            title1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.DarkSlateGray;
            title1.IsDockedInsideChartArea = false;
            title1.Name = "Title1";
            title1.Text = "Cantidad de alumnos por clase";
            this.chartRadarClases.Titles.Add(title1);
            // 
            // chartRadarInventario
            // 
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DarkSlateGray;
            chartArea2.AxisY.Interval = 10D;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            chartArea2.AxisY.LabelStyle.Format = "#";
            chartArea2.AxisY.Maximum = 50D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.LightGray;
            chartArea2.ShadowOffset = 2;
            this.chartRadarInventario.ChartAreas.Add(chartArea2);
            this.chartRadarInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartRadarInventario.Location = new System.Drawing.Point(677, 3);
            this.chartRadarInventario.Name = "chartRadarInventario";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
            series2.Color = System.Drawing.Color.SteelBlue;
            series2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.LabelBackColor = System.Drawing.Color.SteelBlue;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.LabelFormat = "#";
            series2.MarkerColor = System.Drawing.Color.DarkBlue;
            series2.MarkerSize = 8;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Cantidad";
            series2.ToolTip = "#AXISLABEL: #VAL items";
            this.chartRadarInventario.Series.Add(series2);
            this.chartRadarInventario.Size = new System.Drawing.Size(668, 792);
            this.chartRadarInventario.TabIndex = 1;
            this.chartRadarInventario.Text = "chart2";
            title2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            title2.ForeColor = System.Drawing.Color.DarkSlateGray;
            title2.IsDockedInsideChartArea = false;
            title2.Name = "Title1";
            title2.Text = "Items por Categoría";
            this.chartRadarInventario.Titles.Add(title2);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Reports";
            this.Size = new System.Drawing.Size(1348, 798);
            this.Load += new System.EventHandler(this.Reports_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRadarClases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRadarInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRadarClases;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRadarInventario;
    }
}