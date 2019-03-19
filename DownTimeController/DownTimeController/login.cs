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
    public partial class login : Telerik.WinControls.UI.RadForm
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           

            int log;

            UserExtender.usuario =  UserExtender.usuario.login(txtUser.Text, txtPassword.Text);
            log = UserExtender.usuario.LogginStatus;

            if (log == 1)
            {
                this.Close();
            }
            else if (log == 0)
            {
                RadMessageBox.SetThemeName("Office2010Black");
                DialogResult result =  RadMessageBox.Show("The password is incorrect. Please type again!", "Wrong Password", MessageBoxButtons.OK, RadMessageIcon.Info);

                if (result.ToString() == "OK")
                {
                    txtPassword.Text = "";

                }
                
            }
            else if (log == 2)
            {
                RadMessageBox.SetThemeName("Office2010Black");
                DialogResult result = RadMessageBox.Show("This user doesn't exist. Please, verify username", "Wrong username", MessageBoxButtons.OK, RadMessageIcon.Info);

                if (result.ToString() == "OK")
                {
                    txtPassword.Text = "";
                    txtUser.Text = "";

                }
            }

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
