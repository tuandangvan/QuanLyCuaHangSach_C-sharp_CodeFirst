namespace Project_QuanLyCuaHangSach
{
    partial class frmCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerPHONENUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerTypeNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.btnUpdateCustomerType = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbCustomerTypeID = new System.Windows.Forms.ComboBox();
            this.txtCustomerPHONENUM = new System.Windows.Forms.TextBox();
            this.txtCustomerADDRESS = new System.Windows.Forms.TextBox();
            this.txtCustomerNAME = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightBlue;
            this.btnXoa.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnXoa.Location = new System.Drawing.Point(834, 179);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 42);
            this.btnXoa.TabIndex = 39;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightBlue;
            this.btnThoat.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnThoat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThoat.Location = new System.Drawing.Point(834, 240);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 39);
            this.btnThoat.TabIndex = 33;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.CustomerID,
            this.CustomerNAME,
            this.CustomerADDRESS,
            this.CustomerPHONENUM,
            this.CustomerTypeNAME});
            this.dgvKhachHang.Location = new System.Drawing.Point(12, 326);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(1088, 383);
            this.dgvKhachHang.TabIndex = 38;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "Mã Khách Hàng";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            // 
            // CustomerNAME
            // 
            this.CustomerNAME.HeaderText = "Tên Khách Hàng";
            this.CustomerNAME.MinimumWidth = 6;
            this.CustomerNAME.Name = "CustomerNAME";
            // 
            // CustomerADDRESS
            // 
            this.CustomerADDRESS.HeaderText = "Địa Chỉ";
            this.CustomerADDRESS.MinimumWidth = 6;
            this.CustomerADDRESS.Name = "CustomerADDRESS";
            // 
            // CustomerPHONENUM
            // 
            this.CustomerPHONENUM.HeaderText = "Số Điện Thoại";
            this.CustomerPHONENUM.MinimumWidth = 6;
            this.CustomerPHONENUM.Name = "CustomerPHONENUM";
            // 
            // CustomerTypeNAME
            // 
            this.CustomerTypeNAME.HeaderText = "Xếp Loại KH";
            this.CustomerTypeNAME.MinimumWidth = 6;
            this.CustomerTypeNAME.Name = "CustomerTypeNAME";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightBlue;
            this.btnLuu.Enabled = false;
            this.btnLuu.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnLuu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLuu.Location = new System.Drawing.Point(599, 239);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 42);
            this.btnLuu.TabIndex = 35;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightBlue;
            this.btnThem.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnThem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThem.Location = new System.Drawing.Point(599, 179);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 42);
            this.btnThem.TabIndex = 34;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightBlue;
            this.btnSua.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSua.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSua.Location = new System.Drawing.Point(717, 179);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 42);
            this.btnSua.TabIndex = 36;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel
            // 
            this.panel.BackgroundImage = global::Project_QuanLyCuaHangSach.Properties.Resources.mo_hinh_kinh_doanh_xoay_quanh_khach_hang_la_nhu_the_nao;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.btnThoat);
            this.panel.Controls.Add(this.btnXoa);
            this.panel.Controls.Add(this.btnUpdateCustomerType);
            this.panel.Controls.Add(this.btnHuy);
            this.panel.Controls.Add(this.btnSearch);
            this.panel.Controls.Add(this.btnLuu);
            this.panel.Controls.Add(this.cbCustomerTypeID);
            this.panel.Controls.Add(this.txtCustomerPHONENUM);
            this.panel.Controls.Add(this.txtCustomerADDRESS);
            this.panel.Controls.Add(this.txtCustomerNAME);
            this.panel.Controls.Add(this.btnSua);
            this.panel.Controls.Add(this.btnThem);
            this.panel.Controls.Add(this.txtCustomerID);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.label2);
            this.panel.Location = new System.Drawing.Point(12, 11);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1088, 287);
            this.panel.TabIndex = 32;
            // 
            // btnUpdateCustomerType
            // 
            this.btnUpdateCustomerType.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateCustomerType.BackgroundImage = global::Project_QuanLyCuaHangSach.Properties.Resources.images;
            this.btnUpdateCustomerType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateCustomerType.Location = new System.Drawing.Point(425, 240);
            this.btnUpdateCustomerType.Name = "btnUpdateCustomerType";
            this.btnUpdateCustomerType.Size = new System.Drawing.Size(45, 33);
            this.btnUpdateCustomerType.TabIndex = 30;
            this.btnUpdateCustomerType.UseVisualStyleBackColor = false;
            this.btnUpdateCustomerType.Click += new System.EventHandler(this.btnUpdateCustomerType_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::Project_QuanLyCuaHangSach.Properties.Resources.tk;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(429, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 30);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbCustomerTypeID
            // 
            this.cbCustomerTypeID.Enabled = false;
            this.cbCustomerTypeID.FormattingEnabled = true;
            this.cbCustomerTypeID.Location = new System.Drawing.Point(215, 245);
            this.cbCustomerTypeID.Name = "cbCustomerTypeID";
            this.cbCustomerTypeID.Size = new System.Drawing.Size(204, 24);
            this.cbCustomerTypeID.TabIndex = 28;
            // 
            // txtCustomerPHONENUM
            // 
            this.txtCustomerPHONENUM.Enabled = false;
            this.txtCustomerPHONENUM.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtCustomerPHONENUM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCustomerPHONENUM.Location = new System.Drawing.Point(215, 191);
            this.txtCustomerPHONENUM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerPHONENUM.Name = "txtCustomerPHONENUM";
            this.txtCustomerPHONENUM.Size = new System.Drawing.Size(208, 30);
            this.txtCustomerPHONENUM.TabIndex = 27;
            // 
            // txtCustomerADDRESS
            // 
            this.txtCustomerADDRESS.Enabled = false;
            this.txtCustomerADDRESS.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtCustomerADDRESS.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCustomerADDRESS.Location = new System.Drawing.Point(215, 144);
            this.txtCustomerADDRESS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerADDRESS.Name = "txtCustomerADDRESS";
            this.txtCustomerADDRESS.Size = new System.Drawing.Size(315, 30);
            this.txtCustomerADDRESS.TabIndex = 26;
            // 
            // txtCustomerNAME
            // 
            this.txtCustomerNAME.Enabled = false;
            this.txtCustomerNAME.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtCustomerNAME.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCustomerNAME.Location = new System.Drawing.Point(215, 84);
            this.txtCustomerNAME.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerNAME.Name = "txtCustomerNAME";
            this.txtCustomerNAME.Size = new System.Drawing.Size(315, 30);
            this.txtCustomerNAME.TabIndex = 25;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtCustomerID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCustomerID.Location = new System.Drawing.Point(215, 26);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(208, 30);
            this.txtCustomerID.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(15, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = "Số Điện Thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(13, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "Loại Khách Hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(13, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "Địa Chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã Khách Hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên Khách Hàng:";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.LightBlue;
            this.btnHuy.Enabled = false;
            this.btnHuy.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnHuy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHuy.Location = new System.Drawing.Point(717, 238);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 42);
            this.btnHuy.TabIndex = 37;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1118, 722);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.panel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách Hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCustomer_FormClosed);
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerPHONENUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerTypeNAME;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnUpdateCustomerType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbCustomerTypeID;
        private System.Windows.Forms.TextBox txtCustomerPHONENUM;
        private System.Windows.Forms.TextBox txtCustomerADDRESS;
        private System.Windows.Forms.TextBox txtCustomerNAME;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
    }
}