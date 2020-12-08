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
    public partial class Receptionist_Payment : Form
    {
        public Receptionist_Payment()
        {
            InitializeComponent();
        }
        DB db = new DB();

        public string date = DateTime.Today.ToString();

        private void Receptionist_Payment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zabHotelDataSet7.booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.zabHotelDataSet7.booking);

        }

        private void Donebtn_Click(object sender, EventArgs e)
        {
            totalAmt();
            getServices();
           
            insertPay();
            UpdateRoom();
            updateBooking();
            rcept();

            comboBox2.ResetText();

        }

        public void rcept()
        {
            richTextBox1.Text+="************ZAB HOTEL***********\n";
            richTextBox1.Text += "Total Amount: " + totalAmt() +"\n\n\n";
            richTextBox1.Text += "Services: " + getServices() + "\n";
            richTextBox1.Text += "Date: " + date + "\n";
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrcode.Draw("total amount: "+totalAmt().ToString(), 25);
        }

        public double totalAmt()
        {
            double amt = 0;

            try
            {
                db.Myconnection();
                string totalamt = "select isnull((select sum(price) from services,booking_service where services.serviceID=booking_service.services_id and booking_id=" + comboBox2.Text + "),0)+(select amount*days from room_type,room,booking where room_type.roomtypeID=room.room_type_id and booking.room_number=room.roomID and BookingID=" + comboBox2.Text + ")";
                SqlCommand SDA = new SqlCommand(totalamt, DB.con);
                amt = (double)SDA.ExecuteScalar();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return amt;
        }

        public string getServices()
        {
            string name = "";
            try
            {
                string sevrviceQ = "select name from services,booking_service where services.serviceID=booking_service.services_id and booking_id=" + comboBox2.Text + "";
                db.Myconnection();

                SqlCommand SDA = new SqlCommand(sevrviceQ, DB.con);
                 name = (string)SDA.ExecuteScalar();

            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


            return name;


         }
        
        
        public void insertPay()
        {
        

            try
            {
                db.Myconnection();
                string insertsql = "insert into payment (amount,type,date,booking_id) values(" + totalAmt() + "," + ("'") + comboBox1.Text + ("'") + "," + date + "," + comboBox2.Text + ")";
                SqlCommand SDA = new SqlCommand(insertsql, DB.con);
                SDA.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void UpdateRoom()
        {
            try
            {
                db.Myconnection();
                string sqlupdate = "UPDATE R SET R.status = 'vacant' FROM dbo.room AS R INNER JOIN dbo.booking P ON R.roomID = P.room_number WHERE P.BookingID =" + comboBox2.Text + "";
                SqlCommand SDA = new SqlCommand(sqlupdate, DB.con);
                SDA.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        public void updateBooking()
        {
            try {
                db.Myconnection();
                string sqlupdate = "update booking set bk_status='expired' where bookingID='"+comboBox2.Text+"'"; 
            SqlCommand SDA = new SqlCommand(sqlupdate, DB.con);
                SDA.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bookingTableAdapter.Fill(this.zabHotelDataSet7.booking);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox2_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox2.Text == "")
            {
                errorProvider1.SetError(comboBox2, "Please select Room");
                comboBox2.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if(comboBox1.Text == "")
            {
                errorProvider1.SetError(comboBox1, "Please select payment method");
                comboBox1.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
