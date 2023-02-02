using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Read_SQL_Data
{
    public partial class Form1 : Form
    {
        bool ReadAggregates;
       
        public Form1()
        {
            InitializeComponent();
            ReadAggregates = false; ;
            Timer MyTimer = new Timer();
            MyTimer.Interval = (500); // 500 ms
            MyTimer.Tick += new EventHandler(Timer_Tick);
            MyTimer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            List<SensorData>  sensorList = SensorData.GetSensorData(ReadAggregates);

            foreach (var measurement in sensorList)
            {
                if (ReadAggregates)
                {
                    txtBx_TimeSampleWasRead.Text = measurement.SensorDateTime.ToString();
                    txtBx_MaxTemp.Text = measurement.SensorMax.ToString();
                    txtBx_MinTemp.Text = measurement.SensorMin.ToString();
                    txtBx_AvgTemp.Text = measurement.SensorAvg.ToString();
                    txtBx_STD.Text = measurement.SensorStd.ToString();
                }
                else
                {
                    txtBx_TimeSampleWasRead.Text = measurement.SensorDateTime.ToString();
                    txtBx_TempCel.Text = measurement.CelsiusValue.ToString();
                    txtBx_TempFah.Text = measurement.FahrenValue.ToString();
                    Graph_Temperature.PlotYAppend(measurement.CelsiusValue);
                }
            }

            ReadAggregates = (ReadAggregates == true) ? ReadAggregates = false : ReadAggregates = true;
        }
    }
}
