using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.Text.RegularExpressions;

namespace ConsoleApp12_Training1
{
    class Program
    {
        static void Main(string[] args)
        {      
		
            ReadKey();
        }
        public static int CountSmileys(string[] smileys)
        {
            int result = 0;
            foreach(string s in smileys)
            {
                if (Regex.IsMatch(s, @"^(:|;)(?:-|~)?(\)$|D)$"))
                    result++;
            }
            return result;
        }
		
		public static int CountSmileys2(string[] smileys) // second version better than first, if you use know how to use linq
        {
			return smileys.Count(s => Regex.IsMatch(s, @"^(:|;)(?:-|~)?(\)$|D)$"));
        }
    }
}