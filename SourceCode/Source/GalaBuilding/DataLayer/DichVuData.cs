using System;
using System.Collections.Generic;
using System.Text;
using GalaBuilding.Component;
using System.Data;
using System.Data.SqlClient;

namespace GalaBuilding.DataLayer
{
    class DichVuData
    {
        DataService m_DichVuData = new DataService();
        public DataTable LayDSDanToc()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DICHVU");
            m_DichVuData.Load(cmd);
            return m_DichVuData;
        }
        public DataRow ThemDongMoi()
        {
            return m_DichVuData.NewRow();
        }
        public void ThemDichVu(DataRow m_Row)
        {
            m_DichVuData.Rows.Add(m_Row);
        }
        public bool LuuDichVu()
        {
            return m_DichVuData.ExecuteNoneQuery() > 0;
        }
       
    }
}
