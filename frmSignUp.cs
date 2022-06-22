using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QuanLyCuaHangSach
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }
        private UserLogin GetUser()
        {
            UserLogin us = new UserLogin();
            us.ID = txtID.Text;
            us.Passwork = txtPassword.Text;
            us.EmpID = txtEmployeeID.Text;
            return us;
        }

        private void lblDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            UserLogin userid = UserLogin.GetUserLogin(txtEmployeeID.Text);
            Employee id = Employee.GetEmployee(txtEmployeeID.Text);
            if (txtEmployeeID.Text == string.Empty || txtID.Text == string.Empty || txtPassword.Text== string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ!");
            }    
            else if (id == null)
            {
                MessageBox.Show("Mã nhân viên không tồn tại!");
            }
            else if(userid != null)
            {
                MessageBox.Show("Mã nhân viên này đã có tài khoản!");
            }    
            else
            {
                try
                {
                    UserLogin us = GetUser();
                    us.InsertUser();
                    MessageBox.Show("Tạo tài khoản thành công!");
                    frmLogin frm = new frmLogin();
                    frm.Show();
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("Tên tài khoản này đã tồn tại");
                    txtEmployeeID.Focus();
                }
            }
        }
    }
}
