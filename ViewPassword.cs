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
    public partial class ViewPassword : Form
    {
        private int []permission_and_id;
        string accountType;
        DataBase db = new DataBase();

        public ViewPassword(int []permission_and_id)
        {
            InitializeComponent();

            //to be used to check with permission and userID
            this.permission_and_id = permission_and_id;
        }
        private void ViewPassword_Load(object sender, EventArgs e)
        {
            //disabling button due to no data being shown in datagridview at load
            btn_viewpassword_revealpasswords.Enabled = false;
            btn_viewpassword_sort.Enabled = false;
            btn_viewpassword_modify.Enabled = false;
        }

        private void btn_viewpassword_revealpasswords_Click(object sender, EventArgs e)
        {
            string []password = new string[data_grid_ViewPassword.ColumnCount];//to save passwords

            Encryption pass = new Encryption();

            //this can encrypt and decrypt with the same encryptDecypt function
            for(int i = 0;i<data_grid_ViewPassword.Rows.Count;i++)
            {
                password[i] = pass.encryptDecrypt(data_grid_ViewPassword.Rows[i].Cells["Password"].Value.ToString());
                data_grid_ViewPassword.Rows[i].Cells["Password"].Value = password[i];
            }

            //to show the correct button name according to the passwords being revealed or hidden
            if(btn_viewpassword_revealpasswords.Text == "Reveal Passwords")
            {
                btn_viewpassword_revealpasswords.Text = "Hide Passwords";
            }
            else if (btn_viewpassword_revealpasswords.Text == "Hide Passwords")
            {
                btn_viewpassword_revealpasswords.Text = "Reveal Passwords";
            }
        }

        private void btn_viewpassword_sort_Click(object sender, EventArgs e)
        {
            DataTable info = new DataTable();
            info.Load(db.sort(permission_and_id, accountType));
            data_grid_ViewPassword.DataSource = info;
            buttonCheck();
        }

        private void btn_viewpassword_modify_Click(object sender, EventArgs e)
        {
            int size = data_grid_ViewPassword.Columns.Count + 1;
            string[] info = new string[size];

            //to make sure that the password is encrypted when modify button is pressed
            if (btn_viewpassword_revealpasswords.Text == "Hide Passwords")
            {
                btn_viewpassword_revealpasswords_Click(sender, e);
            }

            //making sure only one row is selected to modify
            if (data_grid_ViewPassword.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow r in data_grid_ViewPassword.SelectedRows)
                {
                    for(int i = 0;i<r.Cells.Count;i++)
                    {
                        info[i] = r.Cells[i].Value.ToString();//extracting the selected row info into an array
                    }
                }

                info[size - 1] = accountType;

                ModifyOptionForms modify = new ModifyOptionForms(info);
                modify.Show();
            }
            else //if the user has not selected a row
            {
                MessageBox.Show("Make sure to select a row first!");
            }
        }

        private void btn_viewpassword_application_Click(object sender, EventArgs e)
        {
            accountType = "ApplicationAccount";
            tablePopulate();
            buttonCheck();
        }

        private void btn_viewpassword_game_Click(object sender, EventArgs e)
        {
            accountType = "GameAccount";
            tablePopulate();
            buttonCheck();
        }

        private void btn_viewpassword_website_Click(object sender, EventArgs e)
        {
            accountType = "WebsiteAccount";
            tablePopulate();
            buttonCheck();
        }

        private void tablePopulate()
        {
            DataTable info = new DataTable();
            info.Load(db.viewPassword(permission_and_id, accountType));
            data_grid_ViewPassword.DataSource = info;
        }

        private void buttonCheck()
        {
            if (data_grid_ViewPassword.Rows.Count == 0)
            {
                btn_viewpassword_revealpasswords.Enabled = false;
                btn_viewpassword_sort.Enabled = false;
                btn_viewpassword_modify.Enabled = false;
            }
            else
            {
                btn_viewpassword_revealpasswords.Enabled = true;
                btn_viewpassword_sort.Enabled = true;
                btn_viewpassword_modify.Enabled = true;
            }
            //reseting the password button text to the correct because passwords are encrypted
            btn_viewpassword_revealpasswords.Text = "Reveal Passwords";
        }
    }
}
