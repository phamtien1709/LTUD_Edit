using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using GalaBuilding.DataLayer;
using System.Data;

namespace GalaBuilding.Controller
{
   public class LoaiNguoiDungCtrl
    {
       LoaiNguoiDungData m_LoaiNguoiDungData = new LoaiNguoiDungData();
        public void HienThiComboBox(ComboBox combobox)
        {
            combobox.DataSource = m_LoaiNguoiDungData.LayDSLoaiNguoiDung();
            combobox.DisplayMember = "TenLoaiND";
            combobox.ValueMember = "MaLoaiND";
        }
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbComlumn)
        {
            cmbComlumn.DataSource = m_LoaiNguoiDungData.LayDSLoaiNguoiDung();
            cmbComlumn.DisplayMember = "TenLoaiND";
            cmbComlumn.ValueMember = "MaLoaiND";
            cmbComlumn.DataPropertyName = "MaLoaiND";
            cmbComlumn.HeaderText = "Loại Người Dùng";
        }
     
        public void HienThi(DataGridViewX dgv, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = m_LoaiNguoiDungData.LayDSLoaiNguoiDung();
            bn.BindingSource = bs;
            dgv.DataSource = bs;
        }
        public DataRow ThemDongMoi()
        {
            return m_LoaiNguoiDungData.ThemDongMoi();
        }
       public void ThemLoaiNguoiDung(DataRow m_Row)
        {
            m_LoaiNguoiDungData.ThemLoaiNguoiDung(m_Row);
        }

       public bool LuuLoaiNguoiDung()
        {
            return m_LoaiNguoiDungData.LuuLoaiNguoiDung();
        }
    }
}
