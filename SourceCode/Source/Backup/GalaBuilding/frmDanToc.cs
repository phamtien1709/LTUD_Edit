using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using GalaBuilding.Controller;
using GalaBuilding.Component;


namespace GalaBuilding
{
    public partial class frmDanToc : Office2007Form
    {
        DanTocCtrl m_DanTocCtrl = new DanTocCtrl();
        QuyDinh quyDinh = new QuyDinh();
        public frmDanToc()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmDanToc_Load(object sender, EventArgs e)
        {
            m_DanTocCtrl.HienThi(dgvDantoc, bdgDantoc);
        }

       
       
        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Boolean KiemTraTruocKhiLuu(String cell)
        {
            foreach (DataGridViewRow row in dgvDantoc.Rows)
            {
                if (row.Cells[cell].Value != null)
                {
                    String str = row.Cells[cell].Value.ToString();
                    if (str == "")
                    {
                        MessageBox.Show("Giá trị ô không được rỗng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }

        private void bngluu_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("MaDanToc") == true && KiemTraTruocKhiLuu("TenDanToc") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_DanTocCtrl.LuuDanToc();
            }
        }
        private void dGVDanToc_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            DataRow m_Row = m_DanTocCtrl.ThemDongMoi();
            m_Row["MaDanToc"] = "DT" + quyDinh.LaySTT(dgvDantoc.Rows.Count + 1);
            m_Row["TenDanToc"] = "";
            m_DanTocCtrl.ThemDanToc(m_Row);
            bdgDantoc.BindingSource.MoveLast();
        }

        private void bngThemmoi_Click(object sender, EventArgs e)
        {
           
            DataRow m_Row = m_DanTocCtrl.ThemDongMoi();
            m_Row["MaDanToc"] = "DT" + quyDinh.LaySTT(dgvDantoc.Rows.Count + 1);
            m_Row["TenDanToc"] = "";
            m_DanTocCtrl.ThemDanToc(m_Row);
            bdgDantoc.BindingSource.MoveLast();
        }

        private void bngXoa_Click_1(object sender, EventArgs e)
        {
            if (dgvDantoc.RowCount == 0)
                 bngXoa.Enabled = false;
            else if (MessageBoxEx.Show("Bạn chắc chắn xóa không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgDantoc.BindingSource.RemoveCurrent();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDantoc.RowCount == 0)
                bngXoa.Enabled = false;
            else if (MessageBoxEx.Show("Bạn chắc chắn xóa không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgDantoc.BindingSource.RemoveCurrent();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("MaDanToc") == true && KiemTraTruocKhiLuu("TenDanToc") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_DanTocCtrl.LuuDanToc();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close(); 
        }

        private void btnMenuDantoc_Click(object sender, EventArgs e)
        {

        }
       
    }
}

  
   

   