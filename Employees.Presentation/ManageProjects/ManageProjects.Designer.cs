namespace Employees.Presentation.ManageProjects
{
    partial class ManageProjects
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
            this.BtnDeleteProject = new System.Windows.Forms.Button();
            this.BtnEditProject = new System.Windows.Forms.Button();
            this.BtnAddProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDeleteProject
            // 
            this.BtnDeleteProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnDeleteProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BtnDeleteProject.Location = new System.Drawing.Point(367, 12);
            this.BtnDeleteProject.Name = "BtnDeleteProject";
            this.BtnDeleteProject.Size = new System.Drawing.Size(150, 108);
            this.BtnDeleteProject.TabIndex = 5;
            this.BtnDeleteProject.Text = "Delete project";
            this.BtnDeleteProject.UseVisualStyleBackColor = false;
            this.BtnDeleteProject.Click += new System.EventHandler(this.BtnDeleteProject_Click);
            // 
            // BtnEditProject
            // 
            this.BtnEditProject.BackColor = System.Drawing.Color.Turquoise;
            this.BtnEditProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BtnEditProject.Location = new System.Drawing.Point(192, 12);
            this.BtnEditProject.Name = "BtnEditProject";
            this.BtnEditProject.Size = new System.Drawing.Size(150, 108);
            this.BtnEditProject.TabIndex = 4;
            this.BtnEditProject.Text = "Edit project";
            this.BtnEditProject.UseVisualStyleBackColor = false;
            this.BtnEditProject.Click += new System.EventHandler(this.BtnEditProject_Click);
            // 
            // BtnAddProject
            // 
            this.BtnAddProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAddProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BtnAddProject.Location = new System.Drawing.Point(12, 12);
            this.BtnAddProject.Name = "BtnAddProject";
            this.BtnAddProject.Size = new System.Drawing.Size(150, 108);
            this.BtnAddProject.TabIndex = 3;
            this.BtnAddProject.Text = "Add Project";
            this.BtnAddProject.UseVisualStyleBackColor = false;
            this.BtnAddProject.Click += new System.EventHandler(this.BtnAddProject_Click);
            // 
            // ManageProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(531, 131);
            this.Controls.Add(this.BtnDeleteProject);
            this.Controls.Add(this.BtnEditProject);
            this.Controls.Add(this.BtnAddProject);
            this.Name = "ManageProjects";
            this.Text = "ManageProjects";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnDeleteProject;
        private System.Windows.Forms.Button BtnEditProject;
        private System.Windows.Forms.Button BtnAddProject;
    }
}