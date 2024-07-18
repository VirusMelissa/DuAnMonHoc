
namespace BANTHUCUNG
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
            this.btthem = new System.Windows.Forms.Button();
            this.txttenthucung = new System.Windows.Forms.TextBox();
            this.txtmathucung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtduongdan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mATCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNHDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.iMPATHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHUCUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTHUCUNGDataSet = new BANTHUCUNG.QLTHUCUNGDataSet();
            this.tHUCUNGTableAdapter = new BANTHUCUNG.QLTHUCUNGDataSetTableAdapters.THUCUNGTableAdapter();
            this.bttimanh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUCUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTHUCUNGDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btthem
            // 
            this.btthem.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.Location = new System.Drawing.Point(73, 219);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(89, 38);
            this.btthem.TabIndex = 13;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btdangnhap_Click);
            // 
            // txttenthucung
            // 
            this.txttenthucung.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenthucung.Location = new System.Drawing.Point(379, 117);
            this.txttenthucung.Name = "txttenthucung";
            this.txttenthucung.Size = new System.Drawing.Size(130, 27);
            this.txttenthucung.TabIndex = 12;
            // 
            // txtmathucung
            // 
            this.txtmathucung.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmathucung.Location = new System.Drawing.Point(192, 117);
            this.txtmathucung.Name = "txtmathucung";
            this.txtmathucung.Size = new System.Drawing.Size(47, 27);
            this.txtmathucung.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên Thú Cưng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã Thú Cưng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(150, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 59);
            this.label1.TabIndex = 8;
            this.label1.Text = "THÚ CƯNG MIỀN ĐÔNG";
            // 
            // txtduongdan
            // 
            this.txtduongdan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtduongdan.Location = new System.Drawing.Point(213, 171);
            this.txtduongdan.Name = "txtduongdan";
            this.txtduongdan.Size = new System.Drawing.Size(296, 27);
            this.txtduongdan.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Đường Dẫn Ảnh:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(525, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Location = new System.Drawing.Point(233, 219);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(89, 38);
            this.btxoa.TabIndex = 19;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.Location = new System.Drawing.Point(389, 219);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(89, 38);
            this.btsua.TabIndex = 20;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mATCDataGridViewTextBoxColumn,
            this.tENTCDataGridViewTextBoxColumn,
            this.aNHDataGridViewImageColumn,
            this.iMPATHDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tHUCUNGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(73, 325);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(626, 150);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // mATCDataGridViewTextBoxColumn
            // 
            this.mATCDataGridViewTextBoxColumn.DataPropertyName = "MATC";
            this.mATCDataGridViewTextBoxColumn.HeaderText = "MATC";
            this.mATCDataGridViewTextBoxColumn.Name = "mATCDataGridViewTextBoxColumn";
            // 
            // tENTCDataGridViewTextBoxColumn
            // 
            this.tENTCDataGridViewTextBoxColumn.DataPropertyName = "TENTC";
            this.tENTCDataGridViewTextBoxColumn.HeaderText = "TENTC";
            this.tENTCDataGridViewTextBoxColumn.Name = "tENTCDataGridViewTextBoxColumn";
            // 
            // aNHDataGridViewImageColumn
            // 
            this.aNHDataGridViewImageColumn.DataPropertyName = "ANH";
            this.aNHDataGridViewImageColumn.HeaderText = "ANH";
            this.aNHDataGridViewImageColumn.Name = "aNHDataGridViewImageColumn";
            // 
            // iMPATHDataGridViewTextBoxColumn
            // 
            this.iMPATHDataGridViewTextBoxColumn.DataPropertyName = "IMPATH";
            this.iMPATHDataGridViewTextBoxColumn.HeaderText = "IMPATH";
            this.iMPATHDataGridViewTextBoxColumn.Name = "iMPATHDataGridViewTextBoxColumn";
            // 
            // tHUCUNGBindingSource
            // 
            this.tHUCUNGBindingSource.DataMember = "THUCUNG";
            this.tHUCUNGBindingSource.DataSource = this.qLTHUCUNGDataSet;
            // 
            // qLTHUCUNGDataSet
            // 
            this.qLTHUCUNGDataSet.DataSetName = "QLTHUCUNGDataSet";
            this.qLTHUCUNGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHUCUNGTableAdapter
            // 
            this.tHUCUNGTableAdapter.ClearBeforeFill = true;
            // 
            // bttimanh
            // 
            this.bttimanh.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttimanh.Location = new System.Drawing.Point(558, 263);
            this.bttimanh.Name = "bttimanh";
            this.bttimanh.Size = new System.Drawing.Size(112, 38);
            this.bttimanh.TabIndex = 22;
            this.bttimanh.Text = "Tìm Ảnh";
            this.bttimanh.UseVisualStyleBackColor = true;
            this.bttimanh.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 504);
            this.Controls.Add(this.bttimanh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtduongdan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.txttenthucung);
            this.Controls.Add(this.txtmathucung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUCUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTHUCUNGDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.TextBox txttenthucung;
        private System.Windows.Forms.TextBox txtmathucung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtduongdan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLTHUCUNGDataSet qLTHUCUNGDataSet;
        private System.Windows.Forms.BindingSource tHUCUNGBindingSource;
        private QLTHUCUNGDataSetTableAdapters.THUCUNGTableAdapter tHUCUNGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn aNHDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMPATHDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bttimanh;
    }
}

