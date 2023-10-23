using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Employee : Person, IDisplayable
    {
        public Employee(int age, string? firstName, string? lastName, int eid) : base(age, firstName, lastName)
        {
            Eid = eid;
        }

        public int Eid { get; set; }

        public void DispayInfo(int age)
        {
            if (Age >= 18 && Age<=100)
            {   

                Console.WriteLine($"Employee_ID:{Eid}\nEmployee Name:{FirstName} {LastName}\nAge:{Age} \n ");
            }
        }

        
    }
}

