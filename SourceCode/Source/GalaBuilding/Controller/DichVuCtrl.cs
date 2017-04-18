using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using GalaBuilding.DataLayer;
using System.Data;

namespace GalaBuilding.Controller
{
    class DichVuCtrl
    {
        DichVuData m_DichVuData = new DichVuData();
        public void HienThiComboBox(ComboBox combobox)
        {
            combobox.DataSource = m_DichVuData.LayDSDanToc();
            combobox.DisplayMember = "TenDichVu";
            combobox.ValueMember = "MaDichVu";
        }
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbComlumn)
        {
            cmbComlumn.DataSource = m_DichVuData.LayDSDanToc();
            cmbComlumn.DisplayMember = "TenDichVu";
            cmbComlumn.ValueMember = "MaDichVu";
            cmbComlumn.DataPropertyName = "MaDichVu";
            cmbComlumn.HeaderText = "Dịch vụ";
        }
        public void HienThi(DataGridViewX dgv, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = m_DichVuData.LayDSDanToc();
            bn.BindingSource = bs;
            dgv.DataSource = bs;
        }
        public DataRow ThemDongMoi()
        {
            return m_DichVuData.ThemDongMoi();
        }
        public void ThemDichVu(DataRow m_Row)
        {
            m_DichVuData.ThemDichVu(m_Row);
        }

        public bool LuuDichVu()
        {
            return m_DichVuData.LuuDichVu();
        }
    }
}
