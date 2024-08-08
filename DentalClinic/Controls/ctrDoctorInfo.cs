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
    public partial class ctrDoctorInfo : UserControl
    {
        clsDoctor _doctor;
        int _doctorID;

        public ctrDoctorInfo()
        {
            InitializeComponent();
        }

        public void loadDoctorInfo(int doctorID)
        {
            this._doctorID = doctorID;

            this._loadDoctorFromDB();
            this._setLabelsInfo();
        }

        private void _loadDoctorFromDB()
        {
            this._doctor = clsDoctor.findDoctor(this._doctorID);
        }

        private void _setLabelsInfo()
        {
            lblDoctorName.Text = this._doctor.person.fullname;

            lblSpecialization.Text = this._doctor.specialization;
        }




    }
}
