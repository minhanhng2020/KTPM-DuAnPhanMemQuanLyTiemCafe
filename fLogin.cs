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
            //Username: Tên tự đặt (tối đa 15 ký tự), không ký tự đặc biệt, trừ khi dùng email.
            //- Password: Tối thiểu 8 ký tự, yêu cầu có ký tự hoa, ký tự thường, ký tự số, ký tự đặc biệt.
            //- Bắt buộc có cả username và password.
            CheckLoginBUS c = new CheckLoginBUS();
            if (username == null || username == "" || username.Length > 15 || username.Length <= 3)
            {
                DialogResult rlt = MessageBox.Show("Đã Xảy Ra Lỗi. Vui Lòng Thử Lại...", "Đăng Nhập Hệ Thống", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (rlt==DialogResult.Cancel)
                {
                    MessageBox.Show("Tạm Biệt, Hẹn Gặp Lại.");
                    this.Close();
                }
            }
            else
            {
                if (password == null || password == "" || password.Length > 50)
                {
                    DialogResult rlt = MessageBox.Show("Đã Xảy Ra Lỗi. Vui Lòng Thử Lại...", "Đăng Nhập Hệ Thống", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (rlt == DialogResult.Cancel)
                    {
                        MessageBox.Show("Tạm Biệt, Hẹn Gặp Lại.");
                        this.Close();
                    }
                }
                else
                {
                    if (c.ChckLgn(username, password))
                    {
                        MessageBox.Show("Đăng Nhập Thành Công.", "Đăng Nhập Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        fSoftwareManagement s = new fSoftwareManagement();
                        //this.Enabled = false;
                        this.Hide();
                        s.Show();
                        //this.Close();
                    }
                    else
                    {
                        DialogResult rlt = MessageBox.Show("Đã Xảy Ra Lỗi. Vui Lòng Thử Lại...", "Đăng Nhập Hệ Thống", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        if (rlt == DialogResult.Cancel)
                        {
                            MessageBox.Show("Tạm Biệt, Hẹn Gặp Lại.");
                            this.Close();
                        }
                    }
                }
            }   
        }
    }
}