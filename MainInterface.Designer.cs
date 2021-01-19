
namespace PasswordManager
{
    partial class MainInterface
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
            this.lbl_main_interface_main = new System.Windows.Forms.Label();
            this.lbl_main_interface_view_passwords = new System.Windows.Forms.Button();
            this.lbl_main_interface_search = new System.Windows.Forms.Button();
            this.lbl_main_interface_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_main_interface_main
            // 
            this.lbl_main_interface_main.AutoSize = true;
            this.lbl_main_interface_main.Location = new System.Drawing.Point(223, 64);
            this.lbl_main_interface_main.Name = "lbl_main_interface_main";
            this.lbl_main_interface_main.Size = new System.Drawing.Size(60, 13);
            this.lbl_main_interface_main.TabIndex = 0;
            this.lbl_main_interface_main.Text = "Main Menu";
            // 
            // lbl_main_interface_view_passwords
            // 
            this.lbl_main_interface_view_passwords.Location = new System.Drawing.Point(292, 126);
            this.lbl_main_interface_view_passwords.Name = "lbl_main_interface_view_passwords";
            this.lbl_main_interface_view_passwords.Size = new System.Drawing.Size(98, 23);
            this.lbl_main_interface_view_passwords.TabIndex = 1;
            this.lbl_main_interface_view_passwords.Text = "View Passwords";
            this.lbl_main_interface_view_passwords.UseVisualStyleBackColor = true;
            this.lbl_main_interface_view_passwords.Click += new System.EventHandler(this.lbl_main_interface_view_passwords_Click);
            // 
            // lbl_main_interface_search
            // 
            this.lbl_main_interface_search.Location = new System.Drawing.Point(292, 170);
            this.lbl_main_interface_search.Name = "lbl_main_interface_search";
            this.lbl_main_interface_search.Size = new System.Drawing.Size(98, 23);
            this.lbl_main_interface_search.TabIndex = 2;
            this.lbl_main_interface_search.Text = "Search";
            this.lbl_main_interface_search.UseVisualStyleBackColor = true;
            this.lbl_main_interface_search.Click += new System.EventHandler(this.lbl_main_interface_search_Click);
            // 
            // lbl_main_interface_add
            // 
            this.lbl_main_interface_add.Location = new System.Drawing.Point(292, 211);
            this.lbl_main_interface_add.Name = "lbl_main_interface_add";
            this.lbl_main_interface_add.Size = new System.Drawing.Size(98, 23);
            this.lbl_main_interface_add.TabIndex = 3;
            this.lbl_main_interface_add.Text = "Add";
            this.lbl_main_interface_add.UseVisualStyleBackColor = true;
            this.lbl_main_interface_add.Click += new System.EventHandler(this.lbl_main_interface_add_Click);
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_main_interface_add);
            this.Controls.Add(this.lbl_main_interface_search);
            this.Controls.Add(this.lbl_main_interface_view_passwords);
            this.Controls.Add(this.lbl_main_interface_main);
            this.Name = "MainInterface";
            this.Text = "MainInterface";
            this.Load += new System.EventHandler(this.MainInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_main_interface_main;
        private System.Windows.Forms.Button lbl_main_interface_view_passwords;
        private System.Windows.Forms.Button lbl_main_interface_search;
        private System.Windows.Forms.Button lbl_main_interface_add;
    }
}