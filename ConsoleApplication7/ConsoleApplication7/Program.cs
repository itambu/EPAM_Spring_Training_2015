using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(
                ConfigurationManager
                .ConnectionStrings["blogConnectionStr"]
                .ConnectionString);
            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE id=1", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string alias = reader.GetString(1);
            }

            connection.Close();
            connection.Dispose();
        }
    }
}
