using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleDataBaseRead
{
    class Program
    {
        static void Main(string[] args)
        {
            string serverIp = "localhost";
            string username = "root";
            string password = "";
            string databaseName = "bankingsystemapp";
           // MySqlConnection con = new MySqlConnection("server=localhost; database=bankingsystemapp; username=root; password=;");

            //   string dbConnectionString = string.Format("server={0};uid={1};pwd={2};database={3};", serverIp, username, password, databaseName);
              string dbConnectionString = string.Format("server={0};uid={1};pwd={2};database={3};", serverIp, username, password, databaseName);
            string query = "SELECT * FROM account where accid='" + 3 + "' ";

            var conn = new MySql.Data.MySqlClient.MySqlConnection(dbConnectionString);
            conn.Open();

            var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
               // var someValue = reader["balance"];
                var someValue = reader[4].ToString();
                Console.WriteLine(someValue);

                // Do something with someValue
            }


        }
    }
}
