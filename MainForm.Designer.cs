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
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.Backup = new System.Windows.Forms.ToolStripMenuItem();
            this.assetBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Restore = new System.Windows.Forms.ToolStripMenuItem();
            this.fromAssetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromModelImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sysPrepToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterAuditModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outOfBoxModeOOBEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driveMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instAsset = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.sysPrepToolsToolStripMenuItem,
            this.utilitiesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Backup,
            this.Restore,
            this.exitToolStripMenuItem});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(72, 38);
            this.file.Text = "&File";
            this.file.Click += new System.EventHandler(this.file_Click);
            // 
            // Backup
            // 
            this.Backup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assetBackupToolStripMenuItem,
            this.modelBackupToolStripMenuItem});
            this.Backup.Name = "Backup";
            this.Backup.Size = new System.Drawing.Size(359, 44);
            this.Backup.Text = "&Backup";
            // 
            // assetBackupToolStripMenuItem
            // 
            this.assetBackupToolStripMenuItem.Name = "assetBackupToolStripMenuItem";
            this.assetBackupToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.assetBackupToolStripMenuItem.Text = "&Asset Backup";
            this.assetBackupToolStripMenuItem.Click += new System.EventHandler(this.AddAsset);
            // 
            // modelBackupToolStripMenuItem
            // 
            this.modelBackupToolStripMenuItem.Name = "modelBackupToolStripMenuItem";
            this.modelBackupToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.modelBackupToolStripMenuItem.Text = "&Model Backup";
            this.modelBackupToolStripMenuItem.Click += new System.EventHandler(this.AddModel);
            // 
            // Restore
            // 
            this.Restore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromAssetToolStripMenuItem,
            this.fromModelImageToolStripMenuItem});
            this.Restore.Name = "Restore";
            this.Restore.Size = new System.Drawing.Size(359, 44);
            this.Restore.Text = "&Restore";
            // 
            // fromAssetToolStripMenuItem
            // 
            this.fromAssetToolStripMenuItem.Name = "fromAssetToolStripMenuItem";
            this.fromAssetToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
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
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExit);
            // 
            // sysPrepToolsToolStripMenuItem
            // 
            this.sysPrepToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterAuditModeToolStripMenuItem,
            this.outOfBoxModeOOBEToolStripMenuItem});
            this.sysPrepToolsToolStripMenuItem.Name = "sysPrepToolsToolStripMenuItem";
            this.sysPrepToolsToolStripMenuItem.Size = new System.Drawing.Size(245, 38);
            this.sysPrepToolsToolStripMenuItem.Text = "SysPrep Commands";
            // 
            // enterAuditModeToolStripMenuItem
            // 
            this.enterAuditModeToolStripMenuItem.Name = "enterAuditModeToolStripMenuItem";
            this.enterAuditModeToolStripMenuItem.Size = new System.Drawing.Size(417, 44);
            this.enterAuditModeToolStripMenuItem.Text = "Audit Mode";
            this.enterAuditModeToolStripMenuItem.Click += new System.EventHandler(this.AuditMode);
            // 
            // outOfBoxModeOOBEToolStripMenuItem
            // 
            this.outOfBoxModeOOBEToolStripMenuItem.Name = "outOfBoxModeOOBEToolStripMenuItem";
            this.outOfBoxModeOOBEToolStripMenuItem.Size = new System.Drawing.Size(417, 44);
            this.outOfBoxModeOOBEToolStripMenuItem.Text = "Out of Box Mode (OOBE)";
            this.outOfBoxModeOOBEToolStripMenuItem.Click += new System.EventHandler(this.OOBEMode);
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driveMapToolStripMenuItem});
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(114, 38);
            this.utilitiesToolStripMenuItem.Text = "Utilities";
            // 
            // driveMapToolStripMenuItem
            // 
            this.driveMapToolStripMenuItem.Name = "driveMapToolStripMenuItem";
            this.driveMapToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.driveMapToolStripMenuItem.Text = "Drive Map";
            this.driveMapToolStripMenuItem.Click += new System.EventHandler(this.DriveMap);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.manualToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(85, 38);
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
            // instAsset
            // 
            this.instAsset.AutoSize = true;
            this.instAsset.Location = new System.Drawing.Point(59, 164);
            this.instAsset.Name = "instAsset";
            this.instAsset.Size = new System.Drawing.Size(826, 25);
            this.instAsset.TabIndex = 5;
            this.instAsset.Text = "Welcome to the WimArchiver backup program. Go to File to select a sequence to run" +
    ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(868, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "You can use this program to backup and restore a single asset, or to create a gen" +
    "ericized";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(646, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "image for use on mutliple assets of the same model and hardware.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 529);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.instAsset);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "WimArchiver";
            this.Load += new System.EventHandler(this.DriveMap);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem Backup;
        private System.Windows.Forms.ToolStripMenuItem assetBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Restore;
        private System.Windows.Forms.ToolStripMenuItem fromAssetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromModelImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.Label instAsset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem sysPrepToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterAuditModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outOfBoxModeOOBEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driveMapToolStripMenuItem;
    }
}

