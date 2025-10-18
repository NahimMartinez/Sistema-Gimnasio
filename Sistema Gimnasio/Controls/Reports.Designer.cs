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
            this.chartRadarClases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartRadarClases.Location = new System.Drawing.Point(3, 3);
            this.chartRadarClases.Name = "chartRadarClases";
            this.chartRadarClases.Size = new System.Drawing.Size(668, 792);
            this.chartRadarClases.TabIndex = 0;
            // 
            // chartRadarInventario
            // 
            this.chartRadarInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartRadarInventario.Location = new System.Drawing.Point(677, 3);
            this.chartRadarInventario.Name = "chartRadarInventario";
            this.chartRadarInventario.Size = new System.Drawing.Size(668, 792);
            this.chartRadarInventario.TabIndex = 1;
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