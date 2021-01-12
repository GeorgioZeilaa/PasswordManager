using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    class LoginUserDetail
    {
        string username;
        string password;
        int permission;
        public string Username
        {
            set { username = value; }
            get { return username; }
        }
        public int Permission
        {
            set { permission = value; }
            get { return permission; }
        }
        public string Password
        {
            set { password = value; }
            get { return password; }
        }
    }
}
