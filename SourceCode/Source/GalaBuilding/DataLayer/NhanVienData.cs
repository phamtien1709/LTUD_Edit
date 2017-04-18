using System;
using System.Collections.Generic;
using System.Text;
using GalaBuilding.Component;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;


namespace GalaBuilding.DataLayer
{
    class NhanVienData
    {
        DataService m_NhanVienData = new DataService();
        DataServiceIOExcel dsIOExcel = new DataServiceIOExcel();

        public DataTable LayDsNhanVien()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NHANVIEN");
            m_NhanVienData.Load(cmd);
            return m_NhanVienData;
        }

        public DataRow ThemDongMoi()
        {
            return m_NhanVienData.NewRow();
        }

        public void ThemNhanVien(DataRow m_Row)
        {
            m_NhanVienData.Rows.Add(m_Row);
        }

        public bool LuuNhanVien()
        {
            return m_NhanVienData.ExecuteNoneQuery() > 0;
        }

        public void LuuNhanVien(String MaNhanVien, String TenNhanVien, bool GioiTinh, DateTime NgaySinh, String DiaChi, String DienThoai, String MaChucVu)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO NHANVIEN VALUES(@MaNhanVien, @TenNhanVien, @GioiTinh, @NgaySinh, @DiaChi, @DienThoai, @MaChucVu)");
            cmd.Parameters.Add("MaNhanVien", SqlDbType.VarChar).Value = MaNhanVien;
            cmd.Parameters.Add("TenNhanVien", SqlDbType.NVarChar).Value = TenNhanVien;
            cmd.Parameters.Add("GioiTinh", SqlDbType.Bit).Value = GioiTinh;
            cmd.Parameters.Add("NgaySinh", SqlDbType.DateTime).Value = NgaySinh;
            cmd.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = DiaChi;
            cmd.Parameters.Add("DienThoai", SqlDbType.VarChar).Value = DienThoai;
            cmd.Parameters.Add("MaChucVu", SqlDbType.VarChar).Value = MaChucVu;
            m_NhanVienData.Load(cmd);
        }

        public DataTable LayDsNhanVienForReport()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM CHUCVU CV INNER JOIN NHANVIEN NV ON CV.MaChucVu = NV.MaNhanVien");
            m_NhanVienData.Load(cmd);
            return m_NhanVienData;
        }

        public DataTable TimTheoMa(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NHANVIEN WHERE MaNhanVien LIKE '%' + @ma + '%'");
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = ma;
            m_NhanVienData.Load(cmd);
            return m_NhanVienData;
        }

        public DataTable TimTheoTen(String ten)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NHANVIEN WHERE TenNhanVien LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;
            m_NhanVienData.Load(cmd);
            return m_NhanVienData;
        }

        public String TruyVanChung()
        {
            return "SELECT NV.MaNhanVien, NV.TenNhanVien, NV.GioiTinh, NV.NgaySinh, NV.DiaChi, NV.DienThoai, CV.TenChucVu " +
                   "FROM NHANVIEN NV FULL OUTER JOIN CHUCVU CV ON NV.MaChucVu = CV.MaChucVu ";
        }

        internal void LuuNhanVien(string maNhanVien, string tenNhanVien, bool gioiTinh, DateTime ngaySinh, string chucVu)
        {
            throw new NotImplementedException();
        }

        public DataTable LayDSNhanVienExcel(string path)
        {
            OdbcCommand cmd = new OdbcCommand("select * from [Sheet1$]");
            return dsIOExcel.Load(cmd, path);
        }

        public DataTable TimKiemNhanVien(String TenNhanVien, String theoDiaChi, String DiaChi, String theoChucVu, String TenChucVu)
        {
            SqlCommand cmd = new SqlCommand();

            String sql = TruyVanChung() + " WHERE NV.TenNhanVien LIKE '%' + @TenNhanVien + '%' ";
            cmd.Parameters.Add("TenNhanVien", SqlDbType.NVarChar).Value = TenNhanVien;

            if (theoDiaChi != "NONE")
            {
                sql += theoDiaChi + " NV.DiaChi LIKE N'%' + @DiaChi + '%' ";
                cmd.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = DiaChi;
            }

            if (theoChucVu != "NONE")
            {
                sql += theoChucVu + " CV.TenChucVu = @TenChucVu ";
                cmd.Parameters.Add("TenChucVu", SqlDbType.NVarChar).Value = TenChucVu;
            }

            cmd.CommandText = sql;
            m_NhanVienData.Load(cmd);
            return m_NhanVienData;
        }

        internal object TimKiemNhanVien(string text1, string text2, string text3)
        {
            throw new NotImplementedException();
        }
    }
}
