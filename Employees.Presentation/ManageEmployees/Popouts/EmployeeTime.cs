﻿using System;
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

namespace Employees.Presentation.ManageEmployees.Popouts
{
    public partial class EmployeeTime : Form
    {
        private MainRepository _mainRepository;
        private readonly Employee _employee;
        private readonly Project _project;
        private int _tmpTimeWeek = 0;
        public EmployeeTime(MainRepository mainRepository, Employee employee, Project project)
        {
            InitializeComponent();
            _mainRepository = mainRepository;
            _employee = employee;
            _project = project;
            RefreshEmployeeInfo();
        }

        private void RefreshEmployeeInfo()
        {
            EmployeInfoTextBox.Text = $@"{_employee.Forename} {_employee.Surname} {_employee.Position.ToString()}";
            ProjectNameTextbox.Text = _project.Name;
        }

        private void TimeEmployeeTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(TimeEmployeeTextbox.Text, out _tmpTimeWeek))
                TimeEmployeeTextbox.Text = "";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _mainRepository.RelationEmployeeProject.Add(new RelationEmployeeProject(_employee,_project,_tmpTimeWeek));
            Close();
        }
    }
}