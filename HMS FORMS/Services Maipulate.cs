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
    public partial class Services_Maipulate : Form
    {
        public Services_Maipulate()
        {
            InitializeComponent();
        }
        DB db = new DB();
        private void Services_Maipulate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zabHotelDataSet9.services' table. You can move, or remove it, as needed.
            this.servicesTableAdapter.Fill(this.zabHotelDataSet9.services);

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                db.Myconnection();
                String sqlinsert = "update services set price ='" + textBox2.Text + "' where serviceID='" + comboBox1.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(sqlinsert, DB.con);
                SDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show(" Updated");
            }
            catch
            {
                MessageBox.Show("Unable to update");
            }

            
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                db.Myconnection();
                String sqlinsert = "delete from services where serviceID='" + comboBox1.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(sqlinsert, DB.con);
                SDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted");
            }
            catch
            {
                MessageBox.Show("Unable to Delete");
            }

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            Regex reg = new Regex(@"^\d{3,6}$");


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
    }
    }

