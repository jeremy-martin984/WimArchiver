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
    public partial class AddModelForm : Form
    {
        public AddModelForm()
        {
            InitializeComponent();
        }

        private void OnOK(object sender, EventArgs e)
        {
            //TODO:Model database
            //TODO:Display Confirmation
            var modelFFU = new WimSystemCommand();
            modelFFU.Model = txtModelEntry.Text;
            modelFFU.FinalCommand = modelFFU.Base + modelFFU.Model + modelFFU.End + modelFFU.Model;
            var FFUCreate = new ProcessStartInfo();
            FFUCreate.UseShellExecute = true;
            FFUCreate.WorkingDirectory = @"C:\Windows\System32";
            //TODO:Verify directory in startup environment
            FFUCreate.FileName = @"C:\Windows\System32\cmd.exe";
            FFUCreate.Verb = "runas";
            FFUCreate.Arguments = "/k " + modelFFU.FinalCommand;
            FFUCreate.WindowStyle = ProcessWindowStyle.Normal;
            Process.Start(FFUCreate);

            Close();
        }

        private void OnCancel(object sender, EventArgs e)
        {
            Close();
            //TODO::Something
        }
    }
}
