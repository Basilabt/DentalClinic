using BusinessAccessLayer;
using DentalClinic.Screen.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic.Users
{
    public partial class frmListAllUsers : Form
    {
        private DataTable _dtUsersDataTable;

        public frmListAllUsers()
        {
            InitializeComponent();


        }

        private void frmListAllUsers_Load(object sender, EventArgs e)
        {
            this._handleShowingUsersData();
        }


        private void _handleShowingUsersData()
        {
            this._loadDataFromDB();
            this._fillDataGridView();
            this._resizeGridDimensions();
            this._hideColumns();

        }

      
        private void _loadDataFromDB()
        {
            this._dtUsersDataTable = clsUser.getAllUsers();
        }

        private void _fillDataGridView()
        {
            this.dgvUsers.DataSource = this._dtUsersDataTable;
        }

        private void _resizeGridDimensions()
        {
            dgvUsers.Columns[2].Width = 250;
            dgvUsers.Columns[4].Width = 250;
        }

        private void _hideColumns()
        {
            dgvUsers.Columns[0].Visible = false;
            dgvUsers.Columns[1].Visible = false;
            dgvUsers.Columns[3].Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddNewUser form = new frmAddNewUser();
            form.ShowDialog();
            this._handleShowingUsersData();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            frmDeleteUser form = new frmDeleteUser();
            form.ShowDialog();
            this._handleShowingUsersData();
        }
    }
}
