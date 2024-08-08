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
    public partial class ctrAddNewPrescription : UserControl
    {
        public ctrAddNewPrescription()
        {
            InitializeComponent();
        }


        public int addNewPrescription()
        {
            string medicationName = txtboxMedication.Text;
            string dosage = txtboxDosage.Text;
            string frequency = txtboxFrequency.Text;
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            string specialInstructions = txtboxSpecialInstruction.Text;


            return clsPrescription.addNewPrescription(medicationName,dosage,frequency,startDate,endDate,specialInstructions);
        }


        public bool isValidInput()
        {
            string medicationName = txtboxMedication.Text;
            string dosage = txtboxDosage.Text;
            string frequency = txtboxFrequency.Text;
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            string specialInstructions = txtboxSpecialInstruction.Text;


            return medicationName != "" && dosage != "" && frequency != "" && startDate != null && endDate != null && specialInstructions != "";
        }

    }
}
