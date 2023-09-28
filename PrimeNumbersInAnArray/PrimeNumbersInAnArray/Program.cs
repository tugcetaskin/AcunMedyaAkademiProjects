using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbersInAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizi Boyutunu Giriniz :");
            int lenght = Convert.ToInt32(Console.ReadLine());
            int[] numberlist = new int[lenght];
            int totalMultip = 0;
            int Primenumbertotal = 0;

            for (int i = 0; i < numberlist.Length; i++)
            {
                Console.WriteLine((i + 1) + " enter the numbers");
                int number = Convert.ToInt32(Console.ReadLine());

                numberlist[i] = number;
            }

            for (int i = 0; i < numberlist.Length; i++)
            {
                totalMultip = 0;

                for (int x = 1; x <= numberlist[i]; x++)
                {
                    if (numberlist[i] % x == 0)
                    {
                        totalMultip += x;
                    }
                }

                if (totalMultip == 1 + numberlist[i])
                {
                    Primenumbertotal += numberlist[i];
                }
            }



            Console.WriteLine("total the prime number = " + Primenumbertotal);
            Console.ReadLine();
        }
    }
}
