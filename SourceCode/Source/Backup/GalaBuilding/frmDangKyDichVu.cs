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
    public partial class frmDangKyDichVu : Office2007Form
    {
        DichVuCtrl m_DichVuCtrl = new DichVuCtrl ();
        CanHoCtrl m_CanHoCtrl = new CanHoCtrl();
        public frmDangKyDichVu()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmTraCuuCanHo_Load(object sender, EventArgs e)
        {
            m_DichVuCtrl.HienThiComboBox(cmbMaDichVu);

            //Hien thi bên ButtonItem Dang ky can ho
            m_CanHoCtrl.HienThiComboBox(cmbMaCanHoDK);
            m_DichVuCtrl.HienThiComboBox(cmbMaDichVuDK);
        }

        private void dgvTCCanHo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cmbMaDichVuDK.Text == "")
                m_DichVuCtrl.HienThiComboBox(cmbMaDichVuDK);
        }
        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdTraCuu_Click(object sender, EventArgs e)
        {
            m_CanHoCtrl.TimKiemCanHo(txtMaCanHo, cmbTheoTenNguoiDan, txtTenNguoiDan, cmbTheoDichVu, cmbMaDichVu, cmbMaCanHoDK, dgvTCCanHo, bdgTCCanHo);

            if (dgvTCCanHo.RowCount == 0)
                MessageBoxEx.Show("Không có căn hộ cần tìm trong hệ thống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cmdDangKy_Click(object sender, EventArgs e)
        {
            if (cmbMaCanHoDK.Text != "" && cmbMaDichVuDK.Text != "")
                if (m_CanHoCtrl.LuuCanHoDichVu(cmbMaCanHoDK.SelectedValue.ToString(), cmbMaDichVuDK.SelectedValue.ToString()))
                    MessageBox.Show("Đăng ký thành công!!");
                else
                    MessageBox.Show("Căn hộ này đã đăng ký dịch vụ " + cmbMaDichVuDK.Text + " rồi!!");
            else
                MessageBoxEx.Show("Chưa nhập nội dung cần đăng ký vào khung!", "LỖI ĐĂNG KÝ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}