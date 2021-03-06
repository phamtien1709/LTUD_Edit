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
using GalaBuilding;

namespace GalaBuilding
{
    public partial class frmNguoiDan : DevComponents.DotNetBar.Office2007Form
    {

        NguoiDanCtrl m_NguoiDanCtrl = new NguoiDanCtrl();
        CanHoCtrl m_CanHoCtrl = new CanHoCtrl();
        DanTocCtrl m_DanTocCtrl = new DanTocCtrl();
        TonGiaoCtrl m_TonGiaoCtrl = new TonGiaoCtrl();
        NgheNghiepCtrl m_NgheNghiepCtrl = new NgheNghiepCtrl();
       
        QuyDinh quyDinh = new QuyDinh();

        public frmNguoiDan()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmNguoiDan_Load(object sender, EventArgs e)
        {
            
            m_DanTocCtrl.HienThiComboBox(cmbDanToc);
            m_TonGiaoCtrl.HienThiComboBox(cmbTonGiao1);
            m_NgheNghiepCtrl.HienThiComboBox(cmbNgheNghiep);

            m_DanTocCtrl.HienThiDataGridViewComboBoxColumn(MaDanToc);
            m_TonGiaoCtrl.HienThiDataGridViewComboBoxColumn(MaTonGiao);
            m_NgheNghiepCtrl.HienThiDataGridViewComboBoxColumnNN(MaNgheNghiep);

            //Hien thi bên ButtonItem Dang ky can ho
            m_CanHoCtrl.HienThiComboBox(cmbCanHoDK);

            m_NguoiDanCtrl.HienThi(dgvNguoiDan, bdgNguoiDan, txtMaNguoiDan, txtTenNguoiDan, txtGioiTinh, opbNam, opbNu, dtiNgaySinh, cmbDanToc, cmbTonGiao1, cmbNgheNghiep, txtTenNguoiDanDK);

        }

        private void cmdThemDanToc_Click(object sender, EventArgs e)
        {
            frmDanToc m_DanToc = new frmDanToc();
            m_DanToc.ShowDialog();
        }

        private void cmdThemTonGiao_Click(object sender, EventArgs e)
        {
            frmTonGiao m_TonGiao = new frmTonGiao();
            m_TonGiao.ShowDialog();
        }

        private void cmdThemNgheNghiep_Click(object sender, EventArgs e)
        {
            frmNgheNghiep m_NgheNghiep = new frmNgheNghiep();
            m_NgheNghiep.ShowDialog();
        }

        private void cmdThemVaoDS_Click(object sender, EventArgs e)
        {
            bool gioiTinh = false;
            if (opbNu.Checked == true)
                gioiTinh = true;

            if (txtMaNguoiDan.Text != "" &&
                txtTenNguoiDan.Text != "" &&
                dtiNgaySinh.Value != null &&
                cmbDanToc.SelectedValue != null &&
                cmbTonGiao1.SelectedValue != null &&
                cmbNgheNghiep.SelectedValue != null)
            {
                if (quyDinh.KiemTraDoTuoiNguoiDan(dtiNgaySinh.Value) == true)
                {

                    m_NguoiDanCtrl.LuuNguoiDan(txtMaNguoiDan.Text, txtTenNguoiDan.Text, gioiTinh, dtiNgaySinh.Value, cmbDanToc.SelectedValue.ToString(), cmbTonGiao1.SelectedValue.ToString(), cmbNgheNghiep.SelectedValue.ToString());
                    m_NguoiDanCtrl.HienThi(dgvNguoiDan, bdgNguoiDan, txtMaNguoiDan, txtTenNguoiDan, txtGioiTinh, opbNam, opbNu, dtiNgaySinh, cmbDanToc, cmbTonGiao1, cmbNgheNghiep, txtTenNguoiDanDK);

                    bdgNguoiDan.BindingSource.MoveLast();
                    MessageBox.Show("Thêm thành công!!");
                }
                else
                    MessageBoxEx.Show("Tuổi của người dân " + txtTenNguoiDan.Text + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBoxEx.Show("Giá trị của các ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void dgvNguoiDan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtGioiTinh.Text == "True")
                opbNu.Checked = true;
            else
                opbNam.Checked = true;
            if (cmbCanHoDK.Text == "") 
                m_CanHoCtrl.HienThiComboBox(cmbCanHoDK);
        }

        private void btnNhapExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Title = "Chon mot file Excel";
            openDlg.RestoreDirectory = true;
            openDlg.Multiselect = false;
            openDlg.Filter = "Excel files (*.xls)|*.xls";

            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = openDlg.FileName;
                int viTriBatDau = fileName.LastIndexOf('\\') + 1;
                string tenFile = fileName.Substring(viTriBatDau);
                string path = fileName.Replace("\\", "\\\\");
                m_NguoiDanCtrl.Import(path, dgvNguoiDan);
            }
        }

        void TimKiemNguoiDan()
        {
            if (checkTimTheoMa.Checked == true)
            {
                m_NguoiDanCtrl.TimTheoMa(txtTimKiem.Text);
            }
            else
            {
                m_NguoiDanCtrl.TimTheoTen(txtTimKiem.Text);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            m_NguoiDanCtrl.HienThi(dgvNguoiDan, bdgNguoiDan, txtMaNguoiDan, txtTenNguoiDan, txtGioiTinh, opbNam, opbNu, dtiNgaySinh, cmbDanToc, cmbTonGiao1, cmbNgheNghiep, txtTenNguoiDanDK);
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvNguoiDan.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Thông tin người dân " + row.Cells["TenNguoiDan"].Value.ToString() + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }
        
        public Boolean KiemTraDoTuoiTruocKhiLuu(String doTuoiColumn)
        {
            foreach (DataGridViewRow row in dgvNguoiDan.Rows)
            {
                //MessageBox.Show(row.ToString());
                if (row.Cells[doTuoiColumn].Value != null)
                {
                    DateTime ngaySinh = Convert.ToDateTime(row.Cells[doTuoiColumn].Value.ToString());

                    if (quyDinh.KiemTraDoTuoiNguoiDan(ngaySinh) == false)
                    {
                        MessageBoxEx.Show("Tuổi người dân " + row.Cells["TenNguoiDan"].Value.ToString() + " không đúng quy định!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }
         
        private void bngluu_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("MaNguoiDan") == true &&
            KiemTraTruocKhiLuu("TenNguoiDan") == true &&
            KiemTraTruocKhiLuu("MaDanToc") == true &&
            KiemTraTruocKhiLuu("MaTonGiao") == true &&
            KiemTraTruocKhiLuu("MaNgheNghiep") == true)
            {
                if (KiemTraDoTuoiTruocKhiLuu("NgaySinh") == true)
                {
                    bindingNavigatorPositionItem.Focus();
                    m_NguoiDanCtrl.LuuNguoiDan();
                    MessageBox.Show("Lưu thành công!!");
                }
    
            }
        }

        private void bngXoa_Click(object sender, EventArgs e)
        {
            if (dgvNguoiDan.RowCount == 0)
                bngXoa.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgNguoiDan.BindingSource.RemoveCurrent();
            }
        }

        private void bngThemmoi_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_NguoiDanCtrl.ThemDongMoi();
            m_Row["MaNguoiDan"] = "ND" + quyDinh.LaySTT(dgvNguoiDan.Rows.Count + 1);
            m_Row["TenNguoiDan"] = "";
            m_Row["GioiTinh"] = false;
            //m_Row["NgaySinh"] = DateTime.Today;
            m_Row["MaDanToc"] = "";
            m_Row["MaTonGiao"] = "";
            m_Row["MaNgheNghiep"] = "";
            m_NguoiDanCtrl.ThemNguoiDan(m_Row);

            bdgNguoiDan.BindingSource.MoveLast();
        }

        private void cmdTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
                MessageBoxEx.Show("Chưa nhập nội dung cần tìm kiếm vào khung!", "LỖI TÌM KIẾM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            TimKiemNguoiDan();
        }

        private void cmdDangKy_Click(object sender, EventArgs e)
        {
            if (txtTenNguoiDanDK.Text != "" && cmbCanHoDK.Text != "")
                if (quyDinh.KiemTraSoNguoi(cmbCanHoDK.Text))
                    if (m_CanHoCtrl.LuuCanHoNguoiDan(txtMaNguoiDan.Text, cmbCanHoDK.SelectedValue.ToString()))
                        MessageBox.Show("Đăng ký thành công!!");
                    else
                        MessageBox.Show("Người dân này đã đăng ký căn hộ này rồi!!\n Hãy dùng chức năng Tra Cứu để biết người dân nào đã ở căn hộ nào :)");
                else
                    MessageBox.Show("Phòng này đã có đủ số người quy định!", "LỖI ĐĂNG KÝ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBoxEx.Show("Chưa nhập nội dung cần đăng ký vào khung!", "LỖI ĐĂNG KÝ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}