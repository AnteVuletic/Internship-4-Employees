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

namespace Employees.Presentation.ManageProjects
{
    public partial class EditProject : Form
    {
        private MainRepository _mainRepository;
        private ProjectPlan _currentProjectPlan;
        private int _currentProjectIndex = 0;
        private List<RelationEmployeeProject> _employeesOnProject = new List<RelationEmployeeProject>();
        public EditProject(MainRepository mainRepository)
        {
            InitializeComponent();
            _mainRepository = mainRepository;
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
            GetCurrentProject();
            if (!(_mainRepository.DataProjects.GetAllProjects()[_currentProjectIndex] is Project))
            {
                NameTextBox.Text = _currentProjectPlan.Name;
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
                NameTextBox.Text = _currentProjectPlan.Name;
                RealCheckbox.Checked = true;
                StartDatePicker.Value = ((Project) _currentProjectPlan).StartDate;
                EndDatePicker.Value = ((Project)_currentProjectPlan).EndDate;
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

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
                _currentProjectPlan.Name = NameTextBox.Text;
        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            ((Project)_currentProjectPlan).StartDate = StartDatePicker.Value;
            EndDatePicker.Enabled = true;
            EndDatePicker.MinDate = StartDatePicker.Value;
        }

        private void EndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            ((Project)_currentProjectPlan).EndDate = EndDatePicker.Value;
        }

        private void IsActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ((Project)_currentProjectPlan).IsActive = IsActiveCheckBox.Checked;
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

        private void RealCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (_mainRepository.DataProjects.GetAllProjects()[_currentProjectIndex] is Project)
            {
                RealCheckbox.Checked = true;
                return;
            }
            _mainRepository.DataProjects.GetAllProjects()[_currentProjectIndex] =
                new Project(_currentProjectPlan.Name, DateTime.Now, DateTime.Now, true, false)
                {
                    Id = _currentProjectPlan.Id
                };
            _currentProjectPlan = null;
            CurrentProjectInfo();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            foreach (var checkedItem in EmployeeCheckedList.CheckedItems)
            {
                var checkedEmployee = _mainRepository.DataEmployees.GetAllEmployees()
                    .Find(employee => employee.Equals(checkedItem));
                EmployeeTime popoutEmployeeTime;
                if (_employeesOnProject.Contains(new RelationEmployeeProject(checkedEmployee, _currentProjectPlan)))
                {
                    popoutEmployeeTime = new EmployeeTime(_mainRepository,checkedEmployee,_currentProjectPlan
                        ,_employeesOnProject.Find(relation => relation.EmployeeOib == checkedEmployee.Oib).TimeOnProjectWeek);
                }
                else
                {
                    popoutEmployeeTime = new EmployeeTime(_mainRepository, checkedEmployee, _currentProjectPlan);
                }
                popoutEmployeeTime.ShowDialog();
            }
            Close();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
