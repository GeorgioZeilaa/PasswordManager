
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
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_ViewPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // data_grid_ViewPassword
            // 
            this.data_grid_ViewPassword.AllowUserToAddRows = false;
            this.data_grid_ViewPassword.AllowUserToDeleteRows = false;
            this.data_grid_ViewPassword.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_ViewPassword.Location = new System.Drawing.Point(211, 101);
            this.data_grid_ViewPassword.Name = "data_grid_ViewPassword";
            this.data_grid_ViewPassword.Size = new System.Drawing.Size(240, 150);
            this.data_grid_ViewPassword.TabIndex = 0;
            this.data_grid_ViewPassword.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ViewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data_grid_ViewPassword);
            this.Name = "ViewPassword";
            this.Text = "ViewPassword";
            this.Load += new System.EventHandler(this.ViewPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_ViewPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_grid_ViewPassword;
    }
}