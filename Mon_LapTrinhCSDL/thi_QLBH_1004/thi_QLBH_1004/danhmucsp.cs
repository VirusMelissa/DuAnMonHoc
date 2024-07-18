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

namespace thi_QLBH_1004
{
    public partial class danhmucsp : Form
    {
        string KN = "data source=MAY10" + "\\" + "MAY10; initial catalog = QLBH_1004_TEST; integrated security=true";
        SqlConnection conn = null;
        string bien = "0";
        SqlDataAdapter da = null;
        DataTable dt = null;
        string fileName;
        public danhmucsp()
        {
            InitializeComponent();
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

        private void combo_dvt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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

        private void danhmucsp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_1004_TESTDataSet2.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.qLBH_1004_TESTDataSet2.SANPHAM);

            DataGridViewCellStyle style = dataGridView1.ColumnHeadersDefaultCellStyle;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            combo_dvt.Text = "Cây";

            dataGridView1.Columns[4].DefaultCellStyle.Format = "VNĐ #,###";

            dataGridView1.Columns[0].HeaderText = "MÃ SP";
            dataGridView1.Columns[1].HeaderText = "TÊN SP";
            dataGridView1.Columns[2].HeaderText = "ĐƠN VỊ TÍNH";
            dataGridView1.Columns[3].HeaderText = "NƯỚC SX";
            dataGridView1.Columns[4].HeaderText = "GIÁ BÁN";
            dataGridView1.Columns[5].HeaderText = "ĐƯỜNG DẪN ẢNH";
            dataGridView1.Columns[6].HeaderText = "ẢNH";


            dataGridView1.Columns[2].Width = 130;
            dataGridView1.Columns[5].Width = 130;
            dataGridView1.Columns[4].Width = 130;
        }

        private void txtgiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            this.txtmasp.Text = dataGridView1.Rows[r].Cells[0].Value.ToString().Trim();
            this.txttensp.Text = dataGridView1.Rows[r].Cells[1].Value.ToString().Trim();
            this.combo_dvt.Text = dataGridView1.Rows[r].Cells[2].Value.ToString().Trim();
            this.txtnuocsx.Text = dataGridView1.Rows[r].Cells[3].Value.ToString().Trim();
            this.txtgiaban.Text = dataGridView1.Rows[r].Cells[4].Value.ToString().Trim();
            this.txtduongdan.Text = dataGridView1.Rows[r].Cells[5].Value.ToString().Trim();

            MemoryStream ms = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells[6].Value);
            pictureBox1.Image = Image.FromStream(ms);

            string diem = dataGridView1.Rows[0].Cells[4].Value.ToString();
            double tiente = Convert.ToDouble(diem);
            //định dạng kiểu 123,456đ
            string tong = tiente.ToString("VNĐ #,###");
            txtgiaban.Text = tong;
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            bien = "1";

            txtmasp.ResetText();
            txttensp.ResetText();
            combo_dvt.Text = "";
            txtnuocsx.ResetText();
            txtgiaban.ResetText();
            pictureBox1.ResetText();


            btthem.Enabled = false;
            btxoa.Enabled = false;
            btsua.Enabled = false;
            btthoat.Enabled = false;
            bttim.Enabled = false;
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            bien = "2";

            btthem.Enabled = false;
            btxoa.Enabled = false;
            btsua.Enabled = false;
            btthoat.Enabled = false;
            bttim.Enabled = false;
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            bien = "3";

            txtmasp.Enabled = false;

            btthem.Enabled = false;
            btxoa.Enabled = false;
            btsua.Enabled = false;
            btthoat.Enabled = false;
            bttim.Enabled = false;
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            bien = "0";

            txtmasp.ResetText();
            txttensp.ResetText();
            combo_dvt.Text = "";
            txtnuocsx.ResetText();
            txtgiaban.ResetText();
            pictureBox1.ResetText();

            txtmasp.Enabled = true;

            btthem.Enabled = true;
            btxoa.Enabled = true;
            btsua.Enabled = true;
            btthoat.Enabled = true;
            bttim.Enabled = true;
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn chuyển qua tìm kiếm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));

            if (thongbao == DialogResult.Yes)
            {
                timkiem fr = new timkiem();
                fr.Show();
                this.Visible = false;
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
                    cmd.CommandText = System.String.Concat("insert into SANPHAM(MASP,TENSP,DVT,NUOCSX,GIA,DUONGDANANH,ANH) SELECT '" +
                        txtmasp.Text + "','" +
                        txttensp.Text + "','" +
                        combo_dvt.Text.Trim() + "','" +
                        txtnuocsx.Text + "'," +
                        txtgiaban.Text + ",'" +
                        fileName + "', bulkcolumn from openrowset (bulk '" + fileName + "', single_blob) as picture");
                    cmd.ExecuteNonQuery();

                    //lấy tất cả dữ liệu bảng nhân viên đẩy ra đây
                    da = new SqlDataAdapter("select * from SANPHAM", conn);
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

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = System.String.Concat("delete from SANPHAM where masp = '" + ma + "'");
                    cmd.ExecuteNonQuery();

                    da = new SqlDataAdapter("select * from SANPHAM", conn);
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
                bttim.Enabled = true;
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
                    string ma = txtmasp.Text;

                    cmd.CommandText = System.String.Concat("update sanpham set tensp = '" +
                    this.txttensp.Text.ToString() + "', dvt = '" +
                    this.combo_dvt.Text.ToString() + "', nuocsx = '" +
                    this.txtnuocsx.Text.ToString() + "', gia = " +
                    this.txtgiaban.Text.ToString() +
                    ", duongdananh = '" + txtduongdan.Text.ToString().Trim() + "', anh = (select bulkcolumn" +
                    " from openrowset (bulk '" + d + "', single_blob) as picture)" +
                    " where masp = '" + this.txtmasp.Text.Trim() + "'");
                    cmd.ExecuteNonQuery();

                    //lấy tất cả dữ liệu bảng nhân viên đẩy ra đây
                    da = new SqlDataAdapter("select * from sanpham", conn);
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
                bttim.Enabled = true;

                txtmasp.Enabled = true;
            }
            bien = "0";

            //tự động đổi thành hoa và xóa các khoảng trắng
            string magv = txtmasp.Text.ToUpper().Trim();
            while (magv.IndexOf("  ") >= 0)
            {
                magv = magv.Replace("  ", " ");
            }
            txtmasp.Text = magv;
        }

        private void btthoat_Click(object sender, EventArgs e)
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

        private void txtduongdan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
