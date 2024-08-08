using DataAccessLayer;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class clsPrescription
    {

        public int prescriptionID { get; set; }
        public string medicationName { get; set; }
        public string dosage { get; set; }
        public string frequency { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }   

        public string specialInstructions { get; set; }

        public clsPrescription()
        {
            this.prescriptionID = -1;
            this.medicationName = "";
            this.dosage = "";
            this.frequency = "";
            this.startDate = DateTime.Now;
            this.endDate = DateTime.Now;
            this.specialInstructions = "";

        }

        private clsPrescription(string medicationName , string dosage , string frequency , DateTime startDate , DateTime endDate , string specialInstructions)
        {
            this.medicationName = medicationName;
            this.dosage = dosage;
            this.frequency = frequency;
            this.startDate = startDate;
            this.endDate = endDate;
            this.specialInstructions = specialInstructions;
        }



        // Methods

        public static int addNewPrescription(string medicationName, string dosage, string frequency, DateTime startDate, DateTime endDate, string specialInstructions)
        {
            return clsPrescriptionDataAccess.addNewPrescription(medicationName, dosage, frequency, startDate, endDate, specialInstructions);
        }



    }
}
