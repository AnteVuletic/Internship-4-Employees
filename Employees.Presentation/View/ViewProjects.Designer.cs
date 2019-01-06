using System;
using System.Drawing;
using System.Windows.Forms;
using Employees.Infrastructure.Enums;

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
            // Header for list
            //
            ProjectList.View = System.Windows.Forms.View.Tile;
            ProjectList.Columns.Add(new ColumnHeader("Project").Text = "Project");
            ProjectList.Columns.Add(new ColumnHeader("ProjectDate").Text = "Project Date");
            foreach (var position in Enum.GetNames(typeof(Position)))
            {
                ProjectList.Columns.Add(new ColumnHeader(position).Text = position);
            }
            // 
            // ProjectList
            // 
            this.ProjectList.Enabled = true;
            this.ProjectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ProjectList.GridLines = true;
            this.ProjectList.Location = new System.Drawing.Point(12, 12);
            this.ProjectList.Name = "EmployeeListView";
            this.ProjectList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProjectList.Size = new System.Drawing.Size(613, 344);
            this.ProjectList.TabIndex = 0;
            this.ProjectList.UseCompatibleStateImageBehavior = false;
            this.ProjectList.BorderStyle = BorderStyle.Fixed3D;
            this.ProjectList.BackColor = Color.Azure;
            this.ProjectList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            this.ProjectList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.ProjectList.TileSize = new Size(600,200);
            this.ProjectList.MultiSelect = false;           
            this.ProjectList.SelectedIndexChanged += new EventHandler(this.ProjectList_SelectedIndexChanged);
            // 
            // ViewProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            ((ContainerControl)this).AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 368);
            this.MaximumSize = new System.Drawing.Size(637,368);
            this.Controls.Add(this.ProjectList);
            this.Name = "ViewProjects";
            this.Text = "ViewProjects";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ProjectList;
    }
}