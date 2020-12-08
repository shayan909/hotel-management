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
    public partial class Receptionist_Information : Form
    {
        public Receptionist_Information()
        {
            InitializeComponent();
        }
        DB db = new DB();

        public void insertRecep()
        {
            try
            {
                db.Myconnection();
                groupBox1.Visible = true;
                String sqlinsert = "INSERT INTO reception (first_name,last_name,email,password) VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(sqlinsert, DB.con);
                SDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Reception Record Inserted");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void updateRecep()
        {
            try
            {
                db.Myconnection();

                dataGridView1.Visible = true;
                String sqlinsert = "update reception set first_name='" + textBox2.Text + "',last_name='" + textBox3.Text + "',email='" + textBox4.Text + "',password='" + textBox5.Text + "' where receptionID='" + userControl11.id + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(sqlinsert, DB.con);
                SDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Reception Record Updated");
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void viewRecep()
        {
            try
            {
                db.Myconnection();
                dataGridView1.Visible = true;
                String sqlview = "SELECT * FROM reception";
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

        public void searchRecep()
        {
            try
            {
                db.Myconnection();
                dataGridView1.Visible = true;
                String sqlview = "SELECT * FROM reception where receptionID='" + userControl11.id + "'";
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
        private void Okbtn_Click(object sender, EventArgs e)
        {
            if (Insertrbtn.Checked == true)
            {

                insertRecep();
            }

            else if (Updaterbtn.Checked == true)
            {
                updateRecep();
            }

            else if (Viewrbtn.Checked == true)
            {
                viewRecep();
               }
            else if (Searchrbtn.Checked == true)
            {

                searchRecep();
              
            }
            else if (Deleterbtn.Checked == true)
            {
                deleteRecep();
            } 
            
        }
        public void deleteRecep()
        {
            try
            {
                db.Myconnection();
                string del = "delete from reception where receptionID='" + userControl11.id + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(del, DB.con);
                SDA.SelectCommand.ExecuteNonQuery();

                MessageBox.Show(" Deleted");
            }
            catch (FormatException e)
            {
                MessageBox.Show(e.Message);
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void Receptionist_Information_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Updaterbtn_CheckedChanged(object sender, EventArgs e)
       {
            groupBox1.Visible = true;
        }
        private void Insertrbtn_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
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
            Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");


            if (reg.IsMatch(textBox4.Text) == false)
            {

                errorProvider1.SetError(textBox4, "Enter valid Email");

                textBox4.Focus();
            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Please Enter Password");
                textBox2.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
