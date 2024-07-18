
namespace thithu
{
    partial class inhoadon
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
            this.KH_HDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLBH_1004_TEST2DataSet = new thithu.QLBH_1004_TEST2DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH_1004_TEST2DataSet1 = new thithu.QLBH_1004_TEST2DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.kHACHHANGTableAdapter = new thithu.QLBH_1004_TEST2DataSet1TableAdapters.KHACHHANGTableAdapter();
            this.KH_HDTableAdapter = new thithu.QLBH_1004_TEST2DataSetTableAdapters.KH_HDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.KH_HDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBH_1004_TEST2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_1004_TEST2DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // KH_HDBindingSource
            // 
            this.KH_HDBindingSource.DataMember = "KH_HD";
            this.KH_HDBindingSource.DataSource = this.QLBH_1004_TEST2DataSet;
            // 
            // QLBH_1004_TEST2DataSet
            // 
            this.QLBH_1004_TEST2DataSet.DataSetName = "QLBH_1004_TEST2DataSet";
            this.QLBH_1004_TEST2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.KH_HDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "thithu.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(30, 141);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(754, 305);
            this.reportViewer1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(480, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.kHACHHANGBindingSource;
            this.comboBox1.DisplayMember = "HOTEN";
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(272, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 31);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "MAKH";
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.qLBH_1004_TEST2DataSet1;
            // 
            // qLBH_1004_TEST2DataSet1
            // 
            this.qLBH_1004_TEST2DataSet1.DataSetName = "QLBH_1004_TEST2DataSet1";
            this.qLBH_1004_TEST2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Chọn Tên Khách Hàng";
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // KH_HDTableAdapter
            // 
            this.KH_HDTableAdapter.ClearBeforeFill = true;
            // 
            // inhoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 508);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "inhoadon";
            this.Text = "inhoadon";
            this.Load += new System.EventHandler(this.inhoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KH_HDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBH_1004_TEST2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_1004_TEST2DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private QLBH_1004_TEST2DataSet1 qLBH_1004_TEST2DataSet1;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private QLBH_1004_TEST2DataSet1TableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private System.Windows.Forms.BindingSource KH_HDBindingSource;
        private QLBH_1004_TEST2DataSet QLBH_1004_TEST2DataSet;
        private QLBH_1004_TEST2DataSetTableAdapters.KH_HDTableAdapter KH_HDTableAdapter;
    }
}