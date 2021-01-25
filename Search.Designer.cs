
namespace PasswordManager
{
    partial class Search
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
            this.txt_search_name = new System.Windows.Forms.TextBox();
            this.lbl_search_name = new System.Windows.Forms.Label();
            this.btn_search_search = new System.Windows.Forms.Button();
            this.rdr_search_website = new System.Windows.Forms.RadioButton();
            this.rdr_search_game = new System.Windows.Forms.RadioButton();
            this.rdr_search_application = new System.Windows.Forms.RadioButton();
            this.data_grid_view_search_result = new System.Windows.Forms.DataGridView();
            this.btn_search_modify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view_search_result)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search_name
            // 
            this.txt_search_name.Location = new System.Drawing.Point(256, 78);
            this.txt_search_name.Name = "txt_search_name";
            this.txt_search_name.Size = new System.Drawing.Size(100, 20);
            this.txt_search_name.TabIndex = 0;
            // 
            // lbl_search_name
            // 
            this.lbl_search_name.AutoSize = true;
            this.lbl_search_name.Location = new System.Drawing.Point(77, 81);
            this.lbl_search_name.Name = "lbl_search_name";
            this.lbl_search_name.Size = new System.Drawing.Size(173, 13);
            this.lbl_search_name.TabIndex = 1;
            this.lbl_search_name.Text = "Name of website/application/game";
            // 
            // btn_search_search
            // 
            this.btn_search_search.Location = new System.Drawing.Point(266, 173);
            this.btn_search_search.Name = "btn_search_search";
            this.btn_search_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search_search.TabIndex = 2;
            this.btn_search_search.Text = "Search";
            this.btn_search_search.UseVisualStyleBackColor = true;
            this.btn_search_search.Click += new System.EventHandler(this.btn_search_search_Click);
            // 
            // rdr_search_website
            // 
            this.rdr_search_website.AutoSize = true;
            this.rdr_search_website.Location = new System.Drawing.Point(256, 104);
            this.rdr_search_website.Name = "rdr_search_website";
            this.rdr_search_website.Size = new System.Drawing.Size(64, 17);
            this.rdr_search_website.TabIndex = 3;
            this.rdr_search_website.TabStop = true;
            this.rdr_search_website.Text = "Website";
            this.rdr_search_website.UseVisualStyleBackColor = true;
            // 
            // rdr_search_game
            // 
            this.rdr_search_game.AutoSize = true;
            this.rdr_search_game.Location = new System.Drawing.Point(256, 127);
            this.rdr_search_game.Name = "rdr_search_game";
            this.rdr_search_game.Size = new System.Drawing.Size(53, 17);
            this.rdr_search_game.TabIndex = 4;
            this.rdr_search_game.TabStop = true;
            this.rdr_search_game.Text = "Game";
            this.rdr_search_game.UseVisualStyleBackColor = true;
            // 
            // rdr_search_application
            // 
            this.rdr_search_application.AutoSize = true;
            this.rdr_search_application.Location = new System.Drawing.Point(256, 150);
            this.rdr_search_application.Name = "rdr_search_application";
            this.rdr_search_application.Size = new System.Drawing.Size(77, 17);
            this.rdr_search_application.TabIndex = 5;
            this.rdr_search_application.TabStop = true;
            this.rdr_search_application.Text = "Application";
            this.rdr_search_application.UseVisualStyleBackColor = true;
            // 
            // data_grid_view_search_result
            // 
            this.data_grid_view_search_result.AllowUserToAddRows = false;
            this.data_grid_view_search_result.AllowUserToDeleteRows = false;
            this.data_grid_view_search_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_grid_view_search_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_view_search_result.Location = new System.Drawing.Point(400, 78);
            this.data_grid_view_search_result.Name = "data_grid_view_search_result";
            this.data_grid_view_search_result.ReadOnly = true;
            this.data_grid_view_search_result.Size = new System.Drawing.Size(677, 89);
            this.data_grid_view_search_result.TabIndex = 6;
            // 
            // btn_search_modify
            // 
            this.btn_search_modify.Location = new System.Drawing.Point(400, 173);
            this.btn_search_modify.Name = "btn_search_modify";
            this.btn_search_modify.Size = new System.Drawing.Size(75, 23);
            this.btn_search_modify.TabIndex = 7;
            this.btn_search_modify.Text = "Modify";
            this.btn_search_modify.UseVisualStyleBackColor = true;
            this.btn_search_modify.Click += new System.EventHandler(this.btn_search_modify_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 314);
            this.Controls.Add(this.btn_search_modify);
            this.Controls.Add(this.data_grid_view_search_result);
            this.Controls.Add(this.rdr_search_application);
            this.Controls.Add(this.rdr_search_game);
            this.Controls.Add(this.rdr_search_website);
            this.Controls.Add(this.btn_search_search);
            this.Controls.Add(this.lbl_search_name);
            this.Controls.Add(this.txt_search_name);
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view_search_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search_name;
        private System.Windows.Forms.Label lbl_search_name;
        private System.Windows.Forms.Button btn_search_search;
        private System.Windows.Forms.RadioButton rdr_search_website;
        private System.Windows.Forms.RadioButton rdr_search_game;
        private System.Windows.Forms.RadioButton rdr_search_application;
        private System.Windows.Forms.DataGridView data_grid_view_search_result;
        private System.Windows.Forms.Button btn_search_modify;
    }
}