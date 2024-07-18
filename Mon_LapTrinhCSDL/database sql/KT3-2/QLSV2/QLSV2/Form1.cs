using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV2
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
            this.Visible = false;
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn Thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void danhsach_Click(object sender, EventArgs e)
        {
            danhsach fr = new danhsach();
            fr.Show();
            this.Visible = false;
        }

        private void ketqua_Click(object sender, EventArgs e)
        {
            ketqua fr = new ketqua();
            fr.Show();
            this.Visible = false;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            danhsach.Enabled = false;
            ketqua.Enabled = false;
        }
    }
}
