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
    public partial class frmCustomerType : Form
    {
        public frmCustomerType()
        {
            InitializeComponent();
        }
        private CustomerType GetCustomerType()
        {
            CustomerType ct = new CustomerType();
            ct.CustomerTypeID = txtCustomerTypeID.Text;
            ct.CustomerTypeNAME = txtCustomerTyperNAME.Text;
            ct.CustomerTypeDESCRIBE = txtCustomerTypeDESCRIBE.Text;

            return ct;
        }
        private void ResetTxt()
        {
            txtCustomerTypeID.ResetText();
            txtCustomerTyperNAME.ResetText();
            txtCustomerTypeDESCRIBE.ResetText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtCustomerTypeID.Text == string.Empty || txtCustomerTyperNAME.Text == string.Empty || txtCustomerTypeDESCRIBE.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (CustomerType.GetCustomerType(txtCustomerTypeID.Text) != null)
            {
                MessageBox.Show("Mã loại KH đã tồn tại");
                txtCustomerTypeID.Focus();
            }
            else
            {
                CustomerType tl = GetCustomerType();
                tl.InsertCustomerType();
                MessageBox.Show("Thêm thành công");
                ResetTxt();
                Customer cus = new Customer();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CustomerType custype = CustomerType.GetCustomerType(txtCustomerTypeID.Text);
            if (txtCustomerTypeID.Text == string.Empty)
                MessageBox.Show("Vui lòng nhập mã loại KH!");
            else if (custype == null)
                MessageBox.Show("Không tìm thấy Thể loại này!");
            else
            {
                txtCustomerTypeID.Text = custype.CustomerTypeID;
                txtCustomerTyperNAME.Text = custype.CustomerTypeNAME;
                txtCustomerTypeDESCRIBE.Text = custype.CustomerTypeDESCRIBE;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CustomerType custy = CustomerType.GetCustomerType(txtCustomerTypeID.Text);
            if (txtCustomerTypeID.Text == string.Empty || txtCustomerTyperNAME.Text == string.Empty || txtCustomerTypeDESCRIBE.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (custy == null)
                MessageBox.Show("Không tìm thấy Loại KH này!");
            else
            {
                custy.CustomerTypeNAME = txtCustomerTyperNAME.Text;
                custy.CustomerTypeID = txtCustomerTypeID.Text;
                custy.CustomerTypeDESCRIBE = txtCustomerTypeDESCRIBE.Text;
                custy.UpdateCustomerType();
                MessageBox.Show("Cập nhật thành công!");
                ResetTxt();
            }
        }



        private void frmCustomerType_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.Show();
            this.Hide();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            CustomerType custype = CustomerType.GetCustomerType(txtCustomerTypeID.Text);
            if (txtCustomerTypeID.Text == string.Empty)
                MessageBox.Show("Vui lòng nhập mã loại KH!");
            else if (custype == null)
                MessageBox.Show("Không tìm thấy Thể loại này!");
            else
            {
                txtCustomerTypeID.Text = custype.CustomerTypeID;
                txtCustomerTyperNAME.Text = custype.CustomerTypeNAME;
                txtCustomerTypeDESCRIBE.Text = custype.CustomerTypeDESCRIBE;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            CustomerType cmt = CustomerType.GetCustomerType(txtCustomerTypeID.Text);
            if (txtCustomerTypeID.Text == string.Empty || txtCustomerTyperNAME.Text == string.Empty || txtCustomerTypeDESCRIBE.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (cmt == null)
                MessageBox.Show("Không tìm thấy loại KH này!");
            else
            {
                DialogResult tl = MessageBox.Show("Bạn có chắc muốn xóa!", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {
                    cmt.DeletaCustomerType(txtCustomerTypeID.Text);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                ResetTxt();
            }
        }
    }
}
