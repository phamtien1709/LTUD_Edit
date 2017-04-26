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

        public bool luuNhanVien()
        {
            return m_NhanVienData.ExecuteNoneQuery() > 0;
        }

        public void LuuNhanVien(String MaNhanVien, String TenNhanVien, bool GioiTinh, DateTime NgaySinh, String MaChucVu)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO NHANVIEN VALUES(@MaNhanVien, @TenNhanVien, @GioiTinh, @NgaySinh, @MaChucVu)");
            cmd.Parameters.Add("MaNhanVien", SqlDbType.VarChar).Value = MaNhanVien;
            cmd.Parameters.Add("TenNhanVien", SqlDbType.NVarChar).Value = TenNhanVien;
            cmd.Parameters.Add("GioiTinh", SqlDbType.Bit).Value = GioiTinh;
            cmd.Parameters.Add("NgaySinh", SqlDbType.DateTime).Value = NgaySinh;
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
            return "SELECT NV.MaNhanVien, NV.TenNhanVien, NV.GioiTinh, NV.NgaySinh, CV.TenChucVu " +
                   "FROM NHANVIEN NV FULL OUTER JOIN CHUCVU CV ON NV.MaChucVu = CV.MaChucVu ";
        }


        public DataTable LayDSNhanVienExcel(string path)
        {
            OdbcCommand cmd = new OdbcCommand("select * from [Sheet1$]");
            return dsIOExcel.Load(cmd, path);
        }

        public DataTable TimKiemNhanVien(String TenNhanVien)
        {
            SqlCommand cmd = new SqlCommand();

            String sql = TruyVanChung() + " WHERE NV.TenNhanVien LIKE '%' + @TenNhanVien + '%' ";
            cmd.Parameters.Add("TenNhanVien", SqlDbType.NVarChar).Value = TenNhanVien;

            cmd.CommandText = sql;
            m_NhanVienData.Load(cmd);
            return m_NhanVienData;
        }

    }
}
