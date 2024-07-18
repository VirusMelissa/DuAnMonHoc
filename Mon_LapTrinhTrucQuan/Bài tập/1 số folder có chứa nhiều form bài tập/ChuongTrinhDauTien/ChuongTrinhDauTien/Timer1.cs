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
    public partial class Timer1 : Form
    {
        public Timer1()
        {
            InitializeComponent();
        }
        int gio, phut, giay, i = 0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            i++;
            int x = i % 2;
            if (x == 0)
            {
                txtThongBao.BackColor = Color.Red;
            }
            else txtThongBao.BackColor = Color.White;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            txtGio.Text = gio.ToString();
            txtPhut.Text = phut.ToString();
            txtGiay.Text = giay.ToString();
            if (gio > 0)
            {
                if (phut > 0)
                {
                    if (giay > 0)
                    {
                        giay--;
                    }
                    else
                    {
                        giay = 59;
                        phut--;
                    }
                }
                else
                {
                    phut = 59;
                    gio--;
                }
            }
            else if (gio == 0)
            {
                if (phut > 0)
                {
                    if (giay > 0)
                    {
                        giay--;
                    }
                    else
                    {
                        giay = 59;
                        phut--;

                    }
                }
                else
                {
                    giay--;
                }
            }
            if (gio == 0 && phut == 0 && giay == 30)
            {
                txtThongBao.Text = "bạn đã hết giờ ";
                timer2.Start();
            }
            /*
            else if (gio == 0 && phut == 0 && giay == 29)
            {
                txtThongBao.BackColor = Color.Red;
            }
            else if (gio == 0 && phut == 0 && giay == 28)
            {
                txtThongBao.BackColor = Color.White;
            }
            else if (gio == 0 && phut == 0 && giay == 27)
            {
                txtThongBao.BackColor = Color.Red;
            }
            else if (gio == 0 && phut == 0 && giay == 26)
            {
                txtThongBao.BackColor = Color.White;
            }
            else if (gio == 0 && phut == 0 && giay == 25)
            {
                txtThongBao.BackColor = Color.Red;
            }
            else if (gio == 0 && phut == 0 && giay == 24)
            {
                txtThongBao.BackColor = Color.White;
            }
            */
            else if (gio == 0 && phut == 0 && giay == 0)
            {
                Timer.Stop();
                timer2.Stop();
                txtThongBao.BackColor = Color.White;
                txtHoTen.Enabled = false;
                txtThongBao.Text = "bạn đã hết giờ ";
            }
            
        }

        private void btBatDau_Click(object sender, EventArgs e)
        {
            gio = int.Parse(txtGio.Text);
            phut = int.Parse(txtPhut.Text);
            giay = int.Parse(txtGiay.Text);
            Timer.Enabled = true;
            Timer.Start();
        }
    }
}
