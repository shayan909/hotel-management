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
    public partial class RAvailRoomUC : UserControl
    {
        public RAvailRoomUC()
        {
            InitializeComponent();
        }

        private void RAvailRoomUC_Load(object sender, EventArgs e)
        {
            availRooms();
        }
        DB db = new DB();


    

        public void availRooms()
        {
            try
            {
                db.Myconnection();

                String sqlview = "select * from room where status !='occupied'";

                SqlDataAdapter SDA = new SqlDataAdapter(sqlview, DB.con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            catch
            {
                MessageBox.Show("Error Try Again");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}

