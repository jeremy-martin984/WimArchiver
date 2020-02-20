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
    public partial class OOBEForm : Form
    {
        public OOBEForm()
        {
            InitializeComponent();
        }

        private void OnOK(object sender, EventArgs e)
        {
            var oobeCMD = new PrepCommand();
            if (txtUnattendDIR.Text == "")
                oobeCMD.OOBE("");
            else
            oobeCMD.OOBE(" /unattend:" + txtUnattendDIR.Text);
        }

        private void OnCancel(object sender, EventArgs e)
        {
            Close();
        }

        private void UnattendBrowse(object sender, EventArgs e)
        {
            findUnattend.ShowDialog();
            txtUnattendDIR.Text = findUnattend.FileName;//TODO:file restrictions, input validation
        }
    }
}
