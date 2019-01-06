using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Employees.Data;
using Employees.Data.Project;
using Employees.Domain.Database_Scheme;
using Employees.Domain.Repository;
using Employees.Presentation.ManageEmployees.Popouts;
using Employees.Presentation.Warnings;

namespace Employees.Presentation.ManageProjects
{
    public partial class EditProject : Form
    {
        private MainRepository _mainRepository;
        private ProjectPlan _currentProjectPlan;
        private int _currentProjectIndex = 0;
        private ProjectPlan _mockProjectPlan;
        private Project _mockProject;
        private List<RelationEmployeeProject> _employeesOnProject = new List<RelationEmployeeProject>();
        public EditProject(MainRepository mainRepository)
        {
            InitializeComponent();
            _mainRepository = mainRepository;
            CurrentProjectInfo();
        }
        public EditProject(MainRepository mainRepository,int indexPassed)
        {
            InitializeComponent();
            _mainRepository = mainRepository;
            _currentProjectIndex = indexPassed;
            CurrentProjectInfo();
        }
        public void FillEmployeeList()
        {
            EmployeeCheckedList.Items.Clear();
            foreach (var relationEmployeeProject in _mainRepository.RelationEmployeeProject.FindAll(relationInQuestion => relationInQuestion.ProjectGuid == _currentProjectPlan.Id))
            {
                _employeesOnProject.Add(relationEmployeeProject);
            }

            foreach (var relationEmployeeProject in _employeesOnProject)
            {
                _mainRepository.RelationEmployeeProject.Remove(relationEmployeeProject);
            }

            foreach (var employee in _mainRepository.DataEmployees.GetAllEmployees())
            {
                EmployeeCheckedList.Items.Add(employee);
                if(_employeesOnProject.Contains(new RelationEmployeeProject(employee,_currentProjectPlan)))
                    EmployeeCheckedList.SetItemChecked(EmployeeCheckedList.Items.IndexOf(employee),true);
            }
        }

        public void GetCurrentProject()
        {
            if (_mainRepository.DataProjects.GetAllProjects()[_currentProjectIndex] is Project)
                _currentProjectPlan = (Project) _mainRepository.DataProjects.GetAllProjects()[_currentProjectIndex];
            else
                _currentProjectPlan = _mainRepository.DataProjects.GetAllProjects()[_currentProjectIndex];
        }
        public void CurrentProjectInfo()
        {
            _mockProject = null;
            _mockProjectPlan = null;
            GetCurrentProject();
            if (!(_currentProjectPlan is Project))
            {
                _mockProjectPlan = new ProjectPlan(_currentProjectPlan.Name)
                {
                    Id = _currentProjectPlan.Id
                };
                NameTextBox.Text = _mockProjectPlan.Name;
                RealCheckbox.Checked = false;
                RealCheckbox.CheckState = CheckState.Unchecked;
                ProjectStartLabel.Hide();
                ProjectEndLabel.Hide();
                StartDatePicker.Hide();
                EndDatePicker.Hide();
                IsActiveCheckBox.Hide();
                FillEmployeeList();
            }
            else
            {
                _mockProject = new Project(_currentProjectPlan.Name, ((Project)_currentProjectPlan).StartDate,
                    ((Project)_currentProjectPlan).EndDate, ((Project)_currentProjectPlan).IsActive,
                    ((Project)_currentProjectPlan).IsFinished)
                {
                    Id = _currentProjectPlan.Id
                };            
                NameTextBox.Text = _mockProject.Name;
                RealCheckbox.Checked = true;
                RealCheckbox.CheckState = CheckState.Checked;
                StartDatePicker.Value = _mockProject.StartDate;
                EndDatePicker.Value = _mockProject.EndDate;
                FillEmployeeList();
                ProjectStartLabel.Show();
                ProjectEndLabel.Show();
                StartDatePicker.Show();
                EndDatePicker.Show();
                IsActiveCheckBox.Show();
            }

            CurrentProjectTextBox.Text =
                $@"{(_currentProjectIndex+1).ToString()} / {_mainRepository.DataProjects.GetAllProjects().Count}";
        }

        public void RefreshProjectInfo()
        {
            if (_mockProjectPlan != null)
            {
                NameTextBox.Text = _mockProjectPlan.Name;
                RealCheckbox.Checked = false;
                ProjectStartLabel.Hide();
                ProjectEndLabel.Hide();
                StartDatePicker.Hide();
                EndDatePicker.Hide();
                IsActiveCheckBox.Hide();
                FillEmployeeList();
            }
            else
            {               
                NameTextBox.Text = _mockProject.Name;
                RealCheckbox.Checked = true;
                StartDatePicker.Value = _mockProject.StartDate;
                EndDatePicker.Value = _mockProject.EndDate;
                FillEmployeeList();
                ProjectStartLabel.Show();
                ProjectEndLabel.Show();
                StartDatePicker.Show();
                EndDatePicker.Show();
                IsActiveCheckBox.Show();
            }
        }
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_mockProject != null)
                _mockProject.Name = NameTextBox.Text;
            else
                _mockProjectPlan.Name = NameTextBox.Text;
        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            _mockProject.StartDate = StartDatePicker.Value;
            EndDatePicker.Enabled = true;
            EndDatePicker.MinDate = StartDatePicker.Value;
        }

        private void EndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            _mockProject.EndDate = EndDatePicker.Value;
        }

        private void IsActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _mockProject.IsActive = IsActiveCheckBox.Checked;
        }

        private void BtnLastProject_Click(object sender, EventArgs e)
        {
            if (_currentProjectIndex == _mainRepository.DataProjects.GetAllProjects().Count - 1) return;
            _currentProjectIndex = _mainRepository.DataProjects.GetAllProjects().Count() - 1;
            CurrentProjectInfo();
        }

        private void BtnNextProject_Click(object sender, EventArgs e)
        {
            if (_currentProjectIndex == _mainRepository.DataProjects.GetAllProjects().Count - 1) return;
            _currentProjectIndex++;
            CurrentProjectInfo();
        }

        private void BtnPrevProject_Click(object sender, EventArgs e)
        {
            if (_currentProjectIndex == 0) return;
            _currentProjectIndex--;
            CurrentProjectInfo();
        }

        private void BtnFirstProject_Click(object sender, EventArgs e)
        {         
            _currentProjectIndex = 0;
            CurrentProjectInfo();
        }

        private void RealCheckbox_Clicked(object sender, EventArgs e)
        {
            RealCheckbox.Checked = !RealCheckbox.Checked;
            if (RealCheckbox.Checked)
            {
                _mockProjectPlan = new ProjectPlan(_mockProject.Name)
                {
                    Id = _mockProject.Id
                };
                _mockProject = null;
                RefreshProjectInfo();
                return;
            }
            _mockProject =
                new Project(_mockProjectPlan.Name, DateTime.Now, DateTime.Now, true, false)
                {
                    Id = _mockProjectPlan.Id
                };
            _mockProjectPlan = null;
            RefreshProjectInfo();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

            Close();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (_mainRepository.DataProjects.GetAllProjects().FindAll(projectInQuestion => projectInQuestion.Name == NameTextBox.Text).Count > 1)
            {
                new WarningTemplate("This project name is taken").ShowDialog();
            }
            else
            {
                if (EmployeeCheckedList.CheckedItems.Count == 0)
                {
                    new WarningTemplate("Please add employees to project").ShowDialog();
                }
                else
                {
                    if (_mockProject == null)
                    {
                        _mainRepository.DataProjects.GetAllProjects()[_currentProjectIndex] = _mockProjectPlan;
                    }
                    else
                    {
                        _mainRepository.DataProjects.GetAllProjects()[_currentProjectIndex] = _mockProject;
                    }
                    foreach (var checkedItem in EmployeeCheckedList.CheckedItems)
                    {
                        var checkedEmployee = _mainRepository.DataEmployees.GetAllEmployees()
                            .Find(employee => employee.Equals(checkedItem));
                        EmployeeTime popoutEmployeeTime;
                        if (_employeesOnProject.Contains(new RelationEmployeeProject(checkedEmployee, _currentProjectPlan)))
                        {
                            popoutEmployeeTime = new EmployeeTime(_mainRepository, checkedEmployee, _currentProjectPlan
                                , _employeesOnProject.Find(relation => relation.EmployeeOib == checkedEmployee.Oib).TimeOnProjectWeek);
                        }
                        else
                        {
                            popoutEmployeeTime = new EmployeeTime(_mainRepository, checkedEmployee, _currentProjectPlan);
                        }
                        popoutEmployeeTime.ShowDialog();
                    }
                    Close();
                }
            }
        }
    }
}
