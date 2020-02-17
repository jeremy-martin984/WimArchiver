﻿namespace WimArchiver
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
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromAssetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromModelImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 48);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 44);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assetBackupToolStripMenuItem,
            this.modelBackupToolStripMenuItem});
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
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromAssetToolStripMenuItem,
            this.fromModelImageToolStripMenuItem});
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(271, 44);
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
            this.fromModelImageToolStripMenuItem.Size = new System.Drawing.Size(353, 44);
            this.fromModelImageToolStripMenuItem.Text = "&From Model Image";
            this.fromModelImageToolStripMenuItem.Click += new System.EventHandler(this.RestoreModel);
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
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(85, 44);
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
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromAssetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromModelImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.Label instAsset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

