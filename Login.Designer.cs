
namespace PasswordManager
{
    partial class Login
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
            this.txt_login_username = new System.Windows.Forms.TextBox();
            this.lbl_login_username = new System.Windows.Forms.Label();
            this.btn_login_login = new System.Windows.Forms.Button();
            this.lbl_login_password = new System.Windows.Forms.Label();
            this.txt_login_password = new System.Windows.Forms.TextBox();
            this.lbl_login_incorrect_info = new System.Windows.Forms.Label();
            this.lbl_login_fill_field = new System.Windows.Forms.Label();
            this.lbl_login_failed_login = new System.Windows.Forms.Label();
            this.btn_login_reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_login_username
            // 
            this.txt_login_username.Location = new System.Drawing.Point(335, 134);
            this.txt_login_username.Name = "txt_login_username";
            this.txt_login_username.Size = new System.Drawing.Size(174, 20);
            this.txt_login_username.TabIndex = 0;
            // 
            // lbl_login_username
            // 
            this.lbl_login_username.AutoSize = true;
            this.lbl_login_username.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_username.Location = new System.Drawing.Point(332, 114);
            this.lbl_login_username.Name = "lbl_login_username";
            this.lbl_login_username.Size = new System.Drawing.Size(75, 17);
            this.lbl_login_username.TabIndex = 1;
            this.lbl_login_username.Text = "Username:";
            // 
            // btn_login_login
            // 
            this.btn_login_login.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_login_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login_login.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_login.ForeColor = System.Drawing.Color.Black;
            this.btn_login_login.Location = new System.Drawing.Point(425, 250);
            this.btn_login_login.Name = "btn_login_login";
            this.btn_login_login.Size = new System.Drawing.Size(84, 32);
            this.btn_login_login.TabIndex = 2;
            this.btn_login_login.Text = "Login";
            this.btn_login_login.UseVisualStyleBackColor = false;
            this.btn_login_login.Click += new System.EventHandler(this.btn_login_login_Click);
            // 
            // lbl_login_password
            // 
            this.lbl_login_password.AutoSize = true;
            this.lbl_login_password.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_password.Location = new System.Drawing.Point(332, 182);
            this.lbl_login_password.Name = "lbl_login_password";
            this.lbl_login_password.Size = new System.Drawing.Size(73, 17);
            this.lbl_login_password.TabIndex = 3;
            this.lbl_login_password.Text = "Password:";
            // 
            // txt_login_password
            // 
            this.txt_login_password.Location = new System.Drawing.Point(335, 211);
            this.txt_login_password.Name = "txt_login_password";
            this.txt_login_password.Size = new System.Drawing.Size(174, 20);
            this.txt_login_password.TabIndex = 1;
            // 
            // lbl_login_incorrect_info
            // 
            this.lbl_login_incorrect_info.AutoSize = true;
            this.lbl_login_incorrect_info.Location = new System.Drawing.Point(525, 137);
            this.lbl_login_incorrect_info.Name = "lbl_login_incorrect_info";
            this.lbl_login_incorrect_info.Size = new System.Drawing.Size(157, 13);
            this.lbl_login_incorrect_info.TabIndex = 5;
            this.lbl_login_incorrect_info.Text = "*Username/Password incorrect!";
            // 
            // lbl_login_fill_field
            // 
            this.lbl_login_fill_field.AutoSize = true;
            this.lbl_login_fill_field.Location = new System.Drawing.Point(525, 269);
            this.lbl_login_fill_field.Name = "lbl_login_fill_field";
            this.lbl_login_fill_field.Size = new System.Drawing.Size(143, 13);
            this.lbl_login_fill_field.TabIndex = 6;
            this.lbl_login_fill_field.Text = "*Make sure all filled are filled!";
            // 
            // lbl_login_failed_login
            // 
            this.lbl_login_failed_login.AutoSize = true;
            this.lbl_login_failed_login.Location = new System.Drawing.Point(525, 250);
            this.lbl_login_failed_login.Name = "lbl_login_failed_login";
            this.lbl_login_failed_login.Size = new System.Drawing.Size(79, 13);
            this.lbl_login_failed_login.TabIndex = 7;
            this.lbl_login_failed_login.Text = "*Failed to login!";
            // 
            // btn_login_reset
            // 
            this.btn_login_reset.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_login_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login_reset.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_reset.ForeColor = System.Drawing.Color.Black;
            this.btn_login_reset.Location = new System.Drawing.Point(335, 250);
            this.btn_login_reset.Name = "btn_login_reset";
            this.btn_login_reset.Size = new System.Drawing.Size(84, 32);
            this.btn_login_reset.TabIndex = 8;
            this.btn_login_reset.Text = "Reset";
            this.btn_login_reset.UseVisualStyleBackColor = false;
            this.btn_login_reset.Click += new System.EventHandler(this.btn_login_reset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(331, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 451);
            this.panel1.TabIndex = 9;
            // 
            // Login
            // 
            this.AcceptButton = this.btn_login_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_login_reset);
            this.Controls.Add(this.lbl_login_failed_login);
            this.Controls.Add(this.lbl_login_fill_field);
            this.Controls.Add(this.lbl_login_incorrect_info);
            this.Controls.Add(this.txt_login_password);
            this.Controls.Add(this.lbl_login_password);
            this.Controls.Add(this.btn_login_login);
            this.Controls.Add(this.lbl_login_username);
            this.Controls.Add(this.txt_login_username);
            this.KeyPreview = true;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_login_username;
        private System.Windows.Forms.Label lbl_login_username;
        private System.Windows.Forms.Button btn_login_login;
        private System.Windows.Forms.Label lbl_login_password;
        private System.Windows.Forms.TextBox txt_login_password;
        private System.Windows.Forms.Label lbl_login_incorrect_info;
        private System.Windows.Forms.Label lbl_login_fill_field;
        private System.Windows.Forms.Label lbl_login_failed_login;
        private System.Windows.Forms.Button btn_login_reset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}