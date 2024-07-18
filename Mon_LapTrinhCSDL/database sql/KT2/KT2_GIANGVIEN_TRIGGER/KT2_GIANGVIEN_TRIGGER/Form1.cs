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

namespace KT2_GIANGVIEN_TRIGGER
{
    public partial class quanlygiangvien : Form
    {
        string KN = "data source=MAY10" + "\\" + "MAY10; initial catalog = QL_GIANGVIEN; integrated security=true";
        SqlConnection conn = null;
        string bien = "0";
        SqlDataAdapter da = null;
        DataTable dt = null;
        public quanlygiangvien()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_GIANGVIENDataSet3.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qL_GIANGVIENDataSet3.LOP);
            // TODO: This line of code loads data into the 'qL_GIANGVIENDataSet2.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qL_GIANGVIENDataSet2.MONHOC);
            // TODO: This line of code loads data into the 'qL_GIANGVIENDataSet1.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Fill(this.qL_GIANGVIENDataSet1.GIANGVIEN);
            // TODO: This line of code loads data into the 'qL_GIANGVIENDataSet.ABC' table. You can move, or remove it, as needed.
            this.aBCTableAdapter.Fill(this.qL_GIANGVIENDataSet.ABC);


            combo_mamh.Text = "";
            combo_malop.Text = "";

            DataGridViewCellStyle style = dataGridView1.ColumnHeadersDefaultCellStyle;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView1.Columns[6].DefaultCellStyle.Format = "#### Giờ";

            dataGridView1.Columns[0].HeaderText = "Mã Giảng Viên";
            dataGridView1.Columns[1].HeaderText = "Họ Tên Giảng Viên";
            dataGridView1.Columns[2].HeaderText = "Mã Môn Học";
            dataGridView1.Columns[3].HeaderText = "Tên Môn Học";
            dataGridView1.Columns[4].HeaderText = "Mã Lớp";
            dataGridView1.Columns[5].HeaderText = "Tên Lớp";
            dataGridView1.Columns[6].HeaderText = "Số Giờ Dạy";

            dataGridView1.Columns[0].Width = 130;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Width = 110;
            dataGridView1.Columns[3].Width = 110;
            dataGridView1.Columns[6].Width = 110;
        }

        private void combo_mamh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void combo_malop_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txthoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txttenmonhoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txttenlop_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void combo_chonsohd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            this.txtmagv.Text = dataGridView1.Rows[r].Cells[0].Value.ToString().Trim();
            this.txthoten.Text = dataGridView1.Rows[r].Cells[1].Value.ToString().Trim();
            this.combo_mamh.Text = dataGridView1.Rows[r].Cells[2].Value.ToString().Trim();
            this.txttenmonhoc.Text = dataGridView1.Rows[r].Cells[3].Value.ToString().Trim();
            this.combo_malop.Text = dataGridView1.Rows[r].Cells[4].Value.ToString().Trim();
            this.txttenlop.Text = dataGridView1.Rows[r].Cells[5].Value.ToString().Trim();
            this.txtsogioday.Text = dataGridView1.Rows[r].Cells[6].Value.ToString().Trim();


            txttenmonhoc.Enabled = true;
            txttenlop.Enabled = true;
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(KN);
            SqlCommand cmd = new SqlCommand("select * from ABC where magv = @chon", conn);
            conn.Open();

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@chon";
            p1.Value = combo_chonmagv.Text.ToString().Trim();
            cmd.Parameters.Add(p1);

            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void txthoten_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtmagv.Text != "")
            {
                SqlConnection conn = new SqlConnection(KN);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                conn.Open();

                string s = "select hoten from giangvien where magv = '" + txtmagv.Text + "'";
                SqlCommand com = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = s;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteScalar();
                txthoten.Text = cmd.ExecuteScalar().ToString();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã giảng viên");
            }
        }

        private void txttenmonhoc_MouseClick(object sender, MouseEventArgs e)
        {
            if (combo_mamh.Text.ToString() != "")
            {
                SqlConnection conn = new SqlConnection(KN);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                conn.Open();

                string s = "select tenmh from monhoc where mamh = '" + combo_mamh.Text + "'";
                SqlCommand com = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = s;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteScalar();
                txttenmonhoc.Text = cmd.ExecuteScalar().ToString();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn mã môn học");
            }
        }

        private void txttenlop_MouseClick(object sender, MouseEventArgs e)
        {
            if (combo_malop.Text.ToString() != "")
            {
                SqlConnection conn = new SqlConnection(KN);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                conn.Open();

                string s = "select tenlop from lop where malop = '" + combo_malop.Text + "'";
                SqlCommand com = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = s;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteScalar();
                txttenlop.Text = cmd.ExecuteScalar().ToString();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn mã lớp");
            }
        }

        private void txtmagv_Leave(object sender, EventArgs e)
        {
            //tự động đổi thành hoa và xóa các khoảng trắng
            string magv = txtmagv.Text.ToUpper().Trim();
            while (magv.IndexOf("  ") >= 0)
            {
                magv = magv.Replace("  ", " ");
            }
            txtmagv.Text = magv;
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            bien = "1";

            txtmagv.ResetText();
            txthoten.ResetText();
            combo_mamh.Text = "";
            txttenmonhoc.ResetText();
            combo_malop.Text = "";
            txttenlop.ResetText();
            txtsogioday.ResetText();


            btthem.Enabled = false;
            btxoa.Enabled = false;
            btsua.Enabled = false;
            btdong.Enabled = false;
            bttim.Enabled = false;
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            bien = "2";

            btthem.Enabled = false;
            btxoa.Enabled = false;
            btsua.Enabled = false;
            btdong.Enabled = false;
            bttim.Enabled = false;
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            bien = "3";

            txtmagv.Enabled = false;
            combo_mamh.Enabled = false;
            combo_malop.Enabled = false;

            btthem.Enabled = false;
            btxoa.Enabled = false;
            btsua.Enabled = false;
            btdong.Enabled = false;
            bttim.Enabled = false;
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
                    cmd.CommandText = "insert into ABC(MAGV,MAMH,MALOP,SOGIODAY) values ('" + txtmagv.Text + "','" + combo_mamh.Text.Trim() + "','" + combo_malop.Text.Trim() + "'," + txtsogioday.Text + ")";
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
                bttim.Enabled = true;
            }

            else if (bien == "2")
            {
                SqlConnection conn = new SqlConnection(KN);
                conn.Open();
                try
                {
                    int r = dataGridView1.CurrentCell.RowIndex;
                    string ma = dataGridView1.Rows[r].Cells[0].Value.ToString().Trim();
                    string ma1 = dataGridView1.Rows[r].Cells[2].Value.ToString().Trim();
                    string ma2 = dataGridView1.Rows[r].Cells[4].Value.ToString().Trim();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = System.String.Concat("delete from ABC where magv = '" + ma + "' AND mamh = '" + ma1 + "' AND malop = '" + ma2 + "'");
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
                bttim.Enabled = true;
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
                    string ma = txtmagv.Text;
                    string ma1 = combo_mamh.Text.ToString();
                    string ma2 = combo_malop.Text.ToString();

                    cmd.CommandText = System.String.Concat("update ABC set SOGIODAY = " +
                    this.txtsogioday.Text.ToString() + "" +
                    " where MAGV = '" + this.txtmagv.Text.Trim() + "' AND MAMH = '" + this.combo_mamh.Text.ToString().Trim() + "' AND MALOP = '" + this.combo_malop.Text.ToString().Trim() + "'");
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
                bttim.Enabled = true;

                txtmagv.Enabled = true;
                combo_mamh.Enabled = true;
                combo_malop.Enabled = true;
            }
            bien = "0";

            //tự động đổi thành hoa và xóa các khoảng trắng
            string magv = txtmagv.Text.ToUpper().Trim();
            while (magv.IndexOf("  ") >= 0)
            {
                magv = magv.Replace("  ", " ");
            }
            txtmagv.Text = magv;
        }
    }
}
