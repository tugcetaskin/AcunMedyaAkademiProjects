using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizi Boyutunu Giriniz");
            int lenght = Convert.ToInt32(Console.ReadLine());

            //int[] arr = {1, 5, 7, 1, 4, 1, 5, 9, 12, 9, 1};
            int[] arr = new int[lenght];

            for(int z=0; z<lenght; z++)
            {
                Console.WriteLine("Dizinin " + (z+1) + ". elemanını giriniz :");
                int arrNum = Convert.ToInt32(Console.ReadLine());

                arr[z] = arrNum;
            }
            int num = arr.Length;
            int i, j, k, x;


            for (i = 0; i < num; i++)
            {
                for (j = i + 1; j < num; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        for(x = j; x < num - 1; x++)
                        {
                            arr[x] = arr[x + 1];
                        }
                    }                  
                }
                Array.Resize(ref arr, num--);
                x = j;
            }

            Console.WriteLine("Yeni Dizi : ");

            foreach(var element in arr)
            {
                Console.WriteLine(element);
            }

            Console.ReadLine();
        }
    }
}
