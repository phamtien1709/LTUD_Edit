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
    public partial class frmDichVu : Office2007Form
    {
        DichVuCtrl m_DichVuCtrl = new DichVuCtrl();
        QuyDinh quyDinh = new QuyDinh();
        public frmDichVu()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        private void frmDichVu_Load(object sender, EventArgs e)
        {
            m_DichVuCtrl.HienThi(dgvDichVu, bdgDichVu);
        }



        private void bngXoa_Click(object sender, EventArgs e)
        {
            if (dgvDichVu.RowCount == 0)
                bngXoa.Enabled = false;
            else if (MessageBoxEx.Show("Bạn chắc chắn xóa không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgDichVu.BindingSource.RemoveCurrent();
            }
        }
        public Boolean KiemTraTruocKhiLuu(String cell)
        {
            foreach (DataGridViewRow row in dgvDichVu.Rows)
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
            if (KiemTraTruocKhiLuu("MaDichVu") == true && KiemTraTruocKhiLuu("TenDichVu") == true)
            {
                m_DichVuCtrl.LuuDichVu();
            }
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDichVu.RowCount == 0)
                bngXoa.Enabled = false;
            else if (MessageBoxEx.Show("Bạn chắc chắn xóa không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgDichVu.BindingSource.RemoveCurrent();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("MaDichVu") == true && KiemTraTruocKhiLuu("TenDichVu") == true)
            {
                m_DichVuCtrl.LuuDichVu();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_DichVuCtrl.ThemDongMoi();
            m_Row["MaDichVu"] = "DV" + quyDinh.LaySTT(dgvDichVu.Rows.Count + 1); ;
            m_Row["TenDichVu"] = "";
            m_Row["DonGia"] = 0;
            m_DichVuCtrl.ThemDichVu(m_Row);
            bdgDichVu.BindingSource.MoveLast();
        }

        private void bngThemmoi_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_DichVuCtrl.ThemDongMoi();
            m_Row["MaDichVu"] = "DV" + quyDinh.LaySTT(dgvDichVu.Rows.Count + 1); ;
            m_Row["TenDichVu"] = "";
            m_Row["DonGia"] = 0;
            m_DichVuCtrl.ThemDichVu(m_Row);
            bdgDichVu.BindingSource.MoveLast();
        }
    }
}