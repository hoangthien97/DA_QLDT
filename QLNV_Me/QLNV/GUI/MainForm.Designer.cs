namespace QLNV.GUI
{
    partial class MainForm
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
            this.btnShop = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnDienThoai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(78, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone Shop";
            // 
            // btnShop
            // 
            this.btnShop.Location = new System.Drawing.Point(234, 147);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(131, 36);
            this.btnShop.TabIndex = 1;
            this.btnShop.Text = "Vào Cửa Hàng";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(371, 147);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(131, 36);
            this.btnNhanVien.TabIndex = 2;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnDienThoai
            // 
            this.btnDienThoai.Location = new System.Drawing.Point(97, 147);
            this.btnDienThoai.Name = "btnDienThoai";
            this.btnDienThoai.Size = new System.Drawing.Size(131, 36);
            this.btnDienThoai.TabIndex = 3;
            this.btnDienThoai.Text = "Điện Thoại";
            this.btnDienThoai.UseVisualStyleBackColor = true;
            this.btnDienThoai.Click += new System.EventHandler(this.btnDienThoai_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 234);
            this.Controls.Add(this.btnDienThoai);
            this.Controls.Add(this.btnNhanVien);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnDienThoai;
    }
}