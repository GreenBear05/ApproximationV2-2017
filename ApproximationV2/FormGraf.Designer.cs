namespace ApproximationV2
{
    partial class FormGraf
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartGraf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf)).BeginInit();
            this.SuspendLayout();
            // 
            // chartGraf
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGraf.ChartAreas.Add(chartArea1);
            this.chartGraf.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.chartGraf.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend1.Name = "Legend1";
            this.chartGraf.Legends.Add(legend1);
            this.chartGraf.Location = new System.Drawing.Point(0, -1);
            this.chartGraf.Name = "chartGraf";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Tos";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Line";
            this.chartGraf.Series.Add(series1);
            this.chartGraf.Series.Add(series2);
            this.chartGraf.Size = new System.Drawing.Size(728, 457);
            this.chartGraf.TabIndex = 0;
            this.chartGraf.Text = "chart";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(620, 395);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Выход";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormGraf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 454);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.chartGraf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGraf";
            this.Text = "FormGraf";
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraf;
    }
}