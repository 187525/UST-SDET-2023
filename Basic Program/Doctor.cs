
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    
    
    class Doctor :IDoctor, IAppointment

    {
        public int Did { get; set; }
        public  string? DName { get; set; }

        public void AddNewDoctor()
        {
            Did = 1234; DName = "AAA";

        }

        public void ModifyDoctor()
        {
            Did = 7890; DName = "BBB";
        }

        public void DisplayDoctorDetails() 
        {
            Console.WriteLine($"Did :{Did}\n Doctor Name:{DName} ");
        }

        public void BookApp(int did,string? pname)
        {
            Console.WriteLine("Booked app for {0} with doctor {1}", pname, did);

        }
        public void DelApp(string? pname)
        {
            Console.WriteLine("Canceled app for {0} with doctor", pname);

        }

        public void DelApp(int did, string pname)
        {
            Console.WriteLine("Canceled app for {0} with doctor {1}", pname);

        }
    }

}
