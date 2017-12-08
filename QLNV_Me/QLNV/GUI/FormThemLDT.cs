using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNV.GUI
{
    public partial class FormLDT : Form
    {
        public FormLDT()
        {
            InitializeComponent();
        }

        private void FormThemLDT_Load(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = DienThoaiKernel.DienThoaiKernel.HienThiLoaiDT();
            dgvLoaiDT.DataSource = DT;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Thêm Điện Thoại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (DialogResult == DialogResult.OK)
            {
                int Status;
                string Messages = string.Empty;
                string MaLDT = txtMaLDT.Text;
                string TenLDT = txtTenLoaiDT.Text;
                Status = DienThoaiKernel.DienThoaiKernel.ThemLoaiDienThoai(MaLDT, TenLDT, ref Messages);
                if (Status > 0)
                {
                    MessageBox.Show(Messages);
                    FormThemLDT_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(Messages);
                    FormThemLDT_Load(sender, e);
                }
                FormThemLDT_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("xóa loại điện thoại", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (DialogResult == DialogResult.OK)
            {
                string MaLDT = txtMaLDT.Text;
                int status;
                string Messages = string.Empty;
                status = DienThoaiKernel.DienThoaiKernel.XoaLoaiDienThoai(MaLDT, ref Messages);
                if (status > 0)
                {
                    MessageBox.Show(Messages);
                    FormThemLDT_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(Messages);
                    FormThemLDT_Load(sender, e);
                }
                FormThemLDT_Load(sender, e);
            }
        }

        private void dgvLoaiDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = this.dgvLoaiDT.Rows[e.RowIndex];
                txtMaLDT.Text = Row.Cells["MaLDT"].Value.ToString();
                txtTenLoaiDT.Text = Row.Cells["TenLDT"].Value.ToString();
            }
        }
    }
}
