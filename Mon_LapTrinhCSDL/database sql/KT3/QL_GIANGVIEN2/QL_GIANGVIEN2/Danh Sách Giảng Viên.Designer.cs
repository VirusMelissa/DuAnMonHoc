
namespace QL_GIANGVIEN2
{
    partial class danhsachgiangvien
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
            this.bttimanh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtduongdan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txten = new System.Windows.Forms.TextBox();
            this.txtmagv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btthem = new System.Windows.Forms.Button();
            this.btcapnhat = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtngaysinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLCB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtheso = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.combo_makhoa = new System.Windows.Forms.ComboBox();
            this.qL_GIANGVIEN2DataSet = new QL_GIANGVIEN2.QL_GIANGVIEN2DataSet();
            this.gIANGVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIANGVIENTableAdapter = new QL_GIANGVIEN2.QL_GIANGVIEN2DataSetTableAdapters.GIANGVIENTableAdapter();
            this.mAGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAKHOADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYSINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lUONGCBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hESODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUONGDANANHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNHDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.qL_GIANGVIEN2DataSet1 = new QL_GIANGVIEN2.QL_GIANGVIEN2DataSet1();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new QL_GIANGVIEN2.QL_GIANGVIEN2DataSet1TableAdapters.KHOATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GIANGVIEN2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GIANGVIEN2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bttimanh
            // 
            this.bttimanh.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttimanh.Location = new System.Drawing.Point(734, 269);
            this.bttimanh.Name = "bttimanh";
            this.bttimanh.Size = new System.Drawing.Size(112, 38);
            this.bttimanh.TabIndex = 35;
            this.bttimanh.Text = "Tìm Ảnh";
            this.bttimanh.UseVisualStyleBackColor = true;
            this.bttimanh.Click += new System.EventHandler(this.bttimanh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAGVDataGridViewTextBoxColumn,
            this.mAKHOADataGridViewTextBoxColumn,
            this.hOTENDataGridViewTextBoxColumn,
            this.nGAYSINHDataGridViewTextBoxColumn,
            this.lUONGCBDataGridViewTextBoxColumn,
            this.hESODataGridViewTextBoxColumn,
            this.dUONGDANANHDataGridViewTextBoxColumn,
            this.aNHDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.gIANGVIENBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(70, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 150);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btsua
            // 
            this.btsua.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.Location = new System.Drawing.Point(440, 505);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(89, 38);
            this.btsua.TabIndex = 33;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Location = new System.Drawing.Point(256, 505);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(89, 38);
            this.btxoa.TabIndex = 32;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(701, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // txtduongdan
            // 
            this.txtduongdan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtduongdan.Location = new System.Drawing.Point(210, 298);
            this.txtduongdan.Name = "txtduongdan";
            this.txtduongdan.Size = new System.Drawing.Size(296, 27);
            this.txtduongdan.TabIndex = 30;
            this.txtduongdan.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Đường Dẫn Ảnh:";
            this.label4.Visible = false;
            // 
            // txten
            // 
            this.txten.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txten.Location = new System.Drawing.Point(424, 121);
            this.txten.Name = "txten";
            this.txten.Size = new System.Drawing.Size(255, 31);
            this.txten.TabIndex = 3;
            // 
            // txtmagv
            // 
            this.txtmagv.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmagv.Location = new System.Drawing.Point(210, 121);
            this.txtmagv.Name = "txtmagv";
            this.txtmagv.Size = new System.Drawing.Size(58, 31);
            this.txtmagv.TabIndex = 1;
            this.txtmagv.Leave += new System.EventHandler(this.txtmagv_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 26);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tên Giảng Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mã Giảng Viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(220, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 59);
            this.label1.TabIndex = 23;
            this.label1.Text = "DANH SÁCH GIẢNG VIÊN";
            // 
            // btthem
            // 
            this.btthem.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.Location = new System.Drawing.Point(70, 505);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(89, 38);
            this.btthem.TabIndex = 28;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btcapnhat
            // 
            this.btcapnhat.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcapnhat.Location = new System.Drawing.Point(624, 505);
            this.btcapnhat.Name = "btcapnhat";
            this.btcapnhat.Size = new System.Drawing.Size(120, 38);
            this.btcapnhat.TabIndex = 36;
            this.btcapnhat.Text = "Cập Nhật";
            this.btcapnhat.UseVisualStyleBackColor = true;
            this.btcapnhat.Click += new System.EventHandler(this.btcapnhat_Click);
            // 
            // btthoat
            // 
            this.btthoat.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.Location = new System.Drawing.Point(826, 505);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(89, 38);
            this.btthoat.TabIndex = 37;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 26);
            this.label5.TabIndex = 38;
            this.label5.Text = "Mã Khoa:";
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngaysinh.Location = new System.Drawing.Point(424, 178);
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(130, 31);
            this.txtngaysinh.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(314, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 26);
            this.label6.TabIndex = 40;
            this.label6.Text = "Ngày Sinh:";
            // 
            // txtLCB
            // 
            this.txtLCB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLCB.Location = new System.Drawing.Point(424, 232);
            this.txtLCB.Name = "txtLCB";
            this.txtLCB.Size = new System.Drawing.Size(130, 31);
            this.txtLCB.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(280, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 26);
            this.label7.TabIndex = 42;
            this.label7.Text = "Lương Cơ Bản:";
            // 
            // txtheso
            // 
            this.txtheso.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtheso.Location = new System.Drawing.Point(210, 234);
            this.txtheso.Name = "txtheso";
            this.txtheso.Size = new System.Drawing.Size(47, 31);
            this.txtheso.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(142, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 26);
            this.label8.TabIndex = 44;
            this.label8.Text = "Hệ Số:";
            // 
            // combo_makhoa
            // 
            this.combo_makhoa.DataSource = this.kHOABindingSource;
            this.combo_makhoa.DisplayMember = "MAKHOA";
            this.combo_makhoa.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_makhoa.FormattingEnabled = true;
            this.combo_makhoa.Location = new System.Drawing.Point(210, 179);
            this.combo_makhoa.Name = "combo_makhoa";
            this.combo_makhoa.Size = new System.Drawing.Size(58, 31);
            this.combo_makhoa.TabIndex = 2;
            this.combo_makhoa.ValueMember = "MAKHOA";
            this.combo_makhoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_makhoa_KeyPress);
            // 
            // qL_GIANGVIEN2DataSet
            // 
            this.qL_GIANGVIEN2DataSet.DataSetName = "QL_GIANGVIEN2DataSet";
            this.qL_GIANGVIEN2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIANGVIENBindingSource
            // 
            this.gIANGVIENBindingSource.DataMember = "GIANGVIEN";
            this.gIANGVIENBindingSource.DataSource = this.qL_GIANGVIEN2DataSet;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // mAGVDataGridViewTextBoxColumn
            // 
            this.mAGVDataGridViewTextBoxColumn.DataPropertyName = "MAGV";
            this.mAGVDataGridViewTextBoxColumn.HeaderText = "MAGV";
            this.mAGVDataGridViewTextBoxColumn.Name = "mAGVDataGridViewTextBoxColumn";
            // 
            // mAKHOADataGridViewTextBoxColumn
            // 
            this.mAKHOADataGridViewTextBoxColumn.DataPropertyName = "MAKHOA";
            this.mAKHOADataGridViewTextBoxColumn.HeaderText = "MAKHOA";
            this.mAKHOADataGridViewTextBoxColumn.Name = "mAKHOADataGridViewTextBoxColumn";
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
            // lUONGCBDataGridViewTextBoxColumn
            // 
            this.lUONGCBDataGridViewTextBoxColumn.DataPropertyName = "LUONGCB";
            this.lUONGCBDataGridViewTextBoxColumn.HeaderText = "LUONGCB";
            this.lUONGCBDataGridViewTextBoxColumn.Name = "lUONGCBDataGridViewTextBoxColumn";
            // 
            // hESODataGridViewTextBoxColumn
            // 
            this.hESODataGridViewTextBoxColumn.DataPropertyName = "HESO";
            this.hESODataGridViewTextBoxColumn.HeaderText = "HESO";
            this.hESODataGridViewTextBoxColumn.Name = "hESODataGridViewTextBoxColumn";
            // 
            // dUONGDANANHDataGridViewTextBoxColumn
            // 
            this.dUONGDANANHDataGridViewTextBoxColumn.DataPropertyName = "DUONGDANANH";
            this.dUONGDANANHDataGridViewTextBoxColumn.HeaderText = "DUONGDANANH";
            this.dUONGDANANHDataGridViewTextBoxColumn.Name = "dUONGDANANHDataGridViewTextBoxColumn";
            this.dUONGDANANHDataGridViewTextBoxColumn.Visible = false;
            // 
            // aNHDataGridViewImageColumn
            // 
            this.aNHDataGridViewImageColumn.DataPropertyName = "ANH";
            this.aNHDataGridViewImageColumn.HeaderText = "ANH";
            this.aNHDataGridViewImageColumn.Name = "aNHDataGridViewImageColumn";
            this.aNHDataGridViewImageColumn.Visible = false;
            // 
            // qL_GIANGVIEN2DataSet1
            // 
            this.qL_GIANGVIEN2DataSet1.DataSetName = "QL_GIANGVIEN2DataSet1";
            this.qL_GIANGVIEN2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.qL_GIANGVIEN2DataSet1;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // danhsachgiangvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 572);
            this.Controls.Add(this.combo_makhoa);
            this.Controls.Add(this.txtheso);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLCB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtngaysinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btcapnhat);
            this.Controls.Add(this.bttimanh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtduongdan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txten);
            this.Controls.Add(this.txtmagv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btthem);
            this.Name = "danhsachgiangvien";
            this.Text = "Danh Sách Giảng Viên";
            this.Load += new System.EventHandler(this.danhsachgiangvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GIANGVIEN2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GIANGVIEN2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttimanh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtduongdan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txten;
        private System.Windows.Forms.TextBox txtmagv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btcapnhat;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtngaysinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtheso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combo_makhoa;
        private QL_GIANGVIEN2DataSet qL_GIANGVIEN2DataSet;
        private System.Windows.Forms.BindingSource gIANGVIENBindingSource;
        private QL_GIANGVIEN2DataSetTableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHOADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOTENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYSINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lUONGCBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hESODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dUONGDANANHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn aNHDataGridViewImageColumn;
        private QL_GIANGVIEN2DataSet1 qL_GIANGVIEN2DataSet1;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private QL_GIANGVIEN2DataSet1TableAdapters.KHOATableAdapter kHOATableAdapter;
    }
}