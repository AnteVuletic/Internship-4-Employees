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
            if (_mainRepository.DataProjects.GetAllProjects[_currentProjectIndex] is Project)
                _currentProject = (Project) _mainRepository.DataProjects.GetAllProjects[_currentProjectIndex];
            else
                _currentProjectPlan = _mainRepository.DataProjects.GetAllProjects[_currentProjectIndex];
        }
        public void CurrentProjectInfo()
        {
            GetCurrentProject();
            if (!(_mainRepository.DataProjects.GetAllProjects[_currentProjectIndex] is Project))
            {
                NameTextBox.Text = _currentProjectPlan.Name;
                RealCheckbox.Checked = false;
            }
            else
            {
                NameTextBox.Text = _currentProject.Name;
                RealCheckbox.Checked = true;
                StartDatePicker.Value = _currentProject.StartDate;
                EndDatePicker.Value = _currentProject.EndDate;
                FillEmployeeList();
                RefreshSelectedEmployeeList();
            }

        }

        private void EmployeeCheckedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeCheckedList.SetItemChecked(EmployeeCheckedList.SelectedIndex, true);
            var employeeSelected = EmployeeCheckedList.SelectedItem as Employee;
            foreach (var Employee in _selectedEmployees)
            {
                if (Employee != employeeSelected) continue;
                EmployeeCheckedList.SetItemChecked(EmployeeCheckedList.SelectedIndex, false);
                _selectedEmployees.Remove(Employee);
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
    }
}
