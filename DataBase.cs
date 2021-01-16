﻿using System;
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
            string connectionString = "SERVER=" + dpIp + ";" + "DATABASE=" +
            dpName + ";" + "UID=" + dpUsername + ";" + "PASSWORD=" + dpPassword + ";";
            connection = new MySqlConnection(connectionString);
        }
        public bool addAccount(string username, string password)
        {
            //used to add accounts when registering
            string sql = "INSERT into UserDetail(Username, Password, Permission) Values('" + username + "','" + password + "','"+ 0 +"')";
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                
                return true;//to return true when registration is successful
            }
            catch(Exception e)
            {
                return false;//false if there are any errors
            }
        }
        public int verifyAccount(string username, string password)
        {
            //to check if the credentials supplied are correct from the login page
            string sql = "SELECT COUNT(*) FROM UserDetail WHERE Username = '" + username + "' && Password = '"+password+"'";
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                int count = int.Parse(cmd.ExecuteScalar().ToString());

                if (count == 1)
                {
                    string sql2 = "SELECT * FROM UserDetail WHERE Username = '" + username + "' && Password = '" + password + "'";

                    MySqlCommand cmd2 = new MySqlCommand(sql2, connection);
                    var cursor = cmd2.ExecuteReader();
                    cursor.Read();
                    int permission = cursor.GetInt32("Permission");//to save the permission level before the connection is closed
                    connection.Close();

                    return permission;//to return the permission level of the user, this should be greater than 1 to at least login
                }
                connection.Close();
                return 0;//0 means no permission to login
            }
            catch(Exception e)
            {
                return 0;
            }
        }
        public bool resetAccount(string username, string password)
        {
            string sql = "UPDATE UserDetail SET Password = '" + password + "' WHERE Username = '" + username + "' ";
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}