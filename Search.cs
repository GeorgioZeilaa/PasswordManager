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
    public partial class Search : Form
    {
        private int[] permission_and_id;
        DataBase db = new DataBase();
        private string accountType;
        public Search(int[] permission_and_id)
        {
            InitializeComponent();
            //populate the permission level and userID
            this.permission_and_id = permission_and_id;

            //to disable modify button until a result is found
            btn_search_modify.Enabled = false;

            //limiting the amount of characters allowed
            txt_search_name.MaxLength = 50;
        }

        private void btn_search_search_Click(object sender, EventArgs e)
        {
            string search = txt_search_name.Text;
            if (!string.IsNullOrEmpty(search))
            {
                //to check which type of password is chosen
                if (rdr_search_website.Checked)
                {
                    DataTable info = new DataTable();
                    accountType = "WebsiteAccount";
                    info.Load(db.search(permission_and_id, accountType, search));//retrieve the results of the data
                    data_grid_view_search_result.DataSource = info;
                }
                if (rdr_search_game.Checked)
                {
                    DataTable info = new DataTable();
                    accountType = "GameAccount";
                    info.Load(db.search(permission_and_id, accountType, search));//retrieve the results of the data
                    data_grid_view_search_result.DataSource = info;
                }
                if (rdr_search_application.Checked)
                {
                    DataTable info = new DataTable();
                    accountType = "ApplicationAccount";
                    info.Load(db.search(permission_and_id, accountType, search));//retrieve the results of the data
                    data_grid_view_search_result.DataSource = info;
                }
                if (data_grid_view_search_result.Rows.Count == 0)
                {
                    MessageBox.Show("Not Found!");
                    btn_search_modify.Enabled = false;
                }
                else
                {
                    btn_search_modify.Enabled = true;
                }
            }
        }

        private void btn_search_modify_Click(object sender, EventArgs e)
        {
            int size = data_grid_view_search_result.Columns.Count + 1;//plus 1 due to start assigning value not starting with 0
            string[] info = new string[size];

            //making sure only one row is selected to modify
            if (data_grid_view_search_result.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow r in data_grid_view_search_result.SelectedRows)
                {
                    for (int i = 0; i < r.Cells.Count; i++)
                    {
                        info[i] = r.Cells[i].Value.ToString();//extracting the selected row info into an array
                    }
                }

                info[size - 1] = accountType;//to add the account type to the last value in the array that contains the record

                ModifyOptionForms modify = new ModifyOptionForms(info);
                modify.Show();
            }
            else //if the user has not selected a row
            {
                MessageBox.Show("Make sure to select a row first!");
            }
        }
    }
}
