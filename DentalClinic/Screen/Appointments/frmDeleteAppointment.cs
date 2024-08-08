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
    public partial class frmDeleteAppointment : Form
    {
        public frmDeleteAppointment()
        {
            InitializeComponent();
        }

        private void frmDeleteAppointment_Load(object sender, EventArgs e)
        {
            this._hideControls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._search();  
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            this._delete();
            this.Close();
        }

        // Methods

        private void _search()
        {    
            

            if (this.txtboxAppointmentID.Text != "")
            {
                int appointmentID = int.Parse(this.txtboxAppointmentID.Text);

                if(this.ctrAppointmentInfo1.loadAppointmentInfo(appointmentID))
                {
                    this._showControls();

                } else
                {
                    MessageBox.Show("Appointment Not Found !","",MessageBoxButtons.OK,MessageBoxIcon.Error);    
                }
            }
        }

        private void _delete()
        {
            int appointmentID = int.Parse(txtboxAppointmentID.Text);

            if(clsAppointment.deleteAppointmentByID(appointmentID))
            {
                MessageBox.Show("Appointment Deleted Succesfully","",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void _hideControls()
        {
            this.ctrAppointmentInfo1.Visible = false;
            this.btnDelete.Visible = false;

        }

        private void _showControls()
        {
            this.ctrAppointmentInfo1.Visible = true;
            this.btnDelete.Visible = true;
        }

    }
}
