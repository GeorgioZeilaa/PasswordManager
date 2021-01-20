using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    class WebsiteAccount : AddAppAccount
    {
        private string nameWeb;
        private string url;

        public override void Add(AccountAppDetail detail)
        {

        }
        public string NameWeb
        {
            set { nameWeb = value; }
            get { return nameWeb; }
        }
        public string Url
        {
            set { url = value; }
            get { return url; }
        }
    }
}
