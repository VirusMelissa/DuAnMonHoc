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

namespace thithu
{
    public partial class dangnhap : Form
    {
        SqlConnection conn = new SqlConnection("data source=ADMIN" + "\\" + "SQLEXPRESS; initial catalog = QLBH_1004_TEST2; integrated security=true");
        string @user, @pass;
        public dangnhap()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (thongbao == DialogResult.Yes)
            {
                Menu fr = new Menu();
                fr.Show();
                this.Hide();
            }
        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from TAIKHOAN where username = @user and password = @pass and status=1", conn);

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
            if(rd.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công");
                Menu fr = new Menu();
                fr.Show();
                fr.danhmuc.Enabled = true;
                fr.chitietbanhang.Enabled = true;
                fr.inhoadon.Enabled = true;
                this.Hide();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công");
                txtdangnhap.ResetText();
                txtmatkhau.ResetText();
                conn.Close();
            }
        }
    }
}
