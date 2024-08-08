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
    public partial class ctrAddNewUser : UserControl
    {
        public ctrAddNewUser()
        {
            InitializeComponent();
        }





        public int addNewUser(int personID)
        {
           
            string username = txtboxUsername.Text.Trim();
            string password = txtboxPassword.Text.Trim();
            
            bool isActive = checkboxIsActive.Checked;


            clsUser newUser = new clsUser();

            newUser.userID = -1;
            newUser.personID = personID;
            newUser.username = username;
            newUser.password = password;
            newUser.isActive = isActive;


            newUser.save();


            return newUser.userID; 
        }

        public bool checkValidTextboxInput()
        {

            if(txtboxUsername.Text.Trim() == "")
            {
                errorProvider1.SetError(txtboxUsername, "Can't Be Empty !");
                return false;

            } else
            {
                errorProvider1.SetError(txtboxUsername, null);
            }


            if (txtboxPassword.Text.Trim() == "")
            {
                errorProvider1.SetError(txtboxPassword, "Can't Be Empty !");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtboxPassword, null);
            }

            return true;
        }


        public bool checkUsernameIsUnique()
        {
            string username = txtboxUsername.Text.Trim();

            if(clsUser.doesUserExistByUsername(username))
            {
                errorProvider1.SetError(txtboxUsername, "Username already exists !");
                return false;

            } else
            {
                errorProvider1.SetError (txtboxUsername, null);
            }

            return true;
        }
    }
}
