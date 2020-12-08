using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_FORMS
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public String id
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
