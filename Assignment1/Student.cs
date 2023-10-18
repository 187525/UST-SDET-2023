using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Student
    {

        public double mark1, mark2, mark3;
        public String? studentname;
        public char grade;

        public Student(double mark1, double mark2, double mark3, string? studentname)
        {

            this.mark1 = mark1;
            this.mark2 = mark2;
            this.mark3 = mark3;
            this.studentname = studentname;

        }

        public double CalculateAverage()
        {
            double avg = (mark1 + mark2 + mark3) / 3;
            if (avg >= 90)
            {
                Console.WriteLine("grade = A");
            }
            else if (avg >= 80 && avg < 90)
            {
                Console.WriteLine("grade = B");
            }
            else if (avg >= 70 && avg < 80)
            {
                Console.WriteLine("grade= C");

            }
            else
            {
                Console.WriteLine("Grade=D");
            }
            return avg;

        }
    }
}
