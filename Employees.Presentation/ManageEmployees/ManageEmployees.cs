using System;
using System.Windows.Forms;
using Employees.Domain.Repository;

namespace Employees.Presentation.ManageEmployees
{
    public partial class ManageEmployees : Form
    {
        private MainRepository _mainRepository;
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
            var editEmployeeWindow = new EditEmployee(_mainRepository);
            editEmployeeWindow.ShowDialog();
        }

        private void BtnDeleteEmployee_Click(object sender, EventArgs e)
        {
            var deleteEmployeeWindow = new DeleteEmployee(_mainRepository);
            deleteEmployeeWindow.ShowDialog();
        }
    }
}
