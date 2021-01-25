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
    public partial class EditForm : Form
    {
        string[] info;
        Encryption encrypt = new Encryption();
        public EditForm(string[] info)
        {
            InitializeComponent();
            this.info = info;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            //error warning messages
            lbl_editform_emptyfield.Visible = false;

            //the user should not be able to edit those
            txt_editform_dateupdated.Enabled = false;
            txt_editform_datecreated.Enabled = false;
            txt_editform_userid.Enabled = false;
            txt_editform_id.Enabled = false;
            txt_editform_password.Enabled = false;
            lbl_editform_url.Visible = false;

            //limiting the amount of characters allowed
            txt_editform_username.MaxLength = 50;
            txt_editform_name.MaxLength = 50;
            txt_editform_url.MaxLength = 200;

            btn_editform_reset_Click(sender, e);//to set everything correctly
        }

        private void btn_editform_update_Click(object sender, EventArgs e)
        {
            int size = info.Count() - 1;
            DataBase db = new DataBase();
            info[2] = txt_editform_username.Text;
            info[6] = txt_editform_name.Text;

            //if the password was revealed then encrypt it to get ready to be added to the database
            if (btn_editform_modifypassword.Text == "Hide")
            {
                txt_editform_password.Text = encrypt.encryptDecrypt(txt_editform_password.Text);
                txt_editform_password.Enabled = false;
                btn_editform_modifypassword.Text = "Modify";
                info[3] = txt_editform_password.Text;
            }
            else
            {
                info[3] = txt_editform_password.Text;
            }

            //showing labels and textboxes if it is a website
            if (info[size] == "WebsiteAccount")
            {
                info[7] = txt_editform_url.Text;
            }

            if(db.modify(info))
            {
                MessageBox.Show("Successfully modified!");
            }
            else
            {
                MessageBox.Show("ERROR: Could not modify!");
                this.Close();
            }
        }

        private void btn_editform_reset_Click(object sender, EventArgs e)
        {
            int size = info.Count() - 1;
            //to populate the existing data into textboxes
            txt_editform_id.Text = info[0];
            txt_editform_userid.Text = info[1];
            txt_editform_username.Text = info[2];
            txt_editform_dateupdated.Text = info[4];
            txt_editform_datecreated.Text = info[5];
            txt_editform_name.Text = info[6];

            //showing labels and textboxes if it is a website
            if (info[size] == "WebsiteAccount")
            {
                txt_editform_url.Visible = true;
                lbl_editform_url.Visible = true;
                txt_editform_url.Text = info[7];
            }
            else
            {
                txt_editform_url.Visible = false;
                lbl_editform_url.Visible = false;
            }
            //make sure to reset the password field
            btn_editform_modifypassword.Text = "Modify";
            txt_editform_password.Text = info[3];
            txt_editform_password.Enabled = false;
        }

        private void btn_editform_modifypassword_Click(object sender, EventArgs e)
        {
            //problem with hello password
            if (btn_editform_modifypassword.Text == "Modify") 
            {
                txt_editform_password.Text = encrypt.encryptDecrypt(txt_editform_password.Text);
                txt_editform_password.Enabled = true;
                btn_editform_modifypassword.Text = "Hide";
            }
            else if (btn_editform_modifypassword.Text == "Hide")
            {
                txt_editform_password.Text = encrypt.encryptDecrypt(txt_editform_password.Text);
                txt_editform_password.Enabled = false;
                btn_editform_modifypassword.Text = "Modify";
            }
        }

        private void EditForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }
    }
}
