
namespace QLSV
{
    partial class QuanLySinhVien
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEx = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labTongSinhVien = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtNgayVaoDoan = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textChucVuQLSV = new System.Windows.Forms.TextBox();
            this.txtDonViQLSV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbSinhVienGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnSinhVienThoat = new System.Windows.Forms.Button();
            this.btnSVXoa = new System.Windows.Forms.Button();
            this.btnSVSua = new System.Windows.Forms.Button();
            this.btnSVThem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sinhVienIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayVaoDoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhVienBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSet_Sinhvien = new QLSV.QLSVDataSet_Sinhvien();
            this.sinhVienBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter3 = new QLSV.QLSVDataSet_SinhvienTableAdapters.SinhVienTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet_Sinhvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btnEx);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnSinhVienThoat);
            this.groupBox1.Controls.Add(this.btnSVXoa);
            this.groupBox1.Controls.Add(this.btnSVSua);
            this.groupBox1.Controls.Add(this.btnSVThem);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(22, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1324, 779);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnEx
            // 
            this.btnEx.Location = new System.Drawing.Point(42, 720);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(147, 39);
            this.btnEx.TabIndex = 28;
            this.btnEx.Text = "Xuất file Excel";
            this.btnEx.UseVisualStyleBackColor = true;
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labTongSinhVien);
            this.groupBox4.Location = new System.Drawing.Point(487, 350);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(476, 74);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            // 
            // labTongSinhVien
            // 
            this.labTongSinhVien.AutoSize = true;
            this.labTongSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labTongSinhVien.ForeColor = System.Drawing.Color.Red;
            this.labTongSinhVien.Location = new System.Drawing.Point(65, 18);
            this.labTongSinhVien.Name = "labTongSinhVien";
            this.labTongSinhVien.Size = new System.Drawing.Size(251, 39);
            this.labTongSinhVien.TabIndex = 0;
            this.labTongSinhVien.Text = "Tổng Sinh Viên";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.dtNgayVaoDoan);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtDiaChi);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cbbLop);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.txtSoDienThoai);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(587, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(490, 333);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // dtNgayVaoDoan
            // 
            this.dtNgayVaoDoan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayVaoDoan.Location = new System.Drawing.Point(172, 211);
            this.dtNgayVaoDoan.Name = "dtNgayVaoDoan";
            this.dtNgayVaoDoan.Size = new System.Drawing.Size(260, 22);
            this.dtNgayVaoDoan.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ngày vào đoàn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa Chi:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(172, 26);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(260, 22);
            this.txtDiaChi.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lớp:";
            // 
            // cbbLop
            // 
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(172, 69);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(260, 24);
            this.cbbLop.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(172, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 22);
            this.txtEmail.TabIndex = 14;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(172, 162);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(260, 22);
            this.txtSoDienThoai.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Số Điện Thoại:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.textChucVuQLSV);
            this.groupBox2.Controls.Add(this.txtDonViQLSV);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMaSinhVien);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbbSinhVienGioiTinh);
            this.groupBox2.Controls.Add(this.txtHoVaTen);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateNgaySinh);
            this.groupBox2.Location = new System.Drawing.Point(42, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 333);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // textChucVuQLSV
            // 
            this.textChucVuQLSV.Location = new System.Drawing.Point(172, 274);
            this.textChucVuQLSV.Name = "textChucVuQLSV";
            this.textChucVuQLSV.Size = new System.Drawing.Size(260, 22);
            this.textChucVuQLSV.TabIndex = 26;
            // 
            // txtDonViQLSV
            // 
            this.txtDonViQLSV.Location = new System.Drawing.Point(172, 222);
            this.txtDonViQLSV.Name = "txtDonViQLSV";
            this.txtDonViQLSV.Size = new System.Drawing.Size(260, 22);
            this.txtDonViQLSV.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Chức Vụ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Đơn Vị:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Sinh Viên:";
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(172, 21);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.ReadOnly = true;
            this.txtMaSinhVien.Size = new System.Drawing.Size(260, 22);
            this.txtMaSinhVien.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ Và Tên:";
            // 
            // cbbSinhVienGioiTinh
            // 
            this.cbbSinhVienGioiTinh.FormattingEnabled = true;
            this.cbbSinhVienGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbSinhVienGioiTinh.Location = new System.Drawing.Point(172, 166);
            this.cbbSinhVienGioiTinh.Name = "cbbSinhVienGioiTinh";
            this.cbbSinhVienGioiTinh.Size = new System.Drawing.Size(260, 24);
            this.cbbSinhVienGioiTinh.TabIndex = 22;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(172, 60);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(260, 22);
            this.txtHoVaTen.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Giới Tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày Sinh:";
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgaySinh.Location = new System.Drawing.Point(172, 113);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(260, 22);
            this.dateNgaySinh.TabIndex = 2;
            // 
            // btnSinhVienThoat
            // 
            this.btnSinhVienThoat.Location = new System.Drawing.Point(1173, 720);
            this.btnSinhVienThoat.Name = "btnSinhVienThoat";
            this.btnSinhVienThoat.Size = new System.Drawing.Size(127, 39);
            this.btnSinhVienThoat.TabIndex = 24;
            this.btnSinhVienThoat.Text = "Thoát";
            this.btnSinhVienThoat.UseVisualStyleBackColor = true;
            this.btnSinhVienThoat.Click += new System.EventHandler(this.btnSinhVienThoat_Click);
            // 
            // btnSVXoa
            // 
            this.btnSVXoa.Location = new System.Drawing.Point(1191, 312);
            this.btnSVXoa.Name = "btnSVXoa";
            this.btnSVXoa.Size = new System.Drawing.Size(109, 41);
            this.btnSVXoa.TabIndex = 19;
            this.btnSVXoa.Text = "Xóa";
            this.btnSVXoa.UseVisualStyleBackColor = true;
            this.btnSVXoa.Click += new System.EventHandler(this.btnSVXoa_Click);
            // 
            // btnSVSua
            // 
            this.btnSVSua.Location = new System.Drawing.Point(1191, 165);
            this.btnSVSua.Name = "btnSVSua";
            this.btnSVSua.Size = new System.Drawing.Size(109, 41);
            this.btnSVSua.TabIndex = 18;
            this.btnSVSua.Text = "Sửa";
            this.btnSVSua.UseVisualStyleBackColor = true;
            this.btnSVSua.Click += new System.EventHandler(this.btnSVSua_Click);
            // 
            // btnSVThem
            // 
            this.btnSVThem.Location = new System.Drawing.Point(1193, 11);
            this.btnSVThem.Name = "btnSVThem";
            this.btnSVThem.Size = new System.Drawing.Size(107, 40);
            this.btnSVThem.TabIndex = 17;
            this.btnSVThem.Text = "Thêm";
            this.btnSVThem.UseVisualStyleBackColor = true;
            this.btnSVThem.Click += new System.EventHandler(this.btnSVThem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sinhVienIDDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewCheckBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dienThoaiDataGridViewTextBoxColumn,
            this.lopIDDataGridViewTextBoxColumn,
            this.NgayVaoDoan,
            this.DonVi,
            this.ChucVu});
            this.dataGridView1.DataSource = this.sinhVienBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(42, 430);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1258, 267);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sinhVienIDDataGridViewTextBoxColumn
            // 
            this.sinhVienIDDataGridViewTextBoxColumn.DataPropertyName = "SinhVienID";
            this.sinhVienIDDataGridViewTextBoxColumn.HeaderText = "SinhVienID";
            this.sinhVienIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sinhVienIDDataGridViewTextBoxColumn.Name = "sinhVienIDDataGridViewTextBoxColumn";
            this.sinhVienIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sinhVienIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.NullValue = null;
            this.hoTenDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // gioiTinhDataGridViewCheckBoxColumn
            // 
            this.gioiTinhDataGridViewCheckBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewCheckBoxColumn.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.gioiTinhDataGridViewCheckBoxColumn.Name = "gioiTinhDataGridViewCheckBoxColumn";
            this.gioiTinhDataGridViewCheckBoxColumn.Width = 125;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // dienThoaiDataGridViewTextBoxColumn
            // 
            this.dienThoaiDataGridViewTextBoxColumn.DataPropertyName = "DienThoai";
            this.dienThoaiDataGridViewTextBoxColumn.HeaderText = "DienThoai";
            this.dienThoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dienThoaiDataGridViewTextBoxColumn.Name = "dienThoaiDataGridViewTextBoxColumn";
            this.dienThoaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // lopIDDataGridViewTextBoxColumn
            // 
            this.lopIDDataGridViewTextBoxColumn.DataPropertyName = "LopID";
            this.lopIDDataGridViewTextBoxColumn.HeaderText = "LopID";
            this.lopIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lopIDDataGridViewTextBoxColumn.Name = "lopIDDataGridViewTextBoxColumn";
            this.lopIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // NgayVaoDoan
            // 
            this.NgayVaoDoan.DataPropertyName = "NgayVaoDoan";
            this.NgayVaoDoan.HeaderText = "NgayVaoDoan";
            this.NgayVaoDoan.MinimumWidth = 6;
            this.NgayVaoDoan.Name = "NgayVaoDoan";
            this.NgayVaoDoan.Width = 125;
            // 
            // DonVi
            // 
            this.DonVi.DataPropertyName = "DonVi";
            this.DonVi.HeaderText = "DonVi";
            this.DonVi.MinimumWidth = 6;
            this.DonVi.Name = "DonVi";
            this.DonVi.Width = 125;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "ChucVu";
            this.ChucVu.MinimumWidth = 6;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Width = 125;
            // 
            // qLSVDataSet_Sinhvien
            // 
            this.qLSVDataSet_Sinhvien.DataSetName = "QLSVDataSet_Sinhvien";
            this.qLSVDataSet_Sinhvien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhVienBindingSource3
            // 
            this.sinhVienBindingSource3.DataMember = "SinhVien";
            this.sinhVienBindingSource3.DataSource = this.qLSVDataSet_Sinhvien;
            // 
            // sinhVienTableAdapter3
            // 
            this.sinhVienTableAdapter3.ClearBeforeFill = true;
            // 
            // QuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 825);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanLySinhVien";
            this.Text = "QuanLySinhVien";
            this.Load += new System.EventHandler(this.QuanLySinhVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet_Sinhvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labTongSinhVien;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private System.Windows.Forms.Button btnSVXoa;
        private System.Windows.Forms.Button btnSVSua;
        private System.Windows.Forms.Button btnSVThem;
        private System.Windows.Forms.ComboBox cbbSinhVienGioiTinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.Button btnSinhVienThoat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.BindingSource sinhVienBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNgayVaoDoan;
        private System.Windows.Forms.TextBox textChucVuQLSV;
        private System.Windows.Forms.TextBox txtDonViQLSV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource sinhVienBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinhVienIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gioiTinhDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lopIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayVaoDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.Button btnEx;
        private QLSVDataSet_Sinhvien qLSVDataSet_Sinhvien;
        private System.Windows.Forms.BindingSource sinhVienBindingSource3;
        private QLSVDataSet_SinhvienTableAdapters.SinhVienTableAdapter sinhVienTableAdapter3;
    }
}