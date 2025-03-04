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
    public partial class Register : Form
    {
        Authenticator authenticator = new Authenticator();
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            //warning/error labels not shown at start
            lbl_register_password_dont_match.Visible = false;
            lbl_register_failed_registration.Visible = false;
            lbl_register_fill_fields.Visible = false;

            //password input will not be visible
            txt_register_password1.PasswordChar = '*';
            txt_register_password2.PasswordChar = '*';

            //limiting the amount of characters allowed
            txt_register_username.MaxLength = 50;
            txt_register_password1.MaxLength = 128;
            txt_register_password2.MaxLength = 128;
        }

        public bool register()
        {
            string username = Convert.ToString(txt_register_username.Text);
            string password1 = Convert.ToString(txt_register_password1.Text);
            string password2 = Convert.ToString(txt_register_password2.Text);
            string password = "";

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password1) && !string.IsNullOrEmpty(password2))
            {
                if (password1 == password2)
                {
                    password = password1;
                    if (authenticator.addAccount(username, password))
                    {
                        return true;
                    }
                    else
                    {
                        lbl_register_fill_fields.Visible = false;
                        lbl_register_failed_registration.Visible = true;
                        return false;
                    }
                }
                else
                {
                    lbl_register_fill_fields.Visible = false;
                    lbl_register_password_dont_match.Visible = true;
                    return false;
                }
            }
            else 
            {
                lbl_register_fill_fields.Visible = true;
                return false; 
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if(register())
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Main main = new Main();
            main.Show();
        }

        private void Register_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }
    }
}
