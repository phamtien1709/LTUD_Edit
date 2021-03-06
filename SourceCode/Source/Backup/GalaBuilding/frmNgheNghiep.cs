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
    public partial class frmNgheNghiep : Office2007Form
    {
        NgheNghiepCtrl m_NgheNghiepCtrl = new NgheNghiepCtrl();
        QuyDinh quyDinh = new QuyDinh();
        public frmNgheNghiep()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmNgheNghiep_Load(object sender, EventArgs e)
        {
            m_NgheNghiepCtrl.HienThi(dgvNN1, bdgNN);
        }


       
        public Boolean KiemTraTruocKhiLuu(String cell)
        {
            foreach (DataGridViewRow row in dgvNN1.Rows)
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
  

        private void bngThemmoi_Click_1(object sender, EventArgs e)
        {
            
            DataRow m_Row = m_NgheNghiepCtrl.ThemDongMoi();
            m_Row["MaNgheNghiep"] = "NN" + quyDinh.LaySTT(dgvNN1.Rows.Count + 1);
            m_Row["TenNgheNghiep"] = "";
            m_NgheNghiepCtrl.ThemNgheNghiep(m_Row);
            bdgNN.BindingSource.MoveLast();
        }

        private void bngXoa_Click_1(object sender, EventArgs e)
        {
            if (dgvNN1.RowCount == 0)
                bngXoa.Enabled = false;
            else if (MessageBoxEx.Show("Bạn chắc chắn xóa không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgNN.BindingSource.RemoveCurrent();
            }
        }

        private void bngluu_Click_1(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("MaNgheNghiep") == true && KiemTraTruocKhiLuu("TenNgheNghiep") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_NgheNghiepCtrl.LuuNgheNghiep();
            }
        }

        private void bngthoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            DataRow m_Row = m_NgheNghiepCtrl.ThemDongMoi();
            m_Row["MaNgheNghiep"] = "NN" + quyDinh.LaySTT(dgvNN1.Rows.Count + 1);
            m_Row["TenNgheNghiep"] = "";
            m_NgheNghiepCtrl.ThemNgheNghiep(m_Row);
            bdgNN.BindingSource.MoveLast();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvNN1.RowCount == 0)
                bngXoa.Enabled = false;
            else if (MessageBoxEx.Show("Bạn chắc chắn xóa không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgNN.BindingSource.RemoveCurrent();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("MaNgheNghiep") == true && KiemTraTruocKhiLuu("TenNgheNghiep") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_NgheNghiepCtrl.LuuNgheNghiep();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}