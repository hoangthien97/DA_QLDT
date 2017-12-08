namespace QLNV
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btntk = new System.Windows.Forms.Button();
            this.cbbLoaiDT = new System.Windows.Forms.ComboBox();
            this.cbbGia = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.txtSystem = new System.Windows.Forms.TextBox();
            this.txtROM = new System.Windows.Forms.TextBox();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.txtCameraSau = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCameraTruoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtManHinh = new System.Windows.Forms.TextBox();
            this.btnXoaTatCa = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.svExportNV = new System.Windows.Forms.SaveFileDialog();
            this.dgvDSDT = new System.Windows.Forms.DataGridView();
            this.btnlhd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDT)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReload);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btntk);
            this.groupBox1.Controls.Add(this.cbbLoaiDT);
            this.groupBox1.Controls.Add(this.cbbGia);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(13, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(361, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Giá";
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(93, 137);
            this.btntk.Margin = new System.Windows.Forms.Padding(4);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(144, 47);
            this.btntk.TabIndex = 13;
            this.btntk.Text = "Tìm kiếm";
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbLoaiDT
            // 
            this.cbbLoaiDT.FormattingEnabled = true;
            this.cbbLoaiDT.Location = new System.Drawing.Point(141, 44);
            this.cbbLoaiDT.Name = "cbbLoaiDT";
            this.cbbLoaiDT.Size = new System.Drawing.Size(110, 24);
            this.cbbLoaiDT.TabIndex = 33;
            // 
            // cbbGia
            // 
            this.cbbGia.FormattingEnabled = true;
            this.cbbGia.Items.AddRange(new object[] {
            "Trên 18",
            "Từ 10 - 18",
            "Dưới 10"});
            this.cbbGia.Location = new System.Drawing.Point(141, 84);
            this.cbbGia.Name = "cbbGia";
            this.cbbGia.Size = new System.Drawing.Size(189, 24);
            this.cbbGia.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 47);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 17);
            this.label10.TabIndex = 32;
            this.label10.Text = "Loại Điện Thoại";
            // 
            // txtGia
            // 
            this.txtGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGia.Location = new System.Drawing.Point(378, 39);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(93, 22);
            this.txtGia.TabIndex = 35;
            this.txtGia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(269, 44);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "Giá";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(65, 168);
            this.txtPin.Margin = new System.Windows.Forms.Padding(4);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(196, 22);
            this.txtPin.TabIndex = 31;
            // 
            // txtSystem
            // 
            this.txtSystem.Location = new System.Drawing.Point(65, 123);
            this.txtSystem.Margin = new System.Windows.Forms.Padding(4);
            this.txtSystem.Name = "txtSystem";
            this.txtSystem.Size = new System.Drawing.Size(196, 22);
            this.txtSystem.TabIndex = 29;
            // 
            // txtROM
            // 
            this.txtROM.Location = new System.Drawing.Point(65, 81);
            this.txtROM.Margin = new System.Windows.Forms.Padding(4);
            this.txtROM.Name = "txtROM";
            this.txtROM.Size = new System.Drawing.Size(196, 22);
            this.txtROM.TabIndex = 28;
            // 
            // txtRAM
            // 
            this.txtRAM.Location = new System.Drawing.Point(65, 44);
            this.txtRAM.Margin = new System.Windows.Forms.Padding(4);
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.Size = new System.Drawing.Size(196, 22);
            this.txtRAM.TabIndex = 27;
            // 
            // txtCameraSau
            // 
            this.txtCameraSau.Location = new System.Drawing.Point(378, 163);
            this.txtCameraSau.Margin = new System.Windows.Forms.Padding(4);
            this.txtCameraSau.Name = "txtCameraSau";
            this.txtCameraSau.Size = new System.Drawing.Size(196, 22);
            this.txtCameraSau.TabIndex = 26;
            this.txtCameraSau.TextChanged += new System.EventHandler(this.txtCameraSau_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 167);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Pin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 122);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "System";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 84);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "ROM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "RAM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 168);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Camera Sau";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtCameraTruoc
            // 
            this.txtCameraTruoc.Location = new System.Drawing.Point(378, 119);
            this.txtCameraTruoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtCameraTruoc.Name = "txtCameraTruoc";
            this.txtCameraTruoc.Size = new System.Drawing.Size(211, 22);
            this.txtCameraTruoc.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Camera Trước";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Màn Hình";
            // 
            // txtManHinh
            // 
            this.txtManHinh.Location = new System.Drawing.Point(378, 79);
            this.txtManHinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtManHinh.Name = "txtManHinh";
            this.txtManHinh.Size = new System.Drawing.Size(211, 22);
            this.txtManHinh.TabIndex = 16;
            this.txtManHinh.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnXoaTatCa
            // 
            this.btnXoaTatCa.Location = new System.Drawing.Point(592, 281);
            this.btnXoaTatCa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaTatCa.Name = "btnXoaTatCa";
            this.btnXoaTatCa.Size = new System.Drawing.Size(100, 28);
            this.btnXoaTatCa.TabIndex = 11;
            this.btnXoaTatCa.Text = "Xóa Tất Cả";
            this.btnXoaTatCa.UseVisualStyleBackColor = true;
            this.btnXoaTatCa.Click += new System.EventHandler(this.btnXoaTatCa_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(700, 281);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 28);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(360, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cửa Hàng Điện Thoại";
            // 
            // dgvDSDT
            // 
            this.dgvDSDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDT.Location = new System.Drawing.Point(12, 316);
            this.dgvDSDT.MultiSelect = false;
            this.dgvDSDT.Name = "dgvDSDT";
            this.dgvDSDT.RowTemplate.Height = 24;
            this.dgvDSDT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSDT.Size = new System.Drawing.Size(995, 317);
            this.dgvDSDT.TabIndex = 16;
            this.dgvDSDT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDT_CellContentClick);
            this.dgvDSDT.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDSDT_CellMouseClick);
            this.dgvDSDT.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDSDT_RowHeaderMouseClick);
            // 
            // btnlhd
            // 
            this.btnlhd.Location = new System.Drawing.Point(897, 281);
            this.btnlhd.Margin = new System.Windows.Forms.Padding(4);
            this.btnlhd.Name = "btnlhd";
            this.btnlhd.Size = new System.Drawing.Size(110, 28);
            this.btnlhd.TabIndex = 36;
            this.btnlhd.Text = "Lập Hóa Đơn";
            this.btnlhd.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRAM);
            this.groupBox2.Controls.Add(this.txtGia);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtCameraTruoc);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtPin);
            this.groupBox2.Controls.Add(this.txtManHinh);
            this.groupBox2.Controls.Add(this.txtCameraSau);
            this.groupBox2.Controls.Add(this.txtSystem);
            this.groupBox2.Controls.Add(this.txtROM);
            this.groupBox2.Location = new System.Drawing.Point(381, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 226);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(245, 137);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(108, 47);
            this.btnReload.TabIndex = 35;
            this.btnReload.Text = "Tất Cả";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 645);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnlhd);
            this.Controls.Add(this.dgvDSDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnXoaTatCa);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1037, 692);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Cửa Hàng Điện Thoại";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDT)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog svExportNV;
        private System.Windows.Forms.Button btnXoaTatCa;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.ComboBox cbbGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtManHinh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCameraTruoc;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.TextBox txtSystem;
        private System.Windows.Forms.TextBox txtROM;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.TextBox txtCameraSau;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbLoaiDT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvDSDT;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnlhd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReload;
    }
}

