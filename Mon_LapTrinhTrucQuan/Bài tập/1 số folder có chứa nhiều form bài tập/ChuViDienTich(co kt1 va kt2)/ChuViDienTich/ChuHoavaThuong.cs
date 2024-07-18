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
    public partial class ChuHoavaThuong : Form
    {
        public ChuHoavaThuong()
        {
            InitializeComponent();
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
                string s = NhapA.Text.Trim();
                while (s.IndexOf(" ") >= 0)
                    s = s.Replace(" ", " ");
                if (radioHoa.Checked == true)
                    KetQua.Text = s.ToUpper();
                if (radioThuong.Checked == true)
                    KetQua.Text = s.ToLower();
        }

        private void NhapA_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
