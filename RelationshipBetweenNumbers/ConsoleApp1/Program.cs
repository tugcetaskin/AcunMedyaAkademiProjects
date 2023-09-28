using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci sayıyı giriniz :");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 == num2) 
            {
                Console.WriteLine("Num1 Num2'ye eşittir.");
            }
            if(num2 != num1)
            {
                Console.WriteLine("Num1 Num2'ye eşit değildir.");
            }
            if (num1 > num2)
            {
                Console.WriteLine("Num1 Num2'den büyüktür.");
            }
            if( num2 > num1)
            {
                Console.WriteLine("Num1 Num2'den küçüktür.");
            }
            if (num1 >= num2)
            {
                Console.WriteLine(num1 + " >= " + num2);
            }
            if (num2 >= num1)
            {
                Console.WriteLine(num1 + " <= " + num2);
            }

            Console.ReadLine();
        }
    }
}
