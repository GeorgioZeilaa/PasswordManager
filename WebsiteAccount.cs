using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    class WebsiteAccount : AddAppAccount
    {
        private string nameWeb;
        private string url;

        public override void Add(AccountAppDetail detail)
        {
            DataBase db = new DataBase();
            TextBox name = Application.OpenForms["AddAppAccount"].Controls["txt_add_app_account_website_name"] as TextBox;
            TextBox url = Application.OpenForms["AddAppAccount"].Controls["txt_add_app_account_website_url"] as TextBox;
            NameWeb = name.Text;
            Url = url.Text;
            db.addwebsite(detail, NameWeb, Url);
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
