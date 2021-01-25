
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_main_login
            // 
            this.btn_main_login.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_main_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_main_login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main_login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_main_login.Location = new System.Drawing.Point(307, 112);
            this.btn_main_login.Name = "btn_main_login";
            this.btn_main_login.Size = new System.Drawing.Size(125, 59);
            this.btn_main_login.TabIndex = 0;
            this.btn_main_login.Text = "Login";
            this.btn_main_login.UseVisualStyleBackColor = false;
            this.btn_main_login.Click += new System.EventHandler(this.btn_main_login_Click);
            // 
            // btn_main_register
            // 
            this.btn_main_register.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_main_register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_main_register.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main_register.Location = new System.Drawing.Point(307, 202);
            this.btn_main_register.Name = "btn_main_register";
            this.btn_main_register.Size = new System.Drawing.Size(125, 59);
            this.btn_main_register.TabIndex = 1;
            this.btn_main_register.Text = "Register";
            this.btn_main_register.UseVisualStyleBackColor = false;
            this.btn_main_register.Click += new System.EventHandler(this.btn_main_register_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 394);
            this.panel1.TabIndex = 2;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 394);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_main_register);
            this.Controls.Add(this.btn_main_login);
            this.Name = "Main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_main_login;
        private System.Windows.Forms.Button btn_main_register;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}