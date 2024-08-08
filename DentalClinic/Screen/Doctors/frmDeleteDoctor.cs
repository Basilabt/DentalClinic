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
    public partial class frmDeleteDoctor : Form
    {
        private clsDoctor _doctorToDelete;
        private clsPerson _personToDelete;

        public frmDeleteDoctor()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            this._personToDelete.mode = clsPerson.enMode.Delete;
            this._doctorToDelete.mode = clsDoctor.enMode.Delete;

            if (this._doctorToDelete.save() && this._personToDelete.save())
            {
                MessageBox.Show("Doctor deleted succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            MessageBox.Show("Failed to delete Doctor !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this._searchButtonPressed();
        }


        // Methods

        private void _searchButtonPressed()
        {
            int doctorID = int.Parse(txtboxDoctorID.Text);

            if(txtboxDoctorID.Text == "")
            {
                MessageBox.Show("Empty Field !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this._doctorToDelete = clsDoctor.findDoctor(doctorID);

            if(this._doctorToDelete == null)
            {
                MessageBox.Show("Doctor not found", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this._personToDelete = clsPerson.findPersonByPersonID(this._doctorToDelete.personID);

            ctrPersonInfo1.loadPerson(this._personToDelete.personID);
            ctrDoctorInfo1.loadDoctorInfo(this._doctorToDelete.doctorID);

        }

      
    }
}
