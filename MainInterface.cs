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
    public partial class MainInterface : Form
    {
        private string username;
        private int permission;
        public MainInterface(string username, int permission)
        {
            this.username = username;
            this.permission = permission;
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
            AddAppAccount add = new AddAppAccount();
            add.ShowDialog();
        }

        public void delete()
        {

        }

        public void modify()
        {

        }

        private void lbl_main_interface_view_passwords_Click(object sender, EventArgs e)
        {

        }

        private void lbl_main_interface_search_Click(object sender, EventArgs e)
        {

        }

        private void lbl_main_interface_add_Click(object sender, EventArgs e)
        {
            add();
        }
    }
}
