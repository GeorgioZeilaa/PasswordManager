using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PasswordManager
{
    public partial class Login : Form
    {
        Authenticator auth = new Authenticator();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //making all the error labels not visible on load
            lbl_login_failed_login.Visible = false;
            lbl_login_fill_field.Visible = false;
            lbl_login_incorrect_info.Visible = false;

            txt_login_password.PasswordChar = '*';
        }
        public int[] login()
        {
            int[] permission_and_id = new int[2];
            permission_and_id[0] = 0;
            permission_and_id[1] = 0;

            string username = txt_login_username.Text;
            string password = txt_login_password.Text;

            if(!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                lbl_login_fill_field.Visible = false;//if they are not empty then it should not show that error message anymore
                permission_and_id = auth.verifyAccount(username, password);
                
                if (permission_and_id[0] > 0)//anything above 0 is able to login successfully
                {
                    return permission_and_id;
                }
                else 
                {
                    lbl_login_incorrect_info.Visible = true;
                    return permission_and_id;
                }
            }
            else 
            {
                lbl_login_fill_field.Visible = true;
                return permission_and_id;
            }
        }

        public bool reset()
        {
            string password2 = Interaction.InputBox("Reset password confirmation", "Confirm Password", "", 0, 0);
            string username = txt_login_username.Text;

            if(txt_login_password.Text == password2)//making sure both passwords are matching
            {
                return auth.resetAccount(username, password2);
            }
            else
            {
                MessageBox.Show("Passwords do not match!");
            }
            return false;
        }

        private void btn_login_login_Click(object sender, EventArgs e)
        {
            int []permission_and_id = login();
            if (permission_and_id[0] > 0)
            {
                this.Hide();
                MainInterface mainInter = new MainInterface(txt_login_username.Text, permission_and_id);
                mainInter.Show();
            }
        }

        private void btn_login_reset_Click(object sender, EventArgs e)
        {
            reset();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Main main = new Main();
            main.Show();
        }
    }
}
