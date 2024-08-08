using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public  class clsUser
    {

      public enum enMode
      {
            AddNew = 1 , Update = 2 , Delete = 3
      }

      public int userID { set; get; }
      
      public int personID { set; get; }

      public string username { set; get; }

      public string password { set; get; }

      public bool isActive { set; get; }

      public enMode mode { set; get; }

      // Composition     
      public clsPerson person { set; get; }

     public clsUser()
      {
            this.userID = -1;
            this.personID = -1;
            this.username = "";
            this.password = "";
            this.isActive = false;
            this.mode = enMode.AddNew;
            this.person = null;

      }

     private clsUser(int userID , int personID , string username , string password , bool isActive)
     {
            this.userID = userID;
            this.personID = personID;
            this.username = username;
            this.password = password;
            this.isActive = isActive;
            this.mode = enMode.Update;
            this.person = clsPerson.findPersonByPersonID(personID);
     }
      

    public bool save()
    {
            switch(this.mode)
            {

                case enMode.AddNew:
                    {
                        this.userID = clsUser.addNewUser(this.personID,this.username,this.password,this.isActive);

                        return this.userID != -1;
                    }


                case enMode.Update:
                    {

                        return false;
                    }


                case enMode.Delete:
                    {
                        return clsUser.deleteUser(this.username);

                    }


            }


            return true;

    }



     // Static methods: 
        
    public static bool doesUserExistByUsername(string username)
    {
            return clsUsersDataAccess.doesUserExsitByUsername(username);
    }

    public static bool isUserActive(string username)
    {
            return clsUsersDataAccess.isUserActiveByUsername(username);
    }

    public static int addNewUser(int personID , string username , string password ,bool isActive)
    {
        return clsUsersDataAccess.addNewUser(personID , username , password , isActive);    
    }

    public static clsUser findByUsername(string username)
    {
            int userID = -1;
            int personID = -1;
            string password = "";
            bool isActive = false;

            if (clsUsersDataAccess.findUserByUsername(ref userID, ref personID, username,ref password, ref isActive))
            {
                return new clsUser(userID, personID, username, password, isActive);
            }

            return null;
    }

    public static bool deleteUser(string username)
        {
            return clsUsersDataAccess.deleteUser(username);
        }

    public static clsUser login(string username , string password)
    {
            int userID = -1;
            int personID = -1;
            bool isActive = false;

            if(clsUsersDataAccess.login(ref userID,ref personID,username,password,ref isActive))
            {
                return new clsUser(userID,personID,username,password,isActive);
            }

            return null;
    }

    public static DataTable getAllUsers()
    {
            return clsUsersDataAccess.getAllUsers();
    }



    }
}
