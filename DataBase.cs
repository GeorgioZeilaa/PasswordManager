using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace PasswordManager
{
    class DataBase
    {
        private MySqlConnection connection;

        private const string dpIp = "localhost";
        private const string dpUsername = "root";
        private const string dpPassword = "123";
        private const string dpName = "PasswordManager";
        private const string dpTable = "UserDetail";

        public DataBase()
        {
            string connectionString = "SERVER=" + dpIp + ";" + "DATABASE=" +
            dpName + ";" + "UID=" + dpUsername + ";" + "PASSWORD=" + dpPassword + ";";
            connection = new MySqlConnection(connectionString);
        }
        public bool INSERT(string username, string password)
        {
            string sql = "INSERT into UserDetail(Username, Password, Permission) Values('" + username + "','" + password + "','"+ 0 +"')";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            return false;
        }
    }
}