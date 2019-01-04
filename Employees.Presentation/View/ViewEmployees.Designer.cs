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
            this.EmployeeListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            //
            // Header for list
            //
            this.EmployeeListView.Scrollable = true;
            this.EmployeeListView.View = System.Windows.Forms.View.Details;
            this.EmployeeListView.Columns.Add(new ColumnHeader("OIB").Text = "OIB");
            this.EmployeeListView.Columns.Add(new ColumnHeader("Name").Text = "Name");
            this.EmployeeListView.Columns.Add(new ColumnHeader("SecondName").Text = "Second name");
            this.EmployeeListView.Columns.Add(new ColumnHeader("Surname").Text = "Surname");
            this.EmployeeListView.Columns.Add(new ColumnHeader("Position").Text = "Position");
            this.EmployeeListView.Columns.Add(new ColumnHeader("Birthday").Text = "Birthday");
            this.EmployeeListView.Columns.Add(new ColumnHeader("Hours").Text = "Weekly hours");
            this.EmployeeListView.Columns.Add(new ColumnHeader("Finished").Text = "Finished projects");
            this.EmployeeListView.Columns.Add(new ColumnHeader("Active").Text = "Active projects");

        // 
        // EmployeeListView
        // 
            this.EmployeeListView.Enabled = true;
            this.EmployeeListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.EmployeeListView.GridLines = true;
            this.EmployeeListView.Location = new System.Drawing.Point(12, 12);
            this.EmployeeListView.Name = "EmployeeListView";
            this.EmployeeListView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EmployeeListView.Size = new System.Drawing.Size(613, 344);
            this.EmployeeListView.TabIndex = 0;
            this.EmployeeListView.UseCompatibleStateImageBehavior = false;
            this.EmployeeListView.BorderStyle = BorderStyle.Fixed3D;
            this.EmployeeListView.BackColor = Color.Azure;
            var employeeListWidth = EmployeeListView.Width;
            this.EmployeeListView.Width = 0;
            this.EmployeeListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.EmployeeListView.Width = employeeListWidth;
            // 
            // ViewEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            ((ContainerControl) this).AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 368);
            this.Controls.Add(this.EmployeeListView);
            this.Name = "ViewEmployees";
            this.Text = "ViewEmployees";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView EmployeeListView;
    }
}