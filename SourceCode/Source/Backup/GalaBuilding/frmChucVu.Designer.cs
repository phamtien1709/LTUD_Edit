namespace GalaBuilding
{
    partial class frmChucVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChucVu));
            this.groupBoxDschucvu = new System.Windows.Forms.GroupBox();
            this.ctxMenuDantoc = new DevComponents.DotNetBar.ContextMenuBar();
            this.btnMenuDantoc = new DevComponents.DotNetBar.ButtonItem();
            this.dgvChucVu = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.bdgChucVu = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bngThemmoi = new System.Windows.Forms.ToolStripButton();
            this.bngXoa = new System.Windows.Forms.ToolStripButton();
            this.bngluu = new System.Windows.Forms.ToolStripButton();
            this.bngthoat = new System.Windows.Forms.ToolStripButton();
            this.groupBoxDschucvu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenuDantoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgChucVu)).BeginInit();
            this.bdgChucVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDschucvu
            // 
            this.groupBoxDschucvu.Controls.Add(this.ctxMenuDantoc);
            this.groupBoxDschucvu.Controls.Add(this.dgvChucVu);
            this.groupBoxDschucvu.Controls.Add(this.bdgChucVu);
            this.groupBoxDschucvu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDschucvu.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDschucvu.Name = "groupBoxDschucvu";
            this.groupBoxDschucvu.Size = new System.Drawing.Size(338, 286);
            this.groupBoxDschucvu.TabIndex = 1;
            this.groupBoxDschucvu.TabStop = false;
            this.groupBoxDschucvu.Text = "Danh Sách Chức Vụ";
            // 
            // ctxMenuDantoc
            // 
            this.ctxMenuDantoc.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.ctxMenuDantoc.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMenuDantoc});
            this.ctxMenuDantoc.Location = new System.Drawing.Point(143, 145);
            this.ctxMenuDantoc.Name = "ctxMenuDantoc";
            this.ctxMenuDantoc.Size = new System.Drawing.Size(75, 25);
            this.ctxMenuDantoc.Stretch = true;
            this.ctxMenuDantoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ctxMenuDantoc.TabIndex = 5;
            this.ctxMenuDantoc.TabStop = false;
            this.ctxMenuDantoc.Text = "ctxMenu";
            // 
            // btnMenuDantoc
            // 
            this.btnMenuDantoc.AutoExpandOnClick = true;
            this.btnMenuDantoc.ImagePaddingHorizontal = 8;
            this.btnMenuDantoc.Name = "btnMenuDantoc";
            this.btnMenuDantoc.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnMenuDantoc.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAdd,
            this.btnDelete,
            this.btnSave,
            this.btnClose});
            this.btnMenuDantoc.Text = "Menu";
            // 
            // dgvChucVu
            // 
            this.dgvChucVu.AllowUserToAddRows = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChucVu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvChucVu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChucVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChucVu,
            this.TenChucVu});
            this.ctxMenuDantoc.SetContextMenuEx(this.dgvChucVu, this.btnMenuDantoc);
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChucVu.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChucVu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvChucVu.Location = new System.Drawing.Point(3, 41);
            this.dgvChucVu.Name = "dgvChucVu";
            this.dgvChucVu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvChucVu.Size = new System.Drawing.Size(332, 242);
            this.dgvChucVu.TabIndex = 1;
            this.dgvChucVu.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvChucVu_DataError);
            // 
            // bdgChucVu
            // 
            this.bdgChucVu.AddNewItem = null;
            this.bdgChucVu.CountItem = this.bindingNavigatorCountItem;
            this.bdgChucVu.CountItemFormat = "của {0}";
            this.bdgChucVu.DeleteItem = null;
            this.bdgChucVu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bngThemmoi,
            this.bngXoa,
            this.bngluu,
            this.bngthoat});
            this.bdgChucVu.Location = new System.Drawing.Point(3, 16);
            this.bdgChucVu.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdgChucVu.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdgChucVu.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdgChucVu.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdgChucVu.Name = "bdgChucVu";
            this.bdgChucVu.PositionItem = this.bindingNavigatorPositionItem;
            this.bdgChucVu.Size = new System.Drawing.Size(332, 25);
            this.bdgChucVu.TabIndex = 0;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "của {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // MaChucVu
            // 
            this.MaChucVu.DataPropertyName = "MaChucVu";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaChucVu.DefaultCellStyle = dataGridViewCellStyle8;
            this.MaChucVu.HeaderText = "Mã Chức Vụ";
            this.MaChucVu.Name = "MaChucVu";
            this.MaChucVu.Width = 150;
            // 
            // TenChucVu
            // 
            this.TenChucVu.DataPropertyName = "TenChucVu";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenChucVu.DefaultCellStyle = dataGridViewCellStyle9;
            this.TenChucVu.HeaderText = "Tên Chức Vụ";
            this.TenChucVu.Name = "TenChucVu";
            this.TenChucVu.Width = 150;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::GalaBuilding.Properties.Resources.add;
            this.btnAdd.ImagePaddingHorizontal = 8;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::GalaBuilding.Properties.Resources.delete;
            this.btnDelete.ImagePaddingHorizontal = 8;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.btnDelete.Text = "Xóa dòng được chọn";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::GalaBuilding.Properties.Resources.save;
            this.btnSave.ImagePaddingHorizontal = 8;
            this.btnSave.Name = "btnSave";
            this.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSave.Text = "Lưu danh sách";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::GalaBuilding.Properties.Resources.exit;
            this.btnClose.ImagePaddingHorizontal = 8;
            this.btnClose.Name = "btnClose";
            this.btnClose.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltF4);
            this.btnClose.Text = "Đóng cửa sổ này";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // frmChucVu
            // 
            this.ClientSize = new System.Drawing.Size(338, 286);
            this.Controls.Add(this.groupBoxDschucvu);
            this.DoubleBuffered = true;
            this.Name = "frmChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chức Vụ";
            this.Load += new System.EventHandler(this.frmChucVu_Load);
            this.groupBoxDschucvu.ResumeLayout(false);
            this.groupBoxDschucvu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenuDantoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgChucVu)).EndInit();
            this.bdgChucVu.ResumeLayout(false);
            this.bdgChucVu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDschucvu;
        private DevComponents.DotNetBar.ContextMenuBar ctxMenuDantoc;
        private DevComponents.DotNetBar.ButtonItem btnMenuDantoc;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private DevComponents.DotNetBar.ButtonItem btnSave;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvChucVu;
        private System.Windows.Forms.BindingNavigator bdgChucVu;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bngThemmoi;
        private System.Windows.Forms.ToolStripButton bngXoa;
        private System.Windows.Forms.ToolStripButton bngluu;
        private System.Windows.Forms.ToolStripButton bngthoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChucVu;
    }
}