using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    class WebsiteAccount
    {
        private string name;
        private string url;

        public void add()
        {

        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Url
        {
            set { url = value; }
            get { return url; }
        }
    }
}
