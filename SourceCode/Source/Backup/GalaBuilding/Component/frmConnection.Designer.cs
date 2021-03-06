namespace GalaBuilding.Component
{
    partial class frmConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnection));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtserver = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmbAuthentication = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.winAuth = new DevComponents.Editors.ComboItem();
            this.sqlserver = new DevComponents.Editors.ComboItem();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtusername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtmatkhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.panelLine = new System.Windows.Forms.Panel();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cmbdatabase = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnTesconnection = new DevComponents.DotNetBar.ButtonX();
            this.btnConnect = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.reflectionImage1);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(403, 95);
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
            this.groupPanel1.TabIndex = 0;
            // 
            // reflectionImage1
            // 
            this.reflectionImage1.Dock = System.Windows.Forms.DockStyle.Top;
            this.reflectionImage1.Image = global::GalaBuilding.Properties.Resources.SQL_server;
            this.reflectionImage1.Location = new System.Drawing.Point(0, 0);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(397, 90);
            this.reflectionImage1.TabIndex = 0;
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(25, 111);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Server name:";
            // 
            // txtserver
            // 
            // 
            // 
            // 
            this.txtserver.Border.Class = "TextBoxBorder";
            this.txtserver.Location = new System.Drawing.Point(190, 111);
            this.txtserver.Name = "txtserver";
            this.txtserver.Size = new System.Drawing.Size(172, 20);
            this.txtserver.TabIndex = 1;
            this.txtserver.WatermarkText = "Tên Server";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(25, 140);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Authenticaton:";
            // 
            // cmbAuthentication
            // 
            this.cmbAuthentication.DisplayMember = "Text";
            this.cmbAuthentication.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAuthentication.FormattingEnabled = true;
            this.cmbAuthentication.ItemHeight = 14;
            this.cmbAuthentication.Items.AddRange(new object[] {
            this.winAuth,
            this.sqlserver});
            this.cmbAuthentication.Location = new System.Drawing.Point(189, 140);
            this.cmbAuthentication.Name = "cmbAuthentication";
            this.cmbAuthentication.Size = new System.Drawing.Size(173, 20);
            this.cmbAuthentication.TabIndex = 2;
            this.cmbAuthentication.SelectedIndexChanged += new System.EventHandler(this.cmbAuthentication_SelectedIndexChanged_1);
            // 
            // winAuth
            // 
            this.winAuth.Text = "Windows Authentication";
            // 
            // sqlserver
            // 
            this.sqlserver.Text = "SQL Server Authentication";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(25, 169);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "Username:";
            // 
            // txtusername
            // 
            // 
            // 
            // 
            this.txtusername.Border.Class = "TextBoxBorder";
            this.txtusername.Location = new System.Drawing.Point(189, 169);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(172, 20);
            this.txtusername.TabIndex = 3;
            this.txtusername.WatermarkText = "Tên đăng nhập hệ thống";
            // 
            // txtmatkhau
            // 
            // 
            // 
            // 
            this.txtmatkhau.Border.Class = "TextBoxBorder";
            this.txtmatkhau.Location = new System.Drawing.Point(189, 198);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(172, 20);
            this.txtmatkhau.TabIndex = 4;
            this.txtmatkhau.WatermarkText = "Mật khẩu đăng nhập";
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(25, 198);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "Password: ";
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelLine.Location = new System.Drawing.Point(21, 291);
            this.panelLine.Name = "panelLine";
            this.panelLine.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelLine.Size = new System.Drawing.Size(370, 1);
            this.panelLine.TabIndex = 9;
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(25, 252);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 10;
            this.labelX5.Text = "Database: ";
            // 
            // cmbdatabase
            // 
            this.cmbdatabase.DisplayMember = "Text";
            this.cmbdatabase.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbdatabase.FormattingEnabled = true;
            this.cmbdatabase.ItemHeight = 14;
            this.cmbdatabase.Location = new System.Drawing.Point(188, 252);
            this.cmbdatabase.Name = "cmbdatabase";
            this.cmbdatabase.Size = new System.Drawing.Size(173, 20);
            this.cmbdatabase.TabIndex = 5;
            // 
            // btnTesconnection
            // 
            this.btnTesconnection.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTesconnection.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTesconnection.Location = new System.Drawing.Point(189, 224);
            this.btnTesconnection.Name = "btnTesconnection";
            this.btnTesconnection.Size = new System.Drawing.Size(110, 23);
            this.btnTesconnection.TabIndex = 6;
            this.btnTesconnection.Text = "Test Connection";
            this.btnTesconnection.Click += new System.EventHandler(this.btnTesconnection_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnConnect.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnConnect.Location = new System.Drawing.Point(189, 298);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnCancel.Location = new System.Drawing.Point(286, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 330);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnTesconnection);
            this.Controls.Add(this.cmbdatabase);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.panelLine);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.cmbAuthentication);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtserver);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect to Server";
            this.Load += new System.EventHandler(this.frmConnection_Load);
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtserver;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtusername;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmatkhau;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.Panel panelLine;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbdatabase;
        private DevComponents.DotNetBar.ButtonX btnTesconnection;
        private DevComponents.DotNetBar.ButtonX btnConnect;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.Editors.ComboItem winAuth;
        private DevComponents.Editors.ComboItem sqlserver;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cmbAuthentication;
    }
}