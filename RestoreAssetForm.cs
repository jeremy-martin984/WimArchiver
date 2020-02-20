using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using WimArchiver.Command;

namespace WimArchiver
{
    public partial class RestoreAssetForm : Form
    {
        public RestoreAssetForm()
        {
            InitializeComponent();
        }

        private void OnOK(object sender, EventArgs e)
        {
            string temp = txtAssetEntry.Text;
            bool success = Int32.TryParse(temp, out _);
            if(!success)
            {
                MessageBox.Show("This method is for restoring specific assets and is not suitable for generic images. Please select a different image", "Warning", MessageBoxButtons.OK);
                return;
            }
            else
            {
                var asset = new CaptureCommand();
                asset.RestoreAsset(txtAssetEntry.Text);
                Close();
            }
            //TODO:Fix browse button, display confirmations.
        }

        private void OnCancel(object sender, EventArgs e)
        {
            Close();
        }

        private void OnBtnBrowse(object sender, EventArgs e)
        {
            string temp;
            ReturnDirectory.ShowDialog();
            temp = ReturnDirectory.SafeFileName;
            temp = temp.Remove(7);
            bool success = Int32.TryParse(temp, out _);
            if (success)
            {
                txtAssetEntry.Text = temp;
            }
            else
            {
                MessageBox.Show("This method is for restoring specific assets and is not suitable for generic images. Please select a different image", "Warning", MessageBoxButtons.OK);
            }
        }

        private void RestoreAssetForm_Load(object sender, EventArgs e)
        {

        }
    }

}
