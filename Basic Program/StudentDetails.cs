﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class StudentDetails
    {
        /*public StudentDetails(int rollNo, string? studName, string? city)
        {
            RollNo = rollNo;
            StudName = studName;
            City = city;
        }*/

        public int RollNo { get; set; }
        public string? StudName { get; set; }
        public string? City { get; set; }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("Roll NO:{0} \n Name :{1} \n " +
                " City:{2} ", RollNo, StudName, City);
        }
    }
}
