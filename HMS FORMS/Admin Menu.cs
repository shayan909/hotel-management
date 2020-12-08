using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_FORMS
{
    public partial class Admin_Menu : Form
    {
        public Admin_Menu()
        {
            InitializeComponent();
        }

        
     

        private void PaymentRecordbtn_Click(object sender, EventArgs e)
        {
            Admin_Payment_Record childForm = new Admin_Payment_Record();
            AddOwnedForm(childForm);
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Receptionist_Click(object sender, EventArgs e)
        {
            Receptionist_Information childForm = new Receptionist_Information();
            AddOwnedForm(childForm);
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void Servicesbtn_Click(object sender, EventArgs e)
        {
            Services childForm = new Services();
            AddOwnedForm(childForm);
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Admin_Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 271)
            {
                panel1.Width = 46;
                button1.Left = 4;
            }
            else if (panel1.Width == 46)
            {
               
                panel1.Width = 271;
                button1.Left = 220;

            }
        }

        private void CustomerRecordbtb_Click_1(object sender, EventArgs e)
        {
            Admin_Customer_Record childForm = new Admin_Customer_Record();
            AddOwnedForm(childForm);
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void AvailableRoomsbtn_Click(object sender, EventArgs e)
        {
            AdminRooms childForm = new AdminRooms();
            AddOwnedForm(childForm);
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Bookingbtn_Click_1(object sender, EventArgs e)
        {
            AdminBooking childForm = new AdminBooking();
            AddOwnedForm(childForm);
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void CheckStatusbtn_Click(object sender, EventArgs e)
        {
            Services sr = new Services();
            sr.ShowDialog();
           
        }

        private void Notificationsbtn_Click(object sender, EventArgs e)
        {
            Receptionist_Information childForm = new Receptionist_Information();
            AddOwnedForm(childForm);
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Login lg = new Login();
            lg.Show();
            
        }

        private void Paymentbtn_Click(object sender, EventArgs e)
        {
            Admin_Payment_Record childForm = new Admin_Payment_Record();
            AddOwnedForm(childForm);
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Admin_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
    }
}
