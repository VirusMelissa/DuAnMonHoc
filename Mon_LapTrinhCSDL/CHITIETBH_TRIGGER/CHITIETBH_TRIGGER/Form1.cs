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

namespace CHITIETBH_TRIGGER
{
    public partial class Form1 : Form
    {
        string KN = "data source=MAY10" + "\\" + "MAY10; initial catalog = QLBH_1004_test; integrated security=true";
        SqlConnection conn = null;
        string bien = "0";
        SqlDataAdapter da = null;
        DataTable dt = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_1004_TESTDataSet2.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.qLBH_1004_TESTDataSet2.HOADON);
            // TODO: This line of code loads data into the 'qLBH_1004_TESTDataSet1.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.qLBH_1004_TESTDataSet1.SANPHAM);
            // TODO: This line of code loads data into the 'qLBH_1004_TESTDataSet.ABC' table. You can move, or remove it, as needed.
            this.aBCTableAdapter.Fill(this.qLBH_1004_TESTDataSet.ABC);

            combo_masp.Text = "";

            DataGridViewCellStyle style = dataGridView1.ColumnHeadersDefaultCellStyle;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView1.Columns[3].DefaultCellStyle.Format = "#,### VNĐ";
            dataGridView1.Columns[4].DefaultCellStyle.Format = "#,### VNĐ";

            dataGridView1.Columns[0].HeaderText = "Số Hóa Đơn";
            dataGridView1.Columns[1].HeaderText = "Mã Sản Phẩm";
            dataGridView1.Columns[2].HeaderText = "Số Lượng";
            dataGridView1.Columns[3].HeaderText = "Đơn Giá";
            dataGridView1.Columns[4].HeaderText = "Thành Tiền";

            dataGridView1.Columns[0].Width = 110;
            dataGridView1.Columns[1].Width = 110;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtdongia.ResetText();
            txtthanhtien.ResetText();

            int r = dataGridView1.CurrentCell.RowIndex;
            this.txtsohd.Text = dataGridView1.Rows[r].Cells[0].Value.ToString().Trim();
            this.combo_masp.Text = dataGridView1.Rows[r].Cells[1].Value.ToString().Trim();
            this.txtsl.Text = dataGridView1.Rows[r].Cells[2].Value.ToString().Trim();
        }

        private void txtdongia_MouseClick(object sender, MouseEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            this.txtdongia.Text = dataGridView1.Rows[r].Cells[3].Value.ToString().Trim();

            /*
            double tiente = Convert.ToDouble(txtdongia.Text);
            //định dạng kiểu 123,456đ
            string tong = tiente.ToString("#,### VNĐ");
            //gán dữ liệu string của tong qua text Học Phí
            txtdongia.Text = tong;
            */

            /*
            SqlConnection conn = new SqlConnection(KN);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;            
            cmd.CommandType = CommandType.Text;
            conn.Open();

            string s = "select gia from sanpham where masp = '" + combo_masp.Text + "'";
            SqlCommand com = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = s;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteScalar();
            txtdongia.Text = cmd.ExecuteScalar().ToString();*/
        }

        private void txtthanhtien_MouseClick(object sender, MouseEventArgs e)
        {
            /*
            int r = dataGridView1.CurrentCell.RowIndex;
            this.txtthanhtien.Text = dataGridView1.Rows[r].Cells[4].Value.ToString().Trim();
            */

            int sl = int.Parse(txtsl.Text.ToString());
            float t = float.Parse(txtdongia.Text.ToString());
            float tt = sl * t;
            txtthanhtien.Text = tt.ToString();


            double tiente = Convert.ToDouble(txtthanhtien.Text);
            //định dạng kiểu 123,456đ
            string tong = tiente.ToString("#,### VNĐ");
            //gán dữ liệu string của tong qua text Học Phí
            txtthanhtien.Text = tong;
        }

        private void txtdongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtthanhtien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; 
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            bien = "1";

            txtsohd.ResetText();
            combo_masp.Text = "";
            txtsl.ResetText();
            txtdongia.ResetText();
            txtthanhtien.ResetText();


            btthem.Enabled = false;
            btxoa.Enabled = false;
            btsua.Enabled = false;
            btdong.Enabled = false;
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
                    cmd.CommandText = "insert into ABC(SOHD,MASP,SL) values ('" + txtsohd.Text + "','" +
                        combo_masp.Text + "'," +
                        txtsl.Text + ")";

                    //cmd.CommandText kiểm tra chạy đúng hay không
                    MessageBox.Show(cmd.CommandText);
                    cmd.CommandType = CommandType.Text;
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

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = System.String.Concat("delete from ABC where sohd = '" + ma + "' AND masp = '" + ma1 + "'");
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
                    string ma = txtsohd.Text;
                    string ma1 = combo_masp.Text.ToString();

                    cmd.CommandText = System.String.Concat("update ABC set SL = " +
                    this.txtsl.Text.ToString() + "" +
                    " where SOHD = '" + this.txtsohd.Text.Trim() + "' AND MASP = '" + this.combo_masp.Text.ToString().Trim() + "'");

                    MessageBox.Show(cmd.CommandText);
                    cmd.CommandType = CommandType.Text;
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
                combo_masp.Enabled = true;
            }
            bien = "0";
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
            combo_masp.Enabled = false;

            btthem.Enabled = false;
            btxoa.Enabled = false;
            btsua.Enabled = false;
            btdong.Enabled = false;
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(KN);
            SqlCommand cmd = new SqlCommand("select * from ABC where sohd = @chon", conn);
            conn.Open();

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@chon";
            p1.Value = combo_chonsohd.Text.ToString().Trim();
            cmd.Parameters.Add(p1);

            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void btdong_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn đóng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));

            if (thongbao == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void combo_masp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void combo_chonsohd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
