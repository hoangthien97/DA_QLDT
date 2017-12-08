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

namespace QLNV
{
    public partial class FormLogin : Form
    {
        Form1 fr;
        string strconnection = @"Data Source=PHAMLOC-PC\SQLEXPRESS;Initial Catalog=QLNV;Integrated Security=True";
        SqlConnection conn;
        SqlCommand command;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strconnection);
                conn.Open();
                string sql = "select Count(*) from TaiKhoan  where TaiKhoan = @acc And Matkhau = @pass";
                command = new SqlCommand(sql, conn);
                command.Parameters.Add(new SqlParameter("@acc", txtAccount.Text));
                command.Parameters.Add(new SqlParameter("@pass", txtPassword.Text));
                int x = (int)command.ExecuteScalar();
                if (x == 1)
                {
                    //đăng nhập thành công
                    this.Hide();
                    fr = new Form1();
                    fr.Show();

                }
                else
                {
                    //đăng nhập thất bại
                    label3.Text = "Tài khoản hoặc mật khẩu không chính xác";
                    txtAccount.Text = "";
                    txtPassword.Text = "";
                    txtAccount.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ckbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
