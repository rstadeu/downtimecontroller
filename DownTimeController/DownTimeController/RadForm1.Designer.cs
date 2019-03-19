namespace DownTimeController
{
    partial class RadForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadForm1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslStation = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.btnStop = new Telerik.WinControls.UI.RadButton();
            this.btnFalseFailure = new Telerik.WinControls.UI.RadButton();
            this.btnPrevMan = new Telerik.WinControls.UI.RadButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.expandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimazeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downtimeManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.stationConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.radioButtonArray1 = new Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFalseFailure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevMan)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonArray1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.AllowMerge = false;
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslUser,
            this.tsslStation,
            this.tsslTime});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 136);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(449, 37);
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslUser
            // 
            this.tsslUser.Image = global::DownTimeController.Properties.Resources.User32;
            this.tsslUser.Name = "tsslUser";
            this.tsslUser.Size = new System.Drawing.Size(32, 32);
            // 
            // tsslStation
            // 
            this.tsslStation.Image = global::DownTimeController.Properties.Resources._1393747260_package_system1;
            this.tsslStation.Name = "tsslStation";
            this.tsslStation.Size = new System.Drawing.Size(32, 32);
            // 
            // tsslTime
            // 
            this.tsslTime.Image = global::DownTimeController.Properties.Resources._1393999895_Android_Clock;
            this.tsslTime.Name = "tsslTime";
            this.tsslTime.Size = new System.Drawing.Size(32, 32);
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btnStop.Image = global::DownTimeController.Properties.Resources.Stop77;
            this.btnStop.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStop.ImageScalingSize = new System.Drawing.Size(128, 128);
            this.btnStop.Location = new System.Drawing.Point(12, 38);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(109, 78);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "radButton1";
            this.btnStop.ThemeName = "Office2010Black";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnFalseFailure
            // 
            this.btnFalseFailure.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btnFalseFailure.Image = global::DownTimeController.Properties.Resources.pill77;
            this.btnFalseFailure.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFalseFailure.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFalseFailure.Location = new System.Drawing.Point(169, 38);
            this.btnFalseFailure.Name = "btnFalseFailure";
            this.btnFalseFailure.Size = new System.Drawing.Size(109, 78);
            this.btnFalseFailure.TabIndex = 2;
            this.btnFalseFailure.Text = "radButton2";
            this.btnFalseFailure.ThemeName = "Office2010Black";
            // 
            // btnPrevMan
            // 
            this.btnPrevMan.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btnPrevMan.Image = global::DownTimeController.Properties.Resources.Box77;
            this.btnPrevMan.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrevMan.Location = new System.Drawing.Point(326, 38);
            this.btnPrevMan.Name = "btnPrevMan";
            this.btnPrevMan.Size = new System.Drawing.Size(109, 78);
            this.btnPrevMan.TabIndex = 2;
            this.btnPrevMan.Text = "radButton3";
            this.btnPrevMan.ThemeName = "Office2010Black";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expandToolStripMenuItem,
            this.minimazeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 48);
            // 
            // expandToolStripMenuItem
            // 
            this.expandToolStripMenuItem.Image = global::DownTimeController.Properties.Resources._1394262136_expand;
            this.expandToolStripMenuItem.Name = "expandToolStripMenuItem";
            this.expandToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.expandToolStripMenuItem.Text = "Ex&pand";
            this.expandToolStripMenuItem.Click += new System.EventHandler(this.expandToolStripMenuItem_Click);
            // 
            // minimazeToolStripMenuItem
            // 
            this.minimazeToolStripMenuItem.Image = global::DownTimeController.Properties.Resources.Minimaze;
            this.minimazeToolStripMenuItem.Name = "minimazeToolStripMenuItem";
            this.minimazeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.minimazeToolStripMenuItem.Text = "Minima&ze";
            this.minimazeToolStripMenuItem.Click += new System.EventHandler(this.minimazeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.userToolStripMenuItem,
            this.ticketControlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(449, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downtimeManagerToolStripMenuItem,
            this.toolStripSeparator1,
            this.stationConfigurationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "&Configuration";
            // 
            // downtimeManagerToolStripMenuItem
            // 
            this.downtimeManagerToolStripMenuItem.Image = global::DownTimeController.Properties.Resources._1393747266__desktop1;
            this.downtimeManagerToolStripMenuItem.Name = "downtimeManagerToolStripMenuItem";
            this.downtimeManagerToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.downtimeManagerToolStripMenuItem.Text = "Downtime &Manager";
            this.downtimeManagerToolStripMenuItem.Click += new System.EventHandler(this.downtimeManagerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // stationConfigurationToolStripMenuItem
            // 
            this.stationConfigurationToolStripMenuItem.Image = global::DownTimeController.Properties.Resources._1393747260_package_system1;
            this.stationConfigurationToolStripMenuItem.Name = "stationConfigurationToolStripMenuItem";
            this.stationConfigurationToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.stationConfigurationToolStripMenuItem.Text = "&Station Configuration";
            this.stationConfigurationToolStripMenuItem.Click += new System.EventHandler(this.stationConfigurationToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "&User";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Image = global::DownTimeController.Properties.Resources._1394002464_Login_in;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.loginToolStripMenuItem.Text = "Log &in";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::DownTimeController.Properties.Resources._1394002571_Login_out;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.logoutToolStripMenuItem.Text = "Log &out";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::DownTimeController.Properties.Resources._1394002668_key;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "C&hange Password";
            // 
            // ticketControlToolStripMenuItem
            // 
            this.ticketControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeTicketToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.ticketControlToolStripMenuItem.Name = "ticketControlToolStripMenuItem";
            this.ticketControlToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.ticketControlToolStripMenuItem.Text = "&Ticket Control";
            // 
            // closeTicketToolStripMenuItem
            // 
            this.closeTicketToolStripMenuItem.Image = global::DownTimeController.Properties.Resources._1393747002_configure1;
            this.closeTicketToolStripMenuItem.Name = "closeTicketToolStripMenuItem";
            this.closeTicketToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.closeTicketToolStripMenuItem.Text = "C&lose Ticket";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Image = global::DownTimeController.Properties.Resources.order_history;
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.historyToolStripMenuItem.Text = "&History";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Image = global::DownTimeController.Properties.Resources._1393747439_Stats;
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.reportToolStripMenuItem.Text = "Re&port";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Ticket Manager";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 173);
            this.Controls.Add(this.btnFalseFailure);
            this.Controls.Add(this.btnPrevMan);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Ticket Manager";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFalseFailure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevMan)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonArray1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private Telerik.WinControls.UI.RadButton btnStop;
        private Telerik.WinControls.UI.RadButton btnFalseFailure;
        private Telerik.WinControls.UI.RadButton btnPrevMan;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslStation;
        private System.Windows.Forms.ToolStripStatusLabel tsslTime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downtimeManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem stationConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private System.Windows.Forms.ToolStripMenuItem expandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimazeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray radioButtonArray1;
    }
}
