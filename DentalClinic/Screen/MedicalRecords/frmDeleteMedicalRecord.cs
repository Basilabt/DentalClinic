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

namespace DentalClinic.Screen.MedicalRecords
{
    public partial class frmDeleteMedicalRecord : Form
    {
        public frmDeleteMedicalRecord()
        {
            InitializeComponent();
        }

        private void frmDeleteMedicalRecord_Load(object sender, EventArgs e)
        {
            this._hideInfoControl();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if(txtboxMedicalRecordID.Text == "")
            {
                MessageBox.Show("Medical Record ID can not be null !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int medicalRecordID = int.Parse(txtboxMedicalRecordID.Text);

            if(!ctrMedicalRecordInfo1.searchForPatientMedicalRecord(medicalRecordID))
            {
                MessageBox.Show("No Medical Records Found !","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            this._showInfoControl();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int medicalRecordID = int.Parse(txtboxMedicalRecordID.Text);

            if (clsMedicalRecord.deleteMedicalRecord(medicalRecordID))
            {

                ctrMedicalRecordInfo1.clearControls();
                MessageBox.Show("Deleted Successfully !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                MessageBox.Show("Failed To Delete !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void _hideInfoControl()
        {
            this.ctrMedicalRecordInfo1.Visible = false;
        }

        private void _showInfoControl()
        {
            this.ctrMedicalRecordInfo1.Visible = true;
        }


    }
}
