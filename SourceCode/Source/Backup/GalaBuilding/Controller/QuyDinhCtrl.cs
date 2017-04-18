using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
using GalaBuilding.DataLayer;
using System.Windows.Forms;
using System.Data;

namespace GalaBuilding.Controller
{
   public class QuyDinhCtrl
    {
        QuyDinhData m_QuyDinhData = new QuyDinhData();
        public void HienThi(IntegerInput itiSoNguoiToiDa,

                            IntegerInput itiTuoiNguoiDan_Min,
                            IntegerInput itiTuoiNguoiDan_Max,
                            IntegerInput itiTuoiNhanVien_Min,
                            IntegerInput itiTuoiNhanVien_Max
                            )
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_QuyDinhData.LayDsQuyDinh();

            DataTable DT = m_QuyDinhData.LayDsQuyDinh();

            int SoNguoiToiDa = Convert.ToInt32(DT.Rows[0]["SoNguoiToiDa"]);


            itiTuoiNguoiDan_Min.DataBindings.Clear();
            itiTuoiNguoiDan_Min.DataBindings.Add("Value", bS, "TuoiNguoiDan_Min");

            
            itiTuoiNguoiDan_Max.DataBindings.Clear();
            itiTuoiNguoiDan_Max.DataBindings.Add("Value", bS, "TuoiNguoiDan_Max");

            itiTuoiNhanVien_Min.DataBindings.Clear();
            itiTuoiNhanVien_Min.DataBindings.Add("Value", bS, "TuoiNhanVien_Min");

            itiTuoiNhanVien_Max.DataBindings.Clear();
            itiTuoiNhanVien_Max.DataBindings.Add("Value", bS, "TuoiNhanVien_Max");
           
        }

        public void CapNhatQuyDinhSoNguoi(int SoNguoiToiDa)
        {
            m_QuyDinhData.CapNhatQuyDinhSoNguoi(SoNguoiToiDa);
        }

        public void CapNhatQuyDinhDoTuoiNguoiDan(int tuoiMin, int tuoiMax)
        {
            m_QuyDinhData.CapNhatQuyDinhDoTuoiNguoiDan(tuoiMin, tuoiMax);
        }
        public void CapNhatQuyDinhDoTuoiNhanVien(int tuoiMin, int tuoiMax)
        {
            m_QuyDinhData.CapNhatQuyDinhDoTuoiNhanVien(tuoiMin, tuoiMax);
        }
    }
}
