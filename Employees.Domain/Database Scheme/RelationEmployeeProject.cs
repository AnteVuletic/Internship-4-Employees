using System;
using Employees.Data;
using Employees.Data.Project;

namespace Employees.Domain.Database_Scheme
{
    public class RelationEmployeeProject
    {
        public string EmployeeOib { get; set; }
        public Guid ProjectGuid { get; set; }
        public int TimeOnProjectWeek { get; set; }
        public static int IdRelation { get; private set; }

        public RelationEmployeeProject(Employee pickedEmployee, ProjectPlan pickedProject,int timeOnProjectWeek)
        {
            IdRelation++;
            EmployeeOib = pickedEmployee.Oib;
            ProjectGuid = pickedProject.Id;
            TimeOnProjectWeek = timeOnProjectWeek;
        }

    }
}
