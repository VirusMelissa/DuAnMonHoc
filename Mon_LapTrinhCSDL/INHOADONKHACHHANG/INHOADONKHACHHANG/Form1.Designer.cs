
namespace INHOADONKHACHHANG
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.qLBH_1004_TESTDataSet = new INHOADONKHACHHANG.QLBH_1004_TESTDataSet();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHACHHANGTableAdapter = new INHOADONKHACHHANG.QLBH_1004_TESTDataSetTableAdapters.KHACHHANGTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.QLBH_1004_TESTDataSet1 = new INHOADONKHACHHANG.QLBH_1004_TESTDataSet1();
            this.KH_HDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KH_HDTableAdapter = new INHOADONKHACHHANG.QLBH_1004_TESTDataSet1TableAdapters.KH_HDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_1004_TESTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBH_1004_TESTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KH_HDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.KH_HDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "INHOADONKHACHHANG.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(51, 161);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(708, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn Tên Khách Hàng";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.kHACHHANGBindingSource;
            this.comboBox1.DisplayMember = "HOTEN";
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(262, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 31);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "MAKH";
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(456, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QLBH_1004_TESTDataSet1
            // 
            this.QLBH_1004_TESTDataSet1.DataSetName = "QLBH_1004_TESTDataSet1";
            this.QLBH_1004_TESTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KH_HDBindingSource
            // 
            this.KH_HDBindingSource.DataMember = "KH_HD";
            this.KH_HDBindingSource.DataSource = this.QLBH_1004_TESTDataSet1;
            // 
            // KH_HDTableAdapter
            // 
            this.KH_HDTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_1004_TESTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBH_1004_TESTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KH_HDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private QLBH_1004_TESTDataSet qLBH_1004_TESTDataSet;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private QLBH_1004_TESTDataSetTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource KH_HDBindingSource;
        private QLBH_1004_TESTDataSet1 QLBH_1004_TESTDataSet1;
        private QLBH_1004_TESTDataSet1TableAdapters.KH_HDTableAdapter KH_HDTableAdapter;
    }
}

