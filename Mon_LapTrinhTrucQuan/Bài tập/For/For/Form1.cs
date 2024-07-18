using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* //Tính giai thừa của số nhập vào - giai thừa vd : 5 thì là 1x2x3x4x/ 6 thì là 1x2x3x4x5x6
            int i;
            int giaithua = 1;
            int a = Convert.ToInt32(textBox1.Text);
            for(i = 1; i <= a; i++)
            {
                giaithua *= i;
            }
            textBox2.Text = giaithua.ToString();
            */

            /* //nối chuỗi - nhập 5 thì xuất ra 1+2+3+4+5: 15
            int i, j, tong = 0;
            string ketqua = "1";
            int a = Convert.ToInt32(textBox1.Text);
            for (i = 2; i <= a ; i++)
            {
                for (j = 1; j <= a; j++)
                {
                    tong += j;
                }
                ketqua = ketqua + "+" + i;
            }
            textBox2.Text = Convert.ToString(ketqua) + ": " + tong;
            */


            /* //Tính số thứ 6 ngày 13 trong 1 năm
            int nam, songay;
            nam = int.Parse(textBox1.Text);
            songay = 0;
            for(int thang = 1; thang <= 12; thang ++)
            {
                DateTime Ngay = new DateTime(nam, thang, 13);
                if (Ngay.DayOfWeek == DayOfWeek.Friday)
                    songay += 1;
            }
            string chuoi = "thứ 6 ngày 13 trong năm " + nam + " là: " + songay + " Ngày.";
            textBox2.Text = chuoi;
            */


            /*//nối chuỗi và tính chẵn của chuỗi - nhập 10 thì xuất ra 1+2+3+4+5+6+7+8+9+10: 30(2+4+6+8+10)
            int i, j, tong = 0;
            string ketqua = "1";
            int a = Convert.ToInt32(textBox1.Text);
            for (i = 2; i <= a; i++)
            {
                j = i;
                for (; j % 2 == 0; j++)
                {
                    tong += j;
                }
                ketqua = ketqua + "+" + i;
            }
            textBox2.Text = Convert.ToString(ketqua) + ": " + tong;*/

            /* //nối chuỗi và tính lẻ của chuỗi - nhập 10 thì xuất ra 1+2+3+4+5+6+7+8+9+10: 25(1+3+5+7+9)
            int i, j, z, tong = 0;
            string ketqua = "1";
            int a = Convert.ToInt32(textBox1.Text);
            for (j = 0;j <= a; j++)
            {
                z = j;
                for (; z % 2 != 0; z++)
                {
                    tong += j;
                }
            }
            for (i = 2; i <= a; i++)
            {
                ketqua = ketqua + "+" + i;
            }
            textBox2.Text = Convert.ToString(ketqua) + ": " + tong;*/

            /*//nhập vào dãy số - số nào là số nguyên tố thì xuất ra
            int i, j;
            int a = Convert.ToInt32(textBox1.Text);
            for (i = 0; i <= a; i++)
            {
                j = i;
                if(KiemTraSoNguyenTo(j))
                {
                    textBox2.Text += i + ",";
                }
            }
            string x = textBox2.Text;
            textBox2.Text = x.TrimEnd(',');
            label1.Text = textBox2.Text;
            textBox2.Height = label1.Height;*/



            //nhập vào tháng, xuất ra số ngầy của từng thứ trong tuần

            //cho biến 'thang' để lấy giá trị nhập vào là tháng và 1 số biến để xét ngày thứ
            int thang, dem1 = 0, dem2 = 0, dem3 = 0, dem4 = 0, dem5 = 0, dem6 = 0, dem7 = 0;
            //lấy giá trị int của text
            thang = int.Parse(textBox1.Text);
            //cho mặc định là ngày 1/tháng = số nhập/ năm hiện tại. Sau đó tăng lén 1 tháng
            //hiện tại đang là ngày 1 tháng sau, rồi trừ đi ngày 1 đó thành ngày cuối cùng tháng trước(tháng lúc nhập) 
            DateTime Ngay = new DateTime(DateTime.Now.Year, thang, 1).AddMonths(1).AddDays(-1);
            //tạo biến 'x' và lấy tổng số ngày của biến 'Ngay'
            int x = Convert.ToInt32(Ngay.Day);
            //xét từ ngày 1 - ngày cuối của tháng
            for (int songay = 1; songay <= x; songay++)
            {
                //tạo biến datetime lấy năm 2021/tháng = số nhập/ số ngày của biến đếm từ 1-xx
                DateTime Ngaythu = new DateTime(2021, thang, songay);
                //lấy thứ trong tuần của Datetime 'Ngaythu' để xét
                //nếu là thứ 2 thì gán dem1 = 1 + ...
                if (Ngaythu.DayOfWeek == DayOfWeek.Monday)
                {
                    dem1 += 1;
                }
                else if (Ngaythu.DayOfWeek == DayOfWeek.Tuesday)
                {
                    dem2 += 1;
                }
                else if (Ngaythu.DayOfWeek == DayOfWeek.Wednesday)
                {
                    dem3 += 1;
                }
                else if (Ngaythu.DayOfWeek == DayOfWeek.Thursday)
                {
                    dem4 += 1;
                }
                else if (Ngaythu.DayOfWeek == DayOfWeek.Friday)
                {
                    dem5 += 1;
                }
                else if (Ngaythu.DayOfWeek == DayOfWeek.Saturday)
                {
                    dem6 += 1;
                }
                else if (Ngaythu.DayOfWeek == DayOfWeek.Sunday)
                {
                    dem7 += 1;
                }
            }
            textBox2.Text = "Trong tháng " + textBox1.Text + " có: " + x.ToString() + " Ngày, trong đó: " +
                "\r\nThứ Hai có " + dem1.ToString() + " Ngày" +
                "\r\nThứ Ba có " + dem2.ToString() + " Ngày" +
                "\r\nThứ Tư có " + dem3.ToString() + " Ngày" +
                "\r\nThứ Năm có " + dem4.ToString() + " Ngày" +
                "\r\nThứ Sáu có " + dem5.ToString() + " Ngày" +
                "\r\nThứ Bảy có " + dem6.ToString() + " Ngày" +
                "\r\nChủ Nhật có " + dem7.ToString() + " Ngày";
        }


        static bool KiemTraSoNguyenTo(int n)
        {
            if (n <= 1)// không phải số nguyên tố
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
