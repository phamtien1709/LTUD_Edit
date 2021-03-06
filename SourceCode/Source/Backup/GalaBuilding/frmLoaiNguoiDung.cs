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
    public partial class frmLoaiNguoiDung : Office2007Form
    {
        LoaiNguoiDungCtrl m_LoaiNDCtrl = new LoaiNguoiDungCtrl();
        public frmLoaiNguoiDung()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmLoaiNguoiDung_Load(object sender, EventArgs e)
        {
            m_LoaiNDCtrl.HienThi(dgvLND, bdgLND);
        }

        private void bngThemmoi_Click(object sender, EventArgs e)
        {
            bngXoa.Enabled = true;
            DataRow m_Row = m_LoaiNDCtrl.ThemDongMoi();
            m_Row["MaLoaiND"] = "";
            m_Row["TenLoaiND"] = "";
            m_LoaiNDCtrl.ThemLoaiNguoiDung(m_Row);
            bdgLND.BindingSource.MoveLast();
        }

        private void bngXoa_Click(object sender, EventArgs e)
        {
            if (dgvLND.RowCount == 0)
                bngXoa.Enabled = false;
            else if (MessageBoxEx.Show("Bạn chắc chắn xóa không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgLND.BindingSource.RemoveCurrent();
            }
        }
        public Boolean KiemTraTruocKhiLuu(String cell)
        {
            foreach (DataGridViewRow row in dgvLND.Rows)
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
            if (KiemTraTruocKhiLuu("MaLoaiND") == true && KiemTraTruocKhiLuu("TenLoaiND") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_LoaiNDCtrl.LuuLoaiNguoiDung();
            }
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvLND_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}