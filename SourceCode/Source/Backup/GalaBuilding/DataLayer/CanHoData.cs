using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaBuilding.Component;
using System.Data.SqlClient;
using System.Data;
using System.Data.Odbc;

namespace GalaBuilding.DataLayer
{
    class CanHoData
    {
        DataService m_CanHoData = new DataService();
        DataServiceIOExcel dsIOExcel = new DataServiceIOExcel();


        /*
        public DataTable LayDsCanHoForReport()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM CANHO CH INNER JOIN CANHO_NGUOIDAN CH_ND ON CH.MaCanHo = CH_ND.MaCanHo");
            m_CanHoData.Load(cmd);
            return m_CanHoData;
        }
        */
        public bool LuuCanHoNguoiDan(String MaNguoiDan, String MaCanHo)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO CANHO_NGUOIDAN VALUES(@MaNguoiDan, @MaCanHo)");
            cmd.Parameters.Add("MaNguoiDan", SqlDbType.VarChar).Value = MaNguoiDan;
            cmd.Parameters.Add("MaCanHo", SqlDbType.NVarChar).Value = MaCanHo;
            return m_CanHoData.Load(cmd);
        }

        public bool LuuCanHoDichVu(String MaCanHo, String MaDichVu)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO CANHO_DICHVU VALUES(@MaCanHo, @MaDichVu)");
            cmd.Parameters.Add("MaCanHo", SqlDbType.NVarChar).Value = MaCanHo;
            cmd.Parameters.Add("MaDichVu", SqlDbType.VarChar).Value = MaDichVu;
            return m_CanHoData.Load(cmd);
        }

        public DataTable LayDSCanHoExcel(string path)
        {
            OdbcCommand cmd = new OdbcCommand("select * from [Sheet1$]");
            return dsIOExcel.Load(cmd, path);
        }

        public DataTable TimTheoTenNguoiDan(String ten)
        {
            SqlCommand cmd = new SqlCommand("SELECT CH.MaCanHo, CH.TangLau, CH.SoNguoi, CH.TongChiPhi " +
                                            "FROM CANHO CH INNER JOIN CANHO_NGUOIDAN CH_ND ON CH.MaCanHo = CH_ND.MaCanHo " +
                                            "INNER JOIN NGUOIDAN ND ON ND.MaNguoiDan=CH_ND.MaNguoiDan "+
                                            "WHERE TenNguoiDan LIKE N'%' + @ten + '%'");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;
            m_CanHoData.Load(cmd);
            return m_CanHoData;
        }

        public DataTable LayDsCanHo()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM CANHO");
            m_CanHoData.Load(cmd);
            return m_CanHoData;
        }

        public string TruyVanTheoTenNguoiDan()
        {
            return "SELECT CH.MaCanHo,ND.TenNguoiDan, CH.TangLau, CH.SoNguoi, CH.TongPhiDichVu, DV.TenDichVu " +
                   "FROM CANHO CH LEFT OUTER JOIN CANHO_NGUOIDAN CH_ND ON CH.MaCanHo = CH_ND.MaCanHo " +
                   "LEFT OUTER JOIN NGUOIDAN ND ON ND.MaNguoiDan = CH_ND.MaNguoiDan " +
                   "LEFT OUTER JOIN CANHO_DICHVU CH_DV ON CH.MaCanHo = CH_DV.MaCanHo " +
                   "LEFT OUTER JOIN DICHVU DV ON CH_DV.MaDichVu = DV.MaDichVu";
        }

        public String TruyVanChung()
        {
            return "SELECT CH.MaCanHo, CH.TangLau, CH.SoNguoi, CH.TongPhiDichVu, DV.TenDichVu " +
                   "FROM CANHO CH FULL OUTER JOIN CANHO_DICHVU CH_DV ON CH.MaCanHo=CH_DV.MaCanHo " +
                   "FULL OUTER JOIN DICHVU DV ON CH_DV.MaDichVu = DV.MaDichVu";
        }

        public DataTable TimKiemCanHo(String maCanHo, String theoTenNguoiDan, String TenNguoiDan, String theoDichVu, String TenDichVu)
        {
            SqlCommand cmd = new SqlCommand();
            string sql;

            if (theoTenNguoiDan == "NONE")
            {
                sql = TruyVanChung() + " WHERE CH.MaCanHo LIKE '%' + @maCanHo + '%' ";
                cmd.Parameters.Add("maCanHo", SqlDbType.NVarChar).Value = maCanHo;

                if (theoDichVu != "NONE")
                {
                    sql += theoDichVu + " DV.TenDichVu LIKE N'%' + @TenDichVu + '%' ";
                    cmd.Parameters.Add("TenDichVu", SqlDbType.NVarChar).Value = TenDichVu;
                }
            }
            else
            {
                sql = TruyVanTheoTenNguoiDan() + " WHERE ND.TenNguoiDan LIKE N'%' + @TenNguoiDan + '%' ";
                cmd.Parameters.Add("TenNguoiDan", SqlDbType.NVarChar).Value = TenNguoiDan;
                if (maCanHo != "")
                {
                    sql += theoTenNguoiDan + " CH.MaCanHo LIKE '%' + @maCanHo + '%' ";
                    cmd.Parameters.Add("maCanHo", SqlDbType.NVarChar).Value = maCanHo;
                }
                else if (theoDichVu != "NONE")
                {
                    sql += theoDichVu + " DV.TenDichVu LIKE N'%' + @TenDichVu + '%'";
                    cmd.Parameters.Add("TenDichVu", SqlDbType.NVarChar).Value = TenDichVu;
                }
            }
            
            cmd.CommandText = sql;
            m_CanHoData.Load(cmd);
            return m_CanHoData;
        }
    }
}
