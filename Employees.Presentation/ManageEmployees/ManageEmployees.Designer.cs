namespace Employees.Presentation.ManageEmployees
{
    partial class ManageEmployees
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEditEmployee = new System.Windows.Forms.Button();
            this.BtnDeleteEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnAdd.Location = new System.Drawing.Point(12, 12);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(150, 108);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add Employee";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEditEmployee
            // 
            this.BtnEditEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnEditEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnEditEmployee.Location = new System.Drawing.Point(192, 12);
            this.BtnEditEmployee.Name = "BtnEditEmployee";
            this.BtnEditEmployee.Size = new System.Drawing.Size(150, 108);
            this.BtnEditEmployee.TabIndex = 1;
            this.BtnEditEmployee.Text = "Edit Employee";
            this.BtnEditEmployee.UseVisualStyleBackColor = false;
            this.BtnEditEmployee.Click += new System.EventHandler(this.BtnEditEmployee_Click);
            // 
            // BtnDeleteEmployee
            // 
            this.BtnDeleteEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnDeleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnDeleteEmployee.Location = new System.Drawing.Point(367, 12);
            this.BtnDeleteEmployee.Name = "BtnDeleteEmployee";
            this.BtnDeleteEmployee.Size = new System.Drawing.Size(150, 108);
            this.BtnDeleteEmployee.TabIndex = 2;
            this.BtnDeleteEmployee.Text = "Delete Employee";
            this.BtnDeleteEmployee.UseVisualStyleBackColor = false;
            this.BtnDeleteEmployee.Click += new System.EventHandler(this.BtnDeleteEmployee_Click);
            // 
            // ManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(529, 132);
            this.Controls.Add(this.BtnDeleteEmployee);
            this.Controls.Add(this.BtnEditEmployee);
            this.Controls.Add(this.BtnAdd);
            this.MaximumSize = new System.Drawing.Size(545, 171);
            this.Name = "ManageEmployees";
            this.Text = "ManageEmployees";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEditEmployee;
        private System.Windows.Forms.Button BtnDeleteEmployee;
    }
}