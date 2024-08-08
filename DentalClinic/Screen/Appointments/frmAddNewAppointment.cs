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
    public partial class frmAddNewAppointment : Form
    {
        public frmAddNewAppointment()
        {
            InitializeComponent();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            
        }

        private void frmAddNewAppointment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(ctrAddNewAppointmnet1.validateInput())
            {
                if(ctrAddNewAppointmnet1.addNewAppointment())
                {
                    MessageBox.Show("Add New Appointment", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }


            MessageBox.Show("Failed to add new appointment", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        // Methods


    }
}
