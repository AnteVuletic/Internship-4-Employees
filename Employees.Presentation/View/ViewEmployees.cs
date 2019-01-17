using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employees.Domain.Repository;

namespace Employees.Presentation.View
{
    public partial class ViewEmployees : Form
    {
        private MainRepository _mainRepository;
        public ViewEmployees(MainRepository mainRepository)
        {
            InitializeComponent();
            _mainRepository = mainRepository;
            FillEmployeeList();
        }

        public void FillEmployeeList()
        {
            EmployeeListView.Scrollable = true;
            EmployeeListView.View = System.Windows.Forms.View.Details;
            EmployeeListView.Columns.Add(new ColumnHeader("OIB").Text = "OIB");
            EmployeeListView.Columns.Add(new ColumnHeader("Name").Text = "Name");
            EmployeeListView.Columns.Add(new ColumnHeader("SecondName").Text = "Second name");
            EmployeeListView.Columns.Add(new ColumnHeader("Surname").Text = "Surname");
            EmployeeListView.Columns.Add(new ColumnHeader("Position").Text = "Position");
            EmployeeListView.Columns.Add(new ColumnHeader("Birthday").Text = "Birthday");
            EmployeeListView.Columns.Add(new ColumnHeader("Hours").Text = "Weekly hours");
            EmployeeListView.Columns.Add(new ColumnHeader("Finished").Text = "Finished projects");
            EmployeeListView.Columns.Add(new ColumnHeader("Active").Text = "Active projects");
            foreach (var employee in _mainRepository.DataEmployees.GetAllEmployees())
            {
                var oneRow = new ListViewItem(employee.Oib);
                var weeklyHours = _mainRepository.GetHoursByEmployee(employee.Oib);
                if(weeklyHours < 30)
                    oneRow.BackColor = Color.Yellow;
                else if (weeklyHours >= 30 && weeklyHours <= 40)
                    oneRow.BackColor = Color.Green;
                else
                    oneRow.BackColor = Color.IndianRed;
                oneRow.SubItems.Add(employee.Forename);
                oneRow.SubItems.Add(employee.SecondForename);
                oneRow.SubItems.Add(employee.Surname);
                oneRow.SubItems.Add(employee.Position.ToString());
                oneRow.SubItems.Add(employee.DateBirth.ToString("MM/dd/yyyy"));
                oneRow.SubItems.Add(weeklyHours.ToString("G"));
                oneRow.SubItems.Add(_mainRepository.GetNumberFinishedProjectsByEmployee(employee.Oib));
                oneRow.SubItems.Add(_mainRepository.GetNumberActiveProjectsByEmployee(employee.Oib));
                EmployeeListView.Items.Add(oneRow);
                
            }
        }

        public void EmployeeListView_Click(object sender, EventArgs e)
        {
            if (EmployeeListView.SelectedItems.Count == 0) return;
            var indexOfEmployee = _mainRepository.DataEmployees.GetAllEmployees()
                .FindIndex(employee => employee.Oib == EmployeeListView.SelectedItems[0].SubItems[0].Text);
            new OptionsEmployees(_mainRepository, indexOfEmployee).ShowDialog();
            EmployeeListView.Clear();
            FillEmployeeList();
        }
    }
}
