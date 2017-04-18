using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GalaBuilding.Bussiness
{
    class NguoiDanInfo
    {
        public string MaNguoiDan { get; set; }
        public string TenNguoiDan { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public TonGiaoInfo MaTonGiao { get; set; }
        public DanTocInfo MaDanToc { get; set; }
        public NgheNghiepInfo MaNgheNghiep { get; set; }
    }
}
