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

namespace DentalClinic.Screen.Patient
{
    public partial class frmListAllPatients : Form
    {
        private DataTable _dataTable;

        public frmListAllPatients()
        {
            InitializeComponent();
        }

        private void frmListAllPatients_Load(object sender, EventArgs e)
        {
            this._loadPatientsData();
           
        }


        private void btnAddNewPatient_Click(object sender, EventArgs e)
        {
            frmAddNewPatient form = new frmAddNewPatient();
            form.ShowDialog();
            this._loadPatientsData();
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            frmDeletePatient form = new frmDeletePatient();
            form.ShowDialog();
            this._loadPatientsData();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        // Methods

        private void _loadPatientsData()
        {
            this._loadPatientsFromDB();
            this._fillDataInGrid();
            if (this.dgvPatients.RowCount != 0)
            {
                this._resizeGridDimensions();
            }
        }

        private void _loadPatientsFromDB()
        {
            this._dataTable = clsPatient.getAllPatients();
        }

        private void _fillDataInGrid()
        {
            this.dgvPatients.DataSource = this._dataTable;
        }

        private void _resizeGridDimensions()
        {
                dgvPatients.Columns[0].Width = 100;
                dgvPatients.Columns[1].Width = 450;
                dgvPatients.Columns[2].Width = 50;
                dgvPatients.Columns[3].Width = 150;
        }

    }
}
