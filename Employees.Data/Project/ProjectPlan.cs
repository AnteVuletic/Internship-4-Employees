using System;

namespace Employees.Data.Project
{
    public class ProjectPlan
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        protected ProjectPlan(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}
