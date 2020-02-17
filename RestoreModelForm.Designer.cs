namespace WimArchiver
{
    partial class RestoreModelForm
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
            this.modelBox = new System.Windows.Forms.ComboBox();
            this.modelNameListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instAsset = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.modelNameListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // modelBox
            // 
            this.modelBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.modelBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.modelBox.FormattingEnabled = true;
            this.modelBox.Location = new System.Drawing.Point(254, 220);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(367, 33);
            this.modelBox.TabIndex = 0;
            // 
            // instAsset
            // 
            this.instAsset.AutoSize = true;
            this.instAsset.Location = new System.Drawing.Point(249, 165);
            this.instAsset.Name = "instAsset";
            this.instAsset.Size = new System.Drawing.Size(205, 25);
            this.instAsset.TabIndex = 4;
            this.instAsset.Text = "Select Model Name:";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(424, 331);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 41);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.OnOK);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(582, 331);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 41);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // RestoreModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.instAsset);
            this.Controls.Add(this.modelBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RestoreModelForm";
            this.ShowIcon = false;
            this.Text = "Model Name";
            ((System.ComponentModel.ISupportInitialize)(this.modelNameListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label instAsset;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox modelBox;
        private System.Windows.Forms.BindingSource modelNameListBindingSource;
    }
}