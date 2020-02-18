using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WimArchiver.Command;
using System.Diagnostics;

namespace WimArchiver
{
    public partial class AddAssetForm : Form
    {
        public AddAssetForm()
        {
            InitializeComponent();
        }

        private void OnOK(object sender, EventArgs e)
        {
            /* This has been moved to WimSystemCommand
            //TODO:Display Confirmation
            var assetFFU = new WimSystemCommand();
            assetFFU.Asset = txtAssetEntry.Text;
            assetFFU.FinalCommand = assetFFU.Base + assetFFU.Asset + assetFFU.End + "\"windows\"";
            //MessageBox.Show(modelFFU.FinalCommand, "info", MessageBoxButtons.OK, MessageBoxIcon.Information); To see command output
            var FFUCreate = new ProcessStartInfo();
            FFUCreate.UseShellExecute = true;
            FFUCreate.WorkingDirectory = @"X:\Windows\System32";
            //TODO:Verify directory in startup environment
            FFUCreate.FileName = @"X:\Windows\System32\cmd.exe";
            FFUCreate.Verb = "runas";
            FFUCreate.Arguments = "/c " + assetFFU.FinalCommand;
            FFUCreate.WindowStyle = ProcessWindowStyle.Maximized; //TODO:indication when it's done
            Process.Start(FFUCreate);
            */
            var create = new WimSystemCommand();
            create.AddAsset(txtAssetEntry.Text);
            Close();
        }

        private void OnCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
