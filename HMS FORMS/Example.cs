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
using Tulpep.NotificationWindow;

namespace HMS_FORMS
{
    public partial class Example : UserControl
    {
        public Example()
        {
            InitializeComponent();
        }

        private void Example_Load(object sender, EventArgs e)
        {
           
        }
        DB db = new DB();
       
        public void notify()
        {


            string date = "'" + (DateTime.Today.ToString("dd-MM-yyyy")) + "'";
            db.Myconnection();
            String sqlview = "SELECT distinct check_out_time,room_number,first_name,last_name,bookingID FROM booking,customer,room where booking.customer_id=customer.customerID  and check_out_date=" + date + " and bk_status='valid' order by check_out_time ASC";
            SqlDataAdapter SDA = new SqlDataAdapter(sqlview, DB.con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;





            if (dt.DataSet == null)
            {

                PopupNotifier popup = new PopupNotifier();
                // popup.Image = Properties.Resources.info;
                popup.TitleText = "NOTIFICATION";
                popup.ContentText = "VACATE ROOMS";
                popup.Popup();//Show

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

