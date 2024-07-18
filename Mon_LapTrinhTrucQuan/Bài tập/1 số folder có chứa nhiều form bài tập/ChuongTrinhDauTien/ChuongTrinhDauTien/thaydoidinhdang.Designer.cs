
namespace ChuongTrinhDauTien
{
    partial class thaydoidinhdang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hovaten = new System.Windows.Forms.TextBox();
            this.CB_thaydoi = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "CheckBox trong C#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và Tên";
            // 
            // hovaten
            // 
            this.hovaten.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hovaten.Location = new System.Drawing.Point(131, 92);
            this.hovaten.Name = "hovaten";
            this.hovaten.Size = new System.Drawing.Size(213, 29);
            this.hovaten.TabIndex = 2;
            this.hovaten.TextChanged += new System.EventHandler(this.hovaten_TextChanged);
            // 
            // CB_thaydoi
            // 
            this.CB_thaydoi.AutoSize = true;
            this.CB_thaydoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_thaydoi.Location = new System.Drawing.Point(51, 140);
            this.CB_thaydoi.Name = "CB_thaydoi";
            this.CB_thaydoi.Size = new System.Drawing.Size(276, 26);
            this.CB_thaydoi.TabIndex = 3;
            this.CB_thaydoi.Text = "Thay đổi định dạng Họ và Tên";
            this.CB_thaydoi.UseVisualStyleBackColor = true;
            this.CB_thaydoi.CheckedChanged += new System.EventHandler(this.CB_thaydoi_CheckedChanged);
            // 
            // thaydoidinhdang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 182);
            this.Controls.Add(this.CB_thaydoi);
            this.Controls.Add(this.hovaten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "thaydoidinhdang";
            this.Text = "thaydoidinhdang";
            this.Load += new System.EventHandler(this.thaydoidinhdang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hovaten;
        private System.Windows.Forms.CheckBox CB_thaydoi;
    }
}