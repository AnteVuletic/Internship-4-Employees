using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Infrastructure.Extension
{
    public class ProjectNameExtension
    {
        public static bool TryProjectName(out string destination, string input)
        {
            destination = input.Trim();
            destination = destination[0].ToString().ToUpper() +
                          string.Join("", destination.Skip(1));
            return true;
        }
    }
}
