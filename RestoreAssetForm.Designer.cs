namespace WimArchiver
{
    partial class RestoreAssetForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.instAsset = new System.Windows.Forms.Label();
            this.txtAssetEntry = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.ReturnDirectory = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(366, 313);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 41);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.OnOK);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(586, 313);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 41);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // instAsset
            // 
            this.instAsset.AutoSize = true;
            this.instAsset.Location = new System.Drawing.Point(155, 147);
            this.instAsset.Name = "instAsset";
            this.instAsset.Size = new System.Drawing.Size(210, 25);
            this.instAsset.TabIndex = 9;
            this.instAsset.Text = "Enter Asset Number:";
            // 
            // txtAssetEntry
            // 
            this.txtAssetEntry.Location = new System.Drawing.Point(160, 206);
            this.txtAssetEntry.Name = "txtAssetEntry";
            this.txtAssetEntry.Size = new System.Drawing.Size(433, 31);
            this.txtAssetEntry.TabIndex = 10;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(160, 313);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(105, 41);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.OnBtnBrowse);
            // 
            // ReturnDirectory
            // 
            this.ReturnDirectory.AutoUpgradeEnabled = false;
            this.ReturnDirectory.InitialDirectory = "I:\\";
            this.ReturnDirectory.SupportMultiDottedExtensions = true;
            // 
            // RestoreAssetForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtAssetEntry);
            this.Controls.Add(this.instAsset);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.KeyPreview = true;
            this.Name = "RestoreAssetForm";
            this.Text = "RestoreAssetForm";
            this.Load += new System.EventHandler(this.RestoreAssetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label instAsset;
        private System.Windows.Forms.TextBox txtAssetEntry;
        private System.Windows.Forms.Button btnBrowse;
        internal System.Windows.Forms.OpenFileDialog ReturnDirectory;
    }
}