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

namespace Ishod06
{
    public partial class Form1 : Form
    {
        private String cs = @"Server=.\SQLEXPRESS;Integrated security=true;Initial catalog=AdventureWorksOBP";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            napuniKupce();
        }

        private void napuniKupce()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT TOP 10 * FROM Kupac";
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.HasRows)
                        {
                            dt.Load(r);
                            gvKupac.DataSource = dt;
                        }
                    }
                }
            }
        }
    }
}
