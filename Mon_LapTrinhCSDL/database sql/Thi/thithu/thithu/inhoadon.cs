using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thithu
{
    public partial class inhoadon : Form
    {
        public inhoadon()
        {
            InitializeComponent();
        }

        private void inhoadon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBH_1004_TEST2DataSet.KH_HD' table. You can move, or remove it, as needed.
            //this.KH_HDTableAdapter.Fill(this.QLBH_1004_TEST2DataSet.KH_HD);
            // TODO: This line of code loads data into the 'qLBH_1004_TEST2DataSet1.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qLBH_1004_TEST2DataSet1.KHACHHANG);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.QLBH_1004_TEST2DataSet.EnforceConstraints = false;
            this.KH_HDTableAdapter.Fill(this.QLBH_1004_TEST2DataSet.KH_HD, comboBox1.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }
    }
}
