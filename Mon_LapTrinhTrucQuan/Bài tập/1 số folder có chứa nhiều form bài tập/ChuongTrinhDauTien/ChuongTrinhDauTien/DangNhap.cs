using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhDauTien
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(pass.Text != "")
            {
                pass.PasswordChar = '*';
            }
        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            //+ System.Environment.NewLine +: xuống dòng
            //+ "\n" +: xuống dòng
            if(CBghi_nho.Checked == true)
            {
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Tên Đăng nhập là:" + " " + tendangnhap.Text
                + "\n" + " " + "\n" +
                "Mật Khẩu là:" + " " + pass.Text
                + "\n" + " " + "\n" +
                "Đây là ghi chú", "Thông báo", MessageBoxButtons.OK));
            }
            else
            {
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Tên Đăng nhập là:" + " " + tendangnhap.Text
                + "\n" + " " + "\n" +
                "Mật Khẩu là:" + " " + pass.Text, "Thông báo", MessageBoxButtons.OK));
            }
        }
    }
}
