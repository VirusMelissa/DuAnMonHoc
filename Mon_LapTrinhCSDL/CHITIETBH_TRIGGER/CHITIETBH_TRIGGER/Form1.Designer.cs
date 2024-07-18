
namespace CHITIETBH_TRIGGER
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.combo_chonsohd = new System.Windows.Forms.ComboBox();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH_1004_TESTDataSet2 = new CHITIETBH_TRIGGER.QLBH_1004_TESTDataSet2();
            this.label8 = new System.Windows.Forms.Label();
            this.btthem = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txtsohd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btdong = new System.Windows.Forms.Button();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOCSINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sOHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mASPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHANHTIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aBCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH_1004_TESTDataSet = new CHITIETBH_TRIGGER.QLBH_1004_TESTDataSet();
            this.bttim = new System.Windows.Forms.Button();
            this.btcapnhat = new System.Windows.Forms.Button();
            this.aBCTableAdapter = new CHITIETBH_TRIGGER.QLBH_1004_TESTDataSetTableAdapters.ABCTableAdapter();
            this.combo_masp = new System.Windows.Forms.ComboBox();
            this.sANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH_1004_TESTDataSet1 = new CHITIETBH_TRIGGER.QLBH_1004_TESTDataSet1();
            this.sANPHAMTableAdapter = new CHITIETBH_TRIGGER.QLBH_1004_TESTDataSet1TableAdapters.SANPHAMTableAdapter();
            this.hOADONTableAdapter = new CHITIETBH_TRIGGER.QLBH_1004_TESTDataSet2TableAdapters.HOADONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_1004_TESTDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCSINHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_1004_TESTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_1004_TESTDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_chonsohd
            // 
            this.combo_chonsohd.DataSource = this.hOADONBindingSource;
            this.combo_chonsohd.DisplayMember = "SOHD";
            this.combo_chonsohd.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.combo_chonsohd.FormattingEnabled = true;
            this.combo_chonsohd.Location = new System.Drawing.Point(260, 261);
            this.combo_chonsohd.Name = "combo_chonsohd";
            this.combo_chonsohd.Size = new System.Drawing.Size(121, 31);
            this.combo_chonsohd.TabIndex = 51;
            this.combo_chonsohd.ValueMember = "SOHD";
            this.combo_chonsohd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_chonsohd_KeyPress);
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataMember = "HOADON";
            this.hOADONBindingSource.DataSource = this.qLBH_1004_TESTDataSet2;
            // 
            // qLBH_1004_TESTDataSet2
            // 
            this.qLBH_1004_TESTDataSet2.DataSetName = "QLBH_1004_TESTDataSet2";
            this.qLBH_1004_TESTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 26);
            this.label8.TabIndex = 50;
            this.label8.Text = "Nhập số hóa đơn:";
            // 
            // btthem
            // 
            this.btthem.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.Location = new System.Drawing.Point(57, 534);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(93, 34);
            this.btthem.TabIndex = 49;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Location = new System.Drawing.Point(180, 534);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(95, 34);
            this.btxoa.TabIndex = 48;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.Location = new System.Drawing.Point(313, 534);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(92, 34);
            this.btsua.TabIndex = 47;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // txtdongia
            // 
            this.txtdongia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdongia.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.txtdongia.Location = new System.Drawing.Point(506, 108);
            this.txtdongia.MaxLength = 10;
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(157, 31);
            this.txtdongia.TabIndex = 4;
            this.txtdongia.Tag = "4";
            this.txtdongia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtdongia_MouseClick);
            this.txtdongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdongia_KeyPress);
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.txtthanhtien.Location = new System.Drawing.Point(506, 149);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.Size = new System.Drawing.Size(157, 31);
            this.txtthanhtien.TabIndex = 5;
            this.txtthanhtien.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtthanhtien_MouseClick);
            this.txtthanhtien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtthanhtien_KeyPress);
            // 
            // txtsl
            // 
            this.txtsl.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.txtsl.Location = new System.Drawing.Point(201, 194);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(100, 31);
            this.txtsl.TabIndex = 3;
            this.txtsl.Tag = "3";
            // 
            // txtsohd
            // 
            this.txtsohd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsohd.Location = new System.Drawing.Point(201, 106);
            this.txtsohd.Name = "txtsohd";
            this.txtsohd.Size = new System.Drawing.Size(100, 31);
            this.txtsohd.TabIndex = 1;
            this.txtsohd.Tag = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 26);
            this.label7.TabIndex = 44;
            this.label7.Text = "Mã Sản Phẩm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(388, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 26);
            this.label6.TabIndex = 43;
            this.label6.Text = "Thành Tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 26);
            this.label4.TabIndex = 41;
            this.label4.Text = "Đơn Giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 26);
            this.label2.TabIndex = 39;
            this.label2.Text = "Số Hóa Đơn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(179, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 59);
            this.label1.TabIndex = 36;
            this.label1.Text = "CHI TIẾT BÁN HÀNG";
            // 
            // btdong
            // 
            this.btdong.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdong.Location = new System.Drawing.Point(599, 534);
            this.btdong.Name = "btdong";
            this.btdong.Size = new System.Drawing.Size(99, 34);
            this.btdong.TabIndex = 38;
            this.btdong.Text = "Đóng";
            this.btdong.UseVisualStyleBackColor = true;
            this.btdong.Click += new System.EventHandler(this.btdong_Click);
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            // 
            // hOCSINHBindingSource
            // 
            this.hOCSINHBindingSource.DataMember = "HOCSINH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 26);
            this.label3.TabIndex = 40;
            this.label3.Text = "Số Lượng:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sOHDDataGridViewTextBoxColumn,
            this.mASPDataGridViewTextBoxColumn,
            this.sLDataGridViewTextBoxColumn,
            this.gIADataGridViewTextBoxColumn,
            this.tHANHTIENDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aBCBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(57, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 191);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // sOHDDataGridViewTextBoxColumn
            // 
            this.sOHDDataGridViewTextBoxColumn.DataPropertyName = "SOHD";
            this.sOHDDataGridViewTextBoxColumn.HeaderText = "SOHD";
            this.sOHDDataGridViewTextBoxColumn.Name = "sOHDDataGridViewTextBoxColumn";
            // 
            // mASPDataGridViewTextBoxColumn
            // 
            this.mASPDataGridViewTextBoxColumn.DataPropertyName = "MASP";
            this.mASPDataGridViewTextBoxColumn.HeaderText = "MASP";
            this.mASPDataGridViewTextBoxColumn.Name = "mASPDataGridViewTextBoxColumn";
            // 
            // sLDataGridViewTextBoxColumn
            // 
            this.sLDataGridViewTextBoxColumn.DataPropertyName = "SL";
            this.sLDataGridViewTextBoxColumn.HeaderText = "SL";
            this.sLDataGridViewTextBoxColumn.Name = "sLDataGridViewTextBoxColumn";
            // 
            // gIADataGridViewTextBoxColumn
            // 
            this.gIADataGridViewTextBoxColumn.DataPropertyName = "GIA";
            this.gIADataGridViewTextBoxColumn.HeaderText = "GIA";
            this.gIADataGridViewTextBoxColumn.Name = "gIADataGridViewTextBoxColumn";
            // 
            // tHANHTIENDataGridViewTextBoxColumn
            // 
            this.tHANHTIENDataGridViewTextBoxColumn.DataPropertyName = "THANHTIEN";
            this.tHANHTIENDataGridViewTextBoxColumn.HeaderText = "THANHTIEN";
            this.tHANHTIENDataGridViewTextBoxColumn.Name = "tHANHTIENDataGridViewTextBoxColumn";
            this.tHANHTIENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aBCBindingSource
            // 
            this.aBCBindingSource.DataMember = "ABC";
            this.aBCBindingSource.DataSource = this.qLBH_1004_TESTDataSet;
            // 
            // qLBH_1004_TESTDataSet
            // 
            this.qLBH_1004_TESTDataSet.DataSetName = "QLBH_1004_TESTDataSet";
            this.qLBH_1004_TESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bttim
            // 
            this.bttim.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttim.Location = new System.Drawing.Point(405, 258);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(120, 34);
            this.bttim.TabIndex = 52;
            this.bttim.Text = "Tìm";
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            // 
            // btcapnhat
            // 
            this.btcapnhat.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcapnhat.Location = new System.Drawing.Point(444, 534);
            this.btcapnhat.Name = "btcapnhat";
            this.btcapnhat.Size = new System.Drawing.Size(105, 34);
            this.btcapnhat.TabIndex = 54;
            this.btcapnhat.Text = "Cập Nhật";
            this.btcapnhat.UseVisualStyleBackColor = true;
            this.btcapnhat.Click += new System.EventHandler(this.btcapnhat_Click);
            // 
            // aBCTableAdapter
            // 
            this.aBCTableAdapter.ClearBeforeFill = true;
            // 
            // combo_masp
            // 
            this.combo_masp.DataSource = this.sANPHAMBindingSource;
            this.combo_masp.DisplayMember = "MASP";
            this.combo_masp.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.combo_masp.FormattingEnabled = true;
            this.combo_masp.Location = new System.Drawing.Point(201, 149);
            this.combo_masp.Name = "combo_masp";
            this.combo_masp.Size = new System.Drawing.Size(100, 31);
            this.combo_masp.TabIndex = 55;
            this.combo_masp.ValueMember = "MASP";
            this.combo_masp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_masp_KeyPress);
            // 
            // sANPHAMBindingSource
            // 
            this.sANPHAMBindingSource.DataMember = "SANPHAM";
            this.sANPHAMBindingSource.DataSource = this.qLBH_1004_TESTDataSet1;
            // 
            // qLBH_1004_TESTDataSet1
            // 
            this.qLBH_1004_TESTDataSet1.DataSetName = "QLBH_1004_TESTDataSet1";
            this.qLBH_1004_TESTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sANPHAMTableAdapter
            // 
            this.sANPHAMTableAdapter.ClearBeforeFill = true;
            // 
            // hOADONTableAdapter
            // 
            this.hOADONTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 580);
            this.Controls.Add(this.combo_masp);
            this.Controls.Add(this.btcapnhat);
            this.Controls.Add(this.bttim);
            this.Controls.Add(this.combo_chonsohd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(this.txtthanhtien);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.txtsohd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btdong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_1004_TESTDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCSINHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_1004_TESTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_1004_TESTDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_chonsohd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox txtsohd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btdong;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private System.Windows.Forms.BindingSource hOCSINHBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Button btcapnhat;
        private QLBH_1004_TESTDataSet qLBH_1004_TESTDataSet;
        private System.Windows.Forms.BindingSource aBCBindingSource;
        private QLBH_1004_TESTDataSetTableAdapters.ABCTableAdapter aBCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHANHTIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox combo_masp;
        private QLBH_1004_TESTDataSet1 qLBH_1004_TESTDataSet1;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource;
        private QLBH_1004_TESTDataSet1TableAdapters.SANPHAMTableAdapter sANPHAMTableAdapter;
        private QLBH_1004_TESTDataSet2 qLBH_1004_TESTDataSet2;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private QLBH_1004_TESTDataSet2TableAdapters.HOADONTableAdapter hOADONTableAdapter;
    }
}

