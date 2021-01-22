using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    class PasswordGenerator
    {
        private string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!#$%&*@";

        public string generatePassword()
        {
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            int length = 15;
            while (0 < length--)
            {
                res.Append(characters[rnd.Next(characters.Length)]);
            }
            
            return res.ToString();
        }
    }
}
