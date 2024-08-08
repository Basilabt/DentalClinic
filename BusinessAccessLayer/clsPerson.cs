using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class clsPerson
    {
        public enum enMode
        {
            AddNew = 1 , Update = 2 , Delete = 3
        }
        public enum enGender
        {
            Male = 1 , 
            Female = 0
        }

        public int personID { set; get; }

        public string firstName { set; get; }
        public string secondName { set; get; }
        public string thirdName { set; get; }
        public string lastName { set; get; }

        public string fullname
        {
            get
            {
                return this.firstName + " " + this.secondName + " " + this.thirdName + " " + this.lastName;
            }
        }
        public DateTime birthdate { set; get; }
        public enGender gender { set; get; }
        public string phoneNumber { set; get; }
        public string email { set; get; }
        public string address { set; get; }

        public enMode mode { set; get; }



        public clsPerson()
        {
            this.personID = -1;
            this.firstName = "";
            this.secondName = "";
            this.thirdName = "";
            this.lastName = "";
            this.birthdate = DateTime.Now;
            this.gender = enGender.Male;
            this.phoneNumber = "";
            this.email = "";
            this.address = "";
            this.mode = enMode.AddNew;
        }

        private clsPerson(int personID , string fisrtName , string secondName , string thirdName , string lastName , DateTime birthdate , enGender gender , string phoneNumber , string email , string address)
        {
            this.personID = personID;
            this.firstName = fisrtName;
            this.secondName = secondName;
            this.thirdName = thirdName;
            this.lastName = lastName;
            this.birthdate = birthdate;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.address = address;
            this.mode = enMode.Update;
        }


        public bool save()
        {
            switch (this.mode)
            {

                case enMode.AddNew:
                    {
                        this.personID = clsPerson.addNewPerson(this.firstName, this.secondName, this.thirdName, this.lastName, this.phoneNumber, this.email, this.address, this.birthdate, this.gender == enGender.Male);

                        return this.personID != -1;
                    }


                case enMode.Update:
                    {

                        return false;
                    }


                case enMode.Delete:
                    {
                        return clsPerson.deletePerson(this.personID);   

                    }


            }


            return true;

        }


        // Static methods

        public static clsPerson findPersonByPersonID(int personID)
        {
            bool isMale = false;
            string firstName = "", secondName = "", thirdName = "", lastName = "", phoneNumber = "", email = "", address = "";
            DateTime birthDate = DateTime.Now;

            enGender gender = (isMale) ? enGender.Male : enGender.Female;

            if(clsPersonDataAccess.findPersonByPersonID(personID,ref firstName,ref secondName,ref thirdName,ref lastName,ref birthDate,ref isMale , ref phoneNumber,ref email,ref address))
            {
                return new clsPerson(personID,firstName,secondName,thirdName,lastName,birthDate,gender,phoneNumber,email,address);
            }

            return null;
        }

        public static int addNewPerson(string firstName , string secondName , string thirdName , string lastName , string phoneNumber , string email , string address , DateTime birthDate , bool isMale)
        {
            return clsPersonDataAccess.addNewPerson(firstName, secondName, thirdName, lastName,birthDate,isMale,phoneNumber,email,address);
        }

        public static bool deletePerson(int personID)
        {
            return clsPersonDataAccess.deletePerson(personID);
        }


    }
}
