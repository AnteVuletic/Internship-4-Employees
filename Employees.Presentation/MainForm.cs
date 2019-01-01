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
using Employees.Domain.Repository;
using Employees.Infrastructure.Enums;

namespace Employees.Presentation
{
    public partial class MainForm : Form
    {
        private MainRepository _mainRepository;
        public MainForm()
        {
            InitializeComponent();
            _mainRepository = new MainRepository();
            _mainRepository.DataEmployees.AddEmployee(new Employee("Ante", "Antić", "1293192",
                new DateTime(1995, 10, 1), Position.Programmer, "Jure"));
            _mainRepository.DataEmployees.AddEmployee(new Employee("Šime", "Šimić", "1392131",
                new DateTime(1996, 3, 1), Position.Programmer));
            _mainRepository.DataEmployees.AddEmployee(new Employee("Anica", "Antić", "1673192",
                new DateTime(1997, 10, 1), Position.Accountant, "Ane"));
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
            var viewProjectsWindow = new View.ViewProjects();
            viewProjectsWindow.ShowDialog();
        }
    }
}
