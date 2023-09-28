using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int correctAnswer = 1;
            int answer = 0;

            do
            {
                Console.WriteLine("İki Adet Bir Basamaklı Sayı Giriniz : ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                int number2 = Convert.ToInt32(Console.ReadLine());

                correctAnswer = number1 * number2;

                do
                {
                    Console.WriteLine(number1 + " kere " + number2 + " kaçtır?");
                    answer = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Lütfen Tekrar Deneyin.\n");
                }
                while (answer != correctAnswer);

                if(correctAnswer == answer)
                {
                    Console.WriteLine("Çok Güzel!\n");
                }
            }
            while (answer == correctAnswer);

            Console.ReadLine();
        }
    }
}
