
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
            this.txt_register_password1 = new System.Windows.Forms.TextBox();
            this.lbl_register_username = new System.Windows.Forms.Label();
            this.lbl_register_password1 = new System.Windows.Forms.Label();
            this.txt_register_password2 = new System.Windows.Forms.TextBox();
            this.lbl_register_password2 = new System.Windows.Forms.Label();
            this.lbl_register_password_dont_match = new System.Windows.Forms.Label();
            this.lbl_register_failed_registration = new System.Windows.Forms.Label();
            this.lbl_register_fill_fields = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_register.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(332, 291);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(231, 35);
            this.btn_register.TabIndex = 0;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // txt_register_username
            // 
            this.txt_register_username.Location = new System.Drawing.Point(334, 139);
            this.txt_register_username.Name = "txt_register_username";
            this.txt_register_username.Size = new System.Drawing.Size(229, 20);
            this.txt_register_username.TabIndex = 1;
            // 
            // txt_register_password1
            // 
            this.txt_register_password1.Location = new System.Drawing.Point(334, 191);
            this.txt_register_password1.Name = "txt_register_password1";
            this.txt_register_password1.Size = new System.Drawing.Size(229, 20);
            this.txt_register_password1.TabIndex = 2;
            // 
            // lbl_register_username
            // 
            this.lbl_register_username.AutoSize = true;
            this.lbl_register_username.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_register_username.Location = new System.Drawing.Point(331, 120);
            this.lbl_register_username.Name = "lbl_register_username";
            this.lbl_register_username.Size = new System.Drawing.Size(75, 17);
            this.lbl_register_username.TabIndex = 3;
            this.lbl_register_username.Text = "Username:";
            // 
            // lbl_register_password1
            // 
            this.lbl_register_password1.AutoSize = true;
            this.lbl_register_password1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_register_password1.Location = new System.Drawing.Point(331, 172);
            this.lbl_register_password1.Name = "lbl_register_password1";
            this.lbl_register_password1.Size = new System.Drawing.Size(73, 17);
            this.lbl_register_password1.TabIndex = 4;
            this.lbl_register_password1.Text = "Password:";
            // 
            // txt_register_password2
            // 
            this.txt_register_password2.Location = new System.Drawing.Point(334, 242);
            this.txt_register_password2.Name = "txt_register_password2";
            this.txt_register_password2.Size = new System.Drawing.Size(229, 20);
            this.txt_register_password2.TabIndex = 5;
            // 
            // lbl_register_password2
            // 
            this.lbl_register_password2.AutoSize = true;
            this.lbl_register_password2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_register_password2.Location = new System.Drawing.Point(331, 223);
            this.lbl_register_password2.Name = "lbl_register_password2";
            this.lbl_register_password2.Size = new System.Drawing.Size(111, 17);
            this.lbl_register_password2.TabIndex = 6;
            this.lbl_register_password2.Text = "Verify Password:";
            // 
            // lbl_register_password_dont_match
            // 
            this.lbl_register_password_dont_match.AutoSize = true;
            this.lbl_register_password_dont_match.Location = new System.Drawing.Point(569, 249);
            this.lbl_register_password_dont_match.Name = "lbl_register_password_dont_match";
            this.lbl_register_password_dont_match.Size = new System.Drawing.Size(133, 13);
            this.lbl_register_password_dont_match.TabIndex = 7;
            this.lbl_register_password_dont_match.Text = "*Password does not match";
            // 
            // lbl_register_failed_registration
            // 
            this.lbl_register_failed_registration.AutoSize = true;
            this.lbl_register_failed_registration.Location = new System.Drawing.Point(569, 142);
            this.lbl_register_failed_registration.Name = "lbl_register_failed_registration";
            this.lbl_register_failed_registration.Size = new System.Drawing.Size(123, 13);
            this.lbl_register_failed_registration.TabIndex = 8;
            this.lbl_register_failed_registration.Text = "*Username already exist!";
            // 
            // lbl_register_fill_fields
            // 
            this.lbl_register_fill_fields.AutoSize = true;
            this.lbl_register_fill_fields.Location = new System.Drawing.Point(569, 304);
            this.lbl_register_fill_fields.Name = "lbl_register_fill_fields";
            this.lbl_register_fill_fields.Size = new System.Drawing.Size(128, 13);
            this.lbl_register_fill_fields.TabIndex = 9;
            this.lbl_register_fill_fields.Text = "*Make sure to fill all fields!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 452);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 84);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password\r\n Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(334, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Register";
            // 
            // Register
            // 
            this.AcceptButton = this.btn_register;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_register_fill_fields);
            this.Controls.Add(this.lbl_register_failed_registration);
            this.Controls.Add(this.lbl_register_password_dont_match);
            this.Controls.Add(this.lbl_register_password2);
            this.Controls.Add(this.txt_register_password2);
            this.Controls.Add(this.lbl_register_password1);
            this.Controls.Add(this.lbl_register_username);
            this.Controls.Add(this.txt_register_password1);
            this.Controls.Add(this.txt_register_username);
            this.Controls.Add(this.btn_register);
            this.KeyPreview = true;
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Register_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.TextBox txt_register_username;
        private System.Windows.Forms.TextBox txt_register_password1;
        private System.Windows.Forms.Label lbl_register_username;
        private System.Windows.Forms.Label lbl_register_password1;
        private System.Windows.Forms.TextBox txt_register_password2;
        private System.Windows.Forms.Label lbl_register_password2;
        private System.Windows.Forms.Label lbl_register_password_dont_match;
        private System.Windows.Forms.Label lbl_register_failed_registration;
        private System.Windows.Forms.Label lbl_register_fill_fields;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}