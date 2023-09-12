
namespace QLSV
{
    partial class DangVien
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
            this.groupBoxDoanVien = new System.Windows.Forms.GroupBox();
            this.btnEx = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTongDoanVien = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDangvien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDVTenSinhVien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbDVMaSinhVien = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNgayVaoDoan = new System.Windows.Forms.TextBox();
            this.dtNgayVaoDang = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDVDonVi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDVChucVu = new System.Windows.Forms.TextBox();
            this.btnDoanVienThoat = new System.Windows.Forms.Button();
            this.btnDVXoa = new System.Windows.Forms.Button();
            this.btnDVSua = new System.Windows.Forms.Button();
            this.btnDVThem = new System.Windows.Forms.Button();
            this.dataGridViewDoanVien = new System.Windows.Forms.DataGridView();
            this.DangVienID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhVienIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayVaoDoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetNapDang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dangVienBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSet_Dangvien = new QLSV.QLSVDataSet_Dangvien();
            this.dangVienTableAdapter2 = new QLSV.QLSVDataSet_DangvienTableAdapters.DangVienTableAdapter();
            this.groupBoxDoanVien.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangVienBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet_Dangvien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDoanVien
            // 
            this.groupBoxDoanVien.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBoxDoanVien.Controls.Add(this.btnEx);
            this.groupBoxDoanVien.Controls.Add(this.groupBox4);
            this.groupBoxDoanVien.Controls.Add(this.groupBox3);
            this.groupBoxDoanVien.Controls.Add(this.groupBox2);
            this.groupBoxDoanVien.Controls.Add(this.groupBox1);
            this.groupBoxDoanVien.Controls.Add(this.btnDoanVienThoat);
            this.groupBoxDoanVien.Controls.Add(this.btnDVXoa);
            this.groupBoxDoanVien.Controls.Add(this.btnDVSua);
            this.groupBoxDoanVien.Controls.Add(this.btnDVThem);
            this.groupBoxDoanVien.Controls.Add(this.dataGridViewDoanVien);
            this.groupBoxDoanVien.Location = new System.Drawing.Point(52, 35);
            this.groupBoxDoanVien.Name = "groupBoxDoanVien";
            this.groupBoxDoanVien.Size = new System.Drawing.Size(1350, 638);
            this.groupBoxDoanVien.TabIndex = 0;
            this.groupBoxDoanVien.TabStop = false;
            // 
            // btnEx
            // 
            this.btnEx.Location = new System.Drawing.Point(56, 564);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(141, 53);
            this.btnEx.TabIndex = 25;
            this.btnEx.Text = "Xuất file Excel";
            this.btnEx.UseVisualStyleBackColor = true;
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTongDoanVien);
            this.groupBox4.Location = new System.Drawing.Point(469, 249);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(397, 79);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            // 
            // txtTongDoanVien
            // 
            this.txtTongDoanVien.AutoSize = true;
            this.txtTongDoanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtTongDoanVien.ForeColor = System.Drawing.Color.Red;
            this.txtTongDoanVien.Location = new System.Drawing.Point(23, 18);
            this.txtTongDoanVien.Name = "txtTongDoanVien";
            this.txtTongDoanVien.Size = new System.Drawing.Size(264, 39);
            this.txtTongDoanVien.TabIndex = 16;
            this.txtTongDoanVien.Text = "Tổng Đảng Viên";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtMaDangvien);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtDVTenSinhVien);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cbbDVMaSinhVien);
            this.groupBox3.Location = new System.Drawing.Point(6, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 148);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Đảng Viên:";
            // 
            // txtMaDangvien
            // 
            this.txtMaDangvien.Location = new System.Drawing.Point(136, 13);
            this.txtMaDangvien.Name = "txtMaDangvien";
            this.txtMaDangvien.ReadOnly = true;
            this.txtMaDangvien.Size = new System.Drawing.Size(260, 22);
            this.txtMaDangvien.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Sinh Viên:";
            // 
            // txtDVTenSinhVien
            // 
            this.txtDVTenSinhVien.Location = new System.Drawing.Point(136, 92);
            this.txtDVTenSinhVien.Name = "txtDVTenSinhVien";
            this.txtDVTenSinhVien.ReadOnly = true;
            this.txtDVTenSinhVien.Size = new System.Drawing.Size(260, 22);
            this.txtDVTenSinhVien.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tên Sinh Viên:";
            // 
            // cbbDVMaSinhVien
            // 
            this.cbbDVMaSinhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDVMaSinhVien.FormattingEnabled = true;
            this.cbbDVMaSinhVien.ItemHeight = 16;
            this.cbbDVMaSinhVien.Location = new System.Drawing.Point(136, 52);
            this.cbbDVMaSinhVien.Name = "cbbDVMaSinhVien";
            this.cbbDVMaSinhVien.Size = new System.Drawing.Size(260, 24);
            this.cbbDVMaSinhVien.TabIndex = 12;
            this.cbbDVMaSinhVien.SelectedIndexChanged += new System.EventHandler(this.DVSeclectChange);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.txtNgayVaoDoan);
            this.groupBox2.Controls.Add(this.dtNgayVaoDang);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(448, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 146);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // txtNgayVaoDoan
            // 
            this.txtNgayVaoDoan.Location = new System.Drawing.Point(137, 12);
            this.txtNgayVaoDoan.Name = "txtNgayVaoDoan";
            this.txtNgayVaoDoan.ReadOnly = true;
            this.txtNgayVaoDoan.Size = new System.Drawing.Size(259, 22);
            this.txtNgayVaoDoan.TabIndex = 20;
            // 
            // dtNgayVaoDang
            // 
            this.dtNgayVaoDang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayVaoDang.Location = new System.Drawing.Point(136, 70);
            this.dtNgayVaoDang.Name = "dtNgayVaoDang";
            this.dtNgayVaoDang.Size = new System.Drawing.Size(260, 22);
            this.dtNgayVaoDang.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày Vào Đoàn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày Vào Đảng";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDVDonVi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDVChucVu);
            this.groupBox1.Location = new System.Drawing.Point(890, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 146);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đơn Vị:";
            // 
            // txtDVDonVi
            // 
            this.txtDVDonVi.Location = new System.Drawing.Point(136, 15);
            this.txtDVDonVi.Name = "txtDVDonVi";
            this.txtDVDonVi.Size = new System.Drawing.Size(260, 22);
            this.txtDVDonVi.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Chức Vụ";
            // 
            // txtDVChucVu
            // 
            this.txtDVChucVu.Location = new System.Drawing.Point(136, 72);
            this.txtDVChucVu.Name = "txtDVChucVu";
            this.txtDVChucVu.Size = new System.Drawing.Size(260, 22);
            this.txtDVChucVu.TabIndex = 7;
            // 
            // btnDoanVienThoat
            // 
            this.btnDoanVienThoat.Location = new System.Drawing.Point(1162, 564);
            this.btnDoanVienThoat.Name = "btnDoanVienThoat";
            this.btnDoanVienThoat.Size = new System.Drawing.Size(138, 53);
            this.btnDoanVienThoat.TabIndex = 17;
            this.btnDoanVienThoat.Text = "Thoát";
            this.btnDoanVienThoat.UseVisualStyleBackColor = true;
            this.btnDoanVienThoat.Click += new System.EventHandler(this.btnDoanVienThoat_Click);
            // 
            // btnDVXoa
            // 
            this.btnDVXoa.Location = new System.Drawing.Point(1202, 207);
            this.btnDVXoa.Name = "btnDVXoa";
            this.btnDVXoa.Size = new System.Drawing.Size(124, 48);
            this.btnDVXoa.TabIndex = 15;
            this.btnDVXoa.Text = "Xóa";
            this.btnDVXoa.UseVisualStyleBackColor = true;
            this.btnDVXoa.Click += new System.EventHandler(this.btnDVXoa_Click);
            // 
            // btnDVSua
            // 
            this.btnDVSua.Location = new System.Drawing.Point(1044, 207);
            this.btnDVSua.Name = "btnDVSua";
            this.btnDVSua.Size = new System.Drawing.Size(141, 48);
            this.btnDVSua.TabIndex = 14;
            this.btnDVSua.Text = "Sửa";
            this.btnDVSua.UseVisualStyleBackColor = true;
            this.btnDVSua.Click += new System.EventHandler(this.btnDVSua_Click);
            // 
            // btnDVThem
            // 
            this.btnDVThem.Location = new System.Drawing.Point(890, 207);
            this.btnDVThem.Name = "btnDVThem";
            this.btnDVThem.Size = new System.Drawing.Size(135, 48);
            this.btnDVThem.TabIndex = 13;
            this.btnDVThem.Text = "Thêm";
            this.btnDVThem.UseVisualStyleBackColor = true;
            this.btnDVThem.Click += new System.EventHandler(this.btnDVThem_Click);
            // 
            // dataGridViewDoanVien
            // 
            this.dataGridViewDoanVien.AutoGenerateColumns = false;
            this.dataGridViewDoanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DangVienID,
            this.sinhVienIDDataGridViewTextBoxColumn,
            this.ngayVaoDoanDataGridViewTextBoxColumn,
            this.NgayKetNapDang,
            this.donViDataGridViewTextBoxColumn,
            this.chucVuDataGridViewTextBoxColumn,
            this.HoTen});
            this.dataGridViewDoanVien.DataSource = this.dangVienBindingSource2;
            this.dataGridViewDoanVien.Location = new System.Drawing.Point(56, 334);
            this.dataGridViewDoanVien.Name = "dataGridViewDoanVien";
            this.dataGridViewDoanVien.RowHeadersWidth = 51;
            this.dataGridViewDoanVien.RowTemplate.Height = 24;
            this.dataGridViewDoanVien.Size = new System.Drawing.Size(1244, 211);
            this.dataGridViewDoanVien.TabIndex = 0;
            this.dataGridViewDoanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoanVien_CellContentClick);
            // 
            // DangVienID
            // 
            this.DangVienID.DataPropertyName = "DangVienID";
            this.DangVienID.HeaderText = "DangVienID";
            this.DangVienID.MinimumWidth = 6;
            this.DangVienID.Name = "DangVienID";
            this.DangVienID.ReadOnly = true;
            this.DangVienID.Width = 125;
            // 
            // sinhVienIDDataGridViewTextBoxColumn
            // 
            this.sinhVienIDDataGridViewTextBoxColumn.DataPropertyName = "SinhVienID";
            this.sinhVienIDDataGridViewTextBoxColumn.HeaderText = "SinhVienID";
            this.sinhVienIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sinhVienIDDataGridViewTextBoxColumn.Name = "sinhVienIDDataGridViewTextBoxColumn";
            this.sinhVienIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayVaoDoanDataGridViewTextBoxColumn
            // 
            this.ngayVaoDoanDataGridViewTextBoxColumn.DataPropertyName = "NgayVaoDoan";
            this.ngayVaoDoanDataGridViewTextBoxColumn.HeaderText = "NgayVaoDoan";
            this.ngayVaoDoanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayVaoDoanDataGridViewTextBoxColumn.Name = "ngayVaoDoanDataGridViewTextBoxColumn";
            this.ngayVaoDoanDataGridViewTextBoxColumn.Width = 125;
            // 
            // NgayKetNapDang
            // 
            this.NgayKetNapDang.DataPropertyName = "NgayKetNapDang";
            this.NgayKetNapDang.HeaderText = "NgayKetNapDang";
            this.NgayKetNapDang.MinimumWidth = 6;
            this.NgayKetNapDang.Name = "NgayKetNapDang";
            this.NgayKetNapDang.Width = 125;
            // 
            // donViDataGridViewTextBoxColumn
            // 
            this.donViDataGridViewTextBoxColumn.DataPropertyName = "DonVi";
            this.donViDataGridViewTextBoxColumn.HeaderText = "DonVi";
            this.donViDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donViDataGridViewTextBoxColumn.Name = "donViDataGridViewTextBoxColumn";
            this.donViDataGridViewTextBoxColumn.Width = 125;
            // 
            // chucVuDataGridViewTextBoxColumn
            // 
            this.chucVuDataGridViewTextBoxColumn.DataPropertyName = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.HeaderText = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chucVuDataGridViewTextBoxColumn.Name = "chucVuDataGridViewTextBoxColumn";
            this.chucVuDataGridViewTextBoxColumn.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "HoTen";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 125;
            // 
            // dangVienBindingSource2
            // 
            this.dangVienBindingSource2.DataMember = "DangVien";
            this.dangVienBindingSource2.DataSource = this.qLSVDataSet_Dangvien;
            // 
            // qLSVDataSet_Dangvien
            // 
            this.qLSVDataSet_Dangvien.DataSetName = "QLSVDataSet_Dangvien";
            this.qLSVDataSet_Dangvien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dangVienTableAdapter2
            // 
            this.dangVienTableAdapter2.ClearBeforeFill = true;
            // 
            // DangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 685);
            this.Controls.Add(this.groupBoxDoanVien);
            this.Name = "DangVien";
            this.Text = "DangVien";
            this.Load += new System.EventHandler(this.DoanVien_Load);
            this.groupBoxDoanVien.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangVienBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet_Dangvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDoanVien;
        private System.Windows.Forms.DataGridView dataGridViewDoanVien;
        private System.Windows.Forms.Label txtTongDoanVien;
        private System.Windows.Forms.Button btnDVXoa;
        private System.Windows.Forms.Button btnDVSua;
        private System.Windows.Forms.Button btnDVThem;
        private System.Windows.Forms.ComboBox cbbDVMaSinhVien;
        private System.Windows.Forms.TextBox txtDVDonVi;
        private System.Windows.Forms.TextBox txtMaDangvien;
        private System.Windows.Forms.TextBox txtDVChucVu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDoanVienThoat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDVTenSinhVien;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtNgayVaoDang;
        private System.Windows.Forms.TextBox txtNgayVaoDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DangVienID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinhVienIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayVaoDoanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetNapDang;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.Button btnEx;
        private QLSVDataSet_Dangvien qLSVDataSet_Dangvien;
        private System.Windows.Forms.BindingSource dangVienBindingSource2;
        private QLSVDataSet_DangvienTableAdapters.DangVienTableAdapter dangVienTableAdapter2;
    }
}