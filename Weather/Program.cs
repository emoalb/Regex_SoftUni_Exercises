using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Weather
{
    class Program
    {
       
        static void Main(string[] args)
        {
            SortedDictionary<String, KeyValuePair<float,String>> cityinfo = new SortedDictionary<String, KeyValuePair<float, String>>();
           // List<string> weather = new List<string>();
            bool isEnd = false;
            String pattern = @"([A-Z]{2})([0-9]{1,2}.[0-9]{1,2})([A-Za-z]+)\|";
            do
            {
                String input = Console.ReadLine();
            var match =   Regex.Matches(input, pattern);
                foreach(Match w in match)
                {
                    var city = w.Groups[1].Value;
                    var temp = w.Groups[2].Value;
                    var typWeather= w.Groups[3].Value;
                    
                    cityinfo[city] = new KeyValuePair<float, string>(float.Parse(temp), typWeather);          

                }
                if (input == "end")
                {
                    isEnd = true;
                }
            } while (!isEnd);
            var Sorted = cityinfo.OrderBy(x => x.Value.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var w in Sorted)
            {
                Console.WriteLine($"{w.Key} => {w.Value.Key:f2} => {w.Value.Value}");
            }
        }
    }
}
