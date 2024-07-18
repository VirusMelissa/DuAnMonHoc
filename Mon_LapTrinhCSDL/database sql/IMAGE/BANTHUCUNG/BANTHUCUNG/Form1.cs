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

namespace BANTHUCUNG
{
    public partial class Form1 : Form
    {
        string KN = "data source=MAY10" + "\\" + "MAY10; initial catalog = QLTHUCUNG; integrated security=true";
        SqlDataAdapter da = null;
        DataTable dt = null;
        string fileName;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTHUCUNGDataSet.THUCUNG' table. You can move, or remove it, as needed.
            this.tHUCUNGTableAdapter.Fill(this.qLTHUCUNGDataSet.THUCUNG);

            txtduongdan.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                fileName = dlg.FileName;

                pictureBox1.Image = Image.FromFile(fileName);
                txtduongdan.Text = fileName.ToString();
            }
        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(KN);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = System.String.Concat("insert into THUCUNG (MATC,TENTC, IMPATH,ANH) select '" +
                    this.txtmathucung.Text.ToString() + "','" +
                    this.txttenthucung.Text.ToString() + "','" +
                    fileName + "', bulkcolumn from openrowset (bulk '" + fileName + "', single_blob) as picture");


                MessageBox.Show(cmd.CommandText);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                da = new SqlDataAdapter("select * from thucung", conn);
                dt = new DataTable();
                dt.Clear();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                MessageBox.Show("Đã thêm thành công!!!");
            }
            catch(SqlException)
            {
                MessageBox.Show("Thêm mém thành công!!!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            this.txtmathucung.Text = dataGridView1.Rows[r].Cells[0].Value.ToString().Trim();
            this.txttenthucung.Text = dataGridView1.Rows[r].Cells[1].Value.ToString().Trim();
            this.txtduongdan.Text = dataGridView1.Rows[r].Cells[3].Value.ToString().Trim();

            MemoryStream ms = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells[2].Value);
            pictureBox1.Image = Image.FromStream(ms);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(KN);
            conn.Open();
            try
            {
                //giữ tên đường dẫn
                string d = txtduongdan.Text;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                

                cmd.CommandText = System.String.Concat("update thucung set tentc = '" +
                    this.txttenthucung.Text.ToString() + "', impath = '" + txtduongdan.Text.ToString().Trim() + "', anh = (select bulkcolumn" +
                    " from openrowset (bulk '" + d + "', single_blob) as picture)" +
                    " where matc = '" + this.txtmathucung.Text.Trim() + "'");

                MessageBox.Show(cmd.CommandText);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
               
                da = new SqlDataAdapter("select * from thucung", conn);
                dt = new DataTable();
                dt.Clear();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                MessageBox.Show("Sửa thành công!!!");
            }
            catch(SqlException)
            {
                MessageBox.Show("Sửa mém thành công!!!");
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

                cmd.CommandText = System.String.Concat("delete from thucung where matc = '" + ma + "'");
                cmd.ExecuteNonQuery();

                da = new SqlDataAdapter("select * from thucung", conn);
                dt = new DataTable();
                dt.Clear();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                MessageBox.Show("Xoá thành công!!!");
            }
            catch(SqlException)
            {
                MessageBox.Show("Xoá mém thành công!!!");
            }
        }
    }
}
