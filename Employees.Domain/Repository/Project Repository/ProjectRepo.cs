using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Data;

namespace Employees.Domain.Repository.Project_Repository
{
    public class ProjectRepo
    {
        private List<Project> _projectList;


        public bool AddProject(Project passedProject)
        {
            if (passedProject == null) return false;
            _projectList.Add(passedProject);
            return true;
        }

        public bool RemoveProjectById(Guid passedGuid)
        {
            foreach (var project in _projectList)
            {
                if (project.Id != passedGuid) continue;
                _projectList.Remove(project);
                return true;
            }

            return false;
        }
    }
}
