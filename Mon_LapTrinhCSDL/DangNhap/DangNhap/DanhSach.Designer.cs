
namespace DangNhap
{
    partial class DanhSach
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btthoat = new System.Windows.Forms.Button();
            this.qLBH_1004_TESTDataSet = new DangNhap.QLBH_1004_TESTDataSet();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHACHHANGTableAdapter = new DangNhap.QLBH_1004_TESTDataSetTableAdapters.KHACHHANGTableAdapter();
            this.mAKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sODTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGSINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGDKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOANHSODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_1004_TESTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(97, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAKHDataGridViewTextBoxColumn,
            this.hOTENDataGridViewTextBoxColumn,
            this.dCHIDataGridViewTextBoxColumn,
            this.sODTDataGridViewTextBoxColumn,
            this.nGSINHDataGridViewTextBoxColumn,
            this.nGDKDataGridViewTextBoxColumn,
            this.dOANHSODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kHACHHANGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(55, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 234);
            this.dataGridView1.TabIndex = 2;
            // 
            // btthoat
            // 
            this.btthoat.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.Location = new System.Drawing.Point(572, 379);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(120, 34);
            this.btthoat.TabIndex = 7;
            this.btthoat.Text = "Đóng";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // qLBH_1004_TESTDataSet
            // 
            this.qLBH_1004_TESTDataSet.DataSetName = "QLBH_1004_TESTDataSet";
            this.qLBH_1004_TESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.qLBH_1004_TESTDataSet;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // mAKHDataGridViewTextBoxColumn
            // 
            this.mAKHDataGridViewTextBoxColumn.DataPropertyName = "MAKH";
            this.mAKHDataGridViewTextBoxColumn.HeaderText = "MAKH";
            this.mAKHDataGridViewTextBoxColumn.Name = "mAKHDataGridViewTextBoxColumn";
            // 
            // hOTENDataGridViewTextBoxColumn
            // 
            this.hOTENDataGridViewTextBoxColumn.DataPropertyName = "HOTEN";
            this.hOTENDataGridViewTextBoxColumn.HeaderText = "HOTEN";
            this.hOTENDataGridViewTextBoxColumn.Name = "hOTENDataGridViewTextBoxColumn";
            // 
            // dCHIDataGridViewTextBoxColumn
            // 
            this.dCHIDataGridViewTextBoxColumn.DataPropertyName = "DCHI";
            this.dCHIDataGridViewTextBoxColumn.HeaderText = "DCHI";
            this.dCHIDataGridViewTextBoxColumn.Name = "dCHIDataGridViewTextBoxColumn";
            // 
            // sODTDataGridViewTextBoxColumn
            // 
            this.sODTDataGridViewTextBoxColumn.DataPropertyName = "SODT";
            this.sODTDataGridViewTextBoxColumn.HeaderText = "SODT";
            this.sODTDataGridViewTextBoxColumn.Name = "sODTDataGridViewTextBoxColumn";
            // 
            // nGSINHDataGridViewTextBoxColumn
            // 
            this.nGSINHDataGridViewTextBoxColumn.DataPropertyName = "NGSINH";
            this.nGSINHDataGridViewTextBoxColumn.HeaderText = "NGSINH";
            this.nGSINHDataGridViewTextBoxColumn.Name = "nGSINHDataGridViewTextBoxColumn";
            // 
            // nGDKDataGridViewTextBoxColumn
            // 
            this.nGDKDataGridViewTextBoxColumn.DataPropertyName = "NGDK";
            this.nGDKDataGridViewTextBoxColumn.HeaderText = "NGDK";
            this.nGDKDataGridViewTextBoxColumn.Name = "nGDKDataGridViewTextBoxColumn";
            // 
            // dOANHSODataGridViewTextBoxColumn
            // 
            this.dOANHSODataGridViewTextBoxColumn.DataPropertyName = "DOANHSO";
            this.dOANHSODataGridViewTextBoxColumn.HeaderText = "DOANHSO";
            this.dOANHSODataGridViewTextBoxColumn.Name = "dOANHSODataGridViewTextBoxColumn";
            // 
            // DanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 445);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "DanhSach";
            this.Text = "Danh Sách Khách Hàng";
            this.Load += new System.EventHandler(this.DanhSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_1004_TESTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btthoat;
        private QLBH_1004_TESTDataSet qLBH_1004_TESTDataSet;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private QLBH_1004_TESTDataSetTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOTENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sODTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGSINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGDKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOANHSODataGridViewTextBoxColumn;
    }
}