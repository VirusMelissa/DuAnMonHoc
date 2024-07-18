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
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            txtHoTen.Text = i.ToString();
        }

        private void btbatdau_Click(object sender, EventArgs e)
        {
            //int n = 60;
            //x = e
            timer1.Enabled = !timer1.Enabled;
            i = 0;
            btbatdau.Text = btbatdau.Text == "Dừng" ? "Chạy" : "Dừng";
        }
    }
}
