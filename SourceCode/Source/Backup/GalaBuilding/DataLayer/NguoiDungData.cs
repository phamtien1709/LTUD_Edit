using System;
using System.Collections.Generic;
using System.Text;
using GalaBuilding.Component;
using System.Data;
using System.Data.SqlClient;

namespace GalaBuilding.DataLayer
{
   public class NguoiDungData
    {
        DataService m_NguoiDungData = new DataService();

        public DataTable LayDsNguoiDung()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NGUOIDUNG");
            m_NguoiDungData.Load(cmd);
            return m_NguoiDungData;
        }

        public DataTable LayDsNguoiDung(String m_Username)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NGUOIDUNG WHERE TenDangNhap = @ten");
            cmd.Parameters.Add("ten", SqlDbType.VarChar).Value = m_Username;
            m_NguoiDungData.Load(cmd);
            return m_NguoiDungData;
        }

        public DataTable LayDsNguoiDungDuocLuu()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LUUTAIKHOAN ");
            m_NguoiDungData.Load(cmd);
            return m_NguoiDungData;
        }


        
        public DataRow ThemDongMoi()
        {
            return m_NguoiDungData.NewRow();
        }

        public void ThemNguoiDung(DataRow m_Row)
        {
            m_NguoiDungData.Rows.Add(m_Row);
        }
       
        public bool LuuNguoiDung()
        {
            return m_NguoiDungData.ExecuteNoneQuery() > 0;
        }

        public void DoiMatKhau(String userName, String newPassword)
        {
            m_NguoiDungData.DoiMatKhau(userName, newPassword);
        }

        public void LuuTaiKhoan(string tenDangNhap, string matKhau)
        {
            SqlCommand cmdXoa = new SqlCommand("DELETE FROM LUUTAIKHOAN");
            m_NguoiDungData.Load(cmdXoa);

            SqlCommand cmd = new SqlCommand("INSERT INTO LUUTAIKHOAN VALUES(@tenDangNhap, @matKhau)");
            cmd.Parameters.Add("tenDangNhap", SqlDbType.VarChar).Value = tenDangNhap;
            cmd.Parameters.Add("matKhau", SqlDbType.VarChar).Value = matKhau;
            m_NguoiDungData.Load(cmd);
        }
       /*
        public string LayMatKhauTuTaiKhoanDuocLuu(string TenDangNhap_Test)
        {
            DataService dS = new DataService();
            dS.Load(new SqlCommand("SELECT TenDangNhap, MatKhau FROM LUUTAIKHOAN"));

            string TenDangNhap = dS.Rows[0]["TenDangNhap"].ToString();
            string MatKhau = dS.Rows[0]["MatKhau"].ToString();
            if (TenDangNhap_Test == TenDangNhap)
                return MatKhau;
            return "";
        }
        */
        public void XoaTaiKhoanDuocLuu()
        {
            DataService dS = new DataService();
            dS.Load(new SqlCommand("DELETE FROM LUUTAIKHOAN"));
        }
    }
}
