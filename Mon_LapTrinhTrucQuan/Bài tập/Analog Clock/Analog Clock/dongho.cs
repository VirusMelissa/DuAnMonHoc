using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analog_Clock
{
    public partial class dongho : Form
    {
        Bitmap background, hour, minute, diem, second;
        int nuathoigian, phut, giay, i = 0, j = 0, z = 0;
        //cho demlen = 1 trước vì ít nhất là hết 1 phút đầu tiên
        int demlen = 1, demxuong;

        private void txtPhut_Leave(object sender, EventArgs e)
        {
            /*
            //để code ở đây để khóa giá trị của biến nuathoigian khi nhập vào cho trường hợp 'Dừng' button
            //vì khi dừng, giá trị phút sẽ thay đổi và gán ngược lại cho biến nuathoigian -- nên sẽ thay đổi giá trị của biến liên tục
            if (txtPhut.Text != "")
            {
                phut = int.Parse(txtPhut.Text);
                nuathoigian = phut / 2;
                //gán demxuong để trừ từ từ mỗi khi số phút bằng nửa thời gian cuối
                demxuong = nuathoigian;
            }
            */
        }

        private void txtPhut_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            z++;
            //xét chia lấy số dư để tạo cảnh báo
            int x = z % 2;
            if (x == 0)
            {
                txtThongBao.BackColor = Color.Red;
            }
            else txtThongBao.BackColor = Color.White;
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 'b' || e.KeyChar == 'v' || e.KeyChar == 'k'
                 || e.KeyChar == 'q' || e.KeyChar == 'w' || e.KeyChar == 'W' || e.KeyChar == 'm' || e.KeyChar == 'p'
                  || e.KeyChar == 'd' || e.KeyChar == 'f' || e.KeyChar == 'F' || e.KeyChar == 'j' || e.KeyChar == 'J'
                   || e.KeyChar == 'l' || e.KeyChar == 'z' || e.KeyChar == 'Z' || e.KeyChar == 'x' || e.KeyChar == 's')
            {
                e.Handled = true;
            }
        }

        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            if(txtHoTen.Text != "")
            {
                txtHoTen.Enabled = false;
            }
            else txtHoTen.Enabled = true;
        }

        private void txtThongBao_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            /* Chưa xài được
            btBatDau.Text = "Bắt Đầu";
            btBatDau.Enabled = false;
            txtHoTen.Enabled = true;
            txtPhut.Enabled = true;
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();
            txtHoTen.ResetText();
            txtPhut.ResetText();
            txtThongBao.ResetText();
            */
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (txtNhapPhut.Text != "")
            {
                btBatDau.Enabled = true;
            }
            else
            {
                btBatDau.Enabled = false;
                MessageBox.Show("Vui lòng nhập số Phút", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNhapPhut_KeyPress(object sender, KeyPressEventArgs e)
        {
            //max chiều dài là 3 ký tự
            txtPhut.MaxLength = 3;
            // không cho phép ghi khác số
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void txtNhapPhut_Leave(object sender, EventArgs e)
        {
            //để code ở đây để khóa giá trị của biến nuathoigian khi nhập vào cho trường hợp 'Dừng' button
            //vì khi dừng, giá trị phút sẽ thay đổi và gán ngược lại cho biến nuathoigian -- nên sẽ thay đổi giá trị của biến liên tục
            if (txtNhapPhut.Text != "")
            {
                phut = int.Parse(txtNhapPhut.Text);
                nuathoigian = phut / 2;
                //gán demxuong để trừ từ từ mỗi khi số phút bằng nửa thời gian cuối
                demxuong = nuathoigian;
                txtNhapPhut.Enabled = false;
            }
        }

        private void txtPhut_TextChanged(object sender, EventArgs e)
        {
            if (txtPhut.Text != "")
            {
                btBatDau.Enabled = true;
            }
            else
            {
                btBatDau.Enabled = false;
                MessageBox.Show("Vui lòng nhập số Phút", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát không?"
            + "\n" + " " + "\n" + "Nếu thoát thì bấm 'Yes'"
            + "\n" + "Nếu restart thì bấm 'No'"
            + "\n" + "Nếu muốn quay lại thì bấm 'Cancel'"
            , "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning));

            if (thongbao == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (thongbao == DialogResult.No)
            {
                Application.Restart();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            j++;
            if (j == 60)
            {
                txtThongBao.Text = "Bạn còn " + demxuong + " Phút";
                // demxuong = demxuong - 1
                demxuong -= 1;
                //cho biến quay lại là 0 để xết điều kiện lại ở trên
                j = 0;
            }
            else if (j == 5)
            {
                txtThongBao.Text = "";
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 60)
            {
                txtThongBao.Text = "Bạn đã hết " + demlen + " Phút";
                // demlen = demlen + 1
                demlen += 1;
                //cho biến quay lại là 0 để xét điều kiện lại ở trên
                i = 0;
            }
            else if (i == 5)
            {
                txtThongBao.Text = "";
            }
        }

        private void btBatDau_Click(object sender, EventArgs e)
        {
            timer3.Start();
            timer2.Enabled = !timer2.Enabled;
            btBatDau.Text = btBatDau.Text == "Dừng" ? "Chạy" : "Dừng";
            // đó là khi bạn bấm 'Dừng' thì Text sẽ đổi thành 'Chạy'
            if (btBatDau.Text == "Chạy")
            {
                timer3.Stop();
                timer2.Stop();
                timer4.Stop();
                txtGiay.Text = giay.ToString();
            }
            // đó là khi bạn bấm 'Chạy' thì Text sẽ đổi thành 'Dừng'
            else if (btBatDau.Text == "Dừng")
            {
                timer2.Start();
                if (phut > nuathoigian)
                {
                    timer3.Start();
                }
                else if (phut <= nuathoigian && phut > 0)
                {
                    timer3.Stop();
                    timer4.Start();
                }
                else if (phut == 0 && giay == 0)
                {
                    timer3.Stop();
                    timer4.Stop();
                    timer2.Stop();
                    txtThongBao.Text = "Bạn đã hết thời gian";
                }
            }


            txtNhapPhut.Enabled = false;
            label1.Visible = true;
            label3.Visible = true;
            txtPhut.Visible = true;
            txtGiay.Visible = true;
            //cho mặc định txtGiay là 0
            if (txtGiay.Text == "")
            {
                txtGiay.Text = "0";
            }
            giay = int.Parse(txtGiay.Text);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            txtPhut.Text = phut.ToString();
            txtGiay.Text = giay.ToString();
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
                if (giay > 0)
                {
                    giay--;
                }
            }
            if (phut > nuathoigian)
            {
                timer3.Start();
            }
            else if (phut <= nuathoigian && phut > 0)
            {
                timer3.Stop();
                timer4.Start();
            }
            else if (phut == 0 && giay == 30)
            {
                timer5.Start();
                txtThongBao.Text = "Bạn sắp hết thời gian";
            }
            else if (phut == 0 && giay == 0)
            {
                timer3.Stop();
                timer5.Stop();
                timer4.Stop();
                txtThongBao.Text = "Bạn đã hết thời gian";
                txtThongBao.BackColor = Color.White;
                timer2.Stop();
                label1.Visible = false;
                label3.Visible = false;
                txtPhut.Visible = false;
                txtGiay.Visible = false;
                //BoxHinhNen_DH.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //gán biến Now thành ngày tháng hiện tại
            DateTime hientai = DateTime.Now;
            int Hour = hientai.Hour;
            int Minute = hientai.Minute;
            int Second = hientai.Second;

            //thay đổi góc của kim mỗi giây
            //kim giây 1 vòng 360 (độ)
            //số góc của giây tăng lên 1 lần 6 (độ) <=> 1 điểm (nhảy 1 lần 1 điểm)
            //lấy số giây hiện tại + n*6 đến khi đủ 360 (độ)
            float Goc_S = Second * 6;
            //kim phút 1 vòng 360 (độ)
            //số góc của phút tăng lên 1 lần 0,1 (độ)
            //cứ mỗi 60 (độ) của giây là được 1 (độ) của phút (360 (độ) của giây) là được 6 (độ) của phút <=> 1 điểm
            float Goc_M = Minute * 6 + Goc_S / 60;
            //số góc của giờ tăng lên 1 lần là 0,083(3) (độ)
            //cứ mỗi lần tăng 0,3(độ) của phút là tăng được 0,01(độ) của giờ
            //số giờ sẽ quay 2 vòng tương đương 720(độ) do là 24 tiếng
            float Goc_H = Hour * 30 + Goc_M / 12;

            //thử nghiệm
            //textBox1.Text = Goc_S.ToString();
            //textBox2.Text = Goc_M.ToString();
            //textBox3.Text = Goc_H.ToString();

            //gán hình ảnh của Hình Nền đồng hồ vào biến background
            BoxHinhNen_DH.Image = background;


            //khóa hình ảnh BoxGio vào BoxHinhNen
            //BoxGio nằm trên BoxHinhNen
            BoxHinhNen_DH.Controls.Add(BoxGio);
            //Khởi tạo vị trí mới
            BoxGio.Location = new Point(0, 0);
            BoxGio.Image = QuayHinhAnh(hour, Goc_H);

            //khóa hình ảnh BoxPhut vào BoxGio
            //BoxPhut nằm trên BoxGio
            BoxGio.Controls.Add(BoxPhut);
            //Khởi tạo vị trí mới
            BoxPhut.Location = new Point(0, 0);
            BoxPhut.Image = QuayHinhAnh(minute, Goc_M);

            //khóa hình ảnh BoxDiem vào BoxPhut
            //BoxDiem nằm trên BoxGio, BoxPhut, BoxHinhNen để che phần khoảng trống giữa 2 BoxGio và BoxPhut
            BoxPhut.Controls.Add(BoxDiem);
            //Khởi tạo vị trí mới
            BoxDiem.Location = new Point(0, 0);
            BoxDiem.Image = diem;

            //khóa hình ảnh BoxGiay vào BoxDiem
            BoxDiem.Controls.Add(BoxGiay);
            //Khởi tạo vị trí mới
            BoxGiay.Location = new Point(0, 0);
            BoxGiay.Image = QuayHinhAnh(second, Goc_S);

            //nói chung KIM GIÂY là nằm cao nhất tất cả
        }

        public dongho()
        {
            InitializeComponent();

            background = new Bitmap(".\\clock.png");
            hour = new Bitmap(".\\hour.png");
            minute = new Bitmap(".\\minute.png");
            diem = new Bitmap(".\\dot.png");
            second = new Bitmap(".\\second.png");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btBatDau.Enabled = false;
            label1.Visible = false;
            label3.Visible = false;
            txtPhut.Visible = false;
            txtGiay.Visible = false;

            txtNgayThang.Text = Convert.ToString(DateTime.Now);
            //string Ngay = txtNgayThang.Text;
            //DateTime Ngay1 = DateTime.Parse(Ngay);
            //txtNgayThang.Text = string.Format("{0:dd/MM}", Ngay1);
        }


        private Bitmap QuayHinhAnh(Bitmap rotateMe, float angle)
        {
           // tạo một hình ảnh Bitmap trống
            Bitmap QuayHinhAnh = new Bitmap(rotateMe.Width, rotateMe.Height);

            // biến Bitmap thành đối tượng Đồ họa
            using (Graphics g = Graphics.FromImage(QuayHinhAnh))
            {
                //đặt điểm xoay vào giữa hình ảnh của mình
                g.TranslateTransform(rotateMe.Width / 2, rotateMe.Height / 2);
                // bây giờ xoay hình ảnh
                g.RotateTransform(angle);
                //đặt điểm xoay vào giữa hình ảnh của mình
                g.TranslateTransform(-rotateMe.Width / 2, -rotateMe.Height / 2);
                //vẽ hình ảnh mới của mình vào đối tượng đồ họa
                g.DrawImage(rotateMe, new Point(0, 0));
            }
            //trả về hình ảnh
            return QuayHinhAnh;
        }
    }
}
