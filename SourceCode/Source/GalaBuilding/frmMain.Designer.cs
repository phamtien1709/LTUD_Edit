using System.Windows.Forms;
namespace GalaBuilding
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
       
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            System.Windows.Forms.DialogResult A;
            A = DevComponents.DotNetBar.MessageBoxEx.Show("Bạn có muốn thoát khỏi chương trình không?", "Quản Lý Dịch Vụ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (disposing && (components != null))
                components.Dispose();
            if (A == System.Windows.Forms.DialogResult.Yes)
                base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.office2007StartButton2 = new DevComponents.DotNetBar.Office2007StartButton();
            this.itemContainer5 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer6 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer7 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem15 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem16 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem17 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem18 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem19 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem20 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem14 = new DevComponents.DotNetBar.ButtonItem();
            this.galleryContainer2 = new DevComponents.DotNetBar.GalleryContainer();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.galleryContainer3 = new DevComponents.DotNetBar.GalleryContainer();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem6 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem7 = new DevComponents.DotNetBar.ButtonItem();
            this.galleryContainer1 = new DevComponents.DotNetBar.GalleryContainer();
            this.labelItem8 = new DevComponents.DotNetBar.LabelItem();
            this.buttonItem8 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem9 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem10 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem11 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem12 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem13 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabGiupdo = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabQuydinh = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabTracuu = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabThongKe = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabQuanLy = new DevComponents.DotNetBar.RibbonTabItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.office2007StartButton1 = new DevComponents.DotNetBar.Office2007StartButton();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.btnDangnhap = new DevComponents.DotNetBar.ButtonItem();
            this.btnDangxuat = new DevComponents.DotNetBar.ButtonItem();
            this.btnDoimatkhau = new DevComponents.DotNetBar.ButtonItem();
            this.btnQlyND = new DevComponents.DotNetBar.ButtonItem();
            this.btnSaoluudl = new DevComponents.DotNetBar.ButtonItem();
            this.btnPhuchoidl = new DevComponents.DotNetBar.ButtonItem();
            this.btnThoat = new DevComponents.DotNetBar.ButtonItem();
            this.office2007StartButton5 = new DevComponents.DotNetBar.Office2007StartButton();
            this.itemContainer17 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer18 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer19 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem34 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem35 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem36 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem37 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem38 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem39 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem40 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabQuanLy1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.galleryContainer4 = new DevComponents.DotNetBar.GalleryContainer();
            this.labelItem3 = new DevComponents.DotNetBar.LabelItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tSMQuanTri = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMLoaiNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMNguoiDan = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMDangKyDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMTraCuu = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMTraCuuNguoiDan = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMTraCuuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dânTộcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tônGiáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nghềNghiệpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quyĐịnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giúpĐỡToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinPhầnMềmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiểnThịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhtacvu = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhCôngCụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cửaSổNgangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cửaSổDọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cửaSổBìnhThườngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTTTruong = new System.Windows.Forms.ToolStripButton();
            this.btnTTPM = new System.Windows.Forms.ToolStripButton();
            this.panelTacvu = new DevComponents.DotNetBar.PanelEx();
            this.expelTracuu = new DevComponents.DotNetBar.ExpandablePanel();
            this.cmdTraCuuNhanVien = new DevComponents.DotNetBar.ButtonX();
            this.cmdTraCuuNguoiDan = new DevComponents.DotNetBar.ButtonX();
            this.expelquanly = new DevComponents.DotNetBar.ExpandablePanel();
            this.cmdQuanLyNguoiDan = new DevComponents.DotNetBar.ButtonX();
            this.cmdQuanLyDichVu = new DevComponents.DotNetBar.ButtonX();
            this.cmdQuanLyNhanVien = new DevComponents.DotNetBar.ButtonX();
            this.cmdDangKyDichVu = new DevComponents.DotNetBar.ButtonX();
            this.expanelHethong = new DevComponents.DotNetBar.ExpandablePanel();
            this.buttonthoat = new DevComponents.DotNetBar.ButtonX();
            this.buttondangnhap = new DevComponents.DotNetBar.ButtonX();
            this.buttondangxuat = new DevComponents.DotNetBar.ButtonX();
            this.backupDialog = new System.Windows.Forms.SaveFileDialog();
            this.restoreDialog = new System.Windows.Forms.OpenFileDialog();
            this.office2007StartButton3 = new DevComponents.DotNetBar.Office2007StartButton();
            this.itemContainer8 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer12 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer13 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem21 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem22 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem23 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem24 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem25 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem26 = new DevComponents.DotNetBar.ButtonItem();
            this.menuStrip1.SuspendLayout();
            this.panelTacvu.SuspendLayout();
            this.expelTracuu.SuspendLayout();
            this.expelquanly.SuspendLayout();
            this.expanelHethong.SuspendLayout();
            this.SuspendLayout();
            // 
            // office2007StartButton2
            // 
            this.office2007StartButton2.AutoExpandOnClick = true;
            this.office2007StartButton2.CanCustomize = false;
            this.office2007StartButton2.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.office2007StartButton2.ImagePaddingHorizontal = 2;
            this.office2007StartButton2.ImagePaddingVertical = 2;
            this.office2007StartButton2.Name = "office2007StartButton2";
            this.office2007StartButton2.ShowSubItems = false;
            this.office2007StartButton2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer5});
            this.office2007StartButton2.Text = "&File";
            // 
            // itemContainer5
            // 
            // 
            // 
            // 
            this.itemContainer5.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.itemContainer5.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer5.Name = "itemContainer5";
            this.itemContainer5.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer6});
            // 
            // itemContainer6
            // 
            // 
            // 
            // 
            this.itemContainer6.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
            this.itemContainer6.ItemSpacing = 0;
            this.itemContainer6.Name = "itemContainer6";
            this.itemContainer6.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer7});
            // 
            // itemContainer7
            // 
            // 
            // 
            // 
            this.itemContainer7.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.itemContainer7.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer7.MinimumSize = new System.Drawing.Size(120, 0);
            this.itemContainer7.Name = "itemContainer7";
            this.itemContainer7.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem15,
            this.buttonItem16,
            this.buttonItem17,
            this.buttonItem18,
            this.buttonItem19,
            this.buttonItem20});
            // 
            // buttonItem15
            // 
            this.buttonItem15.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem15.ImagePaddingHorizontal = 8;
            this.buttonItem15.Name = "buttonItem15";
            this.buttonItem15.SubItemsExpandWidth = 24;
            this.buttonItem15.Text = "&New";
            // 
            // buttonItem16
            // 
            this.buttonItem16.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem16.ImagePaddingHorizontal = 8;
            this.buttonItem16.Name = "buttonItem16";
            this.buttonItem16.SubItemsExpandWidth = 24;
            this.buttonItem16.Text = "&Open...";
            // 
            // buttonItem17
            // 
            this.buttonItem17.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem17.ImagePaddingHorizontal = 8;
            this.buttonItem17.Name = "buttonItem17";
            this.buttonItem17.SubItemsExpandWidth = 24;
            this.buttonItem17.Text = "&Save...";
            // 
            // buttonItem18
            // 
            this.buttonItem18.BeginGroup = true;
            this.buttonItem18.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem18.ImagePaddingHorizontal = 8;
            this.buttonItem18.Name = "buttonItem18";
            this.buttonItem18.SubItemsExpandWidth = 24;
            this.buttonItem18.Text = "S&hare...";
            // 
            // buttonItem19
            // 
            this.buttonItem19.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem19.ImagePaddingHorizontal = 8;
            this.buttonItem19.Name = "buttonItem19";
            this.buttonItem19.SubItemsExpandWidth = 24;
            this.buttonItem19.Text = "&Print...";
            // 
            // buttonItem20
            // 
            this.buttonItem20.BeginGroup = true;
            this.buttonItem20.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem20.ImagePaddingHorizontal = 8;
            this.buttonItem20.Name = "buttonItem20";
            this.buttonItem20.SubItemsExpandWidth = 24;
            this.buttonItem20.Text = "&Close";
            // 
            // buttonItem14
            // 
            this.buttonItem14.ImagePaddingHorizontal = 8;
            this.buttonItem14.Name = "buttonItem14";
            this.buttonItem14.Text = "buttonItem14";
            // 
            // galleryContainer2
            // 
            // 
            // 
            // 
            this.galleryContainer2.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer";
            this.galleryContainer2.EnableGalleryPopup = false;
            this.galleryContainer2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.galleryContainer2.MinimumSize = new System.Drawing.Size(180, 240);
            this.galleryContainer2.MultiLine = false;
            this.galleryContainer2.Name = "galleryContainer2";
            this.galleryContainer2.PopupUsesStandardScrollbars = false;
            // 
            // labelItem1
            // 
            this.labelItem1.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.labelItem1.BorderType = DevComponents.DotNetBar.eBorderType.Etched;
            this.labelItem1.CanCustomize = false;
            this.labelItem1.Name = "labelItem1";
            // 
            // galleryContainer3
            // 
            // 
            // 
            // 
            this.galleryContainer3.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer";
            this.galleryContainer3.EnableGalleryPopup = false;
            this.galleryContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.galleryContainer3.MinimumSize = new System.Drawing.Size(180, 240);
            this.galleryContainer3.MultiLine = false;
            this.galleryContainer3.Name = "galleryContainer3";
            this.galleryContainer3.PopupUsesStandardScrollbars = false;
            // 
            // labelItem2
            // 
            this.labelItem2.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.labelItem2.BorderType = DevComponents.DotNetBar.eBorderType.Etched;
            this.labelItem2.CanCustomize = false;
            this.labelItem2.Name = "labelItem2";
            // 
            // buttonItem2
            // 
            this.buttonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem2.ImagePaddingHorizontal = 8;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.SubItemsExpandWidth = 24;
            this.buttonItem2.Text = "&New";
            // 
            // buttonItem3
            // 
            this.buttonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem3.ImagePaddingHorizontal = 8;
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.SubItemsExpandWidth = 24;
            this.buttonItem3.Text = "&Open...";
            // 
            // buttonItem4
            // 
            this.buttonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem4.ImagePaddingHorizontal = 8;
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.SubItemsExpandWidth = 24;
            this.buttonItem4.Text = "&Save...";
            // 
            // buttonItem5
            // 
            this.buttonItem5.BeginGroup = true;
            this.buttonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem5.ImagePaddingHorizontal = 8;
            this.buttonItem5.Name = "buttonItem5";
            this.buttonItem5.SubItemsExpandWidth = 24;
            this.buttonItem5.Text = "S&hare...";
            // 
            // buttonItem6
            // 
            this.buttonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem6.ImagePaddingHorizontal = 8;
            this.buttonItem6.Name = "buttonItem6";
            this.buttonItem6.SubItemsExpandWidth = 24;
            this.buttonItem6.Text = "&Print...";
            // 
            // buttonItem7
            // 
            this.buttonItem7.BeginGroup = true;
            this.buttonItem7.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem7.ImagePaddingHorizontal = 8;
            this.buttonItem7.Name = "buttonItem7";
            this.buttonItem7.SubItemsExpandWidth = 24;
            this.buttonItem7.Text = "&Close";
            // 
            // galleryContainer1
            // 
            // 
            // 
            // 
            this.galleryContainer1.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer";
            this.galleryContainer1.EnableGalleryPopup = false;
            this.galleryContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.galleryContainer1.MinimumSize = new System.Drawing.Size(180, 240);
            this.galleryContainer1.MultiLine = false;
            this.galleryContainer1.Name = "galleryContainer1";
            this.galleryContainer1.PopupUsesStandardScrollbars = false;
            this.galleryContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem8,
            this.buttonItem8,
            this.buttonItem9,
            this.buttonItem10,
            this.buttonItem11});
            // 
            // labelItem8
            // 
            this.labelItem8.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.labelItem8.BorderType = DevComponents.DotNetBar.eBorderType.Etched;
            this.labelItem8.CanCustomize = false;
            this.labelItem8.Name = "labelItem8";
            this.labelItem8.PaddingBottom = 2;
            this.labelItem8.PaddingTop = 2;
            this.labelItem8.Stretch = true;
            this.labelItem8.Text = "Recent Documents";
            // 
            // buttonItem8
            // 
            this.buttonItem8.ImagePaddingHorizontal = 8;
            this.buttonItem8.Name = "buttonItem8";
            this.buttonItem8.Text = "&1. Short News 5-7.rtf";
            // 
            // buttonItem9
            // 
            this.buttonItem9.ImagePaddingHorizontal = 8;
            this.buttonItem9.Name = "buttonItem9";
            this.buttonItem9.Text = "&2. Prospect Email.rtf";
            // 
            // buttonItem10
            // 
            this.buttonItem10.ImagePaddingHorizontal = 8;
            this.buttonItem10.Name = "buttonItem10";
            this.buttonItem10.Text = "&3. Customer Email.rtf";
            // 
            // buttonItem11
            // 
            this.buttonItem11.ImagePaddingHorizontal = 8;
            this.buttonItem11.Name = "buttonItem11";
            this.buttonItem11.Text = "&4. example.rtf";
            // 
            // itemContainer4
            // 
            // 
            // 
            // 
            this.itemContainer4.BackgroundStyle.Class = "RibbonFileMenuBottomContainer";
            this.itemContainer4.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer4.Name = "itemContainer4";
            this.itemContainer4.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem12,
            this.buttonItem13});
            // 
            // buttonItem12
            // 
            this.buttonItem12.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem12.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonItem12.ImagePaddingHorizontal = 8;
            this.buttonItem12.Name = "buttonItem12";
            this.buttonItem12.SubItemsExpandWidth = 24;
            this.buttonItem12.Text = "Opt&ions";
            // 
            // buttonItem13
            // 
            this.buttonItem13.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem13.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonItem13.ImagePaddingHorizontal = 8;
            this.buttonItem13.Name = "buttonItem13";
            this.buttonItem13.SubItemsExpandWidth = 24;
            this.buttonItem13.Text = "E&xit";
            // 
            // ribbonTabGiupdo
            // 
            this.ribbonTabGiupdo.ImagePaddingHorizontal = 8;
            this.ribbonTabGiupdo.Name = "ribbonTabGiupdo";
            this.ribbonTabGiupdo.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F6);
            this.ribbonTabGiupdo.Text = "Giúp Đỡ";
            this.ribbonTabGiupdo.Tooltip = "Giúp Đỡ(F6)";
            // 
            // ribbonTabQuydinh
            // 
            this.ribbonTabQuydinh.ImagePaddingHorizontal = 8;
            this.ribbonTabQuydinh.Name = "ribbonTabQuydinh";
            this.ribbonTabQuydinh.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.ribbonTabQuydinh.Text = "Quy Định";
            this.ribbonTabQuydinh.Tooltip = "Quy Định(F5)";
            // 
            // ribbonTabTracuu
            // 
            this.ribbonTabTracuu.ImagePaddingHorizontal = 8;
            this.ribbonTabTracuu.Name = "ribbonTabTracuu";
            this.ribbonTabTracuu.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F4);
            this.ribbonTabTracuu.Text = "Tra Cứu";
            this.ribbonTabTracuu.Tooltip = "Tra Cứu(F4)";
            // 
            // ribbonTabThongKe
            // 
            this.ribbonTabThongKe.AutoCheckOnClick = true;
            this.ribbonTabThongKe.ImagePaddingHorizontal = 8;
            this.ribbonTabThongKe.Name = "ribbonTabThongKe";
            this.ribbonTabThongKe.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F3);
            this.ribbonTabThongKe.Text = "Thống Kê";
            this.ribbonTabThongKe.Tooltip = "Thống Kê (F3)";
            // 
            // ribbonTabQuanLy
            // 
            this.ribbonTabQuanLy.Checked = true;
            this.ribbonTabQuanLy.ImagePaddingHorizontal = 8;
            this.ribbonTabQuanLy.Name = "ribbonTabQuanLy";
            this.ribbonTabQuanLy.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.ribbonTabQuanLy.Text = "&Quản Lý";
            this.ribbonTabQuanLy.Tooltip = "Quản Lý (F2)";
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            this.qatCustomizeItem1.Tooltip = "Thanh công cụ truy xuất nhanh";
            // 
            // office2007StartButton1
            // 
            this.office2007StartButton1.AutoExpandOnClick = true;
            this.office2007StartButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.office2007StartButton1.ImagePaddingHorizontal = 2;
            this.office2007StartButton1.ImagePaddingVertical = 2;
            this.office2007StartButton1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed;
            this.office2007StartButton1.Name = "office2007StartButton1";
            this.office2007StartButton1.ShowSubItems = false;
            this.office2007StartButton1.StopPulseOnMouseOver = false;
            this.office2007StartButton1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.office2007StartButton1.Text = "Start";
            this.office2007StartButton1.Tooltip = "Start";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer2});
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
            this.itemContainer2.ItemSpacing = 0;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer3});
            // 
            // itemContainer3
            // 
            // 
            // 
            // 
            this.itemContainer3.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.itemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer3.MinimumSize = new System.Drawing.Size(120, 0);
            this.itemContainer3.Name = "itemContainer3";
            this.itemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDangnhap,
            this.btnDangxuat,
            this.btnDoimatkhau,
            this.btnQlyND,
            this.btnSaoluudl,
            this.btnPhuchoidl,
            this.btnThoat});
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.BeginGroup = true;
            this.btnDangnhap.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDangnhap.ImagePaddingHorizontal = 8;
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.PopupWidth = 100;
            this.btnDangnhap.Text = "Đăng Nhập";
            this.btnDangnhap.Tooltip = "Đăng nhập";
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.AutoCheckOnClick = true;
            this.btnDangxuat.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDangxuat.ImagePaddingHorizontal = 8;
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.SubItemsExpandWidth = 24;
            this.btnDangxuat.Text = "Đăng Xuất";
            this.btnDangxuat.Tooltip = "Đăng Xuất";
            // 
            // btnDoimatkhau
            // 
            this.btnDoimatkhau.BeginGroup = true;
            this.btnDoimatkhau.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDoimatkhau.ImagePaddingHorizontal = 8;
            this.btnDoimatkhau.Name = "btnDoimatkhau";
            this.btnDoimatkhau.SubItemsExpandWidth = 24;
            this.btnDoimatkhau.Text = "Đổi mật khẩu";
            this.btnDoimatkhau.Tooltip = "Đổi mật khẩu";
            // 
            // btnQlyND
            // 
            this.btnQlyND.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnQlyND.ImagePaddingHorizontal = 8;
            this.btnQlyND.Name = "btnQlyND";
            this.btnQlyND.Text = "Quản lý người dùng";
            this.btnQlyND.Tooltip = "Quản lý người dùng";
            // 
            // btnSaoluudl
            // 
            this.btnSaoluudl.BeginGroup = true;
            this.btnSaoluudl.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSaoluudl.ImagePaddingHorizontal = 8;
            this.btnSaoluudl.Name = "btnSaoluudl";
            this.btnSaoluudl.SubItemsExpandWidth = 24;
            this.btnSaoluudl.Text = "Sao lưu dữ liệu";
            this.btnSaoluudl.Tooltip = "Sao lưu dữ liệu";
            // 
            // btnPhuchoidl
            // 
            this.btnPhuchoidl.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnPhuchoidl.ImagePaddingHorizontal = 8;
            this.btnPhuchoidl.Name = "btnPhuchoidl";
            this.btnPhuchoidl.SubItemsExpandWidth = 24;
            this.btnPhuchoidl.Text = "Phục hồi dữ liệu";
            this.btnPhuchoidl.Tooltip = "Phục hồi dữ liệu";
            // 
            // btnThoat
            // 
            this.btnThoat.BeginGroup = true;
            this.btnThoat.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnThoat.ImagePaddingHorizontal = 8;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.SubItemsExpandWidth = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Tooltip = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // office2007StartButton5
            // 
            this.office2007StartButton5.AutoExpandOnClick = true;
            this.office2007StartButton5.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.office2007StartButton5.ImagePaddingHorizontal = 2;
            this.office2007StartButton5.ImagePaddingVertical = 2;
            this.office2007StartButton5.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed;
            this.office2007StartButton5.Name = "office2007StartButton5";
            this.office2007StartButton5.ShowSubItems = false;
            this.office2007StartButton5.StopPulseOnMouseOver = false;
            this.office2007StartButton5.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer17});
            this.office2007StartButton5.Text = "Start";
            this.office2007StartButton5.Tooltip = "Start";
            // 
            // itemContainer17
            // 
            // 
            // 
            // 
            this.itemContainer17.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.itemContainer17.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer17.Name = "itemContainer17";
            this.itemContainer17.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer18});
            // 
            // itemContainer18
            // 
            // 
            // 
            // 
            this.itemContainer18.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
            this.itemContainer18.ItemSpacing = 0;
            this.itemContainer18.Name = "itemContainer18";
            this.itemContainer18.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer19});
            // 
            // itemContainer19
            // 
            // 
            // 
            // 
            this.itemContainer19.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.itemContainer19.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer19.MinimumSize = new System.Drawing.Size(120, 0);
            this.itemContainer19.Name = "itemContainer19";
            this.itemContainer19.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem34,
            this.buttonItem35,
            this.buttonItem36,
            this.buttonItem37,
            this.buttonItem38,
            this.buttonItem39,
            this.buttonItem40});
            // 
            // buttonItem34
            // 
            this.buttonItem34.BeginGroup = true;
            this.buttonItem34.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem34.ImagePaddingHorizontal = 8;
            this.buttonItem34.Name = "buttonItem34";
            this.buttonItem34.PopupWidth = 100;
            this.buttonItem34.Text = "Đăng Nhập";
            this.buttonItem34.Tooltip = "Đăng nhập";
            // 
            // buttonItem35
            // 
            this.buttonItem35.AutoCheckOnClick = true;
            this.buttonItem35.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem35.ImagePaddingHorizontal = 8;
            this.buttonItem35.Name = "buttonItem35";
            this.buttonItem35.SubItemsExpandWidth = 24;
            this.buttonItem35.Text = "Đăng Xuất";
            this.buttonItem35.Tooltip = "Đăng Xuất";
            // 
            // buttonItem36
            // 
            this.buttonItem36.BeginGroup = true;
            this.buttonItem36.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem36.ImagePaddingHorizontal = 8;
            this.buttonItem36.Name = "buttonItem36";
            this.buttonItem36.SubItemsExpandWidth = 24;
            this.buttonItem36.Text = "Đổi mật khẩu";
            this.buttonItem36.Tooltip = "Đổi mật khẩu";
            // 
            // buttonItem37
            // 
            this.buttonItem37.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem37.ImagePaddingHorizontal = 8;
            this.buttonItem37.Name = "buttonItem37";
            this.buttonItem37.Text = "Quản lý người dùng";
            this.buttonItem37.Tooltip = "Quản lý người dùng";
            // 
            // buttonItem38
            // 
            this.buttonItem38.BeginGroup = true;
            this.buttonItem38.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem38.ImagePaddingHorizontal = 8;
            this.buttonItem38.Name = "buttonItem38";
            this.buttonItem38.SubItemsExpandWidth = 24;
            this.buttonItem38.Text = "Sao lưu dữ liệu";
            this.buttonItem38.Tooltip = "Sao lưu dữ liệu";
            // 
            // buttonItem39
            // 
            this.buttonItem39.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem39.ImagePaddingHorizontal = 8;
            this.buttonItem39.Name = "buttonItem39";
            this.buttonItem39.SubItemsExpandWidth = 24;
            this.buttonItem39.Text = "Phục hồi dữ liệu";
            this.buttonItem39.Tooltip = "Phục hồi dữ liệu";
            // 
            // buttonItem40
            // 
            this.buttonItem40.BeginGroup = true;
            this.buttonItem40.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem40.ImagePaddingHorizontal = 8;
            this.buttonItem40.Name = "buttonItem40";
            this.buttonItem40.SubItemsExpandWidth = 24;
            this.buttonItem40.Text = "Thoát";
            this.buttonItem40.Tooltip = "Thoát";
            // 
            // ribbonTabQuanLy1
            // 
            this.ribbonTabQuanLy1.Checked = true;
            this.ribbonTabQuanLy1.ImagePaddingHorizontal = 8;
            this.ribbonTabQuanLy1.Name = "ribbonTabQuanLy1";
            this.ribbonTabQuanLy1.Text = "Năm Học";
            // 
            // galleryContainer4
            // 
            // 
            // 
            // 
            this.galleryContainer4.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer";
            this.galleryContainer4.EnableGalleryPopup = false;
            this.galleryContainer4.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.galleryContainer4.MinimumSize = new System.Drawing.Size(180, 240);
            this.galleryContainer4.MultiLine = false;
            this.galleryContainer4.Name = "galleryContainer4";
            this.galleryContainer4.PopupUsesStandardScrollbars = false;
            // 
            // labelItem3
            // 
            this.labelItem3.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.labelItem3.BorderType = DevComponents.DotNetBar.eBorderType.Etched;
            this.labelItem3.CanCustomize = false;
            this.labelItem3.Name = "labelItem3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMQuanTri,
            this.tSMQuanLy,
            this.tSMTraCuu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1280, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tSMQuanTri
            // 
            this.tSMQuanTri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMLoaiNguoiDung,
            this.tSMNguoiDung});
            this.tSMQuanTri.Name = "tSMQuanTri";
            this.tSMQuanTri.Size = new System.Drawing.Size(65, 20);
            this.tSMQuanTri.Text = "Quản Trị";
            // 
            // tSMLoaiNguoiDung
            // 
            this.tSMLoaiNguoiDung.Image = global::GalaBuilding.Properties.Resources.nguoidung;
            this.tSMLoaiNguoiDung.Name = "tSMLoaiNguoiDung";
            this.tSMLoaiNguoiDung.Size = new System.Drawing.Size(164, 22);
            this.tSMLoaiNguoiDung.Text = "Loại Người Dùng";
            this.tSMLoaiNguoiDung.Click += new System.EventHandler(this.tSMLoaiNguoiDung_Click);
            // 
            // tSMNguoiDung
            // 
            this.tSMNguoiDung.Image = global::GalaBuilding.Properties.Resources.nguoidung;
            this.tSMNguoiDung.Name = "tSMNguoiDung";
            this.tSMNguoiDung.Size = new System.Drawing.Size(164, 22);
            this.tSMNguoiDung.Text = "Người Dùng";
            this.tSMNguoiDung.Click += new System.EventHandler(this.tSMNguoiDung_Click);
            // 
            // tSMQuanLy
            // 
            this.tSMQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMNguoiDan,
            this.tSMNhanVien,
            this.tSMDichVu,
            this.tSMDangKyDichVu,
            this.tSMChucVu});
            this.tSMQuanLy.Name = "tSMQuanLy";
            this.tSMQuanLy.Size = new System.Drawing.Size(63, 20);
            this.tSMQuanLy.Text = "Quản Lý";
            this.tSMQuanLy.Click += new System.EventHandler(this.toolStripMenuItem46_Click);
            // 
            // tSMNguoiDan
            // 
            this.tSMNguoiDan.Image = global::GalaBuilding.Properties.Resources.NguoiDan;
            this.tSMNguoiDan.Name = "tSMNguoiDan";
            this.tSMNguoiDan.Size = new System.Drawing.Size(162, 22);
            this.tSMNguoiDan.Text = "Người Dân";
            this.tSMNguoiDan.Click += new System.EventHandler(this.tSMNguoiDan_Click);
            // 
            // tSMNhanVien
            // 
            this.tSMNhanVien.Image = global::GalaBuilding.Properties.Resources.NhanVien;
            this.tSMNhanVien.Name = "tSMNhanVien";
            this.tSMNhanVien.Size = new System.Drawing.Size(162, 22);
            this.tSMNhanVien.Text = "Nhân Viên";
            this.tSMNhanVien.Click += new System.EventHandler(this.tSMNhanVien_Click);
            // 
            // tSMDichVu
            // 
            this.tSMDichVu.Image = global::GalaBuilding.Properties.Resources.DichVu;
            this.tSMDichVu.Name = "tSMDichVu";
            this.tSMDichVu.Size = new System.Drawing.Size(162, 22);
            this.tSMDichVu.Text = "Dịch Vụ";
            this.tSMDichVu.Click += new System.EventHandler(this.tSMDichVu_Click);
            // 
            // tSMDangKyDichVu
            // 
            this.tSMDangKyDichVu.Image = global::GalaBuilding.Properties.Resources.DangKyDichVu;
            this.tSMDangKyDichVu.Name = "tSMDangKyDichVu";
            this.tSMDangKyDichVu.Size = new System.Drawing.Size(162, 22);
            this.tSMDangKyDichVu.Text = "Đăng Ký Dịch Vụ";
            this.tSMDangKyDichVu.Click += new System.EventHandler(this.tSMDangKyDichVu_Click);
            // 
            // tSMChucVu
            // 
            this.tSMChucVu.Image = global::GalaBuilding.Properties.Resources.nghenghiep;
            this.tSMChucVu.Name = "tSMChucVu";
            this.tSMChucVu.Size = new System.Drawing.Size(162, 22);
            this.tSMChucVu.Text = "Chức Vụ";
            this.tSMChucVu.Click += new System.EventHandler(this.tSMChucVu_Click);
            // 
            // tSMTraCuu
            // 
            this.tSMTraCuu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMTraCuuNguoiDan,
            this.tSMTraCuuNhanVien});
            this.tSMTraCuu.Name = "tSMTraCuu";
            this.tSMTraCuu.Size = new System.Drawing.Size(64, 20);
            this.tSMTraCuu.Text = "Tra Cứu ";
            // 
            // tSMTraCuuNguoiDan
            // 
            this.tSMTraCuuNguoiDan.Image = global::GalaBuilding.Properties.Resources.TCGV;
            this.tSMTraCuuNguoiDan.Name = "tSMTraCuuNguoiDan";
            this.tSMTraCuuNguoiDan.Size = new System.Drawing.Size(176, 22);
            this.tSMTraCuuNguoiDan.Text = "Tra Cứu Người Dân";
            this.tSMTraCuuNguoiDan.Click += new System.EventHandler(this.tSMTraCuuNguoiDan_Click);
            // 
            // tSMTraCuuNhanVien
            // 
            this.tSMTraCuuNhanVien.Image = global::GalaBuilding.Properties.Resources.TCHS;
            this.tSMTraCuuNhanVien.Name = "tSMTraCuuNhanVien";
            this.tSMTraCuuNhanVien.Size = new System.Drawing.Size(176, 22);
            this.tSMTraCuuNhanVien.Text = "Tra Cứu Nhân Viên";
            this.tSMTraCuuNhanVien.Click += new System.EventHandler(this.tSMTraCuuNhanVien_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // dânTộcToolStripMenuItem
            // 
            this.dânTộcToolStripMenuItem.Image = global::GalaBuilding.Properties.Resources.dantoc1;
            this.dânTộcToolStripMenuItem.Name = "dânTộcToolStripMenuItem";
            this.dânTộcToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dânTộcToolStripMenuItem.Text = "Dân Tộc";
            // 
            // tônGiáoToolStripMenuItem
            // 
            this.tônGiáoToolStripMenuItem.Image = global::GalaBuilding.Properties.Resources.tongiao;
            this.tônGiáoToolStripMenuItem.Name = "tônGiáoToolStripMenuItem";
            this.tônGiáoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tônGiáoToolStripMenuItem.Text = "Tôn Giáo";
            // 
            // nghềNghiệpToolStripMenuItem
            // 
            this.nghềNghiệpToolStripMenuItem.Image = global::GalaBuilding.Properties.Resources.nghenghiep;
            this.nghềNghiệpToolStripMenuItem.Name = "nghềNghiệpToolStripMenuItem";
            this.nghềNghiệpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nghềNghiệpToolStripMenuItem.Text = "Nghề Nghiệp";
            // 
            // traCứuToolStripMenuItem
            // 
            this.traCứuToolStripMenuItem.Name = "traCứuToolStripMenuItem";
            this.traCứuToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.traCứuToolStripMenuItem.Text = "Tra Cứu ";
            // 
            // quyĐịnhToolStripMenuItem
            // 
            this.quyĐịnhToolStripMenuItem.Name = "quyĐịnhToolStripMenuItem";
            this.quyĐịnhToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.quyĐịnhToolStripMenuItem.Text = "Quy Định";
            // 
            // giúpĐỡToolStripMenuItem
            // 
            this.giúpĐỡToolStripMenuItem.Name = "giúpĐỡToolStripMenuItem";
            this.giúpĐỡToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.giúpĐỡToolStripMenuItem.Text = "Giúp Đỡ";
            // 
            // thôngTinPhầnMềmToolStripMenuItem
            // 
            this.thôngTinPhầnMềmToolStripMenuItem.Image = global::GalaBuilding.Properties.Resources.TTPM;
            this.thôngTinPhầnMềmToolStripMenuItem.Name = "thôngTinPhầnMềmToolStripMenuItem";
            this.thôngTinPhầnMềmToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.thôngTinPhầnMềmToolStripMenuItem.Text = "Thông tin phần mềm";
            // 
            // hiểnThịToolStripMenuItem
            // 
            this.hiểnThịToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thanhtacvu,
            this.thanhCôngCụToolStripMenuItem,
            this.toolStripSeparator4,
            this.cửaSổNgangToolStripMenuItem,
            this.cửaSổDọcToolStripMenuItem,
            this.cửaSổBìnhThườngToolStripMenuItem});
            this.hiểnThịToolStripMenuItem.Name = "hiểnThịToolStripMenuItem";
            this.hiểnThịToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.hiểnThịToolStripMenuItem.Text = "Hiển Thị";
            // 
            // thanhtacvu
            // 
            this.thanhtacvu.Checked = true;
            this.thanhtacvu.CheckOnClick = true;
            this.thanhtacvu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.thanhtacvu.Name = "thanhtacvu";
            this.thanhtacvu.Size = new System.Drawing.Size(183, 22);
            this.thanhtacvu.Text = "Thanh tác vụ";
            // 
            // thanhCôngCụToolStripMenuItem
            // 
            this.thanhCôngCụToolStripMenuItem.Checked = true;
            this.thanhCôngCụToolStripMenuItem.CheckOnClick = true;
            this.thanhCôngCụToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.thanhCôngCụToolStripMenuItem.Name = "thanhCôngCụToolStripMenuItem";
            this.thanhCôngCụToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.thanhCôngCụToolStripMenuItem.Text = "Thanh công cụ";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(180, 6);
            // 
            // cửaSổNgangToolStripMenuItem
            // 
            this.cửaSổNgangToolStripMenuItem.Name = "cửaSổNgangToolStripMenuItem";
            this.cửaSổNgangToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cửaSổNgangToolStripMenuItem.Text = "Cửa Sổ Ngang";
            this.cửaSổNgangToolStripMenuItem.Click += new System.EventHandler(this.cửaSổNgangToolStripMenuItem_Click);
            // 
            // cửaSổDọcToolStripMenuItem
            // 
            this.cửaSổDọcToolStripMenuItem.Name = "cửaSổDọcToolStripMenuItem";
            this.cửaSổDọcToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cửaSổDọcToolStripMenuItem.Text = "Cửa Sổ Dọc";
            this.cửaSổDọcToolStripMenuItem.Click += new System.EventHandler(this.cửaSổDọcToolStripMenuItem_Click);
            // 
            // cửaSổBìnhThườngToolStripMenuItem
            // 
            this.cửaSổBìnhThườngToolStripMenuItem.Name = "cửaSổBìnhThườngToolStripMenuItem";
            this.cửaSổBìnhThườngToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cửaSổBìnhThườngToolStripMenuItem.Text = "Cửa Sổ Bình Thường";
            this.cửaSổBìnhThườngToolStripMenuItem.Click += new System.EventHandler(this.cửaSổBìnhThườngToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 55);
            // 
            // btnTTTruong
            // 
            this.btnTTTruong.Name = "btnTTTruong";
            this.btnTTTruong.Size = new System.Drawing.Size(23, 23);
            // 
            // btnTTPM
            // 
            this.btnTTPM.Name = "btnTTPM";
            this.btnTTPM.Size = new System.Drawing.Size(23, 23);
            // 
            // panelTacvu
            // 
            this.panelTacvu.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelTacvu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.panelTacvu.Controls.Add(this.expelTracuu);
            this.panelTacvu.Controls.Add(this.expelquanly);
            this.panelTacvu.Controls.Add(this.expanelHethong);
            this.panelTacvu.Location = new System.Drawing.Point(1053, 53);
            this.panelTacvu.Name = "panelTacvu";
            this.panelTacvu.Size = new System.Drawing.Size(226, 667);
            this.panelTacvu.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelTacvu.Style.BackColor1.Color = System.Drawing.Color.Azure;
            this.panelTacvu.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panelTacvu.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelTacvu.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panelTacvu.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelTacvu.Style.GradientAngle = 90;
            this.panelTacvu.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
            this.panelTacvu.StyleMouseDown.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panelTacvu.StyleMouseDown.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panelTacvu.StyleMouseDown.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panelTacvu.StyleMouseDown.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panelTacvu.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
            this.panelTacvu.StyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panelTacvu.StyleMouseOver.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panelTacvu.StyleMouseOver.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panelTacvu.StyleMouseOver.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText;
            this.panelTacvu.TabIndex = 23;
            // 
            // expelTracuu
            // 
            this.expelTracuu.CanvasColor = System.Drawing.SystemColors.Control;
            this.expelTracuu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.expelTracuu.Controls.Add(this.cmdTraCuuNhanVien);
            this.expelTracuu.Controls.Add(this.cmdTraCuuNguoiDan);
            this.expelTracuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expelTracuu.Location = new System.Drawing.Point(12, 371);
            this.expelTracuu.Name = "expelTracuu";
            this.expelTracuu.Size = new System.Drawing.Size(192, 108);
            this.expelTracuu.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expelTracuu.Style.BackColor1.Color = System.Drawing.Color.White;
            this.expelTracuu.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption;
            this.expelTracuu.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expelTracuu.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expelTracuu.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expelTracuu.Style.GradientAngle = 90;
            this.expelTracuu.TabIndex = 2;
            this.expelTracuu.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expelTracuu.TitleStyle.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.expelTracuu.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expelTracuu.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expelTracuu.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expelTracuu.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expelTracuu.TitleStyle.GradientAngle = 90;
            this.expelTracuu.TitleText = "Tra Cứu";
            // 
            // cmdTraCuuNhanVien
            // 
            this.cmdTraCuuNhanVien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdTraCuuNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdTraCuuNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdTraCuuNhanVien.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.cmdTraCuuNhanVien.Location = new System.Drawing.Point(24, 69);
            this.cmdTraCuuNhanVien.Name = "cmdTraCuuNhanVien";
            this.cmdTraCuuNhanVien.Size = new System.Drawing.Size(144, 30);
            this.cmdTraCuuNhanVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.cmdTraCuuNhanVien.TabIndex = 13;
            this.cmdTraCuuNhanVien.Text = "Nhân Viên";
            this.cmdTraCuuNhanVien.Tooltip = "Tra cứu Nhân Viên";
            this.cmdTraCuuNhanVien.Click += new System.EventHandler(this.cmdTraCuuNhanVien_Click);
            // 
            // cmdTraCuuNguoiDan
            // 
            this.cmdTraCuuNguoiDan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdTraCuuNguoiDan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdTraCuuNguoiDan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdTraCuuNguoiDan.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.cmdTraCuuNguoiDan.Location = new System.Drawing.Point(24, 33);
            this.cmdTraCuuNguoiDan.Name = "cmdTraCuuNguoiDan";
            this.cmdTraCuuNguoiDan.Size = new System.Drawing.Size(144, 30);
            this.cmdTraCuuNguoiDan.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.cmdTraCuuNguoiDan.TabIndex = 12;
            this.cmdTraCuuNguoiDan.Text = "Người Dân";
            this.cmdTraCuuNguoiDan.Tooltip = "Tra Cứu Người Dân";
            this.cmdTraCuuNguoiDan.Click += new System.EventHandler(this.cmdTraCuuNguoiDan_Click);
            // 
            // expelquanly
            // 
            this.expelquanly.CanvasColor = System.Drawing.SystemColors.Control;
            this.expelquanly.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.expelquanly.Controls.Add(this.cmdQuanLyNguoiDan);
            this.expelquanly.Controls.Add(this.cmdQuanLyDichVu);
            this.expelquanly.Controls.Add(this.cmdQuanLyNhanVien);
            this.expelquanly.Controls.Add(this.cmdDangKyDichVu);
            this.expelquanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expelquanly.Location = new System.Drawing.Point(12, 175);
            this.expelquanly.Name = "expelquanly";
            this.expelquanly.Size = new System.Drawing.Size(192, 190);
            this.expelquanly.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expelquanly.Style.BackColor1.Color = System.Drawing.Color.White;
            this.expelquanly.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption;
            this.expelquanly.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expelquanly.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expelquanly.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expelquanly.Style.GradientAngle = 90;
            this.expelquanly.TabIndex = 1;
            this.expelquanly.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expelquanly.TitleStyle.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.expelquanly.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expelquanly.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expelquanly.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expelquanly.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expelquanly.TitleStyle.GradientAngle = 90;
            this.expelquanly.TitleText = "Quản Lý";
            // 
            // cmdQuanLyNguoiDan
            // 
            this.cmdQuanLyNguoiDan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdQuanLyNguoiDan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdQuanLyNguoiDan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdQuanLyNguoiDan.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.cmdQuanLyNguoiDan.Location = new System.Drawing.Point(24, 37);
            this.cmdQuanLyNguoiDan.Name = "cmdQuanLyNguoiDan";
            this.cmdQuanLyNguoiDan.Size = new System.Drawing.Size(144, 30);
            this.cmdQuanLyNguoiDan.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.cmdQuanLyNguoiDan.TabIndex = 8;
            this.cmdQuanLyNguoiDan.Text = "Quản Lý Người Dân";
            this.cmdQuanLyNguoiDan.Tooltip = "Quản Lý Người Dân";
            this.cmdQuanLyNguoiDan.Click += new System.EventHandler(this.cmdQuanLyNguoiDan_Click);
            // 
            // cmdQuanLyDichVu
            // 
            this.cmdQuanLyDichVu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdQuanLyDichVu.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.cmdQuanLyDichVu.Location = new System.Drawing.Point(24, 109);
            this.cmdQuanLyDichVu.Name = "cmdQuanLyDichVu";
            this.cmdQuanLyDichVu.Size = new System.Drawing.Size(144, 30);
            this.cmdQuanLyDichVu.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.cmdQuanLyDichVu.TabIndex = 4;
            this.cmdQuanLyDichVu.Text = "Quản Lý Dịch Vụ";
            this.cmdQuanLyDichVu.Tooltip = "Quản Lý Dịch Vụ";
            this.cmdQuanLyDichVu.Click += new System.EventHandler(this.cmdQuanLyDichVu_Click);
            // 
            // cmdQuanLyNhanVien
            // 
            this.cmdQuanLyNhanVien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdQuanLyNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdQuanLyNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdQuanLyNhanVien.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.cmdQuanLyNhanVien.Location = new System.Drawing.Point(24, 73);
            this.cmdQuanLyNhanVien.Name = "cmdQuanLyNhanVien";
            this.cmdQuanLyNhanVien.Size = new System.Drawing.Size(144, 30);
            this.cmdQuanLyNhanVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.cmdQuanLyNhanVien.TabIndex = 9;
            this.cmdQuanLyNhanVien.Text = "Quản Lý Nhân Viên";
            this.cmdQuanLyNhanVien.Tooltip = "Quản Lý Nhân Viên";
            this.cmdQuanLyNhanVien.Click += new System.EventHandler(this.cmdQuanLyNhanVien_Click);
            // 
            // cmdDangKyDichVu
            // 
            this.cmdDangKyDichVu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdDangKyDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDangKyDichVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdDangKyDichVu.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.cmdDangKyDichVu.Location = new System.Drawing.Point(24, 145);
            this.cmdDangKyDichVu.Name = "cmdDangKyDichVu";
            this.cmdDangKyDichVu.Size = new System.Drawing.Size(144, 30);
            this.cmdDangKyDichVu.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.cmdDangKyDichVu.TabIndex = 13;
            this.cmdDangKyDichVu.Text = "Đăng Ký Dịch Vụ";
            this.cmdDangKyDichVu.Tooltip = "Tra Cứu Căn Hộ & Đăng Ký Dịch Vụ";
            this.cmdDangKyDichVu.Click += new System.EventHandler(this.cmdDangKyDichVu_Click);
            // 
            // expanelHethong
            // 
            this.expanelHethong.CanvasColor = System.Drawing.SystemColors.Control;
            this.expanelHethong.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.expanelHethong.Controls.Add(this.buttonthoat);
            this.expanelHethong.Controls.Add(this.buttondangnhap);
            this.expanelHethong.Controls.Add(this.buttondangxuat);
            this.expanelHethong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expanelHethong.Location = new System.Drawing.Point(12, 15);
            this.expanelHethong.Name = "expanelHethong";
            this.expanelHethong.Size = new System.Drawing.Size(194, 154);
            this.expanelHethong.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expanelHethong.Style.BackColor1.Color = System.Drawing.Color.White;
            this.expanelHethong.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption;
            this.expanelHethong.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expanelHethong.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expanelHethong.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expanelHethong.Style.GradientAngle = 90;
            this.expanelHethong.TabIndex = 0;
            this.expanelHethong.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expanelHethong.TitleStyle.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.expanelHethong.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expanelHethong.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expanelHethong.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expanelHethong.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expanelHethong.TitleStyle.GradientAngle = 90;
            this.expanelHethong.TitleText = "Hệ Thống";
            // 
            // buttonthoat
            // 
            this.buttonthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonthoat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonthoat.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonthoat.Image = global::GalaBuilding.Properties.Resources.exit;
            this.buttonthoat.Location = new System.Drawing.Point(24, 111);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(144, 28);
            this.buttonthoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.buttonthoat.TabIndex = 3;
            this.buttonthoat.Text = "Thoát";
            this.buttonthoat.Tooltip = "Thoát";
            this.buttonthoat.Click += new System.EventHandler(this.buttonthoat_Click);
            // 
            // buttondangnhap
            // 
            this.buttondangnhap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttondangnhap.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttondangnhap.Image = global::GalaBuilding.Properties.Resources.dangnhapcontext;
            this.buttondangnhap.Location = new System.Drawing.Point(24, 39);
            this.buttondangnhap.Name = "buttondangnhap";
            this.buttondangnhap.Size = new System.Drawing.Size(144, 30);
            this.buttondangnhap.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.buttondangnhap.TabIndex = 2;
            this.buttondangnhap.Text = "Đăng Nhập";
            this.buttondangnhap.Tooltip = "Đăng Xuất";
            this.buttondangnhap.Click += new System.EventHandler(this.buttondangnhap_Click);
            // 
            // buttondangxuat
            // 
            this.buttondangxuat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttondangxuat.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttondangxuat.Image = global::GalaBuilding.Properties.Resources.dangxuatcontext;
            this.buttondangxuat.Location = new System.Drawing.Point(24, 75);
            this.buttondangxuat.Name = "buttondangxuat";
            this.buttondangxuat.Size = new System.Drawing.Size(144, 30);
            this.buttondangxuat.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.buttondangxuat.TabIndex = 1;
            this.buttondangxuat.Text = "Đăng Xuất";
            this.buttondangxuat.Tooltip = "Đăng Xuất";
            this.buttondangxuat.Click += new System.EventHandler(this.buttondangxuat_Click);
            // 
            // backupDialog
            // 
            this.backupDialog.DefaultExt = "*.BAK";
            this.backupDialog.FileName = "GalaBuilding_.BAK";
            this.backupDialog.Filter = "Backup files (*.BAK)|*.BAK";
            this.backupDialog.FilterIndex = 2;
            this.backupDialog.Title = "Sao Lưu Dữ Liệu";
            // 
            // restoreDialog
            // 
            this.restoreDialog.DefaultExt = "*.BAK";
            this.restoreDialog.FileName = "GalaBuilding_.BAK";
            this.restoreDialog.Filter = "Backup files (*.BAK)|*.BAK";
            this.restoreDialog.FilterIndex = 2;
            this.restoreDialog.Title = "PHỤC HỒI DỮ LIỆU";
            // 
            // office2007StartButton3
            // 
            this.office2007StartButton3.AutoExpandOnClick = true;
            this.office2007StartButton3.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.office2007StartButton3.ImagePaddingHorizontal = 2;
            this.office2007StartButton3.ImagePaddingVertical = 2;
            this.office2007StartButton3.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed;
            this.office2007StartButton3.Name = "office2007StartButton3";
            this.office2007StartButton3.ShowSubItems = false;
            this.office2007StartButton3.StopPulseOnMouseOver = false;
            this.office2007StartButton3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer8});
            this.office2007StartButton3.Text = "Start";
            this.office2007StartButton3.Tooltip = "Start";
            // 
            // itemContainer8
            // 
            // 
            // 
            // 
            this.itemContainer8.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.itemContainer8.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer8.Name = "itemContainer8";
            this.itemContainer8.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer12});
            // 
            // itemContainer12
            // 
            // 
            // 
            // 
            this.itemContainer12.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
            this.itemContainer12.ItemSpacing = 0;
            this.itemContainer12.Name = "itemContainer12";
            this.itemContainer12.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer13});
            // 
            // itemContainer13
            // 
            // 
            // 
            // 
            this.itemContainer13.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.itemContainer13.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer13.MinimumSize = new System.Drawing.Size(120, 0);
            this.itemContainer13.Name = "itemContainer13";
            this.itemContainer13.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.buttonItem21,
            this.buttonItem22,
            this.buttonItem23,
            this.buttonItem24,
            this.buttonItem25,
            this.buttonItem26});
            // 
            // buttonItem1
            // 
            this.buttonItem1.BeginGroup = true;
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.ImagePaddingHorizontal = 8;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.PopupWidth = 100;
            this.buttonItem1.Text = "Đăng Nhập";
            this.buttonItem1.Tooltip = "Đăng nhập";
            // 
            // buttonItem21
            // 
            this.buttonItem21.AutoCheckOnClick = true;
            this.buttonItem21.BeginGroup = true;
            this.buttonItem21.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem21.ImagePaddingHorizontal = 8;
            this.buttonItem21.Name = "buttonItem21";
            this.buttonItem21.SubItemsExpandWidth = 24;
            this.buttonItem21.Text = "Đăng Xuất";
            this.buttonItem21.Tooltip = "Đăng Xuất";
            // 
            // buttonItem22
            // 
            this.buttonItem22.BeginGroup = true;
            this.buttonItem22.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem22.ImagePaddingHorizontal = 8;
            this.buttonItem22.Name = "buttonItem22";
            this.buttonItem22.SubItemsExpandWidth = 24;
            this.buttonItem22.Text = "Đổi mật khẩu";
            this.buttonItem22.Tooltip = "Đổi mật khẩu";
            // 
            // buttonItem23
            // 
            this.buttonItem23.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem23.ImagePaddingHorizontal = 8;
            this.buttonItem23.Name = "buttonItem23";
            this.buttonItem23.Text = "Quản lý người dùng";
            this.buttonItem23.Tooltip = "Quản lý người dùng";
            // 
            // buttonItem24
            // 
            this.buttonItem24.BeginGroup = true;
            this.buttonItem24.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem24.ImagePaddingHorizontal = 8;
            this.buttonItem24.Name = "buttonItem24";
            this.buttonItem24.SubItemsExpandWidth = 24;
            this.buttonItem24.Text = "Sao lưu dữ liệu";
            this.buttonItem24.Tooltip = "Sao lưu dữ liệu";
            // 
            // buttonItem25
            // 
            this.buttonItem25.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem25.ImagePaddingHorizontal = 8;
            this.buttonItem25.Name = "buttonItem25";
            this.buttonItem25.SubItemsExpandWidth = 24;
            this.buttonItem25.Text = "Phục hồi dữ liệu";
            this.buttonItem25.Tooltip = "Phục hồi dữ liệu";
            // 
            // buttonItem26
            // 
            this.buttonItem26.BeginGroup = true;
            this.buttonItem26.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem26.ImagePaddingHorizontal = 8;
            this.buttonItem26.Name = "buttonItem26";
            this.buttonItem26.SubItemsExpandWidth = 24;
            this.buttonItem26.Text = "Thoát";
            this.buttonItem26.Tooltip = "Thoát";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::GalaBuilding.Properties.Resources.Class3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 721);
            this.Controls.Add(this.panelTacvu);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ CHUNG CƯ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTacvu.ResumeLayout(false);
            this.expelTracuu.ResumeLayout(false);
            this.expelquanly.ResumeLayout(false);
            this.expanelHethong.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Office2007StartButton office2007StartButton2;
        private DevComponents.DotNetBar.ItemContainer itemContainer5;
        private DevComponents.DotNetBar.ItemContainer itemContainer6;
        private DevComponents.DotNetBar.ItemContainer itemContainer7;
        private DevComponents.DotNetBar.ButtonItem buttonItem15;
        private DevComponents.DotNetBar.ButtonItem buttonItem16;
        private DevComponents.DotNetBar.ButtonItem buttonItem17;
        private DevComponents.DotNetBar.ButtonItem buttonItem18;
        private DevComponents.DotNetBar.ButtonItem buttonItem19;
        private DevComponents.DotNetBar.ButtonItem buttonItem20;
        private DevComponents.DotNetBar.ButtonItem buttonItem14;
        private DevComponents.DotNetBar.GalleryContainer galleryContainer2;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.GalleryContainer galleryContainer3;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private DevComponents.DotNetBar.ButtonItem buttonItem5;
        private DevComponents.DotNetBar.ButtonItem buttonItem6;
        private DevComponents.DotNetBar.ButtonItem buttonItem7;
        private DevComponents.DotNetBar.GalleryContainer galleryContainer1;
        private DevComponents.DotNetBar.LabelItem labelItem8;
        private DevComponents.DotNetBar.ButtonItem buttonItem8;
        private DevComponents.DotNetBar.ButtonItem buttonItem9;
        private DevComponents.DotNetBar.ButtonItem buttonItem10;
        private DevComponents.DotNetBar.ButtonItem buttonItem11;
        private DevComponents.DotNetBar.ItemContainer itemContainer4;
        private DevComponents.DotNetBar.ButtonItem buttonItem12;
        private DevComponents.DotNetBar.ButtonItem buttonItem13;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabGiupdo;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabQuydinh;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabTracuu;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabThongKe;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabQuanLy;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.Office2007StartButton office2007StartButton1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.ButtonItem btnDangnhap;
        private DevComponents.DotNetBar.ButtonItem btnDangxuat;
        private DevComponents.DotNetBar.ButtonItem btnDoimatkhau;
        private DevComponents.DotNetBar.ButtonItem btnQlyND;
        private DevComponents.DotNetBar.ButtonItem btnSaoluudl;
        private DevComponents.DotNetBar.ButtonItem btnPhuchoidl;
        private DevComponents.DotNetBar.ButtonItem btnThoat;
        private DevComponents.DotNetBar.Office2007StartButton office2007StartButton5;
        private DevComponents.DotNetBar.ItemContainer itemContainer17;
        private DevComponents.DotNetBar.ItemContainer itemContainer18;
        private DevComponents.DotNetBar.ItemContainer itemContainer19;
        private DevComponents.DotNetBar.ButtonItem buttonItem34;
        private DevComponents.DotNetBar.ButtonItem buttonItem35;
        private DevComponents.DotNetBar.ButtonItem buttonItem36;
        private DevComponents.DotNetBar.ButtonItem buttonItem37;
        private DevComponents.DotNetBar.ButtonItem buttonItem38;
        private DevComponents.DotNetBar.ButtonItem buttonItem39;
        private DevComponents.DotNetBar.ButtonItem buttonItem40;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabQuanLy1;
        private DevComponents.DotNetBar.GalleryContainer galleryContainer4;
        private DevComponents.DotNetBar.LabelItem labelItem3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem traCứuToolStripMenuItem;
        private ToolStripMenuItem quyĐịnhToolStripMenuItem;
        private ToolStripMenuItem giúpĐỡToolStripMenuItem;
        private ToolStripMenuItem dânTộcToolStripMenuItem;
        private ToolStripMenuItem tônGiáoToolStripMenuItem;
        private ToolStripMenuItem nghềNghiệpToolStripMenuItem;
        private ToolStripMenuItem thôngTinPhầnMềmToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem hiểnThịToolStripMenuItem;
        private ToolStripMenuItem thanhtacvu;
        private ToolStripMenuItem thanhCôngCụToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem cửaSổNgangToolStripMenuItem;
        private ToolStripMenuItem cửaSổDọcToolStripMenuItem;
        private ToolStripMenuItem cửaSổBìnhThườngToolStripMenuItem;
        private DevComponents.DotNetBar.PanelEx panelTacvu;
        private DevComponents.DotNetBar.ExpandablePanel expanelHethong;
        private DevComponents.DotNetBar.ExpandablePanel expelquanly;
        private DevComponents.DotNetBar.ButtonX buttondangxuat;
        private DevComponents.DotNetBar.ButtonX buttonthoat;
        private DevComponents.DotNetBar.ButtonX buttondangnhap;
        private DevComponents.DotNetBar.ButtonX cmdQuanLyDichVu;
        private DevComponents.DotNetBar.ButtonX cmdQuanLyNhanVien;
        private DevComponents.DotNetBar.ButtonX cmdQuanLyNguoiDan;
        private DevComponents.DotNetBar.ExpandablePanel expelTracuu;
        private DevComponents.DotNetBar.ButtonX cmdDangKyDichVu;
        private DevComponents.DotNetBar.ButtonX cmdTraCuuNguoiDan;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton btnTTTruong;
        private ToolStripButton btnTTPM;
        private SaveFileDialog backupDialog;
        private OpenFileDialog restoreDialog;
        private DevComponents.DotNetBar.Office2007StartButton office2007StartButton3;
        private DevComponents.DotNetBar.ItemContainer itemContainer8;
        private DevComponents.DotNetBar.ItemContainer itemContainer12;
        private DevComponents.DotNetBar.ItemContainer itemContainer13;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem21;
        private DevComponents.DotNetBar.ButtonItem buttonItem22;
        private DevComponents.DotNetBar.ButtonItem buttonItem23;
        private DevComponents.DotNetBar.ButtonItem buttonItem24;
        private DevComponents.DotNetBar.ButtonItem buttonItem25;
        private DevComponents.DotNetBar.ButtonItem buttonItem26;
        private ToolStripMenuItem tSMQuanLy;
        private ToolStripMenuItem tSMNguoiDan;
        private ToolStripMenuItem tSMDichVu;
        private ToolStripMenuItem tSMDangKyDichVu;
        private ToolStripMenuItem tSMChucVu;
        private ToolStripMenuItem tSMTraCuu;
        private ToolStripMenuItem tSMTraCuuNguoiDan;
        private ToolStripMenuItem tSMTraCuuNhanVien;
        private ToolStripMenuItem tSMNhanVien;
        private DevComponents.DotNetBar.ButtonX cmdTraCuuNhanVien;
        private ToolStripMenuItem tSMQuanTri;
        private ToolStripMenuItem tSMLoaiNguoiDung;
        private ToolStripMenuItem tSMNguoiDung;
    }
}