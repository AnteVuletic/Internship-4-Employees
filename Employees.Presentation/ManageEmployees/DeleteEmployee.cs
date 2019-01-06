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
using Employees.Infrastructure.Enums;
using Employees.Presentation.Warnings;

namespace Employees.Presentation.ManageEmployees
{
    public partial class DeleteEmployee : Form
    {
        private MainRepository _mainRepository;
        private Employee _currentEmployee;
        private int _currentEmployeeIndex = 0;
        public DeleteEmployee(MainRepository mainRepository)
        {
            InitializeComponent();
            _mainRepository = mainRepository;
            RefreshEmployee();
        }
        public DeleteEmployee(MainRepository mainRepository, int indexPassed)
        {
            InitializeComponent();
            _mainRepository = mainRepository;
            _currentEmployeeIndex = indexPassed;
            RefreshEmployee();
        }
        private void RefreshEmployee()
        {
            _currentEmployee = _mainRepository.DataEmployees.GetAllEmployees()[_currentEmployeeIndex];
            NameTextBox.Text = _currentEmployee.Forename;
            CheckIfSecondName();
            SurnameTextBox.Text = _currentEmployee.Surname;
            OibTextBox.Text = _currentEmployee.Oib;
            BirthdayTextBox.Text = _currentEmployee.DateBirth.ToString("MM/dd/yyyy");
            PositionTextBox.Text = Enum.GetName(typeof(Position), _currentEmployee.Position);
            CurrentPageTextBox.Text = $@"{_currentEmployeeIndex + 1} / {_mainRepository.DataEmployees.GetAllEmployees().Count()}";
            FillProjectList();
        }
        private void FillProjectList()
        {
            ListProjects.Items.Clear();
            foreach (var project in _mainRepository.DataProjects.GetAllProjects())
            {
                ListProjects.Items.Add(project);
                if (_mainRepository.RelationEmployeeProject.Contains(new RelationEmployeeProject(_currentEmployee, project)))
                    ListProjects.SetItemChecked(ListProjects.Items.IndexOf(project), true);
            }
        }
        private void CheckIfSecondName()
        {
            if (_currentEmployee.SecondForename != null)
            {
                CheckBoxSecondName.Checked = true;
                SecondNameTextBox.Show();
                SecondNameTextBox.Text = _currentEmployee.SecondForename;
                return;
            }
            CheckBoxSecondName.Checked = false;
            SecondNameTextBox.Hide();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (new WarningAreYouSure().ShowDialog() == DialogResult.No) return;
            var isDeletable = true;
            foreach (var checkedItem in ListProjects.CheckedItems)
            {
                var projectFound = _mainRepository.DataProjects.GetAllProjects().Find(projectInQuestion => (projectInQuestion is Project project)
                    ? project.ToString() == checkedItem.ToString()
                    : projectInQuestion.ToString() == checkedItem.ToString());
                if (_mainRepository.GetNumberOfRelationsOfProject(projectFound.Id) <= 1)
                    isDeletable = false;

            }

            if (isDeletable)
            {
                _mainRepository.RelationEmployeeProject.RemoveAll(
                    project => project.EmployeeOib == _currentEmployee.Oib);
                _mainRepository.DataEmployees.GetAllEmployees().Remove(_currentEmployee);
                RefreshEmployee();
            }
            else
            {
                new WarningTemplate("You can't delete this employee he's solo on project.").ShowDialog();
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (_currentEmployeeIndex == _mainRepository.DataEmployees.GetAllEmployees().Count - 1) return;
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
