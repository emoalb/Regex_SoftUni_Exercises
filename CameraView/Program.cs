using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            String text = Console.ReadLine();
            String pattern = @"(?<=\|<.{" + input[0] + "})([^|]{0," + input[1] + "})";
            List<String> Hits = new List<string>();
            var words = Regex.Matches(text, pattern);
            foreach(Match word in words)
            {
                Hits.Add(word.Groups[1].Value);
            }
            Console.WriteLine(String.Join(", ", Hits));
        }
    }
}
