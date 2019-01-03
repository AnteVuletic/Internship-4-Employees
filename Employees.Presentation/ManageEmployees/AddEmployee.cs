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
using Employees.Domain.Repository;
using Employees.Infrastructure.Enums;

namespace Employees.Presentation.ManageEmployees
{
    public partial class AddEmployee : Form
    {
        private MainRepository _mainRepository;
        private Employee _mockEmployee = new Employee("","","",DateTime.Now,Position.Accountant,"");
        public AddEmployee(MainRepository mainRepository)
        {
            InitializeComponent();
            _mainRepository = mainRepository;           
            SecondNameLabel.Hide();
            SecondNameTextBox.Hide();
            FillDropDownPosition();
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
        private void AddEmployee_Load(object sender, EventArgs e)
        {
           
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            _mockEmployee.Forename = NameTextBox.Text;
        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            _mockEmployee.Surname = SurnameTextBox.Text;
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

        private void ListProjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _mainRepository.DataEmployees.AddEmployee(_mockEmployee);
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SecondNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _mockEmployee.SecondForename = SecondNameTextBox.Text;
        }
    }
}
