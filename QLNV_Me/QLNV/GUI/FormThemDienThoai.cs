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
    public partial class FormThemDienThoai : Form
    {
        public FormThemDienThoai()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void FormThemDienThoai_Load(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = DienThoaiKernel.DienThoaiKernel.HienThiDienThoai();
            dgvDSDT.DataSource = DT;
            DT = DienThoaiKernel.DienThoaiKernel.HienThiLoaiDT();
            cbbLDT.DataSource = DT;
            cbbLDT.ValueMember = "MaLDT";
            cbbLDT.DisplayMember = "TenLDT";
        }

        private void dgvDSDT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = this.dgvDSDT.Rows[e.RowIndex];
                txtCameraSau1.Text = Row.Cells["CameraSau"].Value.ToString();
                txtCameraTruoc1.Text = Row.Cells["CameraTruoc"].Value.ToString();
                txtROM1.Text = Row.Cells["ROM"].Value.ToString();
                txtRAM1.Text = Row.Cells["RAM"].Value.ToString();
                txtPin1.Text = Row.Cells["Pin"].Value.ToString();
                txtManHinh1.Text = Row.Cells["ManHinh"].Value.ToString();
                txtGia1.Text = Row.Cells["GiaThanh"].Value.ToString();
                txtSystem1.Text = Row.Cells["System"].Value.ToString();
                txtMaDT1.Text = Row.Cells["MaDT"].Value.ToString();
                cbbLDT.SelectedValue = Row.Cells["MaLDT"].Value.ToString();
                txtTenDT1.Text = Row.Cells["TenDT"].Value.ToString();
            }
        }

        private void dgvDSDT_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = this.dgvDSDT.Rows[e.RowIndex];
                txtMaDT1.Text = Row.Cells["MaDT"].Value.ToString();
                txtCameraSau1.Text = Row.Cells["CameraSau"].Value.ToString();
                txtCameraTruoc1.Text = Row.Cells["CameraTruoc"].Value.ToString();
                txtROM1.Text = Row.Cells["ROM"].Value.ToString();
                txtRAM1.Text = Row.Cells["RAM"].Value.ToString();
                txtPin1.Text = Row.Cells["Pin"].Value.ToString();
                txtManHinh1.Text = Row.Cells["ManHinh"].Value.ToString();
                ///*txtGia1*/.Text = Row.Cells["GiaThanh"].Value.ToString();
                txtSystem1.Text = Row.Cells["System"].Value.ToString();
                cbbLDT.SelectedValue = Row.Cells["MaLDT"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Thêm Điện Thoại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (DialogResult == DialogResult.OK)
            {
                int Status;
                string Messages = string.Empty;
                string MaDT = txtMaDT1.Text;
                string TenDT = txtTenDT1.Text;
                string MaLDT = cbbLDT.SelectedValue.ToString();
                string ManHinh = txtManHinh1.Text;
                string CameraTruoc = txtCameraTruoc1.Text;
                string CameraSau = txtCameraSau1.Text;
                string RAM = txtRAM1.Text;
                string ROM = txtROM1.Text;
                string System = txtSystem1.Text;
                string Pin = txtPin1.Text;
                float GiaThanh = float.Parse(txtGia1.Text);
                Status = DienThoaiKernel.DienThoaiKernel.ThemDienThoai(MaDT,TenDT,ManHinh,MaLDT,CameraTruoc,CameraSau,RAM,ROM,System
                    ,Pin,GiaThanh,ref Messages);
                if (Status > 0)
                {
                    MessageBox.Show(Messages);
                    FormThemDienThoai_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(Messages);
                    FormThemDienThoai_Load(sender, e);
                }
                FormThemDienThoai_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("xóa điện thoại", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (DialogResult == DialogResult.OK)
            {
                string MaDT = txtMaDT1.Text;
                string MaLDT = cbbLDT.SelectedValue.ToString();
                int status;
                string Messages = string.Empty;
                status = DienThoaiKernel.DienThoaiKernel.XoaDienThoai( MaDT,  MaLDT, ref  Messages);
                if (status > 0)
                {
                    MessageBox.Show(Messages);
                    FormThemDienThoai_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(Messages);
                    FormThemDienThoai_Load(sender, e);
                }
                FormThemDienThoai_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //int Status;
            //string Messages = string.Empty;
            //string MaDTCu = dgvDSDT.SelectedCells[0].Value.ToString();
            //string MaDTNew = txtMaDT1.Text;
            //string TenDTNew = txtTenDT1.Text;
            //string ManHinhNew = txtManHinh1.Text;
            //string CameraSauNew = txtCameraSau1.Text;
            //string CameraTruocNew = txtCameraTruoc1.Text;
            //string RAMNew = txtRAM1.Text;
            //string ROMNew = txtROM1.Text;
            //string SystemNew = txtSystem1.Text;
            //string PinNew = txtPin1.Text;
            //string MaLDTNew = cbbLDT.SelectedValue.ToString();
            //float GiaThanhNew = float.Parse(txtGia1.Text);
            //Status = DienThoaiKernel.DienThoaiKernel.SuaDienThoai(MaDTCu, ref  Messages,MaDTNew,TenDTNew,ManHinhNew,MaLDTNew,CameraTruocNew
            //                                                         ,CameraSauNew,RAMNew,ROMNew,SystemNew,PinNew,GiaThanhNew);


            //if (Status > 0)
            //{
            //    MessageBox.Show(Messages);
            //    FormThemDienThoai_Load(sender, e);
            //}
            //else
            //{
            //    MessageBox.Show(Messages);
            //    FormThemDienThoai_Load(sender, e);
            //}
            //FormThemDienThoai_Load(sender, e);
        }

        private void btnChangeLDTForm_Click(object sender, EventArgs e)
        {
            var formLDT = new FormLDT();
            formLDT.Show();
        }
    }
}
