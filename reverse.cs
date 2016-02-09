using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
           string input = "reverse";
            char[] inputarray = input.ToCharArray();
            Array.Reverse(inputarray);
            
            string output = new string(inputarray);

            string output1 = output.Replace("a", string.Empty)
                                     .Replace("e", string.Empty)
                                     .Replace("i", string.Empty)
                                     .Replace("o", string.Empty)
                                     .Replace("u", string.Empty)
                                     .Replace("y", string.Empty);
                       Console.WriteLine("op1\t\t{0}", output);
 
            Console.WriteLine("op2\t\t{0}", output1);

  }
    }
}
