﻿using System;
using System.Collections.Generic;
using Employees.Data;
using Employees.Data.Project;

namespace Employees.Domain.Database_Scheme
{
    public class ProjectRepo
    {
        public static List<ProjectPlan> ProjectList = new List<ProjectPlan>();


        public bool AddProject(ProjectPlan passedProject)
        {
            if (passedProject == null) return false;
            ProjectList.Add(passedProject);
            return true;
        }
        public ProjectPlan GetProjectByName(string argProjectName)
        {
            foreach (var projectPlan in ProjectList)
            {
                if (projectPlan.Name == argProjectName)
                {
                    return projectPlan;
                }
            }

            return null;
        }
        public ProjectPlan GetProjectById(Guid argId)
        {
            foreach (var projectPlan in ProjectList)
            {
                if (projectPlan.Id == argId)
                {
                    return projectPlan;
                }
            }

            return null;
        }
        public bool RemoveProjectById(Guid passedGuid)
        {
            foreach (var project in ProjectList)
            {
                if (project.Id != passedGuid) continue;
                ProjectList.Remove(project);
                return true;
            }

            return false;
        }

        public List<ProjectPlan> GetAllProjects() => ProjectList;
    }
}
