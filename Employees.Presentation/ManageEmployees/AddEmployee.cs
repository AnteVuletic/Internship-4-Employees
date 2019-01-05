using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if (NameExtension.TryName(out var inputName, NameTextBox.Text))
            {
                NameTextBox.Text = "";
                NameTextBox.AppendText(inputName);
                NameTextBox.BackColor = Color.LightGreen;
                _mockEmployee.Forename = inputName;
                
            }
            else
            {
                NameTextBox.Text = "";
                NameTextBox.AppendText(inputName);
                NameTextBox.BackColor = Color.IndianRed;
            }
            
        }

        private void SurnameTextBox_KeyPress(object sender, EventArgs e)
        {
            if (NameExtension.TryName(out var inputName, SurnameTextBox.Text))
            {
                SurnameTextBox.Text = "";
                SurnameTextBox.AppendText(inputName);
                SurnameTextBox.BackColor = Color.LightGreen;
                _mockEmployee.Surname = inputName;

            }
            else
            {
                SurnameTextBox.Text = "";
                SurnameTextBox.AppendText(inputName);
                SurnameTextBox.BackColor = Color.IndianRed;
            }
        }

        private void OibTextBox_TextChanged(object sender, EventArgs e)
        {
            _mockEmployee.Oib = OibTextBox.Text;
        }

        private void CheckBoxSecondName_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxSecondName.Checked)
            {
                SecondNameTextBox.Show();
                SecondNameLabel.Show();
            }
            else
            {
                SecondNameTextBox.Hide();
                SecondNameLabel.Hide();
            }
        }

        private void DateTimeBirthday_ValueChanged(object sender, EventArgs e)
        {
            _mockEmployee.DateBirth = DateTimeBirthday.Value;
        }

        private void ComboPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            _mockEmployee.Position = (Position)Enum.Parse(typeof(Position), ComboPosition.Text);
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            _mainRepository.DataEmployees.AddEmployee(_mockEmployee);
            foreach (var project in ListProjects.CheckedItems)
            {
                var projectRef = _mainRepository.DataProjects.GetAllProjects()
                    .Find(projectInQuestion => project.Equals(projectInQuestion));
                var popoutEmployeeTime = new EmployeeTime(_mainRepository,_mockEmployee,projectRef);
                popoutEmployeeTime.ShowDialog();
            }
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SecondNameTextBox_KeyPress(object sender, EventArgs e)
        {
            if (NameExtension.TryName(out var inputName, SecondNameTextBox.Text))
            {
                SecondNameTextBox.Text = "";
                SecondNameTextBox.AppendText(inputName);
                SecondNameTextBox.BackColor = Color.LightGreen;
                _mockEmployee.SecondForename = inputName;

            }
            else
            {
                SecondNameTextBox.Text = "";
                SecondNameTextBox.AppendText(inputName);
                SecondNameTextBox.BackColor = Color.IndianRed;
            }
        }
    }
}
