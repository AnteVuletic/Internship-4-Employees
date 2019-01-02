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

        public RelationEmployeeProject(Employee pickedEmployee, ProjectPlan pickedProject)
        {
            IdRelation++;
            EmployeeOib = pickedEmployee.Oib;
            ProjectGuid = pickedProject.Id;
        }
        public RelationEmployeeProject(Employee pickedEmployee, ProjectPlan pickedProject,int timeOnProjectWeek)
        {
            IdRelation++;
            EmployeeOib = pickedEmployee.Oib;
            ProjectGuid = pickedProject.Id;
            TimeOnProjectWeek = timeOnProjectWeek;
        }

        public int GetEmployeeHour(Employee argEmployee)
        {
            return argEmployee.Oib == EmployeeOib ? TimeOnProjectWeek : 0;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is RelationEmployeeProject))
                return false;
            return ((RelationEmployeeProject) obj).EmployeeOib == EmployeeOib &&
                   ((RelationEmployeeProject) obj).ProjectGuid == ProjectGuid;
        }
    }
}
