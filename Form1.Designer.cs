namespace CPU_Memory_Monitor_WinForms
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.perfCountCpu = new System.Diagnostics.PerformanceCounter();
            this.perfCountAvailableMemory = new System.Diagnostics.PerformanceCounter();
            this.TimerMain = new System.Windows.Forms.Timer(this.components);
            this.perfCountUpTime = new System.Diagnostics.PerformanceCounter();
            this.progressCPU = new MetroFramework.Controls.MetroProgressBar();
            this.progressMemory = new MetroFramework.Controls.MetroProgressBar();
            this.lblCpu = new MetroFramework.Controls.MetroLabel();
            this.lblMemory = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.chartMonitor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblUpTime = new MetroFramework.Controls.MetroLabel();
            this.perfCountMemoryUsage = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.perfCountCpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCountAvailableMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCountUpTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCountMemoryUsage)).BeginInit();
            this.SuspendLayout();
            // 
            // perfCountCpu
            // 
            this.perfCountCpu.CategoryName = "Processor";
            this.perfCountCpu.CounterName = "% Processor Time";
            this.perfCountCpu.InstanceName = "_Total";
            // 
            // perfCountAvailableMemory
            // 
            this.perfCountAvailableMemory.CategoryName = "Memory";
            this.perfCountAvailableMemory.CounterName = "Available MBytes";
            // 
            // TimerMain
            // 
            this.TimerMain.Interval = 1000;
            this.TimerMain.Tick += new System.EventHandler(this.TimerMain_Tick);
            // 
            // perfCountUpTime
            // 
            this.perfCountUpTime.CategoryName = "System";
            this.perfCountUpTime.CounterName = "System Up Time";
            // 
            // progressCPU
            // 
            this.progressCPU.Location = new System.Drawing.Point(12, 108);
            this.progressCPU.Name = "progressCPU";
            this.progressCPU.Size = new System.Drawing.Size(216, 29);
            this.progressCPU.TabIndex = 2;
            // 
            // progressMemory
            // 
            this.progressMemory.Location = new System.Drawing.Point(252, 108);
            this.progressMemory.Name = "progressMemory";
            this.progressMemory.Size = new System.Drawing.Size(216, 29);
            this.progressMemory.TabIndex = 3;
            // 
            // lblCpu
            // 
            this.lblCpu.AutoSize = true;
            this.lblCpu.Location = new System.Drawing.Point(94, 140);
            this.lblCpu.Name = "lblCpu";
            this.lblCpu.Size = new System.Drawing.Size(33, 19);
            this.lblCpu.TabIndex = 4;
            this.lblCpu.Text = "0.00";
            // 
            // lblMemory
            // 
            this.lblMemory.AutoSize = true;
            this.lblMemory.Location = new System.Drawing.Point(325, 140);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(37, 19);
            this.lblMemory.TabIndex = 5;
            this.lblMemory.Text = "0000";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(123, 140);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(20, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "%";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(361, 140);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(29, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "MB";
            // 
            // chartMonitor
            // 
            this.chartMonitor.BorderlineWidth = 5;
            chartArea1.Name = "ChartArea1";
            this.chartMonitor.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMonitor.Legends.Add(legend1);
            this.chartMonitor.Location = new System.Drawing.Point(12, 171);
            this.chartMonitor.Name = "chartMonitor";
            this.chartMonitor.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartMonitor.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Crimson,
        System.Drawing.Color.DodgerBlue};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Memory";
            this.chartMonitor.Series.Add(series1);
            this.chartMonitor.Series.Add(series2);
            this.chartMonitor.Size = new System.Drawing.Size(456, 208);
            this.chartMonitor.TabIndex = 8;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.Color.SeaGreen;
            this.metroLabel5.Location = new System.Drawing.Point(19, 401);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(133, 25);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "System Uptime";
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.Crimson;
            this.metroLabel2.Location = new System.Drawing.Point(315, 80);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Memory";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.metroLabel1.Location = new System.Drawing.Point(92, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 25);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "CPU";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // lblUpTime
            // 
            this.lblUpTime.AutoSize = true;
            this.lblUpTime.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblUpTime.Location = new System.Drawing.Point(163, 401);
            this.lblUpTime.Name = "lblUpTime";
            this.lblUpTime.Size = new System.Drawing.Size(281, 25);
            this.lblUpTime.TabIndex = 11;
            this.lblUpTime.Text = "0 days 0 hours 0 minutes 0 seconds";
            // 
            // perfCountMemoryUsage
            // 
            this.perfCountMemoryUsage.CategoryName = "Memory";
            this.perfCountMemoryUsage.CounterName = "% Committed Bytes In Use";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 443);
            this.Controls.Add(this.lblUpTime);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.chartMonitor);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lblMemory);
            this.Controls.Add(this.lblCpu);
            this.Controls.Add(this.progressMemory);
            this.Controls.Add(this.progressCPU);
            this.Controls.Add(this.metroLabel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "System Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfCountCpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCountAvailableMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCountUpTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCountMemoryUsage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter perfCountCpu;
        private System.Diagnostics.PerformanceCounter perfCountAvailableMemory;
        private System.Windows.Forms.Timer TimerMain;
        private System.Diagnostics.PerformanceCounter perfCountUpTime;
        private MetroFramework.Controls.MetroProgressBar progressCPU;
        private MetroFramework.Controls.MetroProgressBar progressMemory;
        private MetroFramework.Controls.MetroLabel lblCpu;
        private MetroFramework.Controls.MetroLabel lblMemory;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonitor;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblUpTime;
        private System.Diagnostics.PerformanceCounter perfCountMemoryUsage;

    }
}

