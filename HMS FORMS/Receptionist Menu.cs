using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_FORMS
{
    public partial class Receptionist_Menu : Form
    {
        public Receptionist_Menu(string strTextBox)
        {
            InitializeComponent();
            label2.Text = strTextBox;
            
        }
        public Receptionist_Menu()
        {
            InitializeComponent();
          
        }

        private void Receptionist_Menu_Load(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                db.Myconnection();
                string query = "select first_name from reception where receptionID =" + label2.Text + "";
                SqlCommand sq = new SqlCommand(query, DB.con);
                sq.ExecuteNonQuery();
                string id = (string)sq.ExecuteScalar();

                label3.Text = id;
            }
            catch { MessageBox.Show("Unable to retrive reeptionist name");
            }

        }
        private void Bookingbtn_Click(object sender, EventArgs e)
        {
            booking childForm = new booking();
            AddOwnedForm(childForm);
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            childForm.textBox2.Text = this.label2.Text;
            }

        private void CustomerRecordbtb_Click(object sender, EventArgs e)
        {



            // Receptionist_Customer_Records childForm = new Receptionist_Customer_Records();
            // AddOwnedForm(childForm);
            // childForm.FormBorderStyle = FormBorderStyle.None;
            // childForm.TopLevel = false;
            // childForm.Dock = DockStyle.Fill;
            // this.Controls.Add(childForm);
            // this.Tag = childForm;
            // childForm.BringToFront();
            //childForm.Show();

            rcustUC1.BringToFront();
            rcustUC1.Show();
            
        }

        private void AvailableRoomsbtn_Click(object sender, EventArgs e)
        {
            //Receptionist_Available_Rooms childForm = new Receptionist_Available_Rooms();
            //AddOwnedForm(childForm);
            //childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.TopLevel = false;
            //childForm.Dock = DockStyle.Fill;
            //this.Controls.Add(childForm);
            //this.Tag = childForm;
            //childForm.BringToFront();
            //childForm.Show();
            rAvailRoomUC1.availRooms();
            rAvailRoomUC1.BringToFront();
            rAvailRoomUC1.Show();
        }

        private void CheckStatusbtn_Click(object sender, EventArgs e)
        {
            //Receptionist_Check_Status childForm = new Receptionist_Check_Status();
            //AddOwnedForm(childForm);
            //childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.TopLevel = false;
            //childForm.Dock = DockStyle.Fill;
            //this.Controls.Add(childForm);
            //this.Tag = childForm;
            //childForm.BringToFront();
            //childForm.Show();
            rcheck_statusUC1.BringToFront();
            rcheck_statusUC1.Show();

        }

        private void Notificationsbtn_Click(object sender, EventArgs e)
        {
            //Receptionist_Notifications childForm = new Receptionist_Notifications();
            //AddOwnedForm(childForm);
            //childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.TopLevel = false;
            //childForm.Dock = DockStyle.Fill;
            //this.Controls.Add(childForm);
            //this.Tag = childForm;
            //childForm.BringToFront();
            //childForm.Show();

            example1.notify();
            example1.BringToFront();
            example1.Show();

        }

        private void Paymentbtn_Click(object sender, EventArgs e)
        {
            //    Receptionist_Payment childForm = new Receptionist_Payment();
            //    AddOwnedForm(childForm);
            //    childForm.FormBorderStyle = FormBorderStyle.None;
            //    childForm.TopLevel = false;
            //    childForm.Dock = DockStyle.Fill;
            //    this.Controls.Add(childForm);
            //    this.Tag = childForm;
            //    childForm.BringToFront();
            //    childForm.Show();

            rpaymentUC1.BringToFront();
            
            rpaymentUC1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Width ==271)
            {
                
                panel1.Width = 49;
                button1.Left = 4;

            }
            else if (panel1.Width == 49)
            {
                panel1.Width = 271;
              button1.Left = 220;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {


            rServicesUC2.BringToFront();
            rServicesUC2.Show();


            //Reception_Service childForm = new Reception_Service();


            //AddOwnedForm(childForm);
            //childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.TopLevel = false;
            //childForm.Dock = DockStyle.Fill;
            //this.Controls.Add(childForm);
            //this.Tag = childForm;
            //childForm.BringToFront();
            //childForm.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Login lg = new Login();
            lg.Show();
            
        }

        private void Receptionist_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.025;
            }
            else
            {
                timer1.Stop();
                this.Hide();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbookingUC1_Load(object sender, EventArgs e)
        {

        }

        private void rcheck_statusUC1_Load(object sender, EventArgs e)
        {

        }
    }
}
