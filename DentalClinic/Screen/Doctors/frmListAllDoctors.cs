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

namespace DentalClinic.Screen.Doctors
{
    public partial class frmListAllDoctors : Form
    {
        private DataTable _dataTable;

        public frmListAllDoctors()
        {
            InitializeComponent();
        }


        private void frmListAllDoctors_Load(object sender, EventArgs e)
        {
            this._handleShowingDoctorsData();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddNewDoctor form = new frmAddNewDoctor();
            form.ShowDialog();
            this._handleShowingDoctorsData();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            frmDeleteDoctor form = new frmDeleteDoctor();
            form.ShowDialog();
            this._handleShowingDoctorsData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Methods

        private void _handleShowingDoctorsData()
        {
            this._loadDoctorsFromDB();
            this._fillDataGridView();
            this._resizeGridDimensions();
      
        }

        private void _loadDoctorsFromDB()
        {
            this._dataTable = clsDoctor.getAllDoctors();
        }

        private void _fillDataGridView()
        {
            dgvDoctors.DataSource = this._dataTable;
        }

        private void _resizeGridDimensions()
        {
            dgvDoctors.Columns[0].Width = 150;
            dgvDoctors.Columns[1].Width = 280;
            dgvDoctors.Columns[2].Width = 280;

        }


    }
}
