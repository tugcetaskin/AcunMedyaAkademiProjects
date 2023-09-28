using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_3_Try2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean loggedOut = true;
            double totalResult = 0;
            int i = 0;

            while (loggedOut)
            {
                Console.WriteLine("How Many Liters of Petrol Was Spent");
                double petrol = Convert.ToDouble(Console.ReadLine());

                if(petrol == -1)
                {
                    loggedOut = false;
                }
                else
                {
                    Console.WriteLine("How Many Kilometers Traveled?");
                    double km = Convert.ToDouble(Console.ReadLine());

                    double result = km / petrol;
                    totalResult += result;
                    i++;

                    Console.WriteLine("Kilometers / Liters :" + result + "\n");
                }
            }

            double average = totalResult / i;
            Console.WriteLine("\nTotal Kilometers / Liters : " + average);
            Console.ReadLine();
        }
    }
}
