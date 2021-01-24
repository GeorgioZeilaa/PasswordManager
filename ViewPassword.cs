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
            this.permission_and_id = permission_and_id;
            InitializeComponent();
        }
        private void ViewPassword_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            /*            int rowCount = data_grid_ViewPassword.RowCount;
                        int columnCount = data_grid_ViewPassword.Columns.Count;
                        string[,] info = new string[rowCount, columnCount];

                        for (int i = 0; i < rowCount; i++)
                        {
                            for (int j = 0; j < columnCount; j++)
                            {
                                info[i,j] = (data_grid_ViewPassword.Rows[i].Cells[j].Value.ToString());//extracting the selected row info into an array
                            }
                        }*/

            //to know what the account type is
            if (accountType == "ApplicationAccount")
            {
                DataTable info = new DataTable();
                info.Load(db.sort(accountType));
                data_grid_ViewPassword.DataSource = info;
            }
            if (accountType == "GameAccount")
            {
                DataTable info = new DataTable();
                info.Load(db.sort(accountType));
                data_grid_ViewPassword.DataSource = info;
            }
            if (accountType == "WebsiteAccount")
            {
                DataTable info = new DataTable();
                info.Load(db.sort(accountType));
                data_grid_ViewPassword.DataSource = info;
            }
        }

        private void btn_viewpassword_modify_Click(object sender, EventArgs e)
        {
            int size = data_grid_ViewPassword.Columns.Count + 1;
            string[] info = new string[size];

            Encryption pass = new Encryption();


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

/*                //to know what the account type is
                if(accountType == "ApplicationAccount")
                {
                    info[size-1] = accountType;
                }
                if (accountType == "GameAccount")
                {
                    info[size-1] = accountType;
                }
                if (accountType == "WebsiteAccount")
                {
                    info[size-1] = accountType;
                }*/

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
            DataTable info = new DataTable();
            info.Load(db.viewPassword(permission_and_id,"ApplicationAccount"));
            data_grid_ViewPassword.DataSource = info;
            accountType = "ApplicationAccount";

            //reseting the password button text to the correct because passwords are encrypted
            btn_viewpassword_revealpasswords.Text = "Reveal Passwords";
        }

        private void btn_viewpassword_game_Click(object sender, EventArgs e)
        {
            DataTable info = new DataTable();
            info.Load(db.viewPassword(permission_and_id, "GameAccount"));
            data_grid_ViewPassword.DataSource = info;
            accountType = "GameAccount";

            //reseting the password button text to the correct because passwords are encrypted
            btn_viewpassword_revealpasswords.Text = "Reveal Passwords";
        }

        private void btn_viewpassword_website_Click(object sender, EventArgs e)
        {
            DataTable info = new DataTable();
            info.Load(db.viewPassword(permission_and_id, "WebsiteAccount"));
            data_grid_ViewPassword.DataSource = info;
            accountType = "WebsiteAccount";

            //reseting the password button text to the correct because passwords are encrypted
            btn_viewpassword_revealpasswords.Text = "Reveal Passwords";
        }
    }
}
