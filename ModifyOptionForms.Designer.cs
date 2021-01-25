
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_modifyoptionforms_edit
            // 
            this.btn_modifyoptionforms_edit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_modifyoptionforms_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_modifyoptionforms_edit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifyoptionforms_edit.Location = new System.Drawing.Point(321, 147);
            this.btn_modifyoptionforms_edit.Name = "btn_modifyoptionforms_edit";
            this.btn_modifyoptionforms_edit.Size = new System.Drawing.Size(135, 37);
            this.btn_modifyoptionforms_edit.TabIndex = 0;
            this.btn_modifyoptionforms_edit.Text = "Edit";
            this.btn_modifyoptionforms_edit.UseVisualStyleBackColor = false;
            this.btn_modifyoptionforms_edit.Click += new System.EventHandler(this.btn_modifyoptionforms_edit_Click);
            // 
            // btn_modifyoptionforms_delete
            // 
            this.btn_modifyoptionforms_delete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_modifyoptionforms_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_modifyoptionforms_delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifyoptionforms_delete.Location = new System.Drawing.Point(321, 199);
            this.btn_modifyoptionforms_delete.Name = "btn_modifyoptionforms_delete";
            this.btn_modifyoptionforms_delete.Size = new System.Drawing.Size(135, 37);
            this.btn_modifyoptionforms_delete.TabIndex = 1;
            this.btn_modifyoptionforms_delete.Text = "Delete";
            this.btn_modifyoptionforms_delete.UseVisualStyleBackColor = false;
            this.btn_modifyoptionforms_delete.Click += new System.EventHandler(this.btn_modifyoptionforms_delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(269, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Modify Menu:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 451);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password\r\n Manager";
            // 
            // ModifyOptionForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(516, 449);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_modifyoptionforms_delete);
            this.Controls.Add(this.btn_modifyoptionforms_edit);
            this.Name = "ModifyOptionForms";
            this.Text = "ModifyOptionForms";
            this.Load += new System.EventHandler(this.ModifyOptionForms_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_modifyoptionforms_edit;
        private System.Windows.Forms.Button btn_modifyoptionforms_delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}