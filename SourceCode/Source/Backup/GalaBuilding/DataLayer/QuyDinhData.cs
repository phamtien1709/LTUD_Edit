using System;
using System.Data;
using System.Data.SqlClient;
using GalaBuilding.Component;


namespace GalaBuilding.DataLayer
{
   public class QuyDinhData
    {
        DataService m_QuyDinhData = new DataService();

        public DataTable LayDsQuyDinh()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM QUYDINH");
            m_QuyDinhData.Load(cmd);
            return m_QuyDinhData;
        }

        public void CapNhatQuyDinhSoNguoi(int SoNguoiToiDa)
        {
            SqlCommand cmd = new SqlCommand("UPDATE QUYDINH SET SoNguoiToiDa = @SoNguoiToiDa");
            cmd.Parameters.Add("SoNguoiToiDa", SqlDbType.Int).Value = SoNguoiToiDa;
            m_QuyDinhData.Load(cmd);
        }

        public void CapNhatQuyDinhDoTuoiNguoiDan(int TuoiNguoiDan_Min, int TuoiNguoiDan_Max)
        {
            SqlCommand cmd = new SqlCommand("UPDATE QUYDINH SET TuoiNguoiDan_Min = @TuoiNguoiDan_Min, TuoiNguoiDan_Max = @TuoiNguoiDan_Max");
            cmd.Parameters.Add("TuoiNguoiDan_Min", SqlDbType.Int).Value = TuoiNguoiDan_Min;
            cmd.Parameters.Add("TuoiNguoiDan_Max", SqlDbType.Int).Value = TuoiNguoiDan_Max;
            m_QuyDinhData.Load(cmd);
        }

        public void CapNhatQuyDinhDoTuoiNhanVien(int TuoiNhanVien_Min, int TuoiNhanVien_Max)
        {
            SqlCommand cmd = new SqlCommand("UPDATE QUYDINH SET TuoiNhanVien_Min = @TuoiNhanVien_Min, TuoiNhanVien_Max = @TuoiNhanVien_Max");
            cmd.Parameters.Add("TuoiNhanVien_Min", SqlDbType.Int).Value = TuoiNhanVien_Min;
            cmd.Parameters.Add("TuoiNhanVien_Max", SqlDbType.Int).Value = TuoiNhanVien_Max;
            m_QuyDinhData.Load(cmd);
        }
    }
}
