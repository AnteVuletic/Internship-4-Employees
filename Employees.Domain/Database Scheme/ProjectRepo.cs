using System;
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
        public bool RemoveProjectByName(string passedName)
        {
            foreach (var project in ProjectList)
            {
                if (project.Name != passedName) continue;
                ProjectList.Remove(project);
                return true;
            }

            return false;
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

        public List<ProjectPlan> GetAllProjects => ProjectList;
    }
}
