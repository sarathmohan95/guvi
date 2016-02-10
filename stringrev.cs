using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rex
{
    public class Program
    {
        public static void Main(string[] args)
        {
             string input = "reverse";
            char[] inputarray = input.ToCharArray();
            Array.Reverse(inputarray);
            
            string output = new string(inputarray);

            Console.WriteLine("{0}", output);
 
          
        }
    }
}
