using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class NonTeachingStaff:StaffDetails
    {
        public string? Resposibilities { get; set; }
        public int Experience { get; set; }
        public void DisplayTStaffDetails()
        {
            Console.WriteLine("Responsibility : {0} \n Experience: {1} \n",
                Resposibilities, Experience);

        }
    }
}
