using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

namespace Employees.Presentation.ManageEmployees
{
    public partial class EditEmployee : Form
    {
        private MainRepository _mainRepository;
        private int _currentEmployeeIndex = 0;
        private Employee _mockEmployee;
        private Employee _currentEmployee;
        public EditEmployee(MainRepository mainRepository)
        {
            InitializeComponent();
            _mainRepository = mainRepository;
            FillDropDownPosition();
            RefreshEmployee();
        }
        private void FillDropDownPosition()
        {
            var positionNames = Enum.GetNames(typeof(Position));
            foreach (var positionName in positionNames)
            {
                ComboPosition.Items.Add(positionName);                    
            }
        }

        private void FillEmployeeList()
        {
            ListProjects.Items.Clear();
            foreach (var project in _mainRepository.DataProjects.GetAllProjects())
            {
                ListProjects.Items.Add(project);
                if(_mainRepository.RelationEmployeeProject.Contains(new RelationEmployeeProject(_currentEmployee,project)))
                    ListProjects.SetItemChecked(ListProjects.Items.IndexOf(project),true);
            }
        }
        private void RefreshEmployee()
        {
            _currentEmployee = _mainRepository.DataEmployees.GetAllEmployees()[_currentEmployeeIndex];
            _mockEmployee = new Employee(_currentEmployee.Forename, _currentEmployee.Surname, _currentEmployee.Oib,
                _currentEmployee.DateBirth, _currentEmployee.Position, _currentEmployee.SecondForename);
            NameTextBox.Text = _mockEmployee.Forename;
            CheckIfSecondName();
            SurnameTextBox.Text = _mockEmployee.Surname;
            OibTextBox.Text = _mockEmployee.Oib;
            DateTimeBirthday.Value = _mockEmployee.DateBirth;
            ComboPosition.Text = Enum.GetName(typeof(Position), _mockEmployee.Position);
            CurrentPageTextBox.Text = $@"{_currentEmployeeIndex+1} / {_mainRepository.DataEmployees.GetAllEmployees().Count}";
            FillEmployeeList();
        }


        private void CheckIfSecondName()
        {
           if(_mockEmployee.SecondForename != null)
           {
               CheckBoxSecondName.Checked = true;
               SecondNameTextBox.Show();
               SecondNameTextBox.Text = _mockEmployee.SecondForename;
               return;
           }
           CheckBoxSecondName.Checked = false;
           SecondNameTextBox.Hide();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if(_currentEmployeeIndex == _mainRepository.DataEmployees.GetAllEmployees().Count - 1) return;
            _currentEmployeeIndex++;
            RefreshEmployee();
        }


        private void BtnLastEmployee_Click(object sender, EventArgs e)
        {
            if (_currentEmployeeIndex == _mainRepository.DataEmployees.GetAllEmployees().Count - 1) return;
            _currentEmployeeIndex = _mainRepository.DataEmployees.GetAllEmployees().Count() - 1;
            RefreshEmployee();
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (_currentEmployeeIndex == 0) return;
            _currentEmployeeIndex--;
            RefreshEmployee();
        }

        private void BtnFirstEmployee_Click(object sender, EventArgs e)
        {
            if (_currentEmployeeIndex == 0) return;
            _currentEmployeeIndex = 0;
            RefreshEmployee();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _mockEmployee.Forename = NameTextBox.Text;
            _mockEmployee.SecondForename = SecondNameTextBox.Text;
            _mockEmployee.Surname = SurnameTextBox.Text;
            var tmpRelationEmployeeProjectList = new List<RelationEmployeeProject>();         
            foreach (var relationEmployeeProject in _mainRepository.RelationEmployeeProject)
            {
                if (relationEmployeeProject.EmployeeOib == _currentEmployee.Oib)
                    tmpRelationEmployeeProjectList.Add(relationEmployeeProject);
            }

            foreach (var relationEmployeeProject in tmpRelationEmployeeProjectList)
            {
                if (relationEmployeeProject.EmployeeOib == _currentEmployee.Oib)
                    _mainRepository.RelationEmployeeProject.Remove(relationEmployeeProject);
            }

            _mainRepository.DataEmployees.GetAllEmployees()[_currentEmployeeIndex] = _mockEmployee;
            foreach (var relationEmployeeProject in tmpRelationEmployeeProjectList)
            {
                relationEmployeeProject.EmployeeOib = _mockEmployee.Oib;
            }
            foreach (var checkedItem in ListProjects.CheckedItems)
            {
                var checkedItemAppeared = false;
                foreach (var relationEmployeeProject in tmpRelationEmployeeProjectList)
                {
                    if (_mainRepository.DataProjects.GetProjectById(relationEmployeeProject.ProjectGuid).ToString() !=
                        checkedItem.ToString()) continue;
                    checkedItemAppeared = true;
                    _mainRepository.RelationEmployeeProject.Add(relationEmployeeProject);
                }
                if (checkedItemAppeared) continue;
                var projectRefrence = _mainRepository.DataProjects.GetAllProjects().Find(
                    projectIterator => projectIterator.ToString() == checkedItem.ToString());
                var popoutEmployeeTime = new EmployeeTime(_mainRepository,_currentEmployee,projectRefrence);
                popoutEmployeeTime.ShowDialog();
            }
            RefreshEmployee();
        }

        private void NameTextBox_KeyPress(object sender, EventArgs e)
        {
            if (NameExtension.TryName(out var inputName, NameTextBox.Text))
            {
                NameTextBox.Text = "";
                NameTextBox.AppendText(inputName);
                NameTextBox.BackColor = Color.LightGreen;
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
            }
            else
            {
                SurnameTextBox.Text = "";
                SurnameTextBox.AppendText(inputName);
                SurnameTextBox.BackColor = Color.IndianRed;
            }
        }
        private void SecondNameTextBox_KeyPress(object sender, EventArgs e)
        {
            if (NameExtension.TryName(out var inputName, SecondNameTextBox.Text))
            {
                SecondNameTextBox.Text = "";
                SecondNameTextBox.AppendText(inputName);
                SecondNameTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                SecondNameTextBox.Text = "";
                SecondNameTextBox.AppendText(inputName);
                SecondNameTextBox.BackColor = Color.IndianRed;
            }
        }
        private void OibTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentEmployee.Oib = OibTextBox.Text;
        }

        private void DateTimeBirthday_ValueChanged(object sender, EventArgs e)
        {
            _currentEmployee.DateBirth = DateTimeBirthday.Value;
        }

        private void ComboPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentEmployee.Position = (Position)Enum.Parse(typeof(Position), ComboPosition.Text);
        }

    }
}
