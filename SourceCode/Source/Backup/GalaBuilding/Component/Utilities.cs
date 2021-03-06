using System;
using System.Text;
using System.Data;
using System.Xml;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Collections.Generic;
using GalaBuilding.Bussiness;


namespace GalaBuilding.Component
{
    public class Utilities
    {
        public static NguoiDungInfo NguoiDung;
        public static String DatabaseName;
    }
    //các hàm xử lí tập tin XML
    public class XML
    {
        public static XmlDocument XMLReader(String filename)
        {
            XmlDocument xmlR = new XmlDocument();
            try
            {
                xmlR.Load(filename);
            }
            catch
            {
                MessageBoxEx.Show("Không đọc được hoặc không tồn tại tập tin cấu hình " + filename, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return xmlR;
        }
        public static void XMLWriter(String filename, String servname, String database, String costatus)
        {
            XmlTextWriter xmlW = new XmlTextWriter(filename, null);
            xmlW.Formatting = Formatting.Indented;

            xmlW.WriteStartDocument();
            xmlW.WriteStartElement("config");

            xmlW.WriteStartElement("costatus");
            xmlW.WriteString(costatus);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("servname");
            xmlW.WriteString(servname);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("username");
            xmlW.WriteString("");
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("password");
            xmlW.WriteString("");
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("database");
            xmlW.WriteString(database);
            xmlW.WriteEndElement();

            xmlW.WriteEndElement();
            xmlW.WriteEndDocument();

            xmlW.Close();
        }
        public static void XMLWriter(String filename, String servname, String username, String password, String database, String costatus)
        {
            XmlTextWriter xmlW = new XmlTextWriter(filename, null);
            xmlW.Formatting = Formatting.Indented;

            xmlW.WriteStartDocument();
            xmlW.WriteStartElement("config");

            xmlW.WriteStartElement("costatus");
            xmlW.WriteString(costatus);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("servname");
            xmlW.WriteString(servname);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("username");
            xmlW.WriteString(username);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("password");
            xmlW.WriteString(password);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("database");
            xmlW.WriteString(database);
            xmlW.WriteEndElement();

            xmlW.WriteEndElement();
            xmlW.WriteEndDocument();

            xmlW.Close();
        }
    }
    public class QuyDinh
    {
        public String ArrayToString(String[] array, int n)
        {
            String str = "";
            for (int i = 0; i < n; i++)
            {
                if (i != n - 1)
                    str += array[i] + ";";
                else
                    str += array[i];
            }
            return str;
        }

        public Boolean KiemTraSoNguoi(string MaCanHo)
        {
            DataService dS_Toida = new DataService();
            dS_Toida.Load(new SqlCommand("SELECT SoNguoiToiDa FROM QUYDINH"));

            DataService dS_Hientai = new DataService();
            SqlCommand cmd =new SqlCommand("SELECT SoNguoi FROM CANHO CH WHERE CH.MaCanHo=@MaCanHo") ;
            cmd.Parameters.Add("MaCanHo", SqlDbType.VarChar).Value = MaCanHo;
            dS_Hientai.Load(cmd);
            

            int SoNguoiToiDa = Convert.ToInt32(dS_Toida.Rows[0]["SoNguoiToiDa"]);

            int SoNguoiHienTai = Convert.ToInt32(dS_Hientai.Rows[0]["SoNguoi"]);
            if (SoNguoiHienTai < SoNguoiToiDa)
                return true;
            else
                return false;
        }

        public Boolean KiemTraDoTuoiNguoiDan(DateTime ngaySinh)
        {
            DataService dS = new DataService();
            dS.Load(new SqlCommand("SELECT TuoiNguoiDan_Min, TuoiNguoiDan_Max FROM QUYDINH"));

            int DoTuoiNguoiDan_CD = Convert.ToInt32(dS.Rows[0]["TuoiNguoiDan_Min"]);
            int DoTuoiNguoiDan_CT = Convert.ToInt32(dS.Rows[0]["TuoiNguoiDan_Max"]);

            int doTuoi = DateTime.Today.Year - ngaySinh.Year;

            if (DoTuoiNguoiDan_CD <= doTuoi && doTuoi <= DoTuoiNguoiDan_CT)
                return true;
            else
                return false;
        }

        public Boolean KiemTraDoTuoiNhanVien(DateTime ngaySinh)
        {
            DataService dS = new DataService();
            dS.Load(new SqlCommand("SELECT TuoiNhanVien_Min, TuoiNhanVien_Max FROM QUYDINH"));

            int DoTuoiNhanVien_CD = Convert.ToInt32(dS.Rows[0]["TuoiNhanVien_Min"]);
            int DoTuoiNhanVien_CT = Convert.ToInt32(dS.Rows[0]["TuoiNhanVien_Max"]);

            int doTuoi = DateTime.Today.Year - ngaySinh.Year;

            if (DoTuoiNhanVien_CD <= doTuoi && doTuoi <= DoTuoiNhanVien_CT)
                return true;
            else
                return false;
        }

        public String LaySTT(int autoNum)
        {
            if (autoNum < 10)
                return "000" + autoNum;

            else if (autoNum >= 10 && autoNum < 100)
                return "00" + autoNum;

            else if (autoNum >= 100 && autoNum < 1000)
                return "0" + autoNum;

            else if (autoNum >= 1000 && autoNum < 10000)
                return "" + autoNum;

            else
                return "";
        }
    }

}
