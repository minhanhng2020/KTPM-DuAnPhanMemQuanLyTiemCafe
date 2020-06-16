using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DuAnPhanMemQuanLyTiemCafe
{
    public partial class fEmployees : Form
    {
        public fEmployees()
        {
            InitializeComponent();
        }

        private void đóngChứcNăngNàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReturnHome_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.Close();
        }
    }
}
