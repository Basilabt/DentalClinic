using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic.Screen.Users
{
    public partial class frmAddNewUser : Form
    {
        public frmAddNewUser()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            if(ctrAddNewPerson1.checkValidTextboxesInput())
            {
                if(ctrAddNewUser1.checkValidTextboxInput() && ctrAddNewUser1.checkUsernameIsUnique())
                {
                    int newPersonID = ctrAddNewPerson1.addNewPerson();

                    int newUserID = ctrAddNewUser1.addNewUser(newPersonID);

                    MessageBox.Show("User Added Successfully","",MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }

            }

            
           
        }





        

      

    }
}
