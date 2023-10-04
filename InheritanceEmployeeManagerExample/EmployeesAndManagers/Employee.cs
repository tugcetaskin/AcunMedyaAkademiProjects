using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAndManagers
{
    internal class Employee
    {
        private string fullName;
        private string dateOfStart;
        private int salary;

        public Employee(string fullName, string dateOfStart, int salary)
        {
            this.fullName = fullName;
            this.dateOfStart = dateOfStart;
            this.salary = salary;
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string DateOfStart
        {
            get { return dateOfStart; }
            set { dateOfStart = value; }
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
