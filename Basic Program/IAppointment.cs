using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal interface IAppointment
    {
        void BookApp(int Did,string pname);
        void DelApp(int did,string pname);  

    }
}
