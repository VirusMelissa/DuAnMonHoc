using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//liên quan đến chọn hình ảnh
using System.IO;

namespace TinhPhi_HSSV2
{
    public partial class Form1 : Form
    {
        int a, b, c, d, f, g, h, k, i, l, v, hocphi;
        string a1, b1, c1, d1, f1, g1, h1, k1, i1, l1, v1;
        int tongchiphi, tonghocbong;
        string tong, donggop, hocbong, k_donggop, k_hocbong;
        double tiente, tiente1, tiente2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btChonHinh_Click(object sender, EventArgs e)
        {
            //mở thư mục lưu hình ảnh
            OpenFileDialog open = new OpenFileDialog();
            //cho phép những loại hình có đuôi như dưới
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png;";
            if(open.ShowDialog() == DialogResult.OK)
            {
                picture.Image = new Bitmap(open.FileName);
            }
            panel1.Visible = false;
            //tắt checkbox toàn bộ
            txtLietKe.ResetText();
            CB_truonghopdacbiet.Checked = false;
            CB_BHTN.Checked = false;
            CB_BHYT.Checked = false;
            CB_DongPhuc.Checked = false;
            CB_HBDN.Checked = false;
            CB_HBDoan.Checked = false;
            CB_HBHCHS.Checked = false;
            CB_HBHCTD.Checked = false;
            CB_HoiPhi.Checked = false;
            CB_Logo.Checked = false;
            CB_TheHSSV.Checked = false;
        }

        private void comboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //đổi ngành thì phải chọn lớp trước khi chạy nhé @@
            CB_truonghopdacbiet.Visible = false;
            txtHovaTen.Enabled = false;
            comboNganh.Enabled = true;
            comboLop.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtSDT.Enabled = false;
            btChonHinh.Enabled = false;
            btLietKe.Enabled = false;

            //tắt checkbox toàn bộ
            CB_truonghopdacbiet.Checked = false;
            CB_BHTN.Checked = false;
            CB_BHYT.Checked = false;
            CB_DongPhuc.Checked = false;
            CB_HBDN.Checked = false;
            CB_HBDoan.Checked = false;
            CB_HBHCHS.Checked = false;
            CB_HBHCTD.Checked = false;
            CB_HoiPhi.Checked = false;
            CB_Logo.Checked = false;
            CB_TheHSSV.Checked = false;

            //xóa text
            txtLietKe.ResetText();
            txtHovaTen.ResetText();
            txtNgaySinh.ResetText();
            txtSDT.ResetText();
            //xóa cái item đã chọn
            comboNganh.Items.Remove(comboNganh.SelectedItem);
            //xóa toàn bộ item còn lại
            comboNganh.Items.Clear();
            //xóa cái item đã chọn
            comboLop.Items.Remove(comboLop.SelectedItem);
            //xóa toàn bộ item còn lại
            comboLop.Items.Clear();
            picture.Image = null;
            panel1.Visible = true;


            //combobox KHOA khác rỗng
            if (comboKhoa.SelectedItem != null)
            {
                //mở chọn combo NGÀNH
                comboNganh.Enabled = true;
                //gán Item trong combo Khoa qua biến
                String x = comboKhoa.SelectedItem.ToString();
                //Nếu combo KHOA chọn item "Công nghệ thông tin thì
                if (x == "Công nghệ thông tin")
                {
                    //combo Ngành sẽ xóa những item hiện tại
                    comboNganh.Items.Clear();
                    //Và tạo 2 item mới phù hợp với Khoa đó
                    comboNganh.Items.Add("Quản trị cơ sở dữ liệu");
                    comboNganh.Items.Add("Quản trị mạng");
                }
                else if (x == "Điện-Điện tử")
                {
                    comboNganh.Items.Clear();
                    comboNganh.Items.Add("Điện công nghiệp");
                    comboNganh.Items.Add("Điện tử công nghiệp");
                }
                else if (x == "Cơ khí")
                {
                    comboNganh.Items.Clear();
                    comboNganh.Items.Add("Hàn");
                    comboNganh.Items.Add("Bảo trì HTTB cơ khí");
                    comboNganh.Items.Add("Cắt gọt kim loại");
                }
                else if (x == "Bộ môn thuộc trường")
                {
                    comboNganh.Items.Clear();
                    comboNganh.Items.Add("Công nghệ ô tô");
                    comboNganh.Items.Add("Kỹ thuật máy lạnh & ĐHKK");
                    comboNganh.Items.Add("Kế toán doanh nghiệp");
                    comboNganh.Items.Add("Du lịch");
                    comboNganh.Items.Add("Nghiệp vụ nhà hàng");
                }
            }
            else MessageBox.Show("Vui Lòng chọn Khoa");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Group Thông tin
            comboNganh.Enabled = false;
            txtHovaTen.Enabled = false;
            comboLop.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtSDT.Enabled = false;
            txtHocPhi.ReadOnly = true;
            btChonHinh.Enabled = false;
            CB_truonghopdacbiet.Visible = false;
            btLietKe.Enabled = false;

            //Đồng phục và Logo
            labelSL1.Visible = false;
            labelSL2.Visible = false;
            txtSL_DongPhuc.Visible = false;
            txtSL_Logo.Visible = false;

            //chiều rộng của form
            this.Width = 685;

            //Màu cho group Khoản Phí
            groupKhoanDG.ForeColor = Color.Red;
            CB_BHYT.ForeColor = Color.Black;
            CB_BHTN.ForeColor = Color.Black;
            CB_DongPhuc.ForeColor = Color.Black;
            CB_HoiPhi.ForeColor = Color.Black;
            CB_Logo.ForeColor = Color.Black;
            CB_TheHSSV.ForeColor = Color.Black;
            labelSL1.ForeColor = Color.Black;
            labelSL2.ForeColor = Color.Black;

            //Màu cho group Học Bổng
            groupKhoanHB.ForeColor = Color.Blue;
            CB_HBDN.ForeColor = Color.Black;
            CB_HBDoan.ForeColor = Color.Black;
            CB_HBHCHS.ForeColor = Color.Black;
            CB_HBHCTD.ForeColor = Color.Black;

            
            //Các checkbox bên phải của group Học Bổng và Đóng góp
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            txtLietKe.Visible = false;
            picture2.Visible = false;
        }

        private void comboKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CB_HBDN_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_HBDN.Checked)
            {
                textBox1.Visible = true;
                b = 2000000;
                b1 = "\r\n" + " + Học Bổng của Doanh Nghiệp (2,000,000 VNĐ)";
            }
            else
            {
                textBox1.Visible = false;
                b = 0;
                b1 = "";
            }
        }

        private void CB_HBHCHS_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_HBHCHS.Checked)
            {
                textBox2.Visible = true;
                c = 500000;
                c1 = "\r\n" + " + Học Bổng Hội Cựu Học Sinh (500,000 VNĐ)";
            }
            else
            {
                textBox2.Visible = false;
                c = 0;
                c1 = "";
            }
        }

        private void CB_HBDoan_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_HBDoan.Checked)
            {
                textBox4.Visible = true;
                f = 200000;
                f1 = "\r\n" + " + Hỗ trợ Đoàn TNCSHCM (200,000 VNĐ)";
            }
            else
            {
                textBox4.Visible = false;
                f = 0;
                f1 = "";
            }
        }

        private void comboKhoa_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(comboKhoa, "Mời bạn chọn Khoa theo danh sách có sẵn");
        }

        private void comboNganh_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(comboNganh, "Mời bạn chọn Ngành theo danh sách có sẵn");
        }

        private void comboLop_MouseHover(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(comboLop, "Mời bạn chọn Lớp theo danh sách có sẵn");
        }

        private void txtHovaTen_MouseHover(object sender, EventArgs e)
        {
            toolTip4.SetToolTip(txtHovaTen, "Mời bạn ghi họ và tên của mình vào");
        }

        private void txtNgaySinh_MouseHover(object sender, EventArgs e)
        {
            toolTip5.SetToolTip(txtNgaySinh, "Mời bạn nhập ngày sinh bằng số theo định dạng dd-MM-yyyy");
        }

        private void txtSDT_MouseHover(object sender, EventArgs e)
        {
            toolTip6.SetToolTip(comboKhoa, "Mời bạn ghi số điện thoại của mình vào");
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            toolTip7.SetToolTip(panel1, "Mời bạn tải hình ảnh của mình lên");
        }

        private void btChonHinh_MouseHover(object sender, EventArgs e)
        {
            toolTip7.SetToolTip(btChonHinh, "Mời bạn tải hình ảnh của mình lên");
        }

        private void CB_truonghopdacbiet_MouseHover(object sender, EventArgs e)
        {
            toolTip8.SetToolTip(CB_truonghopdacbiet, "Nếu bạn thuộc diện này, click chọn (Miễn học phí)");
        }

        private void btXoa_MouseHover(object sender, EventArgs e)
        {
            toolTip9.SetToolTip(btXoa, "Xóa toàn bộ (như mới hoàn toàn)");
        }

        private void btLietKe_MouseHover(object sender, EventArgs e)
        {
            toolTip10.SetToolTip(btLietKe, "Liệt kê ra các khoản phí khác");
        }

        private void btTinh_MouseHover(object sender, EventArgs e)
        {
            toolTip11.SetToolTip(btTinh, "Xuất ra kết quả thông tin các khoản phí, học bổng của HSSV");
        }

        private void btXem_MouseHover(object sender, EventArgs e)
        {
            toolTip12.SetToolTip(btXem, "Cho Xem trước tiền cần đóng và học bổng được hưởng");
        }

        private void btDoi_MouseHover(object sender, EventArgs e)
        {
            toolTip13.SetToolTip(btDoi, "Cho phép bạn đổi trước khi xuất kết quả");
        }

        private void txtSL_DongPhuc_MouseHover(object sender, EventArgs e)
        {
            toolTip14.SetToolTip(txtSL_DongPhuc, "Nhập số lượng cần mua");
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            //tắt checkbox toàn bộ
            txtLietKe.ResetText();
            CB_truonghopdacbiet.Checked = false;
            CB_BHTN.Checked = false;
            CB_BHYT.Checked = false;
            CB_DongPhuc.Checked = false;
            CB_HBDN.Checked = false;
            CB_HBDoan.Checked = false;
            CB_HBHCHS.Checked = false;
            CB_HBHCTD.Checked = false;
            CB_HoiPhi.Checked = false;
            CB_Logo.Checked = false;
            CB_TheHSSV.Checked = false;
        }

        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {
            //tắt checkbox toàn bộ
            txtLietKe.ResetText();
            CB_truonghopdacbiet.Checked = false;
            CB_BHTN.Checked = false;
            CB_BHYT.Checked = false;
            CB_DongPhuc.Checked = false;
            CB_HBDN.Checked = false;
            CB_HBDoan.Checked = false;
            CB_HBHCHS.Checked = false;
            CB_HBHCTD.Checked = false;
            CB_HoiPhi.Checked = false;
            CB_Logo.Checked = false;
            CB_TheHSSV.Checked = false;
        }

        private void txtHovaTen_TextChanged(object sender, EventArgs e)
        {
            //tắt checkbox toàn bộ
            txtLietKe.ResetText();
            CB_truonghopdacbiet.Checked = false;
            CB_BHTN.Checked = false;
            CB_BHYT.Checked = false;
            CB_DongPhuc.Checked = false;
            CB_HBDN.Checked = false;
            CB_HBDoan.Checked = false;
            CB_HBHCHS.Checked = false;
            CB_HBHCTD.Checked = false;
            CB_HoiPhi.Checked = false;
            CB_Logo.Checked = false;
            CB_TheHSSV.Checked = false;
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            string x = txtSDT.Text;
            //số nhập vào phải là 10 số
            if(x.Length != 10)
            {
                MessageBox.Show("Số Điện Thoại phải đủ 10 số bạn nhé");
                txtSDT.ResetText();
            }
        }

        private void txtSL_Logo_MouseHover(object sender, EventArgs e)
        {
            toolTip14.SetToolTip(txtSL_Logo, "Nhập số lượng cần mua");
        }

        private void btDoi_Click(object sender, EventArgs e)
        {
            //mở khóa những gì bên group thông tin để sửa
            this.Width = 654;
            groupKhoanHB.Visible = false;
            groupKhoanDG.Visible = false;
            groupTT_HSSV.Enabled = true;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            //Xóa toàn bộ thông tin textbox và combo Khoa - Ngành - Lớp
            picture.Image = null;
            panel1.Visible = true;
            txtSDT.ResetText();
            txtNgaySinh.ResetText();
            txtHovaTen.ResetText();
            txtHocPhi.ResetText();
            //xóa cái item đã chọn
            comboLop.Items.Remove(comboLop.SelectedItem);
            //xóa toàn bộ item còn lại
            comboLop.Items.Clear();
            comboNganh.Items.Remove(comboNganh.SelectedItem);
            comboNganh.Items.Clear();
            comboKhoa.Items.Remove(comboKhoa.SelectedItem);
            comboKhoa.Items.Clear();
            //Vì combo Khoa luôn luôn có dữ liệu để người dùng chọn nên sẽ add lại item khi xóa
            comboKhoa.Items.Add("Bộ môn thuộc trường");
            comboKhoa.Items.Add("Công nghệ thông tin");
            comboKhoa.Items.Add("Điện-Điện tử");
            comboKhoa.Items.Add("Cơ khí");

            //lúc người dùng bấm button Liệt Kê là nó đã khóa, nhưng nếu họ không chọn button Đổi thì nó vẫn sẽ khóa
            //nên là khi chọn button Xóa sẽ mở lại những cái này
            comboKhoa.Enabled = true;
            //mở group Thông Tin
            groupTT_HSSV.Enabled = true;

            //bỏ chọn checbox Con thương binh, bệnh binh
            CB_truonghopdacbiet.Checked = false;

            //những cái dưới đây tương tự là form load
            CB_truonghopdacbiet.Visible = false;
            comboNganh.Enabled = false;
            txtHovaTen.Enabled = false;
            comboLop.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtSDT.Enabled = false;
            btChonHinh.Enabled = false;
            btLietKe.Enabled = false;

            labelSL2.Visible = false;
            labelSL1.Visible = false;
            txtSL_DongPhuc.Visible = false;
            txtSL_Logo.Visible = false;
            txtLietKe.Visible = false;
            this.Width = 654;

            //tắt checkbox toàn bộ
            CB_BHTN.Checked = false;
            CB_BHYT.Checked = false;
            CB_DongPhuc.Checked = false;
            CB_HBDN.Checked = false;
            CB_HBDoan.Checked = false;
            CB_HBHCHS.Checked = false;
            CB_HBHCTD.Checked = false;
            CB_HoiPhi.Checked = false;
            CB_Logo.Checked = false;
            CB_TheHSSV.Checked = false;
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            //tính tổng tất cả các checkbox lại
            tongchiphi = a + g + h + k + i + l + v;
            tonghocbong = b + c + d + f;
            //gán biến tong1 là string = chuyển đổi qua string cho (tongchiphi) - tong1 bây giờ là dữ liệu của tongchiphi
            string tong1 = Convert.ToString(tongchiphi);
            //gán biến tong2 là string = chuyển đổi qua string cho (tonghocbong) - tong2 bây giờ là dữ liệu của tonghocbong
            string tong2 = Convert.ToString(tonghocbong);
            //chuyển đổi tong qua số thập phân để tiến hành định dạng tiền tệ
            tiente1 = Convert.ToDouble(tong1);
            tiente2 = Convert.ToDouble(tong2);
            //định dạng kiểu 123,456 VNĐ
            tong1 = tiente1.ToString("#,### VNĐ");
            tong2 = tiente2.ToString("#,### VNĐ");

            //Xét nếu không chọn checkbox nào thì sẽ hiện 'không có'
            if (CB_HBDN.Checked == false && CB_HBDoan.Checked == false && CB_HBHCHS.Checked == false && CB_HBHCTD.Checked == false)
            {
                hocbong = "Không có";
                tong2 = "";
            }
            else hocbong = "";

            //Xét nếu không chọn checkbox nào thì sẽ hiện 'không có' hoặc 'có' (học phí, nếu ko có chọn checkbox Con Thương Binh)
            if (CB_BHYT.Checked == false && CB_BHTN.Checked == false && CB_HoiPhi.Checked == false && CB_TheHSSV.Checked == false
            && CB_Logo.Checked == false && CB_DongPhuc.Checked == false)
            {
                if (CB_truonghopdacbiet.Checked)
                {
                    donggop = "Không có";
                    tong1 = "";
                }
                else
                {
                    donggop = "";
                }
            }
            else donggop = "";

            //nếu có chọn checkbox Con Thương binh, bệnh binh, người có công
            if (CB_truonghopdacbiet.Checked)
            {
                MessageBox.Show(
                "Tên: " + txtHovaTen.Text +
                "\nLớp: " + comboLop.SelectedItem.ToString() +
                "\nNgày Sinh: " + txtNgaySinh.Text +
                "\nSố Điện Thoại: " + txtSDT.Text +
                "\n*Được miễn học phí*" +
                "\n\nTổng chi phí cần phải đóng là: " + donggop + tong1 +
                "\nTổng học bổng được hưởng là: " + hocbong + tong2, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                "Tên: " + txtHovaTen.Text +
                "\nLớp: " + comboLop.SelectedItem.ToString() +
                "\nNgày Sinh: " + txtNgaySinh.Text +
                "\nSố Điện Thoại: " + txtSDT.Text +
                "\nHọc Phí: " + txtHocPhi.Text +
                "\n\nTổng chi phí cần phải đóng là: " + donggop + tong1 +
                "\nTổng học bổng được hưởng là: " + hocbong + tong2, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CB_HBHCTD_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_HBHCTD.Checked)
            {
                textBox3.Visible = true;
                d = 200000;
                d1 = "\r\n" + " + Hỗ trợ của Hội Chữ Thập Đỏ (200,000 VNĐ)";
            }
            else
            {
                textBox3.Visible = false;
                d = 0;
                d1 = "";
            }
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            //khóa bên trái form
            comboKhoa.Enabled = false;
            comboLop.Enabled = false;
            comboNganh.Enabled = false;
            txtHovaTen.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtSDT.Enabled = false;
            btChonHinh.Enabled = false;
            CB_truonghopdacbiet.Enabled = false;
            btLietKe.Enabled = false;


            groupTT_HSSV.Enabled = true;
            picture2.Visible = true;
            picture2.Image = picture.Image;
            groupKhoanDG.Visible = false;
            groupKhoanHB.Visible = false;

            string y = comboNganh.SelectedItem.ToString();
            string x = comboLop.SelectedItem.ToString();

            string kiemtra = x.Substring(0, 1);

            //Nếu ngành chọn là Hàn hoặc Cắt gọt kim loại
            if(y == "Hàn" || y == "Cắt gọt kim loại")
            {
                //cao đẳng
                if(kiemtra == "C")
                {
                    //có chọn checkbox Con thương binh, bệnh binh, người có công
                    if(CB_truonghopdacbiet.Checked)
                    {
                        a = 0;
                        a1 = "\r\n" + " + Học Phí (0 VNĐ)";
                    }

                    //không chọn checkbox Con thương binh, bệnh binh, người có công
                    else
                    {
                        a = 1410000;
                        a1 = "\r\n" + " + Học Phí (1,410,000 VNĐ)";
                    }
                }

                //trung cấp
                else if(kiemtra == "T")
                {
                    //có chọn checkbox Con thương binh, bệnh binh, người có công
                    if (CB_truonghopdacbiet.Checked)
                    {
                        a = 0;
                        a1 = "\r\n" + " + Học Phí (0 VNĐ)";
                    }

                    //không chọn checkbox Con thương binh, bệnh binh, người có công
                    else
                    {
                        a = 1230000;
                        a1 = "\r\n" + " + Học Phí (1,230,000 VNĐ)";
                    }
                }
            }


            //Nếu ngành chọn không phải là Hàn hoặc Cắt gọt kim loại
            else
            {
                //cao đẳng
                if (kiemtra == "C")
                {
                    //có chọn checkbox Con thương binh, bệnh binh, người có công
                    if (CB_truonghopdacbiet.Checked)
                    {
                        a = 0;
                        a1 = "\r\n" + " + Học Phí (0 VNĐ)";
                    }

                    //không chọn checkbox Con thương binh, bệnh binh, người có công
                    else
                    {
                        a = 4700000;
                        a1 = "\r\n" + " + Học Phí (4,700,000 VNĐ)";
                    }
                }

                //trung cấp
                else if (kiemtra == "T")
                {
                    //có chọn checkbox Con thương binh, bệnh binh, người có công
                    if (CB_truonghopdacbiet.Checked)
                    {
                        a = 0;
                        a1 = "\r\n" + " + Học Phí (0 VNĐ)";
                    }

                    //không chọn checkbox Con thương binh, bệnh binh, người có công
                    else
                    {
                        a = 4100000;
                        a1 = "\r\n" + " + Học Phí (4,100,000 VNĐ)";
                    }
                }
            }

            //tính tổng tất cả các checkbox lại
            tongchiphi = a + g + h + k + i + l + v;
            tonghocbong = b + c + d + f;
            //gán biến tong1 là string = chuyển đổi qua string cho (tongchiphi) - tong1 bây giờ là dữ liệu của tongchiphi
            string tong1 = Convert.ToString(tongchiphi);
            //gán biến tong2 là string = chuyển đổi qua string cho (tonghocbong) - tong2 bây giờ là dữ liệu của tonghocbong
            string tong2 = Convert.ToString(tonghocbong);
            //chuyển đổi tong qua số thập phân để tiến hành định dạng tiền tệ
            tiente1 = Convert.ToDouble(tong1);
            tiente2 = Convert.ToDouble(tong2);
            //định dạng kiểu 123,456 VNĐ
            tong1 = tiente1.ToString("#,### VNĐ");
            tong2 = tiente2.ToString("#,### VNĐ");


            //Xét nếu không chọn checkbox nào thì sẽ hiện 'không có'
            if (CB_HBDN.Checked == false && CB_HBDoan.Checked == false && CB_HBHCHS.Checked == false && CB_HBHCTD.Checked == false)
            {
                hocbong = "Không có";
                k_hocbong = "\r\n" + " *Không có học bổng nào cả!* ";
                tong2 = "";
            }
            else
            {
                k_hocbong = "";
                hocbong = "";
            }

            //Xét nếu không chọn checkbox nào thì sẽ hiện 'không có' hoặc 'có' (học phí, nếu ko có chọn checkbox Con Thương Binh)
            if (CB_BHYT.Checked == false && CB_BHTN.Checked == false && CB_HoiPhi.Checked == false && CB_TheHSSV.Checked == false
            && CB_Logo.Checked == false && CB_DongPhuc.Checked == false)
            {
                if (CB_truonghopdacbiet.Checked)
                {
                    donggop = "Không có";
                    k_donggop = "\r\n" + " *Không có đóng góp nào cả!* ";
                    tong1 = "";
                }
                else
                {
                    k_donggop = "\r\n" + " *Không có đóng góp nào cả!* ";
                    donggop = "";
                }
            }
            else
            {
                k_donggop = "";
                donggop = "";
            }

            //Textbox Liệt Kê
            txtLietKe.Visible = true;
            txtLietKe.Text = "Tên: " + txtHovaTen.Text +
                "\r\n" + "Ngày Sinh: " + txtNgaySinh.Text +
                "\r\n" + "Số Điện Thoại: " + txtSDT.Text +
                "\r\n" + "Lớp: " + comboLop.SelectedItem.ToString() +
                "\r\n" + "Ngành: " + comboNganh.SelectedItem.ToString() +
                "\r\n" + "Khoa: " + comboKhoa.SelectedItem.ToString() +
                "\r\n" + "Học Phí: " + txtHocPhi.Text + 
                "\r\n" +
                "\r\n" + "<> Số Tiền Từng Khoản Đóng Góp: " + k_donggop + g1 + h1 + k1 + i1 + l1 + v1 +
                "\r\n" +
                "\r\n" + "<> Số Tiền Từng Khoản Học Bổng: " + k_hocbong + b1 + c1 + d1 + f1 +
                "\r\n" +
                "\r\n" + "Tổng số tiền HSSV cần đóng: " + donggop + tong1 +
                "\r\n" + "Tổng số tiền HSSV được hưởng: " + hocbong + tong2;
            Labeltest.Text = txtLietKe.Text;
            txtLietKe.Height = Labeltest.Height;
        }

        private void CB_BHYT_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_BHYT.Checked)
            {
                textBox5.Visible = true;
                g = 564000;
                g1 = "\r\n" + " + Bảo Hiểm Y Tế (564,000 VNĐ)";
            }
            else
            {
                textBox5.Visible = false;
                g = 0;
                g1 = "";
            }
        }

        private void CB_BHTN_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_BHTN.Checked)
            {
                textBox6.Visible = true;
                h = 70000;
                h1 = "\r\n" + " + Bảo Hiểm Tai Nạn (70,000 VNĐ)";
            }
            else
            {
                textBox6.Visible = false;
                h = 0;
                h1 = "";
            }
        }

        private void CB_HoiPhi_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_HoiPhi.Checked)
            {
                textBox7.Visible = true;
                k = 12000;
                k1 = "\r\n" + " + Hội Phí (12,000 VNĐ)";
            }
            else
            {
                textBox7.Visible = false;
                k = 0;
                k1 = "";
            }
        }

        private void CB_TheHSSV_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_TheHSSV.Checked)
            {
                textBox8.Visible = true;
                i = 22000;
                i1 = "\r\n" + " + Thẻ Học Sinh/Sinh Viên (22,000 VNĐ)";
            }
            else
            {
                textBox8.Visible = false;
                i = 0;
                i1 = "";
            }
        }

        private void CB_DongPhuc_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_DongPhuc.Checked)
            {
                //gán textbox số lượng mặc định là 1 và mở label và textbox Số lượng
                txtSL_DongPhuc.Text = "1";
                labelSL1.Visible = true;
                txtSL_DongPhuc.Visible = true;
                textBox9.Visible = true;
            }
            else
            {
                //gán textbox số lượng mặc định là 0 và tắt label và textbox Số lượng
                txtSL_DongPhuc.Text = "0";
                labelSL1.Visible = false;
                txtSL_DongPhuc.Visible = false;
                textBox9.Visible = false;
                l1 = "";
            }
        }

        private void txtSL_DongPhuc_TextChanged(object sender, EventArgs e)
        {
            //Nếu text số lượng của đồng phục = rỗng
            if (txtSL_DongPhuc.Text == "")
            {
                //bỏ chọn của checkbox đồng phục
                CB_DongPhuc.Checked = false;
                //xuất hiện thông báo lỗi do bị rỗng
                MessageBox.Show("Số lượng không được rỗng", "Thông báo");
                labelSL1.Visible = false;
                txtSL_DongPhuc.Visible = false;
            }
            //Nếu text số lượng của đồng phục khác rỗng
            else if (txtSL_DongPhuc.Text != "")
            {
                //thay đổi số lượng liên tục sẽ thay đổi giá tiền tương tự
                int SL = Convert.ToInt32(txtSL_DongPhuc.Text);
                l = 100000 * SL;
                l1 = "\r\n" + " + Đồng Phục (100,000 VNĐ/Cái) " + " & Số lượng: " + Convert.ToString(SL);
            }
            else if (txtSL_DongPhuc.Text == "1")
            {
                l = 100000;
                l1 = "\r\n" + " + Đồng Phục (100,000 VNĐ/Cái) " + "& Số lượng: 1";
            }
            else if (txtSL_DongPhuc.Text == "0")
            {
                l = 0;
            }
        }

        private void txtSL_DongPhuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //SL tối đa là 2 và là chỉ cho phép nhập số, xóa lùi
            txtSL_DongPhuc.MaxLength = 2;
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void CB_Logo_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Logo.Checked)
            {
                //gán textbox số lượng mặc định là 1 và mở label và textbox Số lượng
                txtSL_Logo.Text = "1";
                labelSL2.Visible = true;
                txtSL_Logo.Visible = true;
                textBox10.Visible = true;
            }
            else
            {
                //gán textbox số lượng mặc định là 0 và tắt label và textbox Số lượng
                txtSL_Logo.Text = "0";
                labelSL2.Visible = false;
                txtSL_Logo.Visible = false;
                textBox10.Visible = false;
                v1 = "";
            }
        }

        private void txtSL_Logo_TextChanged(object sender, EventArgs e)
        {
            //Nếu text số lượng của Logo = rỗng
            if (txtSL_Logo.Text == "")
            {
                //bỏ chọn của checkbox Logo
                CB_Logo.Checked = false;
                //xuất hiện thông báo lỗi do bị rỗng
                MessageBox.Show("Số lượng không được rỗng", "Thông báo");
                labelSL2.Visible = false;
                txtSL_Logo.Visible = false;
            }
            //Nếu text số lượng của Logo khác rỗng
            else if (txtSL_Logo.Text != "")
            {
                //thay đổi số lượng liên tục sẽ thay đổi giá tiền tương tự
                int SL = Convert.ToInt32(txtSL_Logo.Text);
                v = 5000 * SL;
                v1 = "\r\n" + " + Logo Trường (5,000 VNĐ/Cái) " + "& Số lượng: " + Convert.ToString(SL);
            }
            else if (txtSL_DongPhuc.Text == "1")
            {
                v = 5000;
                v1 = "\r\n" + " + Logo Trường (5,000 VNĐ/Cái) " + "& Số lượng: 1";
            }
            else if (txtSL_DongPhuc.Text == "0")
            {
                v = 0;
            }
        }

        private void txtSL_Logo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //SL tối đa là 2 và là chỉ cho phép nhập số, xóa lùi
            txtSL_DongPhuc.MaxLength = 2;
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void comboNganh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboLop_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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

        private void txtHovaTen_Leave(object sender, EventArgs e)
        {
            if (txtHovaTen.Text != "")
            {
                //Tô đậm chữ
                txtHovaTen.Font = new Font(txtHovaTen.Font, FontStyle.Bold);



                string hoten = txtHovaTen.Text.ToLower().Trim();
                //Cắt khoảng trắng 2 bên và 2 khoảng trắng trở lên;
                //>= 0 nghĩa là có vị trí 2 khoảng trắng
                //vd Ba    me (4 khoảng trắng) lượt 1 chạy tìm được 2 cái 2 khoảng trắng xóa thành Ba  me
                //lap lai thấy 1 cái 2 khoảng trắng xóa thành Ba me
                while (hoten.IndexOf("  ") >= 0)    //tim trong chuoi vi tri co 2 khoang trong tro len      
                {
                    hoten = hoten.Replace("  ", " "); //sau do thay the bang 1 khoang trong  rồi quay lại
                }
                txtHovaTen.Text = hoten;




                //Đổi ký tự đầu viết hoa
                //tạo biến rỗng 1
                string strchuyendoi = "";
                //tách các từ giữa các khoảng trắng
                string[] laytu = hoten.Split(' ');
                //tạo biến rỗng 2
                string kytudau = "";
                //Tạo vòng lặp cho biến i = 0; i bé hơn (đếm chiều dài ký tự khoảng trắng) ; cho i + lên đến khi = chiều dài khoảng trắng
                for (int i = 0; i < laytu.Length; i++)
                {
                    //gán biến rỗng 2 = của từ(Chữ) tách đầu tiên cho đến thứ n rồi lấy ký tự đầu tiên
                    //vd Nguyen Thi Minh Loan thì i = 0 => laytu[0] là Nguyen , i = 1 => laytu[1] = Thi và cứ tiếp tục
                    //vd trên có số khoảng trắng là 4
                    kytudau = laytu[i].Substring(0, 1);
                    //gán biến rỗng 1 = ký tự đầu tiên phóng to + giữ ký tự sau vị trí 1 và xóa ký tự đầu tiên + khoảng trống để nối cái chữ tiếp theo
                    //cùng vd trên thì laytu[i].remove(0,1) của 'Nguyen' nghĩa là xóa 'N' và lấy từ ký tự 'g' - 'n'
                    //Vì kytudau.ToUpper() là đã lấy N rồi nên + thêm đuôi uyen + khoảng trống để nối từ tiếp theo
                    // N + uyen + " " (+) T + hi + " " (+) M + inh + " " (+) L + oan + " "
                    //+= là lấy toán hạng bên trái + vs toán hạng bên phải rồi gán qua toán hạng bên trái như K = K + 1
                    strchuyendoi += kytudau.ToUpper() + laytu[i].Remove(0, 1) + " ";
                }
                txtHovaTen.Text = strchuyendoi;
            }
            else MessageBox.Show("Vui lòng nhập tên");
        }
                    
        private void txtHovaTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            //(e.KeyChar >= 'a' && e.KeyChar <= 'z') - cho phép nhập từ a thường đến z thường
            //(e.KeyChar >= 'A' && e.KeyChar <= 'Z') - cho phép nhập từ A hoa đến Z hoa
            //(e.KeyChar == ' ') - cho phép nhập khoảng trắng - e.KeyChar == (char)32 cũng được
            //e.KeyChar == (char)8 - cho phép xóa lùi, char 8: Backspace
            //e.KeyChar >= '0' && e.KeyChar <= '9' - cho phép nhập số
            //! ở đây là khác và e.Handled = true (thì KHÓA sự kiện KeyPress (tức là KHÓA không nhận gì từ bàn phím) )
            //kết hợp nếu khác những ký tự cho phép thì sẽ ko nhận gì từ bàn phím 
            /*if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar == ' ') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') 
                || e.KeyChar == (char)8 || e.KeyChar >= (char)1 && e.KeyChar <= (char)200))*/
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 'b' || e.KeyChar == 'v' || e.KeyChar == 'k'
                 || e.KeyChar == 'q' || e.KeyChar == 'w' || e.KeyChar == 'W' || e.KeyChar == 'm' || e.KeyChar == 'p'
                  || e.KeyChar == 'd' || e.KeyChar == 'f' || e.KeyChar == 'F' || e.KeyChar == 'j' || e.KeyChar == 'J'
                   || e.KeyChar == 'l' || e.KeyChar == 'z' || e.KeyChar == 'Z' || e.KeyChar == 'x' || e.KeyChar == 's')
            {
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSDT.MaxLength = 10;
            if(!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số");
            }
        }

        private void txtNgaySinh_Leave(object sender, EventArgs e)
        {
            string x = txtNgaySinh.Text;
            //số nhập vào tối thiểu là 4 số
            if (x.Length > 3)
            {
                string ss = Convert.ToString(txtNgaySinh.Text);
                //XÉT NGÀY VÀ THÁNG
                //lấy 4 ký tự cuối để xét giới hạn năm
                string dem4kytu = ss.Substring(ss.Length - 4, 4);
                //lấy 1 ký tự đầu
                string dem1kytu = ss.Substring(0, 1);
                //lấy 2 ký tự đầu tiên và 2 ký tự vị trí thứ 3
                string dem2kytu1 = ss.Substring(0, 2);
                string dem2kytu2 = ss.Substring(2, 2);
                //lấy 1 ký tự thứ 3
                string dem1kytu3 = ss.Substring(2, 1);


                //XÉT NGÀY VÀ THÁNG
                int dau = Convert.ToInt32(dem1kytu);
                int dau2 = Convert.ToInt32(dem2kytu1);
                int dau3 = Convert.ToInt32(dem2kytu2);
                int dau4 = Convert.ToInt32(dem1kytu3);

                //XÉT NĂM
                int duoi = Convert.ToInt32(dem4kytu);

                //nếu người dùng nhập 8 số
                if (ss.Length == 8)
                {
                    //chặn lỗi ngày lớn hơn 31 và tháng lớn hơn 12 && ngày và tháng ko được định dạng kiểu 00-00-yyyy
                    if (dau2 >= 1 && dau2 <= 31 && dau3 >= 1 && dau3 <= 12 && dau2 != 00 && dau3 != 00)
                    {
                        //lấy 1 ký tự vị trí thứ 5
                        string lay1kytu1 = ss.Substring(4, 1);
                        int duoi1 = Convert.ToInt32(lay1kytu1);
                        //chỉ cho phép từ năm 1900 - 2100
                        if (duoi >= 1900 && duoi <= 2100 && duoi1 != 0)
                        {
                            if (dau == 0)
                            {
                                string Ngay = Convert.ToString(txtNgaySinh.Text);
                                tiente = Convert.ToDouble(Ngay);
                                tong = tiente.ToString("'0'# - ## - ####");
                                txtNgaySinh.Text = tong;
                            }
                            else
                            {
                                string Ngay = Convert.ToString(txtNgaySinh.Text);
                                tiente = Convert.ToDouble(Ngay);
                                tong = tiente.ToString("## - ## - ####");
                                txtNgaySinh.Text = tong;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Năm sinh không hợp lệ");
                            txtNgaySinh.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ngày/Tháng sinh không hợp lệ");
                        txtNgaySinh.Text = "";
                    }
                }
                //nếu người dùng nhập 7 số
                else if (ss.Length == 7)
                {
                    //lấy 1 ký tự vị trí thứ 4
                    string lay1kytu2 = ss.Substring(3, 1);
                    int duoi2 = Convert.ToInt32(lay1kytu2);
                    //chỉ cho phép từ năm 1900 - 2100
                    if (duoi >= 1900 && duoi <= 2100 && duoi2 != 0)
                    {
                        //chặn lỗi ngày là 00-MM-yyyy
                        if (dau2 != 00)
                        {
                            //nếu số đầu tiên = 0 tương ứng 01-09
                            if (dau == 0)
                            {
                                //chặn lỗi tháng là dd-00-yyyy
                                if (dau4 != 0)
                                {
                                    string Ngay = Convert.ToString(txtNgaySinh.Text);
                                    tiente = Convert.ToDouble(Ngay);
                                    tong = tiente.ToString("'0'# - '0'# - ####");
                                    txtNgaySinh.Text = tong;
                                }
                                else
                                {
                                    MessageBox.Show("Ngày/Tháng sinh không hợp lệ");
                                    txtNgaySinh.Text = "";
                                }
                            }
                            //nếu số đầu tiên # 0 tương ứng 10-31
                            else
                            {
                                //chặn lỗi ngày ko được lớn hơn 31 và tháng # 0
                                if (dau2 >= 1 && dau2 <= 31 && dau4 != 0)
                                {
                                    string Ngay = Convert.ToString(txtNgaySinh.Text);
                                    tiente = Convert.ToDouble(Ngay);
                                    tong = tiente.ToString("## - '0'# - ####");
                                    txtNgaySinh.Text = tong;
                                }
                                else
                                {
                                    MessageBox.Show("Ngày/Tháng sinh không hợp lệ");
                                    txtNgaySinh.Text = "";
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ngày/Tháng sinh không hợp lệ");
                            txtNgaySinh.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Năm sinh không hợp lệ");
                        txtNgaySinh.Text = "";
                    }
                }
                //nếu người dùng nhập 6 số
                else if (ss.Length == 6)
                {
                    //lấy 1 ký tự vị trí thứ 3
                    string lay1kytu3 = ss.Substring(2, 1);
                    int duoi3 = Convert.ToInt32(lay1kytu3);
                    //chỉ cho phép từ năm 1900 - 2100
                    if (duoi >= 1900 && duoi <= 2100 && duoi3 != 0)
                    {
                        //chặn lỗi ngày và tháng là 00-00-yyyy
                        if (dau2 != 00)
                        {
                            string Ngay = Convert.ToString(txtNgaySinh.Text);
                            tiente = Convert.ToDouble(Ngay);
                            tong = tiente.ToString("'0'# - '0'# - ####");
                            txtNgaySinh.Text = tong;
                        }
                        else
                        {
                            MessageBox.Show("Ngày/Tháng sinh không hợp lệ");
                            txtNgaySinh.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Năm sinh không hợp lệ");
                        txtNgaySinh.Text = "";
                    }
                }
                else if (ss.Length == 4)
                {
                    //chỉ cho phép từ năm 1900 - 2100 và chặn lỗi đầu năm là 0xxx
                    if (duoi >= 1900 && duoi <= 2100 && dau != 0)
                    {
                        string Ngay = Convert.ToString(txtNgaySinh.Text);
                        tiente = Convert.ToDouble(Ngay);
                        tong = tiente.ToString("####");
                        txtNgaySinh.Text = tong;
                    }
                    else
                    {
                        MessageBox.Show("Năm sinh không hợp lệ");
                        txtNgaySinh.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Bạn nhập không đúng định dạng");
                    txtNgaySinh.Text = "";
                }
                //string Ngay = txtNgaySinh.Text;
                //DateTime Ngay1 = DateTime.Parse(Ngay);
                //txtNgaySinh.Text = string.Format("{0:dd-MM-yyyy}", Ngay1);
            }
            else
            {
                MessageBox.Show("Nhập tối thiểu 4 số bạn nhé","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgaySinh.ResetText();
            }
        }

        private void txtNgaySinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tối đa 8 ký tự 
            txtNgaySinh.MaxLength = 8;
            //không cho nhập số 0 và các ký tự khác ngoài từ 1-9 và Xóa lùi
            if(!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập số", "Thông báo");
            }
        }

        private void CB_truonghopdacbiet_CheckedChanged(object sender, EventArgs e)
        {
            if(CB_truonghopdacbiet.Checked)
            {
                a = 0;
                txtHocPhi.Text = "0 VNĐ";
            }
            else
            {
                tong = Convert.ToString(hocphi);
                //chuyển đổi tong qua số thập phân để tiến hành định dạng tiền tệ
                tiente = Convert.ToDouble(tong);
                //định dạng kiểu 123,456đ
                tong = tiente.ToString("0#,### VNĐ");
                //gán dữ liệu string của tong qua text Học Phí
                txtHocPhi.Text = tong;
            }
        }

        private void btLietKe_Click(object sender, EventArgs e)
        {
            //nếu 5 textbox thông tin đều khác rỗng
            if (comboKhoa.SelectedItem != null && comboNganh.SelectedItem != null && txtHovaTen.Text != ""
            && comboLop.SelectedItem != null && txtNgaySinh.Text != "" && txtSDT.Text != "" && picture.Image != null)
            //mở group chọn mục chi phí cần đóng và khóa 5 textbox thông tin lại
            {
                MessageBox.Show("Chọn những mục mà HSSV muốn đóng góp và mục học bổng mà HSSV có", "Thông báo");
                groupKhoanDG.Visible = true;
                groupKhoanHB.Visible = true;
                this.Width = 1274;
                groupTT_HSSV.Enabled = false;
                txtLietKe.Visible = false;
                picture2.Visible = false;
            }
            //ngược lại thì hiện thông báo lỗi
            else MessageBox.Show("Vui lòng chọn và nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void comboNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            //đổi ngành thì phải chọn lớp trước khi chạy nhé @@
            CB_truonghopdacbiet.Visible = false;
            txtHovaTen.Enabled = false;
            comboLop.Enabled = true;
            txtNgaySinh.Enabled = false;
            txtSDT.Enabled = false;
            btChonHinh.Enabled = false;
            btLietKe.Enabled = false;

            //tắt checkbox toàn bộ
            CB_truonghopdacbiet.Checked = false;
            CB_BHTN.Checked = false;
            CB_BHYT.Checked = false;
            CB_DongPhuc.Checked = false;
            CB_HBDN.Checked = false;
            CB_HBDoan.Checked = false;
            CB_HBHCHS.Checked = false;
            CB_HBHCTD.Checked = false;
            CB_HoiPhi.Checked = false;
            CB_Logo.Checked = false;
            CB_TheHSSV.Checked = false;

            //xóa text
            txtLietKe.ResetText();
            txtHovaTen.ResetText();
            txtNgaySinh.ResetText();
            txtSDT.ResetText();
            //xóa cái item đã chọn
            comboLop.Items.Remove(comboLop.SelectedItem);
            //xóa toàn bộ item còn lại
            comboLop.Items.Clear();
            picture.Image = null;
            panel1.Visible = true;

            //Nếu combo NGANH khác rỗng
            if (comboNganh.SelectedItem != null)
            {
                //mở 1 số textbox sau
                comboLop.Enabled = true;
                
                //gán x cho item đã chọn trong combo Ngành
                String x = comboNganh.SelectedItem.ToString();
                //nếu item đó có tên là "Điện công nghiệp"
                if (x == "Điện công nghiệp")
                {
                    //xóa Item cũ và tạo những item mới phù hợp với Ngành đã chọn
                    comboLop.Items.Clear();
                    comboLop.Items.Add("CDCN06A");
                    comboLop.Items.Add("CDCN07A");
                    comboLop.Items.Add("CDCN08A");
                    comboLop.Items.Add("TDCN41B");
                    comboLop.Items.Add("TDCN42B");
                    comboLop.Items.Add("TDCN43B");
                }
                else if (x == "Điện tử công nghiệp")
                {
                    comboLop.Items.Clear();
                    comboLop.Items.Add("TDTC43B");
                    comboLop.Items.Add("TDTC42B");
                    comboLop.Items.Add("TDTC41B");
                }
                else if (x == "Quản trị cơ sở dữ liệu")
                {
                    comboLop.Items.Clear();
                    comboLop.Items.Add("CQTC06A");
                    comboLop.Items.Add("CQTC07A");
                    comboLop.Items.Add("CQTC08A");
                }
                else if (x == "Quản trị mạng")
                {
                    comboLop.Items.Clear();
                    comboLop.Items.Add("TQTM41B");
                    comboLop.Items.Add("TQTM42B");
                    comboLop.Items.Add("TQTM43B");
                }
                else if (x == "Hàn")
                {
                    comboLop.Items.Clear();
                    comboLop.Items.Add("THAN41B");
                    comboLop.Items.Add("THAN42B");
                    comboLop.Items.Add("THAN43B");
                }
                else if (x == "Bảo trì HTTB cơ khí")
                {
                    comboLop.Items.Clear();
                    comboLop.Items.Add("TBTC41B");
                    comboLop.Items.Add("TBTC42B");
                    comboLop.Items.Add("TBTC43B");
                }
                else if (x == "Cắt gọt kim loại")
                {
                    comboLop.Items.Clear();
                    comboLop.Items.Add("CCGK06A");
                    comboLop.Items.Add("CCGK07A");
                    comboLop.Items.Add("CCGK08A");
                    comboLop.Items.Add("TCGK41B");
                    comboLop.Items.Add("TCGK42B");
                    comboLop.Items.Add("TCGK43B");
                }
                else if (x == "Công nghệ ô tô")
                {
                    comboLop.Items.Clear();
                    comboLop.Items.Add("CCNO06A");
                    comboLop.Items.Add("CCNO07A");
                    comboLop.Items.Add("CCNO08A");
                    comboLop.Items.Add("TCNO41B");
                    comboLop.Items.Add("TCNO42B");
                    comboLop.Items.Add("TCNO43B");
                }
                else if (x == "Kỹ thuật máy lạnh & ĐHKK")
                {
                    comboLop.Items.Clear();
                    comboLop.Items.Add("CDLA06A");
                    comboLop.Items.Add("CDLA07A");
                    comboLop.Items.Add("CDLA08A");
                    comboLop.Items.Add("TDLA41B");
                    comboLop.Items.Add("TDLA42B");
                    comboLop.Items.Add("TDLA43B");
                }
                else if (x == "Kế toán doanh nghiệp")
                {
                    comboLop.Items.Clear();
                    comboLop.Items.Add("CKTD06A");
                    comboLop.Items.Add("CKTD07A");
                    comboLop.Items.Add("CKTD08A");
                    comboLop.Items.Add("TKTD41B");
                    comboLop.Items.Add("TKTD42B");
                    comboLop.Items.Add("TKTD43B");
                }
                else if (x == "Du lịch")
                {
                    comboLop.Items.Clear();
                    comboLop.Items.Add("TQTD41B");
                    comboLop.Items.Add("TQTD42B");
                    comboLop.Items.Add("TQTD43B");
                }
                else if (x == "Nghiệp vụ nhà hàng")
                {
                    comboLop.Items.Clear();
                    comboLop.Items.Add("TNVN41B");
                    comboLop.Items.Add("TNVN42B");
                    comboLop.Items.Add("TNVN43B");
                }
            }
            else MessageBox.Show("Vui Lòng chọn Ngành");
        }

        private void comboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            btChonHinh.Enabled = true;
            txtHovaTen.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtSDT.Enabled = true;
            CB_truonghopdacbiet.Visible = true;
            CB_truonghopdacbiet.Enabled = true;
            btLietKe.Enabled = true;
            string x = comboLop.SelectedItem.ToString();
            string y = comboNganh.SelectedItem.ToString();
            //lấy 1 ký tự đầu
            string kiemtra = x.Substring(0, 1);

            //Nếu ký tự đầu là C nghĩa là cao đẳng
            if (kiemtra == "C")
            {
                if (y == "Hàn" || y == "Cắt gọt kim loại")
                {
                    a = 1410000;
                    hocphi = 1410000;
                    //gán biến tong là string = chuyển đổi qua string cho (tongchiphi) - tong bây giờ là dữ liệu của tongchiphi
                    tong = Convert.ToString(hocphi);
                    //chuyển đổi tong qua số thập phân để tiến hành định dạng tiền tệ
                    tiente = Convert.ToDouble(tong);
                    //định dạng kiểu 123,456đ
                    tong = tiente.ToString("0#,### VNĐ");
                    //gán dữ liệu string của tong qua text Học Phí
                    txtHocPhi.Text = tong;
                }
                else
                {
                    a = 4700000;
                    hocphi = 4700000;
                    //gán biến tong là string = chuyển đổi qua string cho (tongchiphi) - tong bây giờ là dữ liệu của tongchiphi
                    tong = Convert.ToString(hocphi);
                    //chuyển đổi tong qua số thập phân để tiến hành định dạng tiền tệ
                    tiente = Convert.ToDouble(tong);
                    //định dạng kiểu 123,456đ
                    tong = tiente.ToString("0#,### VNĐ");
                    //gán dữ liệu string của tong qua text Học Phí
                    txtHocPhi.Text = tong;
                }
            }

            //Nếu ký tự đầu là T nghĩa là trung cấp
            else if (kiemtra == "T")
            {
                if (y == "Hàn" || y == "Cắt gọt kim loại")
                {
                    a = 1230000;
                    hocphi = 1230000;
                    //gán biến tong là string = chuyển đổi qua string cho (tongchiphi) - tong bây giờ là dữ liệu của tongchiphi
                    tong = Convert.ToString(hocphi);
                    //chuyển đổi tong qua số thập phân để tiến hành định dạng tiền tệ
                    tiente = Convert.ToDouble(tong);
                    //định dạng kiểu 123,456đ
                    tong = tiente.ToString("0#,### VNĐ");
                    //gán dữ liệu string của tong qua text Học Phí
                    txtHocPhi.Text = tong;
                }
                else
                {
                    a = 4100000;
                    hocphi = 4100000;
                    //gán biến tong là string = chuyển đổi qua string cho (tongchiphi) - tong bây giờ là dữ liệu của tongchiphi
                    tong = Convert.ToString(hocphi);
                    //chuyển đổi tong qua số thập phân để tiến hành định dạng tiền tệ
                    tiente = Convert.ToDouble(tong);
                    //định dạng kiểu 123,456đ
                    tong = tiente.ToString("0#,### VNĐ");
                    //gán dữ liệu string của tong qua text Học Phí
                    txtHocPhi.Text = tong;
                }
            }
            //tắt checkbox toàn bộ
            txtLietKe.ResetText();
            CB_truonghopdacbiet.Checked = false;
            CB_BHTN.Checked = false;
            CB_BHYT.Checked = false;
            CB_DongPhuc.Checked = false;
            CB_HBDN.Checked = false;
            CB_HBDoan.Checked = false;
            CB_HBHCHS.Checked = false;
            CB_HBHCTD.Checked = false;
            CB_HoiPhi.Checked = false;
            CB_Logo.Checked = false;
            CB_TheHSSV.Checked = false;
        }
    }
}
