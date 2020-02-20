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
            modelBox.Items.AddRange(System.IO.File.ReadAllLines("ModelList.txt"));
        }
        
        private void OnOK(object sender, EventArgs e)
        {
            //TODO:Model database
            //TODO:Display Confirmation
            var modelFFU = new CaptureCommand();
            modelFFU.RestoreModel(modelBox.Text);

            Close();
            //TODO:Something, database query to pre-fill model names
        }

        private void OnCancel(object sender, EventArgs e)
        {
            Close();
        }
    }
}
