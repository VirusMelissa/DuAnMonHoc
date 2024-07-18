using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thi_QLBH_1004
{
    public partial class inhoadon : Form
    {
        public inhoadon()
        {
            InitializeComponent();
        }

        private void inhoadon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_1004_TESTDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qLBH_1004_TESTDataSet.KHACHHANG);
            // TODO: This line of code loads data into the 'qLBH_1004_TESTDataSet.KH_HD' table. You can move, or remove it, as needed.
            //this.kH_HDTableAdapter.Fill(this.qLBH_1004_TESTDataSet.KH_HD);

            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btinhoadon_Click(object sender, EventArgs e)
        {
            this.QLBH_1004_TESTDataSet1.EnforceConstraints = false;
            this.KH_HDTableAdapter.Fill(this.QLBH_1004_TESTDataSet1.KH_HD, comboBox1.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }
    }
}
