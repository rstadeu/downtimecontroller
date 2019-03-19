using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace DownTimeController.DownTimeManager
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem18_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem19_Click(object sender, EventArgs e)
        {
            ErrorCodeLoad err = new ErrorCodeLoad();
            err.MdiParent = this;
            err.Show();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
