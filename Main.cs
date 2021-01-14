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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_main_login_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();
            this.Close();
        }

        private void btn_main_register_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
            this.Close();
        }
    }
}
