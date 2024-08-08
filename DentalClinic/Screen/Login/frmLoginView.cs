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

using DentalClinic;
using DentalClinic.Screen;

namespace DentalClinic.Login
{
    public partial class frmLoginView : Form
    {
       

        public frmLoginView()
        {
            InitializeComponent();
        }

        public enum enLoginStatus
        {
            UserDoesNotExit = 1 , 
            UserIsNotActive = 2 , 
            IncorrectUsernameOrPassword = 3 ,
            CorrectCredentials = 4
        }

        private void frmLoginView_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            enLoginStatus loginStatus = this._login();

            switch(loginStatus)
            {

                case enLoginStatus.UserDoesNotExit:
                {
                        MessageBox.Show("User does not exist !","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        break;
                }


                case enLoginStatus.UserIsNotActive:
                {
                        MessageBox.Show("User is not active !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }


                case enLoginStatus.IncorrectUsernameOrPassword:
                {
                        MessageBox.Show("Incorrect username or password !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }


                case enLoginStatus.CorrectCredentials:
                {
                        frmMainView main = new frmMainView();
                        main.ShowDialog();
                        this.Hide();
                        break;
                }

            }

        }

        private enLoginStatus _login()
        {
            string username = txtboxUsername.Text.Trim();
            string password = txtboxPassword.Text.Trim();

            if(!clsUser.doesUserExistByUsername(username))
            {
                return enLoginStatus.UserDoesNotExit;
            }

            if(!clsUser.isUserActive(username))
            {
                return enLoginStatus.UserIsNotActive;
            }


            clsUser user = clsUser.login(username, password);

            if (user == null)
            {
                return enLoginStatus.IncorrectUsernameOrPassword;
            }

            clsGlobal.loggedUser = user;

            return enLoginStatus.CorrectCredentials;

        }
    }
}
