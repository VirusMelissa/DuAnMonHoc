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
    public partial class Kiemtra2_Switch_case_default : Form
    {
        //bool là kiểu dữ liệu true và false
        public Kiemtra2_Switch_case_default()
        {
            InitializeComponent();
        }

        private void Kiemtra2_Switch_case_default_Load(object sender, EventArgs e)
        {
            groupNhapdaucuoi.Visible = false;
            groupNhapKT.Visible = false;
            groupNhapSN.Visible = false;
            ListBoxSo.Visible = false;
            ListBoxKT.Visible = false;

            bt0.Visible = false;
            bt1.Visible = false;
            bt2.Visible = false;
            bt3.Visible = false;
            bt4.Visible = false;
            bt5.Visible = false;
            bt6.Visible = false;
            bt7.Visible = false;
            bt8.Visible = false;
            bt9.Visible = false;
            btsao.Visible = false;
            btbang.Visible = false;
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            if (radio_SoNguyen.Checked)
            {
                if (txtSo.Text != "")
                {
                    int x = Convert.ToInt32(txtSo.Text);
                    /*if (x == 1 || x == 2 || x == 3)
                    {
                        txtQuy.Text = "1";
                    }
                    else if (x == 4 || x == 5 || x == 6)
                    {
                        txtQuy.Text = "2";
                    }
                    else if (x == 7 || x == 8 || x == 9)
                    {
                        txtQuy.Text = "3";
                    }
                    else if (x == 7 || x == 8 || x == 9)
                    {
                        txtQuy.Text = "4";
                    }
                    else MessageBox.Show("Không có tháng" + " " + txtSo.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
                    switch (x)
                    {
                        case 1:
                        case 2:
                        case 3:
                            txtQuy.Text = "1";
                            break;
                        case 4:
                        case 5:
                        case 6:
                            txtQuy.Text = "2";
                            break;
                        case 7:
                        case 8:
                        case 9:
                            txtQuy.Text = "3";
                            break;
                        case 10:
                        case 11:
                        case 12:
                            txtQuy.Text = "4";
                            break;
                        default:
                            MessageBox.Show("Không có tháng" + " " + txtSo.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                else MessageBox.Show("Không được rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if(radio_TenSP.Checked)
            {
                if (txtNhapKT.Text != "")
                {
                    char x = Convert.ToChar(txtNhapKT.Text);
                    /*if (x == 'P')
                    {
                        //xóa cái cũ rồi sau đó tạo cái mới
                        ComboBox_TenSP.Items.Clear();
                        ComboBox_TenSP.Items.Add("Phô Mai");
                        ComboBox_TenSP.Items.Add("Phi Lê Cá");
                        ComboBox_TenSP.Items.Add("Phô Mai Dê");
                        ComboBox_TenSP.Items.Add("Phô Mát Parmesan Cà Tím");
                    }
                    else if (x == 'K')
                    {
                        ComboBox_TenSP.Items.Clear();
                        ComboBox_TenSP.Items.Add("Kẹo Mút");
                        ComboBox_TenSP.Items.Add("Kẹo SôCôLa");
                        ComboBox_TenSP.Items.Add("Kẹo Dẻo");
                        ComboBox_TenSP.Items.Add("Kẹo Bơ Cứng");
                        ComboBox_TenSP.Items.Add("Kẹo Đậu Phộng");
                        ComboBox_TenSP.Items.Add("Khoai Tây Bỏ Lò");
                        ComboBox_TenSP.Items.Add("Khoai Tây Chiên Thịt Xông Khói");
                        ComboBox_TenSP.Items.Add("Kem Vani");
                        ComboBox_TenSP.Items.Add("Kem Sorbet Cam");
                    }
                    else if (x == 'N')
                    {
                        ComboBox_TenSP.Items.Clear();
                        ComboBox_TenSP.Items.Add("Nước Tương");
                        ComboBox_TenSP.Items.Add("Nước Chấm Ô Liu");
                        ComboBox_TenSP.Items.Add("Nước Ép Cà Chua");
                        ComboBox_TenSP.Items.Add("Nước Ép Anh Đào");
                        ComboBox_TenSP.Items.Add("Nước Ép Quả Mọng");
                    }
                    else if (x == 'S')
                    {
                        ComboBox_TenSP.Items.Clear();
                        ComboBox_TenSP.Items.Add("Salad Mùa Hè");
                        ComboBox_TenSP.Items.Add("Salad Củ Dền");
                        ComboBox_TenSP.Items.Add("Salad BLT");
                        ComboBox_TenSP.Items.Add("Sốt Salsa");
                        ComboBox_TenSP.Items.Add("Sốt Chanh");
                        ComboBox_TenSP.Items.Add("Sôcôla Nóng");
                        ComboBox_TenSP.Items.Add("Sandwich Mứt và Bơ Đậu Phộng");
                        ComboBox_TenSP.Items.Add("Sushi Cuộn");
                        ComboBox_TenSP.Items.Add("Súp Cà Chua");
                        ComboBox_TenSP.Items.Add("Súp Tôm Hùm");
                    }
                    else if (x == 'B')
                    {
                        ComboBox_TenSP.Items.Clear();
                        ComboBox_TenSP.Items.Add("Bánh Nhân Cá");
                        ComboBox_TenSP.Items.Add("Bánh Quy");
                        ComboBox_TenSP.Items.Add("Bánh Cà Rốt");
                        ComboBox_TenSP.Items.Add("Bánh Phô Mai");
                        ComboBox_TenSP.Items.Add("Bánh Kem Dâu");
                        ComboBox_TenSP.Items.Add("Bánh Dứa");
                        ComboBox_TenSP.Items.Add("Bánh Feta Khoai Tây");
                        ComboBox_TenSP.Items.Add("Bánh Táo Mật Ong");

                    }
                    else if (x == 'M')
                    {
                        ComboBox_TenSP.Items.Clear();
                        ComboBox_TenSP.Items.Add("Mứt Cam");
                        ComboBox_TenSP.Items.Add("Mứt Nho");
                        ComboBox_TenSP.Items.Add("Mứt Táo");
                        ComboBox_TenSP.Items.Add("Mứt Đào");
                        ComboBox_TenSP.Items.Add("Mứt Dâu");
                        ComboBox_TenSP.Items.Add("Mứt Anh Đào");
                        ComboBox_TenSP.Items.Add("Mayonnaise");
                    }
                    else if (x == 'C')
                    {
                        ComboBox_TenSP.Items.Clear();
                        ComboBox_TenSP.Items.Add("Chuối Chẻ");
                        ComboBox_TenSP.Items.Add("Cà Phê Latte");
                        ComboBox_TenSP.Items.Add("Cà Phê Espresso");
                        ComboBox_TenSP.Items.Add("Cà Phê Mocha");
                        ComboBox_TenSP.Items.Add("Cà Chua Nướng");
                        ComboBox_TenSP.Items.Add("Cà Tím Nướng");
                        ComboBox_TenSP.Items.Add("Cơm Chiên");
                        ComboBox_TenSP.Items.Add("Cá Sốt Cay");
                        ComboBox_TenSP.Items.Add("Canh Hành");
                    }
                    else if (x == 'T')
                    {
                        ComboBox_TenSP.Items.Clear();
                        ComboBox_TenSP.Items.Add("Trà Xanh");
                        ComboBox_TenSP.Items.Add("Trà Táo Gừng");
                        ComboBox_TenSP.Items.Add("Trà Sữa");
                        ComboBox_TenSP.Items.Add("Trà Chanh");
                        ComboBox_TenSP.Items.Add("Trà Mật Ong");
                        ComboBox_TenSP.Items.Add("Trà Cam");
                        ComboBox_TenSP.Items.Add("Trà Bạc Hà");
                        ComboBox_TenSP.Items.Add("Trà Cam");
                        ComboBox_TenSP.Items.Add("Trà Tắc");
                        ComboBox_TenSP.Items.Add("Taco");
                        ComboBox_TenSP.Items.Add("Taco Cá");
                    }
                    else if (x == 'D')
                    {
                        ComboBox_TenSP.Items.Clear();
                        ComboBox_TenSP.Items.Add("Donut Truyền Thống");
                        ComboBox_TenSP.Items.Add("Donut Đậu Phộng");
                        ComboBox_TenSP.Items.Add("Donut Kem");
                        ComboBox_TenSP.Items.Add("Donut Phủ Kẹo Cốm");
                        ComboBox_TenSP.Items.Add("Donut Thịt Xông Khói");
                        ComboBox_TenSP.Items.Add("Donut Có Nhân");
                    }
                    else MessageBox.Show("Không có sản phẩm bắt đầu từ ký tự:" + " " + txtNhapKT.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    */
                    switch (x)
                    {
                        case 'P':
                            ComboBox_TenSP.Items.Clear();
                            ComboBox_TenSP.Items.Add("Phô Mai");
                            ComboBox_TenSP.Items.Add("Phi Lê Cá");
                            ComboBox_TenSP.Items.Add("Phô Mai Dê");
                            ComboBox_TenSP.Items.Add("Phô Mát Parmesan Cà Tím");
                            break;
                        case 'K':
                            ComboBox_TenSP.Items.Clear();
                            ComboBox_TenSP.Items.Add("Kẹo Mút");
                            ComboBox_TenSP.Items.Add("Kẹo SôCôLa");
                            ComboBox_TenSP.Items.Add("Kẹo Dẻo");
                            ComboBox_TenSP.Items.Add("Kẹo Bơ Cứng");
                            ComboBox_TenSP.Items.Add("Kẹo Đậu Phộng");
                            ComboBox_TenSP.Items.Add("Khoai Tây Bỏ Lò");
                            ComboBox_TenSP.Items.Add("Khoai Tây Chiên Thịt Xông Khói");
                            ComboBox_TenSP.Items.Add("Kem Vani");
                            ComboBox_TenSP.Items.Add("Kem Sorbet Cam");
                            break;
                        case 'N':
                            ComboBox_TenSP.Items.Clear();
                            ComboBox_TenSP.Items.Add("Nước Tương");
                            ComboBox_TenSP.Items.Add("Nước Chấm Ô Liu");
                            ComboBox_TenSP.Items.Add("Nước Ép Cà Chua");
                            ComboBox_TenSP.Items.Add("Nước Ép Anh Đào");
                            ComboBox_TenSP.Items.Add("Nước Ép Quả Mọng");
                            break;
                        case 'S':
                            ComboBox_TenSP.Items.Clear();
                            ComboBox_TenSP.Items.Add("Salad Mùa Hè");
                            ComboBox_TenSP.Items.Add("Salad Củ Dền");
                            ComboBox_TenSP.Items.Add("Salad BLT");
                            ComboBox_TenSP.Items.Add("Sốt Salsa");
                            ComboBox_TenSP.Items.Add("Sốt Chanh");
                            ComboBox_TenSP.Items.Add("Sôcôla Nóng");
                            ComboBox_TenSP.Items.Add("Sandwich Mứt và Bơ Đậu Phộng");
                            ComboBox_TenSP.Items.Add("Sushi Cuộn");
                            ComboBox_TenSP.Items.Add("Súp Cà Chua");
                            ComboBox_TenSP.Items.Add("Súp Tôm Hùm");
                            break;
                        case 'B':
                            ComboBox_TenSP.Items.Clear();
                            ComboBox_TenSP.Items.Add("Bánh Nhân Cá");
                            ComboBox_TenSP.Items.Add("Bánh Quy");
                            ComboBox_TenSP.Items.Add("Bánh Cà Rốt");
                            ComboBox_TenSP.Items.Add("Bánh Phô Mai");
                            ComboBox_TenSP.Items.Add("Bánh Kem Dâu");
                            ComboBox_TenSP.Items.Add("Bánh Dứa");
                            ComboBox_TenSP.Items.Add("Bánh Feta Khoai Tây");
                            ComboBox_TenSP.Items.Add("Bánh Táo Mật Ong");
                            break;
                        case 'M':
                            ComboBox_TenSP.Items.Clear();
                            ComboBox_TenSP.Items.Add("Mứt Cam");
                            ComboBox_TenSP.Items.Add("Mứt Nho");
                            ComboBox_TenSP.Items.Add("Mứt Táo");
                            ComboBox_TenSP.Items.Add("Mứt Đào");
                            ComboBox_TenSP.Items.Add("Mứt Dâu");
                            ComboBox_TenSP.Items.Add("Mứt Anh Đào");
                            ComboBox_TenSP.Items.Add("Mayonnaise");
                            break;
                        case 'C':
                            ComboBox_TenSP.Items.Clear();
                            ComboBox_TenSP.Items.Add("Chuối Chẻ");
                            ComboBox_TenSP.Items.Add("Cà Phê Latte");
                            ComboBox_TenSP.Items.Add("Cà Phê Espresso");
                            ComboBox_TenSP.Items.Add("Cà Phê Mocha");
                            ComboBox_TenSP.Items.Add("Cà Chua Nướng");
                            ComboBox_TenSP.Items.Add("Cà Tím Nướng");
                            ComboBox_TenSP.Items.Add("Cơm Chiên");
                            ComboBox_TenSP.Items.Add("Cá Sốt Cay");
                            ComboBox_TenSP.Items.Add("Canh Hành");
                            break;
                        case 'T':
                            ComboBox_TenSP.Items.Clear();
                            ComboBox_TenSP.Items.Add("Trà Xanh");
                            ComboBox_TenSP.Items.Add("Trà Táo Gừng");
                            ComboBox_TenSP.Items.Add("Trà Sữa");
                            ComboBox_TenSP.Items.Add("Trà Chanh");
                            ComboBox_TenSP.Items.Add("Trà Mật Ong");
                            ComboBox_TenSP.Items.Add("Trà Cam");
                            ComboBox_TenSP.Items.Add("Trà Bạc Hà");
                            ComboBox_TenSP.Items.Add("Trà Cam");
                            ComboBox_TenSP.Items.Add("Trà Tắc");
                            ComboBox_TenSP.Items.Add("Taco");
                            ComboBox_TenSP.Items.Add("Taco Cá");
                            break;
                        case 'D':
                            ComboBox_TenSP.Items.Clear();
                            ComboBox_TenSP.Items.Add("Donut Truyền Thống");
                            ComboBox_TenSP.Items.Add("Donut Đậu Phộng");
                            ComboBox_TenSP.Items.Add("Donut Kem");
                            ComboBox_TenSP.Items.Add("Donut Phủ Kẹo Cốm");
                            ComboBox_TenSP.Items.Add("Donut Thịt Xông Khói");
                            ComboBox_TenSP.Items.Add("Donut Có Nhân");
                            break;
                        default:
                            MessageBox.Show("Không có sản phẩm bắt đầu từ ký tự:" + " " + txtNhapKT.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }

                }
                else MessageBox.Show("Không được rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (radio_ThongBao.Checked)
            {
                if (ListBoxdau.SelectedItem != null && ListBoxCuoi.SelectedItem != null)
                {//khai báo biến x và y với dữ liệu được lấy trong listbox
                    string x = ListBoxdau.SelectedItem.ToString();
                    string y = ListBoxCuoi.SelectedItem.ToString();
                    /*if (x == "Life" && y == "journey")
                    {
                        txtTB.Text = x + " " + "is the" + " " + y + " " + "you will be ever on.";
                        txtTB_Viet.Text = "Cuộc sống là hành trình vĩ đại nhất mà bạn từng trải qua.";
                    }
                    else if (x == "You" && y == "biggest")
                    {
                        txtTB.Text = x + " " + "are the" + " " + y + " " + "person when you have a kindness";
                        txtTB_Viet.Text = "Bạn là người giàu có nhất khi bạn có lòng thương người.";
                    }
                    else if (x == "Don't" && y == "bad")
                    {
                        txtTB.Text = x + " " + "let a" + " " + y + " " + "day make you feel like you have a bad life";
                        txtTB_Viet.Text = "Đừng để cho một ngày buồn tẻ khiến bạn cảm thấy như mình có một cuộc sống tồi tệ.";
                    }
                    else if (x == "If" && y == "love")
                    {
                        txtTB.Text = x + " " + "you" + " " + y + " " + "life. Life will love you back";
                        txtTB_Viet.Text = "Nếu bạn yêu cuộc sống, cuộc sống sẽ yêu lại bạn.";
                    }
                    else if (x == "Once" && y == "choose")
                    {
                        txtTB.Text = x + " " + "you" + " " + y + " " + "hope, anything’s possible";
                        txtTB_Viet.Text = "Một khi bạn chọn, mọi thứ đều có thể.";
                    }
                    else if (x == "Keep" && y == "sunshine")
                    {
                        txtTB.Text = x + " " + "your face to the" + " " + y + " " + "and you can not see a shadow";
                        txtTB_Viet.Text = "Hãy hướng về phía mặt trời và bạn sẽ không nhìn thấy bóng tối đâu cả.";
                    }
                    else if (x == "Family")
                    {
                        if (y == "everything.")
                        {
                            txtTB.Text = x + " " + "is not an important thing, it’s" + " " + y;
                            txtTB_Viet.Text = "Gia đình không phải là thứ quan trọng, nó là tất cả mọi thứ.";
                        }
                        else if (y == "individuals,")
                        {
                            txtTB.Text = x + ", like" + " " + y + " " + "are unique.";
                            txtTB_Viet.Text = "Gia đình là một cá thể độc lập và duy nhất.";
                        }
                        else
                        {
                            txtTB.Text = x + " " + "where the life begins and the love never" + " " + y;
                            txtTB_Viet.Text = "Gia đình là nơi cuộc sống bắt đầu và là nơi mà tình yêu không bao giờ kết thúc.";
                        }
                    }
                    else if (x == "Love" && y == "not getting")
                    {
                        txtTB.Text = x + " " + "is" + " " + y + ", but giving.";
                        txtTB_Viet.Text = "Tình yêu không phải là điều ta nhận đuợc mà là những gì ta cho đi.";
                    }
                    else if (x == "Where" && y == "life.")
                    {
                        txtTB.Text = x + " " + "there is love, there is" + " " + y;
                        txtTB_Viet.Text = "Nơi nào có tình yêu, nơi ấy có sự sống";
                    }
                    else if (x == "Be" && y == "dream")
                    {
                        txtTB.Text = x + " " + "your" + " " + y + ", now or never";
                        txtTB_Viet.Text = "Hãy hướng về phía mặt trời và bạn sẽ không nhìn thấy bóng tối đâu cả.";
                    }*/

                    string z = x + " " + y;
                    switch (z)
                    {
                        case "Life journey":
                            txtTB.Text = x + " " + "is the" + " " + y + " " + "you will be ever on.";
                            txtTB_Viet.Text = "Cuộc sống là hành trình vĩ đại nhất mà bạn từng trải qua.";
                            break;
                        case "You biggest":
                            txtTB.Text = x + " " + "are the" + " " + y + " " + "person when you have a kindness";
                            txtTB_Viet.Text = "Bạn là người giàu có nhất khi bạn có lòng thương người.";
                            break;
                        case "Don't bad":
                            txtTB.Text = x + " " + "let a" + " " + y + " " + "day make you feel like you have a bad life";
                            txtTB_Viet.Text = "Đừng để cho một ngày buồn tẻ khiến bạn cảm thấy như mình có một cuộc sống tồi tệ.";
                            break;
                        case "If love":
                            txtTB.Text = x + " " + "you" + " " + y + " " + "life. Life will love you back";
                            txtTB_Viet.Text = "Nếu bạn yêu cuộc sống, cuộc sống sẽ yêu lại bạn.";
                            break;
                        case "Once choose":
                            txtTB.Text = x + " " + "you" + " " + y + " " + "hope, anything’s possible";
                            txtTB_Viet.Text = "Một khi bạn chọn, mọi thứ đều có thể.";
                            break;
                        case "Keep sunshine":
                            txtTB.Text = x + " " + "your face to the" + " " + y + " " + "and you can not see a shadow";
                            txtTB_Viet.Text = "Hãy hướng về phía mặt trời và bạn sẽ không nhìn thấy bóng tối đâu cả.";
                            break;
                        case "Family everything.":
                            txtTB.Text = x + " " + "is not an important thing, it’s" + " " + y;
                            txtTB_Viet.Text = "Gia đình không phải là thứ quan trọng, nó là tất cả mọi thứ.";
                            break;
                        case "Family individuals,":
                            txtTB.Text = x + ", like" + " " + y + " " + "are unique.";
                            txtTB_Viet.Text = "Gia đình là một cá thể độc lập và duy nhất.";
                            break;
                        case "Family ends.":
                            txtTB.Text = x + " " + "where the life begins and the love never" + " " + y;
                            txtTB_Viet.Text = "Gia đình là nơi cuộc sống bắt đầu và là nơi mà tình yêu không bao giờ kết thúc.";
                            break;
                        case "Love not getting":
                            txtTB.Text = x + " " + "is" + " " + y + ", but giving.";
                            txtTB_Viet.Text = "Tình yêu không phải là điều ta nhận đuợc mà là những gì ta cho đi.";
                            break;
                        case "Where life.":
                            txtTB.Text = x + " " + "there is love, there is" + " " + y;
                            txtTB_Viet.Text = "Nơi nào có tình yêu, nơi ấy có sự sống";
                            break;
                        case "Be dream":
                            txtTB.Text = x + " " + "your" + " " + y + ", now or never";
                            txtTB_Viet.Text = "Hãy hướng về phía mặt trời và bạn sẽ không nhìn thấy bóng tối đâu cả.";
                            break;
                        default:
                            break;
                    }
                }
                else MessageBox.Show("Cần phải chọn dữ liệu cho 2 bảng");
            }
        }

        private void radio_SoNguyen_CheckedChanged(object sender, EventArgs e)
        {
            ListBoxKT.Visible = false;
            groupNhapdaucuoi.Visible = false;
            groupNhapKT.Visible = false;
            groupNhapSN.Visible = true;

            txtNhapKT.ResetText();
            txtQuy.ResetText();
            txtSo.ResetText();
            txtTB.ResetText();
            txtTB_Viet.ResetText();

            ComboBox_TenSP.Items.Clear();
            ListBoxCuoi.Items.Clear();
        }

        private void radio_TenSP_CheckedChanged(object sender, EventArgs e)
        {
            groupNhapdaucuoi.Visible = false;
            groupNhapKT.Visible = true;
            groupNhapSN.Visible = false;

            ListBoxSo.Visible = false;

            bt0.Visible = false;
            bt1.Visible = false;
            bt2.Visible = false;
            bt3.Visible = false;
            bt4.Visible = false;
            bt5.Visible = false;
            bt6.Visible = false;
            bt7.Visible = false;
            bt8.Visible = false;
            bt9.Visible = false;
            btsao.Visible = false;
            btbang.Visible = false;

            txtNhapKT.ResetText();
            txtQuy.ResetText();
            txtSo.ResetText();
            txtTB.ResetText();
            txtTB_Viet.ResetText();

            ComboBox_TenSP.Items.Clear();
            ListBoxCuoi.Items.Clear();
        }

        private void radio_ThongBao_CheckedChanged(object sender, EventArgs e)
        {
            groupNhapdaucuoi.Visible = true;
            groupNhapKT.Visible = false;
            groupNhapSN.Visible = false;

            ListBoxSo.Visible = false;
            ListBoxKT.Visible = false;

            bt0.Visible = false;
            bt1.Visible = false;
            bt2.Visible = false;
            bt3.Visible = false;
            bt4.Visible = false;
            bt5.Visible = false;
            bt6.Visible = false;
            bt7.Visible = false;
            bt8.Visible = false;
            bt9.Visible = false;
            btsao.Visible = false;
            btbang.Visible = false;

            txtNhapKT.ResetText();
            txtQuy.ResetText();
            txtSo.ResetText();
            txtTB.ResetText();
            txtTB_Viet.ResetText();

            ComboBox_TenSP.Items.Clear();
            ListBoxCuoi.Items.Clear();
        }

        private void ListBoxSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSo.Text = ListBoxSo.SelectedItem.ToString();
        }

        private void groupNhapSN_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(groupNhapSN, "Nhập tháng với số từ 1-12");
        }

        private void btChon1_Click(object sender, EventArgs e)
        {
            ListBoxSo.Visible = true;

            bt0.Visible = true;
            bt1.Visible = true;
            bt2.Visible = true;
            bt3.Visible = true;
            bt4.Visible = true;
            bt5.Visible = true;
            bt6.Visible = true;
            bt7.Visible = true;
            bt8.Visible = true;
            bt9.Visible = true;
            btsao.Visible = true;
            btbang.Visible = true;
        }

        private void button_Click(object sender, EventArgs e)
        {
            {   
                //gán toàn bộ button có event button_click vào 1 biến
                Button num = (Button)sender;
                //text nhận số của biến đó
                txtSo.Text = txtSo.Text + num.Text;
            }
        }

        private void btsao_Click(object sender, EventArgs e)
        {
            //xóa text số và Qúy
            txtSo.ResetText();
            txtQuy.ResetText();
        }

        private void btsao_MouseHover(object sender, EventArgs e)
        {
            //hiển thị ghi chú khi rê chuột vào
            toolTip2.SetToolTip(btsao, "Delete");
        }

        private void btbang_Click(object sender, EventArgs e)
        {
            btRun_Click(sender, e);
        }

        private void ListBoxKT_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNhapKT.Text = ListBoxKT.SelectedItem.ToString();
        }
        private void ListBoxdau_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Nếu listbox đầu nó có Item Life thì Listbox cuối sẽ có Item journey (công phu lắm thầy ^^)
            if(ListBoxdau.SelectedItem.ToString() == "Life")
            {
                ListBoxCuoi.Items.Clear();
                ListBoxCuoi.Items.Add("journey");
            }
            else if (ListBoxdau.SelectedItem.ToString() == "You")
            {
                ListBoxCuoi.Items.Clear();
                ListBoxCuoi.Items.Add("biggest");
            }
            else if (ListBoxdau.SelectedItem.ToString() == "Don't")
            {
                ListBoxCuoi.Items.Clear();
                ListBoxCuoi.Items.Add("bad");
            }
            else if (ListBoxdau.SelectedItem.ToString() == "If")
            {
                ListBoxCuoi.Items.Clear();
                ListBoxCuoi.Items.Add("love");
            }
            else if (ListBoxdau.SelectedItem.ToString() == "Once")
            {
                ListBoxCuoi.Items.Clear();
                ListBoxCuoi.Items.Add("choose");
            }
            else if (ListBoxdau.SelectedItem.ToString() == "Keep")
            {
                ListBoxCuoi.Items.Clear();
                ListBoxCuoi.Items.Add("sunshine");
            }
            else if (ListBoxdau.SelectedItem.ToString() == "Family")
            {
                ListBoxCuoi.Items.Clear();
                ListBoxCuoi.Items.Add("everything.");
                ListBoxCuoi.Items.Add("individuals,");
                ListBoxCuoi.Items.Add("ends.");
            }
            else if (ListBoxdau.SelectedItem.ToString() == "Love")
            {
                ListBoxCuoi.Items.Clear();
                ListBoxCuoi.Items.Add("not getting");
            }
            else if (ListBoxdau.SelectedItem.ToString() == "Where")
            {
                ListBoxCuoi.Items.Clear();
                ListBoxCuoi.Items.Add("life.");
            }
            else if (ListBoxdau.SelectedItem.ToString() == "Be")
            {
                ListBoxCuoi.Items.Clear();
                ListBoxCuoi.Items.Add("dream");
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btRestart_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn khởi động lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            txtNhapKT.ResetText();
            txtQuy.ResetText();
            txtSo.ResetText();
            txtTB.ResetText();
            txtTB_Viet.ResetText();

            ComboBox_TenSP.Items.Clear();
            ListBoxCuoi.Items.Clear();
        }

        private void txtNhapKT_MouseHover(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(groupNhapSN, "Nhập ký tự (C,D,B,T,K,M,S,N,P)");
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(groupNhapSN, "Nhập ký tự (C,D,B,T,K,M,S,N,P)");
        }

        private void btChon2_Click(object sender, EventArgs e)
        {
            ListBoxKT.Visible = true;
        }
    }
}
