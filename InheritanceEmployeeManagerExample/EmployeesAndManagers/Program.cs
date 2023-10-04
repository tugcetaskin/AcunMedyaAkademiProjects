using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAndManagers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Fatih Kara", "2017.10.10", 7500 );
            Employee emp2 = new Employee("Betül Kalaycı", "2020.09.15", 8900);
            Manager mng1 = new Manager("Hatice Kaya", "2015.09.05", 15000, 20);

            Console.WriteLine(mng1.FullName);
            Console.WriteLine(emp1.Salary);

            Console.ReadLine();
        }
    }
}
