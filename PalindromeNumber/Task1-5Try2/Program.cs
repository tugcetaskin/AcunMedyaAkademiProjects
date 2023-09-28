using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_5Try2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int lenght = 0;
            int temp = number;
            Boolean isPalindrome = true;

            while (temp != 0)
            {
                temp /= 10;
                lenght++;
            }
            temp = number;

            int[] digit = new int[lenght];

            for(int y = 0; y < lenght; y++)
            {
                digit[y] = temp % 10;
                temp /= 10;
            }

            for(int i = 0; i < lenght / 2; i++)
            {
                if (digit[i] == digit[lenght - 1])
                {
                    i++;
                    lenght--;
                }
                else
                {
                    isPalindrome = false;
                }
            }
            if (isPalindrome == true)
            {
                Console.WriteLine("The Number is the Palindrome Number.");
            }
            else
            {
                Console.WriteLine("The Number is Not the Palindrome Number.");
            }
            Console.ReadLine();
        }
    }
}
