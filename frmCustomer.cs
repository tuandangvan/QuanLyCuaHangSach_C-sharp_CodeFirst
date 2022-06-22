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
    public partial class frmCustomer : Form
    {
        bool add = false;
        public frmCustomer()
        {
            InitializeComponent();
            ShowCustomer(Customer.GetAll());
        }
        public void ShowCustomer(List<Customer> listCTM)
        {
            List<CustomerType> ctmType = CustomerType.GetAll();
            dgvKhachHang.Rows.Clear();
            int stt = 1;
            foreach (var i in listCTM)
            {
                int index = dgvKhachHang.Rows.Add();
                dgvKhachHang.Rows[index].Cells[0].Value = stt++;
                dgvKhachHang.Rows[index].Cells[1].Value = i.CustomerID;
                dgvKhachHang.Rows[index].Cells[2].Value = i.CustomerNAME;
                dgvKhachHang.Rows[index].Cells[3].Value = i.CustomerADDRESS;
                dgvKhachHang.Rows[index].Cells[4].Value = i.CustomerPHONENUM;
                dgvKhachHang.Rows[index].Cells[5].Value = i.CustomerType.CustomerTypeNAME;
            }
            cbCustomerTypeID.DataSource = ctmType;
            cbCustomerTypeID.DisplayMember = "CustomerTypeNAME";
            cbCustomerTypeID.ValueMember = "CustomerTypeID";
        }
        public void Reset(bool c)
        {
            txtCustomerID.ResetText();
            txtCustomerNAME.ResetText();
            txtCustomerADDRESS.ResetText();
            txtCustomerPHONENUM.ResetText();

            this.txtCustomerNAME.Enabled = c;
            this.txtCustomerADDRESS.Enabled = c;
            this.txtCustomerPHONENUM.Enabled = c;
            this.cbCustomerTypeID.Enabled = c;

        }
        private Customer GetCustomer()
        {
            Customer ctm = new Customer();

            ctm.CustomerID = txtCustomerID.Text;
            ctm.CustomerNAME = txtCustomerNAME.Text;
            ctm.CustomerPHONENUM = txtCustomerPHONENUM.Text;
            ctm.CustomerADDRESS = txtCustomerADDRESS.Text;
            ctm.CustomerTypeID = cbCustomerTypeID.SelectedValue.ToString();
            return ctm;
        }
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            ShowCustomer(Customer.GetAll());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            add = true;
            //xóa trống các đối tượng trong 
            Reset(true);

            // Cho thao tác trên các nút Lưu / Hủy
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text == string.Empty || txtCustomerADDRESS.Text == string.Empty || txtCustomerNAME.Text == string.Empty ||
                txtCustomerPHONENUM.Text == string.Empty || cbCustomerTypeID.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else if (add)
            {
                try
                {
                    Customer ctm = GetCustomer();
                    ctm.InsertCustomer();
                    MessageBox.Show("Thêm thành công");
                    Reset(true);
                    ShowCustomer(Customer.GetAll());
                }
                catch
                {
                    MessageBox.Show("Mã sách này đã tồn tại");
                    txtCustomerID.Focus();
                }
            }
            else
            {
                try
                {
                    Customer cus = Customer.GetCustomer(txtCustomerID.Text);
                    if (cus == null)
                        throw new Exception("Không tìm thấy sách này trong thư viện");

                    if (txtCustomerID.Text == string.Empty || txtCustomerNAME.Text == string.Empty ||
                        txtCustomerADDRESS.Text == string.Empty || txtCustomerPHONENUM.Text == string.Empty)
                        MessageBox.Show("Vùi lòng nhập đầy đủ thông tin khách hàng!");
                    else
                    {
                        cus.CustomerNAME = txtCustomerNAME.Text;
                        cus.CustomerADDRESS = txtCustomerADDRESS.Text;
                        cus.CustomerPHONENUM = txtCustomerPHONENUM.Text;
                        cus.CustomerTypeID = cbCustomerTypeID.SelectedValue.ToString();
                        cus.UpdateCustomer();
                        MessageBox.Show("Cập nhật thành công");
                        Reset(true);
                        ShowCustomer(Customer.GetAll());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Hide();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            add = false;
            Reset(true);

            // Cho thao tác trên các nút Lưu / Hủy
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;

            int r = dgvKhachHang.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtCustomerID.Text =
            dgvKhachHang.Rows[r].Cells[1].Value.ToString();
            this.txtCustomerNAME.Text =
            dgvKhachHang.Rows[r].Cells[2].Value.ToString();
            this.txtCustomerADDRESS.Text =
            dgvKhachHang.Rows[r].Cells[3].Value.ToString();
            this.txtCustomerPHONENUM.Text =
            dgvKhachHang.Rows[r].Cells[4].Value.ToString();
            this.cbCustomerTypeID.Text =
            dgvKhachHang.Rows[r].Cells[5].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Customer ctmS = Customer.GetCustomer(txtCustomerID.Text);
                if (ctmS == null)
                    MessageBox.Show("Không tìm thấy khách hàng này!");
                else
                {
                    txtCustomerNAME.Text = ctmS.CustomerNAME;
                    txtCustomerPHONENUM.Text = ctmS.CustomerPHONENUM;
                    txtCustomerADDRESS.Text = ctmS.CustomerADDRESS;
                    cbCustomerTypeID.SelectedValue = ctmS.CustomerTypeID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string cusID;

            if (txtCustomerID.Text != string.Empty)
                cusID = txtCustomerID.Text;
            else
                cusID = dgvKhachHang.Rows[dgvKhachHang.CurrentCell.RowIndex].Cells[1].Value.ToString();
            Customer cus = Customer.GetCustomer(cusID);
            if (cus == null)
            {
                MessageBox.Show("Không tìm thấy mã khách hàng này!");
            }
            else
            {
                DialogResult tl = MessageBox.Show("Bạn có chắc muốn xóa!", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {
                    cus.DeleteCustomer();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ShowCustomer(Customer.GetAll());
                }
            }
        }

        private void btnUpdateCustomerType_Click(object sender, EventArgs e)
        {
            frmCustomerType frm = new frmCustomerType();
            frm.ShowDialog();
            this.Hide();
        }

        private void frmCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Hide();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Reset(false);

            // Cho thao tác trên các nút Lưu / Hủy 
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnThoat.Enabled = true;
        }
    }
}