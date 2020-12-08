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
    public partial class AdminBooking : Form
    {
        public AdminBooking()
        {
            InitializeComponent();
        }

        DB db = new DB();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminBooking_Load(object sender, EventArgs e)
        {

        }

        private void ViewAllbtn_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Okbtn_Click(object sender, EventArgs e)
        {
            if (Updaterbtn.Checked == true)
            {
                updateBooking();
            }

            else if (Viewrbtn.Checked == true)
            {

                viewBooking();

            }
            else if (Searchrbtn.Checked == true)
            {
                searchBooking();


            }

        }

        public void updateBooking()
        {

            string theDate = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            string theDate1 = dateTimePicker3.Value.ToString("dd-MM-yyyy");


            string chkouttime = dateTimePicker4.Value.ToString("h:mm tt");
            string chkintime = dateTimePicker2.Value.ToString("h:mm tt");
           
            
            groupBox1.Visible = true;
            try
            {
                String sqlUpdate = "update booking set check_in_date= '" + theDate + "', check_in_time='" + chkintime + "',check_out_date= '" + theDate1 + "',check_out_time='"+ chkouttime +"' where bookingID='" + userControl11.id + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(sqlUpdate, DB.con);
                SDA.SelectCommand.ExecuteNonQuery();

                MessageBox.Show("Booking Updated");

            }
            catch
            {
                MessageBox.Show("Error Try updating");
            }
        }

        public void viewBooking()
        {
            try
            {
                db.Myconnection();

                dataGridView1.Visible = true;
                String sqlview = "SELECT * FROM booking";
                SqlDataAdapter SDA = new SqlDataAdapter(sqlview, DB.con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Error Try Again");
            }
        }



        public void searchBooking()
        {
            try
            {
                db.Myconnection();
                dataGridView1.Visible = true;
                String sqlview = "SELECT * FROM booking where bookingID=" + userControl11.id + "";
                SqlDataAdapter SDA = new SqlDataAdapter(sqlview, DB.con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Error Try Again");
            }
        }




        private void Viewrbtn_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void Searchrbtn_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }



        private void Updaterbtn_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}


