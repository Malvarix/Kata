using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace ConsoleApp12_Training1
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(string s in dirReduce(new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" }))
            {
                Write("{0} ", s);
            }
                                     
            ReadKey();
        }

        public static string[] dirReduce(String[] arr)
        {
            Dictionary<string, string> oppositeSides = new Dictionary<string, string>()
            {
                {"NORTH","SOUTH"},
                {"SOUTH","NORTH"},
                {"WEST","EAST" },
                {"EAST","WEST" }
            };
            List<string> theBestDir = new List<string>();
            foreach(string s in arr)
            {
                if (theBestDir.LastOrDefault() == oppositeSides[s])
                    theBestDir.RemoveAt(theBestDir.Count - 1);
                else
                    theBestDir.Add(s);
            }
            return theBestDir.ToArray();
        }
    }
}