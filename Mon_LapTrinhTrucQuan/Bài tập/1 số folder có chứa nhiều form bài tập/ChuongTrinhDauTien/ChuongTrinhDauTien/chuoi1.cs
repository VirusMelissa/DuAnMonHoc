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
    public partial class chuoi1 : Form
    {
        public chuoi1()
        {
            InitializeComponent();
        }
        private void btThucHien_Click(object sender, EventArgs e)
        {
            //Đếm chiều dài chuỗi
            /*
            txtC1.Text = "Sang";
            txtC2.Text = "Trường Sang";
            string a = Convert.ToString(txtC1.Text);
            string b = Convert.ToString(txtC2.Text);
            txtKQ1.Text = "Chiều dài chuỗi 1 là: " + a.Length;
            txtKQ2.Text = "Chiều dài chuỗi 2 là: " + b.Length;
            */


            //So sánh 2 chuỗi phân biệt chữ hoa, thường 
            /*
            txtC1.Text = "Sang";
            txtC2.Text = "Sang";
            txtC3.Text = "sang";
            string a = Convert.ToString(txtC1.Text);
            string b = Convert.ToString(txtC2.Text);
            string c = Convert.ToString(txtC3.Text);
            if (string.Compare(a, b, false) == 0)
            {
                txtKQ1.Text = "Chuỗi 1 và 2 bằng nhau";
            }
            else
            {
                txtKQ1.Text = "Chuỗi 1 và 2 không bằng nhau";
            }

            if (string.Compare(b, c, false) == 0)
            {
                txtKQ2.Text = "Chuỗi 2 và 3 bằng nhau";
            }
            else
            {
                txtKQ2.Text = "Chuỗi 2 và 3 không bằng nhau";
            }
            */


            //So sánh 2 chuỗi không phân biệt chữ hoa, thường 
            /*
            txtC1.Text = "Sang";
            txtC2.Text = "Sang";
            txtC3.Text = "sang";
            string a = Convert.ToString(txtC1.Text);
            string b = Convert.ToString(txtC2.Text);
            string c = Convert.ToString(txtC3.Text);
            if (string.Compare(a, b, true) == 0)
            {
                txtKQ1.Text = "Chuỗi 1 và 2 bằng nhau";
            }
            else
            {
                txtKQ1.Text = "Chuỗi 1 và 2 không bằng nhau";
            }

            if (string.Compare(b, c, true) == 0)
            {
                txtKQ2.Text = "Chuỗi 2 và 3 bằng nhau";
            }
            else
            {
                txtKQ2.Text = "Chuỗi 2 và 3 không bằng nhau";
            }
            */


            //So sánh sự giống nhau điểm bắt đầu của 2 chuỗi
            /*
            txtC1.Text = "Nguyễn Linh Trường Sang";
            txtC2.Text = "Nguyễn";
            txtC3.Text = "Sang";
            string a = Convert.ToString(txtC1.Text);
            string b = Convert.ToString(txtC2.Text);
            string c = Convert.ToString(txtC3.Text);
            if (a.StartsWith(b))
            {
                txtKQ1.Text = "Điểm bắt đầu chuỗi 2 giống chuỗi 1";
            }
            else
            {
                txtKQ1.Text = "Điểm bắt đầu chuỗi 2 khác chuỗi 1";
            }
            if (a.StartsWith(c))
            {
                txtKQ2.Text = "Điểm bắt đầu chuỗi 2 giống chuỗi 1";
            }
            else
            {
                txtKQ2.Text = "Điểm bắt đầu chuỗi 3 khác chuỗi 1";
            }
            */


            //So sánh sự giống nhau điểm kết thúc của 2 chuỗi
            /*
            txtC1.Text = "Nguyễn Linh Trường Sang";
            txtC2.Text = "Nguyễn";
            txtC3.Text = "Sang";
            string a = Convert.ToString(txtC1.Text);
            string b = Convert.ToString(txtC2.Text);
            string c = Convert.ToString(txtC3.Text);
            if (a.EndsWith(b))
            {
                txtKQ1.Text = "Điểm kết thúc chuỗi 2 giống chuỗi 1";
            }
            else
            {
                txtKQ1.Text = "Điểm kết thúc chuỗi 2 khác chuỗi 1";
            }
            if (a.EndsWith(c))
            {
                txtKQ2.Text = "Điểm kết thúc chuỗi 3 giống chuỗi 1";
            }
            else
            {
                txtKQ2.Text = "Điểm kết thúc chuỗi 3 khác chuỗi 1";
            }
            */



            //So sánh sự tồn tại chuỗi này trong chuỗi kia
            /*
            txtC1.Text = "Nguyễn Linh Trường Sang";
            txtC2.Text = "Trường";
            txtC3.Text = "Quang";
            string a = Convert.ToString(txtC1.Text);
            string b = Convert.ToString(txtC2.Text);
            string c = Convert.ToString(txtC3.Text);
            if (a.Contains(b))
            {
                txtKQ1.Text = "Tìm thấy chuỗi 2 trong chuỗi 1";
            }
            else
            {
                txtKQ1.Text = "Không tìm thấy chuỗi 2 trong chuỗi 1";
            }
            if (a.Contains(c))
            {
                txtKQ2.Text = "Tìm thấy chuỗi 3 trong chuỗi 1";
            }
            else
            {
                txtKQ2.Text = "Không tìm thấy chuỗi 3 trong chuỗi 1";
            }
            */


            //Tìm vị trí xuất hiện đầu tiên của chuỗi cần tìm trong chuỗi hiện có
            /*
            txtC1.Text = "Nguyễn Linh Trường Sang";
            string a = Convert.ToString(txtC1.Text);
            int dem1 = a.IndexOf("ng");
            if (dem1 >= 0)
            { txtKQ1.Text = "Tìm thấy 'ng' trong chuỗi 1 tại vị trí: " + dem1; }else txtKQ1.Text = "không tìm thấy 'ng' trong chuỗi 1";
            int dem2 = a.IndexOf("Linh");
            if (dem2 >= 0)
            { txtKQ2.Text = "Tìm thấy 'Linh' trong chuỗi 1 tại vị trí: " + dem2; }else txtKQ2.Text = "không tìm thấy 'Linh' trong chuỗi 1";
            int dem3 = a.IndexOf("n");
            if (dem3 >= 0)
            { txtC2.Text = "Tìm thấy 'n' trong chuỗi 1 tại vị trí: " + dem3; }else txtC2.Text = "không tìm thấy 'n' trong chuỗi 1";
            int dem4 = a.IndexOf("Quang");
            if (dem4 >= 0)
            { txtC3.Text = "Tìm thấy 'Quang' trong chuỗi 1 tại vị trí: " + dem4; }else txtC3.Text = "không tìm thấy 'Quang' trong chuỗi 1";
            */
            //trường hợp nhập
            /*string a = Convert.ToString(txtC1.Text);
            int dem1 = a.IndexOf(txtC2.Text);
            if (dem1 >= 0)
            { txtKQ1.Text = "Tìm thấy 'ng' trong chuỗi 1 tại vị trí: " + dem1; }
            else txtKQ1.Text = "không tìm thấy 'ng' trong chuỗi 1";*/


            //Tìm vị trí xuất hiện cuối cùng của chuỗi cần tìm trong chuỗi hiện có
            /*
            txtC1.Text = "Nguyễn Linh Trường Sang";
            string a = Convert.ToString(txtC1.Text);
            int dem1 = a.LastIndexOf("ng");
            if (dem1 >= 0)
            { txtKQ1.Text = "Tìm thấy 'ng' trong chuỗi 1 tại vị trí: " + dem1; }else txtKQ1.Text = "không tìm thấy 'ng' trong chuỗi 1";
            int dem2 = a.LastIndexOf("Linh");
            if (dem2 >= 0)
            { txtKQ2.Text = "Tìm thấy 'Linh' trong chuỗi 1 tại vị trí: " + dem2; }else txtKQ2.Text = "không tìm thấy 'Linh' trong chuỗi 1";
            int dem3 = a.LastIndexOf("n");
            if (dem3 >= 0)
            { txtC2.Text = "Tìm thấy 'n' trong chuỗi 1 tại vị trí: " + dem3; }else txtC2.Text = "không tìm thấy 'n' trong chuỗi 1";
            int dem4 = a.LastIndexOf("Quang");
            if (dem4 >= 0)
            { txtC3.Text = "Tìm thấy 'Quang' trong chuỗi 1 tại vị trí: " + dem4; }else txtC3.Text = "không tìm thấy 'Quang' trong chuỗi 1";
            */


            //Kiểm tra đầu chuỗi có tồn tại chuỗi cần tìm không
            /*
            txtC1.Text = "Nguyễn Linh Trường Sang";
            string a = Convert.ToString(txtC1.Text);
            if (a.StartsWith("ng"))
            {
                txtKQ1.Text = "Tìm thấy 'ng' ở đầu trong chuỗi 1";
            }
            else
            {
                txtKQ1.Text = "Không tìm thấy 'ng' ở đầu trong chuỗi 1";
            }
            if (a.StartsWith("Ng"))
            {
                txtKQ2.Text = "Tìm thấy 'Ng' ở đầu trong chuỗi 1";
            }
            else
            {
                txtKQ2.Text = "Không tìm thấy 'Ng' ở đầu trong chuỗi 1";
            }
            */


            //Kiểm tra cuối chuỗi có tồn tại chuỗi cần tìm không
            /*
            txtC1.Text = "Nguyễn Linh Trường Sang";
            string a = Convert.ToString(txtC1.Text);
            if (a.EndsWith("ng"))
            {
                txtKQ1.Text = "Tìm thấy 'ng' ở cuối trong chuỗi 1";
            }
            else
            {
                txtKQ1.Text = "Không tìm thấy 'ng' ở cuối trong chuỗi 1";
            }
            if (a.EndsWith("Ng"))
            {
                txtKQ2.Text = "Tìm thấy 'Ng' ở cuối trong chuỗi 1";
            }
            else
            {
                txtKQ2.Text = "Không tìm thấy 'Ng' ở cuối trong chuỗi 1";
            }
            */


            //Thay thế chuỗi
            /*
            txtC1.Text = "Nguyễn Linh Trường Sang";
            string a = Convert.ToString(txtC1.Text);
            string edit1 = a.Replace("Sang", "Quang");
            txtKQ1.Text = edit1;
            string edit2 = a.Replace("uyễn", "ân");
            txtKQ2.Text = edit2;
            */


            //Cắt chuỗi
            /*
            txtC1.Text = "Nguyễn Linh Trường Sang";
            string a = Convert.ToString(txtC1.Text);
            string edit1 = a.Substring(7, 4);
            txtKQ1.Text = "Lấy 4 ký tự giữa: " + edit1;
            string edit2 = a.Substring(a.Length - 4, 4);
            txtKQ2.Text = "Lấy 4 ký tự cuối: " + edit2;
            */


            //Chuyển từ mảng sang chuỗi
            /*
            string a = string.Join("-","Nguyễn" ,"Linh", "Trường", "Sang");
            string b = string.Join("@","Nguyễn" ,"Linh", "Trường", "Sang");
            txtKQ1.Text = a;
            txtKQ2.Text = b;
            */
            //trường hợp nhập
            /*string a = string.Join("-", txtC1.Text, txtC2.Text, txtC3.Text);
            txtKQ1.Text = a;*/


            //Chuyển hoa và thường
            /*
            txtC1.Text = "Nguyễn Linh Trường Sang";
            string a = Convert.ToString(txtC1.Text);
            string edit1 = a.ToUpper();
            string edit2 = a.ToLower();
            string edit3 = a.ToLower();
            txtKQ1.Text = edit1;
            txtKQ2.Text = edit2;
            */


            //Xóa khoảng trắng
            /*
            txtC1.Text = " " + " " + "Nguyễn Linh Trường Sang" + " " + " ";
            string a = Convert.ToString(txtC1.Text);
            txtC2.Text = "xóa đầu" + a.TrimStart() + "Hacker";
            txtC3.Text = "xóa cuối" + a.TrimEnd() + "Hacker";
            txtKQ1.Text = "xóa 2 bên" + a.Trim() + "Hacker";
            txtKQ2.Text = "nguyên" + a + "Hacker";
            */


            //Xóa chuỗi
            
            txtC1.Text = "Nguyễn Linh Trường Sang";
            string a = Convert.ToString(txtC1.Text);
            txtKQ1.Text = "Xóa từ vị trí 7: " + a.Remove(0,7);
            txtKQ2.Text = "Xóa từ vị trí 15: " + a.Remove(15);
            


            //Xóa Ký tự đầu và ký tự cuối chuỗi
            /*
            txtC1.Text = ".Nguyễn Linh Trường Sang,";
            string a = Convert.ToString(txtC1.Text);
            txtKQ1.Text = "Xóa ký tự đầu: " + a.TrimStart('N');
            txtKQ2.Text = "Xóa ký tự cuối: " + a.TrimEnd('g');
            */
            //trường hợp nhập
            /*
            string a = Convert.ToString(txtC1.Text);
            txtKQ1.Text = "Xóa đầu: " + a.TrimStart('Q');
            txtKQ2.Text = "Xóa cuối: " + a.TrimEnd('g');
            */



            //Tách chuỗi
            /*
            txtC1.Text = "Nguyễn Linh , Trường Sang";
            string a = Convert.ToString(txtC1.Text);
            string[] edit1 = a.Split(',');
            txtKQ1.Text = edit1[0];
            txtKQ2.Text = edit1[1];
            */
        }

        private void chuoi1_Load(object sender, EventArgs e)
        {

        }
    }
}
