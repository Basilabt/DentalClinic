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
    public partial class ctrUserInfo : UserControl
    {
        string _username = "";
        clsUser _user;


        public ctrUserInfo()
        {
            InitializeComponent();

            this._resetValues();
        }


        public void loadUser(string username)
        {
            this._setUsername(username);
            this._loadUserFromDB();
            this._updateLabelswithValues();

        }

        private void _setUsername(string username)
        {
            this._username = username;
        }

        private void _loadUserFromDB()
        {
            this._user = clsUser.findByUsername(this._username);
        }

        private void _updateLabelswithValues()
        {
            lblUsername.Text = this._user.username;
            lblIsActive.Text = (this._user.isActive) ? "Yes" : "No";
        }

        private void _resetValues()
        {

            lblUsername.Text = "";
            lblPassword.Text = "***********";
            lblIsActive.Text = "";

        }
    }
}
