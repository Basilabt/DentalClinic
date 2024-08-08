using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsPersonDataAccess
    {

        public static bool findPersonByPersonID(int personID, ref string fisrtName, ref string secondName, ref string thirdName, ref string lastName, ref DateTime birthdate, ref bool gender, ref string phoneNumber, ref string email, ref string address)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string cmd = "SP_FindPersonByPersonID";

            SqlCommand command = new SqlCommand(cmd, connection);

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@PersonID", personID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true;

                    fisrtName = (string)reader["FirstName"];
                    secondName = (string)reader["SecondName"];
                    thirdName = (string)reader["ThirdName"];
                    lastName = (string)reader["LastName"];
                    birthdate = (DateTime)reader["BirthDate"];
                    gender = (bool)reader["Gender"];
                    email = (string)reader["Email"];
                    phoneNumber = (string)reader["PhoneNumber"];
                    address = (string)reader["Address"];

                }


            }
            catch (Exception exception)
            {

                Console.WriteLine("DEBUG: {0}", exception.Message);

            }
            finally
            {
                connection.Close();
            }



            return true;
        }


        public static int addNewPerson(string firstName, string secondName, string thirdName, string lastName, DateTime birthdate, bool gender, string phoneNumber, string email, string address)
        {
            int newPersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string cmd = "SP_AddNewPerson";
            SqlCommand command = new SqlCommand(cmd, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@SecondName", secondName);
            command.Parameters.AddWithValue("@ThirdName", thirdName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@BirthDate", birthdate);
            command.Parameters.AddWithValue("@Gender", gender);
            command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Address", address);



            try
            {
                connection.Open();

                 Object result =  command.ExecuteScalar();

                if(result != null &&  int.TryParse(result.ToString(),out int id)) {
                    newPersonID = id;
                }


            } catch (Exception exception)
            {

                Console.WriteLine("DEBUG: {0}", exception.Message);

            } finally
            {
                connection.Close();
            }


            return newPersonID;

        }


        public static bool deletePerson(int personID)
        {
            int numberOfAffectedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_DeletePersonByID";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PersonID", personID);

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
