using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using GalaBuilding.Component;
using GalaBuilding.Controller;


namespace GalaBuilding
{
    public partial class frmMain : Office2007Form
    {
        NguoiDungCtrl m_NguoiDungCtrl = new NguoiDungCtrl();
        frmChucVu m_ChucVu = null;
       

        frmTraCuuNguoiDan m_TraCuuNguoiDan = null;

        frmDangNhap m_FormDangNhap = null;
        frmLoaiNguoiDung m_LoaiNguoiDung = null;
        frmNguoiDung m_NguoiDung = null;

        public frmMain()
        {
            InitializeComponent();
            System.Threading.Thread.Sleep(2000);
        }

       
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (DataService.OpenConnection())
            {
                MacDinh();
                DangNhap();
            }
            else
            {
                MacDinh();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthoatkhoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cửaSổNgangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
            
        }

        private void cửaSổDọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cửaSổBìnhThườngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }


       

        public void DangNhap()
        {


        Cont:
            if (m_FormDangNhap == null || m_FormDangNhap.IsDisposed)
                m_FormDangNhap = new frmDangNhap();
/*
            if (m_FormDangNhap.txtdangnhap.Text != "")
                m_FormDangNhap.checkLuuMatKhau.Checked = true;
            else// if (m_FormDangNhap.txtdangnhap.Text == "")
                m_FormDangNhap.checkLuuMatKhau.Checked = false;
            */

            if (m_FormDangNhap.ShowDialog() == DialogResult.OK)
            {
                if (m_FormDangNhap.txtdangnhap.Text == "")
                {
                    m_FormDangNhap.lblMatKhauLoi.Text = "";
                    m_FormDangNhap.lblDangNhapLoi.Text = "Bạn chưa nhập tên!";
                    goto Cont;
                }

                if (m_FormDangNhap.txtmatkhau.Text == "")
                {
                    m_FormDangNhap.lblDangNhapLoi.Text = "";
                    m_FormDangNhap.lblMatKhauLoi.Text = "Bạn chưa nhập mật khẩu!";
                    goto Cont;
                }

                //MessageBox.Show(m_FormDangNhap.txtdangnhap.Text); //Show cái này ra để debug :">
                int ketQua = m_NguoiDungCtrl.DangNhap(m_FormDangNhap.txtdangnhap.Text, m_FormDangNhap.txtmatkhau.Text);
                //MessageBox.Show(m_FormDangNhap.txtdangnhap.Text); //Show cái này ra để debug :">

                switch (ketQua)
                {
                    case 0:
                        m_FormDangNhap.lblMatKhauLoi.Text = "";
                        m_FormDangNhap.lblDangNhapLoi.Text = "Người dùng này không tồn tại!";
                        goto Cont;
                    case 1:
                        m_FormDangNhap.lblDangNhapLoi.Text = "";
                        m_FormDangNhap.lblMatKhauLoi.Text = "Mật khẩu không hợp lệ!";
                        goto Cont;
                    case 2:
                        if (m_FormDangNhap.checkLuuMatKhau.Checked == true)
                        {
                            m_NguoiDungCtrl.LuuTaiKhoan(m_FormDangNhap.txtdangnhap.Text, m_FormDangNhap.txtmatkhau.Text);
                        }
                        else //if (m_FormDangNhap.checkLuuMatKhau.Checked == false)
                            m_NguoiDungCtrl.XoaTaiKhoanDuocLuu();
                        

                        Permissions(Utilities.NguoiDung.MaLoaiND.MaLoaiND);
                        break;
                }
            }
            else
                return;
        }
       

        private void buttondangnhap_Click(object sender, EventArgs e)
        {
            if (m_FormDangNhap == null || m_FormDangNhap.IsDisposed)
                m_FormDangNhap = new frmDangNhap();

            //m_NguoiDungCtrl.HienThiTaiKhoanDuocLuu(m_FormDangNhap.txtdangnhap, m_FormDangNhap.txtmatkhau);

            m_FormDangNhap.txtdangnhap.Text = "";
            m_FormDangNhap.txtmatkhau.Text = "";
            m_FormDangNhap.lblDangNhapLoi.Text = "";
            m_FormDangNhap.lblMatKhauLoi.Text = "";

            DangNhap();
        }

        private void buttondangxuat_Click(object sender, EventArgs e)
        {
            MacDinh();
            Form[] chill = this.MdiChildren;
            foreach (Form frm in chill)
            {
                if (frm != null) frm.Close();
            }
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhapctrl_Click(object sender, EventArgs e)
        {
            if (m_FormDangNhap == null || m_FormDangNhap.IsDisposed)
                m_FormDangNhap = new frmDangNhap();

            //
            if (m_FormDangNhap.txtdangnhap.Text != "")
                m_FormDangNhap.checkLuuMatKhau.Checked = true;
            else if (m_FormDangNhap.txtdangnhap.Text == "")
                m_FormDangNhap.checkLuuMatKhau.Checked = false;

            m_FormDangNhap.txtdangnhap.Text = "";
            m_FormDangNhap.txtmatkhau.Text = "";
            m_FormDangNhap.lblDangNhapLoi.Text = "";
            m_FormDangNhap.lblMatKhauLoi.Text = "";

            DangNhap();


        }

        private void btnDangXuatCtrl_Click(object sender, EventArgs e)
        {
            MacDinh();
        }

        private void bntthoatctrl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
      
        private void buttonItem27_Click(object sender, EventArgs e)
        {
            if (m_FormDangNhap == null || m_FormDangNhap.IsDisposed)
                m_FormDangNhap = new frmDangNhap();

            m_FormDangNhap.txtdangnhap.Text = "";
            m_FormDangNhap.txtmatkhau.Text = "";
            m_FormDangNhap.lblDangNhapLoi.Text = "";
            m_FormDangNhap.lblMatKhauLoi.Text = "";

            DangNhap();
        }

        private void buttonItem28_Click(object sender, EventArgs e)
        {
            MacDinh();
            Form[] chill = this.MdiChildren;
            foreach (Form frm in chill)
            {
                if (frm != null) frm.Close();
            }

        }


        private void buttonItem30_Click(object sender, EventArgs e)
        {
            if (m_NguoiDung == null || m_NguoiDung.IsDisposed)
            {
                m_NguoiDung = new frmNguoiDung();
                m_NguoiDung.MdiParent = frmMain.ActiveForm;
                m_NguoiDung.Show();
            }
            else m_NguoiDung.Activate();
        }

        private void buttonItem31_Click(object sender, EventArgs e)
        {
            if (backupDialog.ShowDialog() == DialogResult.OK)
            {
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("BACKUP DATABASE " + Utilities.DatabaseName + " TO DISK = '" + backupDialog.FileName.ToString() + "'");
                DataService data = new DataService();
                data.Load(cmd);
                MessageBoxEx.Show("Sao lưu dữ liệu thành công!", "BACKUP COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                return;
        }

        private void buttonItem32_Click(object sender, EventArgs e)
        {
            if (restoreDialog.ShowDialog() == DialogResult.OK)
            {
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("USE master RESTORE DATABASE " + Utilities.DatabaseName + " FROM DISK = '" + restoreDialog.FileName.ToString() + "'");
                DataService data = new DataService();
                data.Load(cmd);
                MessageBoxEx.Show("Phục hồi dữ liệu thành công!", "RESTORE COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                return;
        }

        private void buttonItem33_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem46_Click(object sender, EventArgs e)
        {

        }

        private void tSMQuyDinh_Click(object sender, EventArgs e)
        {
        }


        public void Permissions(String m_Per)
        {
            switch (m_Per)
            {
                case "LND001": GiamDoc(); break;
                case "LND002": PhoGiamDoc(); break;
                case "LND003": QuanDoc(); break;
                default: MacDinh(); break;
            }
        }
        //mac dinh
        public void MacDinh()
        {
            
            buttondangnhap.Enabled = true;
            buttonthoat.Enabled = true;
            tSMLoaiNguoiDung.Enabled = false;
            tSMNguoiDung.Enabled = false;
            tSMQuanTri.Enabled = false;

            buttondangxuat.Enabled = false;

            cmdQuanLyNguoiDan.Enabled = false;
            cmdQuanLyNhanVien.Enabled = false;
            cmdQuanLyDichVu.Enabled = false;
            cmdTraCuuNguoiDan.Enabled = false;
            cmdDangKyDichVu.Enabled = false;
            cmdTraCuuNhanVien.Enabled = false;

            tSMQuanLy.Enabled = false;
            tSMTraCuu.Enabled = false;

          
        }

        public void GiamDoc()
        {
            //False
            buttondangnhap.Enabled = false;


            //True

            buttondangxuat.Enabled = true;
            buttonthoat.Enabled = true;

            
            cmdQuanLyNguoiDan.Enabled = true;
            cmdQuanLyNhanVien.Enabled = true;
            cmdQuanLyDichVu.Enabled = true;
            cmdTraCuuNguoiDan.Enabled = true;
            cmdTraCuuNhanVien.Enabled = true;
            cmdDangKyDichVu.Enabled = true;

            tSMQuanTri.Enabled = true;
            tSMLoaiNguoiDung.Enabled = true;
            tSMNguoiDung.Enabled = true;
            tSMQuanLy.Enabled = true;
            tSMTraCuu.Enabled = true;
            tSMDichVu.Enabled = true;
            tSMDangKyDichVu.Enabled = true;
            tSMChucVu.Enabled = true;
        }

        public void PhoGiamDoc()
        {
            ////True
            buttondangxuat.Enabled = true;

            buttonthoat.Enabled = true;

          
            tSMNguoiDan.Enabled = true;
            tSMNhanVien.Enabled = true;

            cmdTraCuuNguoiDan.Enabled = true;
            cmdDangKyDichVu.Enabled = true;


            cmdQuanLyNguoiDan.Enabled = true;
            cmdQuanLyNhanVien.Enabled = true;
            cmdQuanLyDichVu.Enabled = true;
            cmdTraCuuNhanVien.Enabled = true;

            //False
            buttondangnhap.Enabled = false;
            tSMQuanTri.Enabled = false;
        }

        public void QuanDoc()
        {
            ////True
            buttondangxuat.Enabled = true;
            buttonthoat.Enabled = true;

        

            tSMNhanVien.Enabled = true;
            tSMDichVu.Enabled = true;
            tSMDangKyDichVu.Enabled = true;

            tSMTraCuu.Enabled = true;


            cmdQuanLyNguoiDan.Enabled = true;
            cmdQuanLyNhanVien.Enabled = true;
            cmdDangKyDichVu.Enabled = true;
            cmdTraCuuNguoiDan.Enabled = true;
            cmdTraCuuNhanVien.Enabled = true;

            //False
            buttondangnhap.Enabled = false;

            
            tSMChucVu.Enabled = false;
            tSMQuanLy.Enabled = false;
            tSMTraCuu.Enabled = false;
            tSMQuanTri.Enabled = false;
        }


        private void toolStripMenuItem84_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "QuanLy.chm", " ");
        }


        frmNguoiDan m_NguoiDan = null;
        private void toolStripMenuItem56_Click(object sender, EventArgs e)
        {
            if (m_NguoiDan == null || m_NguoiDan.IsDisposed)
            {
                m_NguoiDan = new frmNguoiDan();
                m_NguoiDan.MdiParent = frmMain.ActiveForm;
                m_NguoiDan.Show();
            }
            else m_NguoiDan.Activate();
        }

        frmNhanVien m_NhanVien = null;
        private void cmdQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            if (m_NhanVien == null || m_NhanVien.IsDisposed)
            {
                m_NhanVien = new frmNhanVien();
                m_NhanVien.MdiParent = frmMain.ActiveForm;
                m_NhanVien.Show();
            }
            else m_NhanVien.Activate();
        }
        
        frmDichVu m_DichVu = null;
        private void cmdQuanLyDichVu_Click(object sender, EventArgs e)
        {
            if (m_DichVu == null || m_DichVu.IsDisposed)
            {
                m_DichVu = new frmDichVu();
                m_DichVu.MdiParent = frmMain.ActiveForm;
                m_DichVu.Show();
            }
            else m_DichVu.Activate();
        }
        frmDangKyDichVu m_DangKyDichVu = null;
        private void cmdDangKyDichVu_Click(object sender, EventArgs e)
        {
            if (m_DangKyDichVu == null || m_DangKyDichVu.IsDisposed)
            {
                m_DangKyDichVu = new frmDangKyDichVu();
                m_DangKyDichVu.MdiParent = frmMain.ActiveForm;
                m_DangKyDichVu.Show();
            }
            else m_DangKyDichVu.Activate();
        }

        
        private void cmdTraCuuNguoiDan_Click(object sender, EventArgs e)
        {
            if (m_TraCuuNguoiDan == null || m_TraCuuNguoiDan.IsDisposed)
            {
                m_TraCuuNguoiDan = new frmTraCuuNguoiDan();
                m_TraCuuNguoiDan.MdiParent = frmMain.ActiveForm;
                m_TraCuuNguoiDan.Show();
            }
            else m_TraCuuNguoiDan.Activate();
        }

        frmTraCuuNhanVien m_TraCuuNhanVien = null;
        private void cmdTraCuuNhanVien_Click(object sender, EventArgs e)
        {
            if (m_TraCuuNhanVien == null || m_TraCuuNhanVien.IsDisposed)
            {
                m_TraCuuNhanVien = new frmTraCuuNhanVien();
                m_TraCuuNhanVien.MdiParent = frmMain.ActiveForm;
                m_TraCuuNhanVien.Show();
            }
            else m_TraCuuNhanVien.Activate();

        }

        private void cmdQuanLyNguoiDan_Click(object sender, EventArgs e)
        {
            if (m_NguoiDan == null || m_NguoiDan.IsDisposed)
            {
                m_NguoiDan = new frmNguoiDan();
                m_NguoiDan.MdiParent = frmMain.ActiveForm;
                m_NguoiDan.Show();
            }
            else m_NguoiDan.Activate();
        }

        private void tSBQuanLyNguoiDan_Click(object sender, EventArgs e)
        {
            if (m_NguoiDan == null || m_NguoiDan.IsDisposed)
            {
                m_NguoiDan = new frmNguoiDan();
                m_NguoiDan.MdiParent = frmMain.ActiveForm;
                m_NguoiDan.Show();
            }
            else m_NguoiDan.Activate();
        }

        private void tSBQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            if (m_NhanVien == null || m_NhanVien.IsDisposed)
            {
                m_NhanVien = new frmNhanVien();
                m_NhanVien.MdiParent = frmMain.ActiveForm;
                m_NhanVien.Show();
            }
            else m_NhanVien.Activate();
        }

        private void tSBQuanLyDichVu_Click(object sender, EventArgs e)
        {
            if (m_DichVu == null || m_DichVu.IsDisposed)
            {
                m_DichVu = new frmDichVu();
                m_DichVu.MdiParent = frmMain.ActiveForm;
                m_DichVu.Show();
            }
            else m_DichVu.Activate();
        }

 
        private void tSBDangKyDichVu_Click(object sender, EventArgs e)
        {
            if (m_DangKyDichVu == null || m_DangKyDichVu.IsDisposed)
            {
                m_DangKyDichVu = new frmDangKyDichVu();
                m_DangKyDichVu.MdiParent = frmMain.ActiveForm;
                m_DangKyDichVu.Show();
            }
            else m_DangKyDichVu.Activate();
        }

        private void tSBTraCuuNguoiDan_Click(object sender, EventArgs e)
        {
            if (m_TraCuuNguoiDan == null || m_TraCuuNguoiDan.IsDisposed)
            {
                m_TraCuuNguoiDan = new frmTraCuuNguoiDan();
                m_TraCuuNguoiDan.MdiParent = frmMain.ActiveForm;
                m_TraCuuNguoiDan.Show();
            }
            else m_TraCuuNguoiDan.Activate();
        }
     
        private void tSBTraCuuNhanVien_Click(object sender, EventArgs e)
        {
            if (m_TraCuuNhanVien == null || m_TraCuuNhanVien.IsDisposed)
            {
                m_TraCuuNhanVien = new frmTraCuuNhanVien();
                m_TraCuuNhanVien.MdiParent = frmMain.ActiveForm;
                m_TraCuuNhanVien.Show();
            }
            else m_TraCuuNhanVien.Activate();
        }

        private void tSMNguoiDan_Click(object sender, EventArgs e)
        {
            if (m_NguoiDan == null || m_NguoiDan.IsDisposed)
            {
                m_NguoiDan = new frmNguoiDan();
                m_NguoiDan.MdiParent = frmMain.ActiveForm;
                m_NguoiDan.Show();
            }
            else m_NguoiDan.Activate();
        }

        private void tSMNhanVien_Click(object sender, EventArgs e)
        {
            if (m_NhanVien == null || m_NhanVien.IsDisposed)
            {
                m_NhanVien = new frmNhanVien();
                m_NhanVien.MdiParent = frmMain.ActiveForm;
                m_NhanVien.Show();
            }
            else m_NhanVien.Activate();
        }

        private void tSMDichVu_Click(object sender, EventArgs e)
        {
            if (m_DichVu == null || m_DichVu.IsDisposed)
            {
                m_DichVu = new frmDichVu();
                m_DichVu.MdiParent = frmMain.ActiveForm;
                m_DichVu.Show();
            }
            else m_DichVu.Activate();
        }

        private void tSMDangKyDichVu_Click(object sender, EventArgs e)
        {
            if (m_DangKyDichVu == null || m_DangKyDichVu.IsDisposed)
            {
                m_DangKyDichVu = new frmDangKyDichVu();
                m_DangKyDichVu.MdiParent = frmMain.ActiveForm;
                m_DangKyDichVu.Show();
            }
            else m_DangKyDichVu.Activate();
        }



        private void tSMChucVu_Click(object sender, EventArgs e)
        {
            if (m_ChucVu == null || m_ChucVu.IsDisposed)
            {
                m_ChucVu = new frmChucVu();
                m_ChucVu.MdiParent = frmMain.ActiveForm;
                m_ChucVu.Show();
            }
            else m_ChucVu.Activate();
        }

        private void tSMTraCuuNguoiDan_Click(object sender, EventArgs e)
        {
            if (m_TraCuuNguoiDan == null || m_TraCuuNguoiDan.IsDisposed)
            {
                m_TraCuuNguoiDan = new frmTraCuuNguoiDan();
                m_TraCuuNguoiDan.MdiParent = frmMain.ActiveForm;
                m_TraCuuNguoiDan.Show();
            }
            else m_TraCuuNguoiDan.Activate();
        }

        private void tSMTraCuuNhanVien_Click(object sender, EventArgs e)
        {
            if (m_TraCuuNhanVien == null || m_TraCuuNhanVien.IsDisposed)
            {
                m_TraCuuNhanVien = new frmTraCuuNhanVien();
                m_TraCuuNhanVien.MdiParent = frmMain.ActiveForm;
                m_TraCuuNhanVien.Show();
            }
            else m_TraCuuNhanVien.Activate();
        }

        private void tSBQuyDinh_Click(object sender, EventArgs e)
        {
        }

        private void tSMLoaiNguoiDung_Click(object sender, EventArgs e)
        {
            if (m_LoaiNguoiDung == null || m_LoaiNguoiDung.IsDisposed)
            {
                m_LoaiNguoiDung = new frmLoaiNguoiDung();
                m_LoaiNguoiDung.MdiParent = frmMain.ActiveForm;
                m_LoaiNguoiDung.Show();
            }
            else m_LoaiNguoiDung.Activate();

        }

        private void tSMNguoiDung_Click(object sender, EventArgs e)
        {
            if (m_NguoiDung == null || m_NguoiDung.IsDisposed)
            {
                m_NguoiDung = new frmNguoiDung();
                m_NguoiDung.MdiParent = frmMain.ActiveForm;
                m_NguoiDung.Show();
            }
            else m_NguoiDung.Activate();

        }
    }
}