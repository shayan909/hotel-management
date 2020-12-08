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
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;
using System.Globalization;

namespace HMS_FORMS
{
    public partial class Receptionist_Customer_Records : Form
    {
        public Receptionist_Customer_Records()
        {
            InitializeComponent();
        }
    
        private void Receptionist_Customer_Records_Load(object sender, EventArgs e)
        {
           
           
        }
        DB db = new DB();
        private void Okbtn_Click(object sender, EventArgs e)
        {
            if (Insertrbtn.Checked == true)
            {
                insertCustomer();

            }

            else if (Viewrbtn.Checked == true)
            {
                viewCustomer();
            }
            else if (Searchrbtn.Checked == true)
            {
                searchCustomer(userControl11.id);
            }

        }
        public void searchCustomer()
        {
            try
            {
                string name = "'" + textBox1.Text + "'";
                dataGridView1.Visible = true;
                db.Myconnection();
                String sqlview = "SELECT * FROM customer where first_name=" + name + "";

                SqlDataAdapter SDA = new SqlDataAdapter(sqlview, DB.con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }
        public void searchCustomer(string a)
        {
            try
            {
                dataGridView1.Visible = true;
                db.Myconnection();
                String sqlview = "SELECT * FROM customer where customerID=" + a + "";

                SqlDataAdapter SDA = new SqlDataAdapter(sqlview, DB.con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("ERROR Searching");
            }

        }

        public void viewCustomer()
        {
            try
            {
                db.Myconnection();
                String sqlview = "SELECT * FROM customer";
                SqlDataAdapter SDA = new SqlDataAdapter(sqlview, DB.con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("ERROR Viewing");
            }
        }

        public void insertCustomer()
        {

            int id = 0;
            try
            {
                db.Myconnection();

                groupBox1.Visible = true;
                string theDate = dateTimePicker1.Value.ToString("dd-MM-yyyy");


                String sqlinsert = "INSERT INTO customer (first_name, last_name, cnic, dob,contact ,address,state,country,email) VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + theDate + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "','" + textBox10.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(sqlinsert, DB.con);
                SDA.SelectCommand.ExecuteNonQuery();

                db.Myconnection();
                String sqlview = "select top 1 customerID from customer order by customerID desc";
                SqlCommand sa = new SqlCommand(sqlview, DB.con);
                id = (int)sa.ExecuteScalar();

                MessageBox.Show("Customer ID: " + id);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }




            try { sendMail(id.ToString()); }
            catch { MessageBox.Show("unable to send email"); }

                

            
            
        }
        public void sendMail(string id)
        {

            try
            {
                string senderMail = "shayan.0@live.com";
                string recipient = textBox10.Text.ToString();

                MailMessage msg = new MailMessage(senderMail, recipient, "ZAB HOTEL Notification", "Welcome to ZAB HOTEL\n Your Customer ID is :" + id);
                msg.IsBodyHtml = true;
                string server = "smtp.live.com";
                int port = 587;
                SmtpClient cv = new SmtpClient(server, port);

                cv.UseDefaultCredentials = false;
                cv.EnableSsl = true;
                cv.Credentials = new NetworkCredential(senderMail, "greenbelt.0*");
                cv.SendMailAsync(msg);
            }

            catch
            {
                MessageBox.Show("error sending mail");
            }

         }

            private void Insertrbtn_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void Viewrbtn_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
        }

        private void Searchrbtn_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            groupBox1.Hide();

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchCustomer();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void textBox10_Validating(object sender, CancelEventArgs e)
        {
            Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");


            if (reg.IsMatch(textBox10.Text) == false)
            {

                errorProvider1.SetError(textBox10, "Enter valid Email");
            
                textBox10.Focus();
            }

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            Regex reg = new Regex(@"[a-zA-Z]{3,16}$");


            if (reg.IsMatch(textBox2.Text) == false)
            {

                errorProvider1.SetError(textBox2, "Enter Valid Name");
                textBox2.Focus();

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            Regex reg = new Regex(@"[a-zA-Z]{3,16}$");


            if (reg.IsMatch(textBox3.Text) == false)
            {
                errorProvider1.SetError(textBox3, "Enter Valid Name");
                textBox3.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            Regex reg = new Regex(@"^[0-9]{13}$");


            if (reg.IsMatch(textBox4.Text) == false)
            {
                errorProvider1.SetError(textBox4, "Enter Valid CNIC");
                textBox4.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePicker1.Value.Date == DateTime.Today)
            {
                dateTimePicker1.Focus();
                errorProvider1.SetError(dateTimePicker1, "Enter Valid Date");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            Regex reg = new Regex(@"^[0-9]{8,11}$");


            if (reg.IsMatch(textBox6.Text) == false)
            {
                errorProvider1.SetError(textBox6, "Enter Valid Contact");
                textBox6.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox7_Validating(object sender, CancelEventArgs e)
        {
            Regex reg = new Regex(@"^[A-Za-z0-9'\.\-\s\,]{5,16}$");


            if (reg.IsMatch(textBox7.Text) == false)
            {
                errorProvider1.SetError(textBox7, "Enter Valid Address");
                textBox7.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox8_Validating(object sender, CancelEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                db.Myconnection();
                String sqlview = "SELECT states.name FROM states,countries where countries.id=states.country_id and countries.name='" + comboBox1.Text + "'";

                SqlDataAdapter da = new SqlDataAdapter(sqlview, DB.con);
                DataSet ds = new DataSet();
                da.Fill(ds, "states");

                comboBox2.DisplayMember = "name";
                comboBox2.ValueMember = "name";
                comboBox2.DataSource = ds.Tables["states"];
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }



        private void comboBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox1.Text == "")
            {
                errorProvider1.SetError(comboBox1, "Please select country");
                comboBox1.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void comboBox2_Validating(object sender, CancelEventArgs e)
        {
            if(comboBox2.Text=="")
            {
                errorProvider1.SetError(comboBox2, "Please select state");
                comboBox2.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void dateTimePicker1_VisibleChanged(object sender, EventArgs e)
        {
             }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                db.Myconnection();
                String sqlview = "SELECT * FROM countries";

                SqlDataAdapter da = new SqlDataAdapter(sqlview, DB.con);
                DataSet ds = new DataSet();
                da.Fill(ds, "countries");

                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "name";
                comboBox1.DataSource = ds.Tables["countries"];
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
    }
    }






