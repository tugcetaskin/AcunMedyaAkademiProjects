using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAndManagers
{
    internal class Manager : Employee
    {
        int numberOfPeopleManaged;

        public Manager(string fullName, string dateOfStart, int salary, int numberOfPeopleManaged) : base(fullName, dateOfStart, salary)
        {
            this.numberOfPeopleManaged = numberOfPeopleManaged;
        }
    }
}
