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
using Employees.Presentation.ManageEmployees.Popouts;


namespace Employees.Presentation.ManageProjects
{
    public partial class AddProject : Form
    {
        private readonly MainRepository _mainRepository;
        private readonly Project _project = new Project("",DateTime.Now,DateTime.Now, true,false);
        private readonly ProjectPlan _projectPlan = new ProjectPlan("");
        private readonly List<Employee> _selectedEmployees = new List<Employee>();
        public AddProject(MainRepository mainRepository)
        {
            InitializeComponent();
            _mainRepository = mainRepository;
            FillEmployeeList();
        }

        public void FillEmployeeList()
        {
            foreach (var employee in _mainRepository.DataEmployees.GetAllEmployees())
            {
                EmployeeCheckedList.Items.Add(employee);
            }
        }

        private void RealCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (RealCheckbox.Checked)
            {
                ProjectStartLabel.Show();
                ProjectEndLabel.Show();
                EmployeeLabel.Show();
                EmployeeCheckedList.Show();
                StartDatePicker.Show();
                EndDatePicker.Show();
                EndDatePicker.Enabled = false;
                IsActiveCheckBox.Show();
                _project.Name = _projectPlan.Name;
            }
            else
            {
                ProjectStartLabel.Hide();
                ProjectEndLabel.Hide();
                EmployeeLabel.Hide();
                EmployeeCheckedList.Hide();
                StartDatePicker.Hide();
                EndDatePicker.Hide();
                IsActiveCheckBox.Hide();
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IsActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IsActiveCheckBox.BackColor = IsActiveCheckBox.Checked ? Color.PaleGreen : Color.PaleVioletRed;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RealCheckbox.Checked)
                _project.Name = NameTextBox.Text;
            else
                _projectPlan.Name = NameTextBox.Text;
        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            _project.StartDate = StartDatePicker.Value;
            EndDatePicker.Enabled = true;
            EndDatePicker.MinDate = _project.StartDate;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!RealCheckbox.Checked)
                _mainRepository.DataProjects.AddProject(_projectPlan);
            else
            {
                _mainRepository.DataProjects.AddProject(_project);
                foreach (var selectedEmployee in _selectedEmployees)
                {
                    var popoutEmployeeSelectedWeeklyTime = new EmployeeTime(_mainRepository, selectedEmployee, _project);
                    popoutEmployeeSelectedWeeklyTime.ShowDialog();
                }
            }

            Close();
        }

        private void EmployeeCheckedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeCheckedList.SetItemChecked(EmployeeCheckedList.SelectedIndex,true);
            var employeeSelected = EmployeeCheckedList.SelectedItem as Employee;
            foreach (var Employee in _selectedEmployees)
            {
                if (Employee != employeeSelected) continue;
                EmployeeCheckedList.SetItemChecked(EmployeeCheckedList.SelectedIndex, false);
                _selectedEmployees.Remove(Employee);
                return;
            }
            _selectedEmployees.Add(employeeSelected);
        }
    }

}
