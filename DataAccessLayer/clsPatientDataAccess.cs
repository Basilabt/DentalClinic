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
    public  class clsPatientDataAccess
    {

        public static  bool doesPatientExist(string firstname , string secondName , string thirdName , string lastname)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_DoesPatientExist";

            SqlCommand command = new SqlCommand(query,connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@FirstName", firstname);
            command.Parameters.AddWithValue("@SecondName", secondName);
            command.Parameters.AddWithValue("@ThirdName", thirdName);
            command.Parameters.AddWithValue("@LastName", lastname);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) { 
                    isFound = true;
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

        public static int addNewPatient(int personID)
        {
            int newPersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_AddNewPatient";

            SqlCommand command = new SqlCommand(query, connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@PersonID", personID);

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
                Console.WriteLine("DEBUG: {0}",exception.Message); 

            } finally
            {
                connection.Close();
            }




            return newPersonID;
        }

        public static DataTable getAllPatients()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_GetAllPatients";

            SqlCommand command = new SqlCommand(query,connection);

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
            }
             finally
            {
                connection.Close();
            }


            return dataTable;
        }

        public static bool findPatient(string firstname, string secondName, string thirdName, string lastname,ref int patientID , ref int personID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_FindPatient";
            
            SqlCommand command = new SqlCommand(query, connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@FirstName",firstname);
            command.Parameters.AddWithValue("@SecondName", secondName);
            command.Parameters.AddWithValue("@ThirdName", thirdName);
            command.Parameters.AddWithValue("@LastName", lastname);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;

                    patientID = (int)reader["PatientID"];
                    personID = (int)reader["PersonID"];

                }


            } catch (Exception exception)
            {

                Console.WriteLine("DEBUG: {0}", exception.Message);

            } finally
            {
                connection.Close();
            }


            return isFound;
        }

        public static bool deletePatient(int patientID)
        {
            int numberOfAffectedRows = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_DeletePatient";

            SqlCommand command = new SqlCommand(query, connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@PatientID", patientID);


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

        public static bool findPatient(int patientID ,ref int personID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_FindPatientByID";
            SqlCommand command = new SqlCommand(query,connection);
            command.CommandType= CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PatientID", patientID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;

                    personID = (int)reader["PersonID"];

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


    }
}
