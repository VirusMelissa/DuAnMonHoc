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

namespace QLNV
{
    public partial class danhsach : Form
    {
        string KN = "data source=ADMIN" + "\\" + "SQLEXPRESS; initial catalog = QLNV; integrated security=true";
        SqlDataAdapter da = null;
        DataTable dt = null;
        SqlDataAdapter da_diem = null;
        DataTable dt_diem = null;
        string fileName;
        string @chon;
        public danhsach()
        {
            InitializeComponent();
        }

        private void danhsach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNVDataSet2.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter2.Fill(this.qLNVDataSet2.NHANVIEN);
            // TODO: This line of code loads data into the 'qLNVDataSet1.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter1.Fill(this.qLNVDataSet1.NHANVIEN);
            // TODO: This line of code loads data into the 'qLNVDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qLNVDataSet.NHANVIEN);
            DataGridViewCellStyle style = dataGridView1.ColumnHeadersDefaultCellStyle;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView1.Columns[4].DefaultCellStyle.Format = "#,### VNĐ";
            dataGridView1.Columns[0].HeaderText = "Mã Nhân Viên";
            dataGridView1.Columns[1].HeaderText = "Mã Phòng";
            dataGridView1.Columns[2].HeaderText = "Họ và Tên";
            dataGridView1.Columns[3].HeaderText = "Ngày Sinh";
            dataGridView1.Columns[4].HeaderText = "Lương";

            dataGridView1.Columns[0].Width = 110;
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(KN);
            conn.Open();

            string hoten = txthoten.Text.ToUpper().Trim();
            while (hoten.IndexOf("  ") >= 0)
            {
                hoten = hoten.Replace("  ", " ");
            }
            txthoten.Text = hoten;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = System.String.Concat("insert into NHANVIEN (MANV,MAPHG,HOTEN,NGAYSINH,LUONG,IMPATH,ANH) select '" +
                    this.txtmanv.Text.ToString() + "','" +
                    this.combo_phong.Text.ToString() + "','" +
                    this.txthoten.Text.ToString() + "','" +
                    this.txtngaysinh.Text.ToString() + "','" +
                    this.txtluong.Text.ToString() + "','" +
                    fileName + "', bulkcolumn from openrowset (bulk '" + fileName + "', single_blob) as picture");


                MessageBox.Show(cmd.CommandText);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                da = new SqlDataAdapter("select * from nhanvien", conn);
                dt = new DataTable();
                dt.Clear();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                MessageBox.Show("Đã thêm thành công!!!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Thêm mém thành công!!!");
            }
        }

        private void bttimanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fileName = dlg.FileName;

                picture.Image = Image.FromFile(fileName);
                txtduongdan.Text = fileName.ToString();
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(KN);
            conn.Open();
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                string ma = dataGridView1.Rows[r].Cells[0].Value.ToString().Trim();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = System.String.Concat("delete from nhanvien where manv = '" + ma + "'");
                cmd.ExecuteNonQuery();

                da = new SqlDataAdapter("select * from nhanvien", conn);
                dt = new DataTable();
                dt.Clear();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                MessageBox.Show("Xoá thành công!!!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Xoá mém thành công!!!");
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(KN);
            conn.Open();

            string hoten = txthoten.Text.ToUpper().Trim();
            while (hoten.IndexOf("  ") >= 0)
            {
                hoten = hoten.Replace("  ", " ");
            }
            txthoten.Text = hoten;

            try
            {
                //giữ tên đường dẫn
                string d = txtduongdan.Text;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;


                cmd.CommandText = System.String.Concat("update nhanvien set maphg = '" +
                    this.combo_phong.Text.ToString() + "', hoten = '" +
                    this.txthoten.Text.ToString() + "', ngaysinh = '" +
                    this.txtngaysinh.Text.ToString() + "', luong = '" +
                    this.txtluong.Text.ToString() +
                    "', impath = '" + txtduongdan.Text.ToString().Trim() + "', anh = (select bulkcolumn" +
                    " from openrowset (bulk '" + d + "', single_blob) as picture)" +
                    " where manv = '" + this.txtmanv.Text.Trim() + "'");

                MessageBox.Show(cmd.CommandText);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                da = new SqlDataAdapter("select * from nhanvien", conn);
                dt = new DataTable();
                dt.Clear();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                MessageBox.Show("Sửa thành công!!!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Sửa mém thành công!!!");
            }
        }

        private void combo_chonphong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void combo_phong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            this.txtmanv.Text = dataGridView1.Rows[r].Cells[0].Value.ToString().Trim();
            this.combo_phong.Text = dataGridView1.Rows[r].Cells[1].Value.ToString().Trim();
            this.txthoten.Text = dataGridView1.Rows[r].Cells[2].Value.ToString().Trim();
            this.txtngaysinh.Text = dataGridView1.Rows[r].Cells[3].Value.ToString().Trim();
            this.txtluong.Text = dataGridView1.Rows[r].Cells[4].Value.ToString().Trim();
            this.txtduongdan.Text = dataGridView1.Rows[r].Cells[5].Value.ToString().Trim();

            MemoryStream ms = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells[6].Value);
            picture.Image = Image.FromStream(ms);
        }

        private void combo_chonphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(KN);
            SqlCommand cmd = new SqlCommand("select * from nhanvien where maphg = @chon", conn);
            conn.Open();

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@chon";
            p1.Value = combo_chonphong.Text.ToString().Trim();
            cmd.Parameters.Add(p1);

            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            da_diem = new SqlDataAdapter("select MAPHG, SUM(LUONG) AS TONGLUONG from NHANVIEN WHERE MAPHG= '" + combo_chonphong.Text + "' GROUP BY MAPHG", conn);
            dt_diem = new DataTable();
            dt_diem.Clear();
            da_diem.Fill(dt_diem);

            //Đưa dữ liệu lên DataGridView
            dataGridView2.DataSource = dt_diem;

            string diem = dataGridView2.Rows[0].Cells[1].Value.ToString();
            double tiente = Convert.ToDouble(diem);
            //định dạng kiểu 123,456đ
            string tong = tiente.ToString("0#,### VNĐ");
            //gán dữ liệu string của tong qua text Học Phí
            txttongluong.Text = tong;
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
    }
}
