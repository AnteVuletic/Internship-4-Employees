namespace Employees.Presentation.ManageEmployees.Popouts
{
    partial class EmployeeTime
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
            this.EmployeInfoTextBox = new System.Windows.Forms.TextBox();
            this.ProjectNameTextbox = new System.Windows.Forms.TextBox();
            this.TimeEmployeeTextbox = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeInfoTextBox
            // 
            this.EmployeInfoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.EmployeInfoTextBox.Location = new System.Drawing.Point(12, 12);
            this.EmployeInfoTextBox.Name = "EmployeInfoTextBox";
            this.EmployeInfoTextBox.ReadOnly = true;
            this.EmployeInfoTextBox.Size = new System.Drawing.Size(223, 26);
            this.EmployeInfoTextBox.TabIndex = 0;
            // 
            // ProjectNameTextbox
            // 
            this.ProjectNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ProjectNameTextbox.Location = new System.Drawing.Point(241, 12);
            this.ProjectNameTextbox.Name = "ProjectNameTextbox";
            this.ProjectNameTextbox.ReadOnly = true;
            this.ProjectNameTextbox.Size = new System.Drawing.Size(109, 26);
            this.ProjectNameTextbox.TabIndex = 1;
            // 
            // TimeEmployeeTextbox
            // 
            this.TimeEmployeeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.TimeEmployeeTextbox.Location = new System.Drawing.Point(375, 12);
            this.TimeEmployeeTextbox.Name = "TimeEmployeeTextbox";
            this.TimeEmployeeTextbox.Size = new System.Drawing.Size(51, 26);
            this.TimeEmployeeTextbox.TabIndex = 2;
            this.TimeEmployeeTextbox.TextChanged += new System.EventHandler(this.TimeEmployeeTextbox_TextChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(438, 12);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(40, 26);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // EmployeeTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 45);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TimeEmployeeTextbox);
            this.Controls.Add(this.ProjectNameTextbox);
            this.Controls.Add(this.EmployeInfoTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "EmployeeTime";
            this.Text = "EmployeeTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmployeInfoTextBox;
        private System.Windows.Forms.TextBox ProjectNameTextbox;
        private System.Windows.Forms.TextBox TimeEmployeeTextbox;
        private System.Windows.Forms.Button BtnSave;
    }
}