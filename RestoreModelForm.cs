﻿using System;
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
    public partial class RestoreModelForm : Form
    {
        public RestoreModelForm()
        {

            InitializeComponent();
        }
        
        private void OnOK(object sender, EventArgs e)
        {

            Close();
            //TODO:Something, database query to pre-fill model names
        }

        private void OnCancel(object sender, EventArgs e)
        {
            Close();
        }
    }
}
