namespace DownTimeController
{
    partial class FindErrorCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindErrorCode));
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtErrorCode = new Telerik.WinControls.UI.RadTextBox();
            this.office2007BlackTheme1 = new Telerik.WinControls.Themes.Office2007BlackTheme();
            this.grvErrorCode = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtErrorCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvErrorCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.txtErrorCode);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Find Error Code";
            this.radGroupBox1.Location = new System.Drawing.Point(13, 13);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(552, 99);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Find Error Code";
            this.radGroupBox1.ThemeName = "Office2007Black";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(14, 36);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(62, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Error Code:";
            // 
            // txtErrorCode
            // 
            this.txtErrorCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtErrorCode.Location = new System.Drawing.Point(81, 36);
            this.txtErrorCode.Name = "txtErrorCode";
            this.txtErrorCode.Size = new System.Drawing.Size(443, 20);
            this.txtErrorCode.TabIndex = 0;
            this.txtErrorCode.TabStop = false;
            this.txtErrorCode.ThemeName = "Office2010Black";
            this.txtErrorCode.TextChanged += new System.EventHandler(this.txtErrorCode_TextChanged);
            // 
            // grvErrorCode
            // 
            this.grvErrorCode.AllowUserToAddRows = false;
            this.grvErrorCode.AllowUserToDeleteRows = false;
            this.grvErrorCode.AllowUserToOrderColumns = true;
            this.grvErrorCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grvErrorCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvErrorCode.Location = new System.Drawing.Point(13, 119);
            this.grvErrorCode.Name = "grvErrorCode";
            this.grvErrorCode.ReadOnly = true;
            this.grvErrorCode.Size = new System.Drawing.Size(552, 317);
            this.grvErrorCode.TabIndex = 1;
            this.grvErrorCode.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grvErrorCode_MouseDoubleClick);
            // 
            // FindErrorCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 448);
            this.Controls.Add(this.grvErrorCode);
            this.Controls.Add(this.radGroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindErrorCode";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Find Error Code :: Ticket Manager ";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.FindErrorCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtErrorCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvErrorCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtErrorCode;
        private Telerik.WinControls.Themes.Office2007BlackTheme office2007BlackTheme1;
        private System.Windows.Forms.DataGridView grvErrorCode;
    }
}
