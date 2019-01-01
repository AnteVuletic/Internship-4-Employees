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

namespace Employees.Presentation.ManageProjects
{
    public partial class EditProject : Form
    {
        public EditProject(MainRepository mainRepository)
        {
            InitializeComponent();
        }
    }
}
