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
    public partial class Receptionist_Check_Status : Form
    {
        public Receptionist_Check_Status()
        {
            InitializeComponent();
        }
        DB db = new DB();
        private void Receptionist_Check_Status_Load(object sender, EventArgs e)
        {

        }


        public void updateCheck()
        {
            try
            {
                db.Myconnection();



                String sqlinsert = "update room set check_status='" + comboBox1.Text + "' where roomID='" + comboBox1.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(sqlinsert, DB.con);
                SDA.SelectCommand.ExecuteNonQuery();
                label4.Text = comboBox1.Text;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }


        private void OKbtn_Click(object sender, EventArgs e)
        {

            updateCheck();



        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                db.Myconnection();
                String sqlview = "SELECT roomID FROM room,booking where room.roomID=booking.room_number and bk_status='valid'";

                SqlDataAdapter da = new SqlDataAdapter(sqlview, DB.con);
                DataSet ds = new DataSet();
                da.Fill(ds, "room");

                comboBox1.DisplayMember = "roomID";
                comboBox1.ValueMember = "roomID";
                comboBox1.DataSource = ds.Tables["room"];
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
    }
}
