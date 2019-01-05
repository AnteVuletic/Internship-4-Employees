using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Employees.Infrastructure.Extension
{
    public static class OibExtension
    {
        public static bool TryOib(out string destination, string input)
        {
            input = input.Trim();
            var ifMatch = Regex.Match(input, @"[^0-9]");
            if (ifMatch.Length != 0)
            {
                input = Regex.Replace(input, @"[^0-9]", "");
                destination = input;
            }
            switch (input.Length)
            {
                case 11:
                    destination = input;
                    return true;
                default:
                    destination = input;
                    return false;
            }
        }
    }
}
