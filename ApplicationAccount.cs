using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    class ApplicationAccount : AddAppAccount
    {
        private string nameApp = "";
        public string NameApp
        {
            get { return nameApp; }
            set { nameApp = value; }

        }
        public override void Add(AccountAppDetail detail)
        {
            DataBase db = new DataBase();
            TextBox name = Application.OpenForms["AddAppAccount"].Controls["txt_add_app_account_applicationname"] as TextBox;
            NameApp = name.Text;
            db.add(detail, NameApp);
        }
    }
}
