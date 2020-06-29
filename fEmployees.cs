using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;
using DAO;
using System.Data.SqlClient;

namespace DuAnPhanMemQuanLyTiemCafe
{
    public partial class fEmployees : Form
    {
        EmployeeBUS eBUS = new EmployeeBUS();

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
            fSoftwareManagement f = new fSoftwareManagement();
            f.Show();
            this.Hide();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            string Id = txtEmpID.Text;
            string Name = txtEmpName.Text;
            string Address = txtEmpAddress.Text;

            Employee s = new Employee(Id, Name, Address);

            int rsl = eBUS.Add(s);

            //if (txtSplID.Text != null || txtSplID.Text != "" || txtSplID.ToString() != null || txtSplID.ToString() != "")
            //{
            //    if (cmbSplName.Text != null || cmbSplName.Text != "")
            //    {
            //        if (rsl > 0)
            //        {
            //            List<Supplier> list = sBUS.LoadSupplier();
            //            dgvSupplier.DataSource = list;
            //            MessageBox.Show("Thêm nhà cung cấp mới thành công!");
            //        }
            //        else
            //            MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại...");
            //    }
            //    else
            //        MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại...");
            //}
            //else
            //    MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại...");
        }
    }
}
