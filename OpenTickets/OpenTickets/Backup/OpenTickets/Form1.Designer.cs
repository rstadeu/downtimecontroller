namespace OpenTickets
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnFF = new System.Windows.Forms.Button();
            this.btnStopped = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.expandirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarEstaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarOrdensAbertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharOrdemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abirChamadoOutraEstacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPreventiva = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslTemp = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblssStation = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dsPath = new System.Data.DataSet();
            this.dsDownTimeControl = new System.Data.DataSet();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDownTimeControl)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFF
            // 
            this.btnFF.AccessibleDescription = null;
            this.btnFF.AccessibleName = null;
            resources.ApplyResources(this.btnFF, "btnFF");
            this.btnFF.Font = null;
            this.btnFF.Name = "btnFF";
            this.btnFF.UseVisualStyleBackColor = true;
            this.btnFF.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStopped
            // 
            this.btnStopped.AccessibleDescription = null;
            this.btnStopped.AccessibleName = null;
            resources.ApplyResources(this.btnStopped, "btnStopped");
            this.btnStopped.Font = null;
            this.btnStopped.Name = "btnStopped";
            this.btnStopped.UseVisualStyleBackColor = true;
            this.btnStopped.Click += new System.EventHandler(this.btnStopped_Click);
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AccessibleDescription = null;
            this.contextMenuStrip1.AccessibleName = null;
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.BackgroundImage = null;
            this.contextMenuStrip1.Font = null;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expandirToolStripMenuItem,
            this.minimizarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // expandirToolStripMenuItem
            // 
            this.expandirToolStripMenuItem.AccessibleDescription = null;
            this.expandirToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.expandirToolStripMenuItem, "expandirToolStripMenuItem");
            this.expandirToolStripMenuItem.BackgroundImage = null;
            this.expandirToolStripMenuItem.Name = "expandirToolStripMenuItem";
            this.expandirToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.expandirToolStripMenuItem.Click += new System.EventHandler(this.expandirToolStripMenuItem_Click);
            // 
            // minimizarToolStripMenuItem
            // 
            this.minimizarToolStripMenuItem.AccessibleDescription = null;
            this.minimizarToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.minimizarToolStripMenuItem, "minimizarToolStripMenuItem");
            this.minimizarToolStripMenuItem.BackgroundImage = null;
            this.minimizarToolStripMenuItem.Name = "minimizarToolStripMenuItem";
            this.minimizarToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.minimizarToolStripMenuItem.Click += new System.EventHandler(this.minimizarToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleDescription = null;
            this.menuStrip1.AccessibleName = null;
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackgroundImage = null;
            this.menuStrip1.Font = null;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.baixaToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.AccessibleDescription = null;
            this.arquivoToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.arquivoToolStripMenuItem, "arquivoToolStripMenuItem");
            this.arquivoToolStripMenuItem.BackgroundImage = null;
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dAToolStripMenuItem,
            this.configurarEstaçãoToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // dAToolStripMenuItem
            // 
            this.dAToolStripMenuItem.AccessibleDescription = null;
            this.dAToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.dAToolStripMenuItem, "dAToolStripMenuItem");
            this.dAToolStripMenuItem.BackgroundImage = null;
            this.dAToolStripMenuItem.Name = "dAToolStripMenuItem";
            this.dAToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.dAToolStripMenuItem.Click += new System.EventHandler(this.dAToolStripMenuItem_Click);
            // 
            // configurarEstaçãoToolStripMenuItem
            // 
            this.configurarEstaçãoToolStripMenuItem.AccessibleDescription = null;
            this.configurarEstaçãoToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.configurarEstaçãoToolStripMenuItem, "configurarEstaçãoToolStripMenuItem");
            this.configurarEstaçãoToolStripMenuItem.BackgroundImage = null;
            this.configurarEstaçãoToolStripMenuItem.Name = "configurarEstaçãoToolStripMenuItem";
            this.configurarEstaçãoToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.configurarEstaçãoToolStripMenuItem.Click += new System.EventHandler(this.configurarEstaçãoToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.AccessibleDescription = null;
            this.exitToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.BackgroundImage = null;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.AccessibleDescription = null;
            this.usuariosToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.usuariosToolStripMenuItem, "usuariosToolStripMenuItem");
            this.usuariosToolStripMenuItem.BackgroundImage = null;
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.trocarSenhaToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.AccessibleDescription = null;
            this.loginToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.loginToolStripMenuItem, "loginToolStripMenuItem");
            this.loginToolStripMenuItem.BackgroundImage = null;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.AccessibleDescription = null;
            this.logoutToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.logoutToolStripMenuItem, "logoutToolStripMenuItem");
            this.logoutToolStripMenuItem.BackgroundImage = null;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // trocarSenhaToolStripMenuItem
            // 
            this.trocarSenhaToolStripMenuItem.AccessibleDescription = null;
            this.trocarSenhaToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.trocarSenhaToolStripMenuItem, "trocarSenhaToolStripMenuItem");
            this.trocarSenhaToolStripMenuItem.BackgroundImage = null;
            this.trocarSenhaToolStripMenuItem.Name = "trocarSenhaToolStripMenuItem";
            this.trocarSenhaToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.trocarSenhaToolStripMenuItem.Click += new System.EventHandler(this.trocarSenhaToolStripMenuItem_Click);
            // 
            // baixaToolStripMenuItem
            // 
            this.baixaToolStripMenuItem.AccessibleDescription = null;
            this.baixaToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.baixaToolStripMenuItem, "baixaToolStripMenuItem");
            this.baixaToolStripMenuItem.BackgroundImage = null;
            this.baixaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarOrdensAbertasToolStripMenuItem,
            this.fecharOrdemToolStripMenuItem,
            this.abirChamadoOutraEstacaoToolStripMenuItem});
            this.baixaToolStripMenuItem.Name = "baixaToolStripMenuItem";
            this.baixaToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.baixaToolStripMenuItem.Click += new System.EventHandler(this.baixaToolStripMenuItem_Click);
            // 
            // consultarOrdensAbertasToolStripMenuItem
            // 
            this.consultarOrdensAbertasToolStripMenuItem.AccessibleDescription = null;
            this.consultarOrdensAbertasToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.consultarOrdensAbertasToolStripMenuItem, "consultarOrdensAbertasToolStripMenuItem");
            this.consultarOrdensAbertasToolStripMenuItem.BackgroundImage = null;
            this.consultarOrdensAbertasToolStripMenuItem.Name = "consultarOrdensAbertasToolStripMenuItem";
            this.consultarOrdensAbertasToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.consultarOrdensAbertasToolStripMenuItem.Click += new System.EventHandler(this.consultarOrdensAbertasToolStripMenuItem_Click);
            // 
            // fecharOrdemToolStripMenuItem
            // 
            this.fecharOrdemToolStripMenuItem.AccessibleDescription = null;
            this.fecharOrdemToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.fecharOrdemToolStripMenuItem, "fecharOrdemToolStripMenuItem");
            this.fecharOrdemToolStripMenuItem.BackgroundImage = null;
            this.fecharOrdemToolStripMenuItem.Name = "fecharOrdemToolStripMenuItem";
            this.fecharOrdemToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.fecharOrdemToolStripMenuItem.Click += new System.EventHandler(this.fecharOrdemToolStripMenuItem_Click);
            // 
            // abirChamadoOutraEstacaoToolStripMenuItem
            // 
            this.abirChamadoOutraEstacaoToolStripMenuItem.AccessibleDescription = null;
            this.abirChamadoOutraEstacaoToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.abirChamadoOutraEstacaoToolStripMenuItem, "abirChamadoOutraEstacaoToolStripMenuItem");
            this.abirChamadoOutraEstacaoToolStripMenuItem.BackgroundImage = null;
            this.abirChamadoOutraEstacaoToolStripMenuItem.Name = "abirChamadoOutraEstacaoToolStripMenuItem";
            this.abirChamadoOutraEstacaoToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.abirChamadoOutraEstacaoToolStripMenuItem.Click += new System.EventHandler(this.abirChamadoOutraEstacaoToolStripMenuItem_Click);
            // 
            // btnPreventiva
            // 
            this.btnPreventiva.AccessibleDescription = null;
            this.btnPreventiva.AccessibleName = null;
            resources.ApplyResources(this.btnPreventiva, "btnPreventiva");
            this.btnPreventiva.Font = null;
            this.btnPreventiva.Name = "btnPreventiva";
            this.btnPreventiva.UseVisualStyleBackColor = true;
            this.btnPreventiva.Click += new System.EventHandler(this.btnPreventiva_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AccessibleDescription = null;
            this.statusStrip1.AccessibleName = null;
            this.statusStrip1.AllowItemReorder = true;
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.BackgroundImage = null;
            this.statusStrip1.Font = null;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTemp,
            this.lblssStation,
            this.tsslTime});
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // tsslTemp
            // 
            this.tsslTemp.AccessibleDescription = null;
            this.tsslTemp.AccessibleName = null;
            resources.ApplyResources(this.tsslTemp, "tsslTemp");
            this.tsslTemp.BackgroundImage = null;
            this.tsslTemp.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslTemp.Name = "tsslTemp";
            // 
            // lblssStation
            // 
            this.lblssStation.AccessibleDescription = null;
            this.lblssStation.AccessibleName = null;
            resources.ApplyResources(this.lblssStation, "lblssStation");
            this.lblssStation.BackgroundImage = null;
            this.lblssStation.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblssStation.Name = "lblssStation";
            // 
            // tsslTime
            // 
            this.tsslTime.AccessibleDescription = null;
            this.tsslTime.AccessibleName = null;
            resources.ApplyResources(this.tsslTime, "tsslTime");
            this.tsslTime.BackgroundImage = null;
            this.tsslTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslTime.Name = "tsslTime";
            // 
            // folderBrowserDialog1
            // 
            resources.ApplyResources(this.folderBrowserDialog1, "folderBrowserDialog1");
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // dsPath
            // 
            this.dsPath.DataSetName = "NewDataSet";
            // 
            // dsDownTimeControl
            // 
            this.dsDownTimeControl.DataSetName = "NewDataSet";
            // 
            // Form1
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.ControlBox = false;
            this.Controls.Add(this.btnStopped);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnPreventiva);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnFF);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDownTimeControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFF;
        private System.Windows.Forms.Button btnStopped;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnPreventiva;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem expandirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem dAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarEstaçãoToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Data.DataSet dsPath;
        private System.Data.DataSet dsDownTimeControl;
        private System.Windows.Forms.ToolStripMenuItem consultarOrdensAbertasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharOrdemToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tsslTemp;
        private System.Windows.Forms.ToolStripStatusLabel tsslTime;
        private System.Windows.Forms.ToolStripStatusLabel lblssStation;
        private System.Windows.Forms.ToolStripMenuItem trocarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abirChamadoOutraEstacaoToolStripMenuItem;
    }
}

