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
    public partial class RbookingUC : UserControl
    {
        public RbookingUC()
        {
            InitializeComponent();
        }

        private void RbookingUC_Load(object sender, EventArgs e)
        {
            Receptionist_Menu ob = new Receptionist_Menu();
            // TODO: This line of code loads data into the 'zabHotelDataSet6.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.zabHotelDataSet6.customer);

            textBox2.Text = ob.label2.Text;


        }

        DB db = new DB();
       
        
        private void Okbtnn_Click(object sender, EventArgs e)
        {
            if (Insertrbtnn.Checked == true)
            {   

                insertBooking();
                comboBox1.ResetText();
                comboBox2.ResetText();
                comboBox3.ResetText();
                comboBox4.ResetText();

            }

            else if (Viewrbtnn.Checked == true)
            {

                viewBookings();


                Receptionist_Menu rm = new Receptionist_Menu();

            }
            else if (Searchrbtnn.Checked == true)
            {

                searchBooking(userControl11.id);


            }
            else if (radioButton1.Checked == true)
            {
                viewExpBookings();
            }
        }
    
    public void searchBooking(string a)
        {
            try
            {
                db.Myconnection();
                String sqlview = "SELECT * FROM booking where bookingID=" + a + "";
                SqlDataAdapter SDA = new SqlDataAdapter(sqlview, DB.con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (FormatException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception b)
            {
                MessageBox.Show(b.Message);
            }
        }
        public void viewBookings()
        {

            try
            {
                db.Myconnection();
                String sqlview = "SELECT * FROM booking where bk_status='valid'";
                SqlDataAdapter SDA = new SqlDataAdapter(sqlview, DB.con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (FormatException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }


        }
        public void viewExpBookings()
        {

            try
            {
                db.Myconnection();
                String sqlview = "SELECT * FROM booking where bk_status='expired' or bk_status='null'";
                SqlDataAdapter SDA = new SqlDataAdapter(sqlview, DB.con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (FormatException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }


        }
        public void insertBooking()
        {


            try
            {
                
                string today = DateTime.Today.ToString("dd-MM-yyyy");
                string time = DateTime.Now.ToString("h:mm tt");


                string theDate = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                string theDate1 = dateTimePicker3.Value.ToString("dd-MM-yyyy");
                int days = dateTimePicker3.Value.Day - dateTimePicker1.Value.Day;



                string chkouttime = dateTimePicker4.Value.ToString("h:mm tt");



                string chkintime = dateTimePicker2.Value.ToString("h:mm tt");

                if (days == 0)
                {
                    days = 1;
                }
                else if (days > 0)
                {
                    days++;
                }


                String sqlinsert = "INSERT INTO booking (date, time, check_in_date, check_in_time,check_out_date,check_out_time,customer_id,reception_id,room_number,days,bk_status) VALUES ('" + today + "','" + time + "','" + theDate + "','" + chkintime + "','" + theDate1 + "','" + chkouttime + "','" + comboBox1.Text + "','" + textBox2.Text + "','" + comboBox4.Text + "','" + days + "','valid')";
                SqlDataAdapter SDA = new SqlDataAdapter(sqlinsert, DB.con);
                SDA.SelectCommand.ExecuteNonQuery();

                db.Myconnection();
                String sqlUpdate = "update room set status='occupied' where roomID='" + comboBox4.Text + "'";
                SqlDataAdapter sa = new SqlDataAdapter(sqlUpdate, DB.con);
                sa.SelectCommand.ExecuteNonQuery();


                db.Myconnection();
                String sqlview = "select top 1 bookingID from booking order by bookingID desc";
                SqlCommand aa = new SqlCommand(sqlview, DB.con);
                int bid = (int)aa.ExecuteScalar();

                MessageBox.Show("Booking Inserted Room No: " + comboBox4.Text + "\nBooking ID: " + bid);
            }

            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }



        }




     
        public void searchBooking()
        {
            try
            {

                dataGridView1.Visible = true;
                db.Myconnection();
                String sqlview = "SELECT * FROM booking,customer where booking.customer_id=customer.customerID and first_name='" + textBox1.Text + "'";

                SqlDataAdapter SDA = new SqlDataAdapter(sqlview, DB.con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }




        private void Insertrbtnn_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void Searchrbtnn_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
        }

        private void Viewrbtnn_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                db.Myconnection();
                String sqlview = "SELECT distinct title FROM room_type,room where room_type.roomtypeID=room.room_type_id and status ='vacant'";

                SqlDataAdapter da = new SqlDataAdapter(sqlview, DB.con);
                DataSet ds = new DataSet();
                da.Fill(ds, "room_type");

                comboBox2.DisplayMember = "title";
                comboBox2.ValueMember = "title";
                comboBox2.DataSource = ds.Tables["room_type"];
                comboBox3.ResetText();
                comboBox4.ResetText();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void comboBox3_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                db.Myconnection();
                String sqlview = "SELECT distinct capacity FROM room_type,room where room_type.roomtypeID=room.room_type_id and title='" + comboBox2.Text + "' and status='vacant'";

                SqlDataAdapter da = new SqlDataAdapter(sqlview, DB.con);
                DataSet ds = new DataSet();
                da.Fill(ds, "room");

                comboBox3.DisplayMember = "capacity";
                comboBox3.ValueMember = "capacity";
                comboBox3.DataSource = ds.Tables["room"];

                comboBox4.ResetText();

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void comboBox1_Validating_1(object sender, CancelEventArgs e)
        {
            if (comboBox1.Text == "")
            {
                errorProvider1.SetError(comboBox1, "Please select Customer ID");
                comboBox1.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void comboBox4_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                db.Myconnection();
                String sqlview = "SELECT roomID FROM room,room_type where room.room_type_id = room_type.roomtypeID and title='" + comboBox2.Text + "' and capacity = '" + comboBox3.Text + "' and status='vacant'";

                SqlDataAdapter da = new SqlDataAdapter(sqlview, DB.con);
                DataSet ds = new DataSet();
                da.Fill(ds, "room");

                comboBox4.DisplayMember = "roomID";
                comboBox4.ValueMember = "roomID";
                comboBox4.DataSource = ds.Tables["room"];
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void comboBox4_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox4.Text == "")
            {
                errorProvider1.SetError(comboBox4, "Please select room number");
                comboBox4.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void comboBox3_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox3.Text == "")
            {
                errorProvider1.SetError(comboBox3, "Please select Capacity");
                comboBox3.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void comboBox2_Validating_1(object sender, CancelEventArgs e)
        {
            if (comboBox2.Text == "")
            {
                errorProvider1.SetError(comboBox2, "Please select Type");
                comboBox2.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            searchBooking();
        }
    }
}

