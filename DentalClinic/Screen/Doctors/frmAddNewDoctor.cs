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
    public partial class frmAddNewDoctor : Form
    {
        public frmAddNewDoctor()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(ctrAddNewPerson1.checkValidTextboxesInput())
            {

                if(ctrAddNewDoctor1.validateTextBoxInputs())
                {
                    int newPersonID = ctrAddNewPerson1.addNewPerson();

                    int newDoctorID = ctrAddNewDoctor1.addDoctor(newPersonID);

                    MessageBox.Show("Doctor Added Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }
    }
}
