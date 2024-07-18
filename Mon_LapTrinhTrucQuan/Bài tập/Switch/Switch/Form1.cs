using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //đổi năm dương lịch thành năm âm lịch
            /*
            int namduong;
            string Can = "";
            string Chi = "";
            namduong = Convert.ToInt32(textBox1.Text);
            if (namduong < 0)
            {
                MessageBox.Show("Nhập sai!");
            }
            else
            {
                switch (namduong % 10)
                {
                    case 0:
                        Can = "Canh";
                        break;
                    case 1:
                        Can = "Tân";
                        break;
                    case 2:
                        Can = "Nhâm";
                        break;
                    case 3:
                        Can = "Quý";
                        break;
                    case 4:
                        Can = "Giáp";
                        break;
                    case 5:
                        Can = "Ất";
                        break;
                    case 6:
                        Can = "Bính";
                        break;
                    case 7:
                        Can = "Đinh";
                        break;
                    case 8:
                        Can = "Mậu";
                        break;
                    case 9:
                        Can = "Kỷ";
                        break;
                }
                switch (namduong % 12)
                {
                    case 0:
                        Chi = "Thân";
                        break;
                    case 1:
                        Chi = "Dậu";
                        break;
                    case 2:
                        Chi = "Tuất";
                        break;
                    case 3:
                        Chi = "Hợi";
                        break;
                    case 4:
                        Chi = "Tí";
                        break;
                    case 5:
                        Chi = "Sửu";
                        break;
                    case 6:
                        Chi = "Dần";
                        break;
                    case 7:
                        Chi = "Mão";
                        break;
                    case 8:
                        Chi = "Thìn";
                        break;
                    case 9:
                        Chi = "Tỵ";
                        break;
                    case 10:
                        Chi = "Ngọ";
                        break;
                    case 11:
                        Chi = "Mùi";
                        break;
                }
                labelHienThi.Text = "Năm " + namduong.ToString() + " là năm " + Can + " " + Chi;
            }*/

            
            //xuất ra tuần mấy khi nhập ngày tháng năm vào
            DateTime Ngay = DateTime.Parse(textBox1.Text);
            //textBox1.Text = string.Format("{0:dd/MM/yyyy}", Ngay);
            int bien = Convert.ToInt32(Ngay.Day);
            string x = "";
            if (bien <= 7)
            {
                x = "1";
            }
            else if (bien > 7 && bien <= 14)
            {
                x = "2";
            }
            else if (bien > 14 && bien <= 21)
            {
                x = "3";
            }
            else if (bien > 21 && bien <= 28)
            {
                x = "4";
            }
            else x = "5";

            switch(x)
            {
                case "1": 
                    labelHienThi.Text = "Tuần 1";
                    break;

                case "2":
                    labelHienThi.Text = "Tuần 2";
                    break;

                case "3":
                    labelHienThi.Text = "Tuần 3";
                    break;

                case "4":
                    labelHienThi.Text = "Tuần 4";
                    break;

                default:
                    labelHienThi.Text = "Tuần 5";
                    break;
            }
            
        }
    }
}
