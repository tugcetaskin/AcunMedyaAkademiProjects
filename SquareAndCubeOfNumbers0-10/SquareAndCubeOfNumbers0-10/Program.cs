using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number\tSquare\tCube\n\n");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + "\t" + i*i + "\t" + i*i*i);
            }

            Console.ReadLine();
        }
    }
}
