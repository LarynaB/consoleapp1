using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doit = false;
            string str = "Hello";

            Console.WriteLine("Checking status...");

            if (doit)
            {
                doit = false;
                Console.WriteLine("set to false");
            }

            Console.ReadKey();
        }
    }
}
