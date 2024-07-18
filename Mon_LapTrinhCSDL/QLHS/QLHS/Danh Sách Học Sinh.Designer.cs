
namespace QLHS
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mAHSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYSINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUONGDANANHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNHDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.hOCSINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHSDataSet = new QLHS.QLHSDataSet();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btdong = new System.Windows.Forms.Button();
            this.hOCSINHTableAdapter = new QLHS.QLHSDataSetTableAdapters.HOCSINHTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.txtmahs = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtduongdan = new System.Windows.Forms.TextBox();
            this.txtngaysinh = new System.Windows.Forms.TextBox();
            this.bttimanh = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.combo_chonlop = new System.Windows.Forms.ComboBox();
            this.combo_lop = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCSINHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAHSDataGridViewTextBoxColumn,
            this.lOPDataGridViewTextBoxColumn,
            this.hOTENDataGridViewTextBoxColumn,
            this.nGAYSINHDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn,
            this.dUONGDANANHDataGridViewTextBoxColumn,
            this.aNHDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.hOCSINHBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(62, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 159);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // mAHSDataGridViewTextBoxColumn
            // 
            this.mAHSDataGridViewTextBoxColumn.DataPropertyName = "MAHS";
            this.mAHSDataGridViewTextBoxColumn.HeaderText = "MAHS";
            this.mAHSDataGridViewTextBoxColumn.Name = "mAHSDataGridViewTextBoxColumn";
            // 
            // lOPDataGridViewTextBoxColumn
            // 
            this.lOPDataGridViewTextBoxColumn.DataPropertyName = "LOP";
            this.lOPDataGridViewTextBoxColumn.HeaderText = "LOP";
            this.lOPDataGridViewTextBoxColumn.Name = "lOPDataGridViewTextBoxColumn";
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
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            // 
            // dUONGDANANHDataGridViewTextBoxColumn
            // 
            this.dUONGDANANHDataGridViewTextBoxColumn.DataPropertyName = "DUONGDANANH";
            this.dUONGDANANHDataGridViewTextBoxColumn.HeaderText = "DUONGDANANH";
            this.dUONGDANANHDataGridViewTextBoxColumn.Name = "dUONGDANANHDataGridViewTextBoxColumn";
            // 
            // aNHDataGridViewImageColumn
            // 
            this.aNHDataGridViewImageColumn.DataPropertyName = "ANH";
            this.aNHDataGridViewImageColumn.HeaderText = "ANH";
            this.aNHDataGridViewImageColumn.Name = "aNHDataGridViewImageColumn";
            // 
            // hOCSINHBindingSource
            // 
            this.hOCSINHBindingSource.DataMember = "HOCSINH";
            this.hOCSINHBindingSource.DataSource = this.qLHSDataSet;
            // 
            // qLHSDataSet
            // 
            this.qLHSDataSet.DataSetName = "QLHSDataSet";
            this.qLHSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(183, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 59);
            this.label1.TabIndex = 8;
            this.label1.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // btdong
            // 
            this.btdong.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdong.Location = new System.Drawing.Point(686, 467);
            this.btdong.Name = "btdong";
            this.btdong.Size = new System.Drawing.Size(120, 34);
            this.btdong.TabIndex = 10;
            this.btdong.Text = "Đóng";
            this.btdong.UseVisualStyleBackColor = true;
            this.btdong.Click += new System.EventHandler(this.btdong_Click);
            // 
            // hOCSINHTableAdapter
            // 
            this.hOCSINHTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã Học Sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Họ Tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(383, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ngày Sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(409, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Địa Chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(332, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Đường Dẫn Ảnh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(133, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Lớp:";
            // 
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture.Location = new System.Drawing.Point(672, 84);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(134, 147);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 17;
            this.picture.TabStop = false;
            // 
            // txtmahs
            // 
            this.txtmahs.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmahs.Location = new System.Drawing.Point(189, 103);
            this.txtmahs.Name = "txtmahs";
            this.txtmahs.Size = new System.Drawing.Size(100, 31);
            this.txtmahs.TabIndex = 1;
            this.txtmahs.Tag = "1";
            // 
            // txthoten
            // 
            this.txthoten.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.txthoten.Location = new System.Drawing.Point(189, 191);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(214, 31);
            this.txthoten.TabIndex = 3;
            this.txthoten.Tag = "3";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.txtdiachi.Location = new System.Drawing.Point(493, 191);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(157, 31);
            this.txtdiachi.TabIndex = 5;
            this.txtdiachi.Tag = "5";
            // 
            // txtduongdan
            // 
            this.txtduongdan.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.txtduongdan.Location = new System.Drawing.Point(493, 147);
            this.txtduongdan.Name = "txtduongdan";
            this.txtduongdan.Size = new System.Drawing.Size(157, 31);
            this.txtduongdan.TabIndex = 22;
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtngaysinh.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.txtngaysinh.Location = new System.Drawing.Point(493, 104);
            this.txtngaysinh.MaxLength = 10;
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(126, 31);
            this.txtngaysinh.TabIndex = 4;
            this.txtngaysinh.Tag = "4";
            // 
            // bttimanh
            // 
            this.bttimanh.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttimanh.Location = new System.Drawing.Point(680, 240);
            this.bttimanh.Name = "bttimanh";
            this.bttimanh.Size = new System.Drawing.Size(120, 34);
            this.bttimanh.TabIndex = 6;
            this.bttimanh.Tag = "6";
            this.bttimanh.Text = "Tìm Ảnh";
            this.bttimanh.UseVisualStyleBackColor = true;
            this.bttimanh.Click += new System.EventHandler(this.bttimanh_Click);
            // 
            // btsua
            // 
            this.btsua.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.Location = new System.Drawing.Point(517, 240);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(120, 34);
            this.btsua.TabIndex = 25;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Location = new System.Drawing.Point(357, 240);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(120, 34);
            this.btxoa.TabIndex = 26;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btthem
            // 
            this.btthem.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.Location = new System.Drawing.Point(189, 240);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(120, 34);
            this.btthem.TabIndex = 27;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 26);
            this.label8.TabIndex = 28;
            this.label8.Text = "Chọn Lớp:";
            // 
            // combo_chonlop
            // 
            this.combo_chonlop.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.combo_chonlop.FormattingEnabled = true;
            this.combo_chonlop.Items.AddRange(new object[] {
            "L1",
            "L2",
            "L3",
            "L4",
            "L5",
            "L6",
            "L7",
            "L8",
            "L9",
            "L10"});
            this.combo_chonlop.Location = new System.Drawing.Point(162, 467);
            this.combo_chonlop.Name = "combo_chonlop";
            this.combo_chonlop.Size = new System.Drawing.Size(121, 31);
            this.combo_chonlop.TabIndex = 29;
            this.combo_chonlop.SelectedIndexChanged += new System.EventHandler(this.combo_chonlop_SelectedIndexChanged);
            this.combo_chonlop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_chonlop_KeyPress);
            // 
            // combo_lop
            // 
            this.combo_lop.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.combo_lop.FormattingEnabled = true;
            this.combo_lop.Items.AddRange(new object[] {
            "L1",
            "L2",
            "L3",
            "L4",
            "L5",
            "L6",
            "L7",
            "L8",
            "L9",
            "L10"});
            this.combo_lop.Location = new System.Drawing.Point(189, 147);
            this.combo_lop.Name = "combo_lop";
            this.combo_lop.Size = new System.Drawing.Size(100, 31);
            this.combo_lop.TabIndex = 2;
            this.combo_lop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_lop_KeyPress);
            // 
            // danhsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 528);
            this.Controls.Add(this.combo_lop);
            this.Controls.Add(this.combo_chonlop);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.bttimanh);
            this.Controls.Add(this.txtngaysinh);
            this.Controls.Add(this.txtduongdan);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txtmahs);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btdong);
            this.Name = "danhsach";
            this.Text = "Danh Sách Học  Sinh";
            this.Load += new System.EventHandler(this.danhsach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCSINHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btdong;
        private QLHSDataSet qLHSDataSet;
        private System.Windows.Forms.BindingSource hOCSINHBindingSource;
        private QLHSDataSetTableAdapters.HOCSINHTableAdapter hOCSINHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAHSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOTENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYSINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dUONGDANANHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn aNHDataGridViewImageColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.TextBox txtmahs;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtduongdan;
        private System.Windows.Forms.TextBox txtngaysinh;
        private System.Windows.Forms.Button bttimanh;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combo_chonlop;
        private System.Windows.Forms.ComboBox combo_lop;
    }
}