using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EinfacheSchleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            // While-Schleifen
            int number = 1;

            while (number += 5)
            {
                Console.WriteLine(number);
                number += 1;
            }

            Console.ReadKey();
        }
    }
}
