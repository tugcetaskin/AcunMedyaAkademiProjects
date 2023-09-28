using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            for(int i = 2; i <= 30; i += 2)
            {
                total += i;
            }

            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
