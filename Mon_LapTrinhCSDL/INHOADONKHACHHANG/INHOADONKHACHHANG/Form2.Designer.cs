
namespace INHOADONKHACHHANG
{
    partial class Form2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.qLBH_1004_TESTDataSet3 = new INHOADONKHACHHANG.QLBH_1004_TESTDataSet3();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHACHHANGTableAdapter = new INHOADONKHACHHANG.QLBH_1004_TESTDataSet3TableAdapters.KHACHHANGTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLBH_1004_TESTDataSet2 = new INHOADONKHACHHANG.QLBH_1004_TESTDataSet2();
            this.KH_HDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KH_HDTableAdapter = new INHOADONKHACHHANG.QLBH_1004_TESTDataSet2TableAdapters.KH_HDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_1004_TESTDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBH_1004_TESTDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KH_HDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.kHACHHANGBindingSource;
            this.comboBox1.DisplayMember = "HOTEN";
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(260, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 31);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "MAKH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chọn Tên Khách Hàng";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(454, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // qLBH_1004_TESTDataSet3
            // 
            this.qLBH_1004_TESTDataSet3.DataSetName = "QLBH_1004_TESTDataSet3";
            this.qLBH_1004_TESTDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.qLBH_1004_TESTDataSet3;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.KH_HDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "INHOADONKHACHHANG.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(49, 153);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(668, 246);
            this.reportViewer1.TabIndex = 8;
            // 
            // QLBH_1004_TESTDataSet2
            // 
            this.QLBH_1004_TESTDataSet2.DataSetName = "QLBH_1004_TESTDataSet2";
            this.QLBH_1004_TESTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KH_HDBindingSource
            // 
            this.KH_HDBindingSource.DataMember = "KH_HD";
            this.KH_HDBindingSource.DataSource = this.QLBH_1004_TESTDataSet2;
            // 
            // KH_HDTableAdapter
            // 
            this.KH_HDTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_1004_TESTDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBH_1004_TESTDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KH_HDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private QLBH_1004_TESTDataSet3 qLBH_1004_TESTDataSet3;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private QLBH_1004_TESTDataSet3TableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KH_HDBindingSource;
        private QLBH_1004_TESTDataSet2 QLBH_1004_TESTDataSet2;
        private QLBH_1004_TESTDataSet2TableAdapters.KH_HDTableAdapter KH_HDTableAdapter;
    }
}