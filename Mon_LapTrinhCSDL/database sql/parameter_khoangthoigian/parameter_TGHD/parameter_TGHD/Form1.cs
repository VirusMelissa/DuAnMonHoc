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

namespace parameter_TGHD
{
    public partial class Form1 : Form
    {
        string KN = "data source=ADMIN" + "\\" + "SQLEXPRESS; initial catalog = QLBH_1004_TEST; integrated security = true";
        SqlDataAdapter da = null;
        DataTable dt = null;
        int @tu, @den;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            // TODO: This line of code loads data into the 'qLBH_1004_TESTDataSet.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.qLBH_1004_TESTDataSet.HOADON);

        }

        private void btlietke_Click(object sender, EventArgs e)
        {           
            SqlConnection conn = new SqlConnection(KN);
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from HOADON where TRIGIA between @tu and @den", conn);

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@tu";
            p1.Value = int.Parse(txttu.Text);
            cmd.Parameters.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@den";
            p2.Value = int.Parse(txtden.Text);
            cmd.Parameters.Add(p2);

            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
