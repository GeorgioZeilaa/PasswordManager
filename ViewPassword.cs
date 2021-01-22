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
    public partial class ViewPassword : Form
    {
        private int []permission_and_id;
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

        }

        private void btn_viewpassword_modify_Click(object sender, EventArgs e)
        {

        }

        private void btn_viewpassword_application_Click(object sender, EventArgs e)
        {
            DataTable info = new DataTable();
            info.Load(db.viewPassword(permission_and_id,"ApplicationAccount"));
            data_grid_ViewPassword.DataSource = info;
        }

        private void btn_viewpassword_game_Click(object sender, EventArgs e)
        {
            DataTable info = new DataTable();
            info.Load(db.viewPassword(permission_and_id, "GameAccount"));
            data_grid_ViewPassword.DataSource = info;
        }

        private void btn_viewpassword_website_Click(object sender, EventArgs e)
        {
            DataTable info = new DataTable();
            info.Load(db.viewPassword(permission_and_id, "WebsiteAccount"));
            data_grid_ViewPassword.DataSource = info;
        }
    }
}
