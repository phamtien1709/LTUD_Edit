namespace GalaBuilding
{
    partial class frmTraCuuNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuNhanVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nvgPanelNhanVien = new DevComponents.DotNetBar.NavigationPane();
            this.ngvPanelTimKiem = new DevComponents.DotNetBar.NavigationPanePanel();
            this.cmdTraCuu = new DevComponents.DotNetBar.ButtonX();
            this.txtTenNhanVien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblhoten = new DevComponents.DotNetBar.LabelX();
            this.btnTimKiemNhanVien = new DevComponents.DotNetBar.ButtonItem();
            this.groupBoxDsgv = new System.Windows.Forms.GroupBox();
            this.dgvTraCuuNhanVien = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgTraCuuNhanVien = new System.Windows.Forms.BindingNavigator(this.components);
            this.bngthoat = new System.Windows.Forms.ToolStripButton();
            this.nvgPanelNhanVien.SuspendLayout();
            this.ngvPanelTimKiem.SuspendLayout();
            this.groupBoxDsgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgTraCuuNhanVien)).BeginInit();
            this.bdgTraCuuNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // nvgPanelNhanVien
            // 
            this.nvgPanelNhanVien.CanCollapse = true;
            this.nvgPanelNhanVien.Controls.Add(this.ngvPanelTimKiem);
            this.nvgPanelNhanVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.nvgPanelNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvgPanelNhanVien.ItemPaddingBottom = 2;
            this.nvgPanelNhanVien.ItemPaddingTop = 2;
            this.nvgPanelNhanVien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnTimKiemNhanVien});
            this.nvgPanelNhanVien.Location = new System.Drawing.Point(0, 0);
            this.nvgPanelNhanVien.Name = "nvgPanelNhanVien";
            this.nvgPanelNhanVien.NavigationBarHeight = 67;
            this.nvgPanelNhanVien.Padding = new System.Windows.Forms.Padding(1);
            this.nvgPanelNhanVien.Size = new System.Drawing.Size(192, 494);
            this.nvgPanelNhanVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.nvgPanelNhanVien.TabIndex = 5;
            // 
            // 
            // 
            this.nvgPanelNhanVien.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.nvgPanelNhanVien.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nvgPanelNhanVien.TitlePanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvgPanelNhanVien.TitlePanel.Location = new System.Drawing.Point(1, 1);
            this.nvgPanelNhanVien.TitlePanel.Name = "panelTitle";
            this.nvgPanelNhanVien.TitlePanel.Size = new System.Drawing.Size(190, 24);
            this.nvgPanelNhanVien.TitlePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.nvgPanelNhanVien.TitlePanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.nvgPanelNhanVien.TitlePanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.nvgPanelNhanVien.TitlePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.nvgPanelNhanVien.TitlePanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.nvgPanelNhanVien.TitlePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.nvgPanelNhanVien.TitlePanel.Style.GradientAngle = 90;
            this.nvgPanelNhanVien.TitlePanel.Style.MarginLeft = 4;
            this.nvgPanelNhanVien.TitlePanel.TabIndex = 0;
            // 
            // ngvPanelTimKiem
            // 
            this.ngvPanelTimKiem.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.ngvPanelTimKiem.Controls.Add(this.cmdTraCuu);
            this.ngvPanelTimKiem.Controls.Add(this.txtTenNhanVien);
            this.ngvPanelTimKiem.Controls.Add(this.lblhoten);
            this.ngvPanelTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ngvPanelTimKiem.Location = new System.Drawing.Point(1, 25);
            this.ngvPanelTimKiem.Name = "ngvPanelTimKiem";
            this.ngvPanelTimKiem.ParentItem = this.btnTimKiemNhanVien;
            this.ngvPanelTimKiem.Size = new System.Drawing.Size(190, 401);
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
            this.cmdTraCuu.Location = new System.Drawing.Point(31, 108);
            this.cmdTraCuu.Name = "cmdTraCuu";
            this.cmdTraCuu.Size = new System.Drawing.Size(133, 32);
            this.cmdTraCuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.cmdTraCuu.TabIndex = 4;
            this.cmdTraCuu.Text = "Tra Cứu";
            this.cmdTraCuu.Click += new System.EventHandler(this.cmdTraCuu_Click);
            // 
            // txtTenNhanVien
            // 
            // 
            // 
            // 
            this.txtTenNhanVien.Border.Class = "TextBoxBorder";
            this.txtTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhanVien.Location = new System.Drawing.Point(19, 36);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(155, 20);
            this.txtTenNhanVien.TabIndex = 1;
            // 
            // lblhoten
            // 
            this.lblhoten.Location = new System.Drawing.Point(19, 12);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(86, 23);
            this.lblhoten.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.lblhoten.TabIndex = 0;
            this.lblhoten.Text = "Tên nhân viên";
            // 
            // btnTimKiemNhanVien
            // 
            this.btnTimKiemNhanVien.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnTimKiemNhanVien.Checked = true;
            this.btnTimKiemNhanVien.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnTimKiemNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemNhanVien.Image")));
            this.btnTimKiemNhanVien.ImagePaddingHorizontal = 8;
            this.btnTimKiemNhanVien.Name = "btnTimKiemNhanVien";
            this.btnTimKiemNhanVien.OptionGroup = "navBar";
            // 
            // groupBoxDsgv
            // 
            this.groupBoxDsgv.BackColor = System.Drawing.Color.Silver;
            this.groupBoxDsgv.Controls.Add(this.dgvTraCuuNhanVien);
            this.groupBoxDsgv.Controls.Add(this.bdgTraCuuNhanVien);
            this.groupBoxDsgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDsgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDsgv.Location = new System.Drawing.Point(192, 0);
            this.groupBoxDsgv.Name = "groupBoxDsgv";
            this.groupBoxDsgv.Size = new System.Drawing.Size(727, 494);
            this.groupBoxDsgv.TabIndex = 6;
            this.groupBoxDsgv.TabStop = false;
            this.groupBoxDsgv.Text = "Kết quả tìm kiếm";
            // 
            // dgvTraCuuNhanVien
            // 
            this.dgvTraCuuNhanVien.AllowUserToAddRows = false;
            this.dgvTraCuuNhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvTraCuuNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTraCuuNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.TenNhanVien,
            this.GioiTinh,
            this.NgaySinh,
            this.TenChucVu});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTraCuuNhanVien.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTraCuuNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTraCuuNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTraCuuNhanVien.Location = new System.Drawing.Point(3, 41);
            this.dgvTraCuuNhanVien.Name = "dgvTraCuuNhanVien";
            this.dgvTraCuuNhanVien.Size = new System.Drawing.Size(721, 450);
            this.dgvTraCuuNhanVien.TabIndex = 6;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNhanVien.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.MaNhanVien.Name = "MaNhanVien";
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenNhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            this.TenNhanVien.HeaderText = "Tên Nhân Viên";
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.Width = 150;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính nữ";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GioiTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TenChucVu
            // 
            this.TenChucVu.DataPropertyName = "TenChucVu";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenChucVu.DefaultCellStyle = dataGridViewCellStyle3;
            this.TenChucVu.HeaderText = "Chức vụ";
            this.TenChucVu.Name = "TenChucVu";
            this.TenChucVu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenChucVu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // bdgTraCuuNhanVien
            // 
            this.bdgTraCuuNhanVien.AddNewItem = null;
            this.bdgTraCuuNhanVien.CountItem = null;
            this.bdgTraCuuNhanVien.CountItemFormat = "của {0}";
            this.bdgTraCuuNhanVien.DeleteItem = null;
            this.bdgTraCuuNhanVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bngthoat});
            this.bdgTraCuuNhanVien.Location = new System.Drawing.Point(3, 16);
            this.bdgTraCuuNhanVien.MoveFirstItem = null;
            this.bdgTraCuuNhanVien.MoveLastItem = null;
            this.bdgTraCuuNhanVien.MoveNextItem = null;
            this.bdgTraCuuNhanVien.MovePreviousItem = null;
            this.bdgTraCuuNhanVien.Name = "bdgTraCuuNhanVien";
            this.bdgTraCuuNhanVien.PositionItem = null;
            this.bdgTraCuuNhanVien.Size = new System.Drawing.Size(721, 25);
            this.bdgTraCuuNhanVien.TabIndex = 0;
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
            // frmTraCuuNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 494);
            this.Controls.Add(this.groupBoxDsgv);
            this.Controls.Add(this.nvgPanelNhanVien);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTraCuuNhanVien";
            this.Text = "Tra cứu nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTraCuuNhanVien_Load);
            this.nvgPanelNhanVien.ResumeLayout(false);
            this.ngvPanelTimKiem.ResumeLayout(false);
            this.groupBoxDsgv.ResumeLayout(false);
            this.groupBoxDsgv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgTraCuuNhanVien)).EndInit();
            this.bdgTraCuuNhanVien.ResumeLayout(false);
            this.bdgTraCuuNhanVien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.NavigationPane nvgPanelNhanVien;
        private DevComponents.DotNetBar.NavigationPanePanel ngvPanelTimKiem;
        private DevComponents.DotNetBar.ButtonX cmdTraCuu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenNhanVien;
        private DevComponents.DotNetBar.LabelX lblhoten;
        private DevComponents.DotNetBar.ButtonItem btnTimKiemNhanVien;
        private System.Windows.Forms.GroupBox groupBoxDsgv;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTraCuuNhanVien;
        private System.Windows.Forms.BindingNavigator bdgTraCuuNhanVien;
        private System.Windows.Forms.ToolStripButton bngthoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChucVu;
    }
}