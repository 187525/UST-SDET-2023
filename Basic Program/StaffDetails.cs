using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    class StaffDetails
    {
        public int staffid { get; set; }
        public string? Name { get; set; }
        public  string? Dept { get; set; }

        public void DisplayStaffDetails()
        {
            Console.WriteLine("ID : {0} \n Name : {1}\n" +
               "dept:{2} \n", staffid,Name,Dept);
        }
    }
}
