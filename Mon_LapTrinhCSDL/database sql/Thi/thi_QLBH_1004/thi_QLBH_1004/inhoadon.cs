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

            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btinhoadon_Click(object sender, EventArgs e)
        {
            //this.QLBH_1004_TESTDataSet1.EnforceConstraints = false;
            //this.KH_HDTableAdapter.Fill(this.QLBH_1004_TESTDataSet1.KH_HD, comboBox1.SelectedValue.ToString());
            //this.reportViewer1.RefreshReport();
        }
    }
}
