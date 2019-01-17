using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Employees.Data.Enums;

namespace Employees.Data
{
    public class Employee
    {
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Oib { get; set; }
        public DateTime DateBirth { get; set; }
        public Position Position { get; set; }
        public string SecondForename { get; set; }

        public Employee(string forename, string surname, string oib, DateTime dateBirth,Position position)
        {
            Forename = forename;
            Surname = surname;
            Oib = oib;
            DateBirth = dateBirth;
            Position = position;
        }
        public Employee(string forename,string surname,string oib,DateTime dateBirth,Position position,string secondForename)
        {
            Forename = forename;
            Surname = surname;
            Oib = oib;
            DateBirth = dateBirth;
            Position = position;
            SecondForename = secondForename;
        }

        public override string ToString()
        {
            var hasSecond = SecondForename != null;
            return $"OIB: {Oib} | Name: {Forename}" + (hasSecond ? $"| Second name: {SecondForename}" : " ") +
                    $"| Surname:{Surname} | Position: {Position.ToString()} | Birthday: {DateBirth:MM/dd/yyyy} ";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj) || obj.ToString() == ToString();
        }
    }
}
