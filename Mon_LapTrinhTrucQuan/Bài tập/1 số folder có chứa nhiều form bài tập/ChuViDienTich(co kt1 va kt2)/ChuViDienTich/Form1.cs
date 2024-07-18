using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuViDienTich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Tinh_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(NhapA.Text);
            b = Convert.ToInt32(NhapB.Text);
            if (a > 0 && b > 0)
            {
                ChuVi.Text = Convert.ToString((a + b) * 2);
                DienTich.Text = Convert.ToString(a * b);
            }
            else { MessageBox.Show("Nhập bậy không. Hãy nhập đúng vào"); }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            this.NhapA.Clear(); this.NhapB.Clear();
            this.ChuVi.Clear(); this.DienTich.Clear();
            this.NhapA.Focus();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Ok chưa?", "Thông báo", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning));
            if (thongbao == DialogResult.OK)
                Application.Exit();
        }
    }
}
