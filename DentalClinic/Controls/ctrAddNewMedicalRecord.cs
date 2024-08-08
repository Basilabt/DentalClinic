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
    public partial class ctrAddNewMedicalRecord : UserControl
    {
        public ctrAddNewMedicalRecord()
        {
            InitializeComponent();
        }


        public bool addNewMedcialRecord(int prescriptionID)
        {
            string description = txtboxDescription.Text;
            string diagnosis = txtboxDiagnosis.Text;
            string additionalNotes = txtboxAdditionalNotes.Text;
            int appointmentID = int.Parse(txtboxAppointmentID.Text);


            return clsMedicalRecord.addNewMedicalRecord(appointmentID, prescriptionID, description, diagnosis, additionalNotes);

        }


        public bool isValidInput()
        {
            string description = txtboxDescription.Text;
            string diagnosis = txtboxDiagnosis.Text;
            string additionalNotes = txtboxAdditionalNotes.Text;

            return description != "" && diagnosis != "" && additionalNotes != "";

        }
    }
}
