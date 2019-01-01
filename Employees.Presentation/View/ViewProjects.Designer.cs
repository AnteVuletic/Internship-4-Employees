namespace Employees.Presentation.View
{
    partial class ViewProjects
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
            this.ProjectList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ProjectList
            // 
            this.ProjectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ProjectList.Location = new System.Drawing.Point(12, 12);
            this.ProjectList.MultiSelect = false;
            this.ProjectList.Name = "ProjectList";
            this.ProjectList.Size = new System.Drawing.Size(455, 417);
            this.ProjectList.TabIndex = 0;
            this.ProjectList.TileSize = new System.Drawing.Size(268, 268);
            this.ProjectList.UseCompatibleStateImageBehavior = false;
            this.ProjectList.View = System.Windows.Forms.View.Tile;
            // 
            // ViewProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 441);
            this.Controls.Add(this.ProjectList);
            this.Name = "ViewProjects";
            this.Text = "ViewProjects";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ProjectList;
    }
}