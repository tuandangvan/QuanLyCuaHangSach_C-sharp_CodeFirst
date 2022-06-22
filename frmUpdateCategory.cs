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
    public partial class frmUpdateCategory : Form
    {
        public frmUpdateCategory()
        {
            InitializeComponent();
        }
        private Category GetCategory()
        {
            Category cate = new Category();
            cate.CateID = txtCateID.Text;
            cate.CateNAME = txtCateNAME.Text;
            cate.CateDESCRIBE = txtCateDESCRIBE.Text;

            return cate;
        }
        private void ResetTxt()
        {
            txtCateID.ResetText();
            txtCateNAME.ResetText();
            txtCateDESCRIBE.ResetText();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Category cate = Category.GetCategory(txtCateID.Text);
            if (txtCateID.Text == string.Empty)
                MessageBox.Show("Vui lòng nhập Mã thể loại!");
            else if (cate == null)
                MessageBox.Show("Không tìm thấy Thể loại này!");
            else
            {
                txtCateID.Text = cate.CateID;
                txtCateNAME.Text = cate.CateNAME;
                txtCateDESCRIBE.Text = cate.CateDESCRIBE;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtCateID.Text == string.Empty || txtCateNAME.Text == string.Empty || txtCateDESCRIBE.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (Category.GetCategory(txtCateID.Text) != null)
            {
                MessageBox.Show("Mã Thể loại đã tồn tại");
                txtCateID.Focus();
            }
            else
            {
                Category tl = GetCategory();
                tl.InsertCate();
                MessageBox.Show("Thêm thành công");
                ResetTxt();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Category cate = Category.GetCategory(txtCateID.Text);
            if (txtCateID.Text == string.Empty || txtCateNAME.Text == string.Empty || txtCateDESCRIBE.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (cate == null)
                MessageBox.Show("Không tìm thấy Thể loại này!");
            else
            {
                cate.CateID = txtCateID.Text;
                cate.CateNAME = txtCateNAME.Text;
                cate.CateDESCRIBE = txtCateDESCRIBE.Text;
                cate.UpdateCate();
                MessageBox.Show("Cập nhật thành công!");
                ResetTxt();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Category cate = Category.GetCategory(txtCateID.Text);
            if (txtCateID.Text == string.Empty || txtCateNAME.Text == string.Empty || txtCateDESCRIBE.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (cate == null)
                MessageBox.Show("Không tìm thấy Thể loại này!");
            else
            {
                DialogResult tl = MessageBox.Show("Bạn có chắc muốn xóa!", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {
                    cate.DeletaCate(txtCateID.Text);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                ResetTxt();
            }
        }

        private void frmUpdateCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmBook frm = new frmBook();
            frm.Show();
            this.Hide();
        }

        private void frmUpdateCategory_Load(object sender, EventArgs e)
        {

        }
    }
}
