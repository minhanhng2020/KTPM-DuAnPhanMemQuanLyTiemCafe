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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResetTextboxData_Click(object sender, EventArgs e)
        {
            //Xóa Dòng Chữ Trên Tiêu Đề: this.ResetText();
            
            /*Xóa Dữ Liệu Đã Nhập.*/
            if(txtPassword != null || txtUsername != null)
            {
                if (txtUsername != null)
                {
                    txtUsername.ResetText();
                    txtPassword.ResetText();
                }
                else
                {
                    txtPassword.ResetText();
                }
            }
        }
    }
}
