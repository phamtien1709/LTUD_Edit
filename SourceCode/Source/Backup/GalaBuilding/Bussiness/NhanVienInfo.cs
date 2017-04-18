using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GalaBuilding.Bussiness
{
    class NhanVienInfo
    {

        public string MaNhanVien { get; set; }

        public string TenNhanVien { get; set; }

        public bool GioiTinh { get; set; }

        public DateTime NgaySinh { get; set; }

        public string DiaChi { get; set; }

        public string DienThoai { get; set; }

        public ChucVuInfo ChucVu { get; set; }

    }
}
