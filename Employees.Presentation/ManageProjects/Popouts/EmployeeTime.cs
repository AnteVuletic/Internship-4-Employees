using System;
using System.Windows.Forms;
using Employees.Data;
using Employees.Data.Project;
using Employees.Domain.Database_Scheme;
using Employees.Domain.Repository;
using Employees.Presentation.Warnings;

namespace Employees.Presentation.ManageProjects.Popouts
{
    public partial class EmployeeTime : Form
    {
        private readonly MainRepository _mainRepository;
        private readonly Employee _employee;
        private readonly ProjectPlan _project;
        private int _tmpTimeWeek;
        private readonly bool _flagForEdit;
        public EmployeeTime(MainRepository mainRepository, Employee employee, ProjectPlan project)
        {
            InitializeComponent();
            _mainRepository = mainRepository;
            _employee = employee;
            _project = project;
            _tmpTimeWeek = 0;
            RefreshEmployeeInfo();
        }

        public EmployeeTime(MainRepository mainRepository, Employee employee, ProjectPlan project, int tmpTimeWeek)
        {
            InitializeComponent();
            _mainRepository = mainRepository;
            _employee = employee;
            _project = project;
            _tmpTimeWeek = tmpTimeWeek;
            _flagForEdit = true;
            RefreshEmployeeInfo();
        }
        private void RefreshEmployeeInfo()
        {
            EmployeInfoTextBox.Text = $@"{_employee.Forename} {_employee.Surname} {_employee.Position.ToString()}";
            ProjectNameTextbox.Text = _project.Name;
            if (_flagForEdit)
                TimeEmployeeTextbox.Text = _tmpTimeWeek.ToString("G");
        }

        private void TimeEmployeeTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(TimeEmployeeTextbox.Text, out _tmpTimeWeek))
                TimeEmployeeTextbox.Text = "";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(_tmpTimeWeek == 0 )
            {
               new WarningTemplate("Please enter a value that's not 0.").ShowDialog();

            }else if (_tmpTimeWeek > 168)
            {
                new WarningTemplate("There' only 168 hours in a week.").ShowDialog();
            }
            else
            {
                _mainRepository.RelationEmployeeProject.Add(new RelationEmployeeProject(_employee,_project,_tmpTimeWeek));
                Close();
            }
        }
    }
}
