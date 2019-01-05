using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employees.Data;
using Employees.Data.Project;
using Employees.Domain.Database_Scheme;
using Employees.Domain.Repository;
using Employees.Infrastructure.Enums;
using Employees.Infrastructure.Extension;
using Employees.Presentation.ManageEmployees.Popouts;
using Employees.Presentation.Warnings;

namespace Employees.Presentation.ManageEmployees
{
    public partial class AddEmployee : Form
    {
        private readonly MainRepository _mainRepository;
        private readonly Employee _mockEmployee = new Employee("","","",DateTime.Now,Position.Accountant,"");

        public AddEmployee(MainRepository mainRepository)
        {
            InitializeComponent();
            _mainRepository = mainRepository;
            DateTimeBirthday.MaxDate = new DateTime(DateTime.Today.Year - 18, DateTime.Today.Month ,DateTime.Today.Day);
            SecondNameLabel.Hide();
            SecondNameTextBox.Hide();
            FillDropDownPosition();
            FillListOfProjects();
        }

        private void FillDropDownPosition()
        {
            var positionNames = Enum.GetNames(typeof(Position));
            foreach (var positionName in positionNames)
            {
                ComboPosition.Items.Add(positionName);
            }
        }

        private void FillListOfProjects()
        {
            foreach (var project in _mainRepository.DataProjects.GetAllProjects())
            {
                ListProjects.Items.Add(project);
            }
        }
        private void NameTextBox_KeyPress(object sender, EventArgs e)
        {
            NameTextBox.BackColor = NameExtension.TryName(out var inputName, NameTextBox.Text) ? Color.LightGreen : Color.IndianRed;
            NameTextBox.Text = "";
            NameTextBox.AppendText(inputName);

        }

        private void SurnameTextBox_KeyPress(object sender, EventArgs e)
        {
            SurnameTextBox.BackColor = NameExtension.TryName(out var inputName, SurnameTextBox.Text) ? Color.LightGreen : Color.IndianRed;
            SurnameTextBox.Text = "";
            SurnameTextBox.AppendText(inputName);
        }
        private void SecondNameTextBox_KeyPress(object sender, EventArgs e)
        {
            SecondNameTextBox.BackColor = NameExtension.TryName(out var inputName, SecondNameTextBox.Text) ? Color.LightGreen : Color.IndianRed;
            SecondNameTextBox.Text = "";
            SecondNameTextBox.AppendText(inputName);
        }
        private void OibTextBox_KeyPress(object sender, EventArgs e)
        {
            OibTextBox.BackColor = OibExtension.TryOib(out var inputOib, OibTextBox.Text) ? Color.LightGreen
                : Color.IndianRed;
            OibTextBox.Text = "";
            OibTextBox.AppendText(inputOib);
        }

        private void CheckBoxSecondName_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxSecondName.Checked)
            {
                SecondNameTextBox.Show();
                SecondNameLabel.Show();
                SecondNameTextBox.BackColor = Color.IndianRed;
            }
            else
            {
                SecondNameTextBox.Hide();
                SecondNameLabel.Hide();
                SecondNameTextBox.BackColor = Color.LightGreen;
            }
        }

        private void DateTimeBirthday_ValueChanged(object sender, EventArgs e)
        {
            _mockEmployee.DateBirth = DateTimeBirthday.Value;
        }

        private void ComboPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            _mockEmployee.Position = (Position)Enum.Parse(typeof(Position), ComboPosition.Text);
            ComboPosition.BackColor = Color.LightGreen;
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CheckSave.CheckForm(this))
            {
                _mockEmployee.Forename = NameTextBox.Text;
                _mockEmployee.SecondForename = SecondNameTextBox.Text;
                _mockEmployee.Surname = SecondNameTextBox.Text;
                _mockEmployee.Oib = OibTextBox.Text;
                _mainRepository.DataEmployees.AddEmployee(_mockEmployee);
                foreach (var project in ListProjects.CheckedItems)
                {
                    var projectRef = _mainRepository.DataProjects.GetAllProjects()
                        .Find(projectInQuestion => project.Equals(projectInQuestion));
                    var popoutEmployeeTime = new EmployeeTime(_mainRepository, _mockEmployee, projectRef);
                    popoutEmployeeTime.ShowDialog();
                }
                Close();
            }
            else
            {
                var popoutWarningWindow = new WarningTemplate("Please make sure all info is entered correctly");
                popoutWarningWindow.ShowDialog();
            }
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
