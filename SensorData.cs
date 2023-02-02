using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Read_SQL_Data
{
    public class SensorData
    {
        public double CelsiusValue { get; set; }
        public double FahrenValue { get; set; }
        public DateTime SensorDateTime { get; set; }
        public double SensorMax { get; set; }
        public double SensorMin { get; set; }
        public double SensorAvg { get; set; }
        public double SensorStd { get; set; }

        public static List<SensorData> GetSensorData(Boolean ReadAggregates)
        {
            string conString = ConfigurationManager.ConnectionStrings["DB_Measurements"].ConnectionString;       // DB connection is specified in app.config  https://blog.elmah.io/the-ultimate-guide-to-connection-strings-in-web-config/
            var con = new SqlConnection(conString);                                                              // Connect to database
            string selectSQL;
            if (ReadAggregates)
            {
                selectSQL = "SELECT Timestamp,Max,Min,Average,Std FROM LOG WHERE Timestamp = (SELECT MAX(Timestamp) FROM LOG) AND SensorId = 1;";
            }
            else
            {
                
                selectSQL = "SELECT Fah,Cels, Timestamp FROM TEMPERATURES WHERE Timestamp = (SELECT MAX(Timestamp) FROM TEMPERATURES);";
            }

            con.Open();
            var cmd = new SqlCommand(selectSQL, con); 
            var SqlDataReader = cmd.ExecuteReader();

            var sensorDataList = new List<SensorData>();
            if (SqlDataReader != null)
            {
                while (SqlDataReader.Read())
                {
                    SensorData sensorData = new SensorData();
                    if (ReadAggregates)
                    {
                        sensorData.SensorMax = Convert.ToDouble(SqlDataReader["Max"]);
                        sensorData.SensorMin = Convert.ToDouble(SqlDataReader["Min"]);
                        sensorData.SensorAvg = Convert.ToDouble(SqlDataReader["Average"]);
                        sensorData.SensorStd = Convert.ToDouble(SqlDataReader["Std"]);
                        sensorData.SensorDateTime = Convert.ToDateTime(SqlDataReader["Timestamp"]);
                    }
                    else
                    {
                        sensorData.CelsiusValue = Convert.ToDouble(SqlDataReader["Cels"]);
                        sensorData.FahrenValue = Convert.ToDouble(SqlDataReader["Fah"]);
                        sensorData.SensorDateTime = Convert.ToDateTime(SqlDataReader["Timestamp"]);
                    }                    
                
                    sensorDataList.Add(sensorData);
                }
            }
            con.Close();
            return sensorDataList;
        }
    }
}
