using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int add, mult, avarege, largestNum, smallestNum;

            Console.WriteLine("Enter The First Integer :");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Second Integer :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Third Integer :");
            int num3 = Convert.ToInt32(Console.ReadLine());

            add = num1 + num2 + num3;
            mult = num1 * num2 * num3;
            avarege = (num1 + num2 + num3) / 3;
            largestNum = 0;
            smallestNum = 0;

            Console.WriteLine($"Sum Of Numbers : {add}\n" +
                $"Multiplication Of Numbers : {mult}\n" +
                $"Avarege Of Numbers : {avarege}");

            if(num1 > largestNum)
            {
                largestNum = num1;

                if(num2 > num1)
                {
                    largestNum = num2;
                    if(num1 > num3)
                    {
                        smallestNum = num3;
                    }
                    else
                    {
                        smallestNum = num1;
                    }
                }

                if(num3 > num2)
                {
                    largestNum = num3;
                    if (num1 > num2)
                    {
                        smallestNum = num2;
                    }
                    else
                    {
                        smallestNum = num1;
                    }
                }

                if (num3 > num2)
                {
                    smallestNum = num2;
                }
                else
                {
                    smallestNum = num3;
                }

            }

            Console.WriteLine("Largest Number :" + largestNum + "\n" +
                   "Smallest Number :" + smallestNum);

            //if(num1 > num2 && num1 > num3 && num2 > num3)
            //{
            //    Console.WriteLine("Largest Number :" + num1 + "\n" +
            //        "Smallest Number :" + num3);
            //}

            //if (num1 > num2 && num1 > num3 && num2 < num3)
            //{
            //    Console.WriteLine("Largest Number :" + num1 + "\n" +
            //        "Smallest Number :" + num2);
            //}

            //if (num2 > num1 && num2 > num3 && num1 > num3)
            //{
            //    Console.WriteLine("Largest Number :" + num2 + "\n" +
            //        "Smallest Number :" + num3);
            //}

            //if (num2 > num1 && num2 > num3 && num1 < num3)
            //{
            //    Console.WriteLine("Largest Number :" + num2 + "\n" +
            //        "Smallest Number :" + num1);
            //}

            //if (num3 > num2 && num3 > num1 && num2 > num1)
            //{
            //    Console.WriteLine("Largest Number :" + num3 + "\n" +
            //        "Smallest Number :" + num1);
            //}

            //if (num3 > num2 && num3 > num1 && num2 < num1)
            //{
            //    Console.WriteLine("Largest Number :" + num3 + "\n" +
            //        "Smallest Number :" + num2);
            //}

            Console.ReadLine();
        }
    }
}
