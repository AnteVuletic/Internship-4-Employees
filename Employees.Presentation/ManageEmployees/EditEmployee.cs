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
using Employees.Presentation.Warnings;

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
        public EditEmployee(MainRepository mainRepository,int indexPassed)
        {
            InitializeComponent();
            _mainRepository = mainRepository;
            FillDropDownPosition();
            _currentEmployeeIndex = indexPassed;
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

        private void FillProjectList()
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
            DateTimeBirthday.MaxDate = new DateTime(DateTime.Today.Year - 18, DateTime.Today.Month, DateTime.Today.Day);
            NameTextBox.Text = _mockEmployee.Forename;
            CheckIfSecondName();
            SurnameTextBox.Text = _mockEmployee.Surname;
            OibTextBox.Text = _mockEmployee.Oib;
            DateTimeBirthday.Value = _mockEmployee.DateBirth;
            ComboPosition.Text = Enum.GetName(typeof(Position), _mockEmployee.Position);
            CurrentPageTextBox.Text = $@"{_currentEmployeeIndex+1} / {_mainRepository.DataEmployees.GetAllEmployees().Count}";
            FillProjectList();
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
            _mockEmployee.Oib = OibTextBox.Text;
            var allOccurencesofOib = _mainRepository.DataEmployees.GetAllEmployees()
                .FindAll(thisEmployee => thisEmployee.Oib == _mockEmployee.Oib);
            if (allOccurencesofOib.Count > 1)
            {
                OibTextBox.BackColor = Color.IndianRed;
            }
            var tmpRelationEmployeeProjectList = new List<RelationEmployeeProject>();         
            foreach (var relationEmployeeProject in _mainRepository.RelationEmployeeProject)
            {
                if (relationEmployeeProject.EmployeeOib == _currentEmployee.Oib)
                    tmpRelationEmployeeProjectList.Add(relationEmployeeProject);
            }
            var isOnlyEmployeeButRemovedFromProject = false;
            foreach (var relationEmployeeProject in tmpRelationEmployeeProjectList)
            {
                if (relationEmployeeProject.EmployeeOib == _currentEmployee.Oib)
                    _mainRepository.RelationEmployeeProject.Remove(relationEmployeeProject);
                if (_mainRepository.GetNumberOfRelationsOfProject(relationEmployeeProject.ProjectGuid) > 1) continue;
                foreach (var checkedItem in ListProjects.CheckedItems)
                {
                    var projectInQuestion =
                        _mainRepository.DataProjects.GetProjectById(relationEmployeeProject.ProjectGuid);
                    if (projectInQuestion is Project realProjectInQuestion)
                    {
                        if (realProjectInQuestion.ToString() != checkedItem.ToString()) continue;
                        isOnlyEmployeeButRemovedFromProject = true;
                    }
                    else
                    {
                        if (projectInQuestion.ToString() != checkedItem.ToString()) continue;
                        isOnlyEmployeeButRemovedFromProject = true;
                    }
                }
                    
            }

            if (!CheckSave.CheckForm(this) || !isOnlyEmployeeButRemovedFromProject)
            {
                foreach (var relationEmployeeProject in tmpRelationEmployeeProjectList)
                {
                    _mainRepository.RelationEmployeeProject.Add(relationEmployeeProject);
                }

                if (!isOnlyEmployeeButRemovedFromProject)
                {
                    var popoutWindowWarning = new WarningTemplate("Tried to remove only employee on project.");
                    popoutWindowWarning.ShowDialog();
                }
            }
            else
            {
                _mainRepository.DataEmployees.GetAllEmployees()[_currentEmployeeIndex] = _mockEmployee;
                foreach (var relationEmployeeProject in tmpRelationEmployeeProjectList)
                {
                    relationEmployeeProject.EmployeeOib = _mockEmployee.Oib;
                }

                foreach (var checkedItem in ListProjects.CheckedItems)
                {
                    var projectFound = _mainRepository.DataProjects.GetAllProjects().Find(projectInQuestion => (projectInQuestion is Project project)
                        ? project.ToString() == checkedItem.ToString()
                        : projectInQuestion.ToString() == checkedItem.ToString());
                    foreach (var relationEmployeeProject in tmpRelationEmployeeProjectList)
                    {
                        if (relationEmployeeProject.ProjectGuid == projectFound.Id)
                        {
                            _mainRepository.RelationEmployeeProject.Add(new RelationEmployeeProject(_mockEmployee,projectFound));
                            new EmployeeTime(_mainRepository,_mockEmployee,projectFound,relationEmployeeProject.TimeOnProjectWeek).ShowDialog();
                        }
                        else
                            new EmployeeTime(_mainRepository, _mockEmployee, projectFound).ShowDialog();
                    }
                }
            }

            RefreshEmployee();
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

        private void DateTimeBirthday_ValueChanged(object sender, EventArgs e)
        {
            _mockEmployee.DateBirth = DateTimeBirthday.Value;
        }

        private void ComboPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Enum.TryParse<Position>(ComboPosition.Text, out var outResult))
            {
                _mockEmployee.Position = outResult;
                ComboPosition.BackColor = Color.LightGreen;
            }
            else
            {
                ComboPosition.BackColor = Color.IndianRed;
            }
        }

    }
}
