using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuViDienTich
{
    public partial class Kiemtra1_ChuVi_DienTich : Form
    {
        //khai báo biến nè - float để nhận giá trị 6 vị trí thập phân - double để nhận giá trị 15 vị trí thập phân
        int a, b, c, d, r, chan;
        float x, y, z;
        double P, S;

        /*private void CB_HCN_CheckedChanged(object sender, EventArgs e)
        {
            //Phúc - khi chọn checkbox Hình chữ nhật thì toàn bộ checkbox và group khác đều tắt hết
            if (CB_HCN.CheckState == CheckState.Checked)
            {
                groupHV.Visible = false;
                groupHT.Visible = false;
                groupHTG.Visible = false;
                groupHCN.Visible = true;
                CB_HT.CheckState = CheckState.Unchecked;
                CB_HV.CheckState = CheckState.Unchecked;
                CB_HTG.CheckState = CheckState.Unchecked;
            }
            else if (CB_HCN.CheckState == CheckState.Unchecked)
            {
                groupHCN.Visible = false;
            }
        }*/

        /*private void CB_HTG_CheckedChanged(object sender, EventArgs e)
        {
            //Phúc - khi chọn checkbox Hình tam giác thì toàn bộ checkbox và group khác đều tắt hết
            if (CB_HTG.CheckState == CheckState.Checked)
            {
                groupHV.Visible = false;
                groupHT.Visible = false;
                groupHTG.Visible = true;
                groupHCN.Visible = false;
                CB_HCN.CheckState = CheckState.Unchecked;
                CB_HV.CheckState = CheckState.Unchecked;
                CB_HT.CheckState = CheckState.Unchecked;
            }
            else if (CB_HTG.CheckState == CheckState.Unchecked)
            {
                groupHTG.Visible = false;
            }
        }*/

        private void CB_chuhoa_CheckStateChanged(object sender, EventArgs e)
        {
            //Nếu Checkbox chữ hoa hiện checked thì mở button Chuyển đổi
            if (CB_chuhoa.CheckState == CheckState.Checked)
            {
                btChuyendoi.Enabled = true;
                group_HienThi.Visible = true;
                CB_chuthuong.CheckState = CheckState.Unchecked;
            }
            //Nếu Checkbox chữ hoa không hiện checked nhưng Checkbox chữ thường hiện checked thì vẫn mở button Chuyển đổi
            //còn ngược lại cả 2 checkbox đều không hiện checked thì button chuyển đổi tắt
            else if (CB_chuhoa.CheckState == CheckState.Unchecked)
            {
                if (CB_chuthuong.CheckState == CheckState.Checked)
                {
                    btChuyendoi.Enabled = true;
                    group_HienThi.Visible = true;
                }
                else
                {
                    btChuyendoi.Enabled = false;
                    group_HienThi.Visible = false;
                }
            }
        }

        private void CB_chuthuong_CheckStateChanged(object sender, EventArgs e)
        {
            //Nếu Checkbox chữ thường hiện checked thì mở button Chuyển đổi
            if (CB_chuthuong.CheckState == CheckState.Checked)
            {
                btChuyendoi.Enabled = true;
                group_HienThi.Visible = true;
                CB_chuhoa.CheckState = CheckState.Unchecked;
            }
            //Nếu Checkbox chữ thường không hiện checked nhưng Checkbox chữ hoa hiện checked thì vẫn mở button Chuyển đổi
            //còn ngược lại cả 2 checkbox đều không hiện checked thì button chuyển đổi tắt
            else if (CB_chuthuong.CheckState == CheckState.Unchecked)
            {
                if (CB_chuhoa.CheckState == CheckState.Checked)
                {
                    btChuyendoi.Enabled = true;
                    group_HienThi.Visible = true;
                }
                else
                {
                    group_HienThi.Visible = false;
                    btChuyendoi.Enabled = false;
                }
            }
        }

        private void btChuyendoi_MouseHover(object sender, EventArgs e)
        {
            //hiện ghi chú khi rê chuột vào button chuyển đổi
            toolTip1.SetToolTip(btChuyendoi, "Chuyển đổi hoa và thường trong textbox hiển thị dạng tam giác ở checkbox hình tam giác");
        }

        private void CB_chanle_CheckStateChanged(object sender, EventArgs e)
        {
            //Nếu Checkbox chẵn lẻ hiện checked thì mở button Chuyển đổi
            if (CB_chanle.CheckState == CheckState.Checked)
            {
                btKiemtra.Enabled = true;
                group_HienThi.Visible = true;
            }
            //Nếu Checkbox chẵn lẻ không hiện checked nhưng Checkbox giá trị hiện checked thì vẫn mở button Chuyển đổi
            //còn ngược lại cả 2 checkbox đều không hiện checked thì button chuyển đổi tắt
            else if (CB_chanle.CheckState == CheckState.Unchecked)
            {
                if(CB_giatri.CheckState == CheckState.Checked)
                {
                    btKiemtra.Enabled = true;
                    group_HienThi.Visible = true;
                }
                else group_HienThi.Visible = false;
            }
        }

        private void radio_HV_CheckedChanged(object sender, EventArgs e)
        {
            groupHT.Visible = false;
            groupHV.Visible = true;
            groupHTG.Visible = false;
            groupHCN.Visible = false;
        }

        private void radio_HT_CheckedChanged(object sender, EventArgs e)
        {
            groupHV.Visible = false;
            groupHT.Visible = true;
            groupHTG.Visible = false;
            groupHCN.Visible = false;
        }

        private void radio_HCN_CheckedChanged(object sender, EventArgs e)
        {
            groupHV.Visible = false;
            groupHCN.Visible = true;
            groupHTG.Visible = false;
            groupHT.Visible = false;
        }

        private void radio_HTG_CheckedChanged(object sender, EventArgs e)
        {
            groupHV.Visible = false;
            groupHTG.Visible = true;
            groupHT.Visible = false;
            groupHCN.Visible = false;
        }

        private void NhapA_HTG_TextChanged(object sender, EventArgs e)
        {
            SoChan.ResetText();
            SoLe.ResetText();
            SoLN.ResetText();
            SoNN.ResetText();
            KetQuaCD.ResetText();
        }

        private void NhapB_HTG_TextChanged(object sender, EventArgs e)
        {
            SoChan.ResetText();
            SoLe.ResetText();
            SoLN.ResetText();
            SoNN.ResetText();
            KetQuaCD.ResetText();
        }

        private void NhapC_HTG_TextChanged(object sender, EventArgs e)
        {
            SoChan.ResetText();
            SoLe.ResetText();
            SoLN.ResetText();
            SoNN.ResetText();
            KetQuaCD.ResetText();
        }

        private void NhapA_HCN_TextChanged(object sender, EventArgs e)
        {
            SoChan.ResetText();
            SoLe.ResetText();
            SoLN.ResetText();
            SoNN.ResetText();
            KetQuaCD.ResetText();
        }

        private void NhapB_HCN_TextChanged(object sender, EventArgs e)
        {
            SoChan.ResetText();
            SoLe.ResetText();
            SoLN.ResetText();
            SoNN.ResetText();
            KetQuaCD.ResetText();
        }

        private void NhapBK_HT_TextChanged(object sender, EventArgs e)
        {
            SoChan.ResetText();
            SoLe.ResetText();
            SoLN.ResetText();
            SoNN.ResetText();
            KetQuaCD.ResetText();
        }

        private void NhapA_HV_TextChanged(object sender, EventArgs e)
        {
            SoChan.ResetText();
            SoLe.ResetText();
            SoLN.ResetText();
            SoNN.ResetText();
            KetQuaCD.ResetText();
        }

        private void CB_chuhoa_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(CB_chuhoa, "Chữ Hoa và Chữ Thường chỉ được chọn 1 trong 2");
        }

        private void CB_chuthuong_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(CB_chuthuong, "Chữ Hoa và Chữ Thường chỉ được chọn 1 trong 2");
        }

        private void CB_chanle_MouseHover(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(CB_chanle, "Có thể chọn chẵn lẻ và giá trị cùng lúc");
        }

        private void CB_giatri_MouseHover(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(CB_giatri, "Có thể chọn chẵn lẻ và giá trị cùng lúc");
        }

        private void MoiBanChon_MouseHover(object sender, EventArgs e)
        {
            toolTip4.SetToolTip(CB_chanle, "Mời bạn chọn 1 trong 4 Hình");
        }

        private void KetQuaCD_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btChuyendoi, "Chuyển đổi hoa và thường trong textbox hiển thị dạng tam giác ở checkbox hình tam giác");
        }

        private void CB_chanle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SoChan_TextChanged(object sender, EventArgs e)
        {

        }

        private void CB_giatri_CheckStateChanged(object sender, EventArgs e)
        {
            //Nếu Checkbox giá trị hiện checked thì mở button Chuyển đổi
            if (CB_giatri.CheckState == CheckState.Checked)
            {
                btKiemtra.Enabled = true;
                group_HienThi.Visible = true;
            }
            //Nếu Checkbox giá trị không hiện checked nhưng Checkbox chẵn lẻ hiện checked thì vẫn mở button Chuyển đổi
            //còn ngược lại cả 2 checkbox đều không hiện checked thì button chuyển đổi tắt
            else if (CB_giatri.CheckState == CheckState.Unchecked)
            {
                if (CB_chanle.CheckState == CheckState.Checked)
                {
                    btKiemtra.Enabled = true;
                    group_HienThi.Visible = true;
                }
                else group_HienThi.Visible = false;
            }
        }

        private void btChuyendoi_Click(object sender, EventArgs e)
        {
            //khai báo biến s kiểu chuỗi
            string s = KiemTra_HTG.Text;
            //chuyển chữ hoa
            if (CB_chuhoa.CheckState == CheckState.Checked)
                KetQuaCD.Text = s.ToUpper();
            //chuyễn chữ thường
            if (CB_chuthuong.CheckState == CheckState.Checked)
                KetQuaCD.Text = s.ToLower();
        }

        private void btKiemtra_Click(object sender, EventArgs e)
        {
            //Nếu checkbox của hình vuông = true thì thực hiện phép tính
            if (radio_HV.Checked == true)
            {
                if (CB_chanle.CheckState == CheckState.Checked)
                {
                    d = Convert.ToInt32(NhapA_HV.Text);
                    //Phép chia lấy dư
                    chan = d % 2;
                    //chia cho 2 nhưng không dư
                    if(chan == 0)
                    {
                        SoChan.Text = Convert.ToString(NhapA_HV.Text);
                    }
                    //chia cho 2 nhưng bị dư
                    else SoLe.Text = Convert.ToString(NhapA_HV.Text);
                }

                if (CB_giatri.CheckState == CheckState.Checked)
                {
                    d = Convert.ToInt32(NhapA_HV.Text);
                    SoLN.Text = Convert.ToString(NhapA_HV.Text);
                }
            }

            // Nếu checkbox của hình tròn = true thì thực hiện phép tính
            if (radio_HT.Checked == true)
            {
                if (CB_chanle.CheckState == CheckState.Checked)
                {
                    r = Convert.ToInt32(NhapBK_HT.Text);
                    //Phép chia lấy dư
                    chan = d % 2;
                    //chia cho 2 nhưng không dư
                    if (chan == 0)
                    {
                        SoChan.Text = Convert.ToString(NhapBK_HT.Text);
                    }
                    //chia cho 2 nhưng bị dư
                    else SoLe.Text = Convert.ToString(NhapBK_HT.Text);
                }

                if (CB_giatri.CheckState == CheckState.Checked)
                {
                    r = Convert.ToInt32(NhapBK_HT.Text);
                    SoLN.Text = Convert.ToString(NhapBK_HT.Text);
                }
            }

            // Nếu checkbox của hình chữ nhật = true thì thực hiện phép tính
            if (radio_HCN.Checked == true)
            {
                if (CB_chanle.CheckState == CheckState.Checked)
                {
                    int chan1, chan2;
                    a = Convert.ToInt32(NhapA_HCN.Text);
                    b = Convert.ToInt32(NhapB_HCN.Text);
                    //Phép chia lấy dư
                    chan1 = a % 2;
                    chan2 = b % 2;
                    if (chan1 == 0 && chan2 == 0)
                    {
                        SoChan.Text = Convert.ToString(NhapA_HCN.Text + "," + NhapB_HCN.Text);
                    }
                    else if (chan1 == 0 && chan2 != 0)
                    {
                        SoChan.Text = Convert.ToString(NhapA_HCN.Text);
                        SoLe.Text = Convert.ToString(NhapB_HCN.Text);
                    }
                    else if (chan1 != 0 && chan2 == 0)
                    {
                        SoChan.Text = Convert.ToString(NhapB_HCN.Text);
                        SoLe.Text = Convert.ToString(NhapA_HCN.Text);
                    }
                    else SoLe.Text = Convert.ToString(NhapA_HCN.Text + "," + NhapB_HCN.Text);
                }

                if (CB_giatri.CheckState == CheckState.Checked)
                {
                    a = Convert.ToInt32(NhapA_HCN.Text);
                    b = Convert.ToInt32(NhapB_HCN.Text);
                    if (a > b)
                    {
                        //Tìm số Lớn Nhất và Nhỏ Nhất
                        SoLN.Text = Convert.ToString(NhapA_HCN.Text); 
                        SoNN.Text = Convert.ToString(NhapB_HCN.Text);
                    }
                    else
                    {
                        //Tìm số Lớn Nhất và Nhỏ Nhất
                        SoLN.Text = Convert.ToString(NhapB_HCN.Text);
                        SoNN.Text = Convert.ToString(NhapA_HCN.Text);
                    }
                }
            }

            // Nếu checkbox của hình tam giác = true thì thực hiện phép tính
            if (radio_HTG.Checked == true)
            {
                if (CB_chanle.CheckState == CheckState.Checked)
                {
                    int chan1, chan2, chan3;
                    a = Convert.ToInt32(NhapA_HTG.Text);
                    b = Convert.ToInt32(NhapB_HTG.Text);
                    c = Convert.ToInt32(NhapC_HTG.Text);
                    //Phép chia lấy dư
                    chan1 = a % 2;
                    chan2 = b % 2;
                    chan3 = c % 2;
                    if (chan1 == 0 && chan2 == 0 && chan3 == 0)
                    {
                        SoChan.Text = Convert.ToString(NhapA_HTG.Text + "," + NhapB_HTG.Text + "," + NhapC_HTG.Text);
                    }
                    else if (chan1 == 0 && chan2 == 0 && chan3 != 0)
                    {
                        SoChan.Text = Convert.ToString(NhapA_HTG.Text + "," + NhapB_HTG.Text);
                        SoLe.Text = Convert.ToString(NhapC_HTG.Text);
                    }
                    else if (chan1 == 0 && chan2 != 0 && chan3 == 0)
                    {
                        SoChan.Text = Convert.ToString(NhapA_HTG.Text + "," + NhapC_HTG.Text);
                        SoLe.Text = Convert.ToString(NhapB_HTG.Text);
                    }
                    else if (chan1 != 0 && chan2 == 0 && chan3 == 0)
                    {
                        SoChan.Text = Convert.ToString(NhapB_HTG.Text + "," + NhapC_HTG.Text);
                        SoLe.Text = Convert.ToString(NhapA_HTG.Text);
                    }
                    else if (chan1 == 0 && chan2 != 0 && chan3 != 0)
                    {
                        SoChan.Text = Convert.ToString(NhapA_HTG.Text);
                        SoLe.Text = Convert.ToString(NhapB_HTG.Text + "," + NhapC_HTG.Text);
                    }
                    else if (chan1 != 0 && chan2 == 0 && chan3 != 0)
                    {
                        SoChan.Text = Convert.ToString(NhapB_HTG.Text);
                        SoLe.Text = Convert.ToString(NhapA_HTG.Text + "," + NhapC_HTG.Text);
                    }
                    else if (chan1 != 0 && chan2 != 0 && chan3 == 0)
                    {
                        SoChan.Text = Convert.ToString(NhapC_HTG.Text);
                        SoLe.Text = Convert.ToString(NhapA_HTG.Text + "," + NhapB_HTG.Text);
                    }
                    else SoLe.Text = Convert.ToString(NhapA_HTG.Text + "," + NhapB_HTG.Text + "," + NhapC_HTG.Text);
                }

                if (CB_giatri.CheckState == CheckState.Checked)
                {
                        a = Convert.ToInt32(NhapA_HTG.Text);
                        b = Convert.ToInt32(NhapB_HTG.Text);
                        c = Convert.ToInt32(NhapC_HTG.Text);
                        //Tìm số Lớn Nhất
                        if (a >= b && a >= c)
                        {
                            SoLN.Text = Convert.ToString(NhapA_HTG.Text);
                        }
                        else if(b >= a && b >= c)
                        {
                            SoLN.Text = Convert.ToString(NhapB_HTG.Text);
                        }
                        else if(c >= a && c >= b)
                        {
                            SoLN.Text = Convert.ToString(NhapC_HTG.Text);
                        }
                        //Tìm số Nhỏ Nhất
                        if (a < b && a < c)
                        {
                            SoNN.Text = Convert.ToString(NhapA_HTG.Text);
                        }
                        else if (b < a && b < c)
                        {
                            SoNN.Text = Convert.ToString(NhapB_HTG.Text);
                        }
                        else if (c < a && c < b)
                        {
                            SoNN.Text = Convert.ToString(NhapC_HTG.Text);
                        }                  
                }
            }
        }

        /*private void CB_HT_CheckStateChanged(object sender, EventArgs e)
        {
            //Phúc - khi chọn checkbox Hình tròn thì toàn bộ checkbox và group khác đều tắt hết
            if (CB_HT.CheckState == CheckState.Checked)
            {
                groupHV.Visible = false;
                groupHT.Visible = true;
                groupHTG.Visible = false;
                groupHCN.Visible = false;
                CB_HCN.CheckState = CheckState.Unchecked;
                CB_HV.CheckState = CheckState.Unchecked;
                CB_HTG.CheckState = CheckState.Unchecked;
            }
            else if (CB_HT.CheckState == CheckState.Unchecked)
            {
                groupHT.Visible = false;
            }
        }*/

        /*private void CB_HV_CheckStateChanged(object sender, EventArgs e)
        {
            //Phúc - khi chọn checkbox Hình vuông thì toàn bộ checkbox và group khác đều tắt hết
            if (CB_HV.CheckState == CheckState.Checked)
            {
                groupHV.Visible = true;
                groupHT.Visible = false;
                groupHTG.Visible = false;
                groupHCN.Visible = false;
                CB_HCN.CheckState = CheckState.Unchecked;
                CB_HT.CheckState = CheckState.Unchecked;
                CB_HTG.CheckState = CheckState.Unchecked;
            }
            else if (CB_HV.CheckState == CheckState.Unchecked)
            {
                groupHV.Visible = false;
            }
        }*/
        

        private void btXoa_Click(object sender, EventArgs e)
        {
            //Phúc - xóa tất cả textbox 
            ChuVi_HV.ResetText();
            ChuVi_HT.ResetText();
            ChuVi_HCN.ResetText();
            ChuVi_HTG.ResetText();
            DienTich_HV.ResetText();
            DienTich_HT.ResetText();
            DienTich_HCN.ResetText();
            DienTich_HTG.ResetText();
            NhapA_HV.ResetText();
            NhapBK_HT.ResetText();
            NhapA_HCN.ResetText();
            NhapB_HCN.ResetText();
            NhapA_HTG.ResetText();
            NhapB_HTG.ResetText();
            NhapC_HTG.ResetText();
            KiemTra_HTG.ResetText();
            KetQuaCD.ResetText();
            SoChan.ResetText();
            SoLe.ResetText();
            SoLN.ResetText();
            SoNN.ResetText();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát không?"
            + "\n" + " " +"\n" + "Nếu thoát thì bấm 'Yes'"
            + "\n" + "Nếu restart thì bấm 'No'"
            + "\n" + "Nếu muốn quay lại thì bấm 'Cancel'"
            , "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning));

            if (thongbao == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (thongbao == DialogResult.No)
            {
                Application.Restart();
            }
        }


        public Kiemtra1_ChuVi_DienTich()
        {
            InitializeComponent();
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            //Nếu checkbox = true thì thực hiện phép tính
            if (radio_HV.Checked == true)
            {
                if (NhapA_HV.Text != "")
                {   //Phúc - chuyển đổi textbox qua số nguyên nè, trong đó d là độ dài cạnh
                    d = Convert.ToInt32(NhapA_HV.Text);
                    if (d > 0)
                    {
                        //Tính chu vi HV: P = a x 4
                        ChuVi_HV.Text = Convert.ToString(d * 4);
                        //Tính diện tích HV: Là bình phương độ dài của cạnh
                        DienTich_HV.Text = Convert.ToString(d * d);
                    }
                    else MessageBox.Show("Bạn nhập sai. Vui lòng nhập số dương");
                }
                else MessageBox.Show("Vui lòng nhập giá trị, hàm không được rỗng");
            }

            //Nếu checkbox = true thì thực hiện phép tính
            if (radio_HT.Checked == true)
            {
                if (NhapBK_HT.Text != "")
                {//Phúc - chuyển đổi textbox qua số nguyên nè, trong đó r là bán kính
                    r = Convert.ToInt32(NhapBK_HT.Text);
                    if (r > 0)
                    {
                        //Tính chu vi HT: đường kính x PI hoặc 2 lần bán kính x PI, trong đó Pi là 3,14
                        ChuVi_HT.Text = Convert.ToString(2 * 3.14 * r);
                        //Tính diện tích HT: Là bình phương bán kính hình tròn x PI, trong đó Pi là 3,14
                        DienTich_HT.Text = Convert.ToString(3.14 * r * r);
                    }
                    else MessageBox.Show("Bạn nhập sai. Vui lòng nhập số dương");
                }
                else MessageBox.Show("Vui lòng nhập giá trị, hàm không được rỗng");
            }

            //Nếu checkbox = true thì thực hiện phép tính
            if (radio_HCN.Checked == true)
            {
                if (NhapA_HCN.Text != "" && NhapB_HCN.Text != "")
                {//Phúc - chuyển đổi textbox qua số nguyên nè, trong đó a là chiều dài - b là chiều rộng
                    a = Convert.ToInt32(NhapA_HCN.Text);
                    b = Convert.ToInt32(NhapB_HCN.Text);
                    if (a > 0 && b > 0)
                    {
                        //Tính chu vi HCN: bằng giá trị gấp hai lần tổng chiều dài cộng chiều rộng, công thức P = (a + b) x 2
                        ChuVi_HCN.Text = Convert.ToString((a + b) * 2);
                        //Tính diện tích HCN: bằng tích của chiều dài nhân với chiều rộng, công thức S = a x b
                        DienTich_HCN.Text = Convert.ToString(a * b);
                    }
                    else MessageBox.Show("Bạn nhập sai. Vui lòng nhập số dương");
                }
                else MessageBox.Show("Vui lòng nhập giá trị A và B, hàm không được rỗng");
            }

            //Nếu checkbox = true thì thực hiện phép tính
            if (radio_HTG.Checked == true)
            {
                if (NhapA_HTG.Text != "" && NhapB_HTG.Text != "" && NhapC_HTG.Text != "")
                {   // a,b,c lần lượt là chiều dài 3 cạnh
                    //Phúc - Parse cũng là chuyển chuỗi thành kiểu dữ liệu, do không có Tofloat nên e dùng kiểu này để ép kiểu ^^
                    float a = float.Parse(NhapA_HTG.Text);
                    float b = float.Parse(NhapB_HTG.Text);
                    float c = float.Parse(NhapC_HTG.Text);
                    //bình phương độ dài các cạnh
                    x = a * a;
                    y = b * b;
                    z = c * c;
                    //Xét bất đẳng thức tam giác
                    if (a + b > c && a + c > b && b + c > a)
                    {
                        //Trong tam giác khi 2 trong 3 cạnh bằng nhau thì ta thực hiện cách xét cân và đều
                        if (x == y || y == z || z == x)
                        {
                            //Nếu tam giác đó có 3 cạnh với chiều dài bằng nhau thì gọi là tam giác đều.
                            if (x == y && y == z)
                                KiemTra_HTG.Text = ("Tam Giác Đều");
                            else
                            {
                                //Tam giác có bình phương độ dài 1 cạnh bằng tổng bình phương độ dài 2 cạnh kia là tam giác vuông(định lý Pytago đảo)
                                //trong đó có 2 cạnh lại bằng nhau
                                if (x == y + z || y == x + z || z == x + y)
                                    KiemTra_HTG.Text = ("Tam Giác Vuông Cân");
                                else
                                    //Nếu một hình tam giác có ít nhất 2 cạnh có chiều dài bằng nhau thì được xếp vào dạng tam giác cân.
                                    KiemTra_HTG.Text = ("Tam Giác Cân");
                            }
                        }

                        else
                        {
                            //Tam giác có bình phương độ dài 1 cạnh bằng tổng bình phương độ dài 2 cạnh kia là tam giác vuông(định lý Pytago đảo)
                            if (x == y + z || y == x + z || z == x + y)
                                KiemTra_HTG.Text = ("Tam Giác Vuông");
                            else
                                //Nếu một tam giác không có cạnh nào bằng nhau thì đó là tam giác thường
                                KiemTra_HTG.Text = ("Tam Giác Thường");
                        }
                        if (a > 0 && b > 0 && c > 0)
                        {
                            //p là nửa chu vi của tam giác, công thức p = 1/2(a+b+c)
                            P = (a + b + c) / 2;
                            //sử dụng công thức Heron, trong đó Math.Sqrt là lấy căn bậc 2
                            S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
                            ChuVi_HTG.Text = Convert.ToString(S);
                            DienTich_HTG.Text = Convert.ToString(P);
                        }
                        else MessageBox.Show("Bạn nhập sai. Vui lòng nhập số dương");
                    }
                    //Nếu 2 cạnh + không lớn hơn cạnh còn lại thì không tạo được tam giác vì ảo lắm
                    else KiemTra_HTG.Text = ("Ba cạnh không tạo thành tam giác");
                }
                else MessageBox.Show("Vui lòng nhập giá trị A B C, hàm không được rỗng");
            }
        }

        private void Tinh_Load(object sender, EventArgs e)
        {
            //Phúc - khi form chạy thì tắt hết group
            groupHV.Visible = false;
            groupHT.Visible = false;
            groupHTG.Visible = false;
            groupHCN.Visible = false;
            group_HienThi.Visible = false;
            btKiemtra.Enabled = false;
            btChuyendoi.Enabled = false;
        }

    }
}
