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
            var alternateRows = true;
            foreach (var employee in _mainRepository.DataEmployees.GetAllEmployees())
            {
                var oneRow = new ListViewItem(employee.Oib)
                {
                    BackColor = alternateRows ? Color.CadetBlue : Color.AliceBlue
                };
                oneRow.SubItems.Add(employee.Forename);
                oneRow.SubItems.Add(employee.SecondForename);
                oneRow.SubItems.Add(employee.Surname);
                oneRow.SubItems.Add(employee.Position.ToString());
                oneRow.SubItems.Add(employee.DateBirth.ToString("MM/dd/yyyy"));
                EmployeeListView.Items.Add(oneRow);
                alternateRows = !alternateRows;
            }
        }

    }
}
