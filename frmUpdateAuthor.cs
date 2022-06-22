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
    public partial class frmUpdateAuthor : Form
    {
        public frmUpdateAuthor()
        {
            InitializeComponent();
        }
        private Author GetAuthor()
        {
            Author aut = new Author();
            aut.AuthorID = txtAuthorID.Text;
            aut.AuthorNAME = txtAuthorNAME.Text;
            aut.AuthorPHONENUM = txtAuthorPHONENUM.Text;

            return aut;
        }
        private void ResetTxt()
        {
            txtAuthorNAME.ResetText();
            txtAuthorID.ResetText();
            txtAuthorPHONENUM.ResetText();
        }
        private void frmUpdateAuthor_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Author aut = Author.GetAuthor(txtAuthorID.Text);
            if (txtAuthorID.Text == string.Empty)
                MessageBox.Show("Vui lòng nhập mã Tác giả!");
            else if (aut == null)
                MessageBox.Show("Không tìm thấy tác giả này!");
            else
            {
                txtAuthorID.Text = aut.AuthorID;
                txtAuthorNAME.Text = aut.AuthorNAME;
                txtAuthorPHONENUM.Text = aut.AuthorPHONENUM;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtAuthorID.Text == string.Empty || txtAuthorNAME.Text == string.Empty || txtAuthorPHONENUM.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (Author.GetAuthor(txtAuthorID.Text) != null)
            {
                MessageBox.Show("Mã Thể loại đã tồn tại");
                txtAuthorID.Focus();
            }
            else
            {
                Author tl = GetAuthor();
                tl.InsertAuthor();
                MessageBox.Show("Thêm thành công");
                ResetTxt();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Author aut = Author.GetAuthor(txtAuthorID.Text);
            if (txtAuthorID.Text == string.Empty || txtAuthorNAME.Text == string.Empty || txtAuthorPHONENUM.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (aut == null)
                MessageBox.Show("Không tìm thấy NXB này!");
            else
            {
                aut.AuthorID = txtAuthorID.Text;
                aut.AuthorNAME = txtAuthorNAME.Text;
                aut.AuthorPHONENUM = txtAuthorPHONENUM.Text;
                aut.UpdateAuthor();
                MessageBox.Show("Cập nhật thành công!");
                ResetTxt();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Author aut = Author.GetAuthor(txtAuthorID.Text);
            if (txtAuthorID.Text == string.Empty || txtAuthorNAME.Text == string.Empty || txtAuthorPHONENUM.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (aut == null)
                MessageBox.Show("Không tìm thấy NXB này!");
            else
            {
                DialogResult tl = MessageBox.Show("Bạn có chắc muốn xóa!", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {
                    aut.DeletaAuthor(txtAuthorID.Text);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                ResetTxt();
            }
        }

        private void frmUpdateAuthor_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmBook frm = new frmBook();
            frm.Show();
            this.Hide();
        }
    }
}
