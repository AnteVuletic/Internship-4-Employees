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
using Employees.Presentation.ManageEmployees.Popouts;

namespace Employees.Presentation.ManageEmployees
{
    public partial class EditEmployee : Form
    {
        private MainRepository _mainRepository;
        private int _currentEmployeeIndex = 0;
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
            NameTextBox.Text = _currentEmployee.Forename;
            CheckIfSecondName();
            SurnameTextBox.Text = _currentEmployee.Surname;
            OibTextBox.Text = _currentEmployee.Oib;
            DateTimeBirthday.Value = _currentEmployee.DateBirth;
            ComboPosition.Text = Enum.GetName(typeof(Position), _currentEmployee.Position);
            CurrentPageTextBox.Text = $@"{_currentEmployeeIndex+1} / {_mainRepository.DataEmployees.GetAllEmployees().Count}";
            FillEmployeeList();
        }


        private void CheckIfSecondName()
        {
           if(_currentEmployee.SecondForename != null)
           {
               CheckBoxSecondName.Checked = true;
               SecondNameTextBox.Show();
               SecondNameTextBox.Text = _currentEmployee.SecondForename;
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
            var tmpRelationEmployeeProjectList = new List<RelationEmployeeProject>();
            _mainRepository.DataEmployees.GetAllEmployees()[_currentEmployeeIndex] =
                new Employee(_currentEmployee.Forename, _currentEmployee.Oib, _currentEmployee.Oib,
                    _currentEmployee.DateBirth, _currentEmployee.Position, _currentEmployee.SecondForename);
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
                var popoutEmployeeTime = new EmployeeTime(_mainRepository,_currentEmployee,(Project)projectRefrence);
                popoutEmployeeTime.ShowDialog();
            }
            RefreshEmployee();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentEmployee.Forename = NameTextBox.Text;
        }

        private void SecondNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentEmployee.SecondForename = SecondNameTextBox.Text;
        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentEmployee.Surname = SurnameTextBox.Text;
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
