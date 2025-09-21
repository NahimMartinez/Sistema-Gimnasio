namespace Sistema_Gimnasio.Controls
{
    partial class Reports
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
            this.chartRadarClases = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRadarInventario = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartRadarClases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRadarInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // chartRadarClases
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRadarClases.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRadarClases.Legends.Add(legend1);
            this.chartRadarClases.Location = new System.Drawing.Point(124, 176);
            this.chartRadarClases.Name = "chartRadarClases";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRadarClases.Series.Add(series1);
            this.chartRadarClases.Size = new System.Drawing.Size(450, 573);
            this.chartRadarClases.TabIndex = 0;
            this.chartRadarClases.Text = "chart1";
            // 
            // chartRadarInventario
            // 
            chartArea2.Name = "ChartArea1";
            this.chartRadarInventario.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartRadarInventario.Legends.Add(legend2);
            this.chartRadarInventario.Location = new System.Drawing.Point(697, 139);
            this.chartRadarInventario.Name = "chartRadarInventario";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartRadarInventario.Series.Add(series2);
            this.chartRadarInventario.Size = new System.Drawing.Size(475, 598);
            this.chartRadarInventario.TabIndex = 1;
            this.chartRadarInventario.Text = "chart1";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartRadarInventario);
            this.Controls.Add(this.chartRadarClases);
            this.Name = "Reports";
            this.Size = new System.Drawing.Size(1348, 798);
            ((System.ComponentModel.ISupportInitialize)(this.chartRadarClases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRadarInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartRadarClases;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRadarInventario;
    }
}
