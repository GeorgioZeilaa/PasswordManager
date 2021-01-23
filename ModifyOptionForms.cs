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
    public partial class ModifyOptionForms : Form
    {
        string[] info;
        public ModifyOptionForms(string[] info)
        {
            this.info = info;
            InitializeComponent();
        }

        private void ModifyOptionForms_Load(object sender, EventArgs e)
        {
            this.Text = "Choose an Option:";
        }

        private void btn_modifyoptionforms_edit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modifyoptionforms_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "CHECK", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                DataBase db = new DataBase();
                if(db.delete(info))
                {
                    MessageBox.Show("Successfully deleted");
                }
                else
                {
                    MessageBox.Show("ERROR: Could not delete");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
               //can add code to the button no
            }
        }
    }
}
