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
    public partial class DemTextBox : Form
    {
        public DemTextBox()
        {
            InitializeComponent();
        }

        private void Number_TextChanged(object sender, EventArgs e)
        {
            switch (Number.Text)
            {
                case "1":
                    N1.Visible = true;
                    N2.Visible = false;
                    N3.Visible = false;
                    N4.Visible = false;
                    N5.Visible = false;
                    N6.Visible = false;
                    N7.Visible = false;
                    N8.Visible = false;
                    N9.Visible = false;
                    N10.Visible = false;
                    break;
                case "2":
                    N1.Visible = true;
                    N2.Visible = true;
                    N3.Visible = false;
                    N4.Visible = false;
                    N5.Visible = false;
                    N6.Visible = false;
                    N7.Visible = false;
                    N8.Visible = false;
                    N9.Visible = false;
                    N10.Visible = false;
                    break;
                case "3":
                    N1.Visible = true;
                    N2.Visible = true;
                    N3.Visible = true;
                    N4.Visible = false;
                    N5.Visible = false;
                    N6.Visible = false;
                    N7.Visible = false;
                    N8.Visible = false;
                    N9.Visible = false;
                    N10.Visible = false;
                    break;
                case "4":
                    N1.Visible = true;
                    N2.Visible = true;
                    N3.Visible = true;
                    N4.Visible = true;
                    N5.Visible = false;
                    N6.Visible = false;
                    N7.Visible = false;
                    N8.Visible = false;
                    N9.Visible = false;
                    N10.Visible = false;
                    break;
                case "5":
                    N1.Visible = true;
                    N2.Visible = true;
                    N3.Visible = true;
                    N4.Visible = true;
                    N5.Visible = true;
                    N6.Visible = false;
                    N7.Visible = false;
                    N8.Visible = false;
                    N9.Visible = false;
                    N10.Visible = false;
                    break;
                case "6":
                    N1.Visible = true;
                    N2.Visible = true;
                    N3.Visible = true;
                    N4.Visible = true;
                    N5.Visible = true;
                    N6.Visible = true;
                    N7.Visible = false;
                    N8.Visible = false;
                    N9.Visible = false;
                    N10.Visible = false;
                    break;
                case "7":
                    N1.Visible = true;
                    N2.Visible = true;
                    N3.Visible = true;
                    N4.Visible = true;
                    N5.Visible = true;
                    N6.Visible = true;
                    N7.Visible = true;
                    N8.Visible = false;
                    N9.Visible = false;
                    N10.Visible = false;
                    break;
                case "8":
                    N1.Visible = true;
                    N2.Visible = true;
                    N3.Visible = true;
                    N4.Visible = true;
                    N5.Visible = true;
                    N6.Visible = true;
                    N7.Visible = true;
                    N8.Visible = true;
                    N9.Visible = false;
                    N10.Visible = false;
                    break;
                case "9":
                    N1.Visible = true;
                    N2.Visible = true;
                    N3.Visible = true;
                    N4.Visible = true;
                    N5.Visible = true;
                    N6.Visible = true;
                    N7.Visible = true;
                    N8.Visible = true;
                    N9.Visible = true;
                    N10.Visible = false;
                    break;
                case "10":
                    N1.Visible = true;
                    N2.Visible = true;
                    N3.Visible = true;
                    N4.Visible = true;
                    N5.Visible = true;
                    N6.Visible = true;
                    N7.Visible = true;
                    N8.Visible = true;
                    N9.Visible = true;
                    N10.Visible = true;
                    break;
                case "":
                    N1.Visible = false;
                    N2.Visible = false;
                    N3.Visible = false;
                    N4.Visible = false;
                    N5.Visible = false;
                    N6.Visible = false;
                    N7.Visible = false;
                    N8.Visible = false;
                    N9.Visible = false;
                    N10.Visible = false;
                    break;
                default:
                    N1.Visible = false;
                    N2.Visible = false;
                    N3.Visible = false;
                    N4.Visible = false;
                    N5.Visible = false;
                    N6.Visible = false;
                    N7.Visible = false;
                    N8.Visible = false;
                    N9.Visible = false;
                    N10.Visible = false;
                    DialogResult thongbao;
                    thongbao = (MessageBox.Show("Bạn nhập sai. Hãy Nhập từ 1-10", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning));
                    if (thongbao == DialogResult.OK)
                        this.Number.Clear();
                    break;
            }
            /*if (Number.Text == "1")
            {
                N1.Visible = true;
            }
            else if(Number.Text == "2")
            {
                N1.Visible = true;
                N2.Visible = true;
            }
            else if (Number.Text == "3")
            {
                N1.Visible = true;
                N2.Visible = true;
                N3.Visible = true;
            }
            else if (Number.Text == "4")
            {
                N1.Visible = true;
                N2.Visible = true;
                N3.Visible = true;
                N4.Visible = true;
            }
            else if (Number.Text == "5")
            {
                N1.Visible = true;
                N2.Visible = true;
                N3.Visible = true;
                N4.Visible = true;
                N5.Visible = true;
            }
            else if (Number.Text == "6")
            {
                N1.Visible = true;
                N2.Visible = true;
                N3.Visible = true;
                N4.Visible = true;
                N5.Visible = true;
                N6.Visible = true;
            }
            else if (Number.Text == "7")
            {
                N1.Visible = true;
                N2.Visible = true;
                N3.Visible = true;
                N4.Visible = true;
                N5.Visible = true;
                N6.Visible = true;
                N7.Visible = true;
            }
            else if (Number.Text == "8")
            {
                N1.Visible = true;
                N2.Visible = true;
                N3.Visible = true;
                N4.Visible = true;
                N5.Visible = true;
                N6.Visible = true;
                N7.Visible = true;
                N8.Visible = true;
            }
            else if (Number.Text == "9")
            {
                N1.Visible = true;
                N2.Visible = true;
                N3.Visible = true;
                N4.Visible = true;
                N5.Visible = true;
                N6.Visible = true;
                N7.Visible = true;
                N8.Visible = true;
                N9.Visible = true;
            }
            else if (Number.Text == "10")
            {
                N1.Visible = true;
                N2.Visible = true;
                N3.Visible = true;
                N4.Visible = true;
                N5.Visible = true;
                N6.Visible = true;
                N7.Visible = true;
                N8.Visible = true;
                N9.Visible = true;
                N10.Visible = true;
            }
            else
            {
                MessageBox.Show("Bạn phải nhập từ 1-10");
            }*/
        }

        private void DemTextBox_Load(object sender, EventArgs e)
        {
            N1.Visible = false;
            N2.Visible = false;
            N3.Visible = false;
            N4.Visible = false;
            N5.Visible = false;
            N6.Visible = false;
            N7.Visible = false;
            N8.Visible = false;
            N9.Visible = false;
            N10.Visible = false;
        }

    }
}
