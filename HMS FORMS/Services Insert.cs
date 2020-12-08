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
    public partial class Services_Insert : Form
    {
        public Services_Insert()
        {
            InitializeComponent();
        }
        DB db = new DB();
        private void Services_Insert_Load(object sender, EventArgs e)
        {

        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            try
            {
                db.Myconnection();
                String sqlinsert = "INSERT INTO services(Name, price) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(sqlinsert, DB.con);
                SDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Service Inserted");
            }
            catch
            {
                MessageBox.Show("Incorrect Input");
            }
            
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            Regex reg = new Regex(@"[a-zA-Z]{3,16}$");


            if (reg.IsMatch(textBox1.Text) == false)
            {

                errorProvider1.SetError(textBox1, "Enter Valid Name");
                textBox1.Focus();

            }
            else
            {
                errorProvider1.Clear();
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
