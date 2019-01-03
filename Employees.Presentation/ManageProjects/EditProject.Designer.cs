namespace Employees.Presentation.ManageProjects
{
    partial class EditProject
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
            this.IsActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EmployeeCheckedList = new System.Windows.Forms.CheckedListBox();
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.ProjectEndLabel = new System.Windows.Forms.Label();
            this.ProjectStartLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectedEmployeeList = new System.Windows.Forms.ListView();
            this.RealCheckbox = new System.Windows.Forms.CheckBox();
            this.SelectedEmployeeControlLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CurrentProjectTextBox = new System.Windows.Forms.TextBox();
            this.BtnFirstProject = new System.Windows.Forms.Button();
            this.BtnLastProject = new System.Windows.Forms.Button();
            this.BtnNextProject = new System.Windows.Forms.Button();
            this.BtnPrevProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IsActiveCheckBox
            // 
            this.IsActiveCheckBox.AutoSize = true;
            this.IsActiveCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.IsActiveCheckBox.Checked = true;
            this.IsActiveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsActiveCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.IsActiveCheckBox.Location = new System.Drawing.Point(128, 227);
            this.IsActiveCheckBox.Name = "IsActiveCheckBox";
            this.IsActiveCheckBox.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.IsActiveCheckBox.Size = new System.Drawing.Size(122, 21);
            this.IsActiveCheckBox.TabIndex = 26;
            this.IsActiveCheckBox.Text = "Project active";
            this.IsActiveCheckBox.UseVisualStyleBackColor = false;
            this.IsActiveCheckBox.CheckedChanged += new System.EventHandler(this.IsActiveCheckBox_CheckedChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BtnSave.Location = new System.Drawing.Point(120, 598);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(101, 30);
            this.BtnSave.TabIndex = 24;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Enabled = false;
            this.EndDatePicker.Location = new System.Drawing.Point(135, 185);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(200, 20);
            this.EndDatePicker.TabIndex = 23;
            this.EndDatePicker.ValueChanged += new System.EventHandler(this.EndDatePicker_ValueChanged);
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Location = new System.Drawing.Point(135, 151);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(200, 20);
            this.StartDatePicker.TabIndex = 22;
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.StartDatePicker_ValueChanged);
            // 
            // EmployeeCheckedList
            // 
            this.EmployeeCheckedList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EmployeeCheckedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.EmployeeCheckedList.FormattingEnabled = true;
            this.EmployeeCheckedList.HorizontalScrollbar = true;
            this.EmployeeCheckedList.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.EmployeeCheckedList.Location = new System.Drawing.Point(24, 274);
            this.EmployeeCheckedList.Name = "EmployeeCheckedList";
            this.EmployeeCheckedList.Size = new System.Drawing.Size(322, 148);
            this.EmployeeCheckedList.TabIndex = 21;
            this.EmployeeCheckedList.SelectedIndexChanged += new System.EventHandler(this.EmployeeCheckedList_SelectedIndexChanged);
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.EmployeeLabel.Location = new System.Drawing.Point(118, 251);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(141, 20);
            this.EmployeeLabel.TabIndex = 20;
            this.EmployeeLabel.Text = "List of employees";
            this.EmployeeLabel.Visible = false;
            // 
            // ProjectEndLabel
            // 
            this.ProjectEndLabel.AutoSize = true;
            this.ProjectEndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ProjectEndLabel.Location = new System.Drawing.Point(21, 186);
            this.ProjectEndLabel.Name = "ProjectEndLabel";
            this.ProjectEndLabel.Size = new System.Drawing.Size(96, 20);
            this.ProjectEndLabel.TabIndex = 19;
            this.ProjectEndLabel.Text = "Project End";
            // 
            // ProjectStartLabel
            // 
            this.ProjectStartLabel.AutoSize = true;
            this.ProjectStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ProjectStartLabel.Location = new System.Drawing.Point(21, 151);
            this.ProjectStartLabel.Name = "ProjectStartLabel";
            this.ProjectStartLabel.Size = new System.Drawing.Size(103, 20);
            this.ProjectStartLabel.TabIndex = 18;
            this.ProjectStartLabel.Text = "Project Start";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(135, 70);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(212, 20);
            this.NameTextBox.TabIndex = 16;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label2.Location = new System.Drawing.Point(97, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "Edit project";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(21, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Project name";
            // 
            // SelectedEmployeeList
            // 
            this.SelectedEmployeeList.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.SelectedEmployeeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SelectedEmployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.SelectedEmployeeList.FullRowSelect = true;
            this.SelectedEmployeeList.GridLines = true;
            this.SelectedEmployeeList.Location = new System.Drawing.Point(24, 446);
            this.SelectedEmployeeList.MultiSelect = false;
            this.SelectedEmployeeList.Name = "SelectedEmployeeList";
            this.SelectedEmployeeList.Size = new System.Drawing.Size(321, 114);
            this.SelectedEmployeeList.TabIndex = 27;
            this.SelectedEmployeeList.UseCompatibleStateImageBehavior = false;
            this.SelectedEmployeeList.View = System.Windows.Forms.View.List;
            this.SelectedEmployeeList.SelectedIndexChanged += new System.EventHandler(this.SelectedEmployeeList_SelectedIndexChanged);
            // 
            // RealCheckbox
            // 
            this.RealCheckbox.AutoSize = true;
            this.RealCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.RealCheckbox.Location = new System.Drawing.Point(122, 106);
            this.RealCheckbox.Name = "RealCheckbox";
            this.RealCheckbox.Size = new System.Drawing.Size(118, 24);
            this.RealCheckbox.TabIndex = 17;
            this.RealCheckbox.Text = "Real project";
            this.RealCheckbox.UseVisualStyleBackColor = true;
            // 
            // SelectedEmployeeControlLabel
            // 
            this.SelectedEmployeeControlLabel.AutoSize = true;
            this.SelectedEmployeeControlLabel.Location = new System.Drawing.Point(50, 430);
            this.SelectedEmployeeControlLabel.Name = "SelectedEmployeeControlLabel";
            this.SelectedEmployeeControlLabel.Size = new System.Drawing.Size(285, 13);
            this.SelectedEmployeeControlLabel.TabIndex = 28;
            this.SelectedEmployeeControlLabel.Text = "Press on the employee if you wish to edit the time per week";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "All changes to project are irreversible";
            // 
            // CurrentProjectTextBox
            // 
            this.CurrentProjectTextBox.Enabled = false;
            this.CurrentProjectTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CurrentProjectTextBox.Location = new System.Drawing.Point(154, 566);
            this.CurrentProjectTextBox.Name = "CurrentProjectTextBox";
            this.CurrentProjectTextBox.ReadOnly = true;
            this.CurrentProjectTextBox.Size = new System.Drawing.Size(34, 23);
            this.CurrentProjectTextBox.TabIndex = 47;
            this.CurrentProjectTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnFirstProject
            // 
            this.BtnFirstProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.BtnFirstProject.Location = new System.Drawing.Point(86, 564);
            this.BtnFirstProject.Name = "BtnFirstProject";
            this.BtnFirstProject.Size = new System.Drawing.Size(28, 28);
            this.BtnFirstProject.TabIndex = 46;
            this.BtnFirstProject.Text = "<<";
            this.BtnFirstProject.UseVisualStyleBackColor = true;
            this.BtnFirstProject.Click += new System.EventHandler(this.BtnFirstProject_Click);
            // 
            // BtnLastProject
            // 
            this.BtnLastProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.BtnLastProject.Location = new System.Drawing.Point(228, 564);
            this.BtnLastProject.Name = "BtnLastProject";
            this.BtnLastProject.Size = new System.Drawing.Size(28, 28);
            this.BtnLastProject.TabIndex = 45;
            this.BtnLastProject.Text = ">>";
            this.BtnLastProject.UseVisualStyleBackColor = true;
            this.BtnLastProject.Click += new System.EventHandler(this.BtnLastProject_Click);
            // 
            // BtnNextProject
            // 
            this.BtnNextProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.BtnNextProject.Location = new System.Drawing.Point(194, 564);
            this.BtnNextProject.Name = "BtnNextProject";
            this.BtnNextProject.Size = new System.Drawing.Size(28, 28);
            this.BtnNextProject.TabIndex = 44;
            this.BtnNextProject.Text = ">";
            this.BtnNextProject.UseVisualStyleBackColor = true;
            this.BtnNextProject.Click += new System.EventHandler(this.BtnNextProject_Click);
            // 
            // BtnPrevProject
            // 
            this.BtnPrevProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.BtnPrevProject.Location = new System.Drawing.Point(120, 564);
            this.BtnPrevProject.Name = "BtnPrevProject";
            this.BtnPrevProject.Size = new System.Drawing.Size(28, 28);
            this.BtnPrevProject.TabIndex = 43;
            this.BtnPrevProject.Text = "<";
            this.BtnPrevProject.UseVisualStyleBackColor = true;
            this.BtnPrevProject.Click += new System.EventHandler(this.BtnPrevProject_Click);
            // 
            // EditProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(362, 635);
            this.Controls.Add(this.CurrentProjectTextBox);
            this.Controls.Add(this.BtnFirstProject);
            this.Controls.Add(this.BtnLastProject);
            this.Controls.Add(this.BtnNextProject);
            this.Controls.Add(this.BtnPrevProject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SelectedEmployeeControlLabel);
            this.Controls.Add(this.SelectedEmployeeList);
            this.Controls.Add(this.IsActiveCheckBox);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.EmployeeCheckedList);
            this.Controls.Add(this.EmployeeLabel);
            this.Controls.Add(this.ProjectEndLabel);
            this.Controls.Add(this.ProjectStartLabel);
            this.Controls.Add(this.RealCheckbox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditProject";
            this.Text = "EditProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox IsActiveCheckBox;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.CheckedListBox EmployeeCheckedList;
        private System.Windows.Forms.Label EmployeeLabel;
        private System.Windows.Forms.Label ProjectEndLabel;
        private System.Windows.Forms.Label ProjectStartLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView SelectedEmployeeList;
        private System.Windows.Forms.CheckBox RealCheckbox;
        private System.Windows.Forms.Label SelectedEmployeeControlLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CurrentProjectTextBox;
        private System.Windows.Forms.Button BtnFirstProject;
        private System.Windows.Forms.Button BtnLastProject;
        private System.Windows.Forms.Button BtnNextProject;
        private System.Windows.Forms.Button BtnPrevProject;
    }
}