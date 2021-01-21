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
        public ViewPassword(int []permission_and_id)
        {
            this.permission_and_id = permission_and_id;
            InitializeComponent();
        }

        private void ViewPassword_Load(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            DataTable info = new DataTable();
            info.Load(db.viewPassword(permission_and_id));
            data_grid_ViewPassword.DataSource = info;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
