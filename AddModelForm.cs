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

        private void DisplayConfirm(string message)
        {
            MessageBox.Show(message, "Confirm", MessageBoxButtons.YesNo);
        }
        private void OnOK(object sender, EventArgs e)
        {
            bool fileExists = false;
            var modelFFU = new WimSystemCommand();
            string[] modelLine = System.IO.File.ReadAllLines("ModelList.txt");
            if(modelFFU.CheckIfExists(modelLine, txtModelEntry.Text, out var message, out var temp))
            {
                DialogResult result = MessageBox.Show(message, "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return;
                else
                {
                    fileExists = true;
                    modelFFU.Model = temp;
                    modelFFU.AddModel(modelFFU.Model);
                }
            }
            modelFFU.Model = temp;
            if (!fileExists)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("ModelList.txt", true))
                {
                    file.WriteLine(temp);
                }
                modelLine = System.IO.File.ReadAllLines("ModelList.txt");
                Array.Sort(modelLine);

                System.IO.File.WriteAllLines("ModelList.txt", modelLine);
                modelFFU.AddModel(modelFFU.Model);
            }
            Close();
        }

        private void OnCancel(object sender, EventArgs e)
        {
            Close();
        }
    }
}
