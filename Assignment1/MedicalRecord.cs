using Assignment1.Myexception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class MedicalRecord:Patient
    {
       

        public int RecordId { get; set; }
        public double TreatmentCost { get; set; }
        public static List<MedicalRecord> MedicalRecordList= new List<MedicalRecord>();

        public void AddMedicalRecord (int recordId,int id, string? name, int age, string? diagnosis,double treatmentCost)

        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(diagnosis))
            {
                throw new InvalidPatientDataException(CustomException.exceptionmessage[4]);
            }
            else if(treatmentCost < 0)
            {
                throw new InvalidMedicalRecordException(CustomException.exceptionmessage[5]);
            }
            else
            {
                MedicalRecordList.Add(new MedicalRecord { RecordId = recordId, PatientID = id, PatientName = name, Age = age, Diagnosis = diagnosis, TreatmentCost = treatmentCost });
            }
        }
        public void DisplayDetails()
        {
            foreach (var record in MedicalRecordList)
            {
                Console.WriteLine("Record ID:" +record.RecordId + "\n" + "PatientID:" +record.PatientID + "\n" + "PatientName:" +record.PatientName + "\n" + "Diagonosis:" +record.Diagnosis + "\n" + "TreatmentCost:" +record.TreatmentCost);
            }
        }

    }
}
