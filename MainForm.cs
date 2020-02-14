using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WimArchiver
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddAsset(object sender, EventArgs e)
        {
            AddAssetForm asset = new AddAssetForm();
            asset.ShowDialog(this);
        }

        private void AddModel(object sender, EventArgs e)
        {
            AddModelForm model = new AddModelForm();
            model.ShowDialog(this);
        }

        private void OnExit(object sender, EventArgs e)
        {
            Close();
        }

        private void Test(object sender, CancelEventArgs e)
        {

        }

        private void RestoreAsset(object sender, EventArgs e)
        {
            RestoreAssetForm asset = new RestoreAssetForm();
            asset.ShowDialog(this);
        }

        private void ReturnDirectory_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void RestoreModel(object sender, EventArgs e)
        {
            RestoreModelForm model = new RestoreModelForm();
            model.ShowDialog(this);
        }
    }
}
