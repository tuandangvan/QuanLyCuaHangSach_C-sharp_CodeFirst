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
    public partial class frmSell : Form
    {
        public frmSell()
        {
            InitializeComponent();
            ShowFilter();
            ShowBill();
        }
        List<BillDetail> billDetail = new List<BillDetail>();
        List<Book> ListBook = Book.GetAll();
        private void frmSell_Load(object sender, EventArgs e)
        {
            ShowBook(Book.GetAll());

        }
        public void ShowBillDetail(List<BillDetail> billDetails)
        {
            dgvBillDetail.Rows.Clear();
            int stt = 1;
            foreach (var i in billDetails)
            {
                int index = dgvBillDetail.Rows.Add();
                dgvBillDetail.Rows[index].Cells[0].Value = stt++;
                dgvBillDetail.Rows[index].Cells[1].Value = i.BookImage;
                dgvBillDetail.Rows[index].Cells[2].Value = i.BookID;
                dgvBillDetail.Rows[index].Cells[3].Value = i.BillID;
                dgvBillDetail.Rows[index].Cells[4].Value = i.BookPrice;
                dgvBillDetail.Rows[index].Cells[5].Value = i.BookAmount;
                dgvBillDetail.Rows[index].Cells[6].Value = i.SumPrice;
            }
        }
        private void ShowFilter()
        {
            List<Category> cate = Category.GetAll();
            List<Author> au = Author.GetAll();
            List<Publisher> pb = Publisher.GetAll();

            cbCategoryNAME.DataSource = cate;
            cbCategoryNAME.DisplayMember = "CateNAME";
            cbCategoryNAME.ValueMember = "CateID";
            cbCategoryNAME.SelectedItem = null;
            cbCategoryNAME.SelectedText = null;

            cbAuthorNAME.DataSource = au;
            cbAuthorNAME.DisplayMember = "AuthorNAME";
            cbAuthorNAME.ValueMember = "AuthorID";
            cbAuthorNAME.SelectedItem = null;
            cbAuthorNAME.SelectedText = null;


            cbPublisherNAME.DataSource = pb;
            cbPublisherNAME.DisplayMember = "PublisherNAME";
            cbPublisherNAME.ValueMember = "PublisherID";
            cbPublisherNAME.SelectedItem = null;
            cbPublisherNAME.SelectedText = null;
        }

        private void ShowBill()
        {
            List<BillBook> bill = BillBook.GetAll();
            dgvBill.Rows.Clear();
            int stt = 1;
            foreach (var i in bill)
            {
                int index = dgvBill.Rows.Add();
                dgvBill.Rows[index].Cells[0].Value = stt++;
                dgvBill.Rows[index].Cells[1].Value = i.BillID;
                dgvBill.Rows[index].Cells[2].Value = i.SumBill;
                dgvBill.Rows[index].Cells[3].Value = i.BuyDate;
                dgvBill.Rows[index].Cells[4].Value = i.CustomerID;
                dgvBill.Rows[index].Cells[5].Value = i.EmpID;
            }
        }
        List<Employee> em = Employee.GetAll();
        List<Customer> cus = Customer.GetAll();
        public void ShowBook(List<Book> listSach)
        {
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
            cbCustomerID.DataSource = cus;
            cbCustomerID.DisplayMember = "CustomerID";
            cbCustomerID.ValueMember = "CustomerID";

            cbEmployeeID.DataSource = em;
            cbEmployeeID.DisplayMember = "EmpID";
            cbEmployeeID.ValueMember = "EmpID";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = false;
                Book b = GetBookFromList(ListBook, txtBookID.Text);
                if (b == null)
                {
                    MessageBox.Show("Mã sách không hợp lệ!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBookID.Focus();
                }
                else if (txtAmount.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số lượng sách!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAmount.Focus();
                }
                else if (Convert.ToInt32(txtAmount.Text) > b.BookAMOUNT)
                {
                    MessageBox.Show("Số sách trong kho không còn đủ!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAmount.Focus();
                }
                else if (Convert.ToInt32(txtAmount.Text) < 1)
                {
                    MessageBox.Show("Vui lòng nhập số lượng sách phù hợp!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAmount.Focus();
                }
                else if (txtBillID.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập BillID!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBillID.Focus();
                }
                else if (BillBook.GetBillBook(txtBillID.Text) != null)
                {
                    MessageBox.Show("BillID này đã tồn tại! Vui lòng nhập BillID khác", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBillID.Focus();
                }
                else
                {

                    BillDetail bill = new BillDetail()
                    {
                        BookID = b.BookID,
                        BillID = txtBillID.Text,
                        BookImage = b.BookIMAGE,
                        BookPrice = b.BookPRICE,
                        BookAmount = Convert.ToInt32(txtAmount.Text),
                        SumPrice = b.BookPRICE * Convert.ToInt32(txtAmount.Text)
                    };
                    foreach (var billdetail in billDetail)
                    {

                        if (billdetail.BookID == bill.BookID && billdetail.BillID == bill.BillID)
                        {
                            billdetail.BookAmount += bill.BookAmount;
                            billdetail.SumPrice += bill.SumPrice;
                            check = true;
                        }
                    }
                    if (check == false)
                    {
                        billDetail.Add(bill);
                    }
                    MessageBox.Show("Thêm thành công!");
                    b.BookAMOUNT -= bill.BookAmount;
                    ShowBillDetail(billDetail);
                    ShowBook(ListBook);
                    SumBill();
                    btnCreateBill.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnHuy.Enabled = true;
                    txtBillID.Enabled = false;
                    cbCustomerID.Enabled = false;
                    btnCus.Enabled = false;
                    cbEmployeeID.Enabled = false;
                    txtAmount.Clear();
                    txtBookID.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số lượng sách hợp lệ");
                txtAmount.Focus();
            }
        }
        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            if (billDetail.Count == 0)
            {
                MessageBox.Show("Chưa có sách trong hóa đơn");
            }
            else
            {
                int Sum = 0;
                foreach (BillDetail b in billDetail)
                {
                    Book book = Book.GetBook(b.BookID);
                    if (book != null)
                    {
                        book.BookAMOUNT -= b.BookAmount;
                        book.UpdateBook();
                    }

                    Sum += b.SumPrice;
                }
                BillBook billBook = new BillBook()
                {
                    BillID = txtBillID.Text,
                    BuyDate = DateTime.Now,
                    CustomerID = cbCustomerID.SelectedValue.ToString(),
                    EmpID = cbEmployeeID.SelectedValue.ToString(),
                    SumBill = Sum
                };
                billBook.BillDetails = billDetail;
                billBook.InsertBillBook();

                billDetail.Clear();
                txtBookID.Focus();
                txtBillID.Clear();

                txtBillID.Enabled = true;
                cbEmployeeID.Enabled = true;
                cbCustomerID.Enabled = true;
                btnCus.Enabled = true;

                btnCreateBill.Enabled = false;
                btnHuy.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                ShowBillDetail(billDetail);
                SumBill();

                MessageBox.Show("Đã xuất hóa đơn");
                ShowBill();

            }

        }
        private Book GetBookFromList(List<Book> list, string id)
        {
            return list.Where(p => p.BookID == id).FirstOrDefault();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ListBook = Book.GetAll();
            billDetail.Clear();
            ShowBillDetail(billDetail);
            ShowBook(Book.GetAll());
            SumBill();

            btnCreateBill.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;

            txtBillID.Clear();
            txtAmount.Clear();
            txtBookID.Clear();

            txtBillID.Enabled = true;
            cbCustomerID.Enabled = true;
            cbEmployeeID.Enabled = true;
            btnCus.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void dgvAllBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvAllBook.Rows[e.RowIndex];
                txtBookID.Text = Convert.ToString(row.Cells[2].Value);
                txtAmount.Text = "";
                txtAmount.Focus();
            }
        }

        private void dgvBillDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvBillDetail.Rows[e.RowIndex];
                txtBookID.Text = Convert.ToString(row.Cells[2].Value);
                txtBillID.Text = Convert.ToString(row.Cells[3].Value);
                txtAmount.Text = Convert.ToString(row.Cells[5].Value);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var itemToRemove = billDetail.Single(p => p.BillID == txtBillID.Text && p.BookID == txtBookID.Text);
            if (itemToRemove != null)
            {
                Book book = GetBookFromList(ListBook, itemToRemove.BookID);
                book.BookAMOUNT += itemToRemove.BookAmount;
                billDetail.Remove(itemToRemove);
                if (billDetail.Count == 0)
                {
                    btnSua.Enabled = false;
                    btnHuy.Enabled = true;
                    btnCreateBill.Enabled = false;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = false;

                }
                txtAmount.Clear();
                ShowBillDetail(billDetail);
                ShowBook(ListBook);
                SumBill();
            }
            else
            {
                MessageBox.Show("Không tìm được mã sách phù hợp");
            }
        }
        public void SumBill()
        {
            int sum = 0;
            foreach (var item in billDetail)
            {
                sum += item.SumPrice;
            }
            labelTongTien.Text = sum.ToString();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnCreateBill.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtBillID.Enabled = false;
            txtBookID.Enabled = false;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            txtAmount.Focus();
        }


        private void btnCus_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.ShowDialog();
            this.Hide();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtAmount.Text) >= 0)
                {
                    var item = billDetail.Single(p => p.BillID == txtBillID.Text && p.BookID == txtBookID.Text);
                    Book book = GetBookFromList(ListBook, item.BookID);
                    if (Convert.ToInt32(txtAmount.Text) > book.BookAMOUNT)
                    {
                        MessageBox.Show("Số lượng sách trong kho không còn đủ với yêu cầu này");
                        txtAmount.Focus();
                    }
                    else
                    {
                        book.BookAMOUNT -= -item.BookAmount + Convert.ToInt32(txtAmount.Text);
                        item.BookAmount = Convert.ToInt32(txtAmount.Text);
                        item.SumPrice = item.BookPrice * item.BookAmount;
                        if (item.BookAmount == 0)
                        {
                            billDetail.Remove(item);
                        }
                        ShowBillDetail(billDetail);
                        ShowBook(ListBook);
                        SumBill();

                        btnAdd.Enabled = true;
                        btnCreateBill.Enabled = true;
                        btnXoa.Enabled = true;
                        btnSua.Enabled = true;
                        btnHuy.Enabled = true;
                        txtBookID.Enabled = true;

                        btnLuu.Enabled = false;
                        txtBillID.Enabled = false;

                        txtAmount.Clear();
                        txtBookID.Focus();

                        if (billDetail.Count == 0)
                        {
                            btnSua.Enabled = false;
                            btnCreateBill.Enabled = false;
                            btnXoa.Enabled = false;
                            btnLuu.Enabled = false;

                            btnHuy.Enabled = true;

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lượng sách hợp lệ!");
                    txtAmount.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số lượng sách hợp lệ");
                txtAmount.Focus();
            }
        }
        private void frmSell_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Hide();
        }

        private void cbCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer cus = Customer.GetCustomer(cbCustomerID.Text);
            if (cus != null)
                lblCustomerNAME.Text = cus.CustomerNAME;
        }

        private void cbEmployeeNAME_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee em = Employee.GetEmployee(cbEmployeeID.Text);
            if (em != null)
                lblEmployeeNAME.Text = em.EmpNAME;
        }

        public List<Book> Filter(List<Book> listbook, string CategoryID, string AuthorID, string PublisherID)
        {
            if (CategoryID != null && AuthorID != null && PublisherID != null)
                return listbook.Where(p => p.CateID == CategoryID && p.AuthorID == AuthorID && p.PublisherID == PublisherID).ToList();
            else if (CategoryID != null && AuthorID == null && PublisherID == null)
                return listbook.Where(p => p.CateID == CategoryID).ToList();
            else if (CategoryID == null && AuthorID != null && PublisherID == null)
                return listbook.Where(p => p.AuthorID == AuthorID).ToList();
            else if (CategoryID == null && AuthorID == null && PublisherID != null)
                return listbook.Where(p => p.PublisherID == PublisherID).ToList();
            else if (CategoryID != null && AuthorID != null && PublisherID == null)
                return listbook.Where(p => p.CateID == CategoryID && p.AuthorID == AuthorID).ToList();
            else if (CategoryID != null && AuthorID == null && PublisherID != null)
                return listbook.Where(p => p.CateID == CategoryID && p.PublisherID == PublisherID).ToList();
            else if (CategoryID == null && AuthorID != null && PublisherID != null)
                return listbook.Where(p => p.AuthorID == AuthorID && p.PublisherID == PublisherID).ToList();
            else return listbook.ToList();

        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            string auID, pbID, caID;
            if (cbAuthorNAME.Text == "")
                auID = null;
            else
                auID = (string)cbAuthorNAME.SelectedValue.ToString();
            if (cbPublisherNAME.Text == "")
                pbID = null;
            else
                pbID = (string)cbPublisherNAME.SelectedValue.ToString();
            if (cbCategoryNAME.Text == "")
                caID = null;
            else
                caID = (string)cbCategoryNAME.SelectedValue.ToString();

            ShowBook(Filter(ListBook, caID, auID, pbID));

        }

        private void btnUnFilter_Click(object sender, EventArgs e)
        {
            cbCategoryNAME.SelectedItem = null;
            cbCategoryNAME.SelectedText = null;

            cbAuthorNAME.SelectedItem = null;
            cbAuthorNAME.SelectedText = null;

            cbPublisherNAME.SelectedItem = null;
            cbPublisherNAME.SelectedText = null;

            ShowBook(ListBook);
        }
    }
}
