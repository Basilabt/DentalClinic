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
    public partial class ctrAddNewDoctor : UserControl
    {
        public ctrAddNewDoctor()
        {
            InitializeComponent();
        }

        public bool validateTextBoxInputs()
        {
            return txtboxSpecialization.Text != "";
        }

        public int addDoctor(int personID)
        {
            string specialization = txtboxSpecialization.Text;

            clsDoctor newDoctor = new clsDoctor();
            newDoctor.personID = personID;
            newDoctor.specialization = specialization;

            newDoctor.save();

            return newDoctor.doctorID;

        }
    }
}
