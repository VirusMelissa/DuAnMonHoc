﻿using System;
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
    public partial class danhmucsanpham : Form
    {
        string KN = "data source=ADMIN" + "\\" + "SQLEXPRESS; initial catalog = QLBH_1004_TEST2; integrated security=true";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        string fileName, bien = "0";
        public danhmucsanpham()
        {
            InitializeComponent();
        }

        private void bttimanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                fileName = dlg.FileName;

                pictureBox1.Image = Image.FromFile(fileName);
                txtduongdan.Text = fileName.ToString();
            }    
        }

        private void combo_dvt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtduongdan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void danhmucsanpham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_1004_TEST2DataSet2.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.qLBH_1004_TEST2DataSet2.SANPHAM);

            DataGridViewCellStyle style = dataGridView1.ColumnHeadersDefaultCellStyle;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            combo_dvt.Text = "Cây";

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

        private void txtgiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
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

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            if(bien == "1")
            {
                conn = new SqlConnection(KN);
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = System.String.Concat("insert into SANPHAM(MASP,TENSP,DVT,NUOCSX,GIA,DUONGDANANH,ANH) SELECT '" +
                        txtmasp.Text + "','" +
                        txttensp.Text + "','" +
                        combo_dvt.Text.Trim() + "','" +
                        txtnuocsx.Text + "'," +
                        txtgiaban.Text + ",'" +
                        fileName + "', bulkcolumn from openrowset (bulk '" + fileName + "', single_blob) as picture");
                    MessageBox.Show(cmd.CommandText);
                    cmd.ExecuteNonQuery();

                    da = new SqlDataAdapter("select * from SANPHAM", conn);
                    dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("Đã Thêm thành công");
                }
                catch(SqlException)
                {
                    MessageBox.Show("Không thêm được");
                }
                btthem.Enabled = true;
                btxoa.Enabled = true;
                btsua.Enabled = true;
                btthoat.Enabled = true;
                bttim.Enabled = true;
            }
            else if (bien == "2")
            {
                conn = new SqlConnection(KN);
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
                    MessageBox.Show("Đã Xóa thành công");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Xóa thêm được");
                }
                btthem.Enabled = true;
                btxoa.Enabled = true;
                btsua.Enabled = true;
                btthoat.Enabled = true;
                bttim.Enabled = true;
            }
            else if (bien == "3")
            {
                conn = new SqlConnection(KN);
                conn.Open();
                try
                {
                    string d = txtduongdan.Text;

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = System.String.Concat("update sanpham set tensp = '" +
                        txttensp.Text.ToString() + "', dvt = '" +
                        combo_dvt.Text.ToString().Trim() + "', nuocsx = '" +
                        txtnuocsx.Text.ToString() + "', gia = " +
                        txtgiaban.Text.ToString() + ", duongdananh = '" + d + "', anh = (select bulkcolumn " +
                        " from openrowset (bulk '" + d + "', single_blob) as picture)" +
                        " where masp = '" + txtmasp.Text.Trim() + "'");
                    cmd.ExecuteNonQuery();

                    da = new SqlDataAdapter("select * from SANPHAM", conn);
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
                btthoat.Enabled = true;
                bttim.Enabled = true;

                txtmasp.Enabled = true;
            }
            bien = "0";
            string masp = txtmasp.Text.ToUpper().Trim();
            while (masp.IndexOf("  ") >= 0)
            {
                masp = masp.Replace("  ", " ");
            }
            txtmasp.Text = masp;
        }

        private void btthoat_Click(object sender, EventArgs e)
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

        private void bttim_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn muốn tìm kiếm?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (thongbao == DialogResult.Yes)
            {
                timkiem fr = new timkiem();
                fr.Show();
                this.Hide();
            }
        }

        private void txtmasp_Leave(object sender, EventArgs e)
        {
            string masp = txtmasp.Text.ToUpper().Trim();
            while(masp.IndexOf("  ") >= 0)
            {
                masp = masp.Replace("  ", " ");
            }
            txtmasp.Text = masp;
        }
    }
}