using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public  class clsPayment
    {


        public enum enPaymentMethod
        {
            CreditCard = 1 , DebtCard = 2 , Cash = 3 , MobilePayment = 4
        }










        // Static Methods

        public static DataTable getAllPayments()
        {
            return clsPaymentDataAccess.getAllPayments();
        }

        public static bool addNewPayment(int appointmentID,DateTime paymentDate , double paidAmmount , enPaymentMethod paymentMethod , string additionalNotes)
        {
            return clsPaymentDataAccess.addNewPayment(appointmentID,paymentDate,paidAmmount,((int)paymentMethod),additionalNotes);
        }

    }
}
