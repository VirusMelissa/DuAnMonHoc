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

namespace QLNV
{
    public partial class DangNhap : Form
    {
        SqlConnection conn = new SqlConnection("data source=MAY10" + "\\" + "MAY10; initial catalog = QLNV; integrated security=true");
        string @user, @pass;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {

        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from TAIKHOAN where username= @user and password= @pass and active=1", conn);

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@user";
            p1.Value = txtdangnhap.Text;
            cmd.Parameters.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@pass";
            p2.Value = txtmatkhau.Text;
            cmd.Parameters.Add(p2);

            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công!");
                danhsach fr = new danhsach();
                fr.Show();
                this.Hide();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập mém thành công!");
                conn.Close();
            }
        }
    }
}
