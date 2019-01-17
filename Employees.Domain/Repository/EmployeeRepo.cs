using System.Collections.Generic;
using Employees.Data;

namespace Employees.Domain.Database_Scheme
{
    public class EmployeeRepo
    {
        private static List<Employee> EmployeeList = new List<Employee>();

        public bool AddEmployee(Employee passedEmployee)
        {
            if (passedEmployee == null) return false;
            EmployeeList.Add(passedEmployee);
            return true;
        }

        public bool RemoveByOib(string oib)
        {
            foreach (var employee in EmployeeList)
            {
                if (employee.Oib != oib) continue;
                EmployeeList.Remove(employee);
                return true;
            }

            return false;
        }

        public Employee GetByOib(string argOib)
        {
            foreach (var employee in EmployeeList)
            {
                if (employee.Oib == argOib)
                    return employee;
            }

            return null;
        }
        public List<Employee> GetAllEmployees() => EmployeeList;
    }
}
