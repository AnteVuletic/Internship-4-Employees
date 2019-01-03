using System;
using System.Windows.Forms;
using Employees.Domain.Repository;
using Employees.Presentation.Warnings;

namespace Employees.Presentation.ManageEmployees
{
    public partial class ManageEmployees : Form
    {
        private readonly MainRepository _mainRepository;
        public ManageEmployees(MainRepository mainRepository)
        {
            InitializeComponent();
            _mainRepository = mainRepository;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var addEmployeeWindow = new AddEmployee(_mainRepository);
            addEmployeeWindow.ShowDialog();
        }

        private void BtnEditEmployee_Click(object sender, EventArgs e)
        {
            if (_mainRepository.DataEmployees.GetAllEmployees().Count == 0)
            {
                var warningWindow = new WarningTemplate("There are no employees please add an employee first!");
                warningWindow.ShowDialog();
                return;
            }
            var editEmployeeWindow = new EditEmployee(_mainRepository);
            editEmployeeWindow.ShowDialog();
        }

        private void BtnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (_mainRepository.DataEmployees.GetAllEmployees().Count == 0)
            {
                var warningWindow = new WarningTemplate("There are no employees please add an employee first!");
                warningWindow.ShowDialog();
                return;
            }
            var deleteEmployeeWindow = new DeleteEmployee(_mainRepository);
            deleteEmployeeWindow.ShowDialog();
        }
    }
}
