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
    public partial class frmUpdatePublisher : Form
    {
        public frmUpdatePublisher()
        {
            InitializeComponent();
        }
        private Publisher GetPublisher()
        {
            Publisher aut = new Publisher();
            aut.PublisherID = txtPublisherID.Text;
            aut.PublisherNAME = txtPublisherNAME.Text;
            aut.PublisherADDRESS = txtPublisherADDRESS.Text;
            aut.PublisherPHONENUM = txtPHONENUM.Text;

            return aut;
        }

        private void ResetTxt()
        {
            txtPublisherID.ResetText();
            txtPublisherNAME.ResetText();
            txtPublisherADDRESS.ResetText();
            txtPHONENUM.ResetText();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Publisher pb = Publisher.GetPublisher(txtPublisherID.Text);
            if (txtPublisherID.Text == string.Empty)
                MessageBox.Show("Vui lòng nhập mã NXB!");
            else if (pb == null)
                MessageBox.Show("Không tìm thấy Thể loại này!");
            else
            {
                txtPublisherID.Text = pb.PublisherID;
                txtPublisherNAME.Text = pb.PublisherNAME;
                txtPublisherADDRESS.Text = pb.PublisherADDRESS;
                txtPHONENUM.Text = pb.PublisherNAME;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtPublisherID.Text == string.Empty || txtPublisherNAME.Text == string.Empty || txtPublisherADDRESS.Text == string.Empty || txtPHONENUM.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (Author.GetAuthor(txtPublisherID.Text) != null)
            {
                MessageBox.Show("Mã NXB đã tồn tại");
                txtPublisherID.Focus();
            }
            else
            {
                Publisher tl = GetPublisher();
                tl.InsertPublisher();
                MessageBox.Show("Thêm thành công");
                ResetTxt();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Publisher pb = Publisher.GetPublisher(txtPublisherID.Text);
            if (txtPublisherID.Text == string.Empty || txtPublisherNAME.Text == string.Empty || txtPublisherADDRESS.Text == string.Empty || txtPHONENUM.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (pb == null)
                MessageBox.Show("Không tìm thấy NXB này!");
            else
            {
                pb.PublisherID = txtPublisherID.Text;
                pb.PublisherNAME = txtPublisherNAME.Text;
                pb.PublisherADDRESS = txtPublisherADDRESS.Text;
                pb.PublisherPHONENUM = txtPHONENUM.Text;
                pb.UpdatePublisher();
                MessageBox.Show("Cập nhật thành công!");
                ResetTxt();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Publisher pb = Publisher.GetPublisher(txtPublisherID.Text);
            if (txtPublisherID.Text == string.Empty || txtPublisherNAME.Text == string.Empty || txtPublisherADDRESS.Text == string.Empty || txtPHONENUM.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (pb == null)
                MessageBox.Show("Không tìm thấy NXB này!");
            else
            {
                DialogResult tl = MessageBox.Show("Bạn có chắc muốn xóa!", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {
                    pb.DeletaPublisher(txtPublisherID.Text);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                ResetTxt();
            }
        }

        private void frmUpdatePublisher_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmBook frm = new frmBook();
            frm.Show();
            this.Hide();
        }

        private void frmUpdatePublisher_Load(object sender, EventArgs e)
        {

        }
    }
}
