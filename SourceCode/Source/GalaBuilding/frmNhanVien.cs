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
    public partial class frmNhanVien : Office2007Form
    {
        ChucVuCtrl m_ChucVuCtrl = new ChucVuCtrl();
        NhanVienCtrl m_NhanVienCtrl = new NhanVienCtrl();
        QuyDinh quyDinh = new QuyDinh();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            m_ChucVuCtrl.HienThiComboBox(cmbChucVu);
            m_ChucVuCtrl.HienThiDataGridViewComboBoxColumn(MaChucVu);
            m_NhanVienCtrl.HienThi(dgvNhanVien, bdgNhanVien, txtMaNhanVien, txtTenNhanVien,txtGioiTinh,opbNam,opbNu,dtiNgaySinh, cmbChucVu);
        }

        private void bngThemmoi_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_NhanVienCtrl.ThemDongMoi();
            m_Row["MaNhanVien"] = "NV" + quyDinh.LaySTT(dgvNhanVien.Rows.Count + 1);
            m_Row["TenNhanVien"] = "";
            m_Row["GioiTinh"] = false;
            m_Row["NgaySinh"] = DateTime.Today;
            m_Row["MaChucVu"] = "";
            m_NhanVienCtrl.ThemNhanVien(m_Row);
            bdgNhanVien.BindingSource.MoveLast();
        }

        private void bngXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.RowCount == 0)
                bngXoa.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgNhanVien.BindingSource.RemoveCurrent();
            }
        }
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvNhanVien.Rows)
            {
                
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Thông tin nhân viên " + row.Cells["TenNhanVien"].Value.ToString() + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        //public Boolean KiemTraDoTuoiTruocKhiLuu(String doTuoiColumn)
        //{
        //    foreach (DataGridViewRow row in dgvNhanVien.Rows)
        //    {
        //        if (row.Cells[doTuoiColumn].Value != null)
        //        {
        //            DateTime ngaySinh = Convert.ToDateTime(row.Cells[doTuoiColumn].Value.ToString());

        //            if (quyDinh.KiemTraDoTuoiNhanVien(ngaySinh) == false)
        //            {
        //                MessageBoxEx.Show("Tuổi nhân viên " + row.Cells["TenNhanVien"].Value.ToString() + " không đúng quy định!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return false;
        //            }
        //        }
        //    }
        //    return true;
        //}

        private void bngluu_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("MaNhanVien") == true &&
               KiemTraTruocKhiLuu("TenNhanVien") == true &&
               KiemTraTruocKhiLuu("GioiTinh") == true &&
               KiemTraTruocKhiLuu("NgaySinh") == true &&
               KiemTraTruocKhiLuu("MaChucVu") == true)
            {
                    m_NhanVienCtrl.LuuNhanVien();
            }
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            m_NhanVienCtrl.HienThi(dgvNhanVien, bdgNhanVien, txtMaNhanVien, txtTenNhanVien, txtGioiTinh, opbNam, opbNu, dtiNgaySinh, cmbChucVu);
        }

        private void btnLuuDS_Click(object sender, EventArgs e)
        {

            bool gioiTinh = false;
            if (opbNu.Checked == true)
                gioiTinh = true;

            if (txtMaNhanVien.Text!="" &&
                txtTenNhanVien.Text != "" &&
                dtiNgaySinh.Value != null &&
                cmbChucVu.SelectedValue != null)
            {
                    m_NhanVienCtrl.LuuNhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text, gioiTinh, dtiNgaySinh.Value, cmbChucVu.SelectedValue.ToString());
                    m_NhanVienCtrl.HienThi(dgvNhanVien, bdgNhanVien, txtMaNhanVien, txtTenNhanVien, txtGioiTinh, opbNam, opbNu, dtiNgaySinh, cmbChucVu);
                    bdgNhanVien.BindingSource.MoveLast();
            }
            else
                MessageBoxEx.Show("Giá trị của các ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void TimKiemNhanVien()
        {
                m_NhanVienCtrl.TimTheoTen(txtTimKiem.Text);
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemNhanVien();
            }
        }

        private void cmdTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
                MessageBoxEx.Show("Chưa nhập nội dung cần tìm kiếm vào khung!", "LỖI TÌM KIẾM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            TimKiemNhanVien();
        }

        //private void btnIPExcel_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog openDlg = new OpenFileDialog();
        //    openDlg.Title = "Chon mot file Excel";
        //    openDlg.RestoreDirectory = true;
        //    openDlg.Multiselect = false;
        //    openDlg.Filter = "Excel files (*.xls)|*.xls";

        //    if (openDlg.ShowDialog() == DialogResult.OK)
        //    {
        //        string fileName = openDlg.FileName;
        //        int viTriBatDau = fileName.LastIndexOf('\\') + 1;
        //        string tenFile = fileName.Substring(viTriBatDau);
        //        string path = fileName.Replace("\\", "\\\\");
        //        m_NhanVienCtrl.Import(path, dgvNhanVien);
        //    }
        //}

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtGioiTinh.Text == "True")
                opbNu.Checked = true;
            else
                opbNam.Checked = true;
        }

        private void cmdThemChucVu_Click(object sender, EventArgs e)
        {
            frmChucVu m_ChucVu = new frmChucVu();
            m_ChucVu.ShowDialog();
        }
    }
}