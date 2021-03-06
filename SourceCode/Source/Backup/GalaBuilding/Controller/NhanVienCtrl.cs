﻿using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using GalaBuilding.Bussiness;
using GalaBuilding.DataLayer;
using System.Data.Odbc;
using System.Data;
using DevComponents.Editors.DateTimeAdv;

namespace GalaBuilding.Controller
{
    class NhanVienCtrl
    {
        NhanVienData m_NhanVienData = new NhanVienData();

        public void HienThiComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = m_NhanVienData.LayDsNhanVien();
            comboBox.DisplayMember = "TenNhanVien";
            comboBox.ValueMember = "MaNhanVien";
        }

        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_NhanVienData.LayDsNhanVien();
            cmbColumn.DisplayMember = "TenNhanVien";
            cmbColumn.ValueMember = "MaNhanVien";
            cmbColumn.DataPropertyName = "MaNhanVien";
            cmbColumn.HeaderText = "Nhân viên";
        }


        public void HienThi(DataGridViewX dGV,
                             BindingNavigator bN,
                             TextBoxX txtMaNhanVien,
                             TextBoxX txtTenNhanVien,
                             TextBoxX txtGioiTinh,
                             RadioButton opbNam,
                             RadioButton opbNu,
                             DateTimeInput dtpNgaySinh,
                             TextBoxX txtDiaChi,
                             TextBoxX txtDienThoai,
                             ComboBoxEx cmbChucVu)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_NhanVienData.LayDsNhanVien();

            txtMaNhanVien.DataBindings.Clear();
            txtMaNhanVien.DataBindings.Add("Text", bS, "MaNhanVien");

            txtTenNhanVien.DataBindings.Clear();
            txtTenNhanVien.DataBindings.Add("Text", bS, "TenNhanVien");

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Value", bS, "NgaySinh");

            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", bS, "GioiTinh");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bS, "DiaChi");

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bS, "DienThoai");

            cmbChucVu.DataBindings.Clear();
            cmbChucVu.DataBindings.Add("SelectedValue", bS, "MaChucVu");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public DataRow ThemDongMoi()
        {
            return m_NhanVienData.ThemDongMoi();
        }


        public void ThemNhanVien(DataRow m_Row)
        {
            m_NhanVienData.ThemNhanVien(m_Row);
        }

        public bool LuuNhanVien()
        {
            return m_NhanVienData.LuuNhanVien();
        }

        public void LuuNhanVien(String maNhanVien, String tenNhanVien, bool gioiTinh, DateTime ngaySinh, String diaChi, String dienThoai, String chucVu)
        {
            m_NhanVienData.LuuNhanVien(maNhanVien,tenNhanVien,gioiTinh,ngaySinh,diaChi,dienThoai,chucVu);
        }

        public static IList<NhanVienInfo> LayDsNhanVien()
        {
            NhanVienData m_NVData = new NhanVienData();
            DataTable m_DT = m_NVData.LayDsNhanVienForReport();

            IList<NhanVienInfo> dS = new List<NhanVienInfo>();

            foreach (DataRow Row in m_DT.Rows)
            {

                ChucVuInfo cv = new ChucVuInfo();
                cv.MaChucVu = Convert.ToString(Row["MaChucVu"]);
                cv.TenChucVu= Convert.ToString(Row["TenChucVu"]);

                NhanVienInfo nv = new NhanVienInfo();
                nv.MaNhanVien = Convert.ToString(Row["MaNhanVien"]);
                nv.TenNhanVien = Convert.ToString(Row["TenNhanVien"]);
                nv.DiaChi = Convert.ToString(Row["DiaChi"]);
                nv.DienThoai = Convert.ToString(Row["DienThoai"]);
                nv.ChucVu = cv;
                dS.Add(nv);
            }
            return dS;
        }

        public void TimKiemNhanVien(TextBoxX txtTenNhanVien,
                                   ComboBoxEx cmbTheoDiaChi,
                                   TextBoxX txtDiaChi,
                                   ComboBoxEx cmbTheoChucVu,
                                   ComboBoxEx cmbChucVu,
                                   DataGridViewX dNV,
                                   BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_NhanVienData.TimKiemNhanVien(txtTenNhanVien.Text, cmbTheoDiaChi.Text, txtDiaChi.Text, cmbTheoChucVu.Text, cmbChucVu.Text);
            bN.BindingSource = bS;
            dNV.DataSource = bS;
        }

        public void TimTheoMa(String m_MaNhanVien)
        {
            m_NhanVienData.TimTheoMa(m_MaNhanVien);
        }

        public void TimTheoTen(String m_TenNhanVien)
        {
            m_NhanVienData.TimTheoTen(m_TenNhanVien);
        }

        public void Import(string path, DataGridView dgv)
        {
            DataTable dtbNhanVienExcel = m_NhanVienData.LayDSNhanVienExcel(path);
            DataTable NhanVienTable = m_NhanVienData.LayDsNhanVien();

            int rowSuccess = 0;
            for (int i = 0; i < dtbNhanVienExcel.Rows.Count; i++)
            {
                bool t = false;
                for (int j = 0; j < NhanVienTable.Rows.Count; j++)
                {
                    if (dtbNhanVienExcel.Rows[i][0].ToString() != NhanVienTable.Rows[j][0].ToString())
                    {
                        t = true;
                    }
                    else
                    {
                        t = false;
                        j = NhanVienTable.Rows.Count;
                    }
                }
                if (t)
                {
                    DataRow rowthem = NhanVienTable.NewRow();
                    rowthem[0] = dtbNhanVienExcel.Rows[i][0].ToString();
                    rowthem[1] = dtbNhanVienExcel.Rows[i][1].ToString();
                    rowthem[2] = dtbNhanVienExcel.Rows[i][2].ToString();
                    rowthem[3] = dtbNhanVienExcel.Rows[i][3].ToString();
                    rowthem[4] = dtbNhanVienExcel.Rows[i][4].ToString();


                    NhanVienTable.Rows.Add(rowthem);

                    rowSuccess++;
                }
            }
            MessageBox.Show("Số dòng đã được thêm: " + rowSuccess.ToString() + " dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal void HienThi(DataGridViewX dgvNhanVien, BindingNavigator bdgNhanVien, TextBoxX txtMaNhanVien, TextBoxX txtTenNhanVien, TextBoxX txtDiachi, TextBoxX txtDThoai, ComboBoxEx cmbChucVu)
        {
            throw new NotImplementedException();
        }

        internal void LuuNhanVien(string p, string p_2, string p_3, string p_4, string p_5)
        {
            throw new NotImplementedException();
        }

        internal void LuuNhanVien(string p, string p_2, DataGridViewCheckBoxColumn GioiTinh, DataGridViewTextBoxColumn NgaySinh, string p_5, string p_6, string p_7)
        {
            throw new NotImplementedException();
        }
    }
}
