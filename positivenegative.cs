using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginner1
{
    class Program
    {
  

        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("\n enter num:");
            num =Convert.ToInt32(Console.ReadLine());
            if(num == 0)
            {
                Console.WriteLine("\n Zero");
            }
            else if(num < 0)
            {
                Console.WriteLine("\n Negative");
            }
            else
            {
                Console.WriteLine("\n positive");
            }
        }
    }
}
