
namespace ChuViDienTich
{
    partial class ChuHoavaThuong
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
            this.label3 = new System.Windows.Forms.Label();
            this.NhapA = new System.Windows.Forms.TextBox();
            this.btTinh = new System.Windows.Forms.Button();
            this.radioHoa = new System.Windows.Forms.RadioButton();
            this.radioThuong = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.KetQua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nhập A:";
            // 
            // NhapA
            // 
            this.NhapA.BackColor = System.Drawing.SystemColors.Info;
            this.NhapA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapA.Location = new System.Drawing.Point(339, 139);
            this.NhapA.Name = "NhapA";
            this.NhapA.Size = new System.Drawing.Size(170, 26);
            this.NhapA.TabIndex = 12;
            this.NhapA.TextChanged += new System.EventHandler(this.NhapA_TextChanged);
            // 
            // btTinh
            // 
            this.btTinh.BackColor = System.Drawing.Color.DarkOrange;
            this.btTinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTinh.Location = new System.Drawing.Point(543, 139);
            this.btTinh.Name = "btTinh";
            this.btTinh.Size = new System.Drawing.Size(88, 62);
            this.btTinh.TabIndex = 16;
            this.btTinh.Text = "Tính";
            this.btTinh.UseVisualStyleBackColor = false;
            this.btTinh.Click += new System.EventHandler(this.btTinh_Click);
            // 
            // radioHoa
            // 
            this.radioHoa.AutoSize = true;
            this.radioHoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioHoa.Location = new System.Drawing.Point(168, 184);
            this.radioHoa.Name = "radioHoa";
            this.radioHoa.Size = new System.Drawing.Size(96, 25);
            this.radioHoa.TabIndex = 17;
            this.radioHoa.TabStop = true;
            this.radioHoa.Text = "Chữ Hoa";
            this.radioHoa.UseVisualStyleBackColor = true;
            // 
            // radioThuong
            // 
            this.radioThuong.AutoSize = true;
            this.radioThuong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioThuong.Location = new System.Drawing.Point(327, 184);
            this.radioThuong.Name = "radioThuong";
            this.radioThuong.Size = new System.Drawing.Size(124, 25);
            this.radioThuong.TabIndex = 18;
            this.radioThuong.TabStop = true;
            this.radioThuong.Text = "Chữ Thường";
            this.radioThuong.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kết quả";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // KetQua
            // 
            this.KetQua.BackColor = System.Drawing.SystemColors.Info;
            this.KetQua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KetQua.Location = new System.Drawing.Point(339, 252);
            this.KetQua.Name = "KetQua";
            this.KetQua.Size = new System.Drawing.Size(170, 26);
            this.KetQua.TabIndex = 19;
            this.KetQua.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ChuHoavaThuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KetQua);
            this.Controls.Add(this.radioThuong);
            this.Controls.Add(this.radioHoa);
            this.Controls.Add(this.btTinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NhapA);
            this.Name = "ChuHoavaThuong";
            this.Text = "test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NhapA;
        private System.Windows.Forms.Button btTinh;
        private System.Windows.Forms.RadioButton radioHoa;
        private System.Windows.Forms.RadioButton radioThuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KetQua;
    }
}