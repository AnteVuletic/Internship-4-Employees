using System.Windows.Forms;

namespace Employees.Presentation.ManageEmployees
{
    partial class AddEmployee
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DateTimeBirthday = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboPosition = new System.Windows.Forms.ComboBox();
            this.ListProjects = new System.Windows.Forms.CheckedListBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.CheckBoxSecondName = new System.Windows.Forms.CheckBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.SecondNameTextBox = new System.Windows.Forms.TextBox();
            this.SecondNameLabel = new System.Windows.Forms.Label();
            this.OibTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(58, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "OIB [Press enter to confirm entry]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(12, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Birthday";
            // 
            // DateTimeBirthday
            // 
            this.DateTimeBirthday.Location = new System.Drawing.Point(102, 232);
            this.DateTimeBirthday.MaxDate = new System.DateTime(2126, 12, 2, 0, 0, 0, 0);
            this.DateTimeBirthday.Name = "DateTimeBirthday";
            this.DateTimeBirthday.Size = new System.Drawing.Size(200, 20);
            this.DateTimeBirthday.TabIndex = 8;
            this.DateTimeBirthday.Value = new System.DateTime(2000, 1, 5, 16, 37, 0, 0);
            this.DateTimeBirthday.ValueChanged += new System.EventHandler(this.DateTimeBirthday_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(12, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Position";
            // 
            // ComboPosition
            // 
            this.ComboPosition.BackColor = System.Drawing.Color.IndianRed;
            this.ComboPosition.FormattingEnabled = true;
            this.ComboPosition.Location = new System.Drawing.Point(102, 286);
            this.ComboPosition.Name = "ComboPosition";
            this.ComboPosition.Size = new System.Drawing.Size(200, 21);
            this.ComboPosition.TabIndex = 10;
            this.ComboPosition.SelectedIndexChanged += new System.EventHandler(this.ComboPosition_SelectedIndexChanged);
            // 
            // ListProjects
            // 
            this.ListProjects.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ListProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ListProjects.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ListProjects.FormattingEnabled = true;
            this.ListProjects.HorizontalScrollbar = true;
            this.ListProjects.Location = new System.Drawing.Point(12, 320);
            this.ListProjects.Name = "ListProjects";
            this.ListProjects.Size = new System.Drawing.Size(304, 109);
            this.ListProjects.TabIndex = 11;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BtnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSave.Location = new System.Drawing.Point(12, 446);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(112, 29);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(205, 446);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(111, 29);
            this.BtnCancel.TabIndex = 13;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // CheckBoxSecondName
            // 
            this.CheckBoxSecondName.AutoSize = true;
            this.CheckBoxSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CheckBoxSecondName.Location = new System.Drawing.Point(93, 102);
            this.CheckBoxSecondName.Name = "CheckBoxSecondName";
            this.CheckBoxSecondName.Size = new System.Drawing.Size(114, 21);
            this.CheckBoxSecondName.TabIndex = 14;
            this.CheckBoxSecondName.Text = "Second name";
            this.CheckBoxSecondName.UseVisualStyleBackColor = true;
            this.CheckBoxSecondName.CheckedChanged += new System.EventHandler(this.CheckBoxSecondName_CheckedChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.IndianRed;
            this.NameTextBox.Location = new System.Drawing.Point(102, 76);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(200, 20);
            this.NameTextBox.TabIndex = 15;
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.BackColor = System.Drawing.Color.IndianRed;
            this.SurnameTextBox.Location = new System.Drawing.Point(102, 155);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.SurnameTextBox.TabIndex = 16;
            this.SurnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameTextBox_KeyPress);
            // 
            // SecondNameTextBox
            // 
            this.SecondNameTextBox.BackColor = System.Drawing.Color.IndianRed;
            this.SecondNameTextBox.Location = new System.Drawing.Point(102, 129);
            this.SecondNameTextBox.Name = "SecondNameTextBox";
            this.SecondNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.SecondNameTextBox.TabIndex = 18;
            this.SecondNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecondNameTextBox_KeyPress);
            // 
            // SecondNameLabel
            // 
            this.SecondNameLabel.AutoSize = true;
            this.SecondNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.SecondNameLabel.Location = new System.Drawing.Point(12, 127);
            this.SecondNameLabel.Name = "SecondNameLabel";
            this.SecondNameLabel.Size = new System.Drawing.Size(85, 20);
            this.SecondNameLabel.TabIndex = 19;
            this.SecondNameLabel.Text = "2nd Name";
            // 
            // OibTextBox
            // 
            this.OibTextBox.BackColor = System.Drawing.Color.IndianRed;
            this.OibTextBox.Location = new System.Drawing.Point(61, 206);
            this.OibTextBox.MaxLength = 11;
            this.OibTextBox.Name = "OibTextBox";
            this.OibTextBox.Size = new System.Drawing.Size(200, 20);
            this.OibTextBox.TabIndex = 20;
            this.OibTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OibTextBox_KeyPress);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(328, 487);
            this.ControlBox = false;
            this.Controls.Add(this.OibTextBox);
            this.Controls.Add(this.SecondNameLabel);
            this.Controls.Add(this.SecondNameTextBox);
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
            this.MaximumSize = new System.Drawing.Size(344, 526);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateTimeBirthday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboPosition;
        private System.Windows.Forms.CheckedListBox ListProjects;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.CheckBox CheckBoxSecondName;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox SecondNameTextBox;
        private System.Windows.Forms.Label SecondNameLabel;
        private TextBox OibTextBox;
    }
}