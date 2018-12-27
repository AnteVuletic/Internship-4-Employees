using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Data.Project
{
    public sealed class Project : ProjectPlan
    {
        public bool IsActive { get; set; }
        public bool IsFinished { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Project(string name, DateTime startDate, DateTime endDate,bool isActive, bool isFinished) : base(name)
        {
            StartDate = startDate;
            EndDate = endDate;
            IsActive = isActive;
            IsFinished = isFinished;
        }
    }
}
