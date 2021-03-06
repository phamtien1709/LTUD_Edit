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
    public partial class frmQuyDinh : Office2007Form
    {
        QuyDinhCtrl m_QuyDinhCtrl = new QuyDinhCtrl();
        public frmQuyDinh()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmQuyDinh_Load(object sender, EventArgs e)
        {
            m_QuyDinhCtrl.HienThi(itiSoNguoiToiDa, itiDoTuoiNguoiDan_CD, itiDoTuoiNguoiDan_CT, itiDoTuoiNhanVien_CD, itiDoTuoiNhanVien_CT);
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongy_Click(object sender, EventArgs e)
        {
            if (tabControlPanelSoNguoiToiDa.CanSelect)
            {
                if (itiSoNguoiToiDa.Value < 0 || itiSoNguoiToiDa.Value >= 60)
                    MessageBoxEx.Show("Số người tối đa phải nằm trong khoảng giới hạn 0 - 60!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    m_QuyDinhCtrl.CapNhatQuyDinhSoNguoi(itiSoNguoiToiDa.Value);
                    MessageBoxEx.Show("Cập nhật thành công quy định về số người tối đa!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m_QuyDinhCtrl.HienThi(itiSoNguoiToiDa, itiDoTuoiNguoiDan_CD, itiDoTuoiNguoiDan_CT, itiDoTuoiNhanVien_CD, itiDoTuoiNhanVien_CT);
                }
            }

            else if (tabControlPanelTuoiNguoiDan.CanSelect)
            {
                if (itiDoTuoiNguoiDan_CD.Value < 0 || itiDoTuoiNguoiDan_CT.Value >= 150)
                    MessageBoxEx.Show("Độ tuổi người dân phải nằm trong khoảng giới hạn 0 - 150!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    m_QuyDinhCtrl.CapNhatQuyDinhDoTuoiNguoiDan(itiDoTuoiNguoiDan_CD.Value, itiDoTuoiNguoiDan_CT.Value);
                    MessageBoxEx.Show("Cập nhật thành công quy định về độ tuổi người dân!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m_QuyDinhCtrl.HienThi(itiSoNguoiToiDa, itiDoTuoiNguoiDan_CD, itiDoTuoiNguoiDan_CT, itiDoTuoiNhanVien_CD, itiDoTuoiNhanVien_CT);
                }
            }
            else if (tabControlPanelTuoiNhanVien.CanSelect)
            {
                if (itiDoTuoiNhanVien_CD.Value < 0 || itiDoTuoiNhanVien_CT.Value >= 150)
                    MessageBoxEx.Show("Độ tuổi nhân viên phải nằm trong khoảng giới hạn 0 - 150!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    m_QuyDinhCtrl.CapNhatQuyDinhDoTuoiNhanVien(itiDoTuoiNhanVien_CD.Value, itiDoTuoiNhanVien_CT.Value);
                    MessageBoxEx.Show("Cập nhật thành công quy định về độ tuổi nhân viên!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m_QuyDinhCtrl.HienThi(itiSoNguoiToiDa, itiDoTuoiNguoiDan_CD, itiDoTuoiNguoiDan_CT, itiDoTuoiNhanVien_CD, itiDoTuoiNhanVien_CT);
                }
            }
        }
        }
    }
