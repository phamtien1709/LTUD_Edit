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
       
        QuyDinh quyDinh = new QuyDinh();

        public frmNguoiDan()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmNguoiDan_Load(object sender, EventArgs e)
        {
            

            //Hien thi bên ButtonItem Dang ky can ho
            m_CanHoCtrl.HienThiComboBox(cmbCanHoDK);

            m_NguoiDanCtrl.HienThi(dgvNguoiDan, bdgNguoiDan, txtMaNguoiDan, txtTenNguoiDan, txtGioiTinh, opbNam, opbNu, dtiNgaySinh, txtTenNguoiDanDK);

        }


        private void cmdThemVaoDS_Click(object sender, EventArgs e)
        {
            bool gioiTinh = false;
            if (opbNu.Checked == true)
                gioiTinh = true;

            if (txtMaNguoiDan.Text != "" &&
                txtTenNguoiDan.Text != "" &&
                dtiNgaySinh.Value != null)
            {
                    m_NguoiDanCtrl.LuuNguoiDan(txtMaNguoiDan.Text, txtTenNguoiDan.Text, gioiTinh, dtiNgaySinh.Value);
                    m_NguoiDanCtrl.HienThi(dgvNguoiDan, bdgNguoiDan, txtMaNguoiDan, txtTenNguoiDan, txtGioiTinh, opbNam, opbNu, dtiNgaySinh, txtTenNguoiDanDK);

                    bdgNguoiDan.BindingSource.MoveLast();
                    MessageBox.Show("Thêm thành công!!");
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


        void TimKiemNguoiDan()
        {
                m_NguoiDanCtrl.TimTheoTen(txtTimKiem.Text);
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
         
        private void bngluu_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("MaNguoiDan") == true &&
            KiemTraTruocKhiLuu("TenNguoiDan") == true)
            {
                    m_NguoiDanCtrl.LuuNguoiDan();
                    MessageBox.Show("Lưu thành công!!");
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
            m_Row["NgaySinh"] = DateTime.MinValue;
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

                    if (m_CanHoCtrl.LuuCanHoNguoiDan(txtMaNguoiDan.Text, cmbCanHoDK.SelectedValue.ToString()))
                        MessageBox.Show("Đăng ký thành công!!");
                    else
                        MessageBox.Show("Người dân này đã đăng ký căn hộ này rồi!!\n Hãy dùng chức năng Tra Cứu để biết người dân nào đã ở căn hộ nào :)");
            else
                MessageBoxEx.Show("Chưa nhập nội dung cần đăng ký vào khung!", "LỖI ĐĂNG KÝ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}