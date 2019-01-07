using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employees.Data.Project;
using Employees.Domain.Database_Scheme;
using Employees.Domain.Repository;
using Employees.Presentation.Warnings;

namespace Employees.Presentation.ManageProjects
{
    public partial class RemoveProject : Form
    {
        private MainRepository _mainRepository;
        private Project _currentProject;
        private ProjectPlan _currentProjectPlan;
        private int _currentProjectIndex = 0;
        public RemoveProject(MainRepository mainRepository)
        {
            InitializeComponent();
            _mainRepository = mainRepository;
            CurrentProjectInfo();
        }
        public RemoveProject(MainRepository mainRepository, int indexPassed)
        {
            InitializeComponent();
            _mainRepository = mainRepository;
            _currentProjectIndex = indexPassed;
            CurrentProjectInfo();
        }
        public void FillEmployeeList()
        {
            EmployeeOnProjectList.Clear();
            foreach (var employee in _mainRepository.DataEmployees.GetAllEmployees())
            {
                if (_mainRepository.RelationEmployeeProject.Contains(
                    new RelationEmployeeProject(employee, _mainRepository.DataProjects.GetAllProjects()[_currentProjectIndex])))
                    EmployeeOnProjectList.Items.Add(employee.ToString());
            }
        }
        public void GetCurrentProject()
        {
            if (_mainRepository.DataProjects.GetAllProjects()[_currentProjectIndex] is Project)
                _currentProject = (Project)_mainRepository.DataProjects.GetAllProjects()[_currentProjectIndex];
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
                FillEmployeeList();
                ProjectStartLabel.Hide();
                ProjectEndLabel.Hide();
                EmployeeLabel.Hide();
                EmployeeOnProjectList.Hide();
                StartDatePicker.Hide();
                EndDatePicker.Hide();
                IsActiveCheckBox.Hide();

            }
            else
            {
                NameTextBox.Text = _currentProject.Name;
                RealCheckbox.Checked = true;
                StartDatePicker.Value = _currentProject.StartDate;
                EndDatePicker.Value = _currentProject.EndDate;
                FillEmployeeList();
                ProjectStartLabel.Show();
                ProjectEndLabel.Show();
                EmployeeLabel.Show();
                EmployeeOnProjectList.Show();
                StartDatePicker.Show();
                EndDatePicker.Show();
                IsActiveCheckBox.Show();
            }

            CurrentProjectTextBox.Text =
                $@"{(_currentProjectIndex + 1).ToString()} / {_mainRepository.DataProjects.GetAllProjects().Count}";
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (new WarningAreYouSure().ShowDialog() == DialogResult.No) return;
            _mainRepository.RelationEmployeeProject.RemoveAll(project => project.ProjectGuid == _currentProject.Id);
            _mainRepository.DataProjects.RemoveProjectById(_currentProject.Id);
            DialogResult = DialogResult.OK;
        }
    }
}
