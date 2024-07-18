using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thi
{
    public partial class DichVuTiemChung : Form
    {
        int a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26;
        string b1 = "", b2 = "", b3 = "", b4 = "", b5 = "", b6 = "", b7 = "", b8 = "", b9 = "", b10 = "", b11 = "", b12 = "", b13 = "", b14 = "", b15 = "", b16 = "", b17 = "", b18 = "", b19 = "", b20 = "", b21 = "", b22 = "", b23 = "", b24 = "", b25 = "", b26 = "";
        int tongthanhtien, i = 0, k = 0;
        double j = 2200067690;
        string tong, tuoi, gt, makh;
        double tiente;

        private void btXacNhan_MouseHover(object sender, EventArgs e)
        {
            toolTip4.SetToolTip(btXacNhan, "Xác nhận để đưa ra thông báo vắc xin đã chọn và thành tiền");
        }

        private void btReset_MouseHover(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(btReset, "Cho phép chọn lại vắc xin");
        }

        private void btChon_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(btChon, "Chọn vắc xin");
        }

        private void combo_TuyChon_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(combo_TuyChon, "Tên vắc xin, nước sản xuất, giá");
        }

        private void btTaoMoi_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        public DichVuTiemChung()
        {
            InitializeComponent();
        }

        private void DichVuTiemChung_Load(object sender, EventArgs e)
        {
            btChon.Enabled = false;
            btXacNhan.Enabled = false;
            combo_TuyChon.Enabled = false;
            this.Width = 1026;
            txtLietKe.Visible = false;
            btTaoMoi.Visible = false;
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

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //chỉ cho phép nhập số và xóa lùi
            txtSDT.MaxLength = 10;
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số");
            }
        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            //chỉ cho phép nhập số và xóa lùi
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số");
            }
        }

        private void trick1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cấm nhập
            e.Handled = true;
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            if (txtDiaChi.Text != "")
            {
                string diachi = txtDiaChi.Text.ToLower().Trim();
                //Cắt khoảng trắng 2 bên và 2 khoảng trắng trở lên;
                //>= 0 nghĩa là có vị trí 2 khoảng trắng
                //vd Ba    me (4 khoảng trắng) lượt 1 chạy tìm được 2 cái 2 khoảng trắng xóa thành Ba  me
                //lap lai thấy 1 cái 2 khoảng trắng xóa thành Ba me
                while (diachi.IndexOf("  ") >= 0)    //tim trong chuoi vi tri co 2 khoang trong tro len      
                {
                    diachi = diachi.Replace("  ", " "); //sau do thay the bang 1 khoang trong  rồi quay lại
                }
                txtDiaChi.Text = diachi;




                //Đổi ký tự đầu viết hoa
                //tạo biến rỗng 1
                string strchuyendoi = "";
                //tách các từ giữa các khoảng trắng
                string[] laytu = diachi.Split(' ');
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
                txtDiaChi.Text = strchuyendoi;
            }
            else MessageBox.Show("Vui lòng nhập địa chỉ");
        }

        private void DTimePick_NgaysINH_ValueChanged(object sender, EventArgs e)
        {
            trick1.Visible = false;
        }

        private void list_Chon_SelectedIndexChanged(object sender, EventArgs e)
        {
            btChon.Enabled = false;
            //Nều list chọn khác rỗn
            if (list_Chon.SelectedItem != null)
            {
                //mở chọn combo tùy chọn
                combo_TuyChon.Enabled = true;
                //gán Item trong combo tùy chọn qua biến
                String x = list_Chon.SelectedItem.ToString();
                //Nếu list chọn item "Bạch hầu, ho gà, uốn ván, bại liệt và Hib" thì
                if (x == "Bạch hầu, ho gà, uốn ván, bại liệt và Hib")
                {
                    //combo tùy chọn xóa item đã chọn
                    combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem);
                    //combo tùy chọn sẽ xóa những item hiện tại
                    combo_TuyChon.Items.Clear();
                    //Và tạo item mới phù hợp với list chọn đó
                    combo_TuyChon.Items.Add("Infanrix IPV+Hib(Bỉ) 942.000 VNĐ");
                }
                else if (x == "Bạch hầu, ho gà, uốn ván, bại liệt, Hib và viêm gan B")
                {
                    combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem);
                    combo_TuyChon.Items.Clear();
                    combo_TuyChon.Items.Add("Infanrix Hexa 6in1(Bỉ) 1.218.000 VNĐ");
                    combo_TuyChon.Items.Add("Hexaxim 6in1(Pháp) 1.258.000 VNĐ");
                }
                else if (x == "Rota virus")
                {
                    combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem);
                    combo_TuyChon.Items.Clear();
                    combo_TuyChon.Items.Add("Rotateq(Mỹ) 798.000 VNĐ");
                    combo_TuyChon.Items.Add("Rotarix(Bỉ) 990.000 VNĐ");
                    combo_TuyChon.Items.Add("Rotavin-M1(Việt Nam) 588.000 VNĐ");
                }
                else if (x == "Các bệnh do phế cầu")
                {
                    combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem);
                    combo_TuyChon.Items.Clear();
                    combo_TuyChon.Items.Add("Synflorix(Bỉ) 1.254.000 VNĐ");
                    combo_TuyChon.Items.Add("Prevenar 13(Bỉ) 1.548.000 VNĐ");
                }
                else if (x == "Lao")
                {
                    combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem);
                    combo_TuyChon.Items.Clear();
                    combo_TuyChon.Items.Add("BCG(Việt Nam) 150.000 VNĐ");
                }
                else if (x == "Viêm gan B người lớn")
                {
                    combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem);
                    combo_TuyChon.Items.Clear();
                    combo_TuyChon.Items.Add("Engerix B 1ml(Bỉ) 282.000 VNĐ");
                    combo_TuyChon.Items.Add("Euvax B 1ml(Hàn Quốc) 204.000 VNĐ");
                }
                else if (x == "Viêm gan B trẻ em")
                {
                    combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem);
                    combo_TuyChon.Items.Clear();
                    combo_TuyChon.Items.Add("Euvax B 0.5ml(Hàn Quốc) 140.000 VNĐ");
                    combo_TuyChon.Items.Add("Engerix B 0,5ml(Bỉ) 228.000 VNĐ");
                }
                else if (x == "Viêm màng não mô cầu BC")
                {
                    combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem);
                    combo_TuyChon.Items.Clear();
                    combo_TuyChon.Items.Add("VA-Mengoc-BC(Cu Ba) 354.000 VNĐ");
                }
                else if (x == "Viêm màng não mô cầu ACYW")
                {
                    combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem);
                    combo_TuyChon.Items.Clear();
                    combo_TuyChon.Items.Add("Menactra(Mỹ) 1.512.000 VNĐ");
                }
                else if (x == "Sởi")
                {
                    combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem);
                    combo_TuyChon.Items.Clear();
                    combo_TuyChon.Items.Add("MVVac Lọ 5ml(Việt Nam) 378.000 VNĐ");
                    combo_TuyChon.Items.Add("MVVac Liều 0.5ml(Việt Nam) 216.000 VNĐ");
                }
                else if (x == "Sởi – Quai bị – Rubella")
                {
                    combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem);
                    combo_TuyChon.Items.Clear();
                    combo_TuyChon.Items.Add("MMR II 3 in 1(Mỹ) 366.000 VNĐ");
                }
                else if (x == "Thủy Đậu")
                {
                    combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem);
                    combo_TuyChon.Items.Clear();
                    combo_TuyChon.Items.Add("Varivax(Mỹ) 1.098.000 VNĐ");
                    combo_TuyChon.Items.Add("Varilrix(Bỉ) 1.134.000 VNĐ");
                    combo_TuyChon.Items.Add("Varicella(Hàn Quốc) 840.000 VNĐ");
                }
                else if (x == "Cúm")
                {
                    combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem);
                    combo_TuyChon.Items.Clear();
                    combo_TuyChon.Items.Add("Vaxigrip Tetra 0.5ml(Pháp) 428.000 VNĐ");
                    combo_TuyChon.Items.Add("Influvac 0.5ml(Hà Lan) 418.000 VNĐ");
                    combo_TuyChon.Items.Add("Influvac tetra 0,5ml(Hà Lan) 428.000 VNĐ");
                    combo_TuyChon.Items.Add("GCFlu Quadrivalent 0,5ml(Hàn Quốc) 414.000 VNĐ");
                }
                else if (x == "Cúm (người lớn > 18 tuổi)")
                {
                    combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem);
                    combo_TuyChon.Items.Clear();
                    combo_TuyChon.Items.Add("Ivacflu-S 0,5ml(Việt Nam) 228.000 VNĐ");

                }
                else if (x == "Ung thư cổ tử cung và u nhú bộ phận sinh dục, sùi mào gà")
                {
                    combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem);
                    combo_TuyChon.Items.Clear();
                    combo_TuyChon.Items.Add("Gardasil 0.5ml(Mỹ) 2.148.000 VNĐ");

                }
                else if (x == "Phòng uốn ván")
                {
                    combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem);
                    combo_TuyChon.Items.Clear();
                    combo_TuyChon.Items.Add("SAT - huyết thanh kháng độc tố uốn ván(Việt Nam) 120.000 VNĐ");

                }
                else if (x == "Viêm não Nhật Bản")
                {
                    combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem);
                    combo_TuyChon.Items.Clear();
                    combo_TuyChon.Items.Add("Imojev(Thái Lan) 798.000 VNĐ");
                    combo_TuyChon.Items.Add("Jevax 1ml(Việt Nam) 204.000 VNĐ");

                }
                else if (x == "Vắc xin phòng dại")
                {
                    combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem);
                    combo_TuyChon.Items.Clear();
                    combo_TuyChon.Items.Add("Verorab 0,5ml - TB, TTD(Pháp) 388.000 VNĐ");
                    combo_TuyChon.Items.Add("Abhayrab 0,5ml - TB(Ấn Độ) 306.000 VNĐ");
                    combo_TuyChon.Items.Add("Abhayrab 0,5ml - TTD(Ấn Độ) 258.000 VNĐ");

                }
                else if (x == "Bạch hầu – Uốn ván – Ho gà")
                {
                    combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem);
                    combo_TuyChon.Items.Clear();
                    combo_TuyChon.Items.Add("Adacel(Canada) 744.000 VNĐ");
                    combo_TuyChon.Items.Add("Boostrix(Bỉ) 882.000 VNĐ");

                }
                else if (x == "Bạch hầu – Ho gà – Uốn ván – Bại liệt")
                {
                    combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem);
                    combo_TuyChon.Items.Clear();
                    combo_TuyChon.Items.Add("Tetraxim(Pháp) 550.000 VNĐ");

                }
                else if (x == "Bạch hầu – Uốn ván")
                {
                    combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem);
                    combo_TuyChon.Items.Clear();
                    combo_TuyChon.Items.Add("Uốn ván,bạch hầuTd-Lọ 0,5ml(Việt Nam) 150.000 VNĐ");
                    combo_TuyChon.Items.Add("Uốn ván,bạch hầuTd-Liều 0,5 ml(Việt Nam) 114.000 VNĐ");
                    combo_TuyChon.Items.Add("Uốn ván,bạch hầuTd-Lọ 5ml(Việt Nam) 696.000 VNĐ");
                }
                else if (x == "Viêm gan B và Viêm gan A")
                {
                    combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem);
                    combo_TuyChon.Items.Clear();
                    combo_TuyChon.Items.Add("Twinrix(Bỉ) 672.000 VNĐ");
                }
                else if (x == "Viêm gan A")
                {
                    combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem);
                    combo_TuyChon.Items.Clear();
                    combo_TuyChon.Items.Add("Havax 0,5ml(Việt Nam) 282.000 VNĐ");
                    combo_TuyChon.Items.Add("AVAXIM 80U(Pháp) 708.000 VNĐ");
                }
                else if (x == "Thương hàn")
                {
                    combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem);
                    combo_TuyChon.Items.Clear();
                    combo_TuyChon.Items.Add("Typhoid VI(Việt Nam) 174.000 VNĐ");
                    combo_TuyChon.Items.Add("Typhim VI(Pháp) 360.000 VNĐ");
                }
                else if (x == "Các bệnh do Hib")
                {
                    combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem);
                    combo_TuyChon.Items.Clear();
                    combo_TuyChon.Items.Add("Các bệnh do Hib(Cu Ba) 287.000 VNĐ");
                }
                else if (x == "Tả")
                {
                    combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem);
                    combo_TuyChon.Items.Clear();
                    combo_TuyChon.Items.Add("mORCVAX(Việt Nam) 138.000 VNĐ");
                }
            }
        }

        private void combo_TuyChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            btChon.Enabled = true;
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            //nhận chuỗi từ bảng list chọn bên trái qua bên phải
            list_DaChon.Items.Add(list_Chon.SelectedItem.ToString());
            btChon.Enabled = false;
            btXacNhan.Enabled = true;
            
            string x = list_Chon.SelectedItem.ToString();
            string y = combo_TuyChon.SelectedItem.ToString();
            //Nếu list chọn có 2 loại gần tương tự nhau, chọn 1 trong 2, thì sẽ xóa cả 2 bên list chọn
            if (x == "Bạch hầu, ho gà, uốn ván, bại liệt và Hib" || x == "Bạch hầu, ho gà, uốn ván, bại liệt, Hib và viêm gan B")
            {
                if (x == "Bạch hầu, ho gà, uốn ván, bại liệt và Hib")
                {
                    if (y == "Infanrix IPV+Hib(Bỉ) 942.000 VNĐ")
                    {
                        a1 = 942000;
                        i += a1;
                        b1 = "\r\n" + " + Infanrix IPV+Hib(Bỉ)" + " " + " " + " - " + " " + " " +"Đơn giá: 942.000 VNĐ";
                    }
                }
                else if (x == "Bạch hầu, ho gà, uốn ván, bại liệt, Hib và viêm gan B")
                {
                    if (y == "Infanrix Hexa 6in1(Bỉ) 1.218.000 VNĐ")
                    {
                        a2 = 1218000;
                        i += a2;
                        b2 = "\r\n" + " + Infanrix Hexa 6in1(Bỉ)" + " " + " " + " - " + " " + " " +"Đơn giá: 1.218.000 VNĐ";
                    }
                    else if (y == "Hexaxim 6in1(Pháp) 1.258.000 VNĐ")
                    {
                        a2 = 1258000;
                        i += a2;
                        b2 = "\r\n" + " + Hexaxim 6in1(Pháp)" + " " + " " + " - " + " " + " " +"Đơn giá: 1.258.000 VNĐ";
                    }
                }
                list_Chon.Items.Remove("Bạch hầu, ho gà, uốn ván, bại liệt và Hib");
                list_Chon.Items.Remove("Bạch hầu, ho gà, uốn ván, bại liệt, Hib và viêm gan B");
            }


            if (x == "Rota virus")
            {
                if (y == "Rotateq(Mỹ) 798.000 VNĐ")
                {
                    a3 = 798000;
                    i += a3;
                    b3 = "\r\n" + " + Rotateq(Mỹ)" + " " + " " + " - " + " " + " " +"Đơn giá: 798.000 VNĐ";
                }
                else if (y == "Rotarix(Bỉ) 990.000 VNĐ")
                {
                    a3 = 990000;
                    i += a3;
                    b3 = "\r\n" + " + Rotarix(Bỉ)" + " " + " " + " - " + " " + " " +"Đơn giá: 990.000 VNĐ";
                }
                else if (y == "Rotavin-M1(Việt Nam) 588.000 VNĐ")
                {
                    a3 = 588000;
                    i += a3;
                    b3 = "\r\n" + " + Rotavin-M1(Việt Nam)" + " " + " " + " - " + " " + " " +"Đơn giá: 588.000 VNĐ";
                }
                list_Chon.Items.Remove("Rota virus");
            }


            if (x == "Các bệnh do phế cầu")
            {
                if (y == "Synflorix(Bỉ) 1.254.000 VNĐ")
                {
                    a4 = 1254000;
                    i += a4;
                    b4 = "\r\n" + " + Synflorix(Bỉ)" + " " + " " + " - " + " " + " " +"Đơn giá: 1.254.000 VNĐ";
                }
                else if (y == "Prevenar 13(Bỉ) 1.548.000 VNĐ")
                {
                    a4 = 1548000;
                    i += a4;
                    b4 = "\r\n" + " + Prevenar 13(Bỉ)" + " " + " " + " - " + " " + " " +"Đơn giá: 1.548.000 VNĐ";
                }
                list_Chon.Items.Remove("Các bệnh do phế cầu");
            }


            if (x == "Lao")
            {
                if (y == "BCG(Việt Nam) 150.000 VNĐ")
                {
                    a5 = 150000;
                    i += a5;
                    b5 = "\r\n" + " + BCG(Việt Nam)" + " " + " " + " - " + " " + " " +"Đơn giá: 150.000 VNĐ";
                }
                list_Chon.Items.Remove("Lao");
            }


            if (x == "Viêm gan B người lớn" || x == "Viêm gan B trẻ em")
            {
                if (x == "Viêm gan B người lớn")
                {
                    if (y == "Engerix B 1ml(Bỉ) 282.000 VNĐ")
                    {
                        a6 = 282000;
                        i += a6;
                        b6 = "\r\n" + " + Engerix B 1ml(Bỉ)" + " " + " " + " - " + " " + " " +"Đơn giá: 282.000 VNĐ";
                    }
                    else if (y == "Euvax B 1ml(Hàn Quốc) 204.000 VNĐ")
                    {
                        a6 = 204000;
                        i += a6;
                        b6 = "\r\n" + " + Euvax B 1ml(Hàn Quốc)" + " " + " " + " - " + " " + " " +"Đơn giá: 204.000 VNĐ";
                    }
                }
                else if (x == "Viêm gan B trẻ em")
                {
                    if (y == "Euvax B 0.5ml(Hàn Quốc) 140.000 VNĐ")
                    {
                        a7 = 140000;
                        i += a7;
                        b7 = "\r\n" + " + Euvax B 0.5ml(Hàn Quốc)" + " " + " " + " - " + " " + " " +"Đơn giá: 140.000 VNĐ";
                    }
                    else if (y == "Engerix B 0,5ml(Bỉ) 228.000 VNĐ")
                    {
                        a7 = 228000;
                        i += a7;
                        b7 = "\r\n" + " + Engerix B 0,5ml(Bỉ)" + " " + " " + " - " + " " + " " +"Đơn giá: 228.000 VNĐ";
                    }
                }
                list_Chon.Items.Remove("Viêm gan B người lớn");
                list_Chon.Items.Remove("Viêm gan B trẻ em");
            }
            

            if (x == "Viêm màng não mô cầu BC")
            {
                if (y == "VA-Mengoc-BC(Cu Ba) 354.000 VNĐ")
                {
                    a8 = 354000;
                    i += a8;
                    b8 = "\r\n" + " + VA-Mengoc-BC(Cu Ba)" + " " + " " + " - " + " " + " " +"Đơn giá: 354.000 VNĐ";
                }
                list_Chon.Items.Remove("Viêm màng não mô cầu BC");
            }


            if (x == "Viêm màng não mô cầu ACYW")
            {
                if (y == "Menactra(Mỹ) 1.512.000 VNĐ")
                {
                    a9 = 1512000;
                    i += a9;
                    b9 = "\r\n" + " + Menactra(Mỹ)" + " " + " " + " - " + " " + " " +"Đơn giá: 1.512.000 VNĐ";
                }
                list_Chon.Items.Remove("Viêm màng não mô cầu ACYW");
            }


            if (x == "Sởi" || x == "Sởi – Quai bị – Rubella")
            {
                if (x == "Sởi")
                {
                    if (y == "MVVac Lọ 5ml(Việt Nam) 378.000 VNĐ")
                    {
                        a10 = 378000;
                        i += a10;
                        b10 = "\r\n" + " + MVVac Lọ 5ml(Việt Nam)" + " " + " " + " - " + " " + " " +"Đơn giá: 378.000 VNĐ";
                    }
                    else if (y == "MVVac Liều 0.5ml(Việt Nam) 216.000 VNĐ")
                    {
                        a10 = 216000;
                        i += a10;
                        b10 = "\r\n" + " + MVVac Liều 0.5ml(Việt Nam)" + " " + " " + " - " + " " + " " +"Đơn giá: 216.000 VNĐ";
                    }
                }
                else if (x == "Sởi – Quai bị – Rubella")
                {
                    if (y == "MMR II 3 in 1(Mỹ) 366.000 VNĐ")
                    {
                        a11 = 366000;
                        i += a11;
                        b11 = "\r\n" + " + MMR II 3 in 1(Mỹ)" + " " + " " + " - " + " " + " " +"Đơn giá: 366.000 VNĐ";
                    }
                }
                list_Chon.Items.Remove("Sởi");
                list_Chon.Items.Remove("Sởi – Quai bị – Rubella");
            }


            if (x == "Thủy Đậu")
            {
                if (y == "Varivax(Mỹ) 1.098.000 VNĐ")
                {
                    a12 = 1098000;
                    i += a12;
                    b12 = "\r\n" + " + Varivax(Mỹ) 1.098.000" + " " + " " + " - " + " " + " " +"Đơn giá: VNĐ";
                }
                else if (y == "Varilrix(Bỉ) 1.134.000 VNĐ")
                {
                    a12 = 1134000;
                    i += a12;
                    b12 = "\r\n" + " + Varilrix(Bỉ)" + " " + " " + " - " + " " + " " +"Đơn giá: 1.134.000 VNĐ";
                }
                else if (y == "Varicella(Hàn Quốc) 840.000 VNĐ")
                {
                    a12 = 840000;
                    i += a12;
                    b12 = "\r\n" + " + Varicella(Hàn Quốc)" + " " + " " + " - " + " " + " " +"Đơn giá: 840.000 VNĐ";
                }
                list_Chon.Items.Remove("Thủy Đậu");
            }


            if (x == "Cúm" || x == "Cúm (người lớn > 18 tuổi)")
            {
                if (x == "Cúm")
                {
                    if (y == "Vaxigrip Tetra 0.5ml(Pháp) 428.000 VNĐ")
                    {
                        a13 = 428000;
                        i += a13;
                        b13 = "\r\n" + "Vaxigrip Tetra 0.5ml(Pháp)" + " " + " " + " - " + " " + " " +"Đơn giá: 428.000 VNĐ";
                    }
                    else if (y == "Influvac 0.5ml(Hà Lan) 418.000 VNĐ")
                    {
                        a13 = 418000;
                        i += a13;
                        b13 = "\r\n" + " + Influvac 0.5ml(Hà Lan)" + " " + " " + " - " + " " + " " +"Đơn giá: 418.000 VNĐ";
                    }
                    else if (y == "Influvac tetra 0,5ml(Hà Lan) 428.000 VNĐ")
                    {
                        a13 = 428000;
                        i += a13;
                        b13 = "\r\n" + " + Influvac 0.5ml(Hà Lan)" + " " + " " + " - " + " " + " " +"Đơn giá: 418.000 VNĐ";
                    }
                    else if (y == "GCFlu Quadrivalent 0,5ml(Hàn Quốc) 414.000 VNĐ")
                    {
                        a13 = 414000;
                        i += a13;
                        b13 = "\r\n" + " + GCFlu Quadrivalent 0,5ml(Hàn Quốc)" + " " + " " + " - " + " " + " " +"Đơn giá: 414.000 VNĐ";
                    }
                }
                else if (x == "Cúm (người lớn > 18 tuổi)")
                {
                    if (y == "Ivacflu-S 0,5ml(Việt Nam) 228.000 VNĐ")
                    {
                        a14 = 228000;
                        i += a14;
                        b14 = "\r\n" + " + Ivacflu-S 0,5ml(Việt Nam)" + " " + " " + " - " + " " + " " +"Đơn giá: 228.000 VNĐ";
                    }
                }
                list_Chon.Items.Remove("Cúm");
                list_Chon.Items.Remove("Cúm (người lớn > 18 tuổi)");
            }


            if (x == "Ung thư cổ tử cung và u nhú bộ phận sinh dục, sùi mào gà")
            {
                if (y == "Gardasil 0.5ml(Mỹ) 2.148.000 VNĐ")
                {
                    a15 = 2148000;
                    i += a15;
                    b15 = "\r\n" + " + Gardasil 0.5ml(Mỹ)" + " " + " " + " - " + " " + " " +"Đơn giá: 2.148.000 VNĐ";
                }
                list_Chon.Items.Remove("Ung thư cổ tử cung và u nhú bộ phận sinh dục, sùi mào gà");
            }


            if (x == "Phòng uốn ván")
            {
                if (y == "SAT - huyết thanh kháng độc tố uốn ván(Việt Nam) 120.000 VNĐ")
                {
                    a16 = 120000;
                    i += a16;
                    b16 = "\r\n" + " + SAT huyết thanh kháng độc tố uốn ván(Việt Nam)" + " " + " " + " - " + " " + " " +"Đơn giá: 120.000 VNĐ";
                }
                list_Chon.Items.Remove("Phòng uốn ván");
            }


            if (x == "Viêm não Nhật Bản")
            {
                if (y == "Imojev(Thái Lan) 798.000 VNĐ")
                {
                    a17 = 798000;
                    i += a17;
                    b17 = "\r\n" + " + Imojev(Thái Lan)" + " " + " " + " - " + " " + " " +"Đơn giá: 798.000 VNĐ";
                }
                else if (y == "Jevax 1ml(Việt Nam) 204.000 VNĐ")
                {
                    a17 = 204000;
                    i += a17;
                    b17 = "\r\n" + " + Jevax 1ml(Việt Nam)" + " " + " " + " - " + " " + " " +"Đơn giá: 204.000 VNĐ";
                }
                list_Chon.Items.Remove("Viêm não Nhật Bản");
            }


            if (x == "Vắc xin phòng dại")
            {
                if (y == "Verorab 0,5ml - TB, TTD(Pháp) 388.000 VNĐ")
                {
                    a18 = 388000;
                    i += a18;
                    b18 = "\r\n" + " + Verorab 0,5ml - TB, TTD(Pháp)" + " " + " " + " - " + " " + " " +"Đơn giá: 388.000 VNĐ";
                }
                else if (y == "Abhayrab 0,5ml - TB(Ấn Độ) 306.000 VNĐ")
                {
                    a18 = 306000;
                    i += a18;
                    b18 = "\r\n" + " + Abhayrab 0,5ml - TB(Ấn Độ)" + " " + " " + " - " + " " + " " +"Đơn giá: 306.000 VNĐ";
                }
                else if (y == "Abhayrab 0,5ml - TTD(Ấn Độ) 258.000 VNĐ")
                {
                    a18 = 258000;
                    i += a18;
                    b18 = "\r\n" + " + Abhayrab 0,5ml - TTD(Ấn Độ)" + " " + " " + " - " + " " + " " +"Đơn giá: 258.000 VNĐ";
                }
                list_Chon.Items.Remove("Vắc xin phòng dại");
            }


            if (x == "Bạch hầu – Uốn ván – Ho gà" || x == "Bạch hầu – Ho gà – Uốn ván – Bại liệt" || x == "Bạch hầu – Uốn ván")
            {
                if (x == "Bạch hầu – Uốn ván – Ho gà")
                {
                    if (y == "Adacel(Canada) 744.000 VNĐ")
                    {
                        a19 = 744000;
                        i += a19;
                        b19 = "\r\n" + " + Adacel(Canada)" + " " + " " + " - " + " " + " " +"Đơn giá: 744.000 VNĐ";
                    }
                    else if (y == "Boostrix(Bỉ) 882.000 VNĐ")
                    {
                        a19 = 882000;
                        i += a19;
                        b19 = "\r\n" + " + Boostrix(Bỉ)" + " " + " " + " - " + " " + " " +"Đơn giá: 882.000 VNĐ";
                    }
                }
                else if (x == "Bạch hầu – Ho gà – Uốn ván – Bại liệt")
                {
                    if (y == "Tetraxim(Pháp) 550.000 VNĐ")
                    {
                        a20 = 550000;
                        i += a20;
                        b20 = "\r\n" + " + Tetraxim(Pháp)" + " " + " " + " - " + " " + " " +"Đơn giá: 550.000 VNĐ";
                    }
                }
                else if (x == "Bạch hầu – Uốn ván")
                {
                    if (y == "Uốn ván,bạch hầuTd-Lọ 0,5ml(Việt Nam) 150.000 VNĐ")
                    {
                        a21 = 150000;
                        i += a21;
                        b21 = "\r\n" + " + Uốn ván,bạch hầuTd-Lọ 0,5ml(Việt Nam)" + " " + " " + " " + " - " + " " +"Đơn giá: 150.000 VNĐ";
                    }
                    else if (y == "Uốn ván,bạch hầuTd-Liều 0,5 ml(Việt Nam) 114.000 VNĐ")
                    {
                        a21 = 114000;
                        i += a21;
                        b21 = "\r\n" + " + Uốn ván,bạch hầuTd-Liều 0,5 ml(Việt Nam)" + " " + " " + " - " + " " + " " +"Đơn giá: 114.000 VNĐ";
                    }
                    else if (y == "Uốn ván,bạch hầuTd-Lọ 5ml(Việt Nam) 696.000 VNĐ")
                    {
                        a21 = 696000;
                        i += a21;
                        b21 = "\r\n" + " + Uốn ván,bạch hầuTd-Lọ 5ml(Việt Nam)" + " " + " " + " - " + " " + " " +"Đơn giá: 696.000 VNĐ";
                    }
                }
                list_Chon.Items.Remove("Bạch hầu – Uốn ván – Ho gà");
                list_Chon.Items.Remove("Bạch hầu – Ho gà – Uốn ván – Bại liệt");
                list_Chon.Items.Remove("Bạch hầu – Uốn ván");
            }


            if (x == "Viêm gan B và Viêm gan A" || x == "Viêm gan A")
            {
                if (x == "Viêm gan B và Viêm gan A")
                {
                    if (y == "Twinrix(Bỉ) 672.000 VNĐ")
                    {
                        a22 = 672000;
                        i += a22;
                        b22 = "\r\n" + " + Twinrix(Bỉ)" + " " + " " + " - " + " " + " " +"Đơn giá: 672.000 VNĐ";
                    }
                }
                else if (x == "Viêm gan A")
                {
                    if (y == "Havax 0,5ml(Việt Nam) 282.000 VNĐ")
                    {
                        a23 = 282000;
                        i += a23;
                        b23 = "\r\n" + " + Havax 0,5ml(Việt Nam)" + " " + " " + " - " + " " + " " +"Đơn giá: 282.000 VNĐ";
                    }
                    else if (y == "AVAXIM 80U(Pháp) 708.000 VNĐ")
                    {
                        a23 = 708000;
                        i += a23;
                        b23 = "\r\n" + " + AVAXIM 80U(Pháp)" + " " + " " + " - " + " " + " " +"Đơn giá: 708.000 VNĐ";
                    }
                }
                list_Chon.Items.Remove("Viêm gan B và Viêm gan A");
                list_Chon.Items.Remove("Viêm gan A");
            }


            if (x == "Thương hàn")
            {
                if (y == "Typhoid VI(Việt Nam) 174.000 VNĐ")
                {
                    a24 = 174000;
                    i += a24;
                    b24 = "\r\n" + " + Typhoid VI(Việt Nam)" + " " + " " + " - " + " " + " " +"Đơn giá: 174.000 VNĐ";
                }
                else if (y == "Typhim VI(Pháp) 360.000 VNĐ")
                {
                    a24 = 360000;
                    i += a24;
                    b24 = "\r\n" + " + Typhim VI(Pháp)" + " " + " " + " - " + " " + " " +"Đơn giá: 360.000 VNĐ";
                }
                list_Chon.Items.Remove("Thương hàn");
            }


            if (x == "Các bệnh do Hib")
            {
                if (y == "Các bệnh do Hib(Cu Ba) 287.000 VNĐ")
                {
                    a25 = 287000;
                    i += a25;
                    b25 = "\r\n" + " + Các bệnh do Hib(Cu Ba)" + " " + " " + " - " + " " + " " +"Đơn giá: 287.000 VNĐ";
                }
                list_Chon.Items.Remove("Các bệnh do Hib");
            }


            if (x == "Tả")
            {
                if (y == "mORCVAX(Việt Nam) 138.000 VNĐ")
                {
                    a26 = 138000;
                    i += a26;
                    b26 = "\r\n" + " + mORCVAX(Việt Nam)" + " " + " " + " - " + " " + " " +"Đơn giá: 138.000 VNĐ";
                }
                list_Chon.Items.Remove("Tả");
            }

            combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem.ToString());
            k++;
            //chỉ cho phép tối đa 3 loại vắc xin
            if (k == 3)
            {
                list_Chon.Enabled = false;
                combo_TuyChon.Enabled = false;
            }
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            if (txtHovaTen.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || DTimePick_NgaySinh.Value == null || radio_Nam.Checked == false && radio_Nu.Checked == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                this.Width = 740;
                group_TTKH.Visible = false;
                label1.Visible = false;
                txtLietKe.Visible = true;

                //Tính tuổi
                int namhientai = DateTime.Now.Year;
                int namsinh = int.Parse(DTimePick_NgaySinh.Value.Year.ToString());
                tuoi = Convert.ToString(namhientai - namsinh);

                //Kiểm tra giới tính
                if(radio_Nam.Checked == true)
                {
                    gt = "Nam";
                }
                else if (radio_Nu.Checked == true)
                {
                    gt = "Nữ";
                }

                //Kiểm tra mã khách hàng
                if(txtMaKH.Text == "")
                {
                    j++;
                    makh = Convert.ToString(j);
                }
                else makh = txtMaKH.Text;


                //tính tổng tất cả các checkbox lại
                tongthanhtien = i;
                //gán biến tong là string = chuyển đổi qua string cho (tongthanhtien) - tong bây giờ là dữ liệu của tongthanhtien
                tong = Convert.ToString(tongthanhtien);
                //chuyển đổi tong qua số thập phân để tiến hành định dạng tiền tệ
                tiente = Convert.ToDouble(tong);
                //định dạng kiểu 123,456 VNĐ
                tong = tiente.ToString("0#,### VNĐ");

                txtLietKe.Text = "Khách hàng: " + txtHovaTen.Text +
                " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Tuổi: " + tuoi +
                " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Giới tính: " + gt +
                "\r\n" + "Mã khách hàng: " + makh +
                " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Điện Thoại: " + txtSDT.Text +
                "\r\n" + "Địa Chỉ: " + txtDiaChi.Text +
                "\r\n" + "Tên gói/vaccine: " + b1 + b2 + b3 + b4 + b5 + b6 + b7 + b8 + b9 + b10 + b11 + b12 + b13 + b14 + b15 + b16 + b17 + b18 + b19 + b20 + b21 + b22 + b23 + b24 + b25 + b26 +
                "\r\n\r\n" + "Thành Tiền: " + tong +
                "\r\n\r\n\r\n" + "Lưu Ý:" +
                "\r\n- Quý khách vui lòng thường xuyên kiểm tra điện thoại để được thông báo thời gian tiêm" +
                "\r\n- Nơi sử dụng dịch vụ: VNVC Tây Ninh" +
                "\r\n- Khi đến địa điểm, Quý khách sẽ được các bác sĩ kiểm tra sức khỏe và tư vấn trực tiếp thêm." +
                "\r\nNhằm đảm bảo Quý khách có sử dụng được vắc xin đã chọn hay không" +
                "\r\nVà thể trạng đủ điều kiện để tiêm nhiều loại vắc xin(nếu quý khách chọn nhiều loại)";

                labeltest.Text = txtLietKe.Text;
                txtLietKe.Height = labeltest.Height;
                btTaoMoi.Visible = true;
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            list_DaChon.Items.Clear();
            btXacNhan.Enabled = false;
            btChon.Enabled = false;
            combo_TuyChon.Items.Remove(combo_TuyChon.SelectedItem);
            combo_TuyChon.Items.Clear();

            list_Chon.Items.Clear();
            list_Chon.Items.Remove(list_Chon.SelectedItem);
            i *= 0;
            j *= 0;
            k *= 0;
            
            //gán chuỗi về ban đầu để loại bỏ thông tin trước khi reset
            b1 = ""; b2 = ""; b3 = ""; b4 = ""; b5 = ""; b6 = ""; b7 = ""; b8 = ""; b9 = ""; b10 = ""; b11 = ""; b12 = ""; b13 = ""; b14 = ""; b15 = ""; b16 = ""; b17 = ""; b18 = ""; b19 = ""; b20 = ""; b21 = ""; b22 = ""; b23 = ""; b24 = ""; b25 = ""; b26 = "";

            //tạo mới lại list chọn đối với trường hợp đã chọn 1 số loại vắc xin trước đó ( lúc này nó đã xóa 1 số cái rồi)
            list_Chon.Items.Add("Bạch hầu, ho gà, uốn ván, bại liệt và Hib");
            list_Chon.Items.Add("Bạch hầu, ho gà, uốn ván, bại liệt, Hib và viêm gan B");
            list_Chon.Items.Add("Rota virus");
            list_Chon.Items.Add("Các bệnh do phế cầu");
            list_Chon.Items.Add("Lao");
            list_Chon.Items.Add("Viêm gan B người lớn");
            list_Chon.Items.Add("Viêm gan B trẻ em");
            list_Chon.Items.Add("Viêm màng não mô cầu BC");
            list_Chon.Items.Add("Viêm màng não mô cầu ACYW");
            list_Chon.Items.Add("Sởi");
            list_Chon.Items.Add("Sởi – Quai bị – Rubella");
            list_Chon.Items.Add("Thủy đậu");
            list_Chon.Items.Add("Cúm");
            list_Chon.Items.Add("Cúm (người lớn > 18 tuổi)");
            list_Chon.Items.Add("Ung thư cổ tử cung và u nhú bộ phận sinh dục, sùi mào gà");
            list_Chon.Items.Add("Phòng uốn ván");
            list_Chon.Items.Add("Viêm não Nhật Bản");
            list_Chon.Items.Add("Vắc xin phòng dại");
            list_Chon.Items.Add("Bạch hầu – Uốn ván – Ho gà");
            list_Chon.Items.Add("Bạch hầu – Ho gà – Uốn ván – Bại liệt");
            list_Chon.Items.Add("Bạch hầu – Uốn ván");
            list_Chon.Items.Add("Viêm gan B và Viêm gan A");
            list_Chon.Items.Add("Viêm gan A");
            list_Chon.Items.Add("Thương hàn");
            list_Chon.Items.Add("Các bệnh do Hib");
            list_Chon.Items.Add("Tả");

            list_Chon.Enabled = true;
            combo_TuyChon.Enabled = true;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát không?"
            + "\n" + " " + "\n" + "Nếu thoát thì bấm 'Yes'"
            + "\n" + "Nếu khởi động lại thì bấm 'No'"
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

        private void DTimePick_NgayTiem_ValueChanged(object sender, EventArgs e)
        {
            trick2.Visible = false;
        }
    }
}
