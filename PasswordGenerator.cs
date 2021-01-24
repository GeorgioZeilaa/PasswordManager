using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    class PasswordGenerator
    {
        //to choose randomly from the string of characters in the generatePassword function
        private const string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!#$%&*@";

        public string generatePassword()
        {
            Random rng = new Random();
            int size = characters.Length;
            string password = "";

            int max = rng.Next(2, 5);//between 8 and 20 characters because of the for loop running 4 times every 1 while loop
            int incerement = 0;

            while (incerement != max)
            {
                int value = 0;
                for (int i = 0; i < 5; i++)
                {
                    int random = rng.Next(value, 13+value);//the value starts at 0 and then is incremented by 13 every time to reach maximum of 65 value
                    password += characters[random];
                    value += 13;//the value of 17 is chosen because this should repeat 4 times
                }
                incerement++;
            }
            return password;
        }
    }
}
