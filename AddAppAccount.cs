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
    public partial class AddAppAccount : Form
    {
        AccountAppDetail account = new AccountAppDetail();
        public AddAppAccount()
        {
            InitializeComponent();
        }

        public virtual void Add(AccountAppDetail detail)
        {
            
        }

        public string randomPassword()
        {
            PasswordGenerator generate = new PasswordGenerator();
            return generate.generatePassword();
        }

        private void AddAppAccount_Load(object sender, EventArgs e)
        {
            lbl_add_app_application_website_name.Visible = false;
            txt_add_app_account_website_name.Visible = false;
            lbl_add_app_account_website_url.Visible = false;
            txt_add_app_account_website_url.Visible = false;

            lbl_add_app_account_game_developer.Visible = false;
            txt_add_app_account_developer.Visible = false;

            lbl_add_app_account_application_name.Visible = false;
            txt_add_app_account_applicationname.Visible = false;
        }

        private void rdb_add_app_account_website_CheckedChanged(object sender, EventArgs e)
        {
            lbl_add_app_account_game_developer.Visible = false;
            txt_add_app_account_developer.Visible = false;

            lbl_add_app_account_application_name.Visible = false;
            txt_add_app_account_applicationname.Visible = false;

            lbl_add_app_application_website_name.Visible = true;
            txt_add_app_account_website_name.Visible = true;
            lbl_add_app_account_website_url.Visible = true;
            txt_add_app_account_website_url.Visible = true;
        }

        private void rdb_add_app_account_game_CheckedChanged(object sender, EventArgs e)
        {
            lbl_add_app_application_website_name.Visible = false;
            txt_add_app_account_website_name.Visible = false;
            lbl_add_app_account_website_url.Visible = false;
            txt_add_app_account_website_url.Visible = false;

            lbl_add_app_account_application_name.Visible = false;
            txt_add_app_account_applicationname.Visible = false;

            lbl_add_app_account_game_developer.Visible = true;
            txt_add_app_account_developer.Visible = true;
        }

        private void rdb_add_app_account_application_CheckedChanged(object sender, EventArgs e)
        {
            lbl_add_app_application_website_name.Visible = false;
            txt_add_app_account_website_name.Visible = false;
            lbl_add_app_account_website_url.Visible = false;
            txt_add_app_account_website_url.Visible = false;

            lbl_add_app_account_game_developer.Visible = false;
            txt_add_app_account_developer.Visible = false;

            lbl_add_app_account_application_name.Visible = true;
            txt_add_app_account_applicationname.Visible = true;
        }

        private void btn_add_app_account_create_Click(object sender, EventArgs e)
        {
            account.Username = txt_add_app_account_username.Text;
            account.Password = txt_add_app_account_password.Text;
            account.DateCreated = DateTime.Now.ToString("hh,mm,ss,dd,MM,yyyy");

            if (!string.IsNullOrEmpty(account.Username) && !string.IsNullOrEmpty(account.Username))
            {
                if (rdb_add_app_account_application.Checked)
                {
                    AddAppAccount app = new ApplicationAccount();
                    app.Add(account);
                }
                if (rdb_add_app_account_game.Checked)
                {
                    AddAppAccount game = new GameAccount();
                    game.Add(account);
                }
                if (rdb_add_app_account_website.Checked)
                {
                    AddAppAccount website = new WebsiteAccount();
                    website.Add(account);
                }
            }
        }
    }
}
