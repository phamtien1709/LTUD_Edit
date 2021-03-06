namespace GalaBuilding
{
    partial class frmNguoiDung
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNguoiDung));
            this.groupBoxDsND = new System.Windows.Forms.GroupBox();
            this.dgvND = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiND = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TenND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgND = new System.Windows.Forms.BindingNavigator(this.components);
            this.bngThemmoi = new System.Windows.Forms.ToolStripButton();
            this.bngXoa = new System.Windows.Forms.ToolStripButton();
            this.bngluu = new System.Windows.Forms.ToolStripButton();
            this.bngthoat = new System.Windows.Forms.ToolStripButton();
            this.groupBoxDsND.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgND)).BeginInit();
            this.bdgND.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDsND
            // 
            this.groupBoxDsND.BackColor = System.Drawing.Color.Gray;
            this.groupBoxDsND.Controls.Add(this.dgvND);
            this.groupBoxDsND.Controls.Add(this.bdgND);
            this.groupBoxDsND.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDsND.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDsND.Name = "groupBoxDsND";
            this.groupBoxDsND.Size = new System.Drawing.Size(710, 426);
            this.groupBoxDsND.TabIndex = 1;
            this.groupBoxDsND.TabStop = false;
            this.groupBoxDsND.Text = "Danh Sách Người Dùng";
            // 
            // dgvND
            // 
            this.dgvND.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvND.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvND.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvND.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaND,
            this.MaLoaiND,
            this.TenND,
            this.TenDangNhap,
            this.MatKhau});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvND.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvND.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvND.GridColor = System.Drawing.Color.Gray;
            this.dgvND.Location = new System.Drawing.Point(3, 41);
            this.dgvND.Name = "dgvND";
            this.dgvND.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvND.Size = new System.Drawing.Size(704, 382);
            this.dgvND.TabIndex = 1;
            // 
            // MaND
            // 
            this.MaND.DataPropertyName = "MaND";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaND.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaND.HeaderText = "Mã Người Dùng";
            this.MaND.Name = "MaND";
            this.MaND.Width = 150;
            // 
            // MaLoaiND
            // 
            this.MaLoaiND.DataPropertyName = "MaLoaiND";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaLoaiND.DefaultCellStyle = dataGridViewCellStyle3;
            this.MaLoaiND.HeaderText = "Loại Người Dùng";
            this.MaLoaiND.Name = "MaLoaiND";
            this.MaLoaiND.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaLoaiND.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MaLoaiND.Width = 150;
            // 
            // TenND
            // 
            this.TenND.DataPropertyName = "TenND";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenND.DefaultCellStyle = dataGridViewCellStyle4;
            this.TenND.HeaderText = "Tên Người Dùng";
            this.TenND.Name = "TenND";
            this.TenND.Width = 130;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenDangNhap.DefaultCellStyle = dataGridViewCellStyle5;
            this.TenDangNhap.HeaderText = "Tên Đăng Nhập";
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.Width = 130;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatKhau.DefaultCellStyle = dataGridViewCellStyle6;
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.Name = "MatKhau";
            // 
            // bdgND
            // 
            this.bdgND.AddNewItem = null;
            this.bdgND.CountItem = null;
            this.bdgND.CountItemFormat = "của {0}";
            this.bdgND.DeleteItem = null;
            this.bdgND.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bngThemmoi,
            this.bngXoa,
            this.bngluu,
            this.bngthoat});
            this.bdgND.Location = new System.Drawing.Point(3, 16);
            this.bdgND.MoveFirstItem = null;
            this.bdgND.MoveLastItem = null;
            this.bdgND.MoveNextItem = null;
            this.bdgND.MovePreviousItem = null;
            this.bdgND.Name = "bdgND";
            this.bdgND.PositionItem = null;
            this.bdgND.Size = new System.Drawing.Size(704, 25);
            this.bdgND.TabIndex = 0;
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
            // frmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 426);
            this.Controls.Add(this.groupBoxDsND);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNguoiDung";
            this.Text = "Người Dùng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNguoiDung_Load);
            this.groupBoxDsND.ResumeLayout(false);
            this.groupBoxDsND.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgND)).EndInit();
            this.bdgND.ResumeLayout(false);
            this.bdgND.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDsND;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvND;
        private System.Windows.Forms.BindingNavigator bdgND;
        private System.Windows.Forms.ToolStripButton bngThemmoi;
        private System.Windows.Forms.ToolStripButton bngXoa;
        private System.Windows.Forms.ToolStripButton bngluu;
        private System.Windows.Forms.ToolStripButton bngthoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaND;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaLoaiND;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenND;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
    }
}