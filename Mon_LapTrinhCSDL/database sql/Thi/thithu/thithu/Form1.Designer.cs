
namespace thithu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hethong = new System.Windows.Forms.ToolStripMenuItem();
            this.dangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.danhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.danhmucsanpham = new System.Windows.Forms.ToolStripMenuItem();
            this.chitietbanhang = new System.Windows.Forms.ToolStripMenuItem();
            this.inhoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(521, 241);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hethong,
            this.danhmuc,
            this.chitietbanhang,
            this.inhoadon});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 7;
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
            // danhmuc
            // 
            this.danhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhmucsanpham});
            this.danhmuc.Name = "danhmuc";
            this.danhmuc.Size = new System.Drawing.Size(83, 20);
            this.danhmuc.Text = "DANH MỤC";
            // 
            // danhmucsanpham
            // 
            this.danhmucsanpham.Name = "danhmucsanpham";
            this.danhmucsanpham.Size = new System.Drawing.Size(202, 22);
            this.danhmucsanpham.Text = "DANH MỤC SẢN PHẨM";
            this.danhmucsanpham.Click += new System.EventHandler(this.danhmucsanpham_Click);
            // 
            // chitietbanhang
            // 
            this.chitietbanhang.Name = "chitietbanhang";
            this.chitietbanhang.Size = new System.Drawing.Size(127, 20);
            this.chitietbanhang.Text = "CHI TIẾT BÁN HÀNG";
            this.chitietbanhang.Click += new System.EventHandler(this.chitietbanhang_Click);
            // 
            // inhoadon
            // 
            this.inhoadon.Name = "inhoadon";
            this.inhoadon.Size = new System.Drawing.Size(89, 20);
            this.inhoadon.Text = "IN HÓA ĐƠN";
            this.inhoadon.Click += new System.EventHandler(this.inhoadon_Click);
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
            this.ClientSize = new System.Drawing.Size(521, 268);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hethong;
        private System.Windows.Forms.ToolStripMenuItem dangnhap;
        private System.Windows.Forms.ToolStripMenuItem thoat;
        public System.Windows.Forms.ToolStripMenuItem danhmuc;
        private System.Windows.Forms.ToolStripMenuItem danhmucsanpham;
        public System.Windows.Forms.ToolStripMenuItem chitietbanhang;
        public System.Windows.Forms.ToolStripMenuItem inhoadon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}

