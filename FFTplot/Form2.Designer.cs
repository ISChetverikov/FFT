namespace FFTplot
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.signalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.spectrumChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.signalChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumChart)).BeginInit();
            this.SuspendLayout();
            // 
            // signalChart
            // 
            chartArea1.AxisX.Title = "time, sample";
            chartArea1.AxisY.Title = "level";
            chartArea1.Name = "ChartArea1";
            this.signalChart.ChartAreas.Add(chartArea1);
            this.signalChart.Location = new System.Drawing.Point(12, 12);
            this.signalChart.Name = "signalChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.IsVisibleInLegend = false;
            series1.Name = "sample";
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.signalChart.Series.Add(series1);
            this.signalChart.Size = new System.Drawing.Size(350, 436);
            this.signalChart.TabIndex = 0;
            this.signalChart.Text = "Signal";
            title1.Name = "Signal";
            title1.Text = "Signal";
            this.signalChart.Titles.Add(title1);
            // 
            // spectrumChart
            // 
            chartArea2.AxisX.Title = "frequency, Hz";
            chartArea2.AxisY.Title = "Amplitude";
            chartArea2.Name = "ChartArea1";
            this.spectrumChart.ChartAreas.Add(chartArea2);
            this.spectrumChart.Location = new System.Drawing.Point(433, 12);
            this.spectrumChart.Name = "spectrumChart";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Red;
            series2.Name = "harmonic";
            this.spectrumChart.Series.Add(series2);
            this.spectrumChart.Size = new System.Drawing.Size(394, 436);
            this.spectrumChart.TabIndex = 0;
            this.spectrumChart.Text = "spectrum";
            title2.Name = "Spectrum";
            title2.Text = "Spectrum";
            this.spectrumChart.Titles.Add(title2);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 465);
            this.Controls.Add(this.spectrumChart);
            this.Controls.Add(this.signalChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.Text = "Graphics";
            ((System.ComponentModel.ISupportInitialize)(this.signalChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart signalChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart spectrumChart;
    }
}