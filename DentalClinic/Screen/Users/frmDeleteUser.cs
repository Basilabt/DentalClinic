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

namespace DentalClinic.Screen.Users
{
    public partial class frmDeleteUser : Form
    {
        private clsUser _userToDelete;
        private clsPerson _personToDelete;

        public frmDeleteUser()
        {
            InitializeComponent();

            this.ctrPersonInfo1.Visible = false;
            this.ctrUserInfo1.Visible = false;
            this.btnDelete.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._pressSearchButton();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this._personToDelete.mode = clsPerson.enMode.Delete;
            this._userToDelete.mode = clsUser.enMode.Delete;

            if (this._userToDelete.save() && this._personToDelete.save())
            {
                MessageBox.Show("User deleted succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            MessageBox.Show("Failed to delete user !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }



        //  My Private Methods


        private void _pressSearchButton()
        {
            string username = txtboxUsername.Text;

            if(username == "")
            {
                MessageBox.Show("Empty Field !","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            this._userToDelete = clsUser.findByUsername(username);

            if (this._userToDelete == null)
            {
                MessageBox.Show("User not found", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this._personToDelete = clsPerson.findPersonByPersonID(this._userToDelete.personID);


            ctrPersonInfo1.loadPerson(this._userToDelete.personID);
            ctrUserInfo1.loadUser(username);

       
            this._showInfoControls();


        }

        private void _showInfoControls()
        {
            ctrPersonInfo1.Visible = true;
            ctrUserInfo1.Visible = true;
            btnDelete.Visible = true;
        }

      
    }
}
