
namespace QL_GIANGVIEN2
{
    partial class phancong
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
            this.txtsotietdaday = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.combo_mamh = new System.Windows.Forms.ComboBox();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txttenmonhoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btcapnhat = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btdong = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsotiet = new System.Windows.Forms.TextBox();
            this.qL_GIANGVIEN2DataSet2 = new QL_GIANGVIEN2.QL_GIANGVIEN2DataSet2();
            this.aBCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBCTableAdapter = new QL_GIANGVIEN2.QL_GIANGVIEN2DataSet2TableAdapters.ABCTableAdapter();
            this.mAGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOTIETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOTIETDADAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qL_GIANGVIEN2DataSet3 = new QL_GIANGVIEN2.QL_GIANGVIEN2DataSet3();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new QL_GIANGVIEN2.QL_GIANGVIEN2DataSet3TableAdapters.MONHOCTableAdapter();
            this.combo_magv = new System.Windows.Forms.ComboBox();
            this.qL_GIANGVIEN2DataSet4 = new QL_GIANGVIEN2.QL_GIANGVIEN2DataSet4();
            this.gIANGVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIANGVIENTableAdapter = new QL_GIANGVIEN2.QL_GIANGVIEN2DataSet4TableAdapters.GIANGVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GIANGVIEN2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GIANGVIEN2DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GIANGVIEN2DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsotietdaday
            // 
            this.txtsotietdaday.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.txtsotietdaday.Location = new System.Drawing.Point(610, 190);
            this.txtsotietdaday.Name = "txtsotietdaday";
            this.txtsotietdaday.Size = new System.Drawing.Size(264, 31);
            this.txtsotietdaday.TabIndex = 103;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(462, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 26);
            this.label9.TabIndex = 102;
            this.label9.Text = "Số Tiết Đã Dạy:";
            // 
            // combo_mamh
            // 
            this.combo_mamh.DataSource = this.mONHOCBindingSource;
            this.combo_mamh.DisplayMember = "MAMH";
            this.combo_mamh.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.combo_mamh.FormattingEnabled = true;
            this.combo_mamh.Location = new System.Drawing.Point(236, 148);
            this.combo_mamh.Name = "combo_mamh";
            this.combo_mamh.Size = new System.Drawing.Size(100, 31);
            this.combo_mamh.TabIndex = 81;
            this.combo_mamh.ValueMember = "MAMH";
            this.combo_mamh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_mamh_KeyPress);
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Location = new System.Drawing.Point(236, 485);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(80, 34);
            this.btxoa.TabIndex = 95;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.Location = new System.Drawing.Point(427, 485);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(86, 34);
            this.btsua.TabIndex = 94;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // txthoten
            // 
            this.txthoten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthoten.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.txthoten.Location = new System.Drawing.Point(610, 105);
            this.txthoten.MaxLength = 10;
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(264, 31);
            this.txthoten.TabIndex = 84;
            this.txthoten.Tag = "4";
            this.txthoten.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txthoten_MouseClick);
            // 
            // txttenmonhoc
            // 
            this.txttenmonhoc.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.txttenmonhoc.Location = new System.Drawing.Point(610, 149);
            this.txttenmonhoc.Name = "txttenmonhoc";
            this.txttenmonhoc.Size = new System.Drawing.Size(264, 31);
            this.txttenmonhoc.TabIndex = 85;
            this.txttenmonhoc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txttenmonhoc_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(101, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 26);
            this.label7.TabIndex = 93;
            this.label7.Text = "Mã Môn Học:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(474, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 26);
            this.label6.TabIndex = 92;
            this.label6.Text = "Tên Môn Học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(431, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 26);
            this.label4.TabIndex = 91;
            this.label4.Text = "Họ Tên Giảng Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 26);
            this.label2.TabIndex = 89;
            this.label2.Text = "Mã Giảng Viên:";
            // 
            // btcapnhat
            // 
            this.btcapnhat.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcapnhat.Location = new System.Drawing.Point(648, 485);
            this.btcapnhat.Name = "btcapnhat";
            this.btcapnhat.Size = new System.Drawing.Size(105, 34);
            this.btcapnhat.TabIndex = 100;
            this.btcapnhat.Text = "Cập Nhật";
            this.btcapnhat.UseVisualStyleBackColor = true;
            this.btcapnhat.Click += new System.EventHandler(this.btcapnhat_Click);
            // 
            // btthem
            // 
            this.btthem.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.Location = new System.Drawing.Point(73, 485);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(80, 34);
            this.btthem.TabIndex = 96;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(379, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 59);
            this.label1.TabIndex = 86;
            this.label1.Text = "PHÂN CÔNG";
            // 
            // btdong
            // 
            this.btdong.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdong.Location = new System.Drawing.Point(861, 485);
            this.btdong.Name = "btdong";
            this.btdong.Size = new System.Drawing.Size(92, 34);
            this.btdong.TabIndex = 88;
            this.btdong.Text = "Đóng";
            this.btdong.UseVisualStyleBackColor = true;
            this.btdong.Click += new System.EventHandler(this.btdong_Click);
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
            this.sOTIETDataGridViewTextBoxColumn,
            this.sOTIETDADAYDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aBCBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(75, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(878, 191);
            this.dataGridView1.TabIndex = 87;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 90;
            this.label3.Text = "Số Tiết:";
            // 
            // txtsotiet
            // 
            this.txtsotiet.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsotiet.Location = new System.Drawing.Point(236, 191);
            this.txtsotiet.Name = "txtsotiet";
            this.txtsotiet.Size = new System.Drawing.Size(100, 31);
            this.txtsotiet.TabIndex = 104;
            this.txtsotiet.Tag = "1";
            // 
            // qL_GIANGVIEN2DataSet2
            // 
            this.qL_GIANGVIEN2DataSet2.DataSetName = "QL_GIANGVIEN2DataSet2";
            this.qL_GIANGVIEN2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aBCBindingSource
            // 
            this.aBCBindingSource.DataMember = "ABC";
            this.aBCBindingSource.DataSource = this.qL_GIANGVIEN2DataSet2;
            // 
            // aBCTableAdapter
            // 
            this.aBCTableAdapter.ClearBeforeFill = true;
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
            // sOTIETDataGridViewTextBoxColumn
            // 
            this.sOTIETDataGridViewTextBoxColumn.DataPropertyName = "SOTIET";
            this.sOTIETDataGridViewTextBoxColumn.HeaderText = "SOTIET";
            this.sOTIETDataGridViewTextBoxColumn.Name = "sOTIETDataGridViewTextBoxColumn";
            // 
            // sOTIETDADAYDataGridViewTextBoxColumn
            // 
            this.sOTIETDADAYDataGridViewTextBoxColumn.DataPropertyName = "SOTIETDADAY";
            this.sOTIETDADAYDataGridViewTextBoxColumn.HeaderText = "SOTIETDADAY";
            this.sOTIETDADAYDataGridViewTextBoxColumn.Name = "sOTIETDADAYDataGridViewTextBoxColumn";
            // 
            // qL_GIANGVIEN2DataSet3
            // 
            this.qL_GIANGVIEN2DataSet3.DataSetName = "QL_GIANGVIEN2DataSet3";
            this.qL_GIANGVIEN2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qL_GIANGVIEN2DataSet3;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // combo_magv
            // 
            this.combo_magv.DataSource = this.gIANGVIENBindingSource;
            this.combo_magv.DisplayMember = "MAGV";
            this.combo_magv.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.combo_magv.FormattingEnabled = true;
            this.combo_magv.Location = new System.Drawing.Point(236, 107);
            this.combo_magv.Name = "combo_magv";
            this.combo_magv.Size = new System.Drawing.Size(100, 31);
            this.combo_magv.TabIndex = 105;
            this.combo_magv.ValueMember = "MAGV";
            this.combo_magv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_magv_KeyPress);
            // 
            // qL_GIANGVIEN2DataSet4
            // 
            this.qL_GIANGVIEN2DataSet4.DataSetName = "QL_GIANGVIEN2DataSet4";
            this.qL_GIANGVIEN2DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIANGVIENBindingSource
            // 
            this.gIANGVIENBindingSource.DataMember = "GIANGVIEN";
            this.gIANGVIENBindingSource.DataSource = this.qL_GIANGVIEN2DataSet4;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // phancong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 563);
            this.Controls.Add(this.combo_magv);
            this.Controls.Add(this.txtsotiet);
            this.Controls.Add(this.txtsotietdaday);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.combo_mamh);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txttenmonhoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btcapnhat);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btdong);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Name = "phancong";
            this.Text = "Phân Công";
            this.Load += new System.EventHandler(this.phancong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GIANGVIEN2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GIANGVIEN2DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GIANGVIEN2DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtsotietdaday;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combo_mamh;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txttenmonhoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btcapnhat;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btdong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsotiet;
        private QL_GIANGVIEN2DataSet2 qL_GIANGVIEN2DataSet2;
        private System.Windows.Forms.BindingSource aBCBindingSource;
        private QL_GIANGVIEN2DataSet2TableAdapters.ABCTableAdapter aBCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOTENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAMHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENMHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOTIETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOTIETDADAYDataGridViewTextBoxColumn;
        private QL_GIANGVIEN2DataSet3 qL_GIANGVIEN2DataSet3;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QL_GIANGVIEN2DataSet3TableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.ComboBox combo_magv;
        private QL_GIANGVIEN2DataSet4 qL_GIANGVIEN2DataSet4;
        private System.Windows.Forms.BindingSource gIANGVIENBindingSource;
        private QL_GIANGVIEN2DataSet4TableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
    }
}