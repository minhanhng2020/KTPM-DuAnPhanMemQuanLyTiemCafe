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
    public partial class fSoftwareManagement : Form
    {
        public fSoftwareManagement()
        {
            InitializeComponent();
        }

        private void fSoftwareManagement_Load(object sender, EventArgs e)
            //Lúc Form fSoftwareManagement đang được truy cập thì...
        {
            #region Past
            //fLogin l = new fLogin();
            //this.Enabled = false;
            //this.Hide();
            //l.Show();
            //l.Focus();
            #endregion

            this.Show(); //Hiển Thị fSoftwareManagement.
            this.Enabled = false; //Tắt Thao Tác Với fSoftwareManagement.

            fLogin l = new fLogin(); //???
            DialogResult rlt = l.ShowDialog(); //???
            //Kiểm Tra Người Dùng Có Nhấn Nút 'OK' hay không.
            if (rlt == DialogResult.OK) //Nếu có thì:
            {
                this.Enabled = true;
            }
            else //Nếu không thì:
            {
                this.Hide(); //Ẩn Form Đang Chạy (Form Đang Chạy Là...??)
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
