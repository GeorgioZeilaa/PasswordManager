using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    class Encryption
    {
        private string passwordkey = "secret";

        public string encryptDecrypt(string password)
        {
			int dataLen = password.Length;
			int keyLen = passwordkey.Length;
			char[] output = new char[dataLen];

			for (int i = 0; i < dataLen; ++i)
			{
				output[i] = (char)(password[i] ^ passwordkey[i % keyLen]);
			}

			return new string(output);
		}
    }
}
