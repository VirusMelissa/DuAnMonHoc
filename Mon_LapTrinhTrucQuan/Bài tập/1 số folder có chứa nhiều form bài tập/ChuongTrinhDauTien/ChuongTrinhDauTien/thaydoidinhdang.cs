using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhDauTien
{
    public partial class thaydoidinhdang : Form
    {
        public thaydoidinhdang()
        {
            InitializeComponent();
        }

        private void CB_thaydoi_CheckedChanged(object sender, EventArgs e)
        {
            //hovaten.BackColor = Color.Red;
            //hovaten.ForeColor = Color.Yellow;
            //if(CB_thaydoi.Checked == true)
            //{
            //    hovaten.UseSystemPasswordChar = true;
            //}
            //else
            //{
            //    hovaten.UseSystemPasswordChar = false;
            //}
            if (CB_thaydoi.CheckState == CheckState.Unchecked)
            {
                hovaten.BackColor = Color.Yellow;
                hovaten.ForeColor = Color.Red;
            }
            else if(CB_thaydoi.CheckState == CheckState.Checked)
            { 
                hovaten.BackColor = Color.Red;
                hovaten.ForeColor = Color.Yellow;
            }
        }

        private void thaydoidinhdang_Load(object sender, EventArgs e)
        {
            hovaten.BackColor = Color.Yellow;
            CB_thaydoi.CheckState = CheckState.Indeterminate;
        }

        private void hovaten_TextChanged(object sender, EventArgs e)
        {
            if (hovaten.Text != "")
            {
                hovaten.BackColor = Color.Red;
                hovaten.ForeColor = Color.Yellow;
                CB_thaydoi.CheckState = CheckState.Checked;
            }
        }
    }
}
