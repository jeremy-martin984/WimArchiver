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
    public partial class RestoreModelForm : Form
    {
        public RestoreModelForm()
        {

            InitializeComponent();
        }
        
        private void OnOK(object sender, EventArgs e)
        {
            //TODO:Model database
            //TODO:Display Confirmation
            var modelFFU = new WimSystemCommand();
            modelFFU.Model = modelBox.Text;
            modelFFU.FinalCommand = modelFFU.Base2 + modelFFU.Model + modelFFU.EndRestore;
            //MessageBox.Show(modelFFU.FinalCommand, "info", MessageBoxButtons.OK, MessageBoxIcon.Information); To see command output
            var FFUCreate = new ProcessStartInfo();
            FFUCreate.UseShellExecute = true;
            FFUCreate.WorkingDirectory = @"X:\Windows\System32";
            //TODO:Verify directory in startup environment
            FFUCreate.FileName = @"X:\Windows\System32\cmd.exe";
            FFUCreate.Verb = "runas";
            FFUCreate.Arguments = "/c " + modelFFU.FinalCommand;
            FFUCreate.WindowStyle = ProcessWindowStyle.Maximized; //TODO:indication when it's done
            Process.Start(FFUCreate);

            Close();
            //TODO:Something, database query to pre-fill model names
        }

        private void OnCancel(object sender, EventArgs e)
        {
            Close();
        }
    }
}
