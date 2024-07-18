
namespace QLNV
{
    partial class danhsach
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
            this.combo_phong = new System.Windows.Forms.ComboBox();
            this.combo_chonphong = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btthem = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.bttimanh = new System.Windows.Forms.Button();
            this.txtngaysinh = new System.Windows.Forms.TextBox();
            this.txtduongdan = new System.Windows.Forms.TextBox();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btdong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txttongluong = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.qLNVDataSet = new QLNV.QLNVDataSet();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new QLNV.QLNVDataSetTableAdapters.NHANVIENTableAdapter();
            this.qLNVDataSet1 = new QLNV.QLNVDataSet1();
            this.nHANVIENBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter1 = new QLNV.QLNVDataSet1TableAdapters.NHANVIENTableAdapter();
            this.mANVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAPHGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYSINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMPATHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNHDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.qLNVDataSet2 = new QLNV.QLNVDataSet2();
            this.nHANVIENBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter2 = new QLNV.QLNVDataSet2TableAdapters.NHANVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_phong
            // 
            this.combo_phong.DataSource = this.nHANVIENBindingSource;
            this.combo_phong.DisplayMember = "MAPHG";
            this.combo_phong.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.combo_phong.FormattingEnabled = true;
            this.combo_phong.Location = new System.Drawing.Point(201, 150);
            this.combo_phong.Name = "combo_phong";
            this.combo_phong.Size = new System.Drawing.Size(100, 31);
            this.combo_phong.TabIndex = 31;
            this.combo_phong.ValueMember = "MAPHG";
            this.combo_phong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_phong_KeyPress);
            // 
            // combo_chonphong
            // 
            this.combo_chonphong.DataSource = this.nHANVIENBindingSource2;
            this.combo_chonphong.DisplayMember = "MAPHG";
            this.combo_chonphong.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.combo_chonphong.FormattingEnabled = true;
            this.combo_chonphong.Location = new System.Drawing.Point(229, 470);
            this.combo_chonphong.Name = "combo_chonphong";
            this.combo_chonphong.Size = new System.Drawing.Size(121, 31);
            this.combo_chonphong.TabIndex = 51;
            this.combo_chonphong.ValueMember = "MAPHG";
            this.combo_chonphong.SelectedIndexChanged += new System.EventHandler(this.combo_chonphong_SelectedIndexChanged);
            this.combo_chonphong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_chonphong_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 471);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 26);
            this.label8.TabIndex = 50;
            this.label8.Text = "Chọn Mã Phòng:";
            // 
            // btthem
            // 
            this.btthem.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.Location = new System.Drawing.Point(201, 243);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(120, 34);
            this.btthem.TabIndex = 49;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Location = new System.Drawing.Point(369, 243);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(120, 34);
            this.btxoa.TabIndex = 48;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.Location = new System.Drawing.Point(529, 243);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(120, 34);
            this.btsua.TabIndex = 47;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // bttimanh
            // 
            this.bttimanh.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttimanh.Location = new System.Drawing.Point(692, 243);
            this.bttimanh.Name = "bttimanh";
            this.bttimanh.Size = new System.Drawing.Size(120, 34);
            this.bttimanh.TabIndex = 35;
            this.bttimanh.Tag = "6";
            this.bttimanh.Text = "Tìm Ảnh";
            this.bttimanh.UseVisualStyleBackColor = true;
            this.bttimanh.Click += new System.EventHandler(this.bttimanh_Click);
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtngaysinh.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.txtngaysinh.Location = new System.Drawing.Point(505, 107);
            this.txtngaysinh.MaxLength = 10;
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(126, 31);
            this.txtngaysinh.TabIndex = 33;
            this.txtngaysinh.Tag = "4";
            // 
            // txtduongdan
            // 
            this.txtduongdan.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.txtduongdan.Location = new System.Drawing.Point(505, 191);
            this.txtduongdan.Name = "txtduongdan";
            this.txtduongdan.Size = new System.Drawing.Size(157, 31);
            this.txtduongdan.TabIndex = 46;
            this.txtduongdan.Visible = false;
            // 
            // txtluong
            // 
            this.txtluong.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.txtluong.Location = new System.Drawing.Point(505, 150);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(157, 31);
            this.txtluong.TabIndex = 34;
            this.txtluong.Tag = "5";
            // 
            // txthoten
            // 
            this.txthoten.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.txthoten.Location = new System.Drawing.Point(201, 194);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(214, 31);
            this.txthoten.TabIndex = 32;
            this.txthoten.Tag = "3";
            // 
            // txtmanv
            // 
            this.txtmanv.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanv.Location = new System.Drawing.Point(201, 106);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(100, 31);
            this.txtmanv.TabIndex = 30;
            this.txtmanv.Tag = "1";
            // 
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture.Location = new System.Drawing.Point(684, 87);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(134, 147);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 45;
            this.picture.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 26);
            this.label7.TabIndex = 44;
            this.label7.Text = "Mã Phòng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(426, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 26);
            this.label5.TabIndex = 42;
            this.label5.Text = "Lương:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 26);
            this.label4.TabIndex = 41;
            this.label4.Text = "Ngày Sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 26);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mã Nhân Viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(191, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 59);
            this.label1.TabIndex = 36;
            this.label1.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // btdong
            // 
            this.btdong.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdong.Location = new System.Drawing.Point(698, 470);
            this.btdong.Name = "btdong";
            this.btdong.Size = new System.Drawing.Size(120, 34);
            this.btdong.TabIndex = 38;
            this.btdong.Text = "Đóng";
            this.btdong.UseVisualStyleBackColor = true;
            this.btdong.Click += new System.EventHandler(this.btdong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 40;
            this.label3.Text = "Họ Tên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(395, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 26);
            this.label6.TabIndex = 52;
            this.label6.Text = "Tổng Lương:";
            // 
            // txttongluong
            // 
            this.txttongluong.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.txttongluong.Location = new System.Drawing.Point(519, 470);
            this.txttongluong.Name = "txttongluong";
            this.txttongluong.Size = new System.Drawing.Size(157, 31);
            this.txttongluong.TabIndex = 53;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mANVDataGridViewTextBoxColumn,
            this.mAPHGDataGridViewTextBoxColumn,
            this.hOTENDataGridViewTextBoxColumn,
            this.nGAYSINHDataGridViewTextBoxColumn,
            this.lUONGDataGridViewTextBoxColumn,
            this.iMPATHDataGridViewTextBoxColumn,
            this.aNHDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.nHANVIENBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(84, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(733, 160);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(84, 309);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(731, 149);
            this.dataGridView2.TabIndex = 55;
            this.dataGridView2.Visible = false;
            // 
            // qLNVDataSet
            // 
            this.qLNVDataSet.DataSetName = "QLNVDataSet";
            this.qLNVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.qLNVDataSet;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // qLNVDataSet1
            // 
            this.qLNVDataSet1.DataSetName = "QLNVDataSet1";
            this.qLNVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENBindingSource1
            // 
            this.nHANVIENBindingSource1.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource1.DataSource = this.qLNVDataSet1;
            // 
            // nHANVIENTableAdapter1
            // 
            this.nHANVIENTableAdapter1.ClearBeforeFill = true;
            // 
            // mANVDataGridViewTextBoxColumn
            // 
            this.mANVDataGridViewTextBoxColumn.DataPropertyName = "MANV";
            this.mANVDataGridViewTextBoxColumn.HeaderText = "MANV";
            this.mANVDataGridViewTextBoxColumn.Name = "mANVDataGridViewTextBoxColumn";
            // 
            // mAPHGDataGridViewTextBoxColumn
            // 
            this.mAPHGDataGridViewTextBoxColumn.DataPropertyName = "MAPHG";
            this.mAPHGDataGridViewTextBoxColumn.HeaderText = "MAPHG";
            this.mAPHGDataGridViewTextBoxColumn.Name = "mAPHGDataGridViewTextBoxColumn";
            // 
            // hOTENDataGridViewTextBoxColumn
            // 
            this.hOTENDataGridViewTextBoxColumn.DataPropertyName = "HOTEN";
            this.hOTENDataGridViewTextBoxColumn.HeaderText = "HOTEN";
            this.hOTENDataGridViewTextBoxColumn.Name = "hOTENDataGridViewTextBoxColumn";
            // 
            // nGAYSINHDataGridViewTextBoxColumn
            // 
            this.nGAYSINHDataGridViewTextBoxColumn.DataPropertyName = "NGAYSINH";
            this.nGAYSINHDataGridViewTextBoxColumn.HeaderText = "NGAYSINH";
            this.nGAYSINHDataGridViewTextBoxColumn.Name = "nGAYSINHDataGridViewTextBoxColumn";
            // 
            // lUONGDataGridViewTextBoxColumn
            // 
            this.lUONGDataGridViewTextBoxColumn.DataPropertyName = "LUONG";
            this.lUONGDataGridViewTextBoxColumn.HeaderText = "LUONG";
            this.lUONGDataGridViewTextBoxColumn.Name = "lUONGDataGridViewTextBoxColumn";
            // 
            // iMPATHDataGridViewTextBoxColumn
            // 
            this.iMPATHDataGridViewTextBoxColumn.DataPropertyName = "IMPATH";
            this.iMPATHDataGridViewTextBoxColumn.HeaderText = "IMPATH";
            this.iMPATHDataGridViewTextBoxColumn.Name = "iMPATHDataGridViewTextBoxColumn";
            this.iMPATHDataGridViewTextBoxColumn.Visible = false;
            // 
            // aNHDataGridViewImageColumn
            // 
            this.aNHDataGridViewImageColumn.DataPropertyName = "ANH";
            this.aNHDataGridViewImageColumn.HeaderText = "ANH";
            this.aNHDataGridViewImageColumn.Name = "aNHDataGridViewImageColumn";
            this.aNHDataGridViewImageColumn.Visible = false;
            // 
            // qLNVDataSet2
            // 
            this.qLNVDataSet2.DataSetName = "QLNVDataSet2";
            this.qLNVDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENBindingSource2
            // 
            this.nHANVIENBindingSource2.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource2.DataSource = this.qLNVDataSet2;
            // 
            // nHANVIENTableAdapter2
            // 
            this.nHANVIENTableAdapter2.ClearBeforeFill = true;
            // 
            // danhsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 528);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txttongluong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combo_phong);
            this.Controls.Add(this.combo_chonphong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.bttimanh);
            this.Controls.Add(this.txtngaysinh);
            this.Controls.Add(this.txtduongdan);
            this.Controls.Add(this.txtluong);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btdong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Name = "danhsach";
            this.Text = "Danh Sách Nhân Viên";
            this.Load += new System.EventHandler(this.danhsach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_phong;
        private System.Windows.Forms.ComboBox combo_chonphong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button bttimanh;
        private System.Windows.Forms.TextBox txtngaysinh;
        private System.Windows.Forms.TextBox txtduongdan;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btdong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttongluong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private QLNVDataSet qLNVDataSet;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private QLNVDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private QLNVDataSet1 qLNVDataSet1;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource1;
        private QLNVDataSet1TableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAPHGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOTENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYSINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMPATHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn aNHDataGridViewImageColumn;
        private QLNVDataSet2 qLNVDataSet2;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource2;
        private QLNVDataSet2TableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter2;
    }
}