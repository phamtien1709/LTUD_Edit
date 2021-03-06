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
    public partial class frmNguoiDung : Office2007Form
    {
        NguoiDungCtrl m_NguoiDungCtrl = new NguoiDungCtrl();
        LoaiNguoiDungCtrl m_LoaiNguoiDungCtrl = new LoaiNguoiDungCtrl();
        QuyDinh quyDinh = new QuyDinh();
        public frmNguoiDung()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            m_LoaiNguoiDungCtrl.HienThiDataGridViewComboBoxColumn(MaLoaiND);
            m_NguoiDungCtrl.HienThi(dgvND, bdgND);
        }

        private void bngThemmoi_Click(object sender, EventArgs e)
        {
            
            DataRow m_Row = m_NguoiDungCtrl.ThemDongMoi();
            m_Row["MaND"] = "ND" + quyDinh.LaySTT(dgvND.Rows.Count + 1); ;
            m_Row["MaLoaiND"] = "";
            m_Row["TenND"] = "";
            m_Row["TenDangNhap"] = "";
            m_Row["MatKhau"] = "";
            m_NguoiDungCtrl.ThemNguoiDung(m_Row);
            bdgND.BindingSource.MoveLast();
        }

        private void bngXoa_Click(object sender, EventArgs e)
        {
            if (dgvND.RowCount == 0)
                bngXoa.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgND.BindingSource.RemoveCurrent();
            }
        }
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvND.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Thông tin người dùng không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }
        private void bngluu_Click(object sender, EventArgs e)
        {
                m_NguoiDungCtrl.LuuNguoiDung();
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            DataRow m_Row = m_NguoiDungCtrl.ThemDongMoi();
            m_Row["MaND"] = "ND" + quyDinh.LaySTT(dgvND.Rows.Count + 1);
            m_Row["MaLoaiND"] = "";
            m_Row["TenND"] = "";
            m_Row["TenDangNhap"] = "";
            m_Row["MatKhau"] = "";
            m_NguoiDungCtrl.ThemNguoiDung(m_Row);
            bdgND.BindingSource.MoveLast();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvND.RowCount == 0)
                bngXoa.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgND.BindingSource.RemoveCurrent();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                m_NguoiDungCtrl.LuuNguoiDung();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}