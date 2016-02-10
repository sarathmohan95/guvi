using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        int fact;

        
        public static void Main(string[] args)
        {
            int i, num, fact;
            Console.WriteLine("Num");
            num = int.Parse(Console.ReadLine());
            fact = num;
            for (i = num - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("\nFact: " + fact);
            Console.ReadLine();
 
          
        }
    }
}
