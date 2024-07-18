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

namespace QLHS
{
    public partial class danhsach : Form
    {
        string KN = "data source=MAY10" + "\\" + "MAY10; initial catalog = QLHS; integrated security=true";
        SqlDataAdapter da = null;
        DataTable dt = null;
        string fileName;
        string @chon;
        public danhsach()
        {
            InitializeComponent();
        }

        private void danhsach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHSDataSet.HOCSINH' table. You can move, or remove it, as needed.
            this.hOCSINHTableAdapter.Fill(this.qLHSDataSet.HOCSINH);

            txtduongdan.Enabled = false;

            DataGridViewCellStyle style = dataGridView1.ColumnHeadersDefaultCellStyle;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView1.Columns[0].HeaderText = "Mã Học Sinh";
            dataGridView1.Columns[1].HeaderText = "Lớp";
            dataGridView1.Columns[2].HeaderText = "Họ và Tên";
            dataGridView1.Columns[3].HeaderText = "Ngày Sinh";
            dataGridView1.Columns[4].HeaderText = "Địa Chỉ";
            dataGridView1.Columns[5].HeaderText = "Đường Dẫn Ảnh";
            dataGridView1.Columns[6].HeaderText = "Ảnh";
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(KN);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = System.String.Concat("insert into HOCSINH (MAHS,LOP, HOTEN,NGAYSINH,DIACHI,DUONGDANANH,ANH) select '" +
                    this.txtmahs.Text.ToString() + "','" +
                    this.combo_lop.Text.ToString() + "','" +
                    this.txthoten.Text.ToString() + "','" +
                    this.txtngaysinh.Text.ToString() + "','" +
                    this.txtdiachi.Text.ToString() + "','" +
                    fileName + "', bulkcolumn from openrowset (bulk '" + fileName + "', single_blob) as picture");


                MessageBox.Show(cmd.CommandText);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                da = new SqlDataAdapter("select * from hocsinh", conn);
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

                cmd.CommandText = System.String.Concat("delete from hocsinh where mahs = '" + ma + "'");
                cmd.ExecuteNonQuery();

                da = new SqlDataAdapter("select * from hocsinh", conn);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            this.txtmahs.Text = dataGridView1.Rows[r].Cells[0].Value.ToString().Trim();
            this.combo_lop.Text = dataGridView1.Rows[r].Cells[1].Value.ToString().Trim();
            this.txthoten.Text = dataGridView1.Rows[r].Cells[2].Value.ToString().Trim();
            this.txtngaysinh.Text = dataGridView1.Rows[r].Cells[3].Value.ToString().Trim();
            this.txtdiachi.Text = dataGridView1.Rows[r].Cells[4].Value.ToString().Trim();
            this.txtduongdan.Text = dataGridView1.Rows[r].Cells[5].Value.ToString().Trim();

            MemoryStream ms = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells[6].Value);
            picture.Image = Image.FromStream(ms);
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(KN);
            conn.Open();
            try
            {
                //giữ tên đường dẫn
                string d = txtduongdan.Text;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;


                cmd.CommandText = System.String.Concat("update hocsinh set lop = '" +
                    this.combo_lop.Text.ToString() + "', hoten = '" +
                    this.txthoten.Text.ToString() + "', ngaysinh = '" +
                    this.txtngaysinh.Text.ToString() + "', diachi = '" +
                    this.txtdiachi.Text.ToString() +
                    "', duongdananh = '" + txtduongdan.Text.ToString().Trim() + "', anh = (select bulkcolumn" +
                    " from openrowset (bulk '" + d + "', single_blob) as picture)" +
                    " where mahs = '" + this.txtmahs.Text.Trim() + "'");

                MessageBox.Show(cmd.CommandText);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                da = new SqlDataAdapter("select * from hocsinh", conn);
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

        private void combo_chonlop_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void combo_chonlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(KN);
            SqlCommand cmd = new SqlCommand("select * from HOCSINH where LOP = @chon", conn);
            conn.Open();

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@chon";
            p1.Value = combo_chonlop.Text.ToString().Trim();
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

        private void combo_lop_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
