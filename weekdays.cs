using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
     

     
        static void Main(string[] args)
        {
            string day;
           string[] week = new string[7] { "monday", "tuesday", "wednessday", "thursday", "friday", "saturday", "sunday" };
            Console.WriteLine("type day:");
            day = Console.ReadLine();
            if(day.Contains(week[6]))
            {
                Console.WriteLine("\n false");

            }
            else
            {
                Console.WriteLine("true");
            }
} 

        }
    }

