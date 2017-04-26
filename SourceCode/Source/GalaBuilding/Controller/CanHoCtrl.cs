using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using GalaBuilding.Bussiness;
using GalaBuilding.DataLayer;
using System.Data.Odbc;
using System.Data;

namespace GalaBuilding.Controller
{
    class CanHoCtrl
    {
        CanHoData m_CanHoData = new CanHoData();

        public void HienThiComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = m_CanHoData.LayDsCanHo();
            comboBox.DisplayMember = "MaCanHo";
            comboBox.ValueMember = "MaCanHo";
        }

        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_CanHoData.LayDsCanHo();
            cmbColumn.DisplayMember = "MaCanHo";
            cmbColumn.ValueMember = "MaCanHo";
            cmbColumn.DataPropertyName = "MaCanHo";
            cmbColumn.HeaderText = "Mã Căn Hộ";
        }

        public bool LuuCanHoNguoiDan(String maNguoiDan, String maCanHo)
        {
            return m_CanHoData.LuuCanHoNguoiDan(maNguoiDan, maCanHo);
        }

        public bool LuuCanHoDichVu(String maCanHo, String maDichVu)
        {
            return m_CanHoData.LuuCanHoDichVu(maCanHo, maDichVu);
        }
        /*
        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN,
                            ComboBoxEx cmbMaCanHoDK
                            )
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_CanHoData.LayDsCanHo();

            DataTable dT = m_CanHoData.LayDsCanHo();

            cmbMaCanHoDK.DataBindings.Clear();
            cmbMaCanHoDK.DataBindings.Add("SelectedValue", bS, "MaCanHo");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        */

        public void TimKiemCanHo(TextBoxX txtMaCanHo,
                                   TextBoxX txtTenNguoiDan,
                                   ComboBoxEx cmbMaCanHoDK,
                                   DataGridViewX dGV,
                                   BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_CanHoData.TimKiemCanHo(txtMaCanHo.Text, txtTenNguoiDan.Text);

            cmbMaCanHoDK.DataBindings.Clear();
            cmbMaCanHoDK.DataBindings.Add("SelectedValue", bS, "MaCanHo");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
    }
}
