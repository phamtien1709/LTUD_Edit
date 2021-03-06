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
    public partial class frmTonGiao : Office2007Form
    {
        TonGiaoCtrl m_TonGiaoCtrl = new TonGiaoCtrl();
        QuyDinh quyDinh = new QuyDinh();
        public frmTonGiao()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmTonGiao_Load(object sender, EventArgs e)
        {
            m_TonGiaoCtrl.HienThi(dgvTonGiao, bdgTongiao);
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void bngThemmoi_Click(object sender, EventArgs e)
        {
            
            DataRow m_Row = m_TonGiaoCtrl.ThemDongMoi();
            m_Row["MaTonGiao"] = "TG" + quyDinh.LaySTT(dgvTonGiao.Rows.Count + 1);
            m_Row["TenTonGiao"] = "";
            m_TonGiaoCtrl.ThemTonGiao(m_Row);
            bdgTongiao.BindingSource.MoveLast();
        }

        private void bngXoa_Click(object sender, EventArgs e)
        {
            if (dgvTonGiao.RowCount == 0)
                bngXoa.Enabled = false;
            else if (MessageBoxEx.Show("Bạn chắc chắn xóa không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgTongiao.BindingSource.RemoveCurrent();
            }
        }

        public Boolean KiemTraTruocKhiLuu(String cell)
        {
            foreach (DataGridViewRow row in dgvTonGiao.Rows)
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
            if (KiemTraTruocKhiLuu("MaTonGiao") == true && KiemTraTruocKhiLuu("TenTonGiao") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_TonGiaoCtrl.LuuTonGiao();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            DataRow m_Row = m_TonGiaoCtrl.ThemDongMoi();
            m_Row["MaTonGiao"] = "TG" + quyDinh.LaySTT(dgvTonGiao.Rows.Count + 1);
            m_Row["TenTonGiao"] = "";
            m_TonGiaoCtrl.ThemTonGiao(m_Row);
            bdgTongiao.BindingSource.MoveLast();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTonGiao.RowCount == 0)
                bngXoa.Enabled = false;
            else if (MessageBoxEx.Show("Bạn chắc chắn xóa không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgTongiao.BindingSource.RemoveCurrent();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("MaTonGiao") == true && KiemTraTruocKhiLuu("TenTonGiao") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_TonGiaoCtrl.LuuTonGiao();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}