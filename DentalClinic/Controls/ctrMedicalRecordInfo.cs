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
    public partial class ctrMedicalRecordInfo : UserControl
    {
        private DataTable _dataTable = new DataTable();

        public ctrMedicalRecordInfo()
        {
            InitializeComponent();
        }


        public bool searchForPatientMedicalRecord(int medcialID)
        {
            this._dataTable = clsMedicalRecord.findPatientMedicalRecordByID(medcialID);

            if(this._dataTable.Rows.Count == 0)
            {
                return false;
            }

            this._fillControlWithData();

            return true;
        }

        private void _fillControlWithData()
        {

           this.lblMedicalRecordID.Text = this.lblPatientName.Text = this._dataTable.Rows[0]["MedicalRecordID"].ToString();

            this.lblPatientName.Text = this._dataTable.Rows[0]["Patient"].ToString();
            this.lblAppointmentDate.Text = this._dataTable.Rows[0]["AppointmentDate"].ToString();
            this.lblDoctor.Text = this._dataTable.Rows[0]["Doctor"].ToString();
            this.lblDescription.Text = this._dataTable.Rows[0]["Description"].ToString();
            this.lblDiagnosis.Text = this._dataTable.Rows[0]["Diagnosis"].ToString();
            this.lblMedicationName.Text = this._dataTable.Rows[0]["MedicationName"].ToString();
            this.lblDosage.Text = this._dataTable.Rows[0]["Dosage"].ToString();
            this.lblFrequency.Text = this._dataTable.Rows[0]["Frequency"].ToString();
            this.lblStartDate.Text = this._dataTable.Rows[0]["StartDate"].ToString();
            this.lblEndDate.Text = this._dataTable.Rows[0]["EndDate"].ToString();
            this.lblSpecialInstructions.Text = this._dataTable.Rows[0]["SpecialInstructions"].ToString();


        }


        public void clearControls()
        {
            this.lblMedicalRecordID.Text = "";
            this.lblPatientName.Text = "";
            this.lblAppointmentDate.Text = "";
            this.lblDoctor.Text = "";
            this.lblDescription.Text = "";
            this.lblDiagnosis.Text = "";
            this.lblMedicationName.Text = "";
            this.lblDosage.Text = "";
            this.lblFrequency.Text = "";
            this.lblStartDate.Text = "";
            this.lblEndDate.Text = "";
            this.lblSpecialInstructions.Text = "";

        }





    }
}
