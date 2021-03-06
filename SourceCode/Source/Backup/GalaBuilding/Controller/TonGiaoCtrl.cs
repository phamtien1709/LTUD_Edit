using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using GalaBuilding.DataLayer;
using System.Data;

namespace GalaBuilding.Controller
{
   public class TonGiaoCtrl
    {
        TonGiaoData m_TonGiaoData = new TonGiaoData();
        public void HienThiComboBox(ComboBox combobox)
        {
            combobox.DataSource = m_TonGiaoData.LayDSTonGiao();
            combobox.DisplayMember = "TenTonGiao";
            combobox.ValueMember = "MaTonGiao";
        }
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbComlumn)
        {
            cmbComlumn.DataSource = m_TonGiaoData.LayDSTonGiao();
            cmbComlumn.DisplayMember = "TenTonGiao";
            cmbComlumn.ValueMember = "MaTonGiao";
            cmbComlumn.DataPropertyName = "MaTonGiao";
            cmbComlumn.HeaderText = "T�n Gi�o";
        }
        public void HienThi(DataGridViewX dgv, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = m_TonGiaoData.LayDSTonGiao();
            bn.BindingSource = bs;
            dgv.DataSource = bs;
        }
        public DataRow ThemDongMoi()
        {
            return m_TonGiaoData.ThemDongMoi();
        }
        public void ThemTonGiao(DataRow m_Row)
        {
            m_TonGiaoData.ThemTonGiao(m_Row);
        }

        public bool LuuTonGiao()
        {
            return m_TonGiaoData.LuuTonGiao();
        }
    }
}
