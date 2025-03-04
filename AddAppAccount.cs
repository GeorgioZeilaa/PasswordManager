﻿using System;
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
        public int userID;
        public AddAppAccount()
        {
            InitializeComponent();
            //limiting the amount of characters allowed
            txt_add_app_account_applicationname.MaxLength = 50;
            txt_add_app_account_developer.MaxLength = 50;
            txt_add_app_account_password.MaxLength = 128;
            txt_add_app_account_username.MaxLength = 50;
            txt_add_app_account_website_name.MaxLength = 50;
            txt_add_app_account_website_url.MaxLength = 200;
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
            if (rdb_add_app_account_game.Checked || rdb_add_app_account_website.Checked || rdb_add_app_account_application.Checked)
            {
                account.Username = txt_add_app_account_username.Text;
                account.Password = txt_add_app_account_password.Text;
                account.DateCreated = DateTime.Now.ToString("dd/MM/yyyy,hh:mm:ss tt");
                account.DateUpdated = account.DateCreated;
                account.UserID = userID;

                //checking if any fields are empty
                if (!string.IsNullOrEmpty(account.Username) && !string.IsNullOrEmpty(account.Password))
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
                    MessageBox.Show("Succussfully Added New Account!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Make sure to choose a type of an application!");
            }
        }
        private void btn_add_app_account_generatepassword_Click(object sender, EventArgs e)
        {
            //Generating a password function from the PasswordGenerator class will return a string of random characters
            PasswordGenerator generate = new PasswordGenerator();
            txt_add_app_account_password.Text =  generate.generatePassword();
        }

        private void AddAppAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //to not allow spaces
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void lbl_add_app_account_website_url_Click(object sender, EventArgs e)
        {

        }
    }
}
