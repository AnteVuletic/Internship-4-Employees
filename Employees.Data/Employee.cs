using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Data
{
    public class Employee
    {
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Oib { get; set; }
        public DateTime DateBirth { get; set; }
        public string SecondForename { get; set; }

        public Employee(string forename, string surname, string oib, DateTime dateBirth)
        {
            Forename = forename;
            Surname = surname;
            Oib = oib;
            DateBirth = dateBirth;
        }
        public Employee(string forename,string surname,string oib,DateTime dateBirth,string secondForename)
        {
            Forename = forename;
            Surname = surname;
            Oib = oib;
            DateBirth = dateBirth;
            SecondForename = secondForename;
        }
    }
}
