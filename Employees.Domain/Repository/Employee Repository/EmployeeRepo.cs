using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Data;

namespace Employees.Domain.Repository.Employee_Repository
{
    public class EmployeeRepo
    {
        private List<Employee> _employeeList;

        public bool AddEmployee(Employee passedEmployee)
        {
            if (passedEmployee == null) return false;
            _employeeList.Add(passedEmployee);
            return true;
        }

        public bool RemoveByOib(string oib)
        {
            foreach (var employee in _employeeList)
            {
                if (employee.Oib != oib) continue;
                _employeeList.Remove(employee);
                return true;
            }

            return false;
        }
    }
}
