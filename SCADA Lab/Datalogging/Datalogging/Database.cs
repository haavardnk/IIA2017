using System;
using System.Data;
using System.Data.SqlClient;

namespace Datalogging
{
    public class Database
    {
        private readonly SqlConnection _connection;
        public Database(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }
        
        public void Write(int tagId, double value, double quality)
        {
            var command = new SqlCommand("SampleProcedure", _connection) {CommandType = CommandType.StoredProcedure};
            command.Parameters.Add(new SqlParameter("@TagId", tagId));
            command.Parameters.Add(new SqlParameter("@Value", value));
            command.Parameters.Add(new SqlParameter("@Quality", quality));

            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
