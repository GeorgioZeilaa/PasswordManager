
namespace PasswordManager
{
    partial class ViewPassword
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
            this.data_grid_ViewPassword = new System.Windows.Forms.DataGridView();
            this.btn_viewpassword_revealpasswords = new System.Windows.Forms.Button();
            this.btn_viewpassword_sort = new System.Windows.Forms.Button();
            this.btn_viewpassword_modify = new System.Windows.Forms.Button();
            this.btn_viewpassword_application = new System.Windows.Forms.Button();
            this.btn_viewpassword_game = new System.Windows.Forms.Button();
            this.btn_viewpassword_website = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_ViewPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // data_grid_ViewPassword
            // 
            this.data_grid_ViewPassword.AllowUserToAddRows = false;
            this.data_grid_ViewPassword.AllowUserToDeleteRows = false;
            this.data_grid_ViewPassword.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_ViewPassword.Location = new System.Drawing.Point(38, 101);
            this.data_grid_ViewPassword.Name = "data_grid_ViewPassword";
            this.data_grid_ViewPassword.ReadOnly = true;
            this.data_grid_ViewPassword.Size = new System.Drawing.Size(737, 150);
            this.data_grid_ViewPassword.TabIndex = 0;
            this.data_grid_ViewPassword.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_viewpassword_revealpasswords
            // 
            this.btn_viewpassword_revealpasswords.Location = new System.Drawing.Point(200, 299);
            this.btn_viewpassword_revealpasswords.Name = "btn_viewpassword_revealpasswords";
            this.btn_viewpassword_revealpasswords.Size = new System.Drawing.Size(114, 23);
            this.btn_viewpassword_revealpasswords.TabIndex = 1;
            this.btn_viewpassword_revealpasswords.Text = "Reveal Passwords";
            this.btn_viewpassword_revealpasswords.UseVisualStyleBackColor = true;
            this.btn_viewpassword_revealpasswords.Click += new System.EventHandler(this.btn_viewpassword_revealpasswords_Click);
            // 
            // btn_viewpassword_sort
            // 
            this.btn_viewpassword_sort.Location = new System.Drawing.Point(336, 299);
            this.btn_viewpassword_sort.Name = "btn_viewpassword_sort";
            this.btn_viewpassword_sort.Size = new System.Drawing.Size(75, 23);
            this.btn_viewpassword_sort.TabIndex = 2;
            this.btn_viewpassword_sort.Text = "Sort";
            this.btn_viewpassword_sort.UseVisualStyleBackColor = true;
            this.btn_viewpassword_sort.Click += new System.EventHandler(this.btn_viewpassword_sort_Click);
            // 
            // btn_viewpassword_modify
            // 
            this.btn_viewpassword_modify.Location = new System.Drawing.Point(435, 299);
            this.btn_viewpassword_modify.Name = "btn_viewpassword_modify";
            this.btn_viewpassword_modify.Size = new System.Drawing.Size(75, 23);
            this.btn_viewpassword_modify.TabIndex = 3;
            this.btn_viewpassword_modify.Text = "Modify";
            this.btn_viewpassword_modify.UseVisualStyleBackColor = true;
            this.btn_viewpassword_modify.Click += new System.EventHandler(this.btn_viewpassword_modify_Click);
            // 
            // btn_viewpassword_application
            // 
            this.btn_viewpassword_application.Location = new System.Drawing.Point(239, 55);
            this.btn_viewpassword_application.Name = "btn_viewpassword_application";
            this.btn_viewpassword_application.Size = new System.Drawing.Size(75, 23);
            this.btn_viewpassword_application.TabIndex = 7;
            this.btn_viewpassword_application.Text = "Application";
            this.btn_viewpassword_application.UseVisualStyleBackColor = true;
            this.btn_viewpassword_application.Click += new System.EventHandler(this.btn_viewpassword_application_Click);
            // 
            // btn_viewpassword_game
            // 
            this.btn_viewpassword_game.Location = new System.Drawing.Point(336, 55);
            this.btn_viewpassword_game.Name = "btn_viewpassword_game";
            this.btn_viewpassword_game.Size = new System.Drawing.Size(75, 23);
            this.btn_viewpassword_game.TabIndex = 8;
            this.btn_viewpassword_game.Text = "Game";
            this.btn_viewpassword_game.UseVisualStyleBackColor = true;
            this.btn_viewpassword_game.Click += new System.EventHandler(this.btn_viewpassword_game_Click);
            // 
            // btn_viewpassword_website
            // 
            this.btn_viewpassword_website.Location = new System.Drawing.Point(435, 55);
            this.btn_viewpassword_website.Name = "btn_viewpassword_website";
            this.btn_viewpassword_website.Size = new System.Drawing.Size(75, 23);
            this.btn_viewpassword_website.TabIndex = 9;
            this.btn_viewpassword_website.Text = "Website";
            this.btn_viewpassword_website.UseVisualStyleBackColor = true;
            this.btn_viewpassword_website.Click += new System.EventHandler(this.btn_viewpassword_website_Click);
            // 
            // ViewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_viewpassword_website);
            this.Controls.Add(this.btn_viewpassword_game);
            this.Controls.Add(this.btn_viewpassword_application);
            this.Controls.Add(this.btn_viewpassword_modify);
            this.Controls.Add(this.btn_viewpassword_sort);
            this.Controls.Add(this.btn_viewpassword_revealpasswords);
            this.Controls.Add(this.data_grid_ViewPassword);
            this.Name = "ViewPassword";
            this.Text = "ViewPassword";
            this.Load += new System.EventHandler(this.ViewPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_ViewPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_grid_ViewPassword;
        private System.Windows.Forms.Button btn_viewpassword_revealpasswords;
        private System.Windows.Forms.Button btn_viewpassword_sort;
        private System.Windows.Forms.Button btn_viewpassword_modify;
        private System.Windows.Forms.Button btn_viewpassword_application;
        private System.Windows.Forms.Button btn_viewpassword_game;
        private System.Windows.Forms.Button btn_viewpassword_website;
    }
}