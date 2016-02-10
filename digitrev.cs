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
            string num = "2345";
            char[] numarr = num.ToCharArray();
            Array.Reverse(numarr);
            string op = new string(numarr);
            Console.WriteLine("\n reversed digit:{0}", op);
            

           
 
          
        }
    }
}
