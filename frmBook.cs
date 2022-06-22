using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace Project_QuanLyCuaHangSach
{
    public partial class frmBook : Form
    {
        bool add = false;
        public frmBook()
        {
            InitializeComponent();
            ShowBook(Book.GetAll());
        }
        public void Reset(bool c)
        {
            this.txtBookID.ResetText();
            this.txtBookNAME.ResetText();
            this.cbAuthorNAME.ResetText();
            this.txtBookAMOUNT.ResetText();
            this.txtBookPRICE.ResetText();
            this.cbCategoryNAME.ResetText();
            this.cbPublisherNAME.ResetText();
            this.pictureBoxImageB.Image = null;


            this.txtBookNAME.Enabled = c;
            this.cbAuthorNAME.Enabled = c;
            this.txtBookAMOUNT.Enabled = c;
            this.txtBookPRICE.Enabled = c;
            this.cbCategoryNAME.Enabled = c;
            this.cbPublisherNAME.Enabled = c;

        }
        public void ShowBook(List<Book> listSach)
        {

            List<Author> aut = Author.GetAll();
            List<Publisher> pb = Publisher.GetAll();
            List<Category> ca = Category.GetAll();
            dgvAllBook.Rows.Clear();
            int stt = 1;
            foreach (var i in listSach)
            {
                int index = dgvAllBook.Rows.Add();
                dgvAllBook.Rows[index].Cells[0].Value = stt++;
                dgvAllBook.Rows[index].Cells[1].Value = i.BookIMAGE;
                dgvAllBook.Rows[index].Cells[2].Value = i.BookID;
                dgvAllBook.Rows[index].Cells[3].Value = i.BookNAME;
                dgvAllBook.Rows[index].Cells[4].Value = i.Category.CateNAME;
                dgvAllBook.Rows[index].Cells[5].Value = i.Author.AuthorNAME;
                dgvAllBook.Rows[index].Cells[6].Value = i.Publisher.PublisherNAME;
                dgvAllBook.Rows[index].Cells[7].Value = i.BookPRICE;
                dgvAllBook.Rows[index].Cells[8].Value = i.BookAMOUNT;
            }
            cbAuthorNAME.DataSource = aut;
            cbAuthorNAME.DisplayMember = "AuthorNAME";
            cbAuthorNAME.ValueMember = "AuthorID";

            cbCategoryNAME.DataSource = ca;
            cbCategoryNAME.DisplayMember = "CateNAME";
            cbCategoryNAME.ValueMember = "CateID";

            cbPublisherNAME.DataSource = pb;
            cbPublisherNAME.DisplayMember = "PublisherNAME";
            cbPublisherNAME.ValueMember = "PublisherID";
        }
        private void frmBook_Load(object sender, EventArgs e)
        {
            ShowBook(Book.GetAll());
        }
        private Book GetBook()
        {
            Book book = new Book();
            book.BookIMAGE = ImageToByteArray(pictureBoxImageB.Image);
            book.BookID = txtBookID.Text;
            book.BookNAME = txtBookNAME.Text;
            book.BookAMOUNT = Convert.ToInt32(txtBookAMOUNT.Text);
            book.BookPRICE = Convert.ToInt32(txtBookPRICE.Text);
            book.AuthorID = cbAuthorNAME.SelectedValue.ToString();
            book.PublisherID = cbPublisherNAME.SelectedValue.ToString();
            book.CateID = cbCategoryNAME.SelectedValue.ToString();
            return book;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            add = true;
            //xóa trống các đối tượng trong panel
            Reset(true);


            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            add = false;
            //xóa trống các đối tượng trong panel
            Reset(true);


            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;

            int r = dgvAllBook.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            if (r >=0)
            {
                MemoryStream ms = new MemoryStream((byte[])dgvAllBook.Rows[r].Cells[1].Value);
                this.pictureBoxImageB.Image = Image.FromStream(ms);
                this.txtBookID.Text =
                dgvAllBook.Rows[r].Cells[2].Value.ToString();
                this.txtBookNAME.Text =
                dgvAllBook.Rows[r].Cells[3].Value.ToString();
                this.cbCategoryNAME.Text =
                dgvAllBook.Rows[r].Cells[4].Value.ToString();
                this.cbAuthorNAME.Text =
                dgvAllBook.Rows[r].Cells[5].Value.ToString();
                this.cbPublisherNAME.Text =
                dgvAllBook.Rows[r].Cells[6].Value.ToString();
                this.txtBookPRICE.Text =
                dgvAllBook.Rows[r].Cells[7].Value.ToString();
                this.txtBookAMOUNT.Text =
                dgvAllBook.Rows[r].Cells[8].Value.ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (add)
            {
                if (txtBookID.Text.Length > 10)
                {
                    MessageBox.Show("Mã sách quá dài!");
                }
                else
                {
                    try
                    {
                        Book book = GetBook();
                        if (ImageToByteArray(pictureBoxImageB.Image) != null)
                        {
                            book.BookIMAGE = ImageToByteArray(pictureBoxImageB.Image);
                            book.InsertBook();
                            MessageBox.Show("Thêm sách thành công");
                            Reset(true);
                            ShowBook(Book.GetAll());
                        }
                        else
                            MessageBox.Show("Sách này chưa có bìa sách");
                    }
                    catch
                    {
                        MessageBox.Show("fhakfhksja");
                        txtBookID.Focus();
                    }
                }
            }
            else
            {
                try
                {
                    Book bk = Book.GetBook(txtBookID.Text);
                    if (bk == null)
                        throw new Exception("Không tìm thấy sách này trong thư viện");

                    if (txtBookID.Text == string.Empty || txtBookNAME.Text == string.Empty ||
                        txtBookAMOUNT.Text == string.Empty || txtBookPRICE.Text == string.Empty)
                        MessageBox.Show("Vùi lòng nhập đầy đủ thông tin khách hàng!");
                    else
                    {
                        bk.BookIMAGE = ImageToByteArray(pictureBoxImageB.Image);
                        bk.BookNAME = txtBookNAME.Text;
                        bk.BookAMOUNT = Convert.ToInt32(txtBookAMOUNT.Text);
                        bk.BookPRICE = Convert.ToInt32(txtBookPRICE.Text);
                        bk.AuthorID = cbAuthorNAME.SelectedValue.ToString();
                        bk.PublisherID = cbPublisherNAME.SelectedValue.ToString();
                        bk.CateID = cbCategoryNAME.SelectedValue.ToString();
                        bk.UpdateBook();
                        MessageBox.Show("Cập nhật thành công");
                        Reset(true);
                        ShowBook(Book.GetAll());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //xóa trống các đối tượng trong panel
            Reset(false);


            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnThoat.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Hide();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string bkID;
            if (txtBookID.Text != string.Empty)
                bkID = txtBookID.Text;
            else
                bkID = dgvAllBook.Rows[dgvAllBook.CurrentCell.RowIndex].Cells[2].Value.ToString();
            Book bk = Book.GetBook(bkID);
            if (bk == null)
            {
                MessageBox.Show("Không tìm thấy mã sách này!");
            }
            else
            {
                DialogResult tl = MessageBox.Show("Bạn có chắc muốn xóa!", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {
                    bk.DeleteBook();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ShowBook(Book.GetAll());
                }
            }
        }

        private void btnSuaCategory_Click(object sender, EventArgs e)
        {
            frmUpdateCategory frm = new frmUpdateCategory();
            frm.ShowDialog();
            this.Hide();
        }

        private void btnSuaAuthor_Click(object sender, EventArgs e)
        {
            frmUpdateAuthor frm = new frmUpdateAuthor();
            frm.ShowDialog();
            this.Hide();
        }

        private void btnSuaPublisher_Click(object sender, EventArgs e)
        {
            frmUpdatePublisher frm = new frmUpdatePublisher();
            frm.ShowDialog();
            this.Hide();
        }
        
        private void btnLoadBia_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImageB.Image = Image.FromFile(openFileDialog.FileName);
                this.Text = openFileDialog.FileName;
            }    
        }
        // Chuyển ảnh sang byte array
        byte[] ImageToByteArray(Image image)
        {
            if (pictureBoxImageB.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
            else
                return null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Book bs = Book.GetBook(txtBookID.Text);
                if (bs == null)
                    MessageBox.Show("Không tìm thấy mã sách này!");
                else
                {
                    int r = dgvAllBook.CurrentCell.RowIndex;
                    MemoryStream ms = new MemoryStream((byte[])dgvAllBook.Rows[r].Cells[1].Value);
                    this.pictureBoxImageB.Image = Image.FromStream(ms);
                    txtBookNAME.Text = bs.BookNAME;
                    txtBookID.Text = bs.BookID;
                    txtBookAMOUNT.Text = bs.BookAMOUNT.ToString();
                    txtBookPRICE.Text = bs.BookPRICE.ToString();
                    cbAuthorNAME.Text = bs.Author.AuthorNAME;
                    cbCategoryNAME.Text = bs.Category.CateNAME;
                    cbPublisherNAME.Text = bs.Publisher.PublisherNAME;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Hide();
        }
    }
}
