
namespace Chuoi_String
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
            this.txtNhapC1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdemkytudaxoa = new System.Windows.Forms.TextBox();
            this.txtHocPhi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdemkytudaxoa1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChuoidoi = new System.Windows.Forms.TextBox();
            this.txtChuoithay = new System.Windows.Forms.TextBox();
            this.btExecute = new System.Windows.Forms.Button();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.txtSoLan = new System.Windows.Forms.TextBox();
            this.CB_DoiThay = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioPB = new System.Windows.Forms.RadioButton();
            this.radioKoPB = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNhapC1
            // 
            this.txtNhapC1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapC1.Location = new System.Drawing.Point(220, 78);
            this.txtNhapC1.Name = "txtNhapC1";
            this.txtNhapC1.Size = new System.Drawing.Size(277, 37);
            this.txtNhapC1.TabIndex = 0;
            this.txtNhapC1.TextChanged += new System.EventHandler(this.txtNhapC1_TextChanged);
            this.txtNhapC1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập Chuỗi:";
            // 
            // txtdemkytudaxoa
            // 
            this.txtdemkytudaxoa.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdemkytudaxoa.Location = new System.Drawing.Point(75, 76);
            this.txtdemkytudaxoa.Name = "txtdemkytudaxoa";
            this.txtdemkytudaxoa.ReadOnly = true;
            this.txtdemkytudaxoa.Size = new System.Drawing.Size(324, 37);
            this.txtdemkytudaxoa.TabIndex = 2;
            // 
            // txtHocPhi
            // 
            this.txtHocPhi.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocPhi.Location = new System.Drawing.Point(220, 137);
            this.txtHocPhi.Name = "txtHocPhi";
            this.txtHocPhi.Size = new System.Drawing.Size(244, 37);
            this.txtHocPhi.TabIndex = 3;
            this.txtHocPhi.Leave += new System.EventHandler(this.txtHocPhi_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập Học Phí:";
            // 
            // txtdemkytudaxoa1
            // 
            this.txtdemkytudaxoa1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdemkytudaxoa1.Location = new System.Drawing.Point(75, 129);
            this.txtdemkytudaxoa1.Name = "txtdemkytudaxoa1";
            this.txtdemkytudaxoa1.ReadOnly = true;
            this.txtdemkytudaxoa1.Size = new System.Drawing.Size(324, 37);
            this.txtdemkytudaxoa1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chuỗi cần đổi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đổi thành:";
            // 
            // txtChuoidoi
            // 
            this.txtChuoidoi.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuoidoi.Location = new System.Drawing.Point(220, 200);
            this.txtChuoidoi.Name = "txtChuoidoi";
            this.txtChuoidoi.Size = new System.Drawing.Size(138, 37);
            this.txtChuoidoi.TabIndex = 8;
            this.txtChuoidoi.MouseHover += new System.EventHandler(this.txtChuoidoi_MouseHover);
            // 
            // txtChuoithay
            // 
            this.txtChuoithay.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuoithay.Location = new System.Drawing.Point(220, 247);
            this.txtChuoithay.Name = "txtChuoithay";
            this.txtChuoithay.Size = new System.Drawing.Size(138, 37);
            this.txtChuoithay.TabIndex = 9;
            this.txtChuoithay.MouseHover += new System.EventHandler(this.txtChuoithay_MouseHover);
            // 
            // btExecute
            // 
            this.btExecute.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExecute.Location = new System.Drawing.Point(364, 248);
            this.btExecute.Name = "btExecute";
            this.btExecute.Size = new System.Drawing.Size(133, 36);
            this.btExecute.TabIndex = 10;
            this.btExecute.Text = "Thực hiện";
            this.btExecute.UseVisualStyleBackColor = true;
            this.btExecute.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKQ.Location = new System.Drawing.Point(122, 17);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.ReadOnly = true;
            this.txtKQ.Size = new System.Drawing.Size(277, 37);
            this.txtKQ.TabIndex = 11;
            this.txtKQ.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 33);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kết Quả:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtKQ);
            this.groupBox1.Controls.Add(this.txtdemkytudaxoa1);
            this.groupBox1.Controls.Add(this.txtdemkytudaxoa);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(587, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 175);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(174, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(323, 42);
            this.label6.TabIndex = 14;
            this.label6.Text = "BÀI KIỂM TRA CHUỖI";
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(907, 248);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(94, 36);
            this.btThoat.TabIndex = 16;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(802, 248);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(90, 36);
            this.btXoa.TabIndex = 17;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSoLan
            // 
            this.txtSoLan.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLan.Location = new System.Drawing.Point(722, 247);
            this.txtSoLan.Name = "txtSoLan";
            this.txtSoLan.ReadOnly = true;
            this.txtSoLan.Size = new System.Drawing.Size(65, 37);
            this.txtSoLan.TabIndex = 18;
            // 
            // CB_DoiThay
            // 
            this.CB_DoiThay.AutoSize = true;
            this.CB_DoiThay.Font = new System.Drawing.Font("Calibri", 18F);
            this.CB_DoiThay.Location = new System.Drawing.Point(378, 200);
            this.CB_DoiThay.Name = "CB_DoiThay";
            this.CB_DoiThay.Size = new System.Drawing.Size(119, 33);
            this.CB_DoiThay.TabIndex = 19;
            this.CB_DoiThay.Text = "Đổi Thay";
            this.CB_DoiThay.UseVisualStyleBackColor = true;
            this.CB_DoiThay.CheckedChanged += new System.EventHandler(this.CB_DoiThay_CheckedChanged);
            this.CB_DoiThay.MouseHover += new System.EventHandler(this.CB_DoiThay_MouseHover);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(581, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 33);
            this.label7.TabIndex = 20;
            this.label7.Text = "Số Lần Đổi:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioPB);
            this.groupBox2.Controls.Add(this.radioKoPB);
            this.groupBox2.Location = new System.Drawing.Point(587, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 43);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.MouseHover += new System.EventHandler(this.groupBox2_MouseHover);
            // 
            // radioPB
            // 
            this.radioPB.AutoSize = true;
            this.radioPB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPB.Location = new System.Drawing.Point(229, 9);
            this.radioPB.Name = "radioPB";
            this.radioPB.Size = new System.Drawing.Size(111, 30);
            this.radioPB.TabIndex = 1;
            this.radioPB.TabStop = true;
            this.radioPB.Text = "Phân biệt";
            this.radioPB.UseVisualStyleBackColor = true;
            // 
            // radioKoPB
            // 
            this.radioKoPB.AutoSize = true;
            this.radioKoPB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioKoPB.Location = new System.Drawing.Point(6, 9);
            this.radioKoPB.Name = "radioKoPB";
            this.radioKoPB.Size = new System.Drawing.Size(170, 30);
            this.radioKoPB.TabIndex = 0;
            this.radioKoPB.TabStop = true;
            this.radioKoPB.Text = "Không phân biệt";
            this.radioKoPB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1030, 306);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CB_DoiThay);
            this.Controls.Add(this.txtSoLan);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btExecute);
            this.Controls.Add(this.txtChuoithay);
            this.Controls.Add(this.txtChuoidoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHocPhi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNhapC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNhapC1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdemkytudaxoa;
        private System.Windows.Forms.TextBox txtHocPhi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdemkytudaxoa1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChuoidoi;
        private System.Windows.Forms.TextBox txtChuoithay;
        private System.Windows.Forms.Button btExecute;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.TextBox txtSoLan;
        private System.Windows.Forms.CheckBox CB_DoiThay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioPB;
        private System.Windows.Forms.RadioButton radioKoPB;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}

