
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
            this.lbl_main_interface_view_passwords = new System.Windows.Forms.Button();
            this.lbl_main_interface_search = new System.Windows.Forms.Button();
            this.lbl_main_interface_add = new System.Windows.Forms.Button();
            this.btn_mainInterface_Log_Out = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_main_interface_view_passwords
            // 
            this.lbl_main_interface_view_passwords.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_main_interface_view_passwords.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_main_interface_view_passwords.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_main_interface_view_passwords.Location = new System.Drawing.Point(318, 122);
            this.lbl_main_interface_view_passwords.Name = "lbl_main_interface_view_passwords";
            this.lbl_main_interface_view_passwords.Size = new System.Drawing.Size(140, 37);
            this.lbl_main_interface_view_passwords.TabIndex = 1;
            this.lbl_main_interface_view_passwords.Text = "View Passwords";
            this.lbl_main_interface_view_passwords.UseVisualStyleBackColor = false;
            this.lbl_main_interface_view_passwords.Click += new System.EventHandler(this.lbl_main_interface_view_passwords_Click);
            // 
            // lbl_main_interface_search
            // 
            this.lbl_main_interface_search.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_main_interface_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_main_interface_search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_main_interface_search.Location = new System.Drawing.Point(318, 187);
            this.lbl_main_interface_search.Name = "lbl_main_interface_search";
            this.lbl_main_interface_search.Size = new System.Drawing.Size(140, 37);
            this.lbl_main_interface_search.TabIndex = 2;
            this.lbl_main_interface_search.Text = "Search";
            this.lbl_main_interface_search.UseVisualStyleBackColor = false;
            this.lbl_main_interface_search.Click += new System.EventHandler(this.lbl_main_interface_search_Click);
            // 
            // lbl_main_interface_add
            // 
            this.lbl_main_interface_add.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_main_interface_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_main_interface_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_main_interface_add.Location = new System.Drawing.Point(318, 251);
            this.lbl_main_interface_add.Name = "lbl_main_interface_add";
            this.lbl_main_interface_add.Size = new System.Drawing.Size(140, 37);
            this.lbl_main_interface_add.TabIndex = 3;
            this.lbl_main_interface_add.Text = "Add";
            this.lbl_main_interface_add.UseVisualStyleBackColor = false;
            this.lbl_main_interface_add.Click += new System.EventHandler(this.lbl_main_interface_add_Click);
            // 
            // btn_mainInterface_Log_Out
            // 
            this.btn_mainInterface_Log_Out.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_mainInterface_Log_Out.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_mainInterface_Log_Out.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mainInterface_Log_Out.Location = new System.Drawing.Point(249, 12);
            this.btn_mainInterface_Log_Out.Name = "btn_mainInterface_Log_Out";
            this.btn_mainInterface_Log_Out.Size = new System.Drawing.Size(97, 29);
            this.btn_mainInterface_Log_Out.TabIndex = 4;
            this.btn_mainInterface_Log_Out.Text = "Log Out";
            this.btn_mainInterface_Log_Out.UseVisualStyleBackColor = false;
            this.btn_mainInterface_Log_Out.Click += new System.EventHandler(this.btn_mainInterface_Log_Out_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 452);
            this.panel1.TabIndex = 11;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(314, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Main Menu";
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_mainInterface_Log_Out);
            this.Controls.Add(this.lbl_main_interface_add);
            this.Controls.Add(this.lbl_main_interface_search);
            this.Controls.Add(this.lbl_main_interface_view_passwords);
            this.Name = "MainInterface";
            this.Text = "MainInterface";
            this.Load += new System.EventHandler(this.MainInterface_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button lbl_main_interface_view_passwords;
        private System.Windows.Forms.Button lbl_main_interface_search;
        private System.Windows.Forms.Button lbl_main_interface_add;
        private System.Windows.Forms.Button btn_mainInterface_Log_Out;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}