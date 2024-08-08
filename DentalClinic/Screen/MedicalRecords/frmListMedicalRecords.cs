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
    public partial class frmListMedicalRecords : Form
    {
        DataTable _patientsMedicalRecords = new DataTable();
        DataTable _patientMedicalRecords = new DataTable();

        public frmListMedicalRecords()
        {
            InitializeComponent();
        }
        private void frmListMedicalRecords_Load(object sender, EventArgs e)
        {
            this._handleDataFilling();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this._handleSearch();
        }

        private void btnDeleteMedicalRecord_Click(object sender, EventArgs e)
        {
            frmDeleteMedicalRecord form = new frmDeleteMedicalRecord();
            form.ShowDialog();
            this._handleDataFilling();
        }

        private void btnAddMedicalRecord_Click(object sender, EventArgs e)
        {
            frmAddNewMedicalRecord form = new frmAddNewMedicalRecord();
            form.ShowDialog();
            this._handleDataFilling();
        }


        // Methods

        private void _handleDataFilling()
        {
            this._loadDataFromDB();
            this._fillGridWithData();
        }

        private void _loadDataFromDB()
        {
            this._patientsMedicalRecords = clsMedicalRecord.getAllMedicalRecords();
        }

        private void _fillGridWithData()
        {
           this.dgvMedicalRecords.DataSource = this._patientsMedicalRecords;
        }



        private void _handleSearch()
        {
            string fullname = txtboxPatientFullname.Text;

            if(fullname == "")
            {
                MessageBox.Show("Invalid Fullname","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            this._patientMedicalRecords = clsMedicalRecord.getPatientMedicalRecordsByFullname(fullname);

            if(this._patientMedicalRecords.Rows.Count == 0)
            {
                MessageBox.Show("No medical records found", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.dgvMedicalRecords.DataSource = this._patientMedicalRecords;

        }


    }
}
