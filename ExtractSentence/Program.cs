using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string inputText = Console.ReadLine();
            string reg = $@"\b[^?.!]*\b{input}\b[^?.!]*";
            string pattern =reg;
            foreach (Match m in Regex.Matches(inputText, pattern))
            {
                Console.WriteLine("{0}", m.Value);
            }
        }
    }
}
