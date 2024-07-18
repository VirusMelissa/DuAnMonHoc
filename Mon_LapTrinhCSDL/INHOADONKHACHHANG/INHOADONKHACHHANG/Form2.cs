using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INHOADONKHACHHANG
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.QLBH_1004_TESTDataSet2.EnforceConstraints = false;
            this.KH_HDTableAdapter.Fill(this.QLBH_1004_TESTDataSet2.KH_HD, comboBox1.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBH_1004_TESTDataSet2.KH_HD' table. You can move, or remove it, as needed.
            //this.KH_HDTableAdapter.Fill(this.QLBH_1004_TESTDataSet2.KH_HD);
            // TODO: This line of code loads data into the 'qLBH_1004_TESTDataSet3.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qLBH_1004_TESTDataSet3.KHACHHANG);

            //this.reportViewer1.RefreshReport();
        }
    }
}
