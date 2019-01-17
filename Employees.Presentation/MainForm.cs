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
using Employees.Data.Enums;
using Employees.Data.Project;
using Employees.Domain.Database_Scheme;
using Employees.Domain.Repository;

namespace Employees.Presentation
{
    public partial class MainForm : Form
    {
        private MainRepository _mainRepository;
        public MainForm()
        {
            InitializeComponent();
            _mainRepository = new MainRepository();
            _mainRepository.DataEmployees.AddEmployee(new Employee("Ante", "Antić", "12345678921",
                new DateTime(1995, 10, 1), Position.Programmer, "Jure"));
            _mainRepository.DataEmployees.AddEmployee(new Employee("Šime", "Šimić", "12345678931",
                new DateTime(1996, 3, 1), Position.Programmer));
            _mainRepository.DataEmployees.AddEmployee(new Employee("Anica", "Antić", "12345678941",
                new DateTime(1997, 10, 1), Position.Accountant, "Ane"));
            _mainRepository.DataProjects.AddProject(new ProjectPlan("Cool project"));
            _mainRepository.DataProjects.AddProject(new Project("Very cool project", new DateTime(2018, 10, 10),
                DateTime.Now, true, false));
            _mainRepository.DataProjects.AddProject(new Project("Dump cool project", new DateTime(2018, 6, 15),
                new DateTime(2019, 5, 6), false, true));
            _mainRepository.DataProjects.AddProject(new Project("Somewhat cool project", new DateTime(2018, 7, 13),
                new DateTime(2019, 6, 5), false, false));
            _mainRepository.RelationEmployeeProject.Add(new RelationEmployeeProject(_mainRepository.DataEmployees.GetAllEmployees()[0],
                _mainRepository.DataProjects.GetAllProjects()[0],14));
            _mainRepository.RelationEmployeeProject.Add(new RelationEmployeeProject(_mainRepository.DataEmployees.GetAllEmployees()[1],
                _mainRepository.DataProjects.GetAllProjects()[1], 14));
            _mainRepository.RelationEmployeeProject.Add(new RelationEmployeeProject(_mainRepository.DataEmployees.GetAllEmployees()[1],
                _mainRepository.DataProjects.GetAllProjects()[2], 14));
            _mainRepository.RelationEmployeeProject.Add(new RelationEmployeeProject(_mainRepository.DataEmployees.GetAllEmployees()[2],
                _mainRepository.DataProjects.GetAllProjects()[3], 14));

        }

        private void BtnManageEmployees_Click(object sender, EventArgs e)
        {
            var manageEmployeesWindow = new ManageEmployees.ManageEmployees(_mainRepository);
            manageEmployeesWindow.ShowDialog();
        }

        private void BtnManageProjects_Click(object sender, EventArgs e)
        {
            var manageProjectsWindow = new ManageProjects.ManageProjects(_mainRepository);
            manageProjectsWindow.ShowDialog();
        }

        private void BtnViewEmployees_Click(object sender, EventArgs e)
        {
            var viewEmployeesWindow = new View.ViewEmployees(_mainRepository);
            viewEmployeesWindow.ShowDialog();
        }

        private void BtnViewProjects_Click(object sender, EventArgs e)
        {
            var viewProjectsWindow = new View.ViewProjects(_mainRepository);
            viewProjectsWindow.ShowDialog();
        }
    }
}
