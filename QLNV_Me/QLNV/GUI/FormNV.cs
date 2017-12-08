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
    public partial class FormNV : Form
    {
        public FormNV()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Thêm Nhân Viên", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (DialogResult == DialogResult.OK)
            {
                int Status;
                string Messages = string.Empty;
                string MaNV = txtMaNhanVien.Text;
                string TenNV = txtTenNhanVien.Text;
                string SDT_NV = txtSDT.Text;
                string DiaChi_NV = txtDiaChi.Text;
                Status = DienThoaiKernel.DienThoaiKernel.ThemNhanVien(MaNV, TenNV, SDT_NV, DiaChi_NV, ref Messages);
                if (Status > 0)
                {
                    MessageBox.Show(Messages);
                    FormNV_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(Messages);
                    FormNV_Load(sender, e);
                }
                FormNV_Load(sender, e);
            }
        }

        private void FormNV_Load(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = DienThoaiKernel.DienThoaiKernel.HienThiNhanVien();
            dgvNhanVien.DataSource = DT;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("xóa Nhân Viên", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (DialogResult == DialogResult.OK)
            {
                string MaNV = txtMaNhanVien.Text;
                int status;
                string Messages = string.Empty;
                status = DienThoaiKernel.DienThoaiKernel.XoaNhanVien(MaNV,ref Messages);
                if (status > 0)
                {
                    MessageBox.Show(Messages);
                    FormNV_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(Messages);
                    FormNV_Load(sender, e);
                }
                FormNV_Load(sender, e);
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = this.dgvNhanVien.Rows[e.RowIndex];
                txtMaNhanVien.Text = Row.Cells["MaNV"].Value.ToString();
                txtDiaChi.Text = Row.Cells["DiaChi_NV"].Value.ToString();
                txtSDT.Text = Row.Cells["SDT_NV"].Value.ToString();
                txtTenNhanVien.Text = Row.Cells["TenNV"].Value.ToString();

            }
        }
    }
}
