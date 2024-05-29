using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLayer
{
    public class DB
    {
        private static string _connectionString = @"Data Source=31.147.206.65\PISERVER,1433; Initial Catalog=PI2324_tcosic22_DB;
        User=PI2324_tcosic22_User; Password=-t0nGBJl";
        private static SqlConnection _connection;

        public static void UspostaviVezu()
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        public static void ZatvoriVezu()
        {
            if (_connection.State != System.Data.ConnectionState.Closed)
            {
                _connection.Close();
            }
        }

        public static SqlDataReader DohvatiCitac(string query)
        {
            SqlCommand command = new SqlCommand(query, _connection);
            return command.ExecuteReader();
        }

        public static int IzvrsiNaredbu(string sqlCommand)
        {
            SqlCommand command = new SqlCommand(sqlCommand, _connection);
            return command.ExecuteNonQuery();
        }
    }
}
