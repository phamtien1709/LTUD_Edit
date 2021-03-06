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
    public partial class frmChucVu : DevComponents.DotNetBar.Office2007Form
    {
        ChucVuCtrl m_ChucVuCtrl = new ChucVuCtrl();
        QuyDinh quyDinh = new QuyDinh();

        public frmChucVu()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            m_ChucVuCtrl.HienThi(dgvChucVu, bdgChucVu);
        }

        public Boolean KiemTraTruocKhiLuu(String cell)
        {
            foreach (DataGridViewRow row in dgvChucVu.Rows)
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
            if (KiemTraTruocKhiLuu("MaChucVu") == true && KiemTraTruocKhiLuu("TenChucVu") == true)
            {
                m_ChucVuCtrl.LuuChucVu();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("MaChucVu") == true && KiemTraTruocKhiLuu("TenChucVu") == true)
            {
                m_ChucVuCtrl.LuuChucVu();
            }
        }

        private void dgvChucVu_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void bngThemmoi_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_ChucVuCtrl.ThemDongMoi();
            m_Row["MaChucVu"] = "CV" + quyDinh.LaySTT(dgvChucVu.Rows.Count + 1);
            m_Row["TenChucVu"] = "";
            m_ChucVuCtrl.ThemChucVu(m_Row);
            bdgChucVu.BindingSource.MoveLast();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_ChucVuCtrl.ThemDongMoi();
            m_Row["MaChucVu"] = "CV" + quyDinh.LaySTT(dgvChucVu.Rows.Count + 1);
            m_Row["TenChucVu"] = "";
            m_ChucVuCtrl.ThemChucVu(m_Row);
            bdgChucVu.BindingSource.MoveLast();
        }

        private void bngXoa_Click(object sender, EventArgs e)
        {
            if (dgvChucVu.RowCount == 0)
                bngXoa.Enabled = false;
            else if (MessageBoxEx.Show("Bạn chắc chắn xóa không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgChucVu.BindingSource.RemoveCurrent();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvChucVu.RowCount == 0)
                bngXoa.Enabled = false;
            else if (MessageBoxEx.Show("Bạn chắc chắn xóa không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgChucVu.BindingSource.RemoveCurrent();
            }
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}