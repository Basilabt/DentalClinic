using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class clsAppointment
    {

        public enum enStatus
        {
            Active = 1, Canceled = 2
        }

        public int appointmentID { set; get; }
        public int patientID { set; get; }
        public int doctorID { set; get; }
        public DateTime appointmentDate { set; get; }
        public DateTime appointmentTime { set; get; }
        public int appointmentStatusID { set; get; }
        public clsPatient patient { set; get; }
        public clsDoctor doctor { set; get; }

        public enStatus status { set; get; }

        public clsAppointment()
        {
            this.appointmentID = -1;
            this.patientID = -1;
            this.doctorID = -1;
            this.appointmentDate = DateTime.Now;
            this.appointmentTime = DateTime.Now;

            this.patient = null;
            this.doctor = null;

        }

        private clsAppointment(int appointmentID, int patientID, int doctorID, DateTime appoinmentDate, DateTime appointmentTime, int appointmentStatusID)
        {
            this.appointmentID = appointmentID;
            this.patientID = patientID;
            this.doctorID = doctorID;
            this.appointmentDate = appoinmentDate;
            this.appointmentTime = appointmentTime;

            this.status = (appointmentStatusID == 1) ? enStatus.Active : enStatus.Canceled;
            this.doctor = clsDoctor.findDoctor(doctorID);
            this.patient = clsPatient.findPatient(patientID);
        }


        // static method 

        public static DataTable getAllAppointments()
        {
            return clsAppointmentDataAccess.getAllAppointments();
        }

        public static bool deleteAppointmentByID(int appointmentID)
        {
            return clsAppointmentDataAccess.deleteAppointment(appointmentID);
        }


        public static clsAppointment findAppointmentByID(int appointmentID)
        {

            int patientID = -1, doctorID = -1, appointmentStatusID = -1;
            DateTime appointmentDate = DateTime.Now, appointmentTime = DateTime.Now;


            if (clsAppointmentDataAccess.findAppointmentByID(appointmentID, ref patientID, ref doctorID, ref appointmentDate, ref appointmentTime, ref appointmentStatusID))
            {
                return new clsAppointment(appointmentID, patientID, doctorID, appointmentDate, appointmentTime, appointmentStatusID);
            }



            return null;
        }

        public static bool addNewAppointment(int patientID , int doctorID , DateTime appointmentDate , TimeSpan appointTime , int appointmentStatusID)
        {
            return clsAppointmentDataAccess.addNewAppointment(patientID,doctorID,appointmentDate,appointTime,appointmentStatusID);
        }


    }


   
}
