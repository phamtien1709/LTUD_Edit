namespace GalaBuilding
{
    partial class frmDangKyDichVu
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKyDichVu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nvgPanelGiaoVien = new DevComponents.DotNetBar.NavigationPane();
            this.ngvPanelTimKiem = new DevComponents.DotNetBar.NavigationPanePanel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblhoten = new DevComponents.DotNetBar.LabelX();
            this.cmdTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.cmbTheoDichVu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.txtMaCanHo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbMaDichVu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblNguoiDan = new DevComponents.DotNetBar.LabelX();
            this.txtTenNguoiDan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbTheoTenNguoiDan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.col1 = new DevComponents.Editors.ComboItem();
            this.col2 = new DevComponents.Editors.ComboItem();
            this.col3 = new DevComponents.Editors.ComboItem();
            this.lblDichVu = new DevComponents.DotNetBar.LabelX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmdDangKy = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cmbMaCanHoDK = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbMaDichVuDK = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnTimKiemCH = new DevComponents.DotNetBar.ButtonItem();
            this.groupBoxDsgv = new System.Windows.Forms.GroupBox();
            this.dgvTCCanHo = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaCanHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TangLau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNguoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongPhiDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgTCCanHo = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bngthoat = new System.Windows.Forms.ToolStripButton();
            this.nvgPanelGiaoVien.SuspendLayout();
            this.ngvPanelTimKiem.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupBoxDsgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTCCanHo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgTCCanHo)).BeginInit();
            this.bdgTCCanHo.SuspendLayout();
            this.SuspendLayout();
            // 
            // nvgPanelGiaoVien
            // 
            this.nvgPanelGiaoVien.CanCollapse = true;
            this.nvgPanelGiaoVien.Controls.Add(this.ngvPanelTimKiem);
            this.nvgPanelGiaoVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.nvgPanelGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvgPanelGiaoVien.ItemPaddingBottom = 2;
            this.nvgPanelGiaoVien.ItemPaddingTop = 2;
            this.nvgPanelGiaoVien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnTimKiemCH});
            this.nvgPanelGiaoVien.Location = new System.Drawing.Point(0, 0);
            this.nvgPanelGiaoVien.Name = "nvgPanelGiaoVien";
            this.nvgPanelGiaoVien.Padding = new System.Windows.Forms.Padding(1);
            this.nvgPanelGiaoVien.Size = new System.Drawing.Size(192, 494);
            this.nvgPanelGiaoVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.nvgPanelGiaoVien.TabIndex = 5;
            // 
            // 
            // 
            this.nvgPanelGiaoVien.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.nvgPanelGiaoVien.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nvgPanelGiaoVien.TitlePanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvgPanelGiaoVien.TitlePanel.Location = new System.Drawing.Point(1, 1);
            this.nvgPanelGiaoVien.TitlePanel.Name = "panelTitle";
            this.nvgPanelGiaoVien.TitlePanel.Size = new System.Drawing.Size(190, 24);
            this.nvgPanelGiaoVien.TitlePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.nvgPanelGiaoVien.TitlePanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.nvgPanelGiaoVien.TitlePanel.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.nvgPanelGiaoVien.TitlePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.nvgPanelGiaoVien.TitlePanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.nvgPanelGiaoVien.TitlePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.nvgPanelGiaoVien.TitlePanel.Style.GradientAngle = 90;
            this.nvgPanelGiaoVien.TitlePanel.Style.MarginLeft = 4;
            this.nvgPanelGiaoVien.TitlePanel.TabIndex = 0;
            // 
            // ngvPanelTimKiem
            // 
            this.ngvPanelTimKiem.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ngvPanelTimKiem.Controls.Add(this.groupPanel1);
            this.ngvPanelTimKiem.Controls.Add(this.groupPanel2);
            this.ngvPanelTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ngvPanelTimKiem.Location = new System.Drawing.Point(1, 25);
            this.ngvPanelTimKiem.Name = "ngvPanelTimKiem";
            this.ngvPanelTimKiem.ParentItem = this.btnTimKiemCH;
            this.ngvPanelTimKiem.Size = new System.Drawing.Size(190, 436);
            this.ngvPanelTimKiem.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.ngvPanelTimKiem.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.ngvPanelTimKiem.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.ngvPanelTimKiem.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.ngvPanelTimKiem.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.ngvPanelTimKiem.Style.GradientAngle = 90;
            this.ngvPanelTimKiem.TabIndex = 3;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.lblhoten);
            this.groupPanel1.Controls.Add(this.cmdTimKiem);
            this.groupPanel1.Controls.Add(this.cmbTheoDichVu);
            this.groupPanel1.Controls.Add(this.txtMaCanHo);
            this.groupPanel1.Controls.Add(this.cmbMaDichVu);
            this.groupPanel1.Controls.Add(this.lblNguoiDan);
            this.groupPanel1.Controls.Add(this.txtTenNguoiDan);
            this.groupPanel1.Controls.Add(this.cmbTheoTenNguoiDan);
            this.groupPanel1.Controls.Add(this.lblDichVu);
            this.groupPanel1.Location = new System.Drawing.Point(11, 5);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(172, 228);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 7;
            this.groupPanel1.Text = "Tra Cứu Căn Hộ";
            // 
            // lblhoten
            // 
            this.lblhoten.Location = new System.Drawing.Point(14, 6);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(66, 17);
            this.lblhoten.TabIndex = 0;
            this.lblhoten.Text = "Mã căn hộ";
            // 
            // cmdTimKiem
            // 
            this.cmdTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdTimKiem.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.cmdTimKiem.Location = new System.Drawing.Point(36, 168);
            this.cmdTimKiem.Name = "cmdTimKiem";
            this.cmdTimKiem.Size = new System.Drawing.Size(96, 31);
            this.cmdTimKiem.TabIndex = 4;
            this.cmdTimKiem.Text = "Tìm kiếm";
            this.cmdTimKiem.Click += new System.EventHandler(this.cmdTraCuu_Click);
            // 
            // cmbTheoDichVu
            // 
            this.cmbTheoDichVu.DisplayMember = "Text";
            this.cmbTheoDichVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTheoDichVu.FormattingEnabled = true;
            this.cmbTheoDichVu.ItemHeight = 15;
            this.cmbTheoDichVu.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3});
            this.cmbTheoDichVu.Location = new System.Drawing.Point(13, 111);
            this.cmbTheoDichVu.Name = "cmbTheoDichVu";
            this.cmbTheoDichVu.Size = new System.Drawing.Size(66, 21);
            this.cmbTheoDichVu.TabIndex = 11;
            this.cmbTheoDichVu.Text = "NONE";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "NONE";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "AND";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "OR";
            // 
            // txtMaCanHo
            // 
            // 
            // 
            // 
            this.txtMaCanHo.Border.Class = "TextBoxBorder";
            this.txtMaCanHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCanHo.Location = new System.Drawing.Point(13, 28);
            this.txtMaCanHo.Name = "txtMaCanHo";
            this.txtMaCanHo.Size = new System.Drawing.Size(136, 20);
            this.txtMaCanHo.TabIndex = 1;
            // 
            // cmbMaDichVu
            // 
            this.cmbMaDichVu.DisplayMember = "Text";
            this.cmbMaDichVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMaDichVu.FormattingEnabled = true;
            this.cmbMaDichVu.ItemHeight = 15;
            this.cmbMaDichVu.Location = new System.Drawing.Point(13, 141);
            this.cmbMaDichVu.Name = "cmbMaDichVu";
            this.cmbMaDichVu.Size = new System.Drawing.Size(138, 21);
            this.cmbMaDichVu.TabIndex = 10;
            // 
            // lblNguoiDan
            // 
            this.lblNguoiDan.Location = new System.Drawing.Point(85, 57);
            this.lblNguoiDan.Name = "lblNguoiDan";
            this.lblNguoiDan.Size = new System.Drawing.Size(80, 18);
            this.lblNguoiDan.TabIndex = 5;
            this.lblNguoiDan.Text = "Tên người dân";
            // 
            // txtTenNguoiDan
            // 
            // 
            // 
            // 
            this.txtTenNguoiDan.Border.Class = "TextBoxBorder";
            this.txtTenNguoiDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNguoiDan.Location = new System.Drawing.Point(13, 84);
            this.txtTenNguoiDan.Name = "txtTenNguoiDan";
            this.txtTenNguoiDan.Size = new System.Drawing.Size(136, 20);
            this.txtTenNguoiDan.TabIndex = 9;
            // 
            // cmbTheoTenNguoiDan
            // 
            this.cmbTheoTenNguoiDan.DisplayMember = "Text";
            this.cmbTheoTenNguoiDan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTheoTenNguoiDan.FormattingEnabled = true;
            this.cmbTheoTenNguoiDan.ItemHeight = 15;
            this.cmbTheoTenNguoiDan.Items.AddRange(new object[] {
            this.col1,
            this.col2,
            this.col3});
            this.cmbTheoTenNguoiDan.Location = new System.Drawing.Point(13, 54);
            this.cmbTheoTenNguoiDan.Name = "cmbTheoTenNguoiDan";
            this.cmbTheoTenNguoiDan.Size = new System.Drawing.Size(66, 21);
            this.cmbTheoTenNguoiDan.TabIndex = 6;
            this.cmbTheoTenNguoiDan.Text = "NONE";
            // 
            // col1
            // 
            this.col1.Text = "NONE";
            // 
            // col2
            // 
            this.col2.Text = "AND";
            // 
            // col3
            // 
            this.col3.Text = "OR";
            // 
            // lblDichVu
            // 
            this.lblDichVu.Location = new System.Drawing.Point(88, 112);
            this.lblDichVu.Name = "lblDichVu";
            this.lblDichVu.Size = new System.Drawing.Size(50, 21);
            this.lblDichVu.TabIndex = 7;
            this.lblDichVu.Text = "Dịch vụ";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Controls.Add(this.cmdDangKy);
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Controls.Add(this.cmbMaCanHoDK);
            this.groupPanel2.Controls.Add(this.cmbMaDichVuDK);
            this.groupPanel2.Location = new System.Drawing.Point(10, 245);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(173, 173);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 16;
            this.groupPanel2.Text = "Đăng ký Dịch Vụ";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(14, 6);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(137, 16);
            this.labelX2.TabIndex = 19;
            this.labelX2.Text = "Mã Căn Hộ ĐK Dịch Vụ";
            // 
            // cmdDangKy
            // 
            this.cmdDangKy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdDangKy.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.cmdDangKy.Location = new System.Drawing.Point(37, 111);
            this.cmdDangKy.Name = "cmdDangKy";
            this.cmdDangKy.Size = new System.Drawing.Size(96, 30);
            this.cmdDangKy.TabIndex = 12;
            this.cmdDangKy.Text = "Đăng ký";
            this.cmdDangKy.Click += new System.EventHandler(this.cmdDangKy_Click);
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(14, 55);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(137, 16);
            this.labelX1.TabIndex = 19;
            this.labelX1.Text = "Chọn dịch vụ muốn ĐK";
            // 
            // cmbMaCanHoDK
            // 
            this.cmbMaCanHoDK.DisplayMember = "Text";
            this.cmbMaCanHoDK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMaCanHoDK.Enabled = false;
            this.cmbMaCanHoDK.FormattingEnabled = true;
            this.cmbMaCanHoDK.ItemHeight = 15;
            this.cmbMaCanHoDK.Location = new System.Drawing.Point(13, 28);
            this.cmbMaCanHoDK.Name = "cmbMaCanHoDK";
            this.cmbMaCanHoDK.Size = new System.Drawing.Size(138, 21);
            this.cmbMaCanHoDK.TabIndex = 20;
            // 
            // cmbMaDichVuDK
            // 
            this.cmbMaDichVuDK.DisplayMember = "Text";
            this.cmbMaDichVuDK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMaDichVuDK.FormattingEnabled = true;
            this.cmbMaDichVuDK.ItemHeight = 15;
            this.cmbMaDichVuDK.Location = new System.Drawing.Point(14, 75);
            this.cmbMaDichVuDK.Name = "cmbMaDichVuDK";
            this.cmbMaDichVuDK.Size = new System.Drawing.Size(138, 21);
            this.cmbMaDichVuDK.TabIndex = 20;
            // 
            // btnTimKiemCH
            // 
            this.btnTimKiemCH.Checked = true;
            this.btnTimKiemCH.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnTimKiemCH.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemCH.Image")));
            this.btnTimKiemCH.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnTimKiemCH.ImagePaddingHorizontal = 8;
            this.btnTimKiemCH.Name = "btnTimKiemCH";
            this.btnTimKiemCH.OptionGroup = "navBar";
            // 
            // groupBoxDsgv
            // 
            this.groupBoxDsgv.Controls.Add(this.dgvTCCanHo);
            this.groupBoxDsgv.Controls.Add(this.bdgTCCanHo);
            this.groupBoxDsgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDsgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDsgv.Location = new System.Drawing.Point(192, 0);
            this.groupBoxDsgv.Name = "groupBoxDsgv";
            this.groupBoxDsgv.Size = new System.Drawing.Size(727, 494);
            this.groupBoxDsgv.TabIndex = 6;
            this.groupBoxDsgv.TabStop = false;
            this.groupBoxDsgv.Text = "Kết quả tìm kiếm";
            // 
            // dgvTCCanHo
            // 
            this.dgvTCCanHo.AllowUserToAddRows = false;
            this.dgvTCCanHo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvTCCanHo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTCCanHo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCanHo,
            this.TangLau,
            this.SoNguoi,
            this.TongPhiDichVu});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTCCanHo.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTCCanHo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTCCanHo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTCCanHo.Location = new System.Drawing.Point(3, 41);
            this.dgvTCCanHo.Name = "dgvTCCanHo";
            this.dgvTCCanHo.Size = new System.Drawing.Size(721, 450);
            this.dgvTCCanHo.TabIndex = 6;
            this.dgvTCCanHo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTCCanHo_CellClick);
            // 
            // MaCanHo
            // 
            this.MaCanHo.DataPropertyName = "MaCanHo";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaCanHo.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaCanHo.FillWeight = 90F;
            this.MaCanHo.HeaderText = "Mã căn hộ";
            this.MaCanHo.Name = "MaCanHo";
            this.MaCanHo.Width = 90;
            // 
            // TangLau
            // 
            this.TangLau.DataPropertyName = "TangLau";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TangLau.DefaultCellStyle = dataGridViewCellStyle2;
            this.TangLau.FillWeight = 80F;
            this.TangLau.HeaderText = "Tầng lầu";
            this.TangLau.Name = "TangLau";
            this.TangLau.Width = 80;
            // 
            // SoNguoi
            // 
            this.SoNguoi.DataPropertyName = "SoNguoi";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoNguoi.DefaultCellStyle = dataGridViewCellStyle3;
            this.SoNguoi.FillWeight = 80F;
            this.SoNguoi.HeaderText = "Số người ở";
            this.SoNguoi.Name = "SoNguoi";
            this.SoNguoi.Width = 80;
            // 
            // TongPhiDichVu
            // 
            this.TongPhiDichVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TongPhiDichVu.DataPropertyName = "TongPhiDichVu";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TongPhiDichVu.DefaultCellStyle = dataGridViewCellStyle4;
            this.TongPhiDichVu.FillWeight = 170F;
            this.TongPhiDichVu.HeaderText = "Tổng phí Dịch Vụ (VNĐ/tháng)";
            this.TongPhiDichVu.Name = "TongPhiDichVu";
            this.TongPhiDichVu.Width = 170;
            // 
            // bdgTCCanHo
            // 
            this.bdgTCCanHo.AddNewItem = null;
            this.bdgTCCanHo.CountItem = this.bindingNavigatorCountItem;
            this.bdgTCCanHo.CountItemFormat = "của {0}";
            this.bdgTCCanHo.DeleteItem = null;
            this.bdgTCCanHo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bngthoat});
            this.bdgTCCanHo.Location = new System.Drawing.Point(3, 16);
            this.bdgTCCanHo.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdgTCCanHo.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdgTCCanHo.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdgTCCanHo.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdgTCCanHo.Name = "bdgTCCanHo";
            this.bdgTCCanHo.PositionItem = this.bindingNavigatorPositionItem;
            this.bdgTCCanHo.Size = new System.Drawing.Size(721, 25);
            this.bdgTCCanHo.TabIndex = 0;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "của {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bngthoat
            // 
            this.bngthoat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bngthoat.Image = global::GalaBuilding.Properties.Resources.exit;
            this.bngthoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bngthoat.Name = "bngthoat";
            this.bngthoat.Size = new System.Drawing.Size(23, 22);
            this.bngthoat.Text = "Thoát";
            this.bngthoat.Click += new System.EventHandler(this.bngthoat_Click);
            // 
            // frmDangKyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 494);
            this.Controls.Add(this.groupBoxDsgv);
            this.Controls.Add(this.nvgPanelGiaoVien);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDangKyDichVu";
            this.Text = "Đăng Ký Dịch Vụ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTraCuuCanHo_Load);
            this.nvgPanelGiaoVien.ResumeLayout(false);
            this.ngvPanelTimKiem.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupBoxDsgv.ResumeLayout(false);
            this.groupBoxDsgv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTCCanHo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgTCCanHo)).EndInit();
            this.bdgTCCanHo.ResumeLayout(false);
            this.bdgTCCanHo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.NavigationPane nvgPanelGiaoVien;
        private DevComponents.DotNetBar.NavigationPanePanel ngvPanelTimKiem;
        private DevComponents.DotNetBar.ButtonX cmdTimKiem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaCanHo;
        private DevComponents.DotNetBar.LabelX lblhoten;
        private DevComponents.DotNetBar.ButtonItem btnTimKiemCH;
        private System.Windows.Forms.GroupBox groupBoxDsgv;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTCCanHo;
        private System.Windows.Forms.BindingNavigator bdgTCCanHo;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bngthoat;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenNguoiDan;
        private DevComponents.DotNetBar.LabelX lblDichVu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbTheoTenNguoiDan;
        private DevComponents.DotNetBar.LabelX lblNguoiDan;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbMaDichVu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbTheoDichVu;
        private DevComponents.Editors.ComboItem col1;
        private DevComponents.Editors.ComboItem col2;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem col3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX cmdDangKy;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbMaDichVuDK;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbMaCanHoDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCanHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TangLau;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNguoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongPhiDichVu;
    }
}