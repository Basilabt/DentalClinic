using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsPrescriptionDataAccess
    {


        public static int addNewPrescription(string medicationName , string dosage , string frequency , DateTime startDate , DateTime endDate , string specialInstructions)
        {
            int newPrescriptionID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_AddNewPrescription";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MedicationName", medicationName);
            command.Parameters.AddWithValue("@Dosage", dosage);
            command.Parameters.AddWithValue("@Frequency", frequency);
            command.Parameters.AddWithValue("@StartDate", startDate);
            command.Parameters.AddWithValue("@EndDate", endDate);
            command.Parameters.AddWithValue("@SpecialInstructions", specialInstructions);


            try
            {
                connection.Open();



                Object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    newPrescriptionID = id;
                }



            } catch(Exception exception)
            {
                Console.WriteLine("DEBUG: {0}",exception.Message);

            } finally
            {
                connection.Close();
            }





            return newPrescriptionID;
        }















    }
}
