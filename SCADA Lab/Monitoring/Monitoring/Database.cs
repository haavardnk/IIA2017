using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.InteropServices.ComTypes;

namespace Monitoring
{
    public class Database
    {
        private readonly SqlConnection _connection;

        public Database(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        public List<Tag> GetTagData()
        {
            var tagList = new List<Tag>();

            const string selectSql = "select TagId, TagName, Description, Zero, Span from TAG";
            _connection.Open();
            var cmd = new SqlCommand(selectSql, _connection);

            var dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    var tag = new Tag
                    {
                        TagId = Convert.ToInt32(dr["TagId"]),
                        TagName = Convert.ToString(dr["TagName"]).Trim(),
                        Description = Convert.ToString(dr["Description"]).Trim(),
                        Zero = Convert.ToDouble(dr["Zero"]),
                        Span = Convert.ToDouble(dr["Span"])
                    };


                    tagList.Add(tag);
                }
            }
            _connection.Close();

            tagList = GetAlarmLimit(tagList);
            return tagList;
        }

        private List<Tag> GetAlarmLimit(List<Tag> tagList)
        {
            foreach (var tag in tagList)
            {

                var selectSql = "select H from ALARMCONFIG where TagId =" + tag.TagId;
                _connection.Open();
                var cmd = new SqlCommand(selectSql, _connection);

                var dr = cmd.ExecuteReader();

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        tag.AlarmLimit = Convert.ToDouble(dr["H"]);
                    }
                }
                _connection.Close();
            }
            return tagList;
        }

        public List<Measurement> GetTagHistory(Tag tag)
        {
            var measurementList = new List<Measurement>();

            var selectSql = "select * from HISTORY where TagId ="+tag.TagId.ToString()+ "order by TimeStamp desc";
            _connection.Open();
            var cmd = new SqlCommand(selectSql, _connection);

            var dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read() && measurementList.Count < 500)
                {
                    var measurement = new Measurement
                    {
                        TagId = Convert.ToInt32(dr["TagId"]),
                        TimeStamp = Convert.ToDateTime(dr["TimeStamp"]),
                        Value = Convert.ToDouble(dr["Value"]),
                        OpcQuality = Convert.ToString(dr["Quality"]).Trim()
                    };

                    measurementList.Add(measurement);
                }
            }
            _connection.Close();

            return measurementList;
        }
        public List<ActiveAlarm> GetAlarmList()
        {
            var alarmList = new List<ActiveAlarm>();
            const string selectSql = "select * from ALARM order by ActivationTime desc";
            var command = new SqlCommand(selectSql, _connection);

            _connection.Open();
            var dr = command.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    var alarm = new ActiveAlarm
                    {
                        TagId = Convert.ToInt32(dr["TagId"]),
                        AlarmId = Convert.ToInt32(dr["AlarmId"]),
                        ActivationTime = Convert.ToDateTime(dr["ActivationTime"]),
                        Acknowledged = Convert.ToBoolean(dr["Acknowledged"]),
                        AlarmType = Convert.ToString(dr["AlarmType"]).Trim(),
                        Description = Convert.ToString(dr["Description"]).Trim(),
                        AlarmLimit = Convert.ToInt16(dr["Alarmlimit"])
                    };

                    alarmList.Add(alarm);
                }
            }
            _connection.Close();
            return alarmList;
        }

        public void SetAcknowledgedAlarm(bool acknowledged)
        {
            var command = new SqlCommand("AcknowledgeAlarm", _connection) {CommandType = CommandType.StoredProcedure};
            command.Parameters.AddWithValue("@Acknowledged", acknowledged);

            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}