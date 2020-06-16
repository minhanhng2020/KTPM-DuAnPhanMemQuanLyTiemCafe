using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
//using DAO;

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            //UsersBUS u = new UsersBUS();
            //if (u.Login(username, password))
            //    MessageBox.Show("Đăng Nhập Thành Công.", "Đăng Nhập Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //else
            //    MessageBox.Show("Đã Xảy Ra Lỗi. Vui Lòng Thử Lại...", "Đăng Nhập Hệ Thống", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            CheckLoginBUS c = new CheckLoginBUS();
            if (c.ChckLgn(username, password))
                MessageBox.Show("Đăng Nhập Thành Công.", "Đăng Nhập Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Đã Xảy Ra Lỗi. Vui Lòng Thử Lại...", "Đăng Nhập Hệ Thống", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            }
        }
    }
}