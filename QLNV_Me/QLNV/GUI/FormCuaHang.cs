using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;


namespace QLNV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //ComboboxItem item = new ComboboxItem();
            //item.Text = "Item text1";
            //item.Value = 12;

            //cbbGia.Items.Add(item);

            //cbbGia.SelectedIndex = 0;
            /*string Constr = @"Data Source=DUCPHAN;Initial Catalog=QLNV;Integrated Security=True";
            string cautruyvan = "select * from NhanVien";
            DataSet ds = new DataSet();
            SqlDataAdapter adt = new SqlDataAdapter(cautruyvan,Constr);
            adt.Fill(ds, "NhanVien");     
            //ds.Relations.Add("NV", new DataColumn[] { ds.Tables[0].Columns["ID"] },
            //   new DataColumn[] { ds.Tables[1].Columns["ID"] });
            dgvDSNhanVien.DataSource = ds;
            dgvDSNhanVien.DataMember = "NhanVien";
            cboNhanVien.DataSource = ds;
            cboNhanVien.DisplayMember = "NhanVien.HoTen";
            cboNhanVien.ValueMember = "ID";*/
            /*  SqlConnection SqlConn = new SqlConnection();
              SqlConn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["QLNVDuc"].ConnectionString;
              DataTable Dt = new DataTable();
              SqlConn.Open();
              SqlCommand SqlCmd = new SqlCommand("HienThiNhanVien",SqlConn);
              SqlCmd.CommandType = CommandType.StoredProcedure;
              SqlDataAdapter SqlAda = new SqlDataAdapter(SqlCmd);
              SqlAda.Fill(Dt);
              dgvDSNhanVien.DataSource = Dt;
              SqlConn.Close();*/
            DataTable DT = new DataTable();
            DT = DienThoaiKernel.DienThoaiKernel.HienThiDienThoai();
            dgvDSDT.DataSource = DT;
            //dgvDSNhanVien.Columns["ID"].Visible = false;
            //  DataTable DTCV = new DataTable();
            //DT = DienThoaiKernel.DienThoaiKernel.HienThiChucVu();
            //cbChucVu.DataSource = DT;
            //cbChucVu.ValueMember = "ID";
            //cbChucVu.DisplayMember = "ChucVu";
            //DT = DienThoaiKernel.DienThoaiKernel.HienThiChiNhanh();
            //cbbChiNhanh.DataSource = DT;
            //cbbChiNhanh.DisplayMember = "ChiNhanh";
            //cbbChiNhanh.ValueMember = "ID";
            DT = DienThoaiKernel.DienThoaiKernel.TimTheoGia();
            cbbGia.DataSource = DT;
            cbbGia.ValueMember = "IDTimKiem";
            cbbGia.DisplayMember = "TenTimKiem";
            DT = DienThoaiKernel.DienThoaiKernel.HienThiLoaiDT();
            cbbLoaiDT.DataSource = DT;
            cbbLoaiDT.ValueMember = "MaLDT";
            cbbLoaiDT.DisplayMember = "TenLDT";
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
           
            
              
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            

        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void btnChamcong_Click(object sender, EventArgs e)
        {

        }

        

        private void dgvDSDT_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = this.dgvDSDT.Rows[e.RowIndex];
                txtCameraSau.Text = Row.Cells["CameraSau"].Value.ToString();
                txtCameraTruoc.Text = Row.Cells["CameraTruoc"].Value.ToString();
                txtROM.Text = Row.Cells["ROM"].Value.ToString();
                txtRAM.Text = Row.Cells["RAM"].Value.ToString();
                txtPin.Text = Row.Cells["Pin"].Value.ToString();
                txtManHinh.Text = Row.Cells["ManHinh"].Value.ToString();
                txtGia.Text = Row.Cells["GiaThanh"].Value.ToString();
                txtSystem.Text = Row.Cells["System"].Value.ToString();
                cbbLoaiDT.SelectedValue = Row.Cells["MaLDT"].Value.ToString();
            }
        }

       
        void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
        }

      private void btnSua_Click(object sender, EventArgs e)
        {
            
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
          
            svExportNV.Filter = "Excel|*.xls";
            svExportNV.DefaultExt = ".xls";
            svExportNV.FilterIndex = 0;
            svExportNV.AddExtension = true;
            svExportNV.ShowDialog();
            svExportNV.FileOk += SvExportNV_FileOk1;
           

        }

        private void SvExportNV_FileOk1(object sender, CancelEventArgs e)
        {
            int Status;
            string Messages = string.Empty;
            string FileName = Path.GetFileName(svExportNV.FileName);
            string FilePath = Path.GetDirectoryName(svExportNV.FileName);
            Status = DienThoaiKernel.DienThoaiKernel.ExportDoanhThuThang(ref Messages, FilePath, FileName);
            if (Status > 0)
            {
                MessageBox.Show(Messages);
            }
            else
            {
                MessageBox.Show(Messages);
            }
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvDSDT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = this.dgvDSDT.Rows[e.RowIndex];
                txtGia.Text = Row.Cells["GiaThanh"].Value.ToString();
                txtCameraSau.Text = Row.Cells["CameraSau"].Value.ToString();
                txtCameraTruoc.Text = Row.Cells["CameraTruoc"].Value.ToString();
                txtROM.Text = Row.Cells["ROM"].Value.ToString();
                txtRAM.Text = Row.Cells["RAM"].Value.ToString();
                txtPin.Text = Row.Cells["Pin"].Value.ToString();
                txtManHinh.Text = Row.Cells["ManHinh"].Value.ToString();
                txtSystem.Text = Row.Cells["System"].Value.ToString();
                cbbLoaiDT.SelectedValue = Row.Cells["MaLDT"].Value.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtCameraSau_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            int IDGia = int.Parse(cbbGia.SelectedValue.ToString());
            DT = DienThoaiKernel.DienThoaiKernel.SapXepSanPhamTheoGia(IDGia);
            dgvDSDT.DataSource = DT;

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDSDT_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = this.dgvDSDT.Rows[e.RowIndex];
                txtGia.Text = Row.Cells["GiaThanh"].Value.ToString();
                txtCameraSau.Text = Row.Cells["CameraSau"].Value.ToString();
                txtCameraTruoc.Text = Row.Cells["CameraTruoc"].Value.ToString();
                txtROM.Text = Row.Cells["ROM"].Value.ToString();
                txtRAM.Text = Row.Cells["RAM"].Value.ToString();
                txtPin.Text = Row.Cells["Pin"].Value.ToString();
                txtManHinh.Text = Row.Cells["ManHinh"].Value.ToString();
                txtSystem.Text = Row.Cells["System"].Value.ToString();
                cbbLoaiDT.SelectedValue = Row.Cells["MaLDT"].Value.ToString();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
    }
}
