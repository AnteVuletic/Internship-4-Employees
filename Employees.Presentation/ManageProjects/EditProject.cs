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
        private readonly MainRepository _mainRepository;
        private Project _currentProject;
        private ProjectPlan _currentProjectPlan;
        private int _currentProjectIndex = 0;
        private readonly List<Employee> _selectedEmployees = new List<Employee>();
        public EditProject(MainRepository mainRepository)
        {
            InitializeComponent();
            _mainRepository = mainRepository;
            CurrentProjectInfo();
        }
        public void FillEmployeeList()
        {
            _selectedEmployees.Clear();
            EmployeeCheckedList.Items.Clear();
            foreach (var employee in _mainRepository.DataEmployees.GetAllEmployees())
            {
                EmployeeCheckedList.Items.Add(employee);
                if (!_mainRepository.RelationEmployeeProject.Contains(
                    new RelationEmployeeProject(employee, _currentProject))) continue;
                EmployeeCheckedList.SetItemChecked(EmployeeCheckedList.Items.IndexOf(employee), true);
                _selectedEmployees.Add(employee);
            }
        }
        
        public void RefreshSelectedEmployeeList()
        {
            SelectedEmployeeList.Clear();
            foreach (var checkedEmployee in _selectedEmployees)
            {
                SelectedEmployeeList.Items.Add(checkedEmployee.ToString());
            }
        }
        public void GetCurrentProject()
        {
            if (_mainRepository.DataProjects.GetAllProjects()[_currentProjectIndex] is Project)
                _currentProject = (Project) _mainRepository.DataProjects.GetAllProjects()[_currentProjectIndex];
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
                EmployeeLabel.Hide();
                SelectedEmployeeControlLabel.Hide();
                EmployeeCheckedList.Hide();
                SelectedEmployeeList.Hide();
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
                RefreshSelectedEmployeeList();
                ProjectStartLabel.Show();
                ProjectEndLabel.Show();
                EmployeeLabel.Show();
                SelectedEmployeeControlLabel.Show();
                EmployeeCheckedList.Show();
                SelectedEmployeeList.Show();
                StartDatePicker.Show();
                EndDatePicker.Show();
                IsActiveCheckBox.Show();
            }

            CurrentProjectTextBox.Text =
                $@"{(_currentProjectIndex+1).ToString()} / {_mainRepository.DataProjects.GetAllProjects().Count}";
        }

        private void EmployeeCheckedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeCheckedList.SetItemChecked(EmployeeCheckedList.SelectedIndex, true);
            var employeeSelected = EmployeeCheckedList.SelectedItem as Employee;
            foreach (var employee in _selectedEmployees)
            {
                if (!employee.Equals(employeeSelected)) continue;
                EmployeeCheckedList.SetItemChecked(EmployeeCheckedList.SelectedIndex, false);
                _selectedEmployees.Remove(employee);
                _mainRepository.RelationEmployeeProject.Remove(new RelationEmployeeProject(employee, _currentProject));
                RefreshSelectedEmployeeList();
                return;
            }
            _selectedEmployees.Add(employeeSelected);
            RefreshSelectedEmployeeList();
        }

        private void SelectedEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedEmployeeList.SelectedItems.Count == 0) return;
            var itemsSelected = SelectedEmployeeList.SelectedIndices[0];
            var popoutItemSelected = new EmployeeTime(_mainRepository, _selectedEmployees[itemsSelected], _currentProject,
                _mainRepository
                    .RelationEmployeeProject[
                        _mainRepository.GetIndexOfRelation(new RelationEmployeeProject(_selectedEmployees[itemsSelected], _currentProject))]
                    .TimeOnProjectWeek);
            popoutItemSelected.ShowDialog();
            SelectedEmployeeList.SelectedItems.Clear();        
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_mainRepository.DataProjects.GetAllProjects()[_currentProjectIndex] is Project)
                _currentProject.Name = NameTextBox.Text;
            else
                _currentProjectPlan.Name = NameTextBox.Text;
        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            _currentProject.StartDate = StartDatePicker.Value;
            EndDatePicker.Enabled = true;
            EndDatePicker.MinDate = StartDatePicker.Value;
        }

        private void EndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            _currentProject.EndDate = EndDatePicker.Value;
        }

        private void IsActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _currentProject.IsActive = IsActiveCheckBox.Checked;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RealCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (_mainRepository.DataProjects.GetAllProjects()[_currentProjectIndex] is Project)
                return;
            _mainRepository.DataProjects.GetAllProjects()[_currentProjectIndex] = new Project(_currentProjectPlan.Name, DateTime.Now, DateTime.Now,true,false);
            CurrentProjectInfo();
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
    }
}
