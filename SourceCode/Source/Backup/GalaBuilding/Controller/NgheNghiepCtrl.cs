using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using GalaBuilding.DataLayer;
using System.Data;

namespace GalaBuilding.Controller
{
   public class NgheNghiepCtrl
    {
        NgheNghiepData m_NgheNghiepData = new NgheNghiepData();
        public void HienThiComboBox(ComboBox combobox)
        {
            combobox.DataSource = m_NgheNghiepData.LayDSNgheNghiep();
            combobox.DisplayMember = "TenNgheNghiep";
            combobox.ValueMember = "MaNgheNghiep";
        }
        public void HienThiDataGridViewComboBoxColumnNN(DataGridViewComboBoxColumn cmbComlumn)
        {
            cmbComlumn.DataSource = m_NgheNghiepData.LayDSNgheNghiep();
            cmbComlumn.DisplayMember = "TenNgheNghiep";
            cmbComlumn.ValueMember = "MaNgheNghiep";
            cmbComlumn.DataPropertyName = "MaNgheNghiep";
            cmbComlumn.HeaderText = "Nghề nghiệp";
        }

        public void HienThi(DataGridViewX dgv, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = m_NgheNghiepData.LayDSNgheNghiep();
            bn.BindingSource = bs;
            dgv.DataSource = bs;
        }
        public DataRow ThemDongMoi()
        {
            return m_NgheNghiepData.ThemDongMoi();
        }
       public void ThemNgheNghiep(DataRow m_Row)
        {
            m_NgheNghiepData.ThemNgheNghiep(m_Row);
        }

       public bool LuuNgheNghiep()
        {
            return m_NgheNghiepData.LuuNgheNghiep();
        }

       public void HienThiDataGridViewComboBoxColumnNNCha(DataGridViewComboBoxColumn cmbComlumn)
       {
           cmbComlumn.DataSource = m_NgheNghiepData.LayDSNgheNghiep();
           cmbComlumn.DisplayMember = "TenNgheNghiep";
           cmbComlumn.ValueMember = "MaNgheNghiep";
           cmbComlumn.DataPropertyName = "MaNgheNghiepCha";
           cmbComlumn.HeaderText = "Nghề nghiệp cha";
       }

       public void HienThiDataGridViewComboBoxColumnNNMe(DataGridViewComboBoxColumn cmbComlumn)
       {
           cmbComlumn.DataSource = m_NgheNghiepData.LayDSNgheNghiep();
           cmbComlumn.DisplayMember = "TenNgheNghiep";
           cmbComlumn.ValueMember = "MaNgheNghiep";
           cmbComlumn.DataPropertyName = "MaNgheNghiepMe";
           cmbComlumn.HeaderText = "Nghề nghiệp mẹ";
       }
 
    }
}
