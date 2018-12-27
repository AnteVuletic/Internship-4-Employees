using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Data;

namespace Employees.Domain.Repository
{
    public class MainRepository
    {
        private Employee_Repository.EmployeeRepo _employeeRepo;
        private Project_Repository.ProjectRepo _projectRepo;
        private static Tuple<Employee,Project> mainRepository;

    }
}
