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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxDschucvu = new System.Windows.Forms.GroupBox();
            this.dgvChucVu = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgChucVu = new System.Windows.Forms.BindingNavigator(this.components);
            this.bngThemmoi = new System.Windows.Forms.ToolStripButton();
            this.bngXoa = new System.Windows.Forms.ToolStripButton();
            this.bngluu = new System.Windows.Forms.ToolStripButton();
            this.bngthoat = new System.Windows.Forms.ToolStripButton();
            this.groupBoxDschucvu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgChucVu)).BeginInit();
            this.bdgChucVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDschucvu
            // 
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
            // dgvChucVu
            // 
            this.dgvChucVu.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChucVu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChucVu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChucVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChucVu,
            this.TenChucVu});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChucVu.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChucVu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvChucVu.Location = new System.Drawing.Point(3, 41);
            this.dgvChucVu.Name = "dgvChucVu";
            this.dgvChucVu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvChucVu.Size = new System.Drawing.Size(332, 242);
            this.dgvChucVu.TabIndex = 1;
            this.dgvChucVu.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvChucVu_DataError);
            // 
            // MaChucVu
            // 
            this.MaChucVu.DataPropertyName = "MaChucVu";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaChucVu.DefaultCellStyle = dataGridViewCellStyle3;
            this.MaChucVu.HeaderText = "Mã Chức Vụ";
            this.MaChucVu.Name = "MaChucVu";
            this.MaChucVu.Width = 150;
            // 
            // TenChucVu
            // 
            this.TenChucVu.DataPropertyName = "TenChucVu";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenChucVu.DefaultCellStyle = dataGridViewCellStyle4;
            this.TenChucVu.HeaderText = "Tên Chức Vụ";
            this.TenChucVu.Name = "TenChucVu";
            this.TenChucVu.Width = 150;
            // 
            // bdgChucVu
            // 
            this.bdgChucVu.AddNewItem = null;
            this.bdgChucVu.CountItem = null;
            this.bdgChucVu.CountItemFormat = "của {0}";
            this.bdgChucVu.DeleteItem = null;
            this.bdgChucVu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bngThemmoi,
            this.bngXoa,
            this.bngluu,
            this.bngthoat});
            this.bdgChucVu.Location = new System.Drawing.Point(3, 16);
            this.bdgChucVu.MoveFirstItem = null;
            this.bdgChucVu.MoveLastItem = null;
            this.bdgChucVu.MoveNextItem = null;
            this.bdgChucVu.MovePreviousItem = null;
            this.bdgChucVu.Name = "bdgChucVu";
            this.bdgChucVu.PositionItem = null;
            this.bdgChucVu.Size = new System.Drawing.Size(332, 25);
            this.bdgChucVu.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgChucVu)).EndInit();
            this.bdgChucVu.ResumeLayout(false);
            this.bdgChucVu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDschucvu;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvChucVu;
        private System.Windows.Forms.BindingNavigator bdgChucVu;
        private System.Windows.Forms.ToolStripButton bngThemmoi;
        private System.Windows.Forms.ToolStripButton bngXoa;
        private System.Windows.Forms.ToolStripButton bngluu;
        private System.Windows.Forms.ToolStripButton bngthoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChucVu;
    }
}