namespace Employees.Presentation
{
    partial class MainForm
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
            this.BtnManageEmployees = new System.Windows.Forms.Button();
            this.BtnManageProjects = new System.Windows.Forms.Button();
            this.BtnViewEmployees = new System.Windows.Forms.Button();
            this.BtnViewProjects = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnManageEmployees
            // 
            this.BtnManageEmployees.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnManageEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BtnManageEmployees.Location = new System.Drawing.Point(12, 12);
            this.BtnManageEmployees.Name = "BtnManageEmployees";
            this.BtnManageEmployees.Size = new System.Drawing.Size(201, 112);
            this.BtnManageEmployees.TabIndex = 0;
            this.BtnManageEmployees.Text = "Manage Employees";
            this.BtnManageEmployees.UseVisualStyleBackColor = false;
            this.BtnManageEmployees.Click += new System.EventHandler(this.BtnManageEmployees_Click);
            // 
            // BtnManageProjects
            // 
            this.BtnManageProjects.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnManageProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BtnManageProjects.Location = new System.Drawing.Point(305, 12);
            this.BtnManageProjects.Name = "BtnManageProjects";
            this.BtnManageProjects.Size = new System.Drawing.Size(201, 112);
            this.BtnManageProjects.TabIndex = 1;
            this.BtnManageProjects.Text = "Manage Projects";
            this.BtnManageProjects.UseVisualStyleBackColor = false;
            this.BtnManageProjects.Click += new System.EventHandler(this.BtnManageProjects_Click);
            // 
            // BtnViewEmployees
            // 
            this.BtnViewEmployees.BackColor = System.Drawing.SystemColors.Info;
            this.BtnViewEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BtnViewEmployees.Location = new System.Drawing.Point(12, 168);
            this.BtnViewEmployees.Name = "BtnViewEmployees";
            this.BtnViewEmployees.Size = new System.Drawing.Size(201, 110);
            this.BtnViewEmployees.TabIndex = 2;
            this.BtnViewEmployees.Text = "View Employees";
            this.BtnViewEmployees.UseVisualStyleBackColor = false;
            this.BtnViewEmployees.Click += new System.EventHandler(this.BtnViewEmployees_Click);
            // 
            // BtnViewProjects
            // 
            this.BtnViewProjects.BackColor = System.Drawing.SystemColors.Info;
            this.BtnViewProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BtnViewProjects.Location = new System.Drawing.Point(305, 168);
            this.BtnViewProjects.Name = "BtnViewProjects";
            this.BtnViewProjects.Size = new System.Drawing.Size(201, 110);
            this.BtnViewProjects.TabIndex = 3;
            this.BtnViewProjects.Text = "View Projects";
            this.BtnViewProjects.UseVisualStyleBackColor = false;
            this.BtnViewProjects.Click += new System.EventHandler(this.BtnViewProjects_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 290);
            this.Controls.Add(this.BtnViewProjects);
            this.Controls.Add(this.BtnViewEmployees);
            this.Controls.Add(this.BtnManageProjects);
            this.Controls.Add(this.BtnManageEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "Project manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnManageEmployees;
        private System.Windows.Forms.Button BtnManageProjects;
        private System.Windows.Forms.Button BtnViewEmployees;
        private System.Windows.Forms.Button BtnViewProjects;
    }
}

