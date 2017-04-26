namespace GalaBuilding
{
    partial class frmLoaiNguoiDung
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiNguoiDung));
            this.groupBoxDsdantoc = new System.Windows.Forms.GroupBox();
            this.ctxMenuLND = new DevComponents.DotNetBar.ContextMenuBar();
            this.btnMenuLND = new DevComponents.DotNetBar.ButtonItem();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.dgvLND = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaLoaiND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgLND = new System.Windows.Forms.BindingNavigator(this.components);
            this.bngThemmoi = new System.Windows.Forms.ToolStripButton();
            this.bngXoa = new System.Windows.Forms.ToolStripButton();
            this.bngluu = new System.Windows.Forms.ToolStripButton();
            this.bngthoat = new System.Windows.Forms.ToolStripButton();
            this.groupBoxDsdantoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenuLND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgLND)).BeginInit();
            this.bdgLND.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDsdantoc
            // 
            this.groupBoxDsdantoc.Controls.Add(this.ctxMenuLND);
            this.groupBoxDsdantoc.Controls.Add(this.dgvLND);
            this.groupBoxDsdantoc.Controls.Add(this.bdgLND);
            this.groupBoxDsdantoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDsdantoc.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDsdantoc.Name = "groupBoxDsdantoc";
            this.groupBoxDsdantoc.Size = new System.Drawing.Size(397, 338);
            this.groupBoxDsdantoc.TabIndex = 1;
            this.groupBoxDsdantoc.TabStop = false;
            this.groupBoxDsdantoc.Text = "Danh Sách Loại Người Dùng";
            // 
            // ctxMenuLND
            // 
            this.ctxMenuLND.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.ctxMenuLND.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMenuLND});
            this.ctxMenuLND.Location = new System.Drawing.Point(143, 145);
            this.ctxMenuLND.Name = "ctxMenuLND";
            this.ctxMenuLND.Size = new System.Drawing.Size(75, 25);
            this.ctxMenuLND.Stretch = true;
            this.ctxMenuLND.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ctxMenuLND.TabIndex = 5;
            this.ctxMenuLND.TabStop = false;
            this.ctxMenuLND.Text = "ctxMenu";
            // 
            // btnMenuLND
            // 
            this.btnMenuLND.AutoExpandOnClick = true;
            this.btnMenuLND.ImagePaddingHorizontal = 8;
            this.btnMenuLND.Name = "btnMenuLND";
            this.btnMenuLND.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnMenuLND.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAdd,
            this.btnDelete,
            this.btnSave,
            this.btnClose});
            this.btnMenuLND.Text = "Menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::GalaBuilding.Properties.Resources.add;
            this.btnAdd.ImagePaddingHorizontal = 8;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.bngThemmoi_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::GalaBuilding.Properties.Resources.delete;
            this.btnDelete.ImagePaddingHorizontal = 8;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.btnDelete.Text = "Xóa dòng được chọn";
            this.btnDelete.Click += new System.EventHandler(this.bngXoa_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::GalaBuilding.Properties.Resources.save;
            this.btnSave.ImagePaddingHorizontal = 8;
            this.btnSave.Name = "btnSave";
            this.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSave.Text = "Lưu danh sách";
            this.btnSave.Click += new System.EventHandler(this.bngluu_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::GalaBuilding.Properties.Resources.exit;
            this.btnClose.ImagePaddingHorizontal = 8;
            this.btnClose.Name = "btnClose";
            this.btnClose.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltF4);
            this.btnClose.Text = "Đóng cửa sổ này";
            this.btnClose.Click += new System.EventHandler(this.bngthoat_Click);
            // 
            // dgvLND
            // 
            this.dgvLND.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLND.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLND.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvLND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLND.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiND,
            this.TenLoaiND});
            this.ctxMenuLND.SetContextMenuEx(this.dgvLND, this.btnMenuLND);
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLND.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLND.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLND.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvLND.Location = new System.Drawing.Point(3, 41);
            this.dgvLND.Name = "dgvLND";
            this.dgvLND.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLND.Size = new System.Drawing.Size(391, 294);
            this.dgvLND.TabIndex = 1;
            // 
            // MaLoaiND
            // 
            this.MaLoaiND.DataPropertyName = "MaLoaiND";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaLoaiND.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaLoaiND.HeaderText = "Mã Loại Người Dùng";
            this.MaLoaiND.Name = "MaLoaiND";
            this.MaLoaiND.Width = 150;
            // 
            // TenLoaiND
            // 
            this.TenLoaiND.DataPropertyName = "TenLoaiND";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenLoaiND.DefaultCellStyle = dataGridViewCellStyle3;
            this.TenLoaiND.HeaderText = "Tên Loại Người Dùng";
            this.TenLoaiND.Name = "TenLoaiND";
            this.TenLoaiND.Width = 200;
            // 
            // bdgLND
            // 
            this.bdgLND.AddNewItem = null;
            this.bdgLND.CountItem = null;
            this.bdgLND.CountItemFormat = "của {0}";
            this.bdgLND.DeleteItem = null;
            this.bdgLND.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bngThemmoi,
            this.bngXoa,
            this.bngluu,
            this.bngthoat});
            this.bdgLND.Location = new System.Drawing.Point(3, 16);
            this.bdgLND.MoveFirstItem = null;
            this.bdgLND.MoveLastItem = null;
            this.bdgLND.MoveNextItem = null;
            this.bdgLND.MovePreviousItem = null;
            this.bdgLND.Name = "bdgLND";
            this.bdgLND.PositionItem = null;
            this.bdgLND.Size = new System.Drawing.Size(391, 25);
            this.bdgLND.TabIndex = 0;
            // 
            // bngThemmoi
            // 
            this.bngThemmoi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bngThemmoi.Image = global::GalaBuilding.Properties.Resources.add;
            this.bngThemmoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bngThemmoi.Name = "bngThemmoi";
            this.bngThemmoi.Size = new System.Drawing.Size(23, 22);
            this.bngThemmoi.Text = "Thêm ";
            this.bngThemmoi.Click += new System.EventHandler(this.bngThemmoi_Click);
            // 
            // bngXoa
            // 
            this.bngXoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bngXoa.Image = global::GalaBuilding.Properties.Resources.delete;
            this.bngXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bngXoa.Name = "bngXoa";
            this.bngXoa.Size = new System.Drawing.Size(23, 22);
            this.bngXoa.Text = "Xóa";
            this.bngXoa.Click += new System.EventHandler(this.bngXoa_Click);
            // 
            // bngluu
            // 
            this.bngluu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bngluu.Image = global::GalaBuilding.Properties.Resources.save;
            this.bngluu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bngluu.Name = "bngluu";
            this.bngluu.Size = new System.Drawing.Size(23, 22);
            this.bngluu.Text = "Lưu";
            this.bngluu.Click += new System.EventHandler(this.bngluu_Click);
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
            // frmLoaiNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 338);
            this.Controls.Add(this.groupBoxDsdantoc);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLoaiNguoiDung";
            this.Text = "Loại Người Dùng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLoaiNguoiDung_Load);
            this.groupBoxDsdantoc.ResumeLayout(false);
            this.groupBoxDsdantoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenuLND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgLND)).EndInit();
            this.bdgLND.ResumeLayout(false);
            this.bdgLND.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDsdantoc;
        private DevComponents.DotNetBar.ContextMenuBar ctxMenuLND;
        private DevComponents.DotNetBar.ButtonItem btnMenuLND;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private DevComponents.DotNetBar.ButtonItem btnSave;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvLND;
        private System.Windows.Forms.BindingNavigator bdgLND;
        private System.Windows.Forms.ToolStripButton bngThemmoi;
        private System.Windows.Forms.ToolStripButton bngXoa;
        private System.Windows.Forms.ToolStripButton bngluu;
        private System.Windows.Forms.ToolStripButton bngthoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiND;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiND;
    }
}