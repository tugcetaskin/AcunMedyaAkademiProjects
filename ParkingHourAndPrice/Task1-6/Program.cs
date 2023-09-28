using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] parkingHour = new double[3];
            int y = 1;
            double price;
            double totalHour = 0;
            double totalPrice = 0;

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Parking Hour : ");
                double hour = Convert.ToDouble(Console.ReadLine());
                parkingHour[i] = hour;
                totalHour += hour;
            }

            Console.WriteLine("\n\nCar\tHour\tPrice");

            for(int i = 0;i < 3;i++)
            {
                if (parkingHour[i] <= 3)
                {
                    price = 2;
                }
                else
                {
                    parkingHour[i] = Math.Ceiling(parkingHour[i]);
                    price = 2 + ((parkingHour[i] - 3) * 0.5);
                    if(price > 10)
                    {
                        price = 10;
                    }
                }
                totalPrice += price;

                Console.WriteLine(y + "\t" + parkingHour[i] + "\t" + price);
            }
            Console.WriteLine("Total\t" +  totalHour + "\t" + totalPrice);
            Console.ReadLine();
        }
    }
}
