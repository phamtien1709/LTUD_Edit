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
    public partial class frmTraCuuNhanVien : Office2007Form
    {
        ChucVuCtrl m_ChucVu = new ChucVuCtrl();
        NhanVienCtrl m_NhanVienCtrl = new NhanVienCtrl();
        public frmTraCuuNhanVien()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void cmdTraCuu_Click(object sender, EventArgs e)
        {
            m_NhanVienCtrl.TimKiemNhanVien(txtTenNhanVien, cmbTheoDiaChi, txtDiaChi, cmbTheoChucVu, cmbChucVu, dgvTraCuuNhanVien, bdgTraCuuNhanVien);
        }

        private void frmTraCuuNhanVien_Load(object sender, EventArgs e)
        {
            m_ChucVu.HienThiComboBox(cmbChucVu);
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}