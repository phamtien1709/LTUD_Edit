using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using GalaBuilding.Controller;
using GalaBuilding.Component;



namespace GalaBuilding.Component
{
    public partial class frmSplash :Office2007Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }
       int i;
        private void frmFlash_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 2)
                this.Dispose();
        }
    }
}