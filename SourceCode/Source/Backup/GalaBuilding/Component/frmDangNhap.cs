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


namespace GalaBuilding.Component
{
    public partial class frmDangNhap : Office2007Form
    {
       
        public frmDangNhap()
        {
            InitializeComponent();
            if (txtdangnhap.Text != "")
                checkLuuMatKhau.Checked = true;
            else //if (txtdangnhap.Text == "")
                checkLuuMatKhau.Checked = false;
        }
      
        private void btnhuybo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtmatkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            NguoiDungCtrl m_NguoiDungCtrl = new NguoiDungCtrl();
            m_NguoiDungCtrl.HienThiTaiKhoanDuocLuu(txtdangnhap, txtmatkhau);

            if (txtdangnhap.Text != "")
                checkLuuMatKhau.Checked = true;
            else //if (txtdangnhap.Text == "")
                checkLuuMatKhau.Checked = false;
        }

        private void cmdKetNoi_Click(object sender, EventArgs e)
        {
            frmConnection m_Connection = new frmConnection();
            m_Connection.ShowDialog();
        }
    }
}