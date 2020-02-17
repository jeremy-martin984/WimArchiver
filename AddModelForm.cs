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
            var modelFFU = new WimSystemCommand();
            string temp = txtModelEntry.Text;
            temp = temp.Replace(" ", "_");
            temp = temp.Replace("/", "-");
            temp = temp.ToUpper();
            modelFFU.Model = temp;
            //TODO:Name collision, replacement, true database implementation, text validation
            //TODO:Warning messages,
            bool fileExists = false;
            string[] modelLine = System.IO.File.ReadAllLines("ModelList.txt");
            if(Array.Exists(modelLine, element => element == temp))
            {
                DialogResult result =MessageBox.Show("This model already exists. Do you want to overwrite?", "Image Exists", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
                else fileExists = true;
            }
            if (!fileExists)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("ModelList.txt", true))
                {
                    file.WriteLine(temp);
                }
                modelLine = System.IO.File.ReadAllLines("ModelList.txt");
                Array.Sort(modelLine);

                System.IO.File.WriteAllLines("ModelList.txt", modelLine);
            }
        

        modelFFU.FinalCommand = modelFFU.Base + modelFFU.Model + modelFFU.End + "\"windows\"";
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
        }

        private void OnCancel(object sender, EventArgs e)
        {
            Close();
            //TODO::Something
        }
    }
}
