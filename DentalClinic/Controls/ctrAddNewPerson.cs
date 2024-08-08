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
    public partial class ctrAddNewPerson : UserControl
    {
        public ctrAddNewPerson()
        {
            InitializeComponent();
        }





        public int addNewPerson()
        {
          

            string fisrtName = txtboxFirstName.Text.Trim();
            string secondName = txtboxSecondName.Text.Trim();
            string thirdName = txtboxThirdName.Text.Trim();
            string lastName = txtboxLastName.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string email = txtboxEmail.Text.Trim();
            string address = txtboxAddress.Text.Trim();
            DateTime birthDate = dtpBirthDate.Value;
            clsPerson.enGender gender = (listboxGender.GetItemText(listboxGender.SelectedItem) == "Male") ? clsPerson.enGender.Male : clsPerson.enGender.Female;
           



            clsPerson newPerson = new clsPerson();


            newPerson.personID = -1;
            newPerson.firstName = fisrtName; 
            newPerson.secondName = secondName;
            newPerson.thirdName = thirdName;
            newPerson.lastName = lastName;
            newPerson.phoneNumber = phoneNumber;
            newPerson.email = email;
            newPerson.address = address;
            newPerson.birthdate = birthDate;
            newPerson.gender = gender;


            newPerson.save();

            return newPerson.personID;
        }



        public bool checkValidTextboxesInput()
        {

            if(txtboxFirstName.Text == "")
            {
                errorProvider1.SetError(txtboxFirstName,"Can't be empty !");
                return false;

            } else
            {
                errorProvider1.SetError(txtboxFirstName, null);
            }



            if (txtboxSecondName.Text == "")
            {
                errorProvider1.SetError(txtboxSecondName, "Can't be empty !");
                return false;

            } else
            {
                errorProvider1.SetError (txtboxSecondName, null);
            } 



            if (txtboxThirdName.Text == "")
            {
                errorProvider1.SetError(txtboxThirdName, "Can't be empty !");
                return false;

            } else
            {
                errorProvider1.SetError(txtboxThirdName, null);
            }


            if (txtboxLastName.Text == "")
            {
                errorProvider1.SetError(txtboxLastName, "Can't be empty !");
                return false;

            } else
            {
                errorProvider1.SetError(txtboxLastName, null);
            }


            if (txtPhoneNumber.Text == "")
            {
                errorProvider1.SetError(txtPhoneNumber, "Can't be empty !");
                return false;

            } else
            {
                errorProvider1.SetError(txtPhoneNumber, null);
            }

            if(txtboxEmail.Text == "")
            {
                errorProvider1.SetError(txtboxEmail, "Can't be empty !");
                return false;

            } else
            {
                errorProvider1.SetError(txtboxEmail , null);
            }

            if(txtboxAddress.Text == "")
            {
                errorProvider1.SetError(txtboxAddress, "Can't be empty !");
                return false;

            } else
            {
                errorProvider1.SetError(txtboxAddress, null);
            }




            return true;
        }


    }
}
