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
            this.baixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarOrdensAbertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharOrdemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrevent = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTemp = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.btnFF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFF.BackgroundImage")));
            this.btnFF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFF.Location = new System.Drawing.Point(133, 42);
            this.btnFF.Name = "btnFF";
            this.btnFF.Size = new System.Drawing.Size(74, 78);
            this.btnFF.TabIndex = 1;
            this.btnFF.Text = "Falha Falsa";
            this.btnFF.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFF.UseVisualStyleBackColor = true;
            this.btnFF.Click += new System.EventHandler(this.btnFF_Click);
            // 
            // btnStopped
            // 
            this.btnStopped.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStopped.BackgroundImage")));
            this.btnStopped.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStopped.Location = new System.Drawing.Point(24, 42);
            this.btnStopped.Name = "btnStopped";
            this.btnStopped.Size = new System.Drawing.Size(74, 78);
            this.btnStopped.TabIndex = 0;
            this.btnStopped.Text = "Parado";
            this.btnStopped.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStopped.UseVisualStyleBackColor = true;
            this.btnStopped.Click += new System.EventHandler(this.button2_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Controle de Chamado :: Flextronics";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expandirToolStripMenuItem,
            this.minimizarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 48);
            // 
            // expandirToolStripMenuItem
            // 
            this.expandirToolStripMenuItem.Name = "expandirToolStripMenuItem";
            this.expandirToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.expandirToolStripMenuItem.Text = "E&xpandir";
            // 
            // minimizarToolStripMenuItem
            // 
            this.minimizarToolStripMenuItem.Name = "minimizarToolStripMenuItem";
            this.minimizarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.minimizarToolStripMenuItem.Text = "Mi&nimizar";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.baixaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(351, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dAToolStripMenuItem,
            this.configurarEstaçãoToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.arquivoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("arquivoToolStripMenuItem.Image")));
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // dAToolStripMenuItem
            // 
            this.dAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dAToolStripMenuItem.Image")));
            this.dAToolStripMenuItem.Name = "dAToolStripMenuItem";
            this.dAToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.dAToolStripMenuItem.Text = "Data&base";
            this.dAToolStripMenuItem.Click += new System.EventHandler(this.dAToolStripMenuItem_Click);
            // 
            // configurarEstaçãoToolStripMenuItem
            // 
            this.configurarEstaçãoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("configurarEstaçãoToolStripMenuItem.Image")));
            this.configurarEstaçãoToolStripMenuItem.Name = "configurarEstaçãoToolStripMenuItem";
            this.configurarEstaçãoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.configurarEstaçãoToolStripMenuItem.Text = "Configurar &Estação";
            this.configurarEstaçãoToolStripMenuItem.Click += new System.EventHandler(this.configurarEstaçãoToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.usuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem.Image")));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.usuariosToolStripMenuItem.Text = "&Usuarios";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loginToolStripMenuItem.Image")));
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loginToolStripMenuItem.Text = "Log &in";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem.Text = "Log &out";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // baixaToolStripMenuItem
            // 
            this.baixaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarOrdensAbertasToolStripMenuItem,
            this.fecharOrdemToolStripMenuItem});
            this.baixaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("baixaToolStripMenuItem.Image")));
            this.baixaToolStripMenuItem.Name = "baixaToolStripMenuItem";
            this.baixaToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.baixaToolStripMenuItem.Text = "&Controle de Ordem";
            this.baixaToolStripMenuItem.Click += new System.EventHandler(this.baixaToolStripMenuItem_Click);
            // 
            // consultarOrdensAbertasToolStripMenuItem
            // 
            this.consultarOrdensAbertasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultarOrdensAbertasToolStripMenuItem.Image")));
            this.consultarOrdensAbertasToolStripMenuItem.Name = "consultarOrdensAbertasToolStripMenuItem";
            this.consultarOrdensAbertasToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.consultarOrdensAbertasToolStripMenuItem.Text = "Con&sultar Ordens Abertas";
            // 
            // fecharOrdemToolStripMenuItem
            // 
            this.fecharOrdemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fecharOrdemToolStripMenuItem.Image")));
            this.fecharOrdemToolStripMenuItem.Name = "fecharOrdemToolStripMenuItem";
            this.fecharOrdemToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.fecharOrdemToolStripMenuItem.Text = "&Fechar Ordem";
            // 
            // btnPrevent
            // 
            this.btnPrevent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrevent.BackgroundImage")));
            this.btnPrevent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrevent.Location = new System.Drawing.Point(242, 42);
            this.btnPrevent.Name = "btnPrevent";
            this.btnPrevent.Size = new System.Drawing.Size(74, 78);
            this.btnPrevent.TabIndex = 2;
            this.btnPrevent.Text = "Preventiva";
            this.btnPrevent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrevent.UseVisualStyleBackColor = true;
            this.btnPrevent.Click += new System.EventHandler(this.btnPrevent_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AllowItemReorder = true;
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.tsslTemp,
            this.tsslTime});
            this.statusStrip1.Location = new System.Drawing.Point(334, 132);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(17, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslTemp
            // 
            this.tsslTemp.Name = "tsslTemp";
            this.tsslTemp.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslTime
            // 
            this.tsslTime.Name = "tsslTime";
            this.tsslTime.Size = new System.Drawing.Size(0, 17);
            // 
            // folderBrowserDialog1
            // 
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 154);
            this.ControlBox = false;
            this.Controls.Add(this.btnStopped);
            this.Controls.Add(this.btnPrevent);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnFF);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Controle de chamado :: Flextronics";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btnPrevent;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem expandirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
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
    }
}

