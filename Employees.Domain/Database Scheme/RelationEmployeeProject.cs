using System;
using Employees.Data;
using Employees.Data.Project;

namespace Employees.Domain.Database_Scheme
{
    public class RelationEmployeeProject
    {
        public string EmployeeOib { get; set; }
        public Guid ProjectGuid { get; set; }
        public int TimeOnProject { get; set; }
        public static int IdRelation { get; private set; }

        public RelationEmployeeProject(Employee pickedEmployee, ProjectPlan pickedProject,int timeOnProject)
        {
            IdRelation++;
            EmployeeOib = pickedEmployee.Oib;
            ProjectGuid = pickedProject.Id;
            TimeOnProject = timeOnProject;
        }
    }
}
