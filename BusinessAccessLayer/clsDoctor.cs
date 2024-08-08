using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public  class clsDoctor
    {

        public enum enMode
        {
            AddNew = 1 , Update = 2 , Delete = 3
        }

        public int doctorID { set; get; }
        public int personID { set; get; }
        public string specialization { set; get; }

        public enMode mode { set; get; }
        
        public clsPerson person;


        public clsDoctor()
        {
            this.doctorID = -1;
            this.personID = -1;
            this.specialization = "";
            this.mode = enMode.AddNew;
        }

        private clsDoctor(int doctorID , int personID , string specialization)
        {
            this.doctorID = doctorID;
            this.personID = personID;
            this.specialization = specialization;
            this.person = clsPerson.findPersonByPersonID(personID);
            this.mode = enMode.Update;
        }

        public bool save()
        {

            switch(this.mode)
            {

                case enMode.AddNew:
                    {
                        this.doctorID = clsDoctor.addNewDoctor(this.personID, this.specialization);

                        return doctorID != -1;
                    }


                case enMode.Update:
                    {

                        return false;
                    }



                case enMode.Delete:
                    {
                        return clsDoctor.deleteDoctor(this.doctorID);
                    }

            }

            return false;
        }



        // Static methods

        public static DataTable getAllDoctors()
        {
            return clsDoctorDataAccess.getAllDoctors();
        }

        public static clsDoctor findDoctor(int doctorID)
        {
            int personID = -1;
            string specialization = "";

            if(clsDoctorDataAccess.findDoctor(doctorID,ref personID,ref specialization))
            {
                return new clsDoctor(doctorID, personID, specialization);
            }

            return null;
        }


        public static bool deleteDoctor(int doctorID)
        {
            return clsDoctorDataAccess.deleteDoctor(doctorID);
        }

        public static int addNewDoctor(int personID , string specialization)
        {
            return clsDoctorDataAccess.addNewDoctor(personID, specialization) ;
        }

        public static int findDoctorIDBySpecialization(string specialization)
        {
            return clsDoctorDataAccess.findDoctorIDBySpecialization(specialization);
        }

    }
}
