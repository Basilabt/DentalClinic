using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public  class clsMedicalRecordDataAccess
    {

        public static DataTable getPatientsMedicalRecords()
        {
            DataTable dataTable = new DataTable();


            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_GetPatientsMedicalRecords";

            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    dataTable.Load(reader);

                }



            } catch(Exception exception)
            {

                Console.WriteLine("DEBUG: {0}", exception.Message);

            } finally
            {
                connection.Close();
            }



            return dataTable;

        }

        public static DataTable getPatientMedicalRecordsByFullname(string fullname)
        {

            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_GetPatientMedicalRecordsByFullName";
            SqlCommand command = new SqlCommand(query,connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@patientFullname", fullname);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    dataTable.Load(reader);
                }


            } catch(Exception exception)
            {
                Console.WriteLine("DEBUG: {0}",exception.Message);

            } finally
            {
                connection.Close();
            }







            return dataTable;

        }

        public static bool deleteMedicalRecord(int medicalRecordID)
        {
            int numberOfAffectedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_DeleteMedicalRecordByID";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@medicalRecordID", medicalRecordID);

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

        public static DataTable findMedicalRecordByID(int medicalRecordID)
        {

            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_FindMedicalRecordByID";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType= CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@medicalRecordID", medicalRecordID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                  dataTable.Load(reader);
                }


            } catch (Exception exception)
            {

                Console.WriteLine("DEBUG: {0}",exception.Message);

            } finally
            {
                connection.Close();
            }


            return dataTable;

        }



    }
}
