using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace GalaBuilding.Component
{
    public partial class Thaydoichuot : UserControl
    {
        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern IntPtr LoadCursorFromFile(String str);
        private void Thaydoichuot_Load(object sender, EventArgs e)
        {

        }
        public static Cursor Create(string filename)
        {
            IntPtr Cursor = LoadCursorFromFile(filename);

            if (!IntPtr.Zero.Equals(Cursor))
            {
                return new Cursor(Cursor);
            }
            else
            {
                MessageBoxEx.Show("Không thể tạo con trỏ chuột từ file aero.cur!\nCó thể file này bị lỗi hoặc không tồn tại trong hệ thống.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return Cursors.Default;
            }
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.Name = "Thaydoichuot";
            this.Load += new System.EventHandler(this.Thaydoichuot_Load);
            this.ResumeLayout(false);

        }

    }
}
