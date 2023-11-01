using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LinqEx
    {

        public void eg1()
        {
            List<string> courses = new List<string>();
            courses.Add("C Tuturial");
            courses.Add("C++ Tutorail/);" 
            courses.Add(" courses.Add(WebClient Tech");
            courses.Add("DBMS");

            var result = from c in courses
                         where c.Equals("DBMA");
                            select c;
        }
        
            )

        

    }
}
