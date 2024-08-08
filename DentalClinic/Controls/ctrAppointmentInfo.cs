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
    public partial class ctrAppointmentInfo : UserControl
    {
        private clsAppointment _appointment;

        public ctrAppointmentInfo()
        {
            InitializeComponent();
        }



        public bool loadAppointmentInfo(int appointmentID)
        {

            this._appointment = clsAppointment.findAppointmentByID(appointmentID);



            if(this._appointment.appointmentID != -1)
            {
                lblAppointmentID.Text = this._appointment.appointmentID.ToString(); 

                lblPatientName.Text = this._appointment.patient.person.fullname;
                lblDoctorName.Text = this._appointment.doctor.person.fullname;

                lblAppointmentDate.Text = this._appointment.appointmentDate.ToString();
                lblAppointmentTime.Text = this._appointment.appointmentTime.ToString();

                return true;
            }


            return false;
        }



    }
}
