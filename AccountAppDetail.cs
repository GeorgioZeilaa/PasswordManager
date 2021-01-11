using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    class AccountAppDetail
    {
        private string username;
        private Encryption password;
        private string dateUpdated;
        private string dateCreated;

        public string Username
        {
            set { username = value; }
            get { return username; }
        }
        public Encryption Password
        {
            set { password = value; }
            get { return password; }
        }
        public string DateUpdated
        {
            set { dateUpdated = value; }
            get { return dateUpdated; }
        }
        public string DateCreated
        {
            set { dateCreated = value; }
            get { return dateCreated; }
        }
    }
}
