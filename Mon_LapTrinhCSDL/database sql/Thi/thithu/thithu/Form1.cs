using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thithu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void dangnhap_Click(object sender, EventArgs e)
        {
            dangnhap fr = new dangnhap();
            fr.Show();
            this.Hide();
        }

        private void danhmucsanpham_Click(object sender, EventArgs e)
        {
            danhmucsanpham fr = new danhmucsanpham();
            fr.Show();
            this.Hide();
        }

        private void chitietbanhang_Click(object sender, EventArgs e)
        {
            chitietbanhang fr = new chitietbanhang();
            fr.Show();
            this.Hide();
        }

        private void inhoadon_Click(object sender, EventArgs e)
        {
            inhoadon fr = new inhoadon();
            fr.Show();
            this.Hide();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(thongbao == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            danhmuc.Enabled = false;
            chitietbanhang.Enabled = false;
            inhoadon.Enabled = false;
        }
    }
}
