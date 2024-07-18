
namespace KT2_GIANGVIEN_TRIGGER
{
    partial class quanlygiangvien
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
            this.combo_mamh = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_GIANGVIENDataSet2 = new KT2_GIANGVIEN_TRIGGER.QL_GIANGVIENDataSet2();
            this.btcapnhat = new System.Windows.Forms.Button();
            this.bttim = new System.Windows.Forms.Button();
            this.combo_chonmagv = new System.Windows.Forms.ComboBox();
            this.gIANGVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_GIANGVIENDataSet1 = new KT2_GIANGVIEN_TRIGGER.QL_GIANGVIENDataSet1();
            this.label8 = new System.Windows.Forms.Label();
            this.btthem = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txttenmonhoc = new System.Windows.Forms.TextBox();
            this.txtmagv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btdong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mAGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mALOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENLOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOGIODAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aBCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_GIANGVIENDataSet = new KT2_GIANGVIEN_TRIGGER.QL_GIANGVIENDataSet();
            this.aBCTableAdapter = new KT2_GIANGVIEN_TRIGGER.QL_GIANGVIENDataSetTableAdapters.ABCTableAdapter();
            this.txtsogioday = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txttenlop = new System.Windows.Forms.TextBox();
            this.combo_malop = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_GIANGVIENDataSet3 = new KT2_GIANGVIEN_TRIGGER.QL_GIANGVIENDataSet3();
            this.gIANGVIENTableAdapter = new KT2_GIANGVIEN_TRIGGER.QL_GIANGVIENDataSet1TableAdapters.GIANGVIENTableAdapter();
            this.mONHOCTableAdapter = new KT2_GIANGVIEN_TRIGGER.QL_GIANGVIENDataSet2TableAdapters.MONHOCTableAdapter();
            this.lOPTableAdapter = new KT2_GIANGVIEN_TRIGGER.QL_GIANGVIENDataSet3TableAdapters.LOPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GIANGVIENDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GIANGVIENDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GIANGVIENDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GIANGVIENDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_mamh
            // 
            this.combo_mamh.DataSource = this.mONHOCBindingSource;
            this.combo_mamh.DisplayMember = "MAMH";
            this.combo_mamh.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.combo_mamh.FormattingEnabled = true;
            this.combo_mamh.Location = new System.Drawing.Point(245, 145);
            this.combo_mamh.Name = "combo_mamh";
            this.combo_mamh.Size = new System.Drawing.Size(100, 31);
            this.combo_mamh.TabIndex = 2;
            this.combo_mamh.ValueMember = "MAMH";
            this.combo_mamh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_mamh_KeyPress);
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qL_GIANGVIENDataSet2;
            // 
            // qL_GIANGVIENDataSet2
            // 
            this.qL_GIANGVIENDataSet2.DataSetName = "QL_GIANGVIENDataSet2";
            this.qL_GIANGVIENDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btcapnhat
            // 
            this.btcapnhat.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcapnhat.Location = new System.Drawing.Point(769, 532);
            this.btcapnhat.Name = "btcapnhat";
            this.btcapnhat.Size = new System.Drawing.Size(105, 34);
            this.btcapnhat.TabIndex = 74;
            this.btcapnhat.Text = "Cập Nhật";
            this.btcapnhat.UseVisualStyleBackColor = true;
            this.btcapnhat.Click += new System.EventHandler(this.btcapnhat_Click);
            // 
            // bttim
            // 
            this.bttim.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttim.Location = new System.Drawing.Point(389, 532);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(79, 34);
            this.bttim.TabIndex = 73;
            this.bttim.Text = "Tìm";
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            // 
            // combo_chonmagv
            // 
            this.combo_chonmagv.DataSource = this.gIANGVIENBindingSource;
            this.combo_chonmagv.DisplayMember = "MAGV";
            this.combo_chonmagv.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.combo_chonmagv.FormattingEnabled = true;
            this.combo_chonmagv.Location = new System.Drawing.Point(282, 533);
            this.combo_chonmagv.Name = "combo_chonmagv";
            this.combo_chonmagv.Size = new System.Drawing.Size(101, 31);
            this.combo_chonmagv.TabIndex = 72;
            this.combo_chonmagv.ValueMember = "MAGV";
            this.combo_chonmagv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_chonsohd_KeyPress);
            // 
            // gIANGVIENBindingSource
            // 
            this.gIANGVIENBindingSource.DataMember = "GIANGVIEN";
            this.gIANGVIENBindingSource.DataSource = this.qL_GIANGVIENDataSet1;
            // 
            // qL_GIANGVIENDataSet1
            // 
            this.qL_GIANGVIENDataSet1.DataSetName = "QL_GIANGVIENDataSet1";
            this.qL_GIANGVIENDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 534);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 26);
            this.label8.TabIndex = 71;
            this.label8.Text = "Nhập mã giảng viên:";
            // 
            // btthem
            // 
            this.btthem.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.Location = new System.Drawing.Point(505, 532);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(80, 34);
            this.btthem.TabIndex = 70;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Location = new System.Drawing.Point(601, 532);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(60, 34);
            this.btxoa.TabIndex = 69;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.Location = new System.Drawing.Point(679, 532);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(71, 34);
            this.btsua.TabIndex = 68;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // txthoten
            // 
            this.txthoten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthoten.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.txthoten.Location = new System.Drawing.Point(619, 102);
            this.txthoten.MaxLength = 10;
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(264, 31);
            this.txthoten.TabIndex = 58;
            this.txthoten.Tag = "4";
            this.txthoten.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txthoten_MouseClick);
            this.txthoten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txthoten_KeyPress);
            // 
            // txttenmonhoc
            // 
            this.txttenmonhoc.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.txttenmonhoc.Location = new System.Drawing.Point(619, 146);
            this.txttenmonhoc.Name = "txttenmonhoc";
            this.txttenmonhoc.Size = new System.Drawing.Size(264, 31);
            this.txttenmonhoc.TabIndex = 59;
            this.txttenmonhoc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txttenmonhoc_MouseClick);
            this.txttenmonhoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttenmonhoc_KeyPress);
            // 
            // txtmagv
            // 
            this.txtmagv.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmagv.Location = new System.Drawing.Point(245, 103);
            this.txtmagv.Name = "txtmagv";
            this.txtmagv.Size = new System.Drawing.Size(100, 31);
            this.txtmagv.TabIndex = 1;
            this.txtmagv.Tag = "1";
            this.txtmagv.Leave += new System.EventHandler(this.txtmagv_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(110, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 26);
            this.label7.TabIndex = 67;
            this.label7.Text = "Mã Môn Học:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(483, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 26);
            this.label6.TabIndex = 66;
            this.label6.Text = "Tên Môn Học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(440, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 26);
            this.label4.TabIndex = 65;
            this.label4.Text = "Họ Tên Giảng Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 26);
            this.label2.TabIndex = 63;
            this.label2.Text = "Mã Giảng Viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 59);
            this.label1.TabIndex = 60;
            this.label1.Text = "QUẢN LÝ GIẢNG VIÊN";
            // 
            // btdong
            // 
            this.btdong.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdong.Location = new System.Drawing.Point(888, 532);
            this.btdong.Name = "btdong";
            this.btdong.Size = new System.Drawing.Size(74, 34);
            this.btdong.TabIndex = 62;
            this.btdong.Text = "Đóng";
            this.btdong.UseVisualStyleBackColor = true;
            this.btdong.Click += new System.EventHandler(this.btdong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 26);
            this.label3.TabIndex = 64;
            this.label3.Text = "Mã Lớp:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAGVDataGridViewTextBoxColumn,
            this.hOTENDataGridViewTextBoxColumn,
            this.mAMHDataGridViewTextBoxColumn,
            this.tENMHDataGridViewTextBoxColumn,
            this.mALOPDataGridViewTextBoxColumn,
            this.tENLOPDataGridViewTextBoxColumn,
            this.sOGIODAYDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aBCBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(84, 316);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(878, 191);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // mAGVDataGridViewTextBoxColumn
            // 
            this.mAGVDataGridViewTextBoxColumn.DataPropertyName = "MAGV";
            this.mAGVDataGridViewTextBoxColumn.HeaderText = "MAGV";
            this.mAGVDataGridViewTextBoxColumn.Name = "mAGVDataGridViewTextBoxColumn";
            // 
            // hOTENDataGridViewTextBoxColumn
            // 
            this.hOTENDataGridViewTextBoxColumn.DataPropertyName = "HOTEN";
            this.hOTENDataGridViewTextBoxColumn.HeaderText = "HOTEN";
            this.hOTENDataGridViewTextBoxColumn.Name = "hOTENDataGridViewTextBoxColumn";
            // 
            // mAMHDataGridViewTextBoxColumn
            // 
            this.mAMHDataGridViewTextBoxColumn.DataPropertyName = "MAMH";
            this.mAMHDataGridViewTextBoxColumn.HeaderText = "MAMH";
            this.mAMHDataGridViewTextBoxColumn.Name = "mAMHDataGridViewTextBoxColumn";
            // 
            // tENMHDataGridViewTextBoxColumn
            // 
            this.tENMHDataGridViewTextBoxColumn.DataPropertyName = "TENMH";
            this.tENMHDataGridViewTextBoxColumn.HeaderText = "TENMH";
            this.tENMHDataGridViewTextBoxColumn.Name = "tENMHDataGridViewTextBoxColumn";
            // 
            // mALOPDataGridViewTextBoxColumn
            // 
            this.mALOPDataGridViewTextBoxColumn.DataPropertyName = "MALOP";
            this.mALOPDataGridViewTextBoxColumn.HeaderText = "MALOP";
            this.mALOPDataGridViewTextBoxColumn.Name = "mALOPDataGridViewTextBoxColumn";
            // 
            // tENLOPDataGridViewTextBoxColumn
            // 
            this.tENLOPDataGridViewTextBoxColumn.DataPropertyName = "TENLOP";
            this.tENLOPDataGridViewTextBoxColumn.HeaderText = "TENLOP";
            this.tENLOPDataGridViewTextBoxColumn.Name = "tENLOPDataGridViewTextBoxColumn";
            // 
            // sOGIODAYDataGridViewTextBoxColumn
            // 
            this.sOGIODAYDataGridViewTextBoxColumn.DataPropertyName = "SOGIODAY";
            this.sOGIODAYDataGridViewTextBoxColumn.HeaderText = "SOGIODAY";
            this.sOGIODAYDataGridViewTextBoxColumn.Name = "sOGIODAYDataGridViewTextBoxColumn";
            // 
            // aBCBindingSource
            // 
            this.aBCBindingSource.DataMember = "ABC";
            this.aBCBindingSource.DataSource = this.qL_GIANGVIENDataSet;
            // 
            // qL_GIANGVIENDataSet
            // 
            this.qL_GIANGVIENDataSet.DataSetName = "QL_GIANGVIENDataSet";
            this.qL_GIANGVIENDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aBCTableAdapter
            // 
            this.aBCTableAdapter.ClearBeforeFill = true;
            // 
            // txtsogioday
            // 
            this.txtsogioday.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.txtsogioday.Location = new System.Drawing.Point(245, 251);
            this.txtsogioday.Name = "txtsogioday";
            this.txtsogioday.Size = new System.Drawing.Size(100, 31);
            this.txtsogioday.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 26);
            this.label5.TabIndex = 77;
            this.label5.Text = "Số Giờ Dạy:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(529, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 26);
            this.label9.TabIndex = 78;
            this.label9.Text = "Tên Lớp:";
            // 
            // txttenlop
            // 
            this.txttenlop.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.txttenlop.Location = new System.Drawing.Point(619, 187);
            this.txttenlop.Name = "txttenlop";
            this.txttenlop.Size = new System.Drawing.Size(264, 31);
            this.txttenlop.TabIndex = 79;
            this.txttenlop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txttenlop_MouseClick);
            this.txttenlop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttenlop_KeyPress);
            // 
            // combo_malop
            // 
            this.combo_malop.DataSource = this.lOPBindingSource;
            this.combo_malop.DisplayMember = "MALOP";
            this.combo_malop.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.combo_malop.FormattingEnabled = true;
            this.combo_malop.Location = new System.Drawing.Point(245, 188);
            this.combo_malop.Name = "combo_malop";
            this.combo_malop.Size = new System.Drawing.Size(100, 31);
            this.combo_malop.TabIndex = 3;
            this.combo_malop.ValueMember = "MALOP";
            this.combo_malop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_malop_KeyPress);
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qL_GIANGVIENDataSet3;
            // 
            // qL_GIANGVIENDataSet3
            // 
            this.qL_GIANGVIENDataSet3.DataSetName = "QL_GIANGVIENDataSet3";
            this.qL_GIANGVIENDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // quanlygiangvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 581);
            this.Controls.Add(this.combo_malop);
            this.Controls.Add(this.txttenlop);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtsogioday);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combo_mamh);
            this.Controls.Add(this.btcapnhat);
            this.Controls.Add(this.bttim);
            this.Controls.Add(this.combo_chonmagv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txttenmonhoc);
            this.Controls.Add(this.txtmagv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btdong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "quanlygiangvien";
            this.Text = "Quản Lý Giảng Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GIANGVIENDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GIANGVIENDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GIANGVIENDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GIANGVIENDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_mamh;
        private System.Windows.Forms.Button btcapnhat;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.ComboBox combo_chonmagv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txttenmonhoc;
        private System.Windows.Forms.TextBox txtmagv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btdong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QL_GIANGVIENDataSet qL_GIANGVIENDataSet;
        private System.Windows.Forms.BindingSource aBCBindingSource;
        private QL_GIANGVIENDataSetTableAdapters.ABCTableAdapter aBCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOTENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAMHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENMHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mALOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENLOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOGIODAYDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtsogioday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttenlop;
        private System.Windows.Forms.ComboBox combo_malop;
        private QL_GIANGVIENDataSet1 qL_GIANGVIENDataSet1;
        private System.Windows.Forms.BindingSource gIANGVIENBindingSource;
        private QL_GIANGVIENDataSet1TableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private QL_GIANGVIENDataSet2 qL_GIANGVIENDataSet2;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QL_GIANGVIENDataSet2TableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private QL_GIANGVIENDataSet3 qL_GIANGVIENDataSet3;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QL_GIANGVIENDataSet3TableAdapters.LOPTableAdapter lOPTableAdapter;
    }
}

