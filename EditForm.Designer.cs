
namespace PasswordManager
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_editform_update = new System.Windows.Forms.Button();
            this.btn_editform_reset = new System.Windows.Forms.Button();
            this.lbl_editform_id = new System.Windows.Forms.Label();
            this.lbl_editform_userid = new System.Windows.Forms.Label();
            this.lbl_editform_username = new System.Windows.Forms.Label();
            this.lbl_editform_password = new System.Windows.Forms.Label();
            this.lbl_editform_dateupdated = new System.Windows.Forms.Label();
            this.lbl_editform_datecreated = new System.Windows.Forms.Label();
            this.lbl_editform_name = new System.Windows.Forms.Label();
            this.lbl_editform_url = new System.Windows.Forms.Label();
            this.txt_editform_id = new System.Windows.Forms.TextBox();
            this.txt_editform_userid = new System.Windows.Forms.TextBox();
            this.txt_editform_username = new System.Windows.Forms.TextBox();
            this.txt_editform_dateupdated = new System.Windows.Forms.TextBox();
            this.txt_editform_datecreated = new System.Windows.Forms.TextBox();
            this.txt_editform_name = new System.Windows.Forms.TextBox();
            this.txt_editform_url = new System.Windows.Forms.TextBox();
            this.lbl_editform_emptyfield = new System.Windows.Forms.Label();
            this.btn_editform_modifypassword = new System.Windows.Forms.Button();
            this.txt_editform_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_editform_update
            // 
            this.btn_editform_update.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_editform_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editform_update.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editform_update.Location = new System.Drawing.Point(314, 481);
            this.btn_editform_update.Name = "btn_editform_update";
            this.btn_editform_update.Size = new System.Drawing.Size(130, 36);
            this.btn_editform_update.TabIndex = 0;
            this.btn_editform_update.Text = "Update";
            this.btn_editform_update.UseVisualStyleBackColor = false;
            this.btn_editform_update.Click += new System.EventHandler(this.btn_editform_update_Click);
            // 
            // btn_editform_reset
            // 
            this.btn_editform_reset.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_editform_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editform_reset.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editform_reset.Location = new System.Drawing.Point(312, 66);
            this.btn_editform_reset.Name = "btn_editform_reset";
            this.btn_editform_reset.Size = new System.Drawing.Size(69, 21);
            this.btn_editform_reset.TabIndex = 1;
            this.btn_editform_reset.Text = "Reset";
            this.btn_editform_reset.UseVisualStyleBackColor = false;
            this.btn_editform_reset.Click += new System.EventHandler(this.btn_editform_reset_Click);
            // 
            // lbl_editform_id
            // 
            this.lbl_editform_id.AutoSize = true;
            this.lbl_editform_id.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editform_id.Location = new System.Drawing.Point(311, 96);
            this.lbl_editform_id.Name = "lbl_editform_id";
            this.lbl_editform_id.Size = new System.Drawing.Size(22, 16);
            this.lbl_editform_id.TabIndex = 2;
            this.lbl_editform_id.Text = "ID:";
            // 
            // lbl_editform_userid
            // 
            this.lbl_editform_userid.AutoSize = true;
            this.lbl_editform_userid.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editform_userid.Location = new System.Drawing.Point(311, 144);
            this.lbl_editform_userid.Name = "lbl_editform_userid";
            this.lbl_editform_userid.Size = new System.Drawing.Size(44, 16);
            this.lbl_editform_userid.TabIndex = 3;
            this.lbl_editform_userid.Text = "UserID:";
            // 
            // lbl_editform_username
            // 
            this.lbl_editform_username.AutoSize = true;
            this.lbl_editform_username.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editform_username.Location = new System.Drawing.Point(311, 193);
            this.lbl_editform_username.Name = "lbl_editform_username";
            this.lbl_editform_username.Size = new System.Drawing.Size(66, 16);
            this.lbl_editform_username.TabIndex = 4;
            this.lbl_editform_username.Text = "UserName:";
            // 
            // lbl_editform_password
            // 
            this.lbl_editform_password.AutoSize = true;
            this.lbl_editform_password.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editform_password.Location = new System.Drawing.Point(311, 241);
            this.lbl_editform_password.Name = "lbl_editform_password";
            this.lbl_editform_password.Size = new System.Drawing.Size(62, 16);
            this.lbl_editform_password.TabIndex = 5;
            this.lbl_editform_password.Text = "Password:";
            // 
            // lbl_editform_dateupdated
            // 
            this.lbl_editform_dateupdated.AutoSize = true;
            this.lbl_editform_dateupdated.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editform_dateupdated.Location = new System.Drawing.Point(311, 293);
            this.lbl_editform_dateupdated.Name = "lbl_editform_dateupdated";
            this.lbl_editform_dateupdated.Size = new System.Drawing.Size(92, 16);
            this.lbl_editform_dateupdated.TabIndex = 6;
            this.lbl_editform_dateupdated.Text = "Date Updated:";
            // 
            // lbl_editform_datecreated
            // 
            this.lbl_editform_datecreated.AutoSize = true;
            this.lbl_editform_datecreated.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editform_datecreated.Location = new System.Drawing.Point(311, 341);
            this.lbl_editform_datecreated.Name = "lbl_editform_datecreated";
            this.lbl_editform_datecreated.Size = new System.Drawing.Size(87, 16);
            this.lbl_editform_datecreated.TabIndex = 7;
            this.lbl_editform_datecreated.Text = "Date Created:";
            // 
            // lbl_editform_name
            // 
            this.lbl_editform_name.AutoSize = true;
            this.lbl_editform_name.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editform_name.Location = new System.Drawing.Point(311, 386);
            this.lbl_editform_name.Name = "lbl_editform_name";
            this.lbl_editform_name.Size = new System.Drawing.Size(44, 16);
            this.lbl_editform_name.TabIndex = 8;
            this.lbl_editform_name.Text = "Name:";
            // 
            // lbl_editform_url
            // 
            this.lbl_editform_url.AutoSize = true;
            this.lbl_editform_url.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editform_url.Location = new System.Drawing.Point(311, 430);
            this.lbl_editform_url.Name = "lbl_editform_url";
            this.lbl_editform_url.Size = new System.Drawing.Size(31, 16);
            this.lbl_editform_url.TabIndex = 9;
            this.lbl_editform_url.Text = "URL:";
            // 
            // txt_editform_id
            // 
            this.txt_editform_id.Location = new System.Drawing.Point(314, 112);
            this.txt_editform_id.Name = "txt_editform_id";
            this.txt_editform_id.Size = new System.Drawing.Size(197, 20);
            this.txt_editform_id.TabIndex = 10;
            // 
            // txt_editform_userid
            // 
            this.txt_editform_userid.Location = new System.Drawing.Point(314, 163);
            this.txt_editform_userid.Name = "txt_editform_userid";
            this.txt_editform_userid.Size = new System.Drawing.Size(197, 20);
            this.txt_editform_userid.TabIndex = 11;
            // 
            // txt_editform_username
            // 
            this.txt_editform_username.Location = new System.Drawing.Point(314, 209);
            this.txt_editform_username.Name = "txt_editform_username";
            this.txt_editform_username.Size = new System.Drawing.Size(197, 20);
            this.txt_editform_username.TabIndex = 12;
            // 
            // txt_editform_dateupdated
            // 
            this.txt_editform_dateupdated.Location = new System.Drawing.Point(314, 309);
            this.txt_editform_dateupdated.Name = "txt_editform_dateupdated";
            this.txt_editform_dateupdated.Size = new System.Drawing.Size(197, 20);
            this.txt_editform_dateupdated.TabIndex = 14;
            // 
            // txt_editform_datecreated
            // 
            this.txt_editform_datecreated.Location = new System.Drawing.Point(314, 357);
            this.txt_editform_datecreated.Name = "txt_editform_datecreated";
            this.txt_editform_datecreated.Size = new System.Drawing.Size(197, 20);
            this.txt_editform_datecreated.TabIndex = 15;
            // 
            // txt_editform_name
            // 
            this.txt_editform_name.Location = new System.Drawing.Point(314, 402);
            this.txt_editform_name.Name = "txt_editform_name";
            this.txt_editform_name.Size = new System.Drawing.Size(197, 20);
            this.txt_editform_name.TabIndex = 16;
            // 
            // txt_editform_url
            // 
            this.txt_editform_url.Location = new System.Drawing.Point(314, 446);
            this.txt_editform_url.Name = "txt_editform_url";
            this.txt_editform_url.Size = new System.Drawing.Size(197, 20);
            this.txt_editform_url.TabIndex = 17;
            // 
            // lbl_editform_emptyfield
            // 
            this.lbl_editform_emptyfield.AutoSize = true;
            this.lbl_editform_emptyfield.Location = new System.Drawing.Point(461, 492);
            this.lbl_editform_emptyfield.Name = "lbl_editform_emptyfield";
            this.lbl_editform_emptyfield.Size = new System.Drawing.Size(154, 13);
            this.lbl_editform_emptyfield.TabIndex = 18;
            this.lbl_editform_emptyfield.Text = "*Make sure all fields are filled in";
            // 
            // btn_editform_modifypassword
            // 
            this.btn_editform_modifypassword.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_editform_modifypassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editform_modifypassword.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editform_modifypassword.Location = new System.Drawing.Point(517, 257);
            this.btn_editform_modifypassword.Name = "btn_editform_modifypassword";
            this.btn_editform_modifypassword.Size = new System.Drawing.Size(61, 20);
            this.btn_editform_modifypassword.TabIndex = 19;
            this.btn_editform_modifypassword.Text = "Modify";
            this.btn_editform_modifypassword.UseVisualStyleBackColor = false;
            this.btn_editform_modifypassword.Click += new System.EventHandler(this.btn_editform_modifypassword_Click);
            // 
            // txt_editform_password
            // 
            this.txt_editform_password.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_editform_password.Location = new System.Drawing.Point(314, 257);
            this.txt_editform_password.Name = "txt_editform_password";
            this.txt_editform_password.Size = new System.Drawing.Size(197, 20);
            this.txt_editform_password.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(310, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Edit";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 531);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password\r\n Manager";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(641, 529);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_editform_modifypassword);
            this.Controls.Add(this.lbl_editform_emptyfield);
            this.Controls.Add(this.txt_editform_url);
            this.Controls.Add(this.txt_editform_name);
            this.Controls.Add(this.txt_editform_datecreated);
            this.Controls.Add(this.txt_editform_dateupdated);
            this.Controls.Add(this.txt_editform_password);
            this.Controls.Add(this.txt_editform_username);
            this.Controls.Add(this.txt_editform_userid);
            this.Controls.Add(this.txt_editform_id);
            this.Controls.Add(this.lbl_editform_url);
            this.Controls.Add(this.lbl_editform_name);
            this.Controls.Add(this.lbl_editform_datecreated);
            this.Controls.Add(this.lbl_editform_dateupdated);
            this.Controls.Add(this.lbl_editform_password);
            this.Controls.Add(this.lbl_editform_username);
            this.Controls.Add(this.lbl_editform_userid);
            this.Controls.Add(this.lbl_editform_id);
            this.Controls.Add(this.btn_editform_reset);
            this.Controls.Add(this.btn_editform_update);
            this.KeyPreview = true;
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditForm_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_editform_update;
        private System.Windows.Forms.Button btn_editform_reset;
        private System.Windows.Forms.Label lbl_editform_id;
        private System.Windows.Forms.Label lbl_editform_userid;
        private System.Windows.Forms.Label lbl_editform_username;
        private System.Windows.Forms.Label lbl_editform_password;
        private System.Windows.Forms.Label lbl_editform_dateupdated;
        private System.Windows.Forms.Label lbl_editform_datecreated;
        private System.Windows.Forms.Label lbl_editform_name;
        private System.Windows.Forms.Label lbl_editform_url;
        private System.Windows.Forms.TextBox txt_editform_id;
        private System.Windows.Forms.TextBox txt_editform_userid;
        private System.Windows.Forms.TextBox txt_editform_username;
        private System.Windows.Forms.TextBox txt_editform_dateupdated;
        private System.Windows.Forms.TextBox txt_editform_datecreated;
        private System.Windows.Forms.TextBox txt_editform_name;
        private System.Windows.Forms.TextBox txt_editform_url;
        private System.Windows.Forms.Label lbl_editform_emptyfield;
        private System.Windows.Forms.Button btn_editform_modifypassword;
        private System.Windows.Forms.TextBox txt_editform_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}