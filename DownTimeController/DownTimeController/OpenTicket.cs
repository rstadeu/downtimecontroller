using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using DownTimeController.Classes;

namespace DownTimeController
{
    public partial class OpenTicket : Telerik.WinControls.UI.RadForm
    {
        
        public OpenTicket()
        {
            InitializeComponent();
            ControlWinExtender.window.FirstTime = true;
        }

        private void btnFindErrorCode_Click(object sender, EventArgs e)
        {
            FindErrorCode find = new FindErrorCode();

            find.Show();
        }

        private void OpenTicket_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ErrorCodeExtender.erro.Id > 0)
            {
                if (ControlWinExtender.window.FirstTime)
                {
                    if (!(ControlWinExtender.window.FindErrorCode))
                    {
                        txtErroCode.Text = ErrorCodeExtender.erro.Error_Code;
                        lblDescription.Text = ErrorCodeExtender.erro.Description;
                        ControlWinExtender.window.FirstTime = false;
                    }
                }
            }
        }

        private void radPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
