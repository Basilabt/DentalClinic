using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsDoctorDataAccess
    {

        public static DataTable getAllDoctors()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_GetAllDoctors";
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
                Console.WriteLine("DEBUG: {0}",exception.Message);

            } finally
            {
                connection.Close();
            }



            return dataTable;
        }

        public static bool findDoctor(int doctorID , ref int personID , ref string specialization)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_FindDoctorByID";
            
            SqlCommand command = new SqlCommand(query, connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@DoctorID",doctorID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {   
                    isFound = true;

                    personID = (int)reader["PersonID"];
                    specialization = (string)reader["Specialization"];

                }

            } catch(Exception exception) 
            {
                Console.WriteLine("DEBUG: {0}", exception.Message);

            } finally
            {
                connection.Close();
            }


            return isFound;
        }

        public static bool deleteDoctor(int doctorID)
        {

            int numberOfAffectedRows = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_DeleteDoctorByID";
            
            SqlCommand command = new SqlCommand(query, connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@DoctorID", doctorID);

            try
            {
                connection.Open();

                numberOfAffectedRows = command.ExecuteNonQuery();

            } catch(Exception exception) 
            {
                Console.WriteLine("DEBUG: {0}",exception.Message);
            }
            finally
            {
                connection.Close();
            }
                



            return numberOfAffectedRows >= 1;
        }

        public static int addNewDoctor(int personID , string specialization)
        {
            int newPersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_AddNewDoctor";
            
            SqlCommand command = new SqlCommand(query, connection);
            
            command.CommandType= CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@PersonID", personID);
            command.Parameters.AddWithValue("@Specialization", specialization);

            try
            {
                connection.Open();


                Object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    newPersonID = id;
                }


            } catch(Exception exception)
            {

                Console.WriteLine("DEBUG: {0}", exception.Message);

            } finally
            {
                connection.Close();
            }



            return newPersonID;
        }

        public static int findDoctorIDBySpecialization(string specialization)
        {
            int doctorID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_GetDoctorIDBySpecialization";
            SqlCommand command = new SqlCommand(query,connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Specialization", specialization); 

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    
                    doctorID = (int)reader["DoctorID"];

                }


            } catch (Exception exception)
            {
                Console.WriteLine("DEBUG: {0}", exception.Message);

            } finally
            {
                connection.Close();
            }


            return doctorID;

        }
    }
}
