
namespace PasswordManager
{
    partial class ModifyOptionForms
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
            this.btn_modifyoptionforms_edit = new System.Windows.Forms.Button();
            this.btn_modifyoptionforms_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_modifyoptionforms_edit
            // 
            this.btn_modifyoptionforms_edit.Location = new System.Drawing.Point(59, 45);
            this.btn_modifyoptionforms_edit.Name = "btn_modifyoptionforms_edit";
            this.btn_modifyoptionforms_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_modifyoptionforms_edit.TabIndex = 0;
            this.btn_modifyoptionforms_edit.Text = "Edit";
            this.btn_modifyoptionforms_edit.UseVisualStyleBackColor = true;
            this.btn_modifyoptionforms_edit.Click += new System.EventHandler(this.btn_modifyoptionforms_edit_Click);
            // 
            // btn_modifyoptionforms_delete
            // 
            this.btn_modifyoptionforms_delete.Location = new System.Drawing.Point(163, 45);
            this.btn_modifyoptionforms_delete.Name = "btn_modifyoptionforms_delete";
            this.btn_modifyoptionforms_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_modifyoptionforms_delete.TabIndex = 1;
            this.btn_modifyoptionforms_delete.Text = "Delete";
            this.btn_modifyoptionforms_delete.UseVisualStyleBackColor = true;
            this.btn_modifyoptionforms_delete.Click += new System.EventHandler(this.btn_modifyoptionforms_delete_Click);
            // 
            // ModifyOptionForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 112);
            this.Controls.Add(this.btn_modifyoptionforms_delete);
            this.Controls.Add(this.btn_modifyoptionforms_edit);
            this.Name = "ModifyOptionForms";
            this.Text = "ModifyOptionForms";
            this.Load += new System.EventHandler(this.ModifyOptionForms_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_modifyoptionforms_edit;
        private System.Windows.Forms.Button btn_modifyoptionforms_delete;
    }
}