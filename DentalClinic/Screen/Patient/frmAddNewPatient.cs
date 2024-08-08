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
using System.Xml.Serialization;

namespace DentalClinic.Screen.Patient
{
    public partial class frmAddNewPatient : Form
    {
        public frmAddNewPatient()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this._addButtonPressed();
        }



        private void _addButtonPressed()
        {
            if(!ctrAddNewPerson1.checkValidTextboxesInput())
            {
                return;
            }


            int newPersonID = ctrAddNewPerson1.addNewPerson();

            int newPatientID = clsPatient.addNewPatient(newPersonID);

            MessageBox.Show("Patient added succesfully !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.Close();


        }
    }
}
