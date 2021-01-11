﻿
namespace PasswordManager
{
    partial class Register
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
            this.btn_register = new System.Windows.Forms.Button();
            this.txt_register_username = new System.Windows.Forms.TextBox();
            this.txt_register_pasword1 = new System.Windows.Forms.TextBox();
            this.lbl_register_username = new System.Windows.Forms.Label();
            this.lbl_register_password1 = new System.Windows.Forms.Label();
            this.txt_register_password2 = new System.Windows.Forms.TextBox();
            this.lbl_register_password2 = new System.Windows.Forms.Label();
            this.lbl_register_password_dont_match = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(222, 165);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 0;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // txt_register_username
            // 
            this.txt_register_username.Location = new System.Drawing.Point(222, 85);
            this.txt_register_username.Name = "txt_register_username";
            this.txt_register_username.Size = new System.Drawing.Size(100, 20);
            this.txt_register_username.TabIndex = 1;
            // 
            // txt_register_pasword1
            // 
            this.txt_register_pasword1.Location = new System.Drawing.Point(222, 112);
            this.txt_register_pasword1.Name = "txt_register_pasword1";
            this.txt_register_pasword1.Size = new System.Drawing.Size(100, 20);
            this.txt_register_pasword1.TabIndex = 2;
            // 
            // lbl_register_username
            // 
            this.lbl_register_username.AutoSize = true;
            this.lbl_register_username.Location = new System.Drawing.Point(138, 88);
            this.lbl_register_username.Name = "lbl_register_username";
            this.lbl_register_username.Size = new System.Drawing.Size(55, 13);
            this.lbl_register_username.TabIndex = 3;
            this.lbl_register_username.Text = "Username";
            // 
            // lbl_register_password1
            // 
            this.lbl_register_password1.AutoSize = true;
            this.lbl_register_password1.Location = new System.Drawing.Point(138, 115);
            this.lbl_register_password1.Name = "lbl_register_password1";
            this.lbl_register_password1.Size = new System.Drawing.Size(53, 13);
            this.lbl_register_password1.TabIndex = 4;
            this.lbl_register_password1.Text = "Password";
            // 
            // txt_register_password2
            // 
            this.txt_register_password2.Location = new System.Drawing.Point(222, 138);
            this.txt_register_password2.Name = "txt_register_password2";
            this.txt_register_password2.Size = new System.Drawing.Size(100, 20);
            this.txt_register_password2.TabIndex = 5;
            // 
            // lbl_register_password2
            // 
            this.lbl_register_password2.AutoSize = true;
            this.lbl_register_password2.Location = new System.Drawing.Point(138, 141);
            this.lbl_register_password2.Name = "lbl_register_password2";
            this.lbl_register_password2.Size = new System.Drawing.Size(82, 13);
            this.lbl_register_password2.TabIndex = 6;
            this.lbl_register_password2.Text = "Verify Password";
            // 
            // lbl_register_password_dont_match
            // 
            this.lbl_register_password_dont_match.AutoSize = true;
            this.lbl_register_password_dont_match.Location = new System.Drawing.Point(328, 141);
            this.lbl_register_password_dont_match.Name = "lbl_register_password_dont_match";
            this.lbl_register_password_dont_match.Size = new System.Drawing.Size(133, 13);
            this.lbl_register_password_dont_match.TabIndex = 7;
            this.lbl_register_password_dont_match.Text = "*Password does not match";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_register_password_dont_match);
            this.Controls.Add(this.lbl_register_password2);
            this.Controls.Add(this.txt_register_password2);
            this.Controls.Add(this.lbl_register_password1);
            this.Controls.Add(this.lbl_register_username);
            this.Controls.Add(this.txt_register_pasword1);
            this.Controls.Add(this.txt_register_username);
            this.Controls.Add(this.btn_register);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.TextBox txt_register_username;
        private System.Windows.Forms.TextBox txt_register_pasword1;
        private System.Windows.Forms.Label lbl_register_username;
        private System.Windows.Forms.Label lbl_register_password1;
        private System.Windows.Forms.TextBox txt_register_password2;
        private System.Windows.Forms.Label lbl_register_password2;
        private System.Windows.Forms.Label lbl_register_password_dont_match;
    }
}