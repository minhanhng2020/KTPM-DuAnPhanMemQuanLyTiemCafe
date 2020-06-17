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
    public partial class fCustomers : Form
    {
        public fCustomers()
        {
            InitializeComponent();
        }

        private void btnReturnHome_Click(object sender, EventArgs e)
        {
            //this.hide();
            //Dang viet cau lenh dung de goi form fSoftwareManagement...
            this.Close(); //Cai nay dung de thoat chuong trinh tam thoi va se xoa khi xay dung xong chuc nang mo lai form fSoftwareManagement.
        }
    }
}
