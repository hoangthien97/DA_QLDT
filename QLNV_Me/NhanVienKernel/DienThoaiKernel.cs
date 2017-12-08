using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace DienThoaiKernel

{
    public static class DienThoaiKernel
    {
        public static DataTable HienThiDienThoai()
        {
            SqlConnection SqlConn = new SqlConnection();
            SqlConn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["QLDT"].ConnectionString;
            DataTable Dt = new DataTable();
            SqlConn.Open();
            SqlCommand SqlCmd = new SqlCommand("HienThiDienThoai", SqlConn);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter SqlAda = new SqlDataAdapter(SqlCmd);
            SqlAda.Fill(Dt);
            SqlConn.Close();
            return Dt;
        }
        public static DataTable HienThiNhanVien()
        {
            SqlConnection SqlConn = new SqlConnection();
            SqlConn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["QLDT"].ConnectionString;
            DataTable Dt = new DataTable();
            SqlConn.Open();
            SqlCommand SqlCmd = new SqlCommand("HienThiNhanVien", SqlConn);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter SqlAda = new SqlDataAdapter(SqlCmd);
            SqlAda.Fill(Dt);
            SqlConn.Close();
            return Dt;
        }

        public static DataTable TimTheoGia()
        {
            SqlConnection SqlConn = new SqlConnection();
            SqlConn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["QLDT"].ConnectionString;
            DataTable Dt = new DataTable();
            SqlConn.Open();
            SqlCommand SqlCmd = new SqlCommand("TimTheoGIa", SqlConn);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter SqlAda = new SqlDataAdapter(SqlCmd);
            SqlAda.Fill(Dt);
            SqlConn.Close();
            return Dt;
        }
        public static DataTable HienThiLoaiDT()
        {
            SqlConnection SqlConn = new SqlConnection();
            SqlConn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["QLDT"].ConnectionString;
            DataTable Dt = new DataTable();
            SqlConn.Open();
            SqlCommand SqlCmd = new SqlCommand("HienThiLoaiDT", SqlConn);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter SqlAda = new SqlDataAdapter(SqlCmd);
            SqlAda.Fill(Dt);
            SqlConn.Close();
            return Dt;
        }
        public static DataTable SapXepSanPhamTheoGia(int IDGia)
        {
            SqlConnection SqlConn = new SqlConnection();
            SqlConn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["QLDT"].ConnectionString;
            DataTable Dt = new DataTable();
            SqlConn.Open();
            SqlCommand SqlCmd = new SqlCommand("SapXepSanPhamTheoGia", SqlConn);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter SqlAda = new SqlDataAdapter(SqlCmd);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@IDGia", IDGia);
            SqlAda.Fill(Dt);
            SqlConn.Close();
            return Dt;
        }
        public static int ThemDienThoai(string MaDT, string TenDT, string ManHinh, string MaLDT,string CameraTruoc, string CameraSau
            , string RAM, string ROM, string System, string Pin, float GiaThanh, ref string Messages)
        {
            SqlConnection SqlConn = new SqlConnection();
            SqlConn.ConnectionString = ConfigurationManager.ConnectionStrings["QLDT"].ConnectionString;
            SqlConn.Open();
            int Status;
            SqlCommand SqlCmd = new SqlCommand("ThemDienThoai", SqlConn);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@MaDT", MaDT);
            SqlCmd.Parameters.AddWithValue("@TenDT", TenDT);
            SqlCmd.Parameters.AddWithValue("@ManHinh", ManHinh);
            SqlCmd.Parameters.AddWithValue("@MaLDT", MaLDT);
            SqlCmd.Parameters.AddWithValue("@CameraTruoc", CameraTruoc);
            SqlCmd.Parameters.AddWithValue("@CameraSau", CameraSau);
            SqlCmd.Parameters.AddWithValue("@RAM", RAM);
            SqlCmd.Parameters.AddWithValue("@ROM", ROM);
            SqlCmd.Parameters.AddWithValue("@System", System);
            SqlCmd.Parameters.AddWithValue("@Pin", Pin);
            SqlCmd.Parameters.AddWithValue("@GiaThanh", GiaThanh);
            SqlCmd.Parameters.Add("@Status",SqlDbType.Int);
            SqlCmd.Parameters["@Status"].Direction = ParameterDirection.Output;
            SqlCmd.Parameters.Add("@Message", SqlDbType.NVarChar,50);
            SqlCmd.Parameters["@Message"].Direction = ParameterDirection.Output;           
            SqlCmd.ExecuteNonQuery();
            Messages = SqlCmd.Parameters["@Message"].Value.ToString();
            Status = Convert.ToInt32(SqlCmd.Parameters["@Status"].Value);
            SqlConn.Close();
            return Status;
        }
        public static int XoaDienThoai(string MaDT,string MaLDT, ref string Messages)
        {
            SqlConnection SqlConn = new SqlConnection();
            SqlConn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["QLDT"].ConnectionString;
            SqlConn.Open();
            Messages = "";
            int Status;
            SqlCommand SqlCmd = new SqlCommand("XoaDienThoai", SqlConn);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@MaDT", MaDT);
            SqlCmd.Parameters.AddWithValue("@MaLDT",MaLDT);
            SqlCmd.Parameters.Add("@Message", SqlDbType.NVarChar,50);
            SqlCmd.Parameters.Add("@Status", SqlDbType.Int);
            SqlCmd.Parameters["@Status"].Direction = ParameterDirection.Output;
            SqlCmd.Parameters["@Message"].Direction = ParameterDirection.Output;
            SqlCmd.ExecuteNonQuery();
            Messages = SqlCmd.Parameters["@Message"].Value.ToString();
            Status = Convert.ToInt32(SqlCmd.Parameters["@Status"].Value);
            SqlConn.Close();
            return Status;
        }
        public static int SuaDienThoai(string MaDT, ref string Messages, string MaDTNew, string TenDTNew,string ManHinhNew,
            string MaLDTNew, string CameraTruocNew, string CameraSauNew, string RAMNew, string ROMNew, string SystemNew, string PinNew, float GiaThanhNew)
        {
            SqlConnection SqlConn = new SqlConnection();
            SqlConn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["QLDT"].ConnectionString;
            SqlConn.Open();
            Messages = string.Empty;
            int Status;
            SqlCommand SqlCmd = new SqlCommand("SuaDienThoai", SqlConn);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@MaDT", MaDT);
            SqlCmd.Parameters.AddWithValue("@MaDTNew", MaDTNew);
            SqlCmd.Parameters.AddWithValue("@MaLDTNew", MaLDTNew);
            SqlCmd.Parameters.AddWithValue("@TenDTNew", TenDTNew);
            SqlCmd.Parameters.AddWithValue("@ManHinhNew", ManHinhNew);
            SqlCmd.Parameters.AddWithValue("@CameraSauNew", CameraSauNew);
            SqlCmd.Parameters.AddWithValue("@CamereTruocNew", CameraTruocNew);
            SqlCmd.Parameters.AddWithValue("@RAMNew", RAMNew);
            SqlCmd.Parameters.AddWithValue("@ROMNew", ROMNew);
            SqlCmd.Parameters.AddWithValue("@SystemNew", SystemNew);
            SqlCmd.Parameters.AddWithValue("@PinNew", PinNew);
            SqlCmd.Parameters.AddWithValue("@GiaThanhNew", GiaThanhNew);
            SqlCmd.Parameters.Add("@Message", SqlDbType.NVarChar, 50);
            SqlCmd.Parameters.Add("@Status", SqlDbType.Int);
            SqlCmd.Parameters["@Message"].Direction = ParameterDirection.Output;
            SqlCmd.Parameters["@Status"].Direction = ParameterDirection.Output;
            SqlCmd.ExecuteNonQuery();
            Status = Convert.ToInt32(SqlCmd.Parameters["@Status"].Value);
            Messages = SqlCmd.Parameters["@Message"].Value.ToString();
            SqlConn.Close();
            return Status;
        }
        public static int ExportDoanhThuThang(ref string Messages,string FilePath,string FileName)
        {
            SqlConnection SqlConn = new SqlConnection();
            SqlConn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["QLDT"].ConnectionString;
            SqlConn.Open();
            Messages = string.Empty;
            int Status;
            SqlCommand SqlCmd = new SqlCommand("ExportDoanhThuThang", SqlConn);
            SqlCmd.CommandType = CommandType.StoredProcedure;
             SqlCmd.Parameters.AddWithValue("@FilePath", FilePath);
             SqlCmd.Parameters.AddWithValue("@FileName", FileName);
             SqlCmd.Parameters.Add("@Messages", SqlDbType.NVarChar, 50);
             SqlCmd.Parameters.Add("@Status", SqlDbType.Int);
             SqlCmd.Parameters["@Messages"].Direction = ParameterDirection.Output;
             SqlCmd.Parameters["@Status"].Direction = ParameterDirection.Output;
             SqlCmd.ExecuteNonQuery();
             Status = Convert.ToInt32(SqlCmd.Parameters["@Status"].Value);
             Messages = SqlCmd.Parameters["@Messages"].Value.ToString();
            /* SqlCmd.Parameters.Add("@Messages", SqlDbType.NVarChar, 50);
             SqlCmd.Parameters.Add("@Status", SqlDbType.Int);
             SqlCmd.Parameters["@Messages"].Direction = ParameterDirection.Output;
             SqlCmd.Parameters["@Status"].Direction = ParameterDirection.Output;
             SqlCmd.ExecuteNonQuery();
             Status = Convert.ToInt32(SqlCmd.Parameters["@Status"].Value);
             Messages = SqlCmd.Parameters["@Messages"].Value.ToString();*/
            SqlConn.Close();
            return Status;
        }
        public static int XoaTatCaNhanVien(ref string Messages)
        {
            SqlConnection SqlConn = new SqlConnection();
            SqlConn.ConnectionString = ConfigurationManager.ConnectionStrings["QLDT"].ConnectionString;
            SqlConn.Open();
            SqlCommand SqlCmd = new SqlCommand("XoaTatCaNhanVien",SqlConn);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            Messages = string.Empty;
            int Status;
            SqlCmd.Parameters.Add("@Messages", SqlDbType.NVarChar, 50);
            SqlCmd.Parameters.Add("@Status", SqlDbType.Int);
            SqlCmd.Parameters["@Messages"].Direction = ParameterDirection.Output;
            SqlCmd.Parameters["@Status"].Direction = ParameterDirection.Output;
            SqlCmd.ExecuteNonQuery();
            Status = Convert.ToInt32(SqlCmd.Parameters["@Status"].Value);
            Messages = Convert.ToString(SqlCmd.Parameters["@Messages"].Value);
            SqlConn.Close();
            return Status;
        }

        public static int ThemLoaiDienThoai(string MaLDT, string TenLDT, ref string Messages)
        {
            SqlConnection SqlConn = new SqlConnection();
            SqlConn.ConnectionString = ConfigurationManager.ConnectionStrings["QLDT"].ConnectionString;
            SqlConn.Open();
            int Status;
            SqlCommand SqlCmd = new SqlCommand("ThemLoaiDienThoai", SqlConn);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@MaLDT", MaLDT);
            SqlCmd.Parameters.AddWithValue("@TenLDT", TenLDT);
            SqlCmd.Parameters.Add("@Status", SqlDbType.Int);
            SqlCmd.Parameters["@Status"].Direction = ParameterDirection.Output;
            SqlCmd.Parameters.Add("@Message", SqlDbType.NVarChar, 50);
            SqlCmd.Parameters["@Message"].Direction = ParameterDirection.Output;          
            SqlCmd.ExecuteNonQuery();
            Messages = SqlCmd.Parameters["@Message"].Value.ToString();
            Status = Convert.ToInt32(SqlCmd.Parameters["@Status"].Value);
            SqlConn.Close();
            return Status;
        }

        public static int XoaLoaiDienThoai(string MaLDT, ref string Messages)
        {
            SqlConnection SqlConn = new SqlConnection();
            SqlConn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["QLDT"].ConnectionString;
            SqlConn.Open();
            Messages = string.Empty;
            int Status;
            SqlCommand SqlCmd = new SqlCommand("XoaLoaiDienThoai", SqlConn);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@MaLDT", MaLDT);
            SqlCmd.Parameters.Add("@Message", SqlDbType.NVarChar, 50);
            SqlCmd.Parameters.Add("@Status", SqlDbType.Int);
            SqlCmd.Parameters["@Status"].Direction = ParameterDirection.Output;
            SqlCmd.Parameters["@Message"].Direction = ParameterDirection.Output;
            SqlCmd.ExecuteNonQuery();
            Messages = SqlCmd.Parameters["@Message"].Value.ToString();
            Status = Convert.ToInt32(SqlCmd.Parameters["@Status"].Value);
            SqlConn.Close();
            return Status;
        }
        public static int ThemNhanVien(string MaNV, string TenNV, string SDT_NV,string DiaChi_NV, ref string Messages)
        {
            SqlConnection SqlConn = new SqlConnection();
            SqlConn.ConnectionString = ConfigurationManager.ConnectionStrings["QLDT"].ConnectionString;
            SqlConn.Open();
            int Status;
            SqlCommand SqlCmd = new SqlCommand("ThemNhanVien", SqlConn);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@MaNV", MaNV);
            SqlCmd.Parameters.AddWithValue("@TenNV", TenNV);
            SqlCmd.Parameters.AddWithValue("@SDT_NV", SDT_NV);
            SqlCmd.Parameters.AddWithValue("@DiaChi_NV", DiaChi_NV);
            SqlCmd.Parameters.Add("@Status", SqlDbType.Int);
            SqlCmd.Parameters["@Status"].Direction = ParameterDirection.Output;
            SqlCmd.Parameters.Add("@Message", SqlDbType.NVarChar, 50);
            SqlCmd.Parameters["@Message"].Direction = ParameterDirection.Output;         
            SqlCmd.ExecuteNonQuery();
            Messages = SqlCmd.Parameters["@Message"].Value.ToString();
            Status = Convert.ToInt32(SqlCmd.Parameters["@Status"].Value);
            SqlConn.Close();
            return Status;
        }
        public static int XoaNhanVien(string MaNV, ref string Messages)
        {
            SqlConnection SqlConn = new SqlConnection();
            SqlConn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["QLDT"].ConnectionString;
            SqlConn.Open();
            Messages = string.Empty;
            int Status;
            SqlCommand SqlCmd = new SqlCommand("XoaNhanVien", SqlConn);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@MaNV", MaNV);
            SqlCmd.Parameters.Add("@Message", SqlDbType.NVarChar, 50);
            SqlCmd.Parameters.Add("@Status", SqlDbType.Int);
            SqlCmd.Parameters["@Status"].Direction = ParameterDirection.Output;
            SqlCmd.Parameters["@Message"].Direction = ParameterDirection.Output;
            SqlCmd.ExecuteNonQuery();
            Messages = SqlCmd.Parameters["@Message"].Value.ToString();
            Status = Convert.ToInt32(SqlCmd.Parameters["@Status"].Value);
            SqlConn.Close();
            return Status;
        }
    }
}
