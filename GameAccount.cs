using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    class GameAccount : AddAppAccount
    {
        private string developer;

        public override void Add(AccountAppDetail detail)
        {
            DataBase db = new DataBase();
            TextBox name = Application.OpenForms["AddAppAccount"].Controls["txt_add_app_account_developer"] as TextBox;
            Developer = name.Text;
            db.addgame(detail, Developer);
        }
        public string Developer
        {
            set { developer = value; }
            get { return developer; }
        }
    }
}
