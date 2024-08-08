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

namespace DentalClinic.Screen.Appointments
{
    public partial class frmListAllAppointments : Form
    {

        private DataTable _appointments = new DataTable();


        public frmListAllAppointments()
        {
            InitializeComponent();
        }


        private void frmListAllAppointments_Load(object sender, EventArgs e)
        {
            this._handleGridDataLoading();
        }

        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            frmAddNewAppointment form = new frmAddNewAppointment();
            form.ShowDialog();
            this._handleGridDataLoading();
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            frmDeleteAppointment form = new frmDeleteAppointment();
            form.ShowDialog();
            this._handleGridDataLoading();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        // Methods

        private void _handleGridDataLoading()
        {
            this._loadAppointmentsFromDB();
            this._fillDataGridWithData();
            this._resizeColumnsSize();
        }

        private void _loadAppointmentsFromDB()
        {
            this._appointments = clsAppointment.getAllAppointments();
        }

        private void _fillDataGridWithData()
        {
            this.dgvAppointments.DataSource = this._appointments;
        }

        private void _resizeColumnsSize()
        {
            dgvAppointments.Columns[0].Width = 80;
            dgvAppointments.Columns[1].Width = 140;
            dgvAppointments.Columns[2].Width = 140;
            dgvAppointments.Columns[6].Width = 65;
        }

 
    }
}
