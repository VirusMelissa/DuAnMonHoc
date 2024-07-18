using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ChuongTrinhDauTien
{
    public partial class ThongtinSV : Form
    {
        public ThongtinSV()
        {
            InitializeComponent();
        }


        private void HovaTen_TextChanged(object sender, EventArgs e)
        {
            //HovaTen.Multiline = true;
            HovaTen.ScrollBars = ScrollBars.Vertical; 
            HovaTen.Size = new System.Drawing.Size(200, 50);
        }

        private void SDT_TextChanged(object sender, EventArgs e)
        {
            //SDT.MaxLength = 10;
            //SDT.BorderStyle = BorderStyle.Fixed3D;
            //SDT.BackColor = Color.Yellow;
            //SDT.ForeColor = Color.Red;
            //SDT.UseSystemPasswordChar = true;
            //SDT.PasswordChar = '?';
        }

        private void DiaChi_MouseHover(object sender, EventArgs e)
        {
            DiaChi.BackColor = Color.Yellow;
            DiaChi.ForeColor = Color.Red;
        }

        private void DiaChi_MouseLeave(object sender, EventArgs e)
        {
            DiaChi.BackColor = Color.Red;
            DiaChi.ForeColor = Color.Yellow;
        }

        private void DiemTT_Leave(object sender, EventArgs e)
        {
            if (DiemTT.Text != "")
            {
                DiemTT.Visible = false;
            }
        }

        private void HeLop_Leave(object sender, EventArgs e)
        {
            if (HeLop.Text != "")
            {
                HeLop.Enabled = false;
            }
        }

        private void HovaTen_Leave(object sender, EventArgs e)
        {
            if (HovaTen.Text != "")
            {
                //HovaTen.ReadOnly = true;
                HovaTen.Font = new Font(HovaTen.Font, FontStyle.Bold);
            }
        }

        private void HocPhi_Leave(object sender, EventArgs e)
        {
            if (HocPhi.Text != "")
            {
                //System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                //decimal value = decimal.Parse(HocPhi.Text, System.Globalization.NumberStyles.AllowThousands);
                //HocPhi.Text = String.Format(culture, "{0:N0}", value);
                //HocPhi.Select(HocPhi.Text.Length, 0);
                double HP;
                HP = Convert.ToDouble(HocPhi.Text);
                HocPhi.Text = HP.ToString("#,###");
            }
        }

        private void DiemTT_MouseHover(object sender, EventArgs e) 
        {
            Tool1.SetToolTip(this. DiemTT, "Nhập điểm vào");
            DiemTT.Cursor = Cursors.Hand;
        }

        private void HocPhi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
