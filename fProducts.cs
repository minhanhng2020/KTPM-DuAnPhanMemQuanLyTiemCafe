﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DuAnPhanMemQuanLyTiemCafe
{
    public partial class fProducts : Form
    {
        public fProducts()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();        
        }

        private void đóngChứcNăngNàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
