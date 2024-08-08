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
    public partial class frmDeletePatient : Form
    {

        private clsPatient _patientToDelete;
        private clsPerson _personToDelete;

        public frmDeletePatient()
        {
            InitializeComponent();
        }

        private void frmDeletePatient_Load(object sender, EventArgs e)
        {
            this._hideControls();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(!_doesClientExist())
            {
                MessageBox.Show("Patient not found !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string firstName = txtboxFirstName.Text;
            string secondName = txtboxSecondName.Text;
            string thirdName = txtboxThirdName.Text;
            string lastName = txtboxLastName.Text;

            this._patientToDelete = clsPatient.findPatient(firstName,secondName,thirdName,lastName);
            this._personToDelete = clsPerson.findPersonByPersonID(this._patientToDelete.personID);

            ctrPersonInfo1.loadPerson(this._patientToDelete.personID);

            this._showControls();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            string firstName = txtboxFirstName.Text;
            string secondName = txtboxSecondName.Text;
            string thirdName = txtboxThirdName.Text;
            string lastName = txtboxLastName.Text;

            clsPatient patientToDelete = clsPatient.findPatient(firstName, secondName, thirdName, lastName);
            clsPerson personToDelete = clsPerson.findPersonByPersonID(patientToDelete.personID);

            patientToDelete.mode = clsPatient.enMode.Delete;
            personToDelete.mode = clsPerson.enMode.Delete;

            if (patientToDelete.save() && personToDelete.save())
            {
                MessageBox.Show("Patient deleted succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            MessageBox.Show("Patient deleted succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





        private void _hideControls()
        {
            this.ctrPersonInfo1.Visible = false;
        }

        private void _showControls()
        {
            this.ctrPersonInfo1.Visible = true;
        }

        private bool _doesClientExist()
        {
            string firstName = txtboxFirstName.Text;
            string secondName = txtboxSecondName.Text;
            string thirdName = txtboxThirdName.Text;
            string lastName = txtboxLastName.Text;


            return clsPatient.doesPatientExist(firstName, secondName, thirdName, lastName);
        }

 
    }
}
