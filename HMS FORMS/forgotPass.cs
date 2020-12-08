using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_FORMS
{
    public partial class forgotPass : Form
    {
        public forgotPass()
        {
            InitializeComponent();
        }
        DB db=new DB();
        private void forgotPass_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.UseSystemPasswordChar = true;

        }

        private void UC_Customer_Record_Updatebtn_Click(object sender, EventArgs e)
        {
            sendMail();
        }
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public void sendMail()
        {
            int password = RandomNumber(1000, 10000);
            string senderMail = textBox3.Text.ToString();
            string recipient = textBox1.Text.ToString();

            MailMessage msg = new MailMessage(senderMail, recipient, "Password Reset Notification", "Your New Password is: " + password+ "");
            msg.IsBodyHtml = true;
                string    server = "smtp.live.com";
              int  port = 587;
            SmtpClient cv = new SmtpClient(server, port);

            cv.UseDefaultCredentials = false;
            cv.EnableSsl = true;
            cv.Credentials = new NetworkCredential(senderMail, textBox4.Text);
            cv.SendMailAsync(msg);

            MessageBox.Show("Password Reset Check Mail");


            try
            {
                db.Myconnection();
                string query = "update reception set password = '" + password + "'where email ='" + recipient + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, DB.con);
                sda.SelectCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error Try Again");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");


            if (reg.IsMatch(textBox1.Text) == false)
            {
                MessageBox.Show("Enter valid Email");
                textBox1.Focus();
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");


            if (reg.IsMatch(textBox3.Text) == false)
            {
                MessageBox.Show("Enter valid Email");
                textBox3.Focus();
            }

        }
    }
}
