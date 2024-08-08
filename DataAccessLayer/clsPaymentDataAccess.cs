using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public  class clsPaymentDataAccess
    {


        public static DataTable getAllPayments()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_GetAllPaymnets";
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


            } catch (Exception exception)
            {

                Console.WriteLine("DEBUG: {0}",exception.Message);

            } finally
            {
                connection.Close();
            }



            return dataTable;

        }

        public static bool addNewPayment(int appointmentID,DateTime paymentDate , double paidAmount , int paymentMethodID , string additionalNotes)
        {
            int numberOfAffectedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_AddNewPayment";
            SqlCommand command = new SqlCommand(query,connection);
            command.CommandType= CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@AppointmentID", appointmentID);
            command.Parameters.AddWithValue("@paymentDate",paymentDate);
            command.Parameters.AddWithValue("@paidAmount", paidAmount);
            command.Parameters.AddWithValue("@paymentMethodID", paymentMethodID);
            command.Parameters.AddWithValue("@additionalNotes", additionalNotes);



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
