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
    public partial class RestoreAssetForm : Form
    {
        public RestoreAssetForm()
        {
            InitializeComponent();
        }

        private void OnOK(object sender, EventArgs e)
        {
            Close();
            //TODO:Something
        }

        private void OnCancel(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = ReturnDirectory.ShowDialog();
        }
    }
}
