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

namespace thithu
{
    public partial class timkiem : Form
    {
        string KN = "data source=ADMIN" + "\\" + "SQLEXPRESS; initial catalog = QLBH_1004_TEST2; integrated security=true";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        public timkiem()
        {
            InitializeComponent();
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(KN);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = System.String.Concat("SELECT * FROM SANPHAM WHERE TENSP = '" + txttensp.Text + "'");
            cmd.ExecuteNonQuery();

            da = new SqlDataAdapter("SELECT * FROM SANPHAM WHERE TENSP = '" + txttensp.Text + "'", conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[4].DefaultCellStyle.Format = "#,### VNĐ";

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
            conn = new SqlConnection(KN);
            conn.Open();

            AutoCompleteStringCollection auto2 = new AutoCompleteStringCollection();
            string sql = "select tensp from sanpham";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;

            SqlDataReader rd = cmd.ExecuteReader();
            if(rd != null)
            {
                while(rd.Read())
                {
                    auto2.Add(rd["tensp"].ToString());
                }
            }

            txttensp.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txttensp.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txttensp.AutoCompleteCustomSource = auto2;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MemoryStream ms = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells[6].Value);
            pictureBox1.Image = Image.FromStream(ms);
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (thongbao == DialogResult.Yes)
            {
                danhmucsanpham fr = new danhmucsanpham();
                fr.Show();
                this.Hide();
            }
        }
    }
}
