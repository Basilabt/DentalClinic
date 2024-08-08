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

namespace DentalClinic.Screen.Payments
{
    public partial class frmListAllPayments : Form
    {

        private DataTable _dataTable = new DataTable();

        public frmListAllPayments()
        {
            InitializeComponent();
        }

        private void frmListAllPayments_Load(object sender, EventArgs e)
        {
            this._handleDataFilling();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddNewPayment form = new frmAddNewPayment();
            form.ShowDialog();
        }


        // Methods

        private void _handleDataFilling()
        {
            this._loadPaymentsFromDB();
            this._fillDataGridWithData();
            this._resizeDataGridColumns();
        }

        private void _loadPaymentsFromDB()
        {
            this._dataTable = clsPayment.getAllPayments();
        }

        private void _fillDataGridWithData()
        {
            this.dgvPayments.DataSource = this._dataTable;
        }

        private void _resizeDataGridColumns()
        {
            dgvPayments.Columns[0].Width = 180;
            dgvPayments.Columns[1].Width = 180;
   
        }

    }
}
