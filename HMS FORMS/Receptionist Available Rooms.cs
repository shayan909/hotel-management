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
    public partial class Receptionist_Available_Rooms : Form
    {
        public Receptionist_Available_Rooms()
        {
            InitializeComponent();
        }

        DB db = new DB();


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            String sqlview = "SELECT * FROM info";
            SqlDataAdapter SDA = new SqlDataAdapter(sqlview, DB.con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
           

        }

        public void availRooms()
        {
            try
            {
                db.Myconnection();




                String sqlview = "select * from room where status='vacant'";

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

        private void Receptionist_Available_Rooms_Load(object sender, EventArgs e)
        {
            availRooms();
        }
    }
}
