using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.IO;
using System.Reflection;
using DownTimeController.Classes;

namespace DownTimeController
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        bool isLoggado = false;
        bool janela = true;
        int counter = 1;
        
        public RadForm1()
        {
            InitializeComponent();
            UserExtender.usuario = new User();
            AbsolutePath.absPath = new Paths();
            ErrorCodeExtender.erro = new ErrorCode();
            ControlWinExtender.window = new ControlWindow();
            

        }

        private void RadForm1_Load(object sender, EventArgs e)
        {

            string folder = AbsolutePath.absPath.getAbsolutePath();

            if (!(Directory.Exists(folder)))
            {
                Directory.CreateDirectory(folder);

            }
            tsslStation.Text = System.Net.Dns.GetHostName();
           
            User user = new User();

            int i = user.CreateXMLUserFile();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clockImage();
            controlStripMenuStatus(janela);
            disableButtons(UserExtender.usuario, isLoggado);
           
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (janela)
            {
                this.Hide();
                janela = false;
            }
            else
            {
                this.Show();
                janela = true;
            }
            
        }

        private void expandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            janela = true;
        }

        private void minimazeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            janela = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login Login = new login();
            Login.Show();
        }
        private void clockImage()
        {
             tsslTime.Text = String.Format("{0: HH:mm:ss}", DateTime.Now);
            if (counter == 5)
            {
                tsslTime.Image = DownTimeController.Properties.Resources._1393999895_Android_Clock;
                counter += 1;

            }
            else if (counter == 10)
            {
                tsslTime.Image = DownTimeController.Properties.Resources.Android_Clock1;
                counter += 1;
            }
            else if (counter == 15)
            {
                tsslTime.Image = DownTimeController.Properties.Resources.Android_Clock2;
                counter += 1;
            }
            else if (counter == 20)
            {
                tsslTime.Image = DownTimeController.Properties.Resources.Android_Clock3;
                counter = 1;
            }
            counter += 1;
        }

        private void controlStripMenuStatus(bool window)
        {
            if (janela)
            {
                expandToolStripMenuItem.Enabled = false;
                minimazeToolStripMenuItem.Enabled = true;

            }
            else
            {
                expandToolStripMenuItem.Enabled = true;
                minimazeToolStripMenuItem.Enabled = false;
            }
        }

        private void disableButtons(User us, bool loggado)
        {
            if (!loggado)
            {

                if (us.UserID == null)
                {
                    loginToolStripMenuItem.Enabled = true;
                    btnFalseFailure.Enabled = false;
                    btnPrevMan.Enabled = false;
                    btnStop.Enabled = false;
                    logoutToolStripMenuItem.Enabled = false;
                    configurationToolStripMenuItem.Enabled = false;
                    changePasswordToolStripMenuItem.Enabled = false;
                    tsslUser.Text = "";
                }
                else
                {
                    if (us.AccessLevel == "1")
                    {
                        btnFalseFailure.Enabled = true;
                        btnPrevMan.Enabled = true;
                        btnStop.Enabled = true;
                        logoutToolStripMenuItem.Enabled = true;
                        loginToolStripMenuItem.Enabled = false;
                        configurationToolStripMenuItem.Enabled = false;
                        changePasswordToolStripMenuItem.Enabled = true;
                     }
                    else if (us.AccessLevel == "4")
                    {
                        btnFalseFailure.Enabled = true;
                        btnPrevMan.Enabled = true;
                        btnStop.Enabled = true;
                        logoutToolStripMenuItem.Enabled = true;
                        loginToolStripMenuItem.Enabled = false;
                        configurationToolStripMenuItem.Enabled = true;
                        changePasswordToolStripMenuItem.Enabled = true;
                    }
                    else if (us.AccessLevel == "5")
                    {
                        btnFalseFailure.Enabled = true;
                        btnPrevMan.Enabled = true;
                        btnStop.Enabled = true;
                        logoutToolStripMenuItem.Enabled = true;
                        loginToolStripMenuItem.Enabled = false;
                        configurationToolStripMenuItem.Enabled = true;
                        changePasswordToolStripMenuItem.Enabled = true;

                    }

                    tsslUser.Text = us.FirstName.ToString() + " " + us.LastName.ToString();
                    loggado = true;
                }
            }

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           UserExtender.usuario =  UserExtender.usuario.logout();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            OpenTicket ot = new OpenTicket();

            ot.Show();


        }

        private void stationConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void downtimeManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DownTimeManager.RadForm1 manager = new DownTimeManager.RadForm1();
            manager.Show();
        }

    }
}
