using System;

namespace Employees.Data.Project
{
    public class ProjectPlan
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ProjectPlan(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public override string ToString()
        {
            return $"Name: {Name}";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj) && obj.ToString() == ToString();
        }
    }
}
