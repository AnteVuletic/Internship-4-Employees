namespace Employees.Presentation.ManageProjects
{
    partial class AddProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.RealCheckbox = new System.Windows.Forms.CheckBox();
            this.ProjectStartLabel = new System.Windows.Forms.Label();
            this.ProjectEndLabel = new System.Windows.Forms.Label();
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.EmployeeCheckedList = new System.Windows.Forms.CheckedListBox();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.IsActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label2.Location = new System.Drawing.Point(88, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add project";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(126, 70);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(212, 20);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // RealCheckbox
            // 
            this.RealCheckbox.AutoSize = true;
            this.RealCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.RealCheckbox.Location = new System.Drawing.Point(113, 106);
            this.RealCheckbox.Name = "RealCheckbox";
            this.RealCheckbox.Size = new System.Drawing.Size(118, 24);
            this.RealCheckbox.TabIndex = 3;
            this.RealCheckbox.Text = "Real project";
            this.RealCheckbox.UseVisualStyleBackColor = true;
            this.RealCheckbox.CheckedChanged += new System.EventHandler(this.RealCheckbox_CheckedChanged);
            // 
            // ProjectStartLabel
            // 
            this.ProjectStartLabel.AutoSize = true;
            this.ProjectStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ProjectStartLabel.Location = new System.Drawing.Point(12, 151);
            this.ProjectStartLabel.Name = "ProjectStartLabel";
            this.ProjectStartLabel.Size = new System.Drawing.Size(103, 20);
            this.ProjectStartLabel.TabIndex = 4;
            this.ProjectStartLabel.Text = "Project Start";
            this.ProjectStartLabel.Visible = false;
            // 
            // ProjectEndLabel
            // 
            this.ProjectEndLabel.AutoSize = true;
            this.ProjectEndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ProjectEndLabel.Location = new System.Drawing.Point(12, 186);
            this.ProjectEndLabel.Name = "ProjectEndLabel";
            this.ProjectEndLabel.Size = new System.Drawing.Size(96, 20);
            this.ProjectEndLabel.TabIndex = 5;
            this.ProjectEndLabel.Text = "Project End";
            this.ProjectEndLabel.Visible = false;
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.EmployeeLabel.Location = new System.Drawing.Point(109, 251);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(141, 20);
            this.EmployeeLabel.TabIndex = 6;
            this.EmployeeLabel.Text = "List of employees";
            // 
            // EmployeeCheckedList
            // 
            this.EmployeeCheckedList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EmployeeCheckedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.EmployeeCheckedList.FormattingEnabled = true;
            this.EmployeeCheckedList.HorizontalScrollbar = true;
            this.EmployeeCheckedList.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.EmployeeCheckedList.Location = new System.Drawing.Point(15, 274);
            this.EmployeeCheckedList.Name = "EmployeeCheckedList";
            this.EmployeeCheckedList.Size = new System.Drawing.Size(322, 184);
            this.EmployeeCheckedList.TabIndex = 7;
            this.EmployeeCheckedList.SelectedIndexChanged += new System.EventHandler(this.EmployeeCheckedList_SelectedIndexChanged);
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Location = new System.Drawing.Point(126, 151);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(200, 20);
            this.StartDatePicker.TabIndex = 8;
            this.StartDatePicker.Visible = false;
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.StartDatePicker_ValueChanged);
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(126, 185);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(200, 20);
            this.EndDatePicker.TabIndex = 9;
            this.EndDatePicker.Visible = false;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BtnSave.Location = new System.Drawing.Point(16, 497);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(101, 30);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BtnCancel.Location = new System.Drawing.Point(237, 497);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(101, 30);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // IsActiveCheckBox
            // 
            this.IsActiveCheckBox.AutoSize = true;
            this.IsActiveCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.IsActiveCheckBox.Checked = true;
            this.IsActiveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsActiveCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.IsActiveCheckBox.Location = new System.Drawing.Point(119, 227);
            this.IsActiveCheckBox.Name = "IsActiveCheckBox";
            this.IsActiveCheckBox.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.IsActiveCheckBox.Size = new System.Drawing.Size(122, 21);
            this.IsActiveCheckBox.TabIndex = 13;
            this.IsActiveCheckBox.Text = "Project active";
            this.IsActiveCheckBox.UseVisualStyleBackColor = false;
            this.IsActiveCheckBox.Visible = false;
            this.IsActiveCheckBox.CheckedChanged += new System.EventHandler(this.IsActiveCheckBox_CheckedChanged);
            // 
            // AddProject
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(363, 539);
            this.ControlBox = false;
            this.Controls.Add(this.IsActiveCheckBox);
            this.Controls.Add(this.BtnCancel);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MaximumSize = new System.Drawing.Size(379, 578);
            this.Name = "AddProject";
            this.Text = "AddProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.CheckBox RealCheckbox;
        private System.Windows.Forms.Label ProjectStartLabel;
        private System.Windows.Forms.Label ProjectEndLabel;
        private System.Windows.Forms.Label EmployeeLabel;
        private System.Windows.Forms.CheckedListBox EmployeeCheckedList;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.CheckBox IsActiveCheckBox;
    }
}