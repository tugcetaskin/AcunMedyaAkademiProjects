using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestAndSmallestNumberInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizi Boyutunu Giriniz :");
            int lenght = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[lenght];
            int biggest = 0, smallest = 0;

            for(int i = 0; i < lenght; i++)
            {
                Console.WriteLine((i + 1) + ". Elemanı Giriniz :");
                int number = Convert.ToInt32(Console.ReadLine());

                array[i] = number;

                if(i == 0)
                {
                    biggest = number;
                    smallest = number;
                }
                if(number < smallest)
                {
                    smallest = number;
                }
                if (number > biggest)
                {
                    biggest = number;
                }
            }
            Console.WriteLine("Dizideki En Büyük Sayı : " + biggest);
            Console.WriteLine("Dizideki En Küçük Sayı : " + smallest);

            Console.ReadLine();
        }
    }
}
