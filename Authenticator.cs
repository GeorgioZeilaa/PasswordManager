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
        public Authenticator()
        {

        }

        public bool addAccount(string username, string password)
        {
            user.Username = username;
            user.Password = (Encryption) password;
            return false;
        }

        public int verifyAccount(string username, string password)
        {
            return 0;//returns permission level
        }
    }
}
