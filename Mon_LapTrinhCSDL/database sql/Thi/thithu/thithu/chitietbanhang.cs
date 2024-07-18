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

namespace thithu
{
    public partial class chitietbanhang : Form
    {
        string KN = "data source=ADMIN" + "\\" + "SQLEXPRESS; initial catalog = QLBH_1004_TEST2; integrated security=true";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        string bien = "0";
        public chitietbanhang()
        {
            InitializeComponent();
        }

        private void chitietbanhang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_1004_TEST2DataSet3.ABC' table. You can move, or remove it, as needed.
            this.aBCTableAdapter.Fill(this.qLBH_1004_TEST2DataSet3.ABC);

            DataGridViewCellStyle style = dataGridView1.ColumnHeadersDefaultCellStyle;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style.Font = new Font(dataGridView1.Font, FontStyle.Bold);


            dataGridView1.Columns[3].DefaultCellStyle.Format = "#,### VNĐ";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "#,### VNĐ";

            dataGridView1.Columns[0].HeaderText = "SỐ HÓA ĐƠN";
            dataGridView1.Columns[1].HeaderText = "MÃ KH";
            dataGridView1.Columns[2].HeaderText = "MÃ SP";
            dataGridView1.Columns[3].HeaderText = "GIÁ BÁN";
            dataGridView1.Columns[4].HeaderText = "SỐ LƯỢNG";
            dataGridView1.Columns[5].HeaderText = "THÀNH TIỀN";

            dataGridView1.Columns[0].Width = 130;
            dataGridView1.Columns[3].Width = 130;
            dataGridView1.Columns[4].Width = 130;
            dataGridView1.Columns[5].Width = 130;

            conn = new SqlConnection(KN);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();

            AutoCompleteStringCollection auto2 = new AutoCompleteStringCollection();
            AutoCompleteStringCollection auto3 = new AutoCompleteStringCollection();
            AutoCompleteStringCollection auto4 = new AutoCompleteStringCollection();

            string sql1 = "select sohd from hoadon";
            string sql2 = "select makh from khachhang";
            string sql3 = "select masp from sanpham";

            SqlCommand com1 = new SqlCommand();
            com1.Connection = conn;
            com1.CommandType = CommandType.Text;
            com1.CommandText = sql1;

            SqlCommand com2 = new SqlCommand();
            com2.Connection = conn;
            com2.CommandType = CommandType.Text;
            com2.CommandText = sql2;

            SqlCommand com3 = new SqlCommand();
            com3.Connection = conn;
            com3.CommandType = CommandType.Text;
            com3.CommandText = sql3;

            SqlDataReader rd1 = com1.ExecuteReader();
            if (rd1 != null)
            {
                while (rd1.Read())
                {
                    auto2.Add(rd1["sohd"].ToString());
                }
            }

            txtsohd.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtsohd.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtsohd.AutoCompleteCustomSource = auto2;
            conn.Close();
            conn.Open();


            SqlDataReader rd2 = com2.ExecuteReader();
            if (rd2 != null)
            {
                while (rd2.Read())
                {
                    auto3.Add(rd2["makh"].ToString());
                }
            }

            txtmakh.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtmakh.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtmakh.AutoCompleteCustomSource = auto3;
            conn.Close();
            conn.Open();

            SqlDataReader rd3 = com3.ExecuteReader();
            if (rd3 != null)
            {
                while (rd3.Read())
                {
                    auto4.Add(rd3["masp"].ToString());
                }
            }


            txtmasp.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtmasp.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtmasp.AutoCompleteCustomSource = auto4;
            conn.Close();
        }

        private void txtgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtthanhtien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số");
            }
        }

        private void txtgia_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtmasp.Text != "")
            {
                string s = "select gia from sanpham where masp = '" + txtmasp.Text + "'";

                conn = new SqlConnection(KN);
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = s;
                cmd.ExecuteScalar();
                string x = cmd.ExecuteScalar().ToString();
                txtgia.Text = x.Substring(0, x.Length - 5);
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã sản phẩm");
            }
        }

        private void txtthanhtien_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtgia.Text != "" && txtsoluong.Text != "")
            {
                double x = double.Parse(txtgia.Text);
                int y = int.Parse(txtsoluong.Text);
                double z = x * y;
                txtthanhtien.Text = Convert.ToString(z);
            }
            else
            {
                MessageBox.Show("Thiếu giá trị 'giá' hoặc 'số lượng'");
            }
        }

        private void txtsohd_Leave(object sender, EventArgs e)
        {
            string masp = txtsohd.Text.ToUpper().Trim();
            while (masp.IndexOf("  ") >= 0)
            {
                masp = masp.Replace("  ", " ");
            }
            txtsohd.Text = masp;
        }

        private void txtmakh_Leave(object sender, EventArgs e)
        {
            string masp = txtmakh.Text.ToUpper().Trim();
            while (masp.IndexOf("  ") >= 0)
            {
                masp = masp.Replace("  ", " ");
            }
            txtmakh.Text = masp;
        }

        private void txtmasp_Leave(object sender, EventArgs e)
        {
            string masp = txtmasp.Text.ToUpper().Trim();
            while (masp.IndexOf("  ") >= 0)
            {
                masp = masp.Replace("  ", " ");
            }
            txtmasp.Text = masp;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            this.txtsohd.Text = dataGridView1.Rows[r].Cells[0].Value.ToString().Trim();
            this.txtmakh.Text = dataGridView1.Rows[r].Cells[1].Value.ToString().Trim();
            this.txtmasp.Text = dataGridView1.Rows[r].Cells[2].Value.ToString().Trim();
            string x1 = dataGridView1.Rows[r].Cells[3].Value.ToString().Trim();
            this.txtgia.Text = x1.Substring(0, x1.Length - 5);
            this.txtsoluong.Text = dataGridView1.Rows[r].Cells[4].Value.ToString().Trim();
            string x2 = dataGridView1.Rows[r].Cells[5].Value.ToString().Trim();
            this.txtthanhtien.Text = x2.Substring(0, x2.Length - 5);

            txtgia.Enabled = true;
        }

        private void btdong_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (thongbao == DialogResult.Yes)
            {
                Menu fr = new Menu();
                fr.Show();
                fr.danhmuc.Enabled = true;
                fr.chitietbanhang.Enabled = true;
                fr.inhoadon.Enabled = true;
                this.Hide();
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            bien = "1";

            txtmasp.ResetText();
            txtsohd.ResetText();
            txtmakh.ResetText();
            txtgia.ResetText();
            txtsoluong.ResetText();
            txtthanhtien.ResetText();

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

            txtsohd.Enabled = false;
            txtmasp.Enabled = false;
            txtmakh.Enabled = false;

            btthem.Enabled = false;
            btxoa.Enabled = false;
            btsua.Enabled = false;
            btdong.Enabled = false;
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            if (bien == "1")
            {
                conn = new SqlConnection(KN);
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into ABC(SOHD,MAKH,MASP,SL) values('" + txtsohd.Text + "','" + txtmakh.Text + "','" + txtmasp.Text + "'," + txtsoluong.Text + ")";
                    cmd.ExecuteNonQuery();

                    da = new SqlDataAdapter("select * from ABC", conn);
                    dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("Đã Thêm thành công");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được");
                }
                btthem.Enabled = true;
                btxoa.Enabled = true;
                btsua.Enabled = true;
                btdong.Enabled = true;
            }
            else if (bien == "2")
            {
                conn = new SqlConnection(KN);
                conn.Open();
                try
                {
                    int r = dataGridView1.CurrentCell.RowIndex;
                    string ma = dataGridView1.Rows[r].Cells[0].Value.ToString().Trim();
                    string ma1 = dataGridView1.Rows[r].Cells[1].Value.ToString().Trim();
                    string ma2 = dataGridView1.Rows[r].Cells[2].Value.ToString().Trim();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = System.String.Concat("delete from ABC where sohd = '" + ma + "' AND makh = '" + ma1 + "' AND masp = '" + ma2 + "'");
                    cmd.ExecuteNonQuery();

                    da = new SqlDataAdapter("select * from ABC", conn);
                    dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("Đã Xóa thành công");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Xóa không được");
                }
                btthem.Enabled = true;
                btxoa.Enabled = true;
                btsua.Enabled = true;
                btdong.Enabled = true;
            }
            else if (bien == "3")
            {
                conn = new SqlConnection(KN);
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;

                    string ma = txtsohd.Text.ToString();
                    string ma1 = txtgia.Text.ToString();
                    string ma2 = txtmasp.Text.ToString();
                    cmd.CommandText = System.String.Concat("update ABC set SL = " +
                    this.txtsoluong.Text + "" +  
                    " where SOHD = '" + this.txtsohd.Text + "' AND MAKH = '" + this.txtmakh.Text + "' AND MASP = '" + this.txtmasp.Text + "'");
                    cmd.ExecuteNonQuery();

                    da = new SqlDataAdapter("select * from ABC", conn);
                    dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("Đã Sửa thành công");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không sửa được");
                }
                btthem.Enabled = true;
                btxoa.Enabled = true;
                btsua.Enabled = true;
                btdong.Enabled = true;

                txtmakh.Enabled = true;
                txtsohd.Enabled = true;
                txtmasp.Enabled = true;
            }
            bien = "0";
            string masp1 = txtmasp.Text.ToUpper().Trim();
            while (masp1.IndexOf("  ") >= 0)
            {
                masp1 = masp1.Replace("  ", " ");
            }
            txtmasp.Text = masp1;

            string masp2 = txtsohd.Text.ToUpper().Trim();
            while (masp2.IndexOf("  ") >= 0)
            {
                masp2 = masp2.Replace("  ", " ");
            }
            txtsohd.Text = masp2;

            string masp3 = txtmakh.Text.ToUpper().Trim();
            while (masp3.IndexOf("  ") >= 0)
            {
                masp3 = masp3.Replace("  ", " ");
            }
            txtmakh.Text = masp3;
        }
    }
}
