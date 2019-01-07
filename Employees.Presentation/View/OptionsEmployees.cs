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
using Employees.Presentation.ManageEmployees;

namespace Employees.Presentation.View
{
    public partial class OptionsEmployees : Form
    {
        private MainRepository _mainRepository;
        private int _indexEmployee;
        public OptionsEmployees(MainRepository mainRepository, int indexEmployee)
        {
            InitializeComponent();
            _mainRepository = mainRepository;
            _indexEmployee = indexEmployee;
            NameTextBox.Text = _mainRepository.DataEmployees.GetAllEmployees()[indexEmployee].Forename + " " +
                               _mainRepository.DataEmployees.GetAllEmployees()[indexEmployee].Surname;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            new EditEmployee(_mainRepository, _indexEmployee).ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(new DeleteEmployee(_mainRepository, _indexEmployee).ShowDialog() == DialogResult.OK )
                Close();
        }
    }
}
