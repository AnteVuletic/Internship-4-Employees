using System;
using System.Drawing;
using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            this.ProjectList = new System.Windows.Forms.ListView();
            this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ProjectList
            // 
            this.ProjectList.BackColor = System.Drawing.Color.Azure;
            this.ProjectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ProjectList.GridLines = true;
            this.ProjectList.Location = new System.Drawing.Point(-4, 0);
            this.ProjectList.MultiSelect = false;
            this.ProjectList.Name = "ProjectList";
            this.ProjectList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProjectList.Size = new System.Drawing.Size(625, 330);
            this.ProjectList.TabIndex = 0;
            this.ProjectList.TileSize = new System.Drawing.Size(600, 200);
            this.ToolTipMain.SetToolTip(this.ProjectList, "Select any project to change data.");
            this.ProjectList.UseCompatibleStateImageBehavior = false;
            this.ProjectList.SelectedIndexChanged += new System.EventHandler(this.ProjectList_SelectedIndexChanged);
            // 
            // ViewProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 329);
            this.Controls.Add(this.ProjectList);
            this.MaximumSize = new System.Drawing.Size(637, 368);
            this.Name = "ViewProjects";
            this.Text = "ViewProjects";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ProjectList;
        private ToolTip ToolTipMain;
    }
}