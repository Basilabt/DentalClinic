using BusinessAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic.Controls
{
    public partial class ctrPersonInfo : UserControl
    {
        private int _personID = -1;
        private clsPerson _person;

        public ctrPersonInfo()
        {
            InitializeComponent();

            this._resetValues();

        }

        public void loadPerson(int personID)
        {
            this._setPersonID(personID);
            this._loadPersonFromDB();
            this._updateLabelsWithValues();
        }

        private void _setPersonID(int personID)
        {
            this._personID = personID;
        }


        private void _resetValues()
        {
            lblFirstName.Text = "";
            lblSecondName.Text = "";
            lblThirdName.Text = "";
            lblLastName.Text = "";
            lblPhoneNumber.Text = "";
            lblAddress.Text = "";
            lblEmail.Text = "";
            lblBirthDate.Text = "";
            lblGender.Text = "";
        }

        private void _loadPersonFromDB()
        {
            this._person = clsPerson.findPersonByPersonID(this._personID);
     
        }


        private void _updateLabelsWithValues()
        {
            lblFirstName.Text = this._person.firstName;
            lblSecondName.Text = this._person.secondName;
            lblThirdName.Text = this._person.thirdName;
            lblLastName.Text = this._person.lastName;

            lblPhoneNumber.Text = this._person.phoneNumber;
            lblEmail.Text = this._person.email;
            lblAddress.Text = this._person.address;
            lblBirthDate.Text = this._person.birthdate.ToString();

            lblGender.Text = (this._person.gender == clsPerson.enGender.Male) ? "Male" : "Female";

        }
    }
}
