using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailChecker
{
    class Program
    {
        static void Main(string[] args)
        {
      string pattern = "^|\\s[a-z0-9][\\.\\_\\-a-z0-9]*[a-z0-9]@[a-z0-9][\\.\\-a-z0-9]*[a-z0-9]\\.[a-z]{2,}";
            string input = Console.ReadLine();

                foreach (Match m in Regex.Matches(input, pattern))
                {
                    Console.WriteLine("{0}", m.Value);
                }
            }
        }

    }

