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
        /*
        private void DisplayConfirm(string message)
        {
            MessageBox.Show(message, "Confirm", MessageBoxButtons.YesNo);
        }
        */
        private void OnOK(object sender, EventArgs e)
        {
            
            bool fileExists = false;
            var modelFFU = new CaptureCommand();
            string[] modelLine = System.IO.File.ReadAllLines("I:\\images\\ModelList.txt");
            if(modelFFU.CheckIfExists(modelLine, txtModelEntry.Text, out var message, out var temp))
            {
                DialogResult result = MessageBox.Show(message, "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return;
                else
                {
                    fileExists = true;
                    modelFFU.AddModel(temp);
                }
            }
            if (!fileExists)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("I:\\images\\ModelList.txt", true))
                {
                    file.WriteLine(temp);
                }
                using (System.IO.StreamWriter fileStar = new System.IO.StreamWriter("I:\\images\\ModelListStar.txt", true))
                {
                    
                    fileStar.WriteLine(modelFFU.StarSafe(temp));
                }
                modelLine = System.IO.File.ReadAllLines("I:\\images\\ModelList.txt");
                Array.Sort(modelLine);

                System.IO.File.WriteAllLines("I:\\images\\ModelList.txt", modelLine);
                modelFFU.AddModel(temp);

                modelLine = System.IO.File.ReadAllLines("I:\\images\\ModelListStar.txt");
                Array.Sort(modelLine);

                System.IO.File.WriteAllLines("I:\\images\\ModelListStar.txt", modelLine);
            }
            Close();
        }

        private void OnCancel(object sender, EventArgs e)
        {
            Close();
        }
    }
}
