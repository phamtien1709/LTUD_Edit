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
    public partial class frmTraCuuNguoiDan : Office2007Form
    {
        CanHoCtrl m_CanHoCtrl = new CanHoCtrl();
        NguoiDanCtrl m_NguoiDanCtrl = new NguoiDanCtrl();

        public frmTraCuuNguoiDan()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmTraCuuNguoiDan_Load(object sender, EventArgs e)
        {
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdTraCuu_Click(object sender, EventArgs e)
        {
            m_NguoiDanCtrl.TimKiemNguoiDan(txtTenNguoiDan, dgvTraCuuNguoiDan, bdgTraCuuNguoiDan);
            if (dgvTraCuuNguoiDan.RowCount == 0)
            {
                MessageBoxEx.Show("Không có người dân cần tìm trong hệ thống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bdgTKHocsinh_RefreshItems(object sender, EventArgs e)
        {

        }


    }
}