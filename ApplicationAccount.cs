using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    class ApplicationAccount : AddAppAccount
    {
        private string name;
        public void add()
        {
            DataBase db = new DataBase();
            
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
    }
}
