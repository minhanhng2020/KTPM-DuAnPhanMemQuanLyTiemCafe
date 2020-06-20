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
    public partial class fSoftwareManagement : Form
    {
        public fSoftwareManagement()
        {
            InitializeComponent();
        }

        private void fSoftwareManagement_Load(object sender, EventArgs e)
        {
            #region Past
            //fLogin l = new fLogin();
            //this.Enabled = false;
            //this.Hide();
            //l.Show();
            //l.Focus();
            #endregion

            this.Show();
            this.Enabled = false;

            fLogin l = new fLogin();
            DialogResult rlt = l.ShowDialog();
            if (rlt == DialogResult.OK)
            {
                this.Enabled = true;
            }
            else
            {
                Application.Exit();
            }

        }

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            fSuppliers s = new fSuppliers();
            s.Show();
            this.Hide();
        }
    }
}
