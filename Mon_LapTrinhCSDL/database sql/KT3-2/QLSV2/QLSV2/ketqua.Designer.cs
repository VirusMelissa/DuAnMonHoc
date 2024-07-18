
namespace QLSV2
{
    partial class ketqua
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
            this.combo_masv = new System.Windows.Forms.ComboBox();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHS2DataSet4 = new QLSV2.QLHS2DataSet4();
            this.txtsotc = new System.Windows.Forms.TextBox();
            this.txtdiem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.combo_mamh = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHS2DataSet3 = new QLSV2.QLHS2DataSet3();
            this.btsua = new System.Windows.Forms.Button();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txttenmonhoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btcapnhat = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mASVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mALOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aBCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHS2DataSet2 = new QLSV2.QLHS2DataSet2();
            this.label3 = new System.Windows.Forms.Label();
            this.btdong = new System.Windows.Forms.Button();
            this.aBCTableAdapter = new QLSV2.QLHS2DataSet2TableAdapters.ABCTableAdapter();
            this.mONHOCTableAdapter = new QLSV2.QLHS2DataSet3TableAdapters.MONHOCTableAdapter();
            this.sINHVIENTableAdapter = new QLSV2.QLHS2DataSet4TableAdapters.SINHVIENTableAdapter();
            this.combo_malop = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHS2DataSet5 = new QLSV2.QLHS2DataSet5();
            this.label5 = new System.Windows.Forms.Label();
            this.lOPTableAdapter = new QLSV2.QLHS2DataSet5TableAdapters.LOPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHS2DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHS2DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHS2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHS2DataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_masv
            // 
            this.combo_masv.DataSource = this.sINHVIENBindingSource;
            this.combo_masv.DisplayMember = "MASV";
            this.combo_masv.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.combo_masv.FormattingEnabled = true;
            this.combo_masv.Location = new System.Drawing.Point(237, 107);
            this.combo_masv.Name = "combo_masv";
            this.combo_masv.Size = new System.Drawing.Size(100, 31);
            this.combo_masv.TabIndex = 124;
            this.combo_masv.ValueMember = "MAGV";
            this.combo_masv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_masv_KeyPress);
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.qLHS2DataSet4;
            // 
            // qLHS2DataSet4
            // 
            this.qLHS2DataSet4.DataSetName = "QLHS2DataSet4";
            this.qLHS2DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtsotc
            // 
            this.txtsotc.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsotc.Location = new System.Drawing.Point(237, 235);
            this.txtsotc.Name = "txtsotc";
            this.txtsotc.Size = new System.Drawing.Size(100, 31);
            this.txtsotc.TabIndex = 123;
            this.txtsotc.Tag = "1";
            this.txtsotc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtsotc_MouseClick);
            this.txtsotc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsotc_KeyPress);
            // 
            // txtdiem
            // 
            this.txtdiem.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.txtdiem.Location = new System.Drawing.Point(611, 232);
            this.txtdiem.Name = "txtdiem";
            this.txtdiem.Size = new System.Drawing.Size(264, 31);
            this.txtdiem.TabIndex = 122;
            this.txtdiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiem_KeyPress);
            this.txtdiem.Leave += new System.EventHandler(this.txtdiem_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(542, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 26);
            this.label9.TabIndex = 121;
            this.label9.Text = "Điểm:";
            // 
            // combo_mamh
            // 
            this.combo_mamh.DataSource = this.mONHOCBindingSource;
            this.combo_mamh.DisplayMember = "MAMH";
            this.combo_mamh.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.combo_mamh.FormattingEnabled = true;
            this.combo_mamh.Location = new System.Drawing.Point(237, 148);
            this.combo_mamh.Name = "combo_mamh";
            this.combo_mamh.Size = new System.Drawing.Size(100, 31);
            this.combo_mamh.TabIndex = 106;
            this.combo_mamh.ValueMember = "MAMH";
            this.combo_mamh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_mamh_KeyPress);
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLHS2DataSet3;
            // 
            // qLHS2DataSet3
            // 
            this.qLHS2DataSet3.DataSetName = "QLHS2DataSet3";
            this.qLHS2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btsua
            // 
            this.btsua.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.Location = new System.Drawing.Point(428, 502);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(86, 34);
            this.btsua.TabIndex = 117;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // txthoten
            // 
            this.txthoten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthoten.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.txthoten.Location = new System.Drawing.Point(611, 105);
            this.txthoten.MaxLength = 10;
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(264, 31);
            this.txthoten.TabIndex = 107;
            this.txthoten.Tag = "4";
            this.txthoten.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txthoten_MouseClick);
            // 
            // txttenmonhoc
            // 
            this.txttenmonhoc.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.txttenmonhoc.Location = new System.Drawing.Point(611, 149);
            this.txttenmonhoc.Name = "txttenmonhoc";
            this.txttenmonhoc.Size = new System.Drawing.Size(264, 31);
            this.txttenmonhoc.TabIndex = 108;
            this.txttenmonhoc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txttenmonhoc_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(102, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 26);
            this.label7.TabIndex = 116;
            this.label7.Text = "Mã Môn Học:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(475, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 26);
            this.label6.TabIndex = 115;
            this.label6.Text = "Tên Môn Học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(444, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 26);
            this.label4.TabIndex = 114;
            this.label4.Text = "Họ Tên Sinh Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 26);
            this.label2.TabIndex = 112;
            this.label2.Text = "Mã Sinh Viên:";
            // 
            // btcapnhat
            // 
            this.btcapnhat.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcapnhat.Location = new System.Drawing.Point(649, 502);
            this.btcapnhat.Name = "btcapnhat";
            this.btcapnhat.Size = new System.Drawing.Size(105, 34);
            this.btcapnhat.TabIndex = 120;
            this.btcapnhat.Text = "Cập Nhật";
            this.btcapnhat.UseVisualStyleBackColor = true;
            this.btcapnhat.Click += new System.EventHandler(this.btcapnhat_Click);
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Location = new System.Drawing.Point(237, 502);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(80, 34);
            this.btxoa.TabIndex = 118;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btthem
            // 
            this.btthem.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.Location = new System.Drawing.Point(74, 502);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(80, 34);
            this.btthem.TabIndex = 119;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(404, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 59);
            this.label1.TabIndex = 109;
            this.label1.Text = "KẾT QUẢ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mASVDataGridViewTextBoxColumn,
            this.hOTENDataGridViewTextBoxColumn,
            this.mALOPDataGridViewTextBoxColumn,
            this.mAMHDataGridViewTextBoxColumn,
            this.tENMHDataGridViewTextBoxColumn,
            this.sOTCDataGridViewTextBoxColumn,
            this.dIEMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aBCBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(76, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(878, 191);
            this.dataGridView1.TabIndex = 110;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // mASVDataGridViewTextBoxColumn
            // 
            this.mASVDataGridViewTextBoxColumn.DataPropertyName = "MASV";
            this.mASVDataGridViewTextBoxColumn.HeaderText = "MASV";
            this.mASVDataGridViewTextBoxColumn.Name = "mASVDataGridViewTextBoxColumn";
            // 
            // hOTENDataGridViewTextBoxColumn
            // 
            this.hOTENDataGridViewTextBoxColumn.DataPropertyName = "HOTEN";
            this.hOTENDataGridViewTextBoxColumn.HeaderText = "HOTEN";
            this.hOTENDataGridViewTextBoxColumn.Name = "hOTENDataGridViewTextBoxColumn";
            // 
            // mALOPDataGridViewTextBoxColumn
            // 
            this.mALOPDataGridViewTextBoxColumn.DataPropertyName = "MALOP";
            this.mALOPDataGridViewTextBoxColumn.HeaderText = "MALOP";
            this.mALOPDataGridViewTextBoxColumn.Name = "mALOPDataGridViewTextBoxColumn";
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
            // sOTCDataGridViewTextBoxColumn
            // 
            this.sOTCDataGridViewTextBoxColumn.DataPropertyName = "SOTC";
            this.sOTCDataGridViewTextBoxColumn.HeaderText = "SOTC";
            this.sOTCDataGridViewTextBoxColumn.Name = "sOTCDataGridViewTextBoxColumn";
            // 
            // dIEMDataGridViewTextBoxColumn
            // 
            this.dIEMDataGridViewTextBoxColumn.DataPropertyName = "DIEM";
            this.dIEMDataGridViewTextBoxColumn.HeaderText = "DIEM";
            this.dIEMDataGridViewTextBoxColumn.Name = "dIEMDataGridViewTextBoxColumn";
            // 
            // aBCBindingSource
            // 
            this.aBCBindingSource.DataMember = "ABC";
            this.aBCBindingSource.DataSource = this.qLHS2DataSet2;
            // 
            // qLHS2DataSet2
            // 
            this.qLHS2DataSet2.DataSetName = "QLHS2DataSet2";
            this.qLHS2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 26);
            this.label3.TabIndex = 113;
            this.label3.Text = "Số Tín Chỉ:";
            // 
            // btdong
            // 
            this.btdong.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdong.Location = new System.Drawing.Point(862, 502);
            this.btdong.Name = "btdong";
            this.btdong.Size = new System.Drawing.Size(92, 34);
            this.btdong.TabIndex = 111;
            this.btdong.Text = "Đóng";
            this.btdong.UseVisualStyleBackColor = true;
            this.btdong.Click += new System.EventHandler(this.btdong_Click);
            // 
            // aBCTableAdapter
            // 
            this.aBCTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // combo_malop
            // 
            this.combo_malop.DataSource = this.lOPBindingSource;
            this.combo_malop.DisplayMember = "MALOP";
            this.combo_malop.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.combo_malop.FormattingEnabled = true;
            this.combo_malop.Location = new System.Drawing.Point(237, 192);
            this.combo_malop.Name = "combo_malop";
            this.combo_malop.Size = new System.Drawing.Size(100, 31);
            this.combo_malop.TabIndex = 125;
            this.combo_malop.ValueMember = "MALOP";
            this.combo_malop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_malop_KeyPress);
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLHS2DataSet5;
            // 
            // qLHS2DataSet5
            // 
            this.qLHS2DataSet5.DataSetName = "QLHS2DataSet5";
            this.qLHS2DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 26);
            this.label5.TabIndex = 126;
            this.label5.Text = "Mã Lớp:";
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // ketqua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 563);
            this.Controls.Add(this.combo_malop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combo_masv);
            this.Controls.Add(this.txtsotc);
            this.Controls.Add(this.txtdiem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.combo_mamh);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txttenmonhoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btcapnhat);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btdong);
            this.Name = "ketqua";
            this.Text = "Kết Quả";
            this.Load += new System.EventHandler(this.ketqua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHS2DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHS2DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHS2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHS2DataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox combo_masv;
        private System.Windows.Forms.TextBox txtsotc;
        private System.Windows.Forms.TextBox txtdiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combo_mamh;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txttenmonhoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btcapnhat;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btdong;
        private QLHS2DataSet2 qLHS2DataSet2;
        private System.Windows.Forms.BindingSource aBCBindingSource;
        private QLHS2DataSet2TableAdapters.ABCTableAdapter aBCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOTENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mALOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAMHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENMHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIEMDataGridViewTextBoxColumn;
        private QLHS2DataSet3 qLHS2DataSet3;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QLHS2DataSet3TableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private QLHS2DataSet4 qLHS2DataSet4;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private QLHS2DataSet4TableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.ComboBox combo_malop;
        private System.Windows.Forms.Label label5;
        private QLHS2DataSet5 qLHS2DataSet5;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLHS2DataSet5TableAdapters.LOPTableAdapter lOPTableAdapter;
    }
}