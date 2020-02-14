namespace WimArchiver
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assetBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cDriveOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromAssetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromModelImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cDriveOnlyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.assetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReturnDirectory = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.restoreToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 38);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assetBackupToolStripMenuItem,
            this.modelBackupToolStripMenuItem,
            this.cDriveOnlyToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(271, 44);
            this.newToolStripMenuItem.Text = "&Backup";
            // 
            // assetBackupToolStripMenuItem
            // 
            this.assetBackupToolStripMenuItem.Name = "assetBackupToolStripMenuItem";
            this.assetBackupToolStripMenuItem.Size = new System.Drawing.Size(302, 44);
            this.assetBackupToolStripMenuItem.Text = "&Asset Backup";
            this.assetBackupToolStripMenuItem.Click += new System.EventHandler(this.AddAsset);
            // 
            // modelBackupToolStripMenuItem
            // 
            this.modelBackupToolStripMenuItem.Name = "modelBackupToolStripMenuItem";
            this.modelBackupToolStripMenuItem.Size = new System.Drawing.Size(302, 44);
            this.modelBackupToolStripMenuItem.Text = "&Model Backup";
            this.modelBackupToolStripMenuItem.Click += new System.EventHandler(this.AddModel);
            // 
            // cDriveOnlyToolStripMenuItem
            // 
            this.cDriveOnlyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assetToolStripMenuItem,
            this.modelToolStripMenuItem});
            this.cDriveOnlyToolStripMenuItem.Name = "cDriveOnlyToolStripMenuItem";
            this.cDriveOnlyToolStripMenuItem.Size = new System.Drawing.Size(302, 44);
            this.cDriveOnlyToolStripMenuItem.Text = "&C Drive only";
            // 
            // assetToolStripMenuItem
            // 
            this.assetToolStripMenuItem.Name = "assetToolStripMenuItem";
            this.assetToolStripMenuItem.Size = new System.Drawing.Size(218, 44);
            this.assetToolStripMenuItem.Text = "Asset";
            // 
            // modelToolStripMenuItem
            // 
            this.modelToolStripMenuItem.Name = "modelToolStripMenuItem";
            this.modelToolStripMenuItem.Size = new System.Drawing.Size(218, 44);
            this.modelToolStripMenuItem.Text = "Model";
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromAssetToolStripMenuItem,
            this.fromModelImageToolStripMenuItem,
            this.cDriveOnlyToolStripMenuItem1});
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.restoreToolStripMenuItem.Text = "&Restore";
            // 
            // fromAssetToolStripMenuItem
            // 
            this.fromAssetToolStripMenuItem.Name = "fromAssetToolStripMenuItem";
            this.fromAssetToolStripMenuItem.Size = new System.Drawing.Size(353, 44);
            this.fromAssetToolStripMenuItem.Text = "&From Asset Image";
            this.fromAssetToolStripMenuItem.Click += new System.EventHandler(this.RestoreAsset);
            // 
            // fromModelImageToolStripMenuItem
            // 
            this.fromModelImageToolStripMenuItem.Name = "fromModelImageToolStripMenuItem";
            this.fromModelImageToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.fromModelImageToolStripMenuItem.Text = "&From Model Image";
            this.fromModelImageToolStripMenuItem.Click += new System.EventHandler(this.RestoreModel);
            // 
            // cDriveOnlyToolStripMenuItem1
            // 
            this.cDriveOnlyToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assetToolStripMenuItem1,
            this.modelToolStripMenuItem1});
            this.cDriveOnlyToolStripMenuItem1.Name = "cDriveOnlyToolStripMenuItem1";
            this.cDriveOnlyToolStripMenuItem1.Size = new System.Drawing.Size(353, 44);
            this.cDriveOnlyToolStripMenuItem1.Text = "C Drive Only";
            // 
            // assetToolStripMenuItem1
            // 
            this.assetToolStripMenuItem1.Name = "assetToolStripMenuItem1";
            this.assetToolStripMenuItem1.Size = new System.Drawing.Size(218, 44);
            this.assetToolStripMenuItem1.Text = "Asset";
            // 
            // modelToolStripMenuItem1
            // 
            this.modelToolStripMenuItem1.Name = "modelToolStripMenuItem1";
            this.modelToolStripMenuItem1.Size = new System.Drawing.Size(218, 44);
            this.modelToolStripMenuItem1.Text = "Model";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(271, 44);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExit);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.manualToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(85, 36);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(229, 44);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(229, 44);
            this.manualToolStripMenuItem.Text = "&Manual";
            // 
            // ReturnDirectory
            // 
            this.ReturnDirectory.FileOk += new System.ComponentModel.CancelEventHandler(this.ReturnDirectory_FileOk);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 529);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "WimArchiver";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assetBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cDriveOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromAssetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromModelImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cDriveOnlyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem assetToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modelToolStripMenuItem1;
        internal System.Windows.Forms.OpenFileDialog ReturnDirectory;
    }
}

