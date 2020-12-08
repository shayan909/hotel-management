using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace HMS_FORMS
{
    class DB
    {

        public static SqlConnection con = null;
        public void Myconnection()
        {
            con = new SqlConnection
            (@"Data Source=DESKTOP-5HA0D6L;Initial Catalog=zabHotel;Integrated Security=True");
            con.Open();
        }
    }
}
