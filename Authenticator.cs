using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    class Authenticator
    {
        LoginUserDetail user = new LoginUserDetail();
        DataBase db;
        public Authenticator()
        {
            db = new DataBase();//to connect to the database mysql
        }

        public bool addAccount(string username, string password)
        {
            user.Username = username;
            user.Password = password;
            return db.addAccount(user.Username, user.Password);
        }

        public int verifyAccount(string username, string password)
        {
            user.Username = username;
            user.Password = password;
            return db.verifyAccount(user.Username,user.Password);//returns permission levels
        }

        public bool resetAccount(string username, string password)
        {
            user.Username = username;
            user.Password = password;
            return db.resetAccount(user.Username, user.Password);
        }
    }
}
