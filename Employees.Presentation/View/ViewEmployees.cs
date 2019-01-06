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

        public void EmployeeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EmployeeListView.SelectedItems.Count == 0) return;
            var indexOfEmployee = _mainRepository.DataEmployees.GetAllEmployees()
                .FindIndex(employee => employee.Oib == EmployeeListView.SelectedItems[0].SubItems[0].Text);
            new OptionsEmployees(_mainRepository, indexOfEmployee).ShowDialog();
        }

    }
}
