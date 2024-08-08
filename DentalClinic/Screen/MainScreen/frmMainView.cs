using BusinessAccessLayer;
using DentalClinic.Login;
using DentalClinic.Screen.Appointments;
using DentalClinic.Screen.Doctors;
using DentalClinic.Screen.MedicalRecords;
using DentalClinic.Screen.Patient;
using DentalClinic.Screen.Payments;
using DentalClinic.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic.Screen
{
    public partial class frmMainView : Form
    {
        public frmMainView()
        {
            InitializeComponent();
        }

        private void frmMainView_Load(object sender, EventArgs e)
        {
            this._setBottomSectionLabelValues();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmListAllUsers form = new frmListAllUsers();
            form.ShowDialog();


        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            frmListAllAppointments form = new frmListAllAppointments();
            form.ShowDialog();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            frmListAllDoctors form = new frmListAllDoctors();
            form.ShowDialog();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            frmListAllPatients form = new frmListAllPatients();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmListMedicalRecords form = new frmListMedicalRecords();
            form.ShowDialog();

        }


        private void button1_Click(object sender, EventArgs e)
        {

            frmListAllPayments form = new frmListAllPayments();
            form.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this._logoutButtonPressed();
        }


    



        // Methods
        private void _setBottomSectionLabelValues()
        {
            this.lblUsername.Text = clsGlobal.loggedUser.username;
            this.lblLoginTime.Text = DateTime.Now.ToString();

        }

    

        private void _logoutButtonPressed()
        {
            
            clsGlobal.loggedUser = null;
            frmLoginView form = new frmLoginView();
            form.ShowDialog();
        }

    }
}
