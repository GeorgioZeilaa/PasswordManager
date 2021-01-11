
namespace PasswordManager
{
    partial class Main
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
            this.btn_main_login = new System.Windows.Forms.Button();
            this.btn_main_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_main_login
            // 
            this.btn_main_login.Location = new System.Drawing.Point(260, 154);
            this.btn_main_login.Name = "btn_main_login";
            this.btn_main_login.Size = new System.Drawing.Size(75, 23);
            this.btn_main_login.TabIndex = 0;
            this.btn_main_login.Text = "Login";
            this.btn_main_login.UseVisualStyleBackColor = true;
            this.btn_main_login.Click += new System.EventHandler(this.btn_main_login_Click);
            // 
            // btn_main_register
            // 
            this.btn_main_register.Location = new System.Drawing.Point(361, 154);
            this.btn_main_register.Name = "btn_main_register";
            this.btn_main_register.Size = new System.Drawing.Size(75, 23);
            this.btn_main_register.TabIndex = 1;
            this.btn_main_register.Text = "Register";
            this.btn_main_register.UseVisualStyleBackColor = true;
            this.btn_main_register.Click += new System.EventHandler(this.btn_main_register_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_main_register);
            this.Controls.Add(this.btn_main_login);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_main_login;
        private System.Windows.Forms.Button btn_main_register;
    }
}