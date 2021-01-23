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
    public partial class MainInterface : Form
    {
        private string username;
        private int []permission_and_id;
        private int userid;
        AddAppAccount addappuser = new AddAppAccount();
        public MainInterface(string username, int []permission_and_id)
        {
            this.username = username;
            this.permission_and_id = permission_and_id;
            this.userid = permission_and_id[1];
            addappuser.userID = this.userid;//assigning this variable from addappaccount class to be able to assign the user id to the account they create
            InitializeComponent();
        }

        private void MainInterface_Load(object sender, EventArgs e)
        {
            
        }

        public void search()
        {

        }

        public void sort()
        {

        }

        public void add()
        {
            addappuser.Show();//problem
        }

        public void delete()
        {

        }

        public void modify()
        {
            
        }

        private void lbl_main_interface_view_passwords_Click(object sender, EventArgs e)
        {
            ViewPassword viewpassword = new ViewPassword(permission_and_id);
            viewpassword.Show();
        }

        private void lbl_main_interface_search_Click(object sender, EventArgs e)
        {

        }

        private void lbl_main_interface_add_Click(object sender, EventArgs e)
        {
            add();
        }

        private void btn_mainInterface_Log_Out_Click(object sender, EventArgs e)
        {
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
