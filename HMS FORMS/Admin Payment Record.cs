using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HMS_FORMS
{
    public partial class Admin_Payment_Record : Form
    {
        public Admin_Payment_Record()
        {
            InitializeComponent();
        }
        DB db = new DB();
        private void Admin_Payment_Record_Load(object sender, EventArgs e)
        {
          
            // TODO: This line of code loads data into the 'zabHotelDataSet.payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.zabHotelDataSet.payment);
            reportViewer1.RefreshReport();
            reportViewer1.Refresh();


        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
