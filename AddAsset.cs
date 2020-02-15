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
            DialogResult = DialogResult.OK;
            var AssetFFU = new WimSystemCommand();
            AssetFFU.Asset = txtAssetEntry.Text;
            AssetFFU.FinalCommand = AssetFFU.Base + AssetFFU.Asset + AssetFFU.End + AssetFFU.Asset;
            var FFUCreate = new ProcessStartInfo();
            FFUCreate.UseShellExecute = true;
            FFUCreate.WorkingDirectory = @"X:\Windows\System32";
            //TODO:Verify directory in startup environment
            FFUCreate.FileName = @"X:\Windows\System32\cmd.exe";
            FFUCreate.Verb = "runas";
            FFUCreate.Arguments = "/c " + AssetFFU.FinalCommand;
            FFUCreate.WindowStyle = ProcessWindowStyle.Minimized;
            Process.Start(FFUCreate);
            Close();
        }

        private void OnCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
