using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.SqlServer.Server;

namespace DataAccessLayer
{
    public class clsUsersDataAccess
    {


        public static bool doesUserExsitByUsername(string username)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_DoesUserExistByUsername";

            SqlCommand command = new SqlCommand(query, connection);

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Username", username);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    isFound = true;
                }


            } catch(Exception exception)
            {
                Console.WriteLine("DEBUG: {0}", exception.Message);

            }
            finally
            {
                connection.Close();
            }




            return isFound;
        }

        public static bool isUserActiveByUsername(string username)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string cmd = "SP_IsUserActiveByUsername";

            SqlCommand command = new SqlCommand(cmd, connection);

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Username", username);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    isFound = true;
                }


            } catch (Exception exception)
            {

                Console.WriteLine("DEBUG: {0}",exception.Message);

            } finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int addNewUser(int personID , string username , string password , bool isActive)
        {
            int newUserID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string cmd = "SP_AddNewUser";
            SqlCommand command = new SqlCommand(cmd, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@PersonID", personID);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", personID);
            command.Parameters.AddWithValue("@IsActive", isActive);

            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    newUserID = id;
                }


            } catch(Exception exception) 
            {

                Console.WriteLine("DEBUG: {0}", exception.Message);

            } finally
            {
                connection.Close();
            }



            return newUserID;

        }

        public static bool deleteUser(string username)
        {
            int numberOfAffectedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_DeleteUserByUsername";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Username", username);

            try
            {

                connection.Open();

                numberOfAffectedRows = command.ExecuteNonQuery();


            } catch(Exception exception)
            {

                Console.WriteLine("DEBUG: {0}", exception.Message);

            } finally
            {
                connection.Close();
            }



            return numberOfAffectedRows >= 1;
        }
        
        public static bool findUserByUsername(ref int userID , ref int personID , string username , ref string password ,ref  bool isActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection( clsDataAccessLayerSettings.connectionString);

            string query = "SP_FindUserByUsername";
            SqlCommand command = new SqlCommand(query , connection);
            command.CommandType= CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Username", username);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    userID = (int)reader["UserID"];
                    personID = (int)reader["PersonID"];
                    password = (string)reader["Password"];
                    isFound = (bool)reader["IsActive"];

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

        public static bool login(ref int userID , ref int personID ,  string username , string password , ref bool isActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string cmd = "SP_Login";

            SqlCommand command = new SqlCommand(cmd, connection);

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {            

                    userID = (int)reader["UserID"];
                    personID = (int)reader["PersonID"];
                    username = (string)reader["Username"];
                    password = (string)reader["Password"];
           
                    isActive = (bool)reader["IsActive"];

                    isFound = true;

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


        public static DataTable getAllUsers()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string cmd = "SP_GetAllUsers";
            SqlCommand command = new SqlCommand(cmd,connection);
            command.CommandType = CommandType.StoredProcedure;
            
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

            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }

    }
}
