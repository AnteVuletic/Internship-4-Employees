namespace Employees.Presentation.Warnings
{
    partial class WarningTemplate
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
            this.WarningTextBox = new System.Windows.Forms.TextBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WarningTextBox
            // 
            this.WarningTextBox.Enabled = false;
            this.WarningTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.WarningTextBox.Location = new System.Drawing.Point(65, 13);
            this.WarningTextBox.Name = "WarningTextBox";
            this.WarningTextBox.Size = new System.Drawing.Size(454, 26);
            this.WarningTextBox.TabIndex = 0;
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.SystemColors.Control;
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BtnOk.Location = new System.Drawing.Point(251, 45);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 1;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // WarningTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(562, 72);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.WarningTextBox);
            this.Name = "WarningTemplate";
            this.Text = "WarningTemplate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WarningTextBox;
        private System.Windows.Forms.Button BtnOk;
    }
}