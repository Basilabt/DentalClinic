using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class clsMedicalRecord
    {

        public int medicalRecordID { get; set; }
        public int appointmentID { get; set; }
        public int prescriptionID { get; set; }
        public string description { set; get; }
        public string diagnosis { get; set; }

        public string additionalNotes { set; get; }
        
        public clsMedicalRecord()
        {
            this.medicalRecordID = -1;
            this.appointmentID = -1;
            this.prescriptionID = -1;
            this.description = "";
            this.diagnosis = "";
            this.additionalNotes = "";
        }

        private clsMedicalRecord(int appoiontmentID , int prescriptionID , string description, string diagnosis , string additionalNotes)
        {
            this.appointmentID = appoiontmentID;
            this.prescriptionID = prescriptionID;
            this.description = description; 
            this.diagnosis = diagnosis;
            this.additionalNotes = additionalNotes; 

        }

        // Static Methods

        public static DataTable getAllMedicalRecords()
        {
            return clsMedicalRecordDataAccess.getPatientsMedicalRecords();
        }

        public static DataTable getPatientMedicalRecordsByFullname(string fullname)
        {
            return clsMedicalRecordDataAccess.getPatientMedicalRecordsByFullname(fullname);
        }

        public static bool deleteMedicalRecord(int medicalRecordID)
        {
            return clsMedicalRecordDataAccess.deleteMedicalRecord(medicalRecordID);
        }


        public static DataTable findPatientMedicalRecordByID(int medicalRecordID)
        {   
            return clsMedicalRecordDataAccess.findMedicalRecordByID(medicalRecordID);
        }


        public static bool addNewMedicalRecord(int appointmentID , int prescriptionID , string description , string diagnosis , string additionalNotes)
        {
            int numberOfAffectedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_AddNewMedicalRecord";

            SqlCommand command = new SqlCommand(query,connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@appointmentID",appointmentID);
            command.Parameters.AddWithValue("@prescriptionID", prescriptionID);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@diagnosis", diagnosis);
            command.Parameters.AddWithValue("@additionalNotes", additionalNotes);


            try
            {
                connection.Open();

                numberOfAffectedRows = command.ExecuteNonQuery();


            } catch (Exception exception)
            {
                Console.WriteLine("DEBUG: {0}", exception.Message);
            }
            finally
            {
                connection.Close();
            }


            return numberOfAffectedRows >= 1;
        }

    }
}
