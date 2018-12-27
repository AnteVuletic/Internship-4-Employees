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
        private static EmployeeRepo _dataEmployees;
        private static ProjectRepo _dataProjects;
        private static List<RelationEmployeeProject> _relationEmployeeProject;

        public MainRepository()
        {
            _dataEmployees = new EmployeeRepo();
            _dataProjects = new ProjectRepo();
            _relationEmployeeProject = new List<RelationEmployeeProject>();          
        }
    }
}
