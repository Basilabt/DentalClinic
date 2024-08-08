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
    public partial class ctrAddNewAppointmnet : UserControl
    {
        clsPatient _patient;
        int _doctorID = -1;

        public ctrAddNewAppointmnet()
        {
            InitializeComponent();
        }

        private void txtboxFirstName_Validating(object sender, CancelEventArgs e)
        {
            string firstName = txtboxFirstName.Text.Trim();

            if(firstName == "")
            {

                errorProvider1.SetError(txtboxFirstName, "Can't be empty");
                e.Cancel = true;

            } else
            {
                errorProvider1.SetError(txtboxFirstName, null);
                e.Cancel = false;
            }

        }

        private void txtboxSecondName_Validating(object sender, CancelEventArgs e)
        {
            string secondName = txtboxSecondName.Text.Trim();

            if (secondName == "")
            {

                errorProvider1.SetError(txtboxSecondName, "Can't be empty");
                e.Cancel = true;

            }
            else
            {
                errorProvider1.SetError(txtboxSecondName, null);
                e.Cancel = false;
            }
        }

        private void txtboxThirdName_Validating(object sender, CancelEventArgs e)
        {
            string thirdName = txtboxThirdName.Text.Trim();

            if (thirdName == "")
            {

                errorProvider1.SetError(txtboxThirdName, "Can't be empty");
                e.Cancel = true;

            }
            else
            {
                errorProvider1.SetError(txtboxThirdName, null);
                e.Cancel = false;
            }
        }

        private void txtboxLastName_Validating(object sender, CancelEventArgs e)
        {
            string lastName = txtboxLastName.Text.Trim();

            if (lastName == "")
            {

                errorProvider1.SetError(txtboxLastName, "Can't be empty");
                e.Cancel = true;

            }
            else
            {
                errorProvider1.SetError(txtboxLastName, null);
                e.Cancel = false;
            }
        }


        // Methods

        public bool validateInput()
        {
            return this.ValidateChildren();
        }

        public bool addNewAppointment()
        {
            string firstName = txtboxFirstName.Text.Trim();
            string secondName = txtboxSecondName.Text.Trim();
            string thirdName = txtboxThirdName.Text.Trim();
            string lastName = txtboxLastName.Text.Trim();

            this._patient = clsPatient.findPatient(firstName,secondName,thirdName,lastName);

            if(this._patient == null)
            {
                return false;
            }

            //string specialization = listboxSpecialization.SelectedItem.ToString();
            string specialization = "Endodontics";
            this._doctorID = clsDoctor.findDoctorIDBySpecialization(specialization);

            if(this._doctorID == -1)
            {
                return false;
            }

            DateTime date = appointmentDateTime.Value.Date;
            TimeSpan time = appointmentDateTime.Value.TimeOfDay;

            return clsAppointment.addNewAppointment(this._patient.patientID,this._doctorID,date,time,1);
        }

    }
}
