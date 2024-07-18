using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhap
{
    public partial class DanhSach : Form
    {
        public DanhSach()
        {
            InitializeComponent();
        }

        private void DanhSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_1004_TESTDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qLBH_1004_TESTDataSet.KHACHHANG);

        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            dangnhap fr = new dangnhap();
            fr.Show();
            this.Hide();
        }
    }
}
