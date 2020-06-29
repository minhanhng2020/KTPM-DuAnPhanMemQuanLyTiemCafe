using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
//using DAO;

namespace DuAnPhanMemQuanLyTiemCafe
{
    public partial class fLogin : Form
    {
        private SqlConnection cn;

        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            string cnStr = "Server = .; Database = CoffeeShop; Integrated Security=True";
            cn = new SqlConnection(cnStr);
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

            #region DAC_TA_YEU_CAU
            //Username: Tên tự đặt (tối đa 15 ký tự), không ký tự đặc biệt, trừ khi dùng email.
            //- Password: Tối thiểu 8 ký tự, yêu cầu có ký tự hoa, ký tự thường, ký tự số, ký tự đặc biệt.
            //- Bắt buộc có cả username và password.
            #endregion

            CheckLoginBUS c = new CheckLoginBUS();
            if (username == null || username == "" || username.Length > 15 || username.Length <= 3)
            {
                DialogResult rlt = MessageBox.Show("Đã Xảy Ra Lỗi. Vui Lòng Thử Lại...", "Đăng Nhập Hệ Thống", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (rlt == DialogResult.Cancel)
                {
                    MessageBox.Show("Tạm Biệt, Hẹn Gặp Lại.");
                    // Application.Exit();
                    this.Close();
                }
            }
            else
            {
                //MAT KHAU CHUA HOP LE
                if (password == null || password == "" || password.Length > 50)
                {
                    DialogResult rlt = MessageBox.Show("Đã Xảy Ra Lỗi. Vui Lòng Thử Lại...", "Đăng Nhập Hệ Thống", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (rlt == DialogResult.Cancel)
                    {
                        MessageBox.Show("Tạm Biệt, Hẹn Gặp Lại.");
                        // Application.Exit();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    if (c.ChckLgn(username, password)) //DANG NHAP THANH CONG.
                    {
                        MessageBox.Show("Đăng Nhập Thành Công.", "Đăng Nhập Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else //DANG NHAP BI LOI.
                    {
                        DialogResult rlt = MessageBox.Show("Đã Xảy Ra Lỗi. Vui Lòng Thử Lại...", "Đăng Nhập Hệ Thống", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        if (rlt == DialogResult.Cancel)
                        {
                            MessageBox.Show("Tạm Biệt, Hẹn Gặp Lại.");
                            // Application.Exit();
                            this.Close();
                        }
                    }
                }
            }   
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}