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
    public partial class FormLoiChao : Form
    {
        public FormLoiChao()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnChao_Click(object sender, EventArgs e)
        {
                // chào trong textbox
                txtChao.Text  = "Chào bạn: " + txtTen.Text + " Đến với C#";
               //chào trong button
                chao.Text = "Chào bạn: " + txtTen.Text + " Đến với C#";
               //đổi màu chữ button
                chao.ForeColor = Color.Blue;
                txtTen.ForeColor = Color.Blue;
                txtChao.ForeColor = Color.Blue;
                label1.ForeColor = Color.Yellow;
                label2.ForeColor = Color.Yellow;
                label3.ForeColor = Color.Yellow;
                btnChao.BackColor = Color.Green;
                btnThoat.BackColor = Color.Green;
                btnXoa.BackColor = Color.Green;
               //chào trong tiêu đề form
                this.Text = "Chào bạn: " + txtTen.Text + " Đến với C#";
                txtTen.Text = txtTen.Text + " " + "Chào bạn: " + txtTen.Text + " Đến với C#";
               //đổi màu nền form
                this.BackColor = Color.Red;
               //chào trong thông báo box
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Chào bạn: " + txtTen.Text + " Đến với C#?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk));
                if (thongbao == DialogResult.OK)
                Application.Restart();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtTen.Clear(); this.txtChao.Clear(); this.chao.ResetText(); this.Text = String.Empty;
            this.txtTen.Focus();
            this.BackColor = Color.Empty;
            chao.ForeColor = Color.Empty;
            txtTen.ForeColor = Color.Empty;
            txtChao.ForeColor = Color.Empty;
            label1.ForeColor = Color.Empty;
            label2.ForeColor = Color.Empty;
            label3.ForeColor = Color.Empty;
            btnChao.BackColor = Color.Empty;
            btnThoat.BackColor = Color.Empty;
            btnXoa.BackColor = Color.Empty;
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát không?"
            + "\n" + "Nếu thoát thì bấm 'Yes'"
            + "\n" + "Nếu restart thì bấm 'No'"
            , "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning));

            if (thongbao == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (thongbao == DialogResult.No)
            {
                Application.Restart();
            }
            else this.BackColor = Color.Red;
        }

        private void btBien_Click(object sender, EventArgs e)
        {
            //Biến kết quả = điều kiện ? biểu thức đúng : biểu thức sai
            txtChao.Text = txtTen.Text == "Hiếu" ? "Đúng" : "Sai";
        }

        private void txtChao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
