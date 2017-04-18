using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using GalaBuilding.DataLayer;
using System.Data;


namespace GalaBuilding.Controller
{
    class ChucVuCtrl
    {
        ChucVuData m_ChucVuData = new ChucVuData();
        public void HienThiComboBox(ComboBox combobox)
        {
            combobox.DataSource = m_ChucVuData.LayDSChucVu();
            combobox.DisplayMember = "TenChucVu";
            combobox.ValueMember = "MaChucVu";
        }
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbComlumn)
        {
            cmbComlumn.DataSource = m_ChucVuData.LayDSChucVu();
            cmbComlumn.DisplayMember = "TenChucVu";
            cmbComlumn.ValueMember = "MaChucVu";
            cmbComlumn.DataPropertyName = "MaChucVu";
            cmbComlumn.HeaderText = "Chức Vụ";
        }
        public void HienThi(DataGridViewX dgv, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = m_ChucVuData.LayDSChucVu();
            bn.BindingSource = bs;
            dgv.DataSource = bs;
        }
        public DataRow ThemDongMoi()
        {
            return m_ChucVuData.ThemDongMoi();
        }
        public void ThemChucVu(DataRow m_Row)
        {
            m_ChucVuData.ThemChucVu(m_Row);
        }

        public bool LuuChucVu()
        {
            return m_ChucVuData.LuuChucVu();
        }
    }
}
