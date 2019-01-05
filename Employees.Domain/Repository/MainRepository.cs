using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Data.Project;
using Employees.Domain.Database_Scheme;

namespace Employees.Domain.Repository
{
    public class MainRepository
    {
        public EmployeeRepo DataEmployees { get; set; }
        public ProjectRepo DataProjects { get; set; }
        public List<RelationEmployeeProject> RelationEmployeeProject { get; set; }

        public MainRepository()
        {
            DataEmployees = new EmployeeRepo();
            DataProjects = new ProjectRepo();
            RelationEmployeeProject = new List<RelationEmployeeProject>();          
        }

        public int GetHoursByEmployee(string argOib)
        {
            var sumOfHours = 0;
            foreach (var relationEmployeeProject in RelationEmployeeProject.FindAll(project => project.EmployeeOib == argOib))
            {
                sumOfHours += relationEmployeeProject.TimeOnProjectWeek;
            }

            return sumOfHours;
        }

        public string GetNumberFinishedProjectsByEmployee(string argOib)
        {
            var sumOfFinished = 0;
            foreach (var relationEmployeeProject in RelationEmployeeProject.FindAll(project => project.EmployeeOib == argOib))
            {
                if (!(DataProjects.GetProjectById(relationEmployeeProject.ProjectGuid) is Project realProject))
                    continue;
                if (realProject.IsFinished)
                    sumOfFinished++;
            }

            return sumOfFinished.ToString("G");
        }

        public string GetNumberActiveProjectsByEmployee(string argOib)
        {
            var sumOfActive = 0;
            foreach (var relationEmployeeProject in RelationEmployeeProject.FindAll(project => project.EmployeeOib == argOib))
            {
                if (!(DataProjects.GetProjectById(relationEmployeeProject.ProjectGuid) is Project realProject))
                    continue;
                if (realProject.IsActive)
                    sumOfActive += 1;
            }

            return sumOfActive.ToString("G");
        }
        public int GetNumberOfRelationsOfProject(Guid projectId)
        {
            var counterOfProjects = 0;
            foreach (var relationEmployeeProject in RelationEmployeeProject)
            {
                if (!(relationEmployeeProject.ProjectGuid == projectId)) continue;
                counterOfProjects++;
            }

            return counterOfProjects;
        }
    }
}
