using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ChuViDienTich
{
    public partial class ChuViDienTich : Form
    {
        public ChuViDienTich()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(NhapA.Text);
            b = Convert.ToInt32(NhapB.Text);
            if (a > 0 && b > 0) 
            {
                ChuVi.Text = Convert.ToString((a + b) * 2); 
                DienTich.Text = Convert.ToString(a * b);
            }
            else 
            {
                btXoa.BackColor = Color.Red;
                btThoat.BackColor = Color.Red;
                btTinh.Visible = false;
                MessageBox.Show("Bạn nhập sai dữ liệu");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NhapB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ChuViDienTich_Load(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            this.NhapA.Clear(); this.NhapB.Clear();
            this.ChuVi.Clear(); this.DienTich.Clear();
            this.NhapA.Focus();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Ok chưa?", "Thông báo", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning));
            if (thongbao == DialogResult.OK)
            Application.Exit();
        }

        private void ChuVi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DienTich_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void NhapA_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void NhapB_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
