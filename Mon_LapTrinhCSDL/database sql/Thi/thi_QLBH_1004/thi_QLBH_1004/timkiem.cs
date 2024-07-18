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
    public partial class timkiem : Form
    {
        string KN = "data source=ADMIN" + "\\" + "SQLEXPRESS; initial catalog = QLBH_1004_TEST; integrated security=true";
        SqlDataAdapter da_sp = null;
        DataTable dt_sp = null;
        SqlConnection conn = null;
        public timkiem()
        {
            InitializeComponent();
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(KN);
            conn.Open();


            SqlCommand cmd = new SqlCommand();
            //mở kết nối
            cmd.Connection = conn;           
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = System.String.Concat("SELECT * FROM sanpham WHERE tensp='" + txttensp.Text + "'");
            cmd.ExecuteNonQuery();
            //load lại dữ liệu trên datagridview
            da_sp = new SqlDataAdapter("SELECT * FROM sanpham WHERE tensp='" + txttensp.Text + "'", conn);
            dt_sp = new DataTable();
            dt_sp.Clear();
            da_sp.Fill(dt_sp);
            //Đưa dữ liệu lên DataGridView
            dataGridView1.DataSource = dt_sp;

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

        private void timkiem_Load(object sender, EventArgs e)
        {
            //Khởi tạo kết nối
            conn = new SqlConnection(KN);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            //mở kết nối
            cmd.Connection = conn;

            //khai báo đối tượng auto
            AutoCompleteStringCollection auto2 = new AutoCompleteStringCollection();
            //lọc ra họ tên của tất cả nhân viên có trong bảng nhân viên
            string sql = "Select tensp from sanpham";

            SqlCommand com = new SqlCommand();
            com.Connection = conn;            
            com.CommandType = CommandType.Text;
            com.CommandText = sql;

            SqlDataReader rd = com.ExecuteReader();
            //nếu tìm được thì gán 3 dòng trên
            if (rd != null)
            {
                while (rd.Read())
                {
                    auto2.Add(rd["tensp"].ToString());
                }
            }
            //gợi ý những tên có họ nguyễn
            txttensp.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txttensp.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txttensp.AutoCompleteCustomSource = auto2;
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn đóng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));

            if (thongbao == DialogResult.Yes)
            {
                danhmucsp fr = new danhmucsp();
                fr.Show();
                this.Hide();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;

            MemoryStream ms = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells[6].Value);
            pictureBox1.Image = Image.FromStream(ms);
        }
    }
}
