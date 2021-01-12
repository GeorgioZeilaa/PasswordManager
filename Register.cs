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
            string username = Convert.ToString(txt_register_username.Text);
            string password1 = Convert.ToString(txt_register_pasword1.Text);
            string password2 = Convert.ToString(txt_register_password2.Text);
            string password = "";

            if (password1 == password2)
            {
                password = password1;
                if (authenticator.addAccount(username, password))
                {
                    MainInterface settingform = new MainInterface();

                    settingform.Show();
                    this.Hide();//needs work
                }
                else
                {

                }
            }
            else
            {
                lbl_register_password_dont_match.Visible = true;
            }
            return false;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            register();
        }
    }
}
