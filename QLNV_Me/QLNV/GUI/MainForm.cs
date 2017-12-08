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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            var formShop = new Form1();
            formShop.Show();
        }

        private void btnDienThoai_Click(object sender, EventArgs e)
        {
            var formDT = new FormThemDienThoai();
            formDT.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            var formNV = new FormNV();
            formNV.Show();
        }
    }
}
