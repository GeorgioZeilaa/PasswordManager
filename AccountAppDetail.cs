using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    public class AccountAppDetail
    {
        private string username;
        private string password;
        private int userID;
        Encryption encrypt = new Encryption();
        private string dateUpdated;
        private string dateCreated;

        public int UserID
        {
            set { userID = value; }
            get { return userID; }
        }
        public string Username
        {
            set { username = value; }
            get { return username; }
        }
        public string Password
        {
            set { password = encrypt.encryptDecrypt(value); }
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
