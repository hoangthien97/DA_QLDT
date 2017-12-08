namespace QLNV.GUI
{
    partial class FormLDT
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
            this.txtTenLoaiDT = new System.Windows.Forms.TextBox();
            this.txtMaLDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvLoaiDT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDT)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenLoaiDT
            // 
            this.txtTenLoaiDT.Location = new System.Drawing.Point(175, 138);
            this.txtTenLoaiDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLoaiDT.Name = "txtTenLoaiDT";
            this.txtTenLoaiDT.Size = new System.Drawing.Size(211, 22);
            this.txtTenLoaiDT.TabIndex = 18;
            // 
            // txtMaLDT
            // 
            this.txtMaLDT.Location = new System.Drawing.Point(175, 95);
            this.txtMaLDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLDT.Name = "txtMaLDT";
            this.txtMaLDT.Size = new System.Drawing.Size(211, 22);
            this.txtMaLDT.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên Loại Điện Thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã Loại Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 58);
            this.label3.TabIndex = 19;
            this.label3.Text = "Loại Điện Thoại";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(199, 181);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(307, 181);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 28);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(91, 181);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvLoaiDT
            // 
            this.dgvLoaiDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiDT.Location = new System.Drawing.Point(12, 225);
            this.dgvLoaiDT.Name = "dgvLoaiDT";
            this.dgvLoaiDT.RowTemplate.Height = 24;
            this.dgvLoaiDT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiDT.Size = new System.Drawing.Size(474, 202);
            this.dgvLoaiDT.TabIndex = 49;
            this.dgvLoaiDT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiDT_CellClick);
            // 
            // FormLDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 439);
            this.Controls.Add(this.dgvLoaiDT);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenLoaiDT);
            this.Controls.Add(this.txtMaLDT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLDT";
            this.Text = "Quản Lý Loại Điện Thoại";
            this.Load += new System.EventHandler(this.FormThemLDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenLoaiDT;
        private System.Windows.Forms.TextBox txtMaLDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvLoaiDT;
    }
}