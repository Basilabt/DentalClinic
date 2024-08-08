using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class clsPatient
    {
        public enum enMode
        {
            AddNew = 1 , Delete = 2 , Update = 3
        }

        public int patientID { set; get; }
        public int personID { set; get; }
        public clsPerson person { set; get; }

        public enMode mode { set; get; }


        public clsPatient()
        {
            this.patientID = -1;
            this.personID = -1;
            this.mode = enMode.AddNew;
            
        }

        private clsPatient(int patientID,int personID)
        {
            this.patientID = patientID;
            this.personID=personID;
            this.person = clsPerson.findPersonByPersonID(personID);
            this.mode = enMode.Update;
        }


        public bool save()
        {
           switch(this.mode)
            {

                case enMode.AddNew:
                    {
                        return false;
                    }

                case enMode.Delete:
                    {
                        return clsPatient.deletePatient(this.patientID);
                    }


                case enMode.Update:
                    {
                        return false;
                    
                    }



            }

            return false;
        }
        

        // Static Methods


        public static DataTable getAllPatients()
        {
            return clsPatientDataAccess.getAllPatients();
        }

        public static bool doesPatientExist(string firstName, string secondName, string thirdName, string lastName)
        {
            return clsPatientDataAccess.doesPatientExist(firstName, secondName, thirdName, lastName);
        }

        public static int addNewPatient(int personID)
        {
            return clsPatientDataAccess.addNewPatient(personID);
        }

        public static clsPatient findPatient(string firstName , string secondName , string thirdName , string lastName)
        {
            int patientID = -1;
            int personID = -1;

            if (clsPatientDataAccess.findPatient(firstName, secondName, thirdName,lastName,ref patientID,ref personID))
            {
               return new clsPatient(patientID,personID);   
            }

            return null;
        }

        public static clsPatient findPatient(int patientID)
        {
            int personID = -1;

            if(clsPatientDataAccess.findPatient(patientID,ref personID))
            {
                return new clsPatient(patientID,personID);
            }

            return null;
        }

        public static bool deletePatient(int patientID)
        {
            return clsPatientDataAccess.deletePatient(patientID);
        }

    }
}
