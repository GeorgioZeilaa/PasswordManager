using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    class GameAccount : AddAppAccount
    {
        private string developer;

        public override void Add(AccountAppDetail detail)
        {

        }
        public string Developer
        {
            set { developer = value; }
            get { return developer; }
        }
    }
}
