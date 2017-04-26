using System;
using System.Collections.Generic;
using System.Text;
using GalaBuilding.Component;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
namespace GalaBuilding.DataLayer
{
    class NguoiDanData
    {
        DataService m_NguoiDanData = new DataService();
        DataServiceIOExcel dsIOExcel = new DataServiceIOExcel();

        public DataTable LayDsNguoiDan()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NGUOIDAN");
            m_NguoiDanData.Load(cmd);
            return m_NguoiDanData;
        }

        public DataTable LayDsNguoiDanTheoCanHo(String macanho)
        {
            SqlCommand cmd = new SqlCommand("SELECT CH_ND.MaNguoiDan, ND.TenNguoiDan " +
                                            "FROM NGUOIDAN ND INNER JOIN CANHO_NGUOIDAN CH_ND ON ND.MaNguoiDan = CH_ND.MaNguoiDan " +
                                            "INNER JOIN CANHO CH ON CH.MaCanHo = CH_ND.MaCanHo " +
                                            "WHERE CH_ND.MaCanHo = @macanho");
            cmd.Parameters.Add("macanho", SqlDbType.VarChar).Value = macanho;

            m_NguoiDanData.Load(cmd);
            return m_NguoiDanData;
        }

        public void LuuNDVaoBangCANHO_NGUOIDAN(String maCanHo, String maNguoiDan)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO CANHO_NGUOIDAN VALUES(@maCanHo, @maNguoiDan)");
            cmd.Parameters.Add("maCanHo", SqlDbType.VarChar).Value = maCanHo;
            cmd.Parameters.Add("maNguoiDan", SqlDbType.VarChar).Value = maNguoiDan;

            m_NguoiDanData.Load(cmd);
        }

        public DataTable LayDSNguoiDanExcel(string path)
        {
            OdbcCommand cmd = new OdbcCommand("select * from [Sheet1$]");
            return dsIOExcel.Load(cmd, path);
        }


        public void XoaNDKhoiBangCANHO_NGUOIDAN(String maCanHo)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM CANHO_NGUOIDAN WHERE MaCanHo = @maCanHo");
            cmd.Parameters.Add("maCanHo", SqlDbType.VarChar).Value = maCanHo;
            m_NguoiDanData.Load(cmd);
        }


        public DataRow ThemDongMoi()
        {
            return m_NguoiDanData.NewRow();
        }

        public void ThemNguoiDan(DataRow m_Row)
        {
            m_NguoiDanData.Rows.Add(m_Row);
        }

        public bool LuuNguoiDan()
        {
            return m_NguoiDanData.ExecuteNoneQuery() > 0;
        }

        public void LuuNguoiDan(String MaNguoiDan, String TenNguoiDan, bool GioiTinh, DateTime NgaySinh)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO NGUOIDAN VALUES(@MaNguoiDan, @TenNguoiDan, @GioiTinh, @NgaySinh)");
            cmd.Parameters.Add("MaNguoiDan", SqlDbType.VarChar).Value = MaNguoiDan;
            cmd.Parameters.Add("TenNguoiDan", SqlDbType.NVarChar).Value = TenNguoiDan;
            cmd.Parameters.Add("GioiTinh", SqlDbType.Bit).Value = GioiTinh;
            cmd.Parameters.Add("NgaySinh", SqlDbType.DateTime).Value = NgaySinh;

            m_NguoiDanData.Load(cmd);
        }

        public DataTable TimTheoMa(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NGUOIDAN WHERE MaNguoiDan LIKE '%' + @ma + '%'");
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = ma;

            m_NguoiDanData.Load(cmd);
            return m_NguoiDanData;
        }

        public DataTable TimTheoTen(String ten)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NGUOIDAN WHERE TenNguoiDan LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;

            m_NguoiDanData.Load(cmd);
            return m_NguoiDanData;
        }

        public String TruyVan()
        {
            return "SELECT MaNguoiDan, TenNguoiDan from NGUOIDAN ";
        }

        public String TruyVanChung()
        {
            return "SELECT ND.MaNguoiDan,ND.TenNguoiDan, CH_ND.MaCanHo, ND.GioiTinh, ND.NgaySinh " +
                   "FROM NGUOIDAN ND " +
                   "FULL OUTER JOIN CANHO_NGUOIDAN CH_ND ON ND.MaNguoiDan = CH_ND.MaNguoiDan";
        }

        internal DataTable LayDsNguoiDanForReport()
        {
            throw new NotImplementedException();
        }

        public DataTable TimKiemNguoiDan(String TenNguoiDan)
        {
            SqlCommand cmd = new SqlCommand();

            String sql = TruyVanChung() + " WHERE ND.TenNguoiDan LIKE N'%' + @TenNguoiDan + '%' ";
            cmd.Parameters.Add("TenNguoiDan", SqlDbType.NVarChar).Value = TenNguoiDan;

            cmd.CommandText = sql;
            m_NguoiDanData.Load(cmd);
            return m_NguoiDanData;
        }
    }
}
