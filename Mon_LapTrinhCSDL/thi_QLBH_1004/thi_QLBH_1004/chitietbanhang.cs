using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace thi_QLBH_1004
{
    public partial class chitietbanhang : Form
    {
        string KN = "data source=MAY10" + "\\" + "MAY10; initial catalog = QLBH_1004_TEST; integrated security=true";
        SqlConnection conn = null;
        string bien = "0";
        SqlDataAdapter da = null;
        DataTable dt = null;
        public chitietbanhang()
        {
            InitializeComponent();
        }

        private void chitietbanhang_Load(object sender, EventArgs e)
        {
            DataGridViewCellStyle style = dataGridView1.ColumnHeadersDefaultCellStyle;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView1.Columns[3].DefaultCellStyle.Format = "#,### VNĐ";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "#,### VNĐ";

            dataGridView1.Columns[0].HeaderText = "SỐ HÓA ĐƠN";
            dataGridView1.Columns[1].HeaderText = "MÃ KH";
            dataGridView1.Columns[2].HeaderText = "MÃ SP";
            dataGridView1.Columns[3].HeaderText = "GIÁ BÁN";
            dataGridView1.Columns[4].HeaderText = "SỐ LƯỢNG";
            dataGridView1.Columns[5].HeaderText = "THÀNH TIỀN";

            dataGridView1.Columns[0].Width = 130;
            dataGridView1.Columns[3].Width = 130;
            dataGridView1.Columns[4].Width = 110;
            dataGridView1.Columns[5].Width = 130;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            this.txtsohd.Text = dataGridView1.Rows[r].Cells[0].Value.ToString().Trim();
            this.txtmakh.Text = dataGridView1.Rows[r].Cells[1].Value.ToString().Trim();
            this.txtmasp.Text = dataGridView1.Rows[r].Cells[2].Value.ToString().Trim();
            this.txtgia.Text = dataGridView1.Rows[r].Cells[3].Value.ToString().Trim();
            this.txtsoluong.Text = dataGridView1.Rows[r].Cells[4].Value.ToString().Trim();
            this.txtthanhtien.Text = dataGridView1.Rows[r].Cells[5].Value.ToString().Trim();

            string tien1 = dataGridView1.Rows[0].Cells[3].Value.ToString();
            string tien2 = dataGridView1.Rows[0].Cells[5].Value.ToString();
            double tiente1 = Convert.ToDouble(tien1);
            double tiente2 = Convert.ToDouble(tien2);
            //định dạng kiểu 123,456đ
            string tong1 = tiente1.ToString("# VNĐ");
            string tong2 = tiente2.ToString("# VNĐ");
            txtgia.Text = tong1;
            txtthanhtien.Text = tong2;

            txtgia.Enabled = true;
        }

        private void txtgia_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtmasp.Text != "")
            {
                SqlConnection conn = new SqlConnection(KN);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                conn.Open();

                string s = "select gia from sanpham where masp = '" + txtmasp.Text + "'";
                SqlCommand com = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = s;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteScalar();
                txtgia.Text = cmd.ExecuteScalar().ToString();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã sản phẩm");
            }
        }

        private void txtthanhtien_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtgia.Text != "" && txtsoluong.Text != "")
            {
                float x = float.Parse(txtgia.Text);
                int y = int.Parse(txtsoluong.Text);
                float z = x * y;
                txtthanhtien.Text = Convert.ToString(z);
            }
            else MessageBox.Show("Thiếu giá trị 'giá' hoặc 'số lượng'");
        }

        private void txtsohd_Leave(object sender, EventArgs e)
        {
            //tự động đổi thành hoa và xóa các khoảng trắng
            string magv = txtsohd.Text.ToUpper().Trim();
            while (magv.IndexOf("  ") >= 0)
            {
                magv = magv.Replace("  ", " ");
            }
            txtsohd.Text = magv;
        }

        private void txtmakh_Leave(object sender, EventArgs e)
        {
            //tự động đổi thành hoa và xóa các khoảng trắng
            string magv = txtmakh.Text.ToUpper().Trim();
            while (magv.IndexOf("  ") >= 0)
            {
                magv = magv.Replace("  ", " ");
            }
            txtmakh.Text = magv;
        }

        private void txtmasp_Leave(object sender, EventArgs e)
        {
            //tự động đổi thành hoa và xóa các khoảng trắng
            string magv = txtmasp.Text.ToUpper().Trim();
            while (magv.IndexOf("  ") >= 0)
            {
                magv = magv.Replace("  ", " ");
            }
            txtmasp.Text = magv;
        }

        private void txtgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số");
            }
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số");
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            bien = "1";

            txtsohd.ResetText();
            txtmakh.ResetText();
            txtmasp.ResetText();
            txtgia.ResetText();
            txtsoluong.ResetText();
            txtthanhtien.ResetText();


            txtgia.Enabled = false;

            btthem.Enabled = false;
            btxoa.Enabled = false;
            btsua.Enabled = false;
            btdong.Enabled = false;
        }

        private void txtthanhtien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            bien = "2";

            btthem.Enabled = false;
            btxoa.Enabled = false;
            btsua.Enabled = false;
            btdong.Enabled = false;
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            bien = "3";

            txtsohd.Enabled = false;
            txtmakh.Enabled = false;
            txtmasp.Enabled = false;
            txtgia.Enabled = false;

            btthem.Enabled = false;
            btxoa.Enabled = false;
            btsua.Enabled = false;
            btdong.Enabled = false;
        }

        private void btdong_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn đóng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));

            if (thongbao == DialogResult.Yes)
            {
                Menu fr = new Menu();
                fr.Show();
                fr.danhmuc.Visible = true;
                fr.chitietbanhang.Enabled = true;
                fr.inhoadon.Enabled = true;
                this.Hide();
            }
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            if (bien == "1")
            {
                //chuỗi đối tượng kết nối
                conn = new SqlConnection(KN);
                //mở kết nối ra
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    //"insert into nhanvien values là thêm nhân viên vào table
                    cmd.CommandText = "insert into ABC(SOHD,MAKH,MASP,SL) values('" + txtsohd.Text + "','" + txtmakh.Text + "','" + txtmasp.Text + "'," + txtsoluong.Text + ")";
                    cmd.ExecuteNonQuery();

                    //lấy tất cả dữ liệu bảng nhân viên đẩy ra đây
                    da = new SqlDataAdapter("select * from ABC", conn);
                    dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                    //trung gian để đưa dữ liệu qua gridview
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("Đã thêm thành công!");
                }
                //ngoại lệ
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được, lỗi rồi! kkk");
                }
                btthem.Enabled = true;
                btxoa.Enabled = true;
                btsua.Enabled = true;
                btdong.Enabled = true;

                txtgia.Enabled = true;
            }

            else if (bien == "2")
            {
                SqlConnection conn = new SqlConnection(KN);
                conn.Open();
                try
                {
                    int r = dataGridView1.CurrentCell.RowIndex;
                    string ma = dataGridView1.Rows[r].Cells[0].Value.ToString().Trim();
                    string ma1 = dataGridView1.Rows[r].Cells[1].Value.ToString().Trim();
                    string ma2 = dataGridView1.Rows[r].Cells[2].Value.ToString().Trim();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = System.String.Concat("delete from ABC where sohd = '" + ma + "' AND makh = '" + ma1 + "' AND masp = '" + ma2 + "'");
                    cmd.ExecuteNonQuery();

                    da = new SqlDataAdapter("select * from ABC", conn);
                    dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    MessageBox.Show("Xoá thành công!!!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Xoá không thành công!!!");
                }
                btthem.Enabled = true;
                btxoa.Enabled = true;
                btsua.Enabled = true;
                btdong.Enabled = true;
            }
            else if (bien == "3")
            {
                conn = new SqlConnection(KN);
                //mở kết nối ra
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    string ma = txtsohd.Text.ToString();
                    string ma1 = txtmakh.Text.ToString();
                    string ma2 = txtmasp.Text.ToString();

                    cmd.CommandText = System.String.Concat("update ABC set SL = " +
                    this.txtsoluong.Text + "" +
                    " where SOHD = '" + this.txtsohd.Text + "' AND MAKH = '" + this.txtmakh.Text + "' AND MASP = '" + this.txtmasp.Text + "'");
                    cmd.ExecuteNonQuery();

                    //lấy tất cả dữ liệu bảng nhân viên đẩy ra đây
                    da = new SqlDataAdapter("select * from ABC", conn);
                    dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                    //trung gian để đưa dữ liệu qua gridview
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("Đã sửa thành công!");
                }
                //ngoại lệ
                catch (SqlException)
                {
                    MessageBox.Show("Không sửa được, lỗi rồi! kkk");
                }
                btthem.Enabled = true;
                btxoa.Enabled = true;
                btsua.Enabled = true;
                btdong.Enabled = true;

                txtsohd.Enabled = true;
                txtmakh.Enabled = true;
                txtmasp.Enabled = true;
                txtgia.Enabled = true;
            }
            bien = "0";
        }
    }
}
