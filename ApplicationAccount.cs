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
        private string name;
        public override void add()
        {
            TextBox t = Application.OpenForms["AddAppAccount"].Controls["txt_add_app_account_applicationname"] as TextBox;
            name = t.Text;
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
    }
}
