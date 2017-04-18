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


        public DataTable LayDsNguoiDanForReport()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NGHENGHIEP NN, NGUOIDAN ND, DANTOC DT, TONGIAO TG WHERE ND.MaNgheNghiep = NN.MaNgheNghiep AND ND.MaDanToc = DT.MaDanToc AND ND.MaTonGiao = TG.MaTonGiao");
            m_NguoiDanData.Load(cmd);
            return m_NguoiDanData;
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

        public void LuuNguoiDan(String MaNguoiDan, String TenNguoiDan, bool GioiTinh, DateTime NgaySinh, String MaDanToc, String MaTonGiao, String MaNgheNghiep)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO NGUOIDAN VALUES(@MaNguoiDan, @TenNguoiDan, @GioiTinh, @NgaySinh, @MaDanToc, @MaTonGiao, @MaNgheNghiep)");
            cmd.Parameters.Add("MaNguoiDan", SqlDbType.VarChar).Value = MaNguoiDan;
            cmd.Parameters.Add("TenNguoiDan", SqlDbType.NVarChar).Value = TenNguoiDan;
            cmd.Parameters.Add("GioiTinh", SqlDbType.Bit).Value = GioiTinh;
            cmd.Parameters.Add("NgaySinh", SqlDbType.DateTime).Value = NgaySinh;
            cmd.Parameters.Add("MaDanToc", SqlDbType.VarChar).Value = MaDanToc;
            cmd.Parameters.Add("MaTonGiao", SqlDbType.VarChar).Value = MaTonGiao;
            cmd.Parameters.Add("MaNgheNghiep", SqlDbType.VarChar).Value = MaNgheNghiep;

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

        /*
        public String TruyVanChung()
        {
            return "SELECT ND.MaNguoiDan, ND.TenNguoiDan, ND.GioiTinh, ND.NgaySinh, DT.TenDanToc, TG.TenTonGiao FROM NGUOIDAN ND INNER JOIN DANTOC DT ON ND.MaDanToc = DT.MaDanToc INNER JOIN TONGIAO TG ON ND.MaTonGiao = TG.MaTonGiao";
        }
        */
        public String TruyVanChung()
        {
            return "SELECT ND.MaNguoiDan,ND.TenNguoiDan, CH_ND.MaCanHo, ND.GioiTinh, ND.NgaySinh, NN.TenNgheNghiep, DT.TenDanToc, TG.TenTonGiao " +
                   "FROM NGUOIDAN ND FULL OUTER JOIN NGHENGHIEP NN ON ND.MaNgheNghiep = NN.MaNgheNghiep " +
                   "FULL OUTER JOIN DANTOC DT ON ND.MaDanToc = DT.MaDanToc " +
                   "FULL OUTER JOIN TONGIAO TG ON ND.MaTonGiao = TG.MaTonGiao " +
                   "FULL OUTER JOIN CANHO_NGUOIDAN CH_ND ON ND.MaNguoiDan = CH_ND.MaNguoiDan ";
        }

        public DataTable TimKiemNguoiDan(String TenNguoiDan)
        {
            SqlCommand cmd = new SqlCommand();

            String sql = TruyVanChung() + " WHERE ND.TenNguoiDan LIKE N'%' + @ + '%' ";
            cmd.Parameters.Add("TenNguoiDan", SqlDbType.NVarChar).Value = TenNguoiDan;
            m_NguoiDanData.Load(cmd);
            return m_NguoiDanData;
        }

        public DataTable TimKiemNguoiDan(String TenNguoiDan, String theoCanHo, String MaCanHo, String theoNgheNghiep, String TenNgheNghiep, String theoDanToc, String TenDanToc, String theoTonGiao, String TenTonGiao)
        {
            SqlCommand cmd = new SqlCommand();

            String sql = TruyVanChung() + " WHERE ND.TenNguoiDan LIKE N'%' + @TenNguoiDan + '%' ";
            cmd.Parameters.Add("TenNguoiDan", SqlDbType.NVarChar).Value = TenNguoiDan;

            if (theoCanHo != "NONE")
            {
                sql += theoCanHo + " CH_ND.MaCanHo = @MaCanHo ";
                cmd.Parameters.Add("MaCanHo", SqlDbType.NVarChar).Value = MaCanHo;
            }

            if (theoNgheNghiep != "NONE")
            {
                sql += theoNgheNghiep + " NN.TenNgheNghiep = @TenNgheNghiep ";
                cmd.Parameters.Add("TenNgheNghiep", SqlDbType.NVarChar).Value = TenNgheNghiep;
            }

            if (theoDanToc != "NONE")
            {
                sql += theoDanToc + " DT.TenDanToc = @TenDanToc ";
                cmd.Parameters.Add("TenDanToc", SqlDbType.NVarChar).Value = TenDanToc;
            }

            if (theoTonGiao != "NONE")
            {
                sql += theoTonGiao + " TG.TenTonGiao = @TenTonGiao ";
                cmd.Parameters.Add("TenTonGiao ", SqlDbType.NVarChar).Value = TenTonGiao;
            }

            cmd.CommandText = sql;
            m_NguoiDanData.Load(cmd);
            return m_NguoiDanData;
        }


        /*
        internal object TimKiemNguoiDan(string p, string p_2, string p_3, string p_4, string p_5, string p_6, string p_7)
        {
            throw new NotImplementedException();
        }
         */ 
    }
}
