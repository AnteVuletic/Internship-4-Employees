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

namespace Employees.Presentation.ManageProjects
{
    public partial class EditProject : Form
    {
        private MainRepository _mainRepository;
        private Project _currentProject;
        private ProjectPlan _currentProjectPlan;
        private int _currentProjectIndex = 0;
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
                if(_mainRepository.RelationEmployeeProject.Contains(new RelationEmployeeProject(employee,_currentProject)))
                    EmployeeCheckedList.SetItemChecked(EmployeeCheckedList.Items.IndexOf(employee), true);
            }
        }

        public void RefreshSelectedEmployeeList()
        {
            var listOfCheckedEmployees = EmployeeCheckedList.CheckedItems;
            foreach (var checkedEmployee in listOfCheckedEmployees)
            {
                SelectedEmployeeList.Items.Add((checkedEmployee as Employee).ToString());
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
    }
}
