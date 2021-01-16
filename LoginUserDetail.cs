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
        Encryption psw = new Encryption();
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
            set { password = psw.encryptDecrypt(value); }
            get { return password; }
        }
    }
}
