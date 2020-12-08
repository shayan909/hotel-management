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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }
        DB db = new DB();
        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Services_Insert chlid = new Services_Insert();
            chlid.MdiParent = this;
            chlid.Show();
            dataGridView1.Hide();
       
            label1.Hide();
          
        }

        private void manipulateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Services_Maipulate chlid = new Services_Maipulate();
            chlid.MdiParent = this;
            chlid.Show();
            dataGridView1.Hide();
           
            label1.Hide();
            
        }

        private void Services_Load(object sender, EventArgs e)
        {

        }

        private void ViewAllbtn_Click(object sender, EventArgs e)
        {
            try
            {
                String sqlview = "SELECT * FROM services";
                SqlDataAdapter SDA = new SqlDataAdapter(sqlview, DB.con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
            
        }
    }
}
