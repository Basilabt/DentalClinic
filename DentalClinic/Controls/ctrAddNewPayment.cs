using BusinessAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic.Controls
{
    public partial class ctrAddNewPayment : UserControl
    {
        public ctrAddNewPayment()
        {
            InitializeComponent();
        }





        private bool _checkValidInput()
        {
           
            if(txtboxAppintmentID.Text == "" || txtboxPaidAmount.Text == "" || txtboxAdditionalNotes.Text == "")
            {
                return false;
            }

            return true;

        }


        public bool addNewPayment()
        {
            int appointmentID = int.Parse(txtboxAppintmentID.Text);
            double paidAmount = double.Parse(txtboxPaidAmount.Text);
            string additionalNotes = txtboxAdditionalNotes.Text;
            DateTime payemntDate = dtpPaymentDate.Value;

            clsPayment.enPaymentMethod paymentMethod = clsPayment.enPaymentMethod.Cash;
            
            if(listboxPaymentMethod.SelectedIndex == 0)
            {
                paymentMethod = clsPayment.enPaymentMethod.CreditCard;

            } else if(listboxPaymentMethod.SelectedIndex == 1)
            {

                paymentMethod = clsPayment.enPaymentMethod.DebtCard;

            } else if(listboxPaymentMethod.SelectedIndex == 2)
            {

                paymentMethod = clsPayment.enPaymentMethod.Cash;

            } else
            {

                paymentMethod = clsPayment.enPaymentMethod.MobilePayment;

            }

            return clsPayment.addNewPayment(appointmentID,payemntDate,paidAmount,paymentMethod,additionalNotes);

        }
    }
}
