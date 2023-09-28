using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktoriyel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 1;
            Console.WriteLine("Faktoriyelini bulmak istediğiniz sayıyı giriniz :");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                result *= i;
            }
            Console.WriteLine(num + "! = " + result);
            Console.ReadLine();
        }
    }
}
