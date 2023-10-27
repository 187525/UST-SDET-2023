using Assignment1.Myexception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment1
{
    internal class Patient
    {
        public int PatientID { get; set; }
        public string? PatientName { get; set; }

        public int Age { get; set; }

        public string? Diagnosis { get; set; }

        List<Patient> patients = new List<Patient>();
        public void AddPatient(int id, string? name, int age, string? diagnosis)
        {

            if (string.IsNullOrEmpty(name))
            {
                throw new MyExceptions(CustomException.exceptionmessage[2]);
            }
            else if (age < 0 || age >= 120)
            {
                throw new MyExceptions(CustomException.exceptionmessage[1]);
            }
            else if (string.IsNullOrEmpty(diagnosis))
            {
                throw new MyExceptions(CustomException.exceptionmessage[3]);
            }
            else
            {
                patients.Add(new Patient { PatientID = id, PatientName = name, Age = age, Diagnosis = diagnosis });

            }
        }
        public void AddPatientTextfile(int id,string name,int age,string? diagnosis)
        {
            FileStream filestream=new FileStream("C:\\Users\\Administrator\\Desktop\\Files\\Patient.txt",FileMode.Create,FileAccess.Write);
            StreamWriter writer=new StreamWriter(filestream);
            writer.WriteLine("Patient ID:" + id);
            writer.WriteLine("Patient Name:" + name);
            writer.WriteLine("age:" + age);
            writer.WriteLine("Diagnosis:" + diagnosis);
            writer.Close();
            filestream.Close();
        }
       

        public void ReadDeatils()
        {
            FileStream filestream=new FileStream("C:\\Users\\Administrator\\Desktop\\Files\\Patient.txt",FileMode.Open,FileAccess.Read);
            StreamReader reader=new StreamReader(filestream);   
            string? str=reader.ReadToEnd();
            Console.WriteLine();
            reader.Close();
            filestream.Close ();


        }
        

    }
}
