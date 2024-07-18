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

namespace QL_GIANGVIEN2
{
    public partial class danhsachgiangvien : Form
    {
        string KN = "data source=MAY10" + "\\" + "MAY10; initial catalog = QL_GIANGVIEN2; integrated security=true";
        SqlConnection conn = null;
        string bien = "0";
        SqlDataAdapter da = null;
        DataTable dt = null;
        string fileName;
        public danhsachgiangvien()
        {
            InitializeComponent();
        }

        private void danhsachgiangvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_GIANGVIEN2DataSet1.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.qL_GIANGVIEN2DataSet1.KHOA);
            // TODO: This line of code loads data into the 'qL_GIANGVIEN2DataSet.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Fill(this.qL_GIANGVIEN2DataSet.GIANGVIEN);

            combo_makhoa.Text = "";

            DataGridViewCellStyle style = dataGridView1.ColumnHeadersDefaultCellStyle;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView1.Columns[4].DefaultCellStyle.Format = "#,### VNĐ";

            dataGridView1.Columns[0].HeaderText = "Mã Giảng Viên";
            dataGridView1.Columns[1].HeaderText = "Mã Khoa";
            dataGridView1.Columns[2].HeaderText = "Họ Tên Giảng Viên";
            dataGridView1.Columns[3].HeaderText = "Ngày Sinh";
            dataGridView1.Columns[4].HeaderText = "Lương Cơ Bản";
            dataGridView1.Columns[5].HeaderText = "Hệ Số";


            dataGridView1.Columns[0].Width = 130;
            dataGridView1.Columns[2].Width = 180;
            dataGridView1.Columns[2].Width = 110;
            dataGridView1.Columns[4].Width = 120;

        }

        private void combo_makhoa_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            this.txtmagv.Text = dataGridView1.Rows[r].Cells[0].Value.ToString().Trim();
            this.combo_makhoa.Text = dataGridView1.Rows[r].Cells[1].Value.ToString().Trim();
            this.txten.Text = dataGridView1.Rows[r].Cells[2].Value.ToString().Trim();
            this.txtngaysinh.Text = dataGridView1.Rows[r].Cells[3].Value.ToString().Trim();
            this.txtLCB.Text = dataGridView1.Rows[r].Cells[4].Value.ToString().Trim();
            this.txtheso.Text = dataGridView1.Rows[r].Cells[5].Value.ToString().Trim();
            this.txtduongdan.Text = dataGridView1.Rows[r].Cells[6].Value.ToString().Trim();

            MemoryStream ms = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells[7].Value);
            pictureBox1.Image = Image.FromStream(ms);
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
                    cmd.CommandText = System.String.Concat("insert into GIANGVIEN(MAGV,MAKHOA,HOTEN,NGAYSINH,LUONGCB,HESO,DUONGDANANH,ANH) SELECT '" + 
                        txtmagv.Text + "','" + 
                        combo_makhoa.Text.Trim() + "','" + 
                        txten.Text + "','" +
                        txtngaysinh.Text + "'," +
                        txtLCB.Text + "," +
                        txtheso.Text + ",'" +
                        fileName + "', bulkcolumn from openrowset (bulk '" + fileName + "', single_blob) as picture");
                    cmd.ExecuteNonQuery();

                    //lấy tất cả dữ liệu bảng nhân viên đẩy ra đây
                    da = new SqlDataAdapter("select * from GIANGVIEN", conn);
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

                    cmd.CommandText = System.String.Concat("delete from GIANGVIEN where magv = '" + ma + "' AND makhoa = '" + ma1 + "'");
                    cmd.ExecuteNonQuery();

                    da = new SqlDataAdapter("select * from GIANGVIEN", conn);
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
                    string ma = txtmagv.Text;
                    string ma1 = combo_makhoa.Text.ToString();

                    cmd.CommandText = System.String.Concat("update giangvien set makhoa = '" +
                    this.combo_makhoa.Text.ToString() + "', hoten = '" +
                    this.txten.Text.ToString() + "', ngaysinh = '" +
                    this.txtngaysinh.Text.ToString() + "', luongCB = " +
                    this.txtLCB.Text.ToString() + ", heso = " +
                    this.txtheso.Text.ToString() +
                    ", duongdananh = '" + txtduongdan.Text.ToString().Trim() + "', anh = (select bulkcolumn" +
                    " from openrowset (bulk '" + d + "', single_blob) as picture)" +
                    " where magv = '" + this.txtmagv.Text.Trim() + "'");
                    cmd.ExecuteNonQuery();

                    //lấy tất cả dữ liệu bảng nhân viên đẩy ra đây
                    da = new SqlDataAdapter("select * from giangvien", conn);
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

                txtmagv.Enabled = true;
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

        private void btthem_Click(object sender, EventArgs e)
        {
            bien = "1";

            txtmagv.ResetText();
            txten.ResetText();
            combo_makhoa.Text = "";
            txtngaysinh.ResetText();
            txtLCB.ResetText();
            txtheso.ResetText();


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

            txtmagv.Enabled = false;

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
                fr.phancong.Enabled = true;
                this.Hide();
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
    }
}
