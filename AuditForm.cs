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
    public partial class AuditForm : Form
    {
        public AuditForm()
        {
            InitializeComponent();
        }

        private void OnCancel(object sender, EventArgs e)
        {
            Close();
        }

        private void OnOK(object sender, EventArgs e)
        {
            var sysPrep = new PrepCommand();
            sysPrep.AuditMode();
            Close();

            //TODO:Audit system command
        }
    }
}
