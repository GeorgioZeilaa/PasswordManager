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
            this.Show();
        }

        private void btn_main_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btn_main_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
