using System;
using System.Windows.Forms;
using Employees.Domain.Repository;

namespace Employees.Presentation.ManageProjects
{
    public partial class ManageProjects : Form
    {
        private MainRepository _mainRepository;
        public ManageProjects(MainRepository mainRepository)
        {
            InitializeComponent();
            _mainRepository = mainRepository;
        }

        private void BtnAddProject_Click(object sender, EventArgs e)
        {
            var windowAddProject = new AddProject(_mainRepository);
            windowAddProject.ShowDialog();
        }

        private void BtnEditProject_Click(object sender, EventArgs e)
        {
            var windowEditProject = new EditProject(_mainRepository);
            windowEditProject.ShowDialog();
        }

        private void BtnDeleteProject_Click(object sender, EventArgs e)
        {
            var windowDeleteProject = new RemoveProject(_mainRepository);
            windowDeleteProject.ShowDialog();
        }
    }
}
