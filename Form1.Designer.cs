
namespace Read_SQL_Data
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBx_TempCel = new System.Windows.Forms.TextBox();
            this.txtBx_TimeSampleWasRead = new System.Windows.Forms.TextBox();
            this.Graph_Temperature = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot4 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis4 = new NationalInstruments.UI.XAxis();
            this.yAxis4 = new NationalInstruments.UI.YAxis();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBx_TempFah = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBx_AvgTemp = new System.Windows.Forms.TextBox();
            this.txtBx_MaxTemp = new System.Windows.Forms.TextBox();
            this.txtBx_MinTemp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBx_STD = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Graph_Temperature)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actual temperature[C]";
            // 
            // txtBx_TempCel
            // 
            this.txtBx_TempCel.Location = new System.Drawing.Point(143, 197);
            this.txtBx_TempCel.Name = "txtBx_TempCel";
            this.txtBx_TempCel.ReadOnly = true;
            this.txtBx_TempCel.Size = new System.Drawing.Size(110, 20);
            this.txtBx_TempCel.TabIndex = 1;
            // 
            // txtBx_TimeSampleWasRead
            // 
            this.txtBx_TimeSampleWasRead.Location = new System.Drawing.Point(392, 197);
            this.txtBx_TimeSampleWasRead.Name = "txtBx_TimeSampleWasRead";
            this.txtBx_TimeSampleWasRead.ReadOnly = true;
            this.txtBx_TimeSampleWasRead.Size = new System.Drawing.Size(110, 20);
            this.txtBx_TimeSampleWasRead.TabIndex = 2;
            // 
            // Graph_Temperature
            // 
            this.Graph_Temperature.Location = new System.Drawing.Point(12, 12);
            this.Graph_Temperature.Name = "Graph_Temperature";
            this.Graph_Temperature.PlotAreaColor = System.Drawing.SystemColors.ControlLight;
            this.Graph_Temperature.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot4});
            this.Graph_Temperature.Size = new System.Drawing.Size(490, 175);
            this.Graph_Temperature.TabIndex = 3;
            this.Graph_Temperature.UseColorGenerator = true;
            this.Graph_Temperature.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis4});
            this.Graph_Temperature.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis4});
            // 
            // waveformPlot4
            // 
            this.waveformPlot4.FillBase = NationalInstruments.UI.XYPlotFillBase.Plot;
            this.waveformPlot4.FillMode = NationalInstruments.UI.PlotFillMode.Lines;
            this.waveformPlot4.LineColor = System.Drawing.SystemColors.ActiveCaption;
            this.waveformPlot4.LineColorPrecedence = NationalInstruments.UI.ColorPrecedence.UserDefinedColor;
            this.waveformPlot4.LineWidth = 2F;
            this.waveformPlot4.PointColor = System.Drawing.SystemColors.WindowText;
            this.waveformPlot4.XAxis = this.xAxis4;
            this.waveformPlot4.YAxis = this.yAxis4;
            this.waveformPlot4.YErrorHighLineColor = System.Drawing.Color.Cyan;
            // 
            // xAxis4
            // 
            this.xAxis4.BaseLineVisible = true;
            this.xAxis4.Caption = "Sample N";
            this.xAxis4.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // yAxis4
            // 
            this.yAxis4.Caption = "Temperature [C]";
            this.yAxis4.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yAxis4.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.yAxis4.Range = new NationalInstruments.UI.Range(-15D, 40D);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Average Temperature[C]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Max Temperature[C]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Min Temperature[C]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Actual temperature[F]";
            // 
            // txtBx_TempFah
            // 
            this.txtBx_TempFah.Location = new System.Drawing.Point(143, 227);
            this.txtBx_TempFah.Name = "txtBx_TempFah";
            this.txtBx_TempFah.ReadOnly = true;
            this.txtBx_TempFah.Size = new System.Drawing.Size(110, 20);
            this.txtBx_TempFah.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Last sample:";
            // 
            // txtBx_AvgTemp
            // 
            this.txtBx_AvgTemp.Location = new System.Drawing.Point(143, 257);
            this.txtBx_AvgTemp.Name = "txtBx_AvgTemp";
            this.txtBx_AvgTemp.ReadOnly = true;
            this.txtBx_AvgTemp.Size = new System.Drawing.Size(110, 20);
            this.txtBx_AvgTemp.TabIndex = 10;
            // 
            // txtBx_MaxTemp
            // 
            this.txtBx_MaxTemp.Location = new System.Drawing.Point(143, 287);
            this.txtBx_MaxTemp.Name = "txtBx_MaxTemp";
            this.txtBx_MaxTemp.ReadOnly = true;
            this.txtBx_MaxTemp.Size = new System.Drawing.Size(110, 20);
            this.txtBx_MaxTemp.TabIndex = 11;
            // 
            // txtBx_MinTemp
            // 
            this.txtBx_MinTemp.Location = new System.Drawing.Point(143, 317);
            this.txtBx_MinTemp.Name = "txtBx_MinTemp";
            this.txtBx_MinTemp.ReadOnly = true;
            this.txtBx_MinTemp.Size = new System.Drawing.Size(110, 20);
            this.txtBx_MinTemp.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "STD [C]";
            // 
            // txtBx_STD
            // 
            this.txtBx_STD.Location = new System.Drawing.Point(143, 343);
            this.txtBx_STD.Name = "txtBx_STD";
            this.txtBx_STD.ReadOnly = true;
            this.txtBx_STD.Size = new System.Drawing.Size(110, 20);
            this.txtBx_STD.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 369);
            this.Controls.Add(this.txtBx_STD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBx_MinTemp);
            this.Controls.Add(this.txtBx_MaxTemp);
            this.Controls.Add(this.txtBx_AvgTemp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBx_TempFah);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Graph_Temperature);
            this.Controls.Add(this.txtBx_TimeSampleWasRead);
            this.Controls.Add(this.txtBx_TempCel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Temperature";
            ((System.ComponentModel.ISupportInitialize)(this.Graph_Temperature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBx_TempCel;
        private System.Windows.Forms.TextBox txtBx_TimeSampleWasRead;
        private NationalInstruments.UI.WindowsForms.WaveformGraph Graph_Temperature;
        private NationalInstruments.UI.WaveformPlot waveformPlot4;
        private NationalInstruments.UI.XAxis xAxis4;
        private NationalInstruments.UI.YAxis yAxis4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBx_TempFah;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBx_AvgTemp;
        private System.Windows.Forms.TextBox txtBx_MaxTemp;
        private System.Windows.Forms.TextBox txtBx_MinTemp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBx_STD;
    }
}

