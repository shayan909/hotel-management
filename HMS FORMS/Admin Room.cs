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
    public partial class AdminRooms : Form
    {
        public AdminRooms()
        {
            InitializeComponent();
            
        }
        DB db = new DB();
      
        private void AdminRooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zabHotelDataSet8.room_type' table. You can move, or remove it, as needed.
            this.room_typeTableAdapter.Fill(this.zabHotelDataSet8.room_type);
            viewRooms();
        }
        public void updateRooms()
        {
            try
            {
                db.Myconnection();
                String sqlUpdate = "update room_type set amount= " + textBox2.Text + "where roomtypeID=" + comboBox1.Text + "";

                SqlDataAdapter SDA = new SqlDataAdapter(sqlUpdate, DB.con);
                SDA.SelectCommand.ExecuteNonQuery();


                viewRooms();
            }
            catch
            {
                MessageBox.Show("Error Try Again");
            }

        }

        public void viewRooms()
        {
            try
            {
                db.Myconnection();

                dataGridView1.Visible = true;
                String sqlview = "SELECT * FROM room_type";
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

        private void UC_Customer_Record_Updatebtn_Click(object sender, EventArgs e)
        {
            updateRooms();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            Regex reg = new Regex(@"^\d{4,5}$");


            if (reg.IsMatch(textBox2.Text) == false)
            {
                errorProvider1.SetError(textBox2, "Enter Valid Amount");
                textBox2.Focus();
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
                errorProvider1.SetError(comboBox1, "Select RoomID");
                comboBox1.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
