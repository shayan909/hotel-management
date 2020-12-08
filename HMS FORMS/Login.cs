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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        DB db = new DB();
       
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ucLogo1_Load(object sender, EventArgs e)
        {

        }



     
        private void forgotpasswordbtn_Click(object sender, EventArgs e)
        {
            forgotPass pas = new forgotPass();
            pas.ShowDialog();
        }

        public void adminLogin() {

            try
            {
                db.Myconnection();

                string admin = "'" + (textBox1.Text) + "'";


                string query = "select password from reception where first_name='admin' and receptionID=" + admin + "";

                SqlCommand cmd = new SqlCommand(query, DB.con);

                cmd.ExecuteNonQuery();

                int pass = (int)cmd.ExecuteScalar();


             


                if (textBox2.Text == pass.ToString())
                {
                    Admin_Menu ad = new Admin_Menu();
                    ad.Show();
                    this.Hide();
                }



            }
            catch
            {
                MessageBox.Show("Error Try Again");
            }

            

        }
        public void receptionLogin() {
            try
            {
                db.Myconnection();

              //  uname = "'" + (textBox1.Text) + "'";
                 string query = "select password from reception where receptionID=" + textBox1.Text + " and first_name!='admin'";

                SqlCommand cmd = new SqlCommand(query, DB.con);

                cmd.ExecuteNonQuery();

                int pass = (int)cmd.ExecuteScalar();

           


                if (textBox2.Text == pass.ToString())
                {
                    Receptionist_Menu ad = new Receptionist_Menu(textBox1.Text);
                    ad.Show();
                    this.Hide();

                }



            }
            catch
            {
                MessageBox.Show("Error Try Again");
            }

        }




        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                adminLogin();
            }
            else if (radioButton2.Checked == true)
            {
                receptionLogin();
              }

        }
      

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Please Enter ID");
                textBox1.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
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

        private void radioButton1_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }
}
