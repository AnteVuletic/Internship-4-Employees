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
            _mainRepository.DataEmployees.GetAllEmployees().Remove(_currentEmployee);
            RefreshEmployee();
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
