using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public  class clsAppointmentDataAccess
    {


        public static DataTable getAllAppointments()
        {
            DataTable dataTable = new DataTable();


            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_GetAllAppointments";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows) {
                    dataTable.Load(reader);
                }


            } catch (Exception exception)
            {
                Console.WriteLine("DEBUG: {0}",exception.Message);
            }
            finally
            {
                connection.Close(); 
            }



            return dataTable;

        }

        public static bool deleteAppointment(int appointmentID)
        {

            int numberOfAffectedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_DeleteAppointmentByID";
            SqlCommand command = new SqlCommand(query,connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@AppointmentID", appointmentID);

            try
            {
                connection.Open();

                numberOfAffectedRows = command.ExecuteNonQuery();


            } catch(Exception exception)
            {
                Console.WriteLine("DEBUG: {0}", exception.Message);


            }
            finally
            {
                connection.Close();
            }




            return numberOfAffectedRows >= 1;

        }

        public static bool findAppointmentByID(int appointmentID , ref int personID , ref int doctorID , ref DateTime appointmentDate , ref DateTime appointmentTime , ref int appointmentStatusID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection (clsDataAccessLayerSettings.connectionString);

            string query = "SP_FindAppointmentByID";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@AppointmentID", appointmentID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;

                    personID = (int)reader["PatientID"];
                    doctorID = (int)reader["DoctorID"];
                    appointmentDate = (DateTime)reader["AppointmentDate"];
                    appointmentTime = (DateTime)reader["AppointmentTime"];
                    appointmentStatusID = (int)reader["AppointmentStatusID"];

                }


            } catch(Exception exception)
            {
                Console.WriteLine("DEBUG: {0}",exception.Message);

            } finally
            {
                connection.Close();
            }



            return isFound;
        }

        public static bool addNewAppointment(int patientID , int doctorID , DateTime appointmentDate , TimeSpan appointmentTime , int appointmentStatusID)
        {
            int numberOfAffectedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_AddNewAppointment";
            SqlCommand command = new SqlCommand(query,connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PatientID",patientID);
            command.Parameters.AddWithValue("@DoctorID", doctorID);
            command.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
            command.Parameters.AddWithValue("@AppointmentTime", appointmentTime);
            command.Parameters.AddWithValue("@AppointmentStatusID", appointmentStatusID);

            try
            {
                connection.Open();

                numberOfAffectedRows = command.ExecuteNonQuery();

            } catch (Exception exception)
            {

                Console.WriteLine("DEBUG: {0}", exception.Message);

            } finally
            {
                connection.Close();
            }


            return numberOfAffectedRows >= 1;
        }





    }
}
