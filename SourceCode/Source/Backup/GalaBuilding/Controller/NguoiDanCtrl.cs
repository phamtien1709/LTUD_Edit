﻿using System;
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
                             ComboBoxEx cmbDanToc,
                             ComboBoxEx cmbTonGiao,
                             ComboBoxEx cmbNgheNghiep,
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

            cmbDanToc.DataBindings.Clear();
            cmbDanToc.DataBindings.Add("SelectedValue", bS, "MaDanToc");

            cmbTonGiao.DataBindings.Clear();
            cmbTonGiao.DataBindings.Add("SelectedValue", bS, "MaTonGiao");

            cmbNgheNghiep.DataBindings.Clear();
            cmbNgheNghiep.DataBindings.Add("SelectedValue", bS, "MaNgheNghiep");

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

                NgheNghiepInfo nn = new NgheNghiepInfo();
                nn.MaNgheNghiep = Convert.ToString(Row["MaNgheNghiep"]);
                nn.TenNgheNghiep = Convert.ToString(Row["TenNgheNghiep"]);

                DanTocInfo dt = new DanTocInfo();
                dt.MaDanToc = Convert.ToString(Row["MaDanToc"]);
                dt.TenDanToc = Convert.ToString(Row["TenDanToc"]);

                TonGiaoInfo tg = new TonGiaoInfo();
                tg.MaTonGiao = Convert.ToString(Row["MaTonGiao"]);
                tg.TenTonGiao = Convert.ToString(Row["TenTonGiao"]);

                nd.MaNguoiDan = Convert.ToString(Row["MaNguoiDan"]);
                nd.TenNguoiDan = Convert.ToString(Row["TenNguoiDan"]);
                nd.GioiTinh = Convert.ToBoolean(Row["GioiTinh"]);
                nd.NgaySinh = Convert.ToDateTime(Row["NgaySinh"]);
                nd.MaDanToc = dt;
                nd.MaTonGiao = tg;
                nd.MaNgheNghiep = nn;

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

        public void LuuNguoiDan(String maNguoiDan, String tenNguoiDan, bool gioiTinh, DateTime ngaySinh, String maDanToc, String maTonGiao,  String maNgheNghiep)
        {
            m_NguoiDanData.LuuNguoiDan(maNguoiDan, tenNguoiDan, gioiTinh, ngaySinh, maDanToc, maTonGiao, maNgheNghiep);
        }



        public void TimKiemNguoiDan(TextBoxX txtTenNguoiDan,
                                    ComboBoxEx cmbTheoCanHo,
                                    ComboBoxEx cmbMaCanHo,

                                    ComboBoxEx cmbTheoNgheNghiep,
                                    ComboBoxEx cmbNgheNghiep,
                                    ComboBoxEx cmbTheoDanToc,
                                    ComboBoxEx cmbDanToc,
                                    ComboBoxEx cmbTheoTonGiao,
                                    ComboBoxEx cmbTonGiao,

                                    DataGridViewX dND,
                                    BindingNavigator bND)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_NguoiDanData.TimKiemNguoiDan(txtTenNguoiDan.Text, cmbTheoCanHo.Text, cmbMaCanHo.Text, cmbTheoNgheNghiep.Text, cmbNgheNghiep.Text, cmbTheoDanToc.Text, cmbDanToc.Text, cmbTheoTonGiao.Text, cmbTonGiao.Text);

            bND.BindingSource = bS;
            dND.DataSource = bS;            
        }
        public static void TimTheoMa(ListViewEx lvw, String m_MaNguoiDan)
        {
            NguoiDanData data = new NguoiDanData();
            DataTable table = data.TimTheoMa(m_MaNguoiDan);
            lvw.Items.Clear();
            foreach (DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaNguoiDan"].ToString());
                item.SubItems.Add(row["TenNguoiDan"].ToString());
                lvw.Items.Add(item);
            }

        }

        public static void TimTheoTen(ListViewEx lvw, String m_TenNguoiDan)
        {
            NguoiDanData data = new NguoiDanData();
            DataTable table = data.TimTheoTen(m_TenNguoiDan);
            lvw.Items.Clear();
            foreach (DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem(row["MANGUOIDAN"].ToString());
                item.SubItems.Add(row["TENNGUOIDAN"].ToString());
                lvw.Items.Add(item);
            }

        }

        public void TimTheoMa(String m_MaNguoiDan)
        {
            m_NguoiDanData.TimTheoMa(m_MaNguoiDan);
        }

        public void TimTheoTen(String m_MaNguoiDan)
        {
            m_NguoiDanData.TimTheoTen(m_MaNguoiDan);
        }

        public void Import(string path, DataGridView dgv)
        {
            DataTable dtbNguoiDanExcel = m_NguoiDanData.LayDSNguoiDanExcel(path);
            DataTable NguoiDanTable = m_NguoiDanData.LayDsNguoiDan();

            int rowSuccess = 0;
            for (int i = 0; i < dtbNguoiDanExcel.Rows.Count; i++)
            {
                bool t = false;
                for (int j = 0; j < NguoiDanTable.Rows.Count; j++)
                {
                    if (dtbNguoiDanExcel.Rows[i][0].ToString() != NguoiDanTable.Rows[j][0].ToString())
                    {
                        t = true;
                    }
                    else
                    {
                        t = false;
                        j = NguoiDanTable.Rows.Count;
                    }
                }
                if (t)
                {
                    DataRow rowthem = NguoiDanTable.NewRow();
                    rowthem[0] = dtbNguoiDanExcel.Rows[i][0].ToString();
                    rowthem[1] = dtbNguoiDanExcel.Rows[i][1].ToString();
                    if (dtbNguoiDanExcel.Rows[i][2].ToString().Trim() == "TRUE")

                        rowthem[2] = Convert.ToBoolean(dtbNguoiDanExcel.Rows[i][2]);
                    else
                        rowthem[2] = Convert.ToBoolean(dtbNguoiDanExcel.Rows[i][2]);

                    //rowthem[2] = dtbHocSinhExcel.Rows[i][2].ToString();
                    rowthem[3] = dtbNguoiDanExcel.Rows[i][3].ToString();
                    rowthem[4] = dtbNguoiDanExcel.Rows[i][4].ToString();
                    rowthem[5] = dtbNguoiDanExcel.Rows[i][5].ToString();
                    rowthem[6] = dtbNguoiDanExcel.Rows[i][6].ToString();
                    rowthem[7] = dtbNguoiDanExcel.Rows[i][7].ToString();
                    rowthem[8] = dtbNguoiDanExcel.Rows[i][8].ToString();
                    rowthem[9] = dtbNguoiDanExcel.Rows[i][9].ToString();
                    rowthem[10] = dtbNguoiDanExcel.Rows[i][10].ToString();

                    NguoiDanTable.Rows.Add(rowthem);

                    rowSuccess++;
                }
            }
            MessageBox.Show("Số dòng đã được thêm: " + rowSuccess.ToString() + " dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        /*
        internal void TimKiemNguoiDan(TextBoxX txtTenNguoiDan, ComboBoxEx cmbTheoNgheNghiep, TextBoxX txtNgheNghiep, ComboBoxEx cmbTheoDantoc, ComboBoxEx cmbDanToc, ComboBoxEx cmbTheoTonGiao, ComboBoxEx cmbTonGiao, DataGridViewX dgvTKHocSinh, BindingNavigator bdgTKHocsinh)
        {
            throw new NotImplementedException();
        }
         */

        internal void TimKiemNguoiDan(TextBoxX txtTenNguoiDan,ComboBoxEx cmbTheoCanHo, ComboBoxEx cmbMaCanHo, ComboBoxEx cmbTheoNgheNghiep, TextBoxX txtNgheNghiep, ComboBoxEx cmbTheoDantoc, ComboBoxEx cmbDanToc, ComboBoxEx cmbTheoTonGiao, ComboBoxEx cmbTonGiao, DataGridViewX dgvTraCuuNguoiDan, BindingNavigator bdgTraCuuNguoiDan)
        {
            throw new NotImplementedException();
        }

    }
}
