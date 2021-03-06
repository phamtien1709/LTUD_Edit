using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using GalaBuilding.DataLayer;
using System.Data;

namespace GalaBuilding.Controller
{
   public class DanTocCtrl
    {
       DanTocData m_DanTocData = new DanTocData();
       public void HienThiComboBox(ComboBox combobox)
       { 
           combobox.DataSource = m_DanTocData.LayDSDanToc();
           combobox.DisplayMember = "TenDanToc";
           combobox.ValueMember = "MaDanToc";
       }
       public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbComlumn)
       {
           cmbComlumn.DataSource = m_DanTocData.LayDSDanToc();
           cmbComlumn.DisplayMember = "TenDanToc";
           cmbComlumn.ValueMember = "MaDanToc";
           cmbComlumn.DataPropertyName = "MaDanToc";
           cmbComlumn.HeaderText = "Dân Tộc";
       }
       public void HienThi(DataGridViewX dgv, BindingNavigator bn)
       {
           BindingSource bs = new BindingSource();
           bs.DataSource = m_DanTocData.LayDSDanToc();
           bn.BindingSource = bs;
           dgv.DataSource = bs;
       }
       public DataRow ThemDongMoi()
       {
           return m_DanTocData.ThemDongMoi();
       }
       public void ThemDanToc(DataRow m_Row)
       {
            m_DanTocData.ThemDanToc(m_Row);
       }

       public bool LuuDanToc()
       {
           return m_DanTocData.LuuDanToc();
       }
       
    }
}
