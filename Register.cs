using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Register : Form
    {
        Authenticator authenticator = new Authenticator();
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            lbl_register_password_dont_match.Visible = false;
        }

        public bool register()
        {
            string username = Convert.ToString(txt_register_username);
            string password = "0";
            if (txt_register_pasword1 == txt_register_password2)
            {
                password = Convert.ToString(txt_register_pasword1);
            }
            else
            {
                lbl_register_password_dont_match.Visible = true;
            }
            

            if(authenticator.addAccount(username,password))
            {
                MainInterface settingform = new MainInterface();

                settingform.Show();
                this.Close();
            }
            else
            {
                
            }


            return false;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            register();
        }
    }
}
