﻿using System;
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

        public override string ToString()
        {
            return base.ToString() + (IsActive ? " | Active" : " | Not Active") + (IsFinished ? " | Project finished" : " | Project being worked on") 
                   + $" | Start date: {StartDate:MM/dd/yyyy}"  + $" | End date: {EndDate:MM/dd/yyyy}";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj) && obj.ToString() == ToString();
        }
    }
}
