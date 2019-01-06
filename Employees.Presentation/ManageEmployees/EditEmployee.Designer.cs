using System.Windows.Forms;

namespace Employees.Presentation.ManageEmployees
{
    partial class EditEmployee
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
            this.SecondNameLabel = new System.Windows.Forms.Label();
            this.SecondNameTextBox = new System.Windows.Forms.TextBox();
            this.OibTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CheckBoxSecondName = new System.Windows.Forms.CheckBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.ListProjects = new System.Windows.Forms.CheckedListBox();
            this.ComboPosition = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DateTimeBirthday = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPrev = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnLastEmployee = new System.Windows.Forms.Button();
            this.BtnFirstEmployee = new System.Windows.Forms.Button();
            this.CurrentPageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SecondNameLabel
            // 
            this.SecondNameLabel.AutoSize = true;
            this.SecondNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.SecondNameLabel.Location = new System.Drawing.Point(14, 127);
            this.SecondNameLabel.Name = "SecondNameLabel";
            this.SecondNameLabel.Size = new System.Drawing.Size(85, 20);
            this.SecondNameLabel.TabIndex = 36;
            this.SecondNameLabel.Text = "2nd Name";
            // 
            // SecondNameTextBox
            // 
            this.SecondNameTextBox.BackColor = System.Drawing.Color.LightGreen;
            this.SecondNameTextBox.Location = new System.Drawing.Point(104, 129);
            this.SecondNameTextBox.Name = "SecondNameTextBox";
            this.SecondNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.SecondNameTextBox.TabIndex = 35;
            this.SecondNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecondNameTextBox_KeyPress);
            // 
            // OibTextBox
            // 
            this.OibTextBox.BackColor = System.Drawing.Color.LightGreen;
            this.OibTextBox.Location = new System.Drawing.Point(63, 206);
            this.OibTextBox.MaxLength = 11;
            this.OibTextBox.Name = "OibTextBox";
            this.OibTextBox.Size = new System.Drawing.Size(200, 20);
            this.OibTextBox.TabIndex = 34;
            this.OibTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OibTextBox_KeyPress);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.BackColor = System.Drawing.Color.LightGreen;
            this.SurnameTextBox.Location = new System.Drawing.Point(104, 155);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.SurnameTextBox.TabIndex = 33;
            this.SurnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameTextBox_KeyPress);
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.LightGreen;
            this.NameTextBox.Location = new System.Drawing.Point(104, 76);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(200, 20);
            this.NameTextBox.TabIndex = 32;
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            // 
            // CheckBoxSecondName
            // 
            this.CheckBoxSecondName.AutoSize = true;
            this.CheckBoxSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CheckBoxSecondName.Location = new System.Drawing.Point(95, 102);
            this.CheckBoxSecondName.Name = "CheckBoxSecondName";
            this.CheckBoxSecondName.Size = new System.Drawing.Size(114, 21);
            this.CheckBoxSecondName.TabIndex = 31;
            this.CheckBoxSecondName.Text = "Second name";
            this.CheckBoxSecondName.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(208, 471);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(111, 29);
            this.BtnCancel.TabIndex = 30;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BtnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSave.Location = new System.Drawing.Point(12, 471);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(112, 29);
            this.BtnSave.TabIndex = 29;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ListProjects
            // 
            this.ListProjects.BackColor = System.Drawing.Color.LightGreen;
            this.ListProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ListProjects.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ListProjects.FormattingEnabled = true;
            this.ListProjects.Location = new System.Drawing.Point(14, 320);
            this.ListProjects.Name = "ListProjects";
            this.ListProjects.Size = new System.Drawing.Size(304, 109);
            this.ListProjects.TabIndex = 28;
            // 
            // ComboPosition
            // 
            this.ComboPosition.BackColor = System.Drawing.Color.LightGreen;
            this.ComboPosition.FormattingEnabled = true;
            this.ComboPosition.Location = new System.Drawing.Point(104, 286);
            this.ComboPosition.Name = "ComboPosition";
            this.ComboPosition.Size = new System.Drawing.Size(200, 21);
            this.ComboPosition.TabIndex = 27;
            this.ComboPosition.SelectedIndexChanged += new System.EventHandler(this.ComboPosition_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(14, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Position";
            // 
            // DateTimeBirthday
            // 
            this.DateTimeBirthday.Location = new System.Drawing.Point(104, 232);
            this.DateTimeBirthday.MaxDate = new System.DateTime(2019, 1, 5, 0, 0, 0, 0);
            this.DateTimeBirthday.Name = "DateTimeBirthday";
            this.DateTimeBirthday.Size = new System.Drawing.Size(200, 20);
            this.DateTimeBirthday.TabIndex = 25;
            this.DateTimeBirthday.Value = new System.DateTime(2019, 1, 5, 0, 0, 0, 0);
            this.DateTimeBirthday.ValueChanged += new System.EventHandler(this.DateTimeBirthday_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(14, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Birthday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(60, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "OIB [Press enter to confirm entry]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(14, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(14, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 39);
            this.label1.TabIndex = 20;
            this.label1.Text = "Edit Employee";
            // 
            // BtnPrev
            // 
            this.BtnPrev.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.BtnPrev.Location = new System.Drawing.Point(112, 439);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new System.Drawing.Size(28, 28);
            this.BtnPrev.TabIndex = 38;
            this.BtnPrev.Text = "<";
            this.BtnPrev.UseVisualStyleBackColor = false;
            this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.BtnNext.Location = new System.Drawing.Point(186, 439);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(28, 28);
            this.BtnNext.TabIndex = 39;
            this.BtnNext.Text = ">";
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnLastEmployee
            // 
            this.BtnLastEmployee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLastEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.BtnLastEmployee.Location = new System.Drawing.Point(220, 439);
            this.BtnLastEmployee.Name = "BtnLastEmployee";
            this.BtnLastEmployee.Size = new System.Drawing.Size(28, 28);
            this.BtnLastEmployee.TabIndex = 40;
            this.BtnLastEmployee.Text = ">>";
            this.BtnLastEmployee.UseVisualStyleBackColor = false;
            this.BtnLastEmployee.Click += new System.EventHandler(this.BtnLastEmployee_Click);
            // 
            // BtnFirstEmployee
            // 
            this.BtnFirstEmployee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnFirstEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.BtnFirstEmployee.Location = new System.Drawing.Point(78, 439);
            this.BtnFirstEmployee.Name = "BtnFirstEmployee";
            this.BtnFirstEmployee.Size = new System.Drawing.Size(28, 28);
            this.BtnFirstEmployee.TabIndex = 41;
            this.BtnFirstEmployee.Text = "<<";
            this.BtnFirstEmployee.UseVisualStyleBackColor = false;
            this.BtnFirstEmployee.Click += new System.EventHandler(this.BtnFirstEmployee_Click);
            // 
            // CurrentPageTextBox
            // 
            this.CurrentPageTextBox.BackColor = System.Drawing.Color.LightGreen;
            this.CurrentPageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CurrentPageTextBox.Location = new System.Drawing.Point(146, 441);
            this.CurrentPageTextBox.Name = "CurrentPageTextBox";
            this.CurrentPageTextBox.ReadOnly = true;
            this.CurrentPageTextBox.Size = new System.Drawing.Size(34, 23);
            this.CurrentPageTextBox.TabIndex = 42;
            this.CurrentPageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(331, 512);
            this.ControlBox = false;
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
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.ListProjects);
            this.Controls.Add(this.ComboPosition);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DateTimeBirthday);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(347, 551);
            this.Name = "EditEmployee";
            this.Text = "EditEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SecondNameLabel;
        private System.Windows.Forms.TextBox SecondNameTextBox;
        private System.Windows.Forms.TextBox OibTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.CheckBox CheckBoxSecondName;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.CheckedListBox ListProjects;
        private System.Windows.Forms.ComboBox ComboPosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DateTimeBirthday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPrev;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnLastEmployee;
        private System.Windows.Forms.Button BtnFirstEmployee;
        private System.Windows.Forms.TextBox CurrentPageTextBox;
    }
}