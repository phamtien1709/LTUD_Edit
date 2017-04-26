using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using GalaBuilding.DataLayer;
using System.Data;
using GalaBuilding.Bussiness;
using DevComponents.Editors.DateTimeAdv;
using System.Data.SqlClient;

namespace GalaBuilding.Controller
{
    class NguoiDanCtrl
    {
        NguoiDanData m_NguoiDanData = new NguoiDanData();

        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_NguoiDanData.LayDsNguoiDan();
            comboBox.DisplayMember = "TenNguoiDan";
            comboBox.ValueMember = "MaNguoiDan";
        }

        public void HienThiComboBox(string maCanHo, ComboBoxEx comboBox)
        {
            NguoiDanData m_HSData = new NguoiDanData();
            comboBox.DataSource = m_HSData.LayDsNguoiDanTheoCanHo(maCanHo);
            comboBox.DisplayMember = "TenNguoiDan";
            comboBox.ValueMember = "MaNguoiDan";
        }

        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_NguoiDanData.LayDsNguoiDan();
            cmbColumn.DisplayMember = "TenNguoiDan";
            cmbColumn.ValueMember = "MaNguoiDan";
            cmbColumn.DataPropertyName = "MaNguoiDan";
            cmbColumn.HeaderText = "Người dân";
        }



        public void HienThi(DataGridViewX dGV,
                             BindingNavigator bN,
                             TextBoxX txtMaNguoiDan,
                             TextBoxX txtTenNguoiDan,
                             TextBoxX txtGioiTinh,
                             RadioButton opbNam,
                             RadioButton opbNu,
                             DateTimeInput dtpNgaySinh,
                             TextBoxX txtTenNguoiDanDK
                             )
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_NguoiDanData.LayDsNguoiDan();

            DataTable dT = m_NguoiDanData.LayDsNguoiDan();


            txtMaNguoiDan.DataBindings.Clear();
            txtMaNguoiDan.DataBindings.Add("Text", bS, "MaNguoiDan");

            txtTenNguoiDan.DataBindings.Clear();
            txtTenNguoiDan.DataBindings.Add("Text", bS, "TenNguoiDan");

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Value", bS, "NgaySinh");

            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", bS, "GioiTinh");


            txtTenNguoiDanDK.DataBindings.Clear();
            txtTenNguoiDanDK.DataBindings.Add("Text", bS, "TenNguoiDan");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void HienThiDsNguoiDanTheoCanHo(DataGridViewX dGV, BindingNavigator bN, String macanho)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_NguoiDanData.LayDsNguoiDanTheoCanHo(macanho);

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        //hien thi ds trong CANHO_NGUOIDAN
        public void HienThiDsNguoiDanTheoCanHo(String macanho, ListViewEx lV)
        {
            DataTable m_DT = m_NguoiDanData.LayDsNguoiDanTheoCanHo(macanho);

            lV.Items.Clear();
            foreach (DataRow Row in m_DT.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Row["MaNguoiDan"].ToString();
                item.SubItems.Add(Row["TenNguoiDan"].ToString());

                lV.Items.Add(item);
            }
        }
        /*
        public DataTable HienThiDsHocSinhTheoNamHoc(String namHoc)
        {
            return m_NguoiDanData.LayDsHocSinhTheoNamHoc(namHoc);
        }
        */

        public void XoaNDKhoiBangCH_ND(String maCanHo_Cu)
        {
            m_NguoiDanData.XoaNDKhoiBangCANHO_NGUOIDAN(maCanHo_Cu);

        }

        public void LuuNDVaoBangCANHO_NGUOIDAN(string maCanHo, ListViewEx nguoiDan)
        {
            foreach (ListViewItem item in nguoiDan.Items)
            {
                m_NguoiDanData.LuuNDVaoBangCANHO_NGUOIDAN(maCanHo, item.SubItems[0].Text.ToString());
            }
        }

        //report
        public static IList<NguoiDanInfo> LayDsNguoiDan()
        {
            NguoiDanData m_NDData = new NguoiDanData();
            DataTable m_DT = m_NDData.LayDsNguoiDanForReport();

            IList<NguoiDanInfo> dS = new List<NguoiDanInfo>();

            foreach (DataRow Row in m_DT.Rows)
            {
                NguoiDanInfo nd = new NguoiDanInfo();


                nd.MaNguoiDan = Convert.ToString(Row["MaNguoiDan"]);
                nd.TenNguoiDan = Convert.ToString(Row["TenNguoiDan"]);
                nd.GioiTinh = Convert.ToBoolean(Row["GioiTinh"]);
                nd.NgaySinh = Convert.ToDateTime(Row["NgaySinh"]);

                dS.Add(nd);
            }
            return dS;
        }

        public DataRow ThemDongMoi()
        {
            return m_NguoiDanData.ThemDongMoi();
        }

        public void ThemNguoiDan(DataRow m_Row)
        {
            m_NguoiDanData.ThemNguoiDan(m_Row);
        }

        public bool LuuNguoiDan()
        {
            return m_NguoiDanData.LuuNguoiDan();
        }

        public void LuuNguoiDan(String maNguoiDan, String tenNguoiDan, bool gioiTinh, DateTime ngaySinh)
        {
            m_NguoiDanData.LuuNguoiDan(maNguoiDan, tenNguoiDan, gioiTinh, ngaySinh);
        }



        //public static void TimTheoMa(ListViewEx lvw, String m_MaNguoiDan)
        //{
        //    NguoiDanData data = new NguoiDanData();
        //    DataTable table = data.TimTheoMa(m_MaNguoiDan);
        //    lvw.Items.Clear();
        //    foreach (DataRow row in table.Rows)
        //    {
        //        ListViewItem item = new ListViewItem(row["MaNguoiDan"].ToString());
        //        item.SubItems.Add(row["TenNguoiDan"].ToString());
        //        lvw.Items.Add(item);
        //    }

        //}

        //public static void TimTheoTen(ListViewEx lvw, String m_TenNguoiDan)
        //{
        //    NguoiDanData data = new NguoiDanData();
        //    DataTable table = data.TimTheoTen(m_TenNguoiDan);
        //    lvw.Items.Clear();
        //    foreach (DataRow row in table.Rows)
        //    {
        //        ListViewItem item = new ListViewItem(row["MANGUOIDAN"].ToString());
        //        item.SubItems.Add(row["TENNGUOIDAN"].ToString());
        //        lvw.Items.Add(item);
        //    }

        //}
        public void TimKiemNguoiDan(TextBoxX txtTenNguoiDan,
                            DataGridViewX dND,
                            BindingNavigator bND)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_NguoiDanData.TimKiemNguoiDan(txtTenNguoiDan.Text);

            bND.BindingSource = bS;
            dND.DataSource = bS;
        }


        public void TimTheoMa(String m_MaNguoiDan)
        {
            m_NguoiDanData.TimTheoMa(m_MaNguoiDan);
        }

        public void TimTheoTen(String m_MaNguoiDan)
        {
            m_NguoiDanData.TimTheoTen(m_MaNguoiDan);
        }
    }
}
