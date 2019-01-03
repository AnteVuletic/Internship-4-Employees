using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employees.Data.Project;
using Employees.Domain.Repository;

namespace Employees.Presentation.View
{
    public partial class ViewProjects : Form
    {
        private MainRepository _mainRepository;
        public ViewProjects(MainRepository mainRepository)
        {
            InitializeComponent();
            _mainRepository = mainRepository;
            RefreshProjectList();
        }

        public void RefreshProjectList()
        {
            foreach (var project in _mainRepository.DataProjects.GetAllProjects())
            {
                if (project is Project project1)
                    ProjectList.Items.Add(project1.ToString());
                else
                    ProjectList.Items.Add(project.ToString());
            }
        }
    }
}
