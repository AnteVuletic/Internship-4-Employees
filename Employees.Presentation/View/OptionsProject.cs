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
using Employees.Presentation.ManageProjects;

namespace Employees.Presentation.View
{
    public partial class OptionsProject : Form
    {
        private MainRepository _mainRepository;
        private int _indexOfProject;
        public OptionsProject(MainRepository mainRepository,int indexOfProject)
        {
            InitializeComponent();
            _mainRepository = mainRepository;
            _indexOfProject = indexOfProject;
            NameTextBox.Text = _mainRepository.DataProjects.GetAllProjects()[_indexOfProject].Name;
            if (!(_mainRepository.DataProjects.GetAllProjects()[_indexOfProject] is Project))
                BtnFinish.Enabled = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            new EditProject(_mainRepository, _indexOfProject).ShowDialog();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            new RemoveProject(_mainRepository, _indexOfProject).ShowDialog();
        }

        private void BtnFinish_Click(object sender, EventArgs e)
        {
            if (_mainRepository.DataProjects.GetAllProjects()[_indexOfProject] is Project realProject)
                realProject.IsFinished = !realProject.IsFinished;
        }
    }
}
