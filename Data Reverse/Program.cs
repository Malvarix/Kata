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
		
        }
        public static int[] DataReverse2(int[] data) // DataReverse = DataReverse2, but it's smarter than DataReverse
        {
            int[] bits = data;
            for(int i = 0; i < data.Length; i += 8)
            {
                Array.Reverse(bits, i, 8);
            }
            Array.Reverse(bits);
            return bits;
        }
        public static int[] DataReverse(int[] data)
        {
            string results = string.Join("", data);
            int temp1 = 0;
            string temp2 = "";
            List<string> temp3 = new List<string>();
            for(int i = 0; i < results.Length; i++)
            {
                if(temp1 != 7)
                {
                    temp2 += results[i];
                    temp1++;
                }
                else if(temp1 == 7)
                {
                    temp2 += results[i];
                    temp3.Add(temp2);
                    temp2 = "";
                    temp1 = 0;
                }
            }
            temp3.Reverse();
            List<int> res = new List<int>();
            foreach(string s in temp3)
            {
                foreach(char c in s)
                {
                    res.Add(Int32.Parse(c.ToString()));
                }
            }
            return res.ToArray(); 
        }
    }
}