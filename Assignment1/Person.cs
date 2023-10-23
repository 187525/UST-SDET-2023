using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Person
    {
            private string? firstName;
            private string? lastName;
            int age;

        public Person(int age, string? firstName, string? lastName)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }

        
        public string? FirstName { get => firstName; set => firstName = value; }
        public string? LastName { get => lastName; set => lastName = value; }
        public int Age 
        {
            get => age;

            set 
            {

                if (value >= 18 && value <= 100)
                {
                    age = value;


                }
                else
                {
                    Console.WriteLine("Enter age between 18 and 100");
                }

                
            }
        }
    }
}
