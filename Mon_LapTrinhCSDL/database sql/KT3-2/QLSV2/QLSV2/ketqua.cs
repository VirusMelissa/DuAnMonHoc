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

namespace QLSV2
{
    public partial class ketqua : Form
    {
        string KN = "data source=MAY10" + "\\" + "MAY10; initial catalog = QLHS2; integrated security=true";
        SqlConnection conn = null;
        string bien = "0";
        SqlDataAdapter da = null;
        DataTable dt = null;
        public ketqua()
        {
            InitializeComponent();
        }

        private void ketqua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHS2DataSet5.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLHS2DataSet5.LOP);
            // TODO: This line of code loads data into the 'qLHS2DataSet4.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.qLHS2DataSet4.SINHVIEN);
            // TODO: This line of code loads data into the 'qLHS2DataSet3.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLHS2DataSet3.MONHOC);
            // TODO: This line of code loads data into the 'qLHS2DataSet2.ABC' table. You can move, or remove it, as needed.
            this.aBCTableAdapter.Fill(this.qLHS2DataSet2.ABC);

            combo_masv.Text = "";
            combo_mamh.Text = "";
            combo_malop.Text = "";

            DataGridViewCellStyle style = dataGridView1.ColumnHeadersDefaultCellStyle;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView1.Columns[0].HeaderText = "Mã Sinh Viên";
            dataGridView1.Columns[1].HeaderText = "Họ Tên Sinh Viên";
            dataGridView1.Columns[2].HeaderText = "Mã Lớp";
            dataGridView1.Columns[3].HeaderText = "Mã Môn Học";
            dataGridView1.Columns[4].HeaderText = "Tên Môn Học";
            dataGridView1.Columns[5].HeaderText = "Số Tín Chỉ";
            dataGridView1.Columns[6].HeaderText = "Điểm";

            dataGridView1.Columns[0].Width = 130;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[3].Width = 110;
            dataGridView1.Columns[4].Width = 110;
            dataGridView1.Columns[5].Width = 110;

        }

        private void combo_malop_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void combo_mamh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void combo_masv_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            this.combo_masv.Text = dataGridView1.Rows[r].Cells[0].Value.ToString().Trim();
            this.txthoten.Text = dataGridView1.Rows[r].Cells[1].Value.ToString().Trim();
            this.combo_malop.Text = dataGridView1.Rows[r].Cells[2].Value.ToString().Trim();
            this.combo_mamh.Text = dataGridView1.Rows[r].Cells[3].Value.ToString().Trim();
            this.txttenmonhoc.Text = dataGridView1.Rows[r].Cells[4].Value.ToString().Trim();
            this.txtsotc.Text = dataGridView1.Rows[r].Cells[5].Value.ToString().Trim();
            this.txtdiem.Text = dataGridView1.Rows[r].Cells[6].Value.ToString().Trim();


            txthoten.Enabled = true;
            txttenmonhoc.Enabled = true;
        }

        private void txthoten_MouseClick(object sender, MouseEventArgs e)
        {
            if (combo_masv.Text.ToString() != "")
            {
                SqlConnection conn = new SqlConnection(KN);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                conn.Open();

                string s = "select hoten from sinhvien where masv = '" + combo_masv.Text + "'";
                SqlCommand com = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = s;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteScalar();
                txthoten.Text = cmd.ExecuteScalar().ToString();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên");
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
                MessageBox.Show("Bạn chưa nhập mã môn học");
            }
        }

        private void txtsotc_MouseClick(object sender, MouseEventArgs e)
        {
            if (combo_mamh.Text.ToString() != "")
            {
                SqlConnection conn = new SqlConnection(KN);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                conn.Open();

                string s = "select sotc from monhoc where mamh = '" + combo_mamh.Text + "'";
                SqlCommand com = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = s;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteScalar();
                txtsotc.Text = cmd.ExecuteScalar().ToString();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã môn học");
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            bien = "1";

            combo_masv.Text = "";
            txthoten.ResetText();
            combo_malop.Text = "";
            combo_mamh.Text = "";
            txttenmonhoc.ResetText();
            txtsotc.ResetText();
            txtdiem.ResetText();


            txthoten.Enabled = false;
            txttenmonhoc.Enabled = false;
            txtsotc.Enabled = false;


            btthem.Enabled = false;
            btxoa.Enabled = false;
            btsua.Enabled = false;
            btdong.Enabled = false;
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

            combo_masv.Enabled = false;
            combo_malop.Enabled = false;
            txthoten.Enabled = false;
            combo_mamh.Enabled = false;
            txttenmonhoc.Enabled = false;
            txtsotc.Enabled = false;

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
                fr.danhsach.Enabled = true;
                fr.ketqua.Enabled = true;
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
                    cmd.CommandText = "insert into ABC(MASV,MALOP,MAMH,DIEM) values('" + combo_masv.Text.Trim() + "','" + combo_malop.Text.Trim() + "','" + combo_mamh.Text.Trim() + "'," + txtdiem.Text + ")";
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

                txthoten.Enabled = true;
                txttenmonhoc.Enabled = true;
                txtsotc.Enabled = true;
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
                    string ma2 = dataGridView1.Rows[r].Cells[3].Value.ToString().Trim();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = System.String.Concat("delete from ABC where masv = '" + ma + "' AND malop = '" + ma1 + "' AND mamh = '" + ma2 + "'");
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
                    string ma = combo_masv.Text.ToString();
                    string ma1 = combo_malop.Text.ToString();
                    string ma2 = combo_mamh.Text.ToString();

                    cmd.CommandText = System.String.Concat("update ABC set DIEM = " +
                    this.txtdiem.Text.ToString() + "" +
                    " where MASV = '" + this.combo_masv.Text.ToString().Trim() + "' AND MALOP = '" + this.combo_malop.Text.ToString().Trim() + "' AND MAMH = '" + this.combo_mamh.Text.ToString().Trim() + "'");
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

                combo_masv.Enabled = true;
                combo_malop.Enabled = true;
                txthoten.Enabled = true;
                combo_mamh.Enabled = true;
                txttenmonhoc.Enabled = true;
                txtsotc.Enabled = true;
            }
            bien = "0";
        }

        private void txtdiem_Leave(object sender, EventArgs e)
        {
            if (txtdiem.Text != "")
            {
                int x = Convert.ToInt32(txtdiem.Text);
                if (x > 10 || x < 0)
                {
                    MessageBox.Show("Bạn nhập không đúng");
                    txtdiem.ResetText();
                }
            }
            else MessageBox.Show("Điểm không được rỗng");
        }

        private void txtdiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtdiem.MaxLength = 2;
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số");
            }
        }

        private void txtsotc_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtsotc.MaxLength = 1;
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số");
            }
        }
    }
}
