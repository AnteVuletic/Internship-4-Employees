namespace Employees.Presentation.ManageEmployees
{
    partial class DeleteEmployee
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
            this.CurrentPageTextBox = new System.Windows.Forms.TextBox();
            this.BtnFirstEmployee = new System.Windows.Forms.Button();
            this.BtnLastEmployee = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnPrev = new System.Windows.Forms.Button();
            this.SecondNameLabel = new System.Windows.Forms.Label();
            this.SecondNameTextBox = new System.Windows.Forms.TextBox();
            this.OibTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CheckBoxSecondName = new System.Windows.Forms.CheckBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.ListProjects = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.BirthdayTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CurrentPageTextBox
            // 
            this.CurrentPageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CurrentPageTextBox.Location = new System.Drawing.Point(155, 441);
            this.CurrentPageTextBox.Name = "CurrentPageTextBox";
            this.CurrentPageTextBox.ReadOnly = true;
            this.CurrentPageTextBox.Size = new System.Drawing.Size(34, 23);
            this.CurrentPageTextBox.TabIndex = 64;
            this.CurrentPageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnFirstEmployee
            // 
            this.BtnFirstEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.BtnFirstEmployee.Location = new System.Drawing.Point(87, 439);
            this.BtnFirstEmployee.Name = "BtnFirstEmployee";
            this.BtnFirstEmployee.Size = new System.Drawing.Size(28, 28);
            this.BtnFirstEmployee.TabIndex = 63;
            this.BtnFirstEmployee.Text = "<<";
            this.BtnFirstEmployee.UseVisualStyleBackColor = true;
            this.BtnFirstEmployee.Click += new System.EventHandler(this.BtnFirstEmployee_Click);
            // 
            // BtnLastEmployee
            // 
            this.BtnLastEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.BtnLastEmployee.Location = new System.Drawing.Point(229, 439);
            this.BtnLastEmployee.Name = "BtnLastEmployee";
            this.BtnLastEmployee.Size = new System.Drawing.Size(28, 28);
            this.BtnLastEmployee.TabIndex = 62;
            this.BtnLastEmployee.Text = ">>";
            this.BtnLastEmployee.UseVisualStyleBackColor = true;
            this.BtnLastEmployee.Click += new System.EventHandler(this.BtnLastEmployee_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.BtnNext.Location = new System.Drawing.Point(195, 439);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(28, 28);
            this.BtnNext.TabIndex = 61;
            this.BtnNext.Text = ">";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnPrev
            // 
            this.BtnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.BtnPrev.Location = new System.Drawing.Point(121, 439);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new System.Drawing.Size(28, 28);
            this.BtnPrev.TabIndex = 60;
            this.BtnPrev.Text = "<";
            this.BtnPrev.UseVisualStyleBackColor = true;
            this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // SecondNameLabel
            // 
            this.SecondNameLabel.AutoSize = true;
            this.SecondNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.SecondNameLabel.Location = new System.Drawing.Point(23, 127);
            this.SecondNameLabel.Name = "SecondNameLabel";
            this.SecondNameLabel.Size = new System.Drawing.Size(85, 20);
            this.SecondNameLabel.TabIndex = 59;
            this.SecondNameLabel.Text = "2nd Name";
            // 
            // SecondNameTextBox
            // 
            this.SecondNameTextBox.Location = new System.Drawing.Point(113, 129);
            this.SecondNameTextBox.Name = "SecondNameTextBox";
            this.SecondNameTextBox.ReadOnly = true;
            this.SecondNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.SecondNameTextBox.TabIndex = 58;
            // 
            // OibTextBox
            // 
            this.OibTextBox.Location = new System.Drawing.Point(113, 193);
            this.OibTextBox.Name = "OibTextBox";
            this.OibTextBox.ReadOnly = true;
            this.OibTextBox.Size = new System.Drawing.Size(200, 20);
            this.OibTextBox.TabIndex = 57;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(113, 155);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.ReadOnly = true;
            this.SurnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.SurnameTextBox.TabIndex = 56;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(113, 76);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(200, 20);
            this.NameTextBox.TabIndex = 55;
            // 
            // CheckBoxSecondName
            // 
            this.CheckBoxSecondName.AutoSize = true;
            this.CheckBoxSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CheckBoxSecondName.Location = new System.Drawing.Point(104, 102);
            this.CheckBoxSecondName.Name = "CheckBoxSecondName";
            this.CheckBoxSecondName.Size = new System.Drawing.Size(114, 21);
            this.CheckBoxSecondName.TabIndex = 54;
            this.CheckBoxSecondName.Text = "Second name";
            this.CheckBoxSecondName.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnCancel.Location = new System.Drawing.Point(217, 471);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(111, 29);
            this.BtnCancel.TabIndex = 53;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnDelete.Location = new System.Drawing.Point(21, 471);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(112, 29);
            this.BtnDelete.TabIndex = 52;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // ListProjects
            // 
            this.ListProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ListProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ListProjects.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ListProjects.FormattingEnabled = true;
            this.ListProjects.Location = new System.Drawing.Point(23, 320);
            this.ListProjects.Name = "ListProjects";
            this.ListProjects.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ListProjects.Size = new System.Drawing.Size(304, 109);
            this.ListProjects.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(23, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(23, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Birthday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(23, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "OIB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(23, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 39);
            this.label1.TabIndex = 43;
            this.label1.Text = "Delete Employee";
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Location = new System.Drawing.Point(113, 287);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.ReadOnly = true;
            this.PositionTextBox.Size = new System.Drawing.Size(200, 20);
            this.PositionTextBox.TabIndex = 65;
            // 
            // BirthdayTextBox
            // 
            this.BirthdayTextBox.Location = new System.Drawing.Point(113, 234);
            this.BirthdayTextBox.Name = "BirthdayTextBox";
            this.BirthdayTextBox.ReadOnly = true;
            this.BirthdayTextBox.Size = new System.Drawing.Size(200, 20);
            this.BirthdayTextBox.TabIndex = 66;
            // 
            // DeleteEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(358, 514);
            this.Controls.Add(this.BirthdayTextBox);
            this.Controls.Add(this.PositionTextBox);
            this.Controls.Add(this.CurrentPageTextBox);
            this.Controls.Add(this.BtnFirstEmployee);
            this.Controls.Add(this.BtnLastEmployee);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrev);
            this.Controls.Add(this.SecondNameLabel);
            this.Controls.Add(this.SecondNameTextBox);
            this.Controls.Add(this.OibTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CheckBoxSecondName);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.ListProjects);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeleteEmployee";
            this.Text = "DeleteEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CurrentPageTextBox;
        private System.Windows.Forms.Button BtnFirstEmployee;
        private System.Windows.Forms.Button BtnLastEmployee;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnPrev;
        private System.Windows.Forms.Label SecondNameLabel;
        private System.Windows.Forms.TextBox SecondNameTextBox;
        private System.Windows.Forms.TextBox OibTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.CheckBox CheckBoxSecondName;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.CheckedListBox ListProjects;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.TextBox BirthdayTextBox;
    }
}