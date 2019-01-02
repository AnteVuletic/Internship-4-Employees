using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public int GetIndexOfRelation(RelationEmployeeProject argRelation)
        {
            for (var relationIndex = 0; relationIndex < RelationEmployeeProject.Count; relationIndex++)
            {
                if (!RelationEmployeeProject[relationIndex].Equals(argRelation)) continue;
                return relationIndex;
            }
            throw new Exception("Relation not found");
        }
    }
}
