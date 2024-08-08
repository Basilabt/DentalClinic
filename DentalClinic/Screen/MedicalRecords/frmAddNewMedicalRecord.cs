using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic.Screen.MedicalRecords
{
    public partial class frmAddNewMedicalRecord : Form
    {
        public frmAddNewMedicalRecord()
        {
            InitializeComponent();
        }

        private void btnAddNewMedicalRecord_Click(object sender, EventArgs e)
        {
            this._addNewMedicalRecord();
        }

        private void frmAddNewMedicalRecord_Load(object sender, EventArgs e)
        {

        }


        private void _addNewMedicalRecord()
        {

            if(!ctrAddNewMedicalRecord1.isValidInput() || !ctrAddNewPrescription1.isValidInput())
            {
                MessageBox.Show("Input Can't Be Null","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }


            int prescriptionID = ctrAddNewPrescription1.addNewPrescription();

            if(prescriptionID != -1 && ctrAddNewMedicalRecord1.addNewMedcialRecord(prescriptionID))
            {
                MessageBox.Show("Record Add Succssesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else
            {
                MessageBox.Show("Failed to add medical record", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
          
            }




        }
    }
}
