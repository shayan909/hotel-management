using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HMS_FORMS
{
    public partial class RServicesUC : UserControl
    {
        public RServicesUC()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RServicesUC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zabHotelDataSet7.booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.zabHotelDataSet7.booking);
            // TODO: This line of code loads data into the 'zabHotelDataSet1.services' table. You can move, or remove it, as needed.
            this.servicesTableAdapter.Fill(this.zabHotelDataSet1.services);
        }
        DB db = new DB();
    


        public void addService()
        {
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                db.Myconnection();
                string serviceID = "select serviceID from services where name='" + comboBox1.Text + "'";
                SqlCommand sq = new SqlCommand(serviceID, DB.con);
                sq.ExecuteNonQuery();
                int id = (int)sq.ExecuteScalar();



                db.Myconnection();

                string inquery = "insert into booking_service(date,booking_id,services_id) values ('" + date + "','" + comboBox2.Text + "','" + id + "')";
                SqlCommand da = new SqlCommand(inquery, DB.con);
                da.ExecuteNonQuery();

                MessageBox.Show("Service added");
            }
            catch
            {
                MessageBox.Show("Error Try Again");
            }
        }

       
      
        private void OKbtn_Click_1(object sender, EventArgs e)
        {
            addService();
        }
    }
}

