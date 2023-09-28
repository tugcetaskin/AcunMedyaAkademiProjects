using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veriyi giriniz : ");
            int data = Convert.ToInt32(Console.ReadLine());

            int tmp;
            int rew = 0;
            int swap;
            int[] newNumber = new int[4];

            for(int i = 0; i < 4; i++)
            {
                tmp = data % 10;
                rew = (rew * 10) + tmp;
                data /= 10;
            }

            //Console.WriteLine("Rew : " + rew);

            for(int i = 0; i < 4; i++)
            {
                tmp = rew % 10;
                tmp += 7;
                if(tmp > 9)
                {
                    tmp %= 10;
                }
                newNumber[i] = tmp;
                rew /= 10;
            }

            //Console.WriteLine("Dizi : " + newNumber[0] + " " + newNumber[1] + " " + newNumber[2] + " " + newNumber[3]);

            for(int i = 0; i < 2; i++)
            {
                swap = newNumber[i];
                newNumber[i] = newNumber[i + 2];
                newNumber[i + 2] = swap;
            }

            Console.WriteLine("Şifrelenmiş Sayı : ");

            foreach(int sayi in newNumber)
            {
                Console.WriteLine(sayi);
            }

            //Şifrelenmiş Sayıları Eski Haline Çevirme

            for(int i =0; i < 2; i++)
            {
                swap = newNumber[i];
                newNumber[i] = newNumber[i + 2];
                newNumber[i + 2] = swap;
            }

            for(int i = 0; i < 4; i++)
            {
                newNumber[i] -= 7;
                if (newNumber[i] < 0)
                {
                    newNumber[i] += 10;
                }
            }

            Console.WriteLine("\nGerçek Sayı : ");

            foreach (int sayi in newNumber)
            {
                Console.WriteLine(sayi);
            }

            Console.ReadLine();
        }
    }
}
