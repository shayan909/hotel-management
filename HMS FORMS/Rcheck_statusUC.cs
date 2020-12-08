using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HMS_FORMS
{
    public partial class Rcheck_statusUC : UserControl
    {
        public Rcheck_statusUC()
        {
            InitializeComponent();
        }

        private void Rcheck_statusUC_Load(object sender, EventArgs e)
        {

        }
        DB db = new DB();
      
        public void updateCheck()
        {
            try
            {
                db.Myconnection();



                String sqlinsert = "update room set check_status='" + comboBox1.Text + "' where roomID='" + comboBox2.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(sqlinsert, DB.con);
                SDA.SelectCommand.ExecuteNonQuery();
                label4.Text = comboBox1.Text;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }



      

        private void OKbtn_Click_1(object sender, EventArgs e)
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

                comboBox2.DisplayMember = "roomID";
                comboBox2.ValueMember = "roomID";
                comboBox2.DataSource = ds.Tables["room"];
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.roomTableAdapter.Fill(this.zabHotelDataSet10.room);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

