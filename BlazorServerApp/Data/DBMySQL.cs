using MySql.Data.MySqlClient;
namespace BlazorServerApp.Data
{
    public class DBMySQL
    {
        private static string Hostname = "localhost";

        private static string UserName = "root";

        private static string Password = "";

        private static string Database = "mobile_shop";

        private static int Port = 3306;

        public static MySqlConnection GetMySqlConnection()
        {
            string connStr = String.Format("Server={0};Database={1};User={2};Passsword={3};Port={4}", Hostname, Database, UserName, Password, Port);
            return new MySqlConnection(connStr);
        }
    }
}
