using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Chuoi_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;
        private void textBox1_Leave(object sender, EventArgs e)
        {
            /*
            if (txtNhapC1.Text != "")
            {
                //câu 1
                //Cho chữ đậm lên
                txtNhapC1.Font = new Font(txtNhapC1.Font, FontStyle.Bold);




                //Cắt khoảng trắng 2 bên và 2 khoảng trắng trở lên
                string hoten = txtNhapC1.Text.Trim();
                //>= 0 nghĩa là có vị trí 2 khoảng trắng
                //vd Ba    me (4 khoảng trắng) lượt 1 chạy tìm được 2 cái 2 khoảng trắng xóa thành Ba  me
                //lap lai thấy 1 cái 2 khoảng trắng xóa thành Ba me
                while (hoten.IndexOf("  ") >= 0)    //tim trong chuoi vi tri co 2 khoang trong tro len      
                {
                    hoten = hoten.Replace("  ", " "); //sau do thay the bang 1 khoang trong  rồi quay lại
                }            
                txtNhapC1.Text = hoten;




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
                txtNhapC1.Text = strchuyendoi;

                string[] khoangtrang = hoten.Split(' ');
                txtdemkytudaxoa1.Text = "số khoảng trắng: " + (khoangtrang.Length - 1);

                
            }
            else MessageBox.Show("Vui Lòng Nhập", "Thông báo");
            */
                
        }
        private static bool IsNumber(string val)
        {
            if (val != "")
                return Regex.IsMatch(val, @"^[0-9]\d*\.?[0]*$");
            else return true;
        }

        public static int DemKhoangTrang(string str)
        {
            int bien_dem = 0;
            string str1;
            for (int i = 0; i < str.Length; i++)
            {
                str1 = str.Substring(i, 1);
                if (str1 == " ")
                    bien_dem++;
            }
            return bien_dem;
        }

        private void txtHocPhi_Leave(object sender, EventArgs e)
        {
            if (txtHocPhi.Text != "")
            {
                if (IsNumber(txtHocPhi.Text) != true)
                {
                    MessageBox.Show("Dữ liệu nhập không hợp lệ, không phải số nguyên dương", "Thông báo");
                    txtHocPhi.Text = "";
                }
                else
                {
                    double tiente = Convert.ToDouble(txtHocPhi.Text);
                    txtHocPhi.Text = tiente.ToString("#,###");
                }
            }
            else MessageBox.Show("Không được rỗng");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CB_DoiThay.Checked)
            {
                if (radioKoPB.Checked)
                {
                    string hoten1 = txtNhapC1.Text.ToLower();
                    string x = txtChuoidoi.Text.ToLower();
                    string y = txtChuoithay.Text.ToLower();
                    txtNhapC1.Text = hoten1.Replace(x, y);
                }
                else if(radioPB.Checked)
                {
                    string hoten1 = txtNhapC1.Text;
                    string x = txtChuoidoi.Text;
                    string y = txtChuoithay.Text;
                    txtNhapC1.Text = hoten1.Replace(x, y);
                }
            }
            

            //Tô đậm chữ
            txtKQ.Font = new Font(txtNhapC1.Font, FontStyle.Bold);



            string hoten = txtNhapC1.Text.ToLower().Trim();
            //Cắt khoảng trắng 2 bên và 2 khoảng trắng trở lên;
            //>= 0 nghĩa là có vị trí 2 khoảng trắng
            //vd Ba    me (4 khoảng trắng) lượt 1 chạy tìm được 2 cái 2 khoảng trắng xóa thành Ba  me
            //lap lai thấy 1 cái 2 khoảng trắng xóa thành Ba me
            while (hoten.IndexOf("  ") >= 0)    //tim trong chuoi vi tri co 2 khoang trong tro len      
            {
                hoten = hoten.Replace("  ", " "); //sau do thay the bang 1 khoang trong  rồi quay lại
            }
            txtKQ.Text = hoten;



            
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
            txtKQ.Text = strchuyendoi;
            

            /*
            //viet hoa chu cai dau, chu cai sau viet thuong
            int i = 0;
            hoten = hoten.ToLower();
            while (i != hoten.Length)
            {
                if (hoten[i] == ' ' && hoten[i + 1] == ' ')
                {
                    hoten = hoten.Remove(i + 1, 1);
                    i = 0;
                }
                i++;
            }
            string p = hoten[0].ToString();
            p = p.ToUpper();
            hoten = hoten.Remove(0, 1);
            hoten = hoten.Insert(0, p);
            i = 0;
            while (i < hoten.Length)
            {
                if (hoten[i] == ' ')
                {
                    p = hoten[i + 1].ToString();
                    p = p.ToUpper();
                    hoten = hoten.Remove(i + 1, 1);
                    hoten = hoten.Insert(i + 1, p);
                }
                i++;
            }
            txtKQ.Text = hoten;
            */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string hoten = txtKQ.Text;
            string[] khoangtrang = hoten.Split(' ');
            string str2;
            str2 = Convert.ToString(txtNhapC1.Text);
            txtdemkytudaxoa.Text = "Số khoảng trắng được xóa là: " + (DemKhoangTrang(str2) - (khoangtrang.Length - 2));
            txtdemkytudaxoa1.Text = "Số khoảng trắng hiện tại là: " + (khoangtrang.Length - 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtChuoidoi.Enabled = false;
            txtChuoithay.Enabled = false;
            groupBox2.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtNhapC1.ResetText();
            txtKQ.ResetText();
            txtdemkytudaxoa.ResetText();
            txtdemkytudaxoa1.ResetText();
            txtHocPhi.ResetText();
            txtChuoidoi.ResetText();
            txtChuoithay.ResetText();
            txtSoLan.ResetText();
            CB_DoiThay.Checked = false;
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

        private void CB_DoiThay_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_DoiThay.Checked)
            {
                radioPB.Checked = true;
                txtChuoidoi.Enabled = true;
                txtChuoithay.Enabled = true;
                groupBox2.Enabled = true;
            }
            else
            {
                txtChuoidoi.Enabled = false;
                txtChuoithay.Enabled = false;
                groupBox2.Enabled = false;
                radioPB.Checked = false;
                radioKoPB.Checked = false;
            }
        }

        private void txtNhapC1_TextChanged(object sender, EventArgs e)
        {
            //câu 2
            /*string hoten = txtNhapC1.Text;
            string[] khoangtrang = hoten.Split(' ');
            txtdemkytudaxoa.Text = "Số khoảng trắng: " + (khoangtrang.Length - 1);
            txtdemkytudaxoa1.Text = "Số ký tự: " + hoten.Length;*/
            txtKQ.ResetText();
            txtdemkytudaxoa.ResetText();
            txtdemkytudaxoa1.ResetText();
        }

        private void CB_DoiThay_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(CB_DoiThay, "Đổi chuỗi cần tìm trong 'Nhập chuỗi'");
        }

        private void txtChuoidoi_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(CB_DoiThay, "Đổi chuỗi cần tìm trong 'Nhập chuỗi'");
        }

        private void txtChuoithay_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(CB_DoiThay, "Chuỗi cần thay khi đã tìm 'Nhập chuỗi'");
        }

        private void groupBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(CB_DoiThay, "Chọn không phân biệt/phân biệt chữ hoa,thường khi đổi");
        }
    }
}
