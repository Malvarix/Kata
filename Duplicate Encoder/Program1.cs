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
            WriteLine(DuplicateEncode("(( @"));
            ReadKey();
        }
        public static string DuplicateEncode(string word)
        {
            char[] temp = word.ToLower().ToCharArray();
            string result = "";
            for(int i = 0; i < temp.Length; i++)
            {
                if (temp.Count(x => x == temp[i]) > 1)
                    result += ')';
                else if (temp.Count(x => x == temp[i]) <= 1)
                    result += '(';
            }
            return result;
        }
    }
}
