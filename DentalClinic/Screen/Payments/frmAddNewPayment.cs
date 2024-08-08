using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic.Screen.Payments
{
    public partial class frmAddNewPayment : Form
    {
        public frmAddNewPayment()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(ctrAddNewPayment1.addNewPayment())
            {
                MessageBox.Show("Added Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Faield to add payemnt", "", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
