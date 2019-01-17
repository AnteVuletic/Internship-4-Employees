using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Employees.Infrastructure.Extension
{
    public static class NameExtension
    {
        public static bool TryName(out string destination, string input)
        {
            input = input.Trim();
            var isMatch = Regex.Match(input, @"[^a-zA-Z]");
            if (isMatch.Length !=0)
            {
                input = Regex.Replace(input, @"[^a-zA-Z]", "");
                destination = input;
                return false;
            }
            if (input.Length == 0)
            {
                destination = " ";
                return false;
            }
            if (input.Length >= 16)
            {
                destination = input.Substring(0, 16);
                return false;
            }

            if (input.Length >= 2)
            {
                input = input.ToLower();
                input = input.First().ToString().ToUpper() + string.Join("", input.Skip(1));
                destination = input;
                return true;
            }

            destination = input;
            return false;
        }
    }
}
