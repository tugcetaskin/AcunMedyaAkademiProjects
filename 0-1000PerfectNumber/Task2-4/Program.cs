using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_4
{
    internal class Program
    {
        static void divisor(int number)
        {
            Console.WriteLine("Sayının Bölenleri : ");

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void perfectNumber(int number)
        {
            int total = 0;
            int i;

            for (i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    total += i;
                }
            }

            if (total == number)
            {
                //Console.WriteLine("\nSayı Mükemmel Sayıdır!\n");
                Console.Write(number);
                divisor(number);
            }         
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Sayı Giriniz : ");
            //int number = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < 1000; ++i)
            {
                perfectNumber(i);
            }

            //perfectNumber(number);

            Console.ReadLine();
        }
    }
}
