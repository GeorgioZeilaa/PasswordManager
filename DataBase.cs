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

        //Database credentials that are used when connecting
        private const string dpIp = "localhost";
        private const string dpUsername = "root";
        private const string dpPassword = "123";
        private const string dpName = "PasswordManager";
        private const string dpTable = "UserDetail";

        public DataBase()
        {
            //the connection to be made to the MySQL database
            try
            {
                string connectionString = "SERVER=" + dpIp + ";" + "DATABASE=" +
                dpName + ";" + "UID=" + dpUsername + ";" + "PASSWORD=" + dpPassword + ";Charset=utf8;";//using UTF-8 for unicode encrypted password cipher
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR:", e);
            }
            
        }

        ~DataBase()
        {
            connection.Close();
        }

        public bool addAccount(string username, string password)
        {
            //used to check if a username already exists
            string sql = "SELECT COUNT(*) FROM UserDetail WHERE Username = '" + username + "' ";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                int count = int.Parse(cmd.ExecuteScalar().ToString());

                if(count == 0)//if there is another account with the same username
                {
                    //used to add accounts when registering
                    using (var cmd2 = new MySqlCommand("INSERT into UserDetail SET Username= @username, Password = @password, Permission= @permission",
                                  connection))
                    {
                        cmd2.Parameters.Add("@username", MySqlDbType.Blob).Value = username;
                        cmd2.Parameters.Add("@password", MySqlDbType.Blob).Value = password;
                        cmd2.Parameters.Add("@permission", MySqlDbType.Blob).Value = 1;
                        cmd2.ExecuteNonQuery();
                    }
                    return true;//to return true when registration is successful
                }
                else
                {
                    return false;//return false if there is already an account that already exists
                }
            }
            catch(Exception e)
            {
                return false;//false if there are any errors
            }
        }

        public int[] verifyAccount(string username, string password)
        {
            //to check if the credentials supplied are correct from the login page
            string sql = "SELECT COUNT(*) FROM UserDetail WHERE Username = '" + username + "' && Password = '" + password + "' ";
            int []permission_and_id = new int[2];
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                int count = int.Parse(cmd.ExecuteScalar().ToString());

                permission_and_id[0] = 0;
                permission_and_id[1] = 0;

                if (count == 1)
                {
                    string sql2 = "SELECT * FROM UserDetail WHERE Username = '" + username + "' && Password = '" + password + "'";

                    MySqlCommand cmd2 = new MySqlCommand(sql2, connection);
                    var cursor = cmd2.ExecuteReader();
                    cursor.Read();
                    int permission = cursor.GetInt32("Permission");//to save the permission level before the connection is closed
                    int id = cursor.GetInt32("ID");
                    permission_and_id[0] = permission;
                    permission_and_id[1] = id;

                    return permission_and_id;//to return the permission level of the user, this should be greater than 1 to at least login
                }
                return permission_and_id;//0 means no permission to login
            }
            catch(Exception e)
            {
                //Console.WriteLine(e); debug
                return permission_and_id;
            }
        }

        public bool resetAccount(string username, string password)
        {
            string sql = "UPDATE UserDetail SET Password = '" + password + "' WHERE Username = '" + username + "' ";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool addapplication(AccountAppDetail detail, string name)
        {
            try
            {
                using (var cmd = new MySqlCommand("INSERT into ApplicationAccount SET UserID= @userid, Username= @username, " +
                    "Password = @password, DateCreated= @datecreated, DateUpdated= @dateupated, Name= @name" +
                    "", connection))
                {
                    cmd.Parameters.Add("@userid", MySqlDbType.Blob).Value = detail.UserID;
                    cmd.Parameters.Add("@username", MySqlDbType.Blob).Value = detail.Username;
                    cmd.Parameters.Add("@password", MySqlDbType.Blob).Value = detail.Password;
                    cmd.Parameters.Add("@datecreated", MySqlDbType.Blob).Value = detail.DateCreated;
                    cmd.Parameters.Add("@dateupated", MySqlDbType.Blob).Value = detail.DateUpdated;
                    cmd.Parameters.Add("@name", MySqlDbType.Blob).Value = name;
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool addgame(AccountAppDetail detail, string name)
        {
            try
            {
                using (var cmd = new MySqlCommand("INSERT into GameAccount SET UserID= @userid, Username= @username, " +
                    "Password = @password, DateCreated= @datecreated, DateUpdated= @dateupated, Name= @name" +
                    "", connection))
                {
                    cmd.Parameters.Add("@userid", MySqlDbType.Blob).Value = detail.UserID;
                    cmd.Parameters.Add("@username", MySqlDbType.Blob).Value = detail.Username;
                    cmd.Parameters.Add("@password", MySqlDbType.Blob).Value = detail.Password;
                    cmd.Parameters.Add("@datecreated", MySqlDbType.Blob).Value = detail.DateCreated;
                    cmd.Parameters.Add("@dateupated", MySqlDbType.Blob).Value = detail.DateUpdated;
                    cmd.Parameters.Add("@name", MySqlDbType.Blob).Value = name;
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool addwebsite(AccountAppDetail detail, string name, string url)
        {
            try
            {
                using (var cmd = new MySqlCommand("INSERT into WebsiteAccount SET UserID= @userid, Username= @username, " +
                    "Password = @password, DateCreated= @datecreated, DateUpdated= @dateupated, Name= @name, URL= @url" +
                    "", connection))
                {
                    cmd.Parameters.Add("@userid", MySqlDbType.Blob).Value = detail.UserID;
                    cmd.Parameters.Add("@username", MySqlDbType.Blob).Value = detail.Username;
                    cmd.Parameters.Add("@password", MySqlDbType.Blob).Value = detail.Password;
                    cmd.Parameters.Add("@datecreated", MySqlDbType.Blob).Value = detail.DateCreated;
                    cmd.Parameters.Add("@dateupated", MySqlDbType.Blob).Value = detail.DateUpdated;
                    cmd.Parameters.Add("@name", MySqlDbType.Blob).Value = name;
                    cmd.Parameters.Add("@url", MySqlDbType.Blob).Value = url;
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public MySqlDataReader viewPassword(int []permission_and_id, string table)
        {
            int permission = permission_and_id[0];
            int userid = permission_and_id[1];
            //checking if admin or user.
            if(permission>1)
            {  
                using (var cmd = new MySqlCommand("SELECT * FROM "+table.ToString()+"", connection))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    return reader;
                }
            }
            else
            {
                using (var cmd = new MySqlCommand("SELECT * FROM " + table.ToString() + " WHERE UserID=@userid", connection))
                {
                    cmd.Parameters.Add("@userid", MySqlDbType.Blob).Value = userid;//retrieving only the passwords for that specific user
                    MySqlDataReader reader = cmd.ExecuteReader();
                    return reader;
                }
            }
        }

        public bool delete(string[] info)
        {
            int size = info.Count()-1;//getting the table name

            using (var cmd = new MySqlCommand("DELETE FROM "+info[size]+" WHERE ID=@id", connection))
            {
                try
                {
                    cmd.Parameters.Add("@id", MySqlDbType.Blob).Value = info[0];//retrieving the specific unique ID to delete that sepcific record
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch(Exception e)
                {
                    Console.WriteLine("ERROR:", e);
                    return false;
                }
            }
        }
    }
}