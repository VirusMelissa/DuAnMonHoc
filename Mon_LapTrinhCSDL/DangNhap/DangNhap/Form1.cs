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

namespace DangNhap
{
    public partial class dangnhap : Form
    {
        SqlConnection conn = new SqlConnection("data source=MAY10" + "\\" + "MAY10; initial catalog = QLBH_1004_TEST; integrated security=true");
        string @user, @pass;
        public dangnhap()
        {
            InitializeComponent();
        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            if (txtdangnhap.Text == "" || txtmatkhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu");
            }
            else
            {
                string KN = "select * from TAIKHOAN where UserName= '" + txtdangnhap.Text + "' and Password= '" + txtmatkhau.Text + "' and status=1";
                SqlCommand cmd = new SqlCommand(KN, conn);
                conn.Open();

                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    DanhSach fr = new DanhSach();
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

        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));

            if (thongbao == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btdangnhap2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from TAIKHOAN where UserName= @user and Password= @pass and status=1", conn);
            
            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@user";
            p1.Value = txtdangnhap.Text;
            cmd.Parameters.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@pass";
            p2.Value = txtmatkhau.Text;
            cmd.Parameters.Add(p2);

            MessageBox.Show(cmd.CommandText);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công!");
                DanhSach fr = new DanhSach();
                fr.Show();
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
