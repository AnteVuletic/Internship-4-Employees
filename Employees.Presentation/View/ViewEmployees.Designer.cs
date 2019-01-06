using System;
using System.Drawing;
using System.Windows.Forms;

namespace Employees.Presentation.View
{
    partial class ViewEmployees
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
            this.EmployeeListView = new System.Windows.Forms.ListView();
            this.TooltipMain = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // EmployeeListView
            // 
            this.EmployeeListView.BackColor = System.Drawing.Color.Azure;
            this.EmployeeListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.EmployeeListView.FullRowSelect = true;
            this.EmployeeListView.GridLines = true;
            this.EmployeeListView.Location = new System.Drawing.Point(-2, -1);
            this.EmployeeListView.MultiSelect = false;
            this.EmployeeListView.Name = "EmployeeListView";
            this.EmployeeListView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EmployeeListView.Size = new System.Drawing.Size(623, 332);
            this.EmployeeListView.TabIndex = 0;
            this.TooltipMain.SetToolTip(this.EmployeeListView, "Select any employee to manipulate data.");
            this.EmployeeListView.UseCompatibleStateImageBehavior = false;
            this.EmployeeListView.SelectedIndexChanged += new System.EventHandler(this.EmployeeListView_SelectedIndexChanged);
            // 
            // ViewEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 329);
            this.Controls.Add(this.EmployeeListView);
            this.MaximumSize = new System.Drawing.Size(637, 368);
            this.Name = "ViewEmployees";
            this.Text = "ViewEmployees";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView EmployeeListView;
        private ToolTip TooltipMain;
    }
}