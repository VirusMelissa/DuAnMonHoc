
namespace QL_GIANGVIEN2
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hethong = new System.Windows.Forms.ToolStripMenuItem();
            this.dangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.danhsach = new System.Windows.Forms.ToolStripMenuItem();
            this.phancong = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hethong,
            this.danhsach,
            this.phancong});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(460, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hethong
            // 
            this.hethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangnhap,
            this.thoat});
            this.hethong.Name = "hethong";
            this.hethong.Size = new System.Drawing.Size(78, 20);
            this.hethong.Text = "HỆ THỐNG";
            // 
            // dangnhap
            // 
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(180, 22);
            this.dangnhap.Text = "ĐĂNG NHẬP";
            this.dangnhap.Click += new System.EventHandler(this.dangnhap_Click);
            // 
            // thoat
            // 
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(180, 22);
            this.thoat.Text = "THOÁT";
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // danhsach
            // 
            this.danhsach.Name = "danhsach";
            this.danhsach.Size = new System.Drawing.Size(154, 20);
            this.danhsach.Text = "DANH SÁCH GIẢNG VIÊN";
            this.danhsach.Click += new System.EventHandler(this.danhsach_Click);
            // 
            // phancong
            // 
            this.phancong.Name = "phancong";
            this.phancong.Size = new System.Drawing.Size(89, 20);
            this.phancong.Text = "PHÂN CÔNG";
            this.phancong.Click += new System.EventHandler(this.phancong_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 101);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hethong;
        private System.Windows.Forms.ToolStripMenuItem dangnhap;
        private System.Windows.Forms.ToolStripMenuItem thoat;
        public System.Windows.Forms.ToolStripMenuItem danhsach;
        public System.Windows.Forms.ToolStripMenuItem phancong;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}

