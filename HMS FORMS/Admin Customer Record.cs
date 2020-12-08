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
using System.Text.RegularExpressions;

namespace HMS_FORMS
{
    public partial class Admin_Customer_Record : Form
    {
        public Admin_Customer_Record()
        {
            InitializeComponent();
        }
        DB db = new DB();
        private void uC_Customer_Record1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ViewAllbtn_Click(object sender, EventArgs e)
        {

        }
        public void updateCustomer()
        {

      
            try
            {
                string theDate = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                db.Myconnection();
                groupBox1.Visible = true;
                String sqlUpdate = "update customer set first_name= '" + textBox2.Text + "', last_name= '" + textBox3.Text + "', cnic='" + textBox4.Text + "', dob='" + theDate + "',contact= '" + textBox6.Text + "',address= '" + textBox7.Text + "',state= '" + comboBox2.Text + "',country=  '" + comboBox1.Text + "',email= '" + textBox10.Text + "' where customerID=" + userControl11.id + "";
                SqlDataAdapter SDA = new SqlDataAdapter(sqlUpdate, DB.con);
                SDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Customer Updated");
            }
            catch
            {
                MessageBox.Show("Error Try Again");
            }

        }

        public void viewCustomers()
        { try { db.Myconnection();
                dataGridView1.Visible = true;
                String sqlview = "SELECT * FROM customer";
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
                MessageBox.Show("Error Try Again");
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
                MessageBox.Show("Error Try Again");
            }

        }
    public void    deleteCustomer()
        {
            try
            {
                db.Myconnection();
                String sqldel = "delete from customer where customerID=" + userControl11.id + "";
                SqlDataAdapter SDA = new SqlDataAdapter(sqldel, DB.con);
                SDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Customer Deleted");
            }
            catch
            {
                MessageBox.Show("Error Try Again");
            }
        }

        private void Okbtn_Click(object sender, EventArgs e)
        {

                if (Updaterbtn.Checked == true)
                {
                updateCustomer();
                }

                else if (Viewrbtn.Checked == true)
                {
                viewCustomers();
            }
                else if (Searchrbtn.Checked == true)
                {
                searchCustomer(userControl11.id);


                }
              
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Admin_Customer_Record_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            searchCustomer();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Updaterbtn_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            groupBox1.Visible = true;
        }

        private void Viewrbtn_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;

        }

        private void Searchrbtn_CheckedChanged(object sender, EventArgs e)
        {

            groupBox1.Visible = false;
        }

        private void Deleterbtn_CheckedChanged(object sender, EventArgs e)
        {

            groupBox1.Visible = false;
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
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

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            Regex reg = new Regex(@"[a-zA-Z]{3,16}$");


            if (reg.IsMatch(textBox3.Text) == false)
            {

                errorProvider1.SetError(textBox3, "Enter Valid Name");
                textBox2.Focus();

            }
            else
            {
                errorProvider1.Clear();
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
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
            Regex reg = new Regex(@"^\d{8,11}$");


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
            if (comboBox2.Text == "")
            {
                errorProvider1.SetError(comboBox2, "Please select state");
                comboBox2.Focus();
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

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            Regex reg = new Regex(@"^\d{13}$");


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
    }

}
