using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_FORMS
{
    public partial class Reception_Service : Form
    {
        public Reception_Service()
        {
            InitializeComponent();
        }
        DB db = new DB();
        private void label1_Click(object sender, EventArgs e)
        {

        }


        public void addService() {
            try
            {
                string today = DateTime.Today.ToString("dd-MM-yyyy");
                db.Myconnection();
                string serviceID = "select serviceID from services where name='" + comboBox1.Text + "'";
                SqlCommand sq = new SqlCommand(serviceID, DB.con);
                sq.ExecuteNonQuery();
                int id = (int)sq.ExecuteScalar();



                db.Myconnection();

                string inquery = "insert into booking_service(date,booking_id,services_id) values ('" + today + "','" + comboBox2.Text + "','" + id + "')";
                SqlCommand da = new SqlCommand(inquery, DB.con);
                da.ExecuteNonQuery();

                MessageBox.Show("Service added");
            }
            catch
            {
                MessageBox.Show("Error Try Again");
            }
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            addService();
        }

        private void Reception_Service_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zabHotelDataSet7.booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.zabHotelDataSet7.booking);
            // TODO: This line of code loads data into the 'zabHotelDataSet1.services' table. You can move, or remove it, as needed.
            this.servicesTableAdapter.Fill(this.zabHotelDataSet1.services);

        }
    }
}
