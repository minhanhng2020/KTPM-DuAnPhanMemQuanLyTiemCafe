using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Chen them cac muc tu tao.
using System.Data.SqlClient;
using BUS;
using DTO;

namespace DuAnPhanMemQuanLyTiemCafe
{
    public partial class fSuppliers : Form
    {
        SupplierBUS sBUS = new SupplierBUS();

        public fSuppliers()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        private void fSuppliers_Load(object sender, EventArgs e)
        {
            List<Supplier> l = sBUS.LoadSupplier();
            dgvSupplier.DataSource = l;
        }

        private void btnAddSup_Click(object sender, EventArgs e)
        {
            string Id = txtSplID.Text;
            string Name = cmbSplName.Text;
            string Address = cmbSplAddr.Text;

            Supplier s = new Supplier(Id, Name, Address);

            int rsl = sBUS.Add(s);

            if (Id != null || Id != "")
            {
                if (Name != null || Name != "")
                {
                    if (rsl > 0)
                    {
                        List<Supplier> list = sBUS.LoadSupplier();
                        dgvSupplier.DataSource = list;
                        MessageBox.Show("Thêm nhà cung cấp mới thành công!");
                    }
                    else
                        MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại...");
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại...");
            }
            else
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại...");
        }
        
        //private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int index = dgvSupplier.CurrentCell.RowIndex;
        //    txtSplID = dgvSupplier.Rows[index].Cells["IdColumn"].Value.ToString();
        //    Cmb.Text = dgvSupplier.Rows[index].Cells["NameColumn"].Value.ToString();
        //    txtAddress.Text = dgvSupplier.Rows[index].Cells["AddressColumn"].Value.ToString();
        //}

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReturnHome_Click(object sender, EventArgs e)
        {
            fSoftwareManagement sm = new fSoftwareManagement();
            sm.Show();
            this.Hide();
        }

        private void btnEditSup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức Năng Đang Được Bổ Sung, Vui Lòng Quay Lại Sau.");
        }

        private void btnRemSup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức Năng Đang Được Bổ Sung, Vui Lòng Quay Lại Sau.");
        }
    }
}
