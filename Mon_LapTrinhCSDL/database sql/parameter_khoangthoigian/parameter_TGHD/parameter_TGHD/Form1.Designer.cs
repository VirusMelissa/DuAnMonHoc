
namespace parameter_TGHD
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttu = new System.Windows.Forms.TextBox();
            this.txtden = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btlietke = new System.Windows.Forms.Button();
            this.qLBH_1004_TESTDataSet = new parameter_TGHD.QLBH_1004_TESTDataSet();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOADONTableAdapter = new parameter_TGHD.QLBH_1004_TESTDataSetTableAdapters.HOADONTableAdapter();
            this.sOHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRIGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_1004_TESTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến:";
            // 
            // txttu
            // 
            this.txttu.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttu.Location = new System.Drawing.Point(130, 53);
            this.txttu.Name = "txttu";
            this.txttu.Size = new System.Drawing.Size(98, 31);
            this.txttu.TabIndex = 2;
            // 
            // txtden
            // 
            this.txtden.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtden.Location = new System.Drawing.Point(292, 53);
            this.txtden.Name = "txtden";
            this.txtden.Size = new System.Drawing.Size(100, 31);
            this.txtden.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sOHDDataGridViewTextBoxColumn,
            this.tRIGIADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hOADONBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(49, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(378, 138);
            this.dataGridView1.TabIndex = 4;
            // 
            // btlietke
            // 
            this.btlietke.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlietke.Location = new System.Drawing.Point(398, 53);
            this.btlietke.Name = "btlietke";
            this.btlietke.Size = new System.Drawing.Size(75, 31);
            this.btlietke.TabIndex = 5;
            this.btlietke.Text = "Liệt Kê";
            this.btlietke.UseVisualStyleBackColor = true;
            this.btlietke.Click += new System.EventHandler(this.btlietke_Click);
            // 
            // qLBH_1004_TESTDataSet
            // 
            this.qLBH_1004_TESTDataSet.DataSetName = "QLBH_1004_TESTDataSet";
            this.qLBH_1004_TESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataMember = "HOADON";
            this.hOADONBindingSource.DataSource = this.qLBH_1004_TESTDataSet;
            // 
            // hOADONTableAdapter
            // 
            this.hOADONTableAdapter.ClearBeforeFill = true;
            // 
            // sOHDDataGridViewTextBoxColumn
            // 
            this.sOHDDataGridViewTextBoxColumn.DataPropertyName = "SOHD";
            this.sOHDDataGridViewTextBoxColumn.HeaderText = "SOHD";
            this.sOHDDataGridViewTextBoxColumn.Name = "sOHDDataGridViewTextBoxColumn";
            // 
            // tRIGIADataGridViewTextBoxColumn
            // 
            this.tRIGIADataGridViewTextBoxColumn.DataPropertyName = "TRIGIA";
            this.tRIGIADataGridViewTextBoxColumn.HeaderText = "TRIGIA";
            this.tRIGIADataGridViewTextBoxColumn.Name = "tRIGIADataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 294);
            this.Controls.Add(this.btlietke);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtden);
            this.Controls.Add(this.txttu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_1004_TESTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttu;
        private System.Windows.Forms.TextBox txtden;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btlietke;
        private QLBH_1004_TESTDataSet qLBH_1004_TESTDataSet;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private QLBH_1004_TESTDataSetTableAdapters.HOADONTableAdapter hOADONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRIGIADataGridViewTextBoxColumn;
    }
}

