using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ReadDatabase
{
    public class Measurement
    {
        public int SensorId { get; set; }
        public double CelsiusValue { get; set; }
        public double FahrenheitValue { get; set; }
        public DateTime TimeStamp { get; set; }


        public static List<Measurement> GetMeasurements()
        {
            var measurementList = new List<Measurement>();
            var con = new SqlConnection(@"Data Source=DESKTOP-PNGCAGM\SQLEXPRESS;Initial Catalog=SensorDatabase;Trusted_Connection=True");
            const string selectSql = "select CelsiusValue, FahrenheitValue, SensorId, Timestamp from GetLogData order by Timestamp desc";
            
            con.Open();

            var cmd = new SqlCommand(selectSql, con);

            var dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    var measurement = new Measurement();

                    measurement.SensorId = Convert.ToInt32(dr["SensorId"]);
                    measurement.CelsiusValue = Convert.ToDouble(dr["CelsiusValue"]);
                    measurement.FahrenheitValue = Convert.ToDouble(dr["FahrenheitValue"]);
                    measurement.TimeStamp = Convert.ToDateTime(dr["TimeStamp"]);

                    measurementList.Add(measurement);

                    if(measurementList.Count == 100)
                    {
                        break;
                    }
                }
            }

            con.Close();
            return measurementList;
        }
    }
}