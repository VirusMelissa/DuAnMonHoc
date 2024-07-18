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
using System.IO;

namespace QLSV2
{
    public partial class danhsach : Form
    {
        string KN = "data source=MAY10" + "\\" + "MAY10; initial catalog = QLHS2; integrated security=true";
        SqlConnection conn = null;
        string bien = "0";
        SqlDataAdapter da = null;
        DataTable dt = null;
        string fileName;
        public danhsach()
        {
            InitializeComponent();
        }

        private void bttimanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fileName = dlg.FileName;

                pictureBox1.Image = Image.FromFile(fileName);
                txtduongdan.Text = fileName.ToString();
            }
        }

        private void danhsach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHS2DataSet1.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLHS2DataSet1.LOP);
            // TODO: This line of code loads data into the 'qLHS2DataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.qLHS2DataSet.SINHVIEN);

            combo_malop.Text = "";

            DataGridViewCellStyle style = dataGridView1.ColumnHeadersDefaultCellStyle;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView1.Columns[4].DefaultCellStyle.Format = "#,### VNĐ";

            dataGridView1.Columns[0].HeaderText = "Mã Sinh Viên";
            dataGridView1.Columns[1].HeaderText = "Mã Lớp";
            dataGridView1.Columns[2].HeaderText = "Họ Tên Sinh Viên";
            dataGridView1.Columns[3].HeaderText = "Ngày Sinh";
            dataGridView1.Columns[4].HeaderText = "Học Bổng";


            dataGridView1.Columns[0].Width = 130;
            dataGridView1.Columns[2].Width = 180;
        }

        private void combo_malop_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            this.txtmasv.Text = dataGridView1.Rows[r].Cells[0].Value.ToString().Trim();
            this.combo_malop.Text = dataGridView1.Rows[r].Cells[1].Value.ToString().Trim();
            this.txtten.Text = dataGridView1.Rows[r].Cells[2].Value.ToString().Trim();
            this.txtngaysinh.Text = dataGridView1.Rows[r].Cells[3].Value.ToString().Trim();
            this.txthocbong.Text = dataGridView1.Rows[r].Cells[4].Value.ToString().Trim();
            this.txtduongdan.Text = dataGridView1.Rows[r].Cells[5].Value.ToString().Trim();

            MemoryStream ms = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells[6].Value);
            pictureBox1.Image = Image.FromStream(ms);
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            bien = "1";

            txtmasv.ResetText();
            txtten.ResetText();
            combo_malop.Text = "";
            txtngaysinh.ResetText();
            txthocbong.ResetText();
            pictureBox1.ResetText();


            btthem.Enabled = false;
            btxoa.Enabled = false;
            btsua.Enabled = false;
            btthoat.Enabled = false;
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            bien = "2";

            btthem.Enabled = false;
            btxoa.Enabled = false;
            btsua.Enabled = false;
            btthoat.Enabled = false;
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            bien = "3";

            txtmasv.Enabled = false;

            btthem.Enabled = false;
            btxoa.Enabled = false;
            btsua.Enabled = false;
            btthoat.Enabled = false;
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));

            if (thongbao == DialogResult.Yes)
            {
                Menu fr = new Menu();
                fr.Show();
                fr.danhsach.Enabled = true;
                fr.ketqua.Enabled = true;
                this.Hide();
            }
        }

        private void txtmasv_Leave(object sender, EventArgs e)
        {
            //tự động đổi thành hoa và xóa các khoảng trắng
            string magv = txtmasv.Text.ToUpper().Trim();
            while (magv.IndexOf("  ") >= 0)
            {
                magv = magv.Replace("  ", " ");
            }
            txtmasv.Text = magv;
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
                    cmd.CommandText = System.String.Concat("insert into SINHVIEN(MASV,MALOP,HOTEN,NGAYSINH,HOCBONG,DUONGDANANH,ANH) SELECT '" +
                        txtmasv.Text + "','" +
                        combo_malop.Text.Trim() + "','" +
                        txtten.Text + "','" +
                        txtngaysinh.Text + "'," +
                        txthocbong.Text + ",'" +
                        fileName + "', bulkcolumn from openrowset (bulk '" + fileName + "', single_blob) as picture");
                    cmd.ExecuteNonQuery();

                    //lấy tất cả dữ liệu bảng nhân viên đẩy ra đây
                    da = new SqlDataAdapter("select * from SINHVIEN", conn);
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
                btthoat.Enabled = true;
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

                    cmd.CommandText = System.String.Concat("delete from SINHVIEN where masv = '" + ma + "' AND malop = '" + ma1 + "'");
                    cmd.ExecuteNonQuery();

                    da = new SqlDataAdapter("select * from SINHVIEN", conn);
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
                btthoat.Enabled = true;
            }
            else if (bien == "3")
            {
                string d = txtduongdan.Text;
                conn = new SqlConnection(KN);
                //mở kết nối ra
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    string ma = txtmasv.Text;
                    string ma1 = combo_malop.Text.ToString();

                    cmd.CommandText = System.String.Concat("update sinhvien set malop = '" +
                    this.combo_malop.Text.ToString() + "', hoten = '" +
                    this.txtten.Text.ToString() + "', ngaysinh = '" +
                    this.txtngaysinh.Text.ToString() + "', hocbong = " +
                    this.txthocbong.Text.ToString() +
                    ", duongdananh = '" + txtduongdan.Text.ToString().Trim() + "', anh = (select bulkcolumn" +
                    " from openrowset (bulk '" + d + "', single_blob) as picture)" +
                    " where masv = '" + this.txtmasv.Text.Trim() + "'");
                    cmd.ExecuteNonQuery();

                    //lấy tất cả dữ liệu bảng nhân viên đẩy ra đây
                    da = new SqlDataAdapter("select * from sinhvien", conn);
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
                btthoat.Enabled = true;

                txtmasv.Enabled = true;
            }
            bien = "0";

            //tự động đổi thành hoa và xóa các khoảng trắng
            string magv = txtmasv.Text.ToUpper().Trim();
            while (magv.IndexOf("  ") >= 0)
            {
                magv = magv.Replace("  ", " ");
            }
            txtmasv.Text = magv;
        }

        private void danhsach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số");
            }
        }
    }
}
