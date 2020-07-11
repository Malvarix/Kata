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
            WriteLine(Rot13("tEst"));
            ReadKey();
        }
        public static string Rot13(string message)
        {
            char[] array = message.ToCharArray();
            for(int i = 0; i < message.Length; i++)
            {
                int index = array[i];
                if(index >= 'a' && index <= 'z')
                {
                    if (index > 'm')
                        index -= 13;
                    else
                        index += 13;
                }
                else if(index >= 'A' && index <= 'Z')
                {
                    if (index > 'M')
                        index -= 13;
                    else
                        index += 13;
                }
                array[i] = (char)index;
            }
            return string.Concat(array);
        }
    }
}