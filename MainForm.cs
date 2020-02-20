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

namespace WimArchiver
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //TODO:When ran from normally, Handle unattend processing, sysprep commands, offline image processing/updating
            //TODO:When ran from inside windows PE, windows RE update/WIM capture, error reporting, 32-bit versions
            //TODO:Alternate directories, off-load functions to classes
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

        private void AuditMode(object sender, EventArgs e)
        {
            AuditForm auditForm = new AuditForm();
            auditForm.ShowDialog(this);
        }

        private void OOBEMode(object sender, EventArgs e)
        {
            OOBEForm OOBE = new OOBEForm();
            OOBE.ShowDialog(this);
        }

        private void DriveMap(object sender, EventArgs e)
        {
            var netStart = new NetStart();
            netStart.CheckForIDrive(out string error);
            if (error != null)
            {
                MessageBox.Show(error, "Drive not Mapped", MessageBoxButtons.OK);
                Backup.Enabled = false;
                Restore.Enabled = false;
            }
            else
            {
                Backup.Enabled = true;
                Restore.Enabled = true;
            }

        }

        private void file_Click(object sender, EventArgs e)
        {
            var netStart = new NetStart();
            netStart.CheckForIDrive(out string error);
            if (error != null)
            {
                //MessageBox.Show(error, "Drive not Mapped", MessageBoxButtons.OK);
                Backup.Enabled = false;
                Restore.Enabled = false;
            }
        }
    }
}
