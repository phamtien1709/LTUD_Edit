using System;
using System.Collections.Generic;
using System.Text;
using GalaBuilding.Component;
using System.Data;
using System.Data.SqlClient;

namespace GalaBuilding.DataLayer
{
    class ChucVuData
    {
        DataService m_ChucVuData = new DataService();
        public DataTable LayDSChucVu()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM CHUCVU");
            m_ChucVuData.Load(cmd);
            return m_ChucVuData;
        }
        public DataRow ThemDongMoi()
        {
            return m_ChucVuData.NewRow();
        }
        public void ThemChucVu(DataRow m_Row)
        {
            m_ChucVuData.Rows.Add(m_Row);
        }
        public bool LuuChucVu()
        {
            return m_ChucVuData.ExecuteNoneQuery() > 0;
        }
    }
}
