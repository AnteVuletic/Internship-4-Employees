namespace Employees.Presentation.ManageProjects
{
    partial class RemoveProject
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
            this.CurrentProjectTextBox = new System.Windows.Forms.TextBox();
            this.BtnFirstProject = new System.Windows.Forms.Button();
            this.BtnLastProject = new System.Windows.Forms.Button();
            this.BtnNextProject = new System.Windows.Forms.Button();
            this.BtnPrevProject = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.IsActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.ProjectEndLabel = new System.Windows.Forms.Label();
            this.ProjectStartLabel = new System.Windows.Forms.Label();
            this.RealCheckbox = new System.Windows.Forms.CheckBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.EmployeeOnProjectList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // CurrentProjectTextBox
            // 
            this.CurrentProjectTextBox.Enabled = false;
            this.CurrentProjectTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CurrentProjectTextBox.Location = new System.Drawing.Point(150, 433);
            this.CurrentProjectTextBox.Name = "CurrentProjectTextBox";
            this.CurrentProjectTextBox.ReadOnly = true;
            this.CurrentProjectTextBox.Size = new System.Drawing.Size(34, 23);
            this.CurrentProjectTextBox.TabIndex = 52;
            this.CurrentProjectTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnFirstProject
            // 
            this.BtnFirstProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.BtnFirstProject.Location = new System.Drawing.Point(82, 431);
            this.BtnFirstProject.Name = "BtnFirstProject";
            this.BtnFirstProject.Size = new System.Drawing.Size(28, 28);
            this.BtnFirstProject.TabIndex = 51;
            this.BtnFirstProject.Text = "<<";
            this.BtnFirstProject.UseVisualStyleBackColor = true;
            this.BtnFirstProject.Click += new System.EventHandler(this.BtnFirstProject_Click);
            // 
            // BtnLastProject
            // 
            this.BtnLastProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.BtnLastProject.Location = new System.Drawing.Point(224, 431);
            this.BtnLastProject.Name = "BtnLastProject";
            this.BtnLastProject.Size = new System.Drawing.Size(28, 28);
            this.BtnLastProject.TabIndex = 50;
            this.BtnLastProject.Text = ">>";
            this.BtnLastProject.UseVisualStyleBackColor = true;
            this.BtnLastProject.Click += new System.EventHandler(this.BtnLastProject_Click);
            // 
            // BtnNextProject
            // 
            this.BtnNextProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.BtnNextProject.Location = new System.Drawing.Point(190, 431);
            this.BtnNextProject.Name = "BtnNextProject";
            this.BtnNextProject.Size = new System.Drawing.Size(28, 28);
            this.BtnNextProject.TabIndex = 49;
            this.BtnNextProject.Text = ">";
            this.BtnNextProject.UseVisualStyleBackColor = true;
            this.BtnNextProject.Click += new System.EventHandler(this.BtnNextProject_Click);
            // 
            // BtnPrevProject
            // 
            this.BtnPrevProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.BtnPrevProject.Location = new System.Drawing.Point(116, 431);
            this.BtnPrevProject.Name = "BtnPrevProject";
            this.BtnPrevProject.Size = new System.Drawing.Size(28, 28);
            this.BtnPrevProject.TabIndex = 48;
            this.BtnPrevProject.Text = "<";
            this.BtnPrevProject.UseVisualStyleBackColor = true;
            this.BtnPrevProject.Click += new System.EventHandler(this.BtnPrevProject_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "All changes to project are irreversible";
            // 
            // IsActiveCheckBox
            // 
            this.IsActiveCheckBox.AutoSize = true;
            this.IsActiveCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.IsActiveCheckBox.Checked = true;
            this.IsActiveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsActiveCheckBox.Enabled = false;
            this.IsActiveCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.IsActiveCheckBox.Location = new System.Drawing.Point(116, 232);
            this.IsActiveCheckBox.Name = "IsActiveCheckBox";
            this.IsActiveCheckBox.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.IsActiveCheckBox.Size = new System.Drawing.Size(122, 21);
            this.IsActiveCheckBox.TabIndex = 63;
            this.IsActiveCheckBox.Text = "Project active";
            this.IsActiveCheckBox.UseVisualStyleBackColor = false;
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Enabled = false;
            this.EndDatePicker.Location = new System.Drawing.Point(123, 190);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(200, 20);
            this.EndDatePicker.TabIndex = 62;
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Enabled = false;
            this.StartDatePicker.Location = new System.Drawing.Point(123, 156);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(200, 20);
            this.StartDatePicker.TabIndex = 61;
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.EmployeeLabel.Location = new System.Drawing.Point(106, 256);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(141, 20);
            this.EmployeeLabel.TabIndex = 59;
            this.EmployeeLabel.Text = "List of employees";
            this.EmployeeLabel.Visible = false;
            // 
            // ProjectEndLabel
            // 
            this.ProjectEndLabel.AutoSize = true;
            this.ProjectEndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ProjectEndLabel.Location = new System.Drawing.Point(9, 191);
            this.ProjectEndLabel.Name = "ProjectEndLabel";
            this.ProjectEndLabel.Size = new System.Drawing.Size(96, 20);
            this.ProjectEndLabel.TabIndex = 58;
            this.ProjectEndLabel.Text = "Project End";
            // 
            // ProjectStartLabel
            // 
            this.ProjectStartLabel.AutoSize = true;
            this.ProjectStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ProjectStartLabel.Location = new System.Drawing.Point(9, 156);
            this.ProjectStartLabel.Name = "ProjectStartLabel";
            this.ProjectStartLabel.Size = new System.Drawing.Size(103, 20);
            this.ProjectStartLabel.TabIndex = 57;
            this.ProjectStartLabel.Text = "Project Start";
            // 
            // RealCheckbox
            // 
            this.RealCheckbox.AutoSize = true;
            this.RealCheckbox.Enabled = false;
            this.RealCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.RealCheckbox.Location = new System.Drawing.Point(110, 111);
            this.RealCheckbox.Name = "RealCheckbox";
            this.RealCheckbox.Size = new System.Drawing.Size(118, 24);
            this.RealCheckbox.TabIndex = 56;
            this.RealCheckbox.Text = "Real project";
            this.RealCheckbox.UseVisualStyleBackColor = true;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Enabled = false;
            this.NameTextBox.Location = new System.Drawing.Point(123, 75);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(212, 20);
            this.NameTextBox.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label2.Location = new System.Drawing.Point(43, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 39);
            this.label2.TabIndex = 54;
            this.label2.Text = "Remove project";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(9, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Project name";
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BtnDelete.Location = new System.Drawing.Point(29, 483);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(83, 32);
            this.BtnDelete.TabIndex = 65;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BtnCancel.Location = new System.Drawing.Point(215, 483);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(83, 32);
            this.BtnCancel.TabIndex = 66;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // EmployeeOnProjectList
            // 
            this.EmployeeOnProjectList.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.EmployeeOnProjectList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EmployeeOnProjectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.EmployeeOnProjectList.Location = new System.Drawing.Point(12, 279);
            this.EmployeeOnProjectList.Name = "EmployeeOnProjectList";
            this.EmployeeOnProjectList.Size = new System.Drawing.Size(311, 146);
            this.EmployeeOnProjectList.TabIndex = 67;
            this.EmployeeOnProjectList.UseCompatibleStateImageBehavior = false;
            this.EmployeeOnProjectList.View = System.Windows.Forms.View.List;
            // 
            // RemoveProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(339, 527);
            this.Controls.Add(this.EmployeeOnProjectList);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IsActiveCheckBox);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.EmployeeLabel);
            this.Controls.Add(this.ProjectEndLabel);
            this.Controls.Add(this.ProjectStartLabel);
            this.Controls.Add(this.RealCheckbox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentProjectTextBox);
            this.Controls.Add(this.BtnFirstProject);
            this.Controls.Add(this.BtnLastProject);
            this.Controls.Add(this.BtnNextProject);
            this.Controls.Add(this.BtnPrevProject);
            this.Name = "RemoveProject";
            this.Text = "RemoveProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CurrentProjectTextBox;
        private System.Windows.Forms.Button BtnFirstProject;
        private System.Windows.Forms.Button BtnLastProject;
        private System.Windows.Forms.Button BtnNextProject;
        private System.Windows.Forms.Button BtnPrevProject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox IsActiveCheckBox;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.Label EmployeeLabel;
        private System.Windows.Forms.Label ProjectEndLabel;
        private System.Windows.Forms.Label ProjectStartLabel;
        private System.Windows.Forms.CheckBox RealCheckbox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ListView EmployeeOnProjectList;
    }
}