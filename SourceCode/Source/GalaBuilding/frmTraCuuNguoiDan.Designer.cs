namespace GalaBuilding
{
    partial class frmTraCuuNguoiDan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuNguoiDan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nvgPanelGiaoVien = new DevComponents.DotNetBar.NavigationPane();
            this.ngvPanelTimKiem = new DevComponents.DotNetBar.NavigationPanePanel();
            this.cmdTraCuu = new DevComponents.DotNetBar.ButtonX();
            this.txtTenNguoiDan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblhoten = new DevComponents.DotNetBar.LabelX();
            this.btnTraCuuNguoiDan = new DevComponents.DotNetBar.ButtonItem();
            this.groupBoxDsgv = new System.Windows.Forms.GroupBox();
            this.dgvTraCuuNguoiDan = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaNguoiDan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNguoiDan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCanHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgTraCuuNguoiDan = new System.Windows.Forms.BindingNavigator(this.components);
            this.bngthoat = new System.Windows.Forms.ToolStripButton();
            this.nvgPanelGiaoVien.SuspendLayout();
            this.ngvPanelTimKiem.SuspendLayout();
            this.groupBoxDsgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuNguoiDan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgTraCuuNguoiDan)).BeginInit();
            this.bdgTraCuuNguoiDan.SuspendLayout();
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
            this.btnTraCuuNguoiDan});
            this.nvgPanelGiaoVien.Location = new System.Drawing.Point(0, 0);
            this.nvgPanelGiaoVien.Name = "nvgPanelGiaoVien";
            this.nvgPanelGiaoVien.NavigationBarHeight = 67;
            this.nvgPanelGiaoVien.Padding = new System.Windows.Forms.Padding(1);
            this.nvgPanelGiaoVien.Size = new System.Drawing.Size(192, 509);
            this.nvgPanelGiaoVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.nvgPanelGiaoVien.TabIndex = 6;
            // 
            // 
            // 
            this.nvgPanelGiaoVien.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.nvgPanelGiaoVien.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nvgPanelGiaoVien.TitlePanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvgPanelGiaoVien.TitlePanel.Location = new System.Drawing.Point(1, 1);
            this.nvgPanelGiaoVien.TitlePanel.Name = "panelTitle";
            this.nvgPanelGiaoVien.TitlePanel.Size = new System.Drawing.Size(190, 24);
            this.nvgPanelGiaoVien.TitlePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.nvgPanelGiaoVien.TitlePanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.nvgPanelGiaoVien.TitlePanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.nvgPanelGiaoVien.TitlePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.nvgPanelGiaoVien.TitlePanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.nvgPanelGiaoVien.TitlePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.nvgPanelGiaoVien.TitlePanel.Style.GradientAngle = 90;
            this.nvgPanelGiaoVien.TitlePanel.Style.MarginLeft = 4;
            this.nvgPanelGiaoVien.TitlePanel.TabIndex = 0;
            // 
            // ngvPanelTimKiem
            // 
            this.ngvPanelTimKiem.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.ngvPanelTimKiem.Controls.Add(this.cmdTraCuu);
            this.ngvPanelTimKiem.Controls.Add(this.txtTenNguoiDan);
            this.ngvPanelTimKiem.Controls.Add(this.lblhoten);
            this.ngvPanelTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ngvPanelTimKiem.Location = new System.Drawing.Point(1, 25);
            this.ngvPanelTimKiem.Name = "ngvPanelTimKiem";
            this.ngvPanelTimKiem.ParentItem = this.btnTraCuuNguoiDan;
            this.ngvPanelTimKiem.Size = new System.Drawing.Size(190, 416);
            this.ngvPanelTimKiem.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.ngvPanelTimKiem.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.ngvPanelTimKiem.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.ngvPanelTimKiem.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.ngvPanelTimKiem.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.ngvPanelTimKiem.Style.GradientAngle = 90;
            this.ngvPanelTimKiem.TabIndex = 3;
            // 
            // cmdTraCuu
            // 
            this.cmdTraCuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdTraCuu.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.cmdTraCuu.Location = new System.Drawing.Point(30, 135);
            this.cmdTraCuu.Name = "cmdTraCuu";
            this.cmdTraCuu.Size = new System.Drawing.Size(133, 32);
            this.cmdTraCuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.cmdTraCuu.TabIndex = 4;
            this.cmdTraCuu.Text = "Tra Cứu";
            this.cmdTraCuu.Click += new System.EventHandler(this.cmdTraCuu_Click);
            // 
            // txtTenNguoiDan
            // 
            // 
            // 
            // 
            this.txtTenNguoiDan.Border.Class = "TextBoxBorder";
            this.txtTenNguoiDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNguoiDan.Location = new System.Drawing.Point(19, 36);
            this.txtTenNguoiDan.Name = "txtTenNguoiDan";
            this.txtTenNguoiDan.Size = new System.Drawing.Size(155, 20);
            this.txtTenNguoiDan.TabIndex = 1;
            // 
            // lblhoten
            // 
            this.lblhoten.Location = new System.Drawing.Point(19, 12);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(94, 23);
            this.lblhoten.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.lblhoten.TabIndex = 0;
            this.lblhoten.Text = "Tên Người Dân";
            // 
            // btnTraCuuNguoiDan
            // 
            this.btnTraCuuNguoiDan.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnTraCuuNguoiDan.Checked = true;
            this.btnTraCuuNguoiDan.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnTraCuuNguoiDan.Image = ((System.Drawing.Image)(resources.GetObject("btnTraCuuNguoiDan.Image")));
            this.btnTraCuuNguoiDan.ImagePaddingHorizontal = 8;
            this.btnTraCuuNguoiDan.Name = "btnTraCuuNguoiDan";
            this.btnTraCuuNguoiDan.OptionGroup = "navBar";
            // 
            // groupBoxDsgv
            // 
            this.groupBoxDsgv.BackColor = System.Drawing.Color.Silver;
            this.groupBoxDsgv.Controls.Add(this.dgvTraCuuNguoiDan);
            this.groupBoxDsgv.Controls.Add(this.bdgTraCuuNguoiDan);
            this.groupBoxDsgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDsgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDsgv.Location = new System.Drawing.Point(192, 0);
            this.groupBoxDsgv.Name = "groupBoxDsgv";
            this.groupBoxDsgv.Size = new System.Drawing.Size(877, 509);
            this.groupBoxDsgv.TabIndex = 7;
            this.groupBoxDsgv.TabStop = false;
            this.groupBoxDsgv.Text = "Kết quả tìm kiếm";
            // 
            // dgvTraCuuNguoiDan
            // 
            this.dgvTraCuuNguoiDan.AllowUserToAddRows = false;
            this.dgvTraCuuNguoiDan.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTraCuuNguoiDan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTraCuuNguoiDan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNguoiDan,
            this.TenNguoiDan,
            this.MaCanHo,
            this.GioiTinh,
            this.NgaySinh});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTraCuuNguoiDan.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTraCuuNguoiDan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTraCuuNguoiDan.GridColor = System.Drawing.Color.Silver;
            this.dgvTraCuuNguoiDan.Location = new System.Drawing.Point(3, 41);
            this.dgvTraCuuNguoiDan.Name = "dgvTraCuuNguoiDan";
            this.dgvTraCuuNguoiDan.Size = new System.Drawing.Size(871, 465);
            this.dgvTraCuuNguoiDan.TabIndex = 6;
            // 
            // MaNguoiDan
            // 
            this.MaNguoiDan.DataPropertyName = "MaNguoiDan";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNguoiDan.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaNguoiDan.HeaderText = "Mã Người Dân";
            this.MaNguoiDan.Name = "MaNguoiDan";
            this.MaNguoiDan.Width = 130;
            // 
            // TenNguoiDan
            // 
            this.TenNguoiDan.DataPropertyName = "TenNguoiDan";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenNguoiDan.DefaultCellStyle = dataGridViewCellStyle2;
            this.TenNguoiDan.HeaderText = "Tên Người Dân";
            this.TenNguoiDan.Name = "TenNguoiDan";
            this.TenNguoiDan.Width = 150;
            // 
            // MaCanHo
            // 
            this.MaCanHo.DataPropertyName = "MaCanHo";
            this.MaCanHo.FillWeight = 115F;
            this.MaCanHo.HeaderText = "Căn Hộ Đang ở";
            this.MaCanHo.Name = "MaCanHo";
            this.MaCanHo.Width = 115;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.NullValue = false;
            this.GioiTinh.DefaultCellStyle = dataGridViewCellStyle3;
            this.GioiTinh.HeaderText = "Giới tính nữ";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GioiTinh.ToolTipText = "Nam: không check; Nữ: check";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaySinh.DefaultCellStyle = dataGridViewCellStyle4;
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // bdgTraCuuNguoiDan
            // 
            this.bdgTraCuuNguoiDan.AddNewItem = null;
            this.bdgTraCuuNguoiDan.CountItem = null;
            this.bdgTraCuuNguoiDan.CountItemFormat = "của {0}";
            this.bdgTraCuuNguoiDan.DeleteItem = null;
            this.bdgTraCuuNguoiDan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bngthoat});
            this.bdgTraCuuNguoiDan.Location = new System.Drawing.Point(3, 16);
            this.bdgTraCuuNguoiDan.MoveFirstItem = null;
            this.bdgTraCuuNguoiDan.MoveLastItem = null;
            this.bdgTraCuuNguoiDan.MoveNextItem = null;
            this.bdgTraCuuNguoiDan.MovePreviousItem = null;
            this.bdgTraCuuNguoiDan.Name = "bdgTraCuuNguoiDan";
            this.bdgTraCuuNguoiDan.PositionItem = null;
            this.bdgTraCuuNguoiDan.Size = new System.Drawing.Size(871, 25);
            this.bdgTraCuuNguoiDan.TabIndex = 0;
            this.bdgTraCuuNguoiDan.RefreshItems += new System.EventHandler(this.bdgTKHocsinh_RefreshItems);
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
            // frmTraCuuNguoiDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 509);
            this.Controls.Add(this.groupBoxDsgv);
            this.Controls.Add(this.nvgPanelGiaoVien);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTraCuuNguoiDan";
            this.Text = "Tra Cứu Người Dân";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTraCuuNguoiDan_Load);
            this.nvgPanelGiaoVien.ResumeLayout(false);
            this.ngvPanelTimKiem.ResumeLayout(false);
            this.groupBoxDsgv.ResumeLayout(false);
            this.groupBoxDsgv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuNguoiDan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgTraCuuNguoiDan)).EndInit();
            this.bdgTraCuuNguoiDan.ResumeLayout(false);
            this.bdgTraCuuNguoiDan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.NavigationPane nvgPanelGiaoVien;
        private DevComponents.DotNetBar.NavigationPanePanel ngvPanelTimKiem;
        private DevComponents.DotNetBar.ButtonX cmdTraCuu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenNguoiDan;
        private DevComponents.DotNetBar.LabelX lblhoten;
        private DevComponents.DotNetBar.ButtonItem btnTraCuuNguoiDan;
        private System.Windows.Forms.GroupBox groupBoxDsgv;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTraCuuNguoiDan;
        private System.Windows.Forms.BindingNavigator bdgTraCuuNguoiDan;
        private System.Windows.Forms.ToolStripButton bngthoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNguoiDan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNguoiDan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCanHo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
    }
}