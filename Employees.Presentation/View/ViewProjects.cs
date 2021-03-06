﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employees.Data.Enums;
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
            ProjectList.View = System.Windows.Forms.View.Tile;
            ProjectList.Columns.Add(new ColumnHeader("Project").Text = "Project");
            ProjectList.Columns.Add(new ColumnHeader("ProjectDate").Text = "Project Date");
            foreach (var position in Enum.GetNames(typeof(Position)))
            {
                ProjectList.Columns.Add(new ColumnHeader(position).Text = position);
            }
            foreach (var project in _mainRepository.DataProjects.GetAllProjects())
            {

                var projectGroup = new ListViewItem(project.Name);
                if (project is Project realProject)
                {
                    projectGroup.SubItems.Add(realProject.StartDate.ToString("MM/dd/yyyy") + " - " +
                                              realProject.EndDate.ToString("MM/dd/yyyy"));
                }
                else
                {
                    projectGroup.SubItems.Add("-");
                }

                foreach (var position in Enum.GetNames(typeof(Position)))
                {
                    var employeesInPosition = _mainRepository.RelationEmployeeProject.FindAll(
                        relation => relation.ProjectGuid == project.Id);
                    var numOfEmployees = employeesInPosition.FindAll(employee =>
                            _mainRepository.DataEmployees.GetByOib(employee.EmployeeOib).Position.ToString() ==
                            position)
                        .Count;
                    var stringForStaging = $"{position} ({numOfEmployees}) :";
                        var ifChanged = false;
                        foreach (var relationEmployeeProject in employeesInPosition)
                        {
                            var employee = _mainRepository.DataEmployees.GetByOib(relationEmployeeProject.EmployeeOib);
                            if (employee.Position.ToString() != position) continue;
                            ifChanged = true;
                            stringForStaging += $" {Environment.NewLine} {employee.Forename} {employee.Surname} {relationEmployeeProject.TimeOnProjectWeek}";
                        }

                        projectGroup.SubItems.Add(ifChanged ? stringForStaging : " ");
                    }
                    ProjectList.Items.Add(projectGroup);
               
            }
        }

        public void ProjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProjectList.SelectedItems.Count == 0) return;
            var indexOfProject = _mainRepository.DataProjects.GetAllProjects().FindIndex(projectTest => projectTest.Name == ProjectList.SelectedItems[0].SubItems[0].Text);
            new OptionsProject(_mainRepository, indexOfProject).ShowDialog();
            ProjectList.Clear();
            RefreshProjectList();
        }

    }
}
