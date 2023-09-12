
namespace QLSV
{
    partial class TimKiemSV
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiemSV = new System.Windows.Forms.TextBox();
            this.btnTimKiemThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.sinhVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSet8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSet_TKSV = new QLSV.QLSVDataSet_TKSV();
            this.sinhVienBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter2 = new QLSV.QLSVDataSet_TKSVTableAdapters.SinhVienTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet8BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet_TKSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnTimKiemThoat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(44, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1125, 520);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTimKiemSV);
            this.groupBox2.Location = new System.Drawing.Point(110, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(908, 75);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập thông tin:";
            // 
            // txtTimKiemSV
            // 
            this.txtTimKiemSV.Location = new System.Drawing.Point(182, 28);
            this.txtTimKiemSV.Name = "txtTimKiemSV";
            this.txtTimKiemSV.Size = new System.Drawing.Size(611, 22);
            this.txtTimKiemSV.TabIndex = 3;
            this.txtTimKiemSV.TextChanged += new System.EventHandler(this.txtTimKiemSV_TextChanged);
            // 
            // btnTimKiemThoat
            // 
            this.btnTimKiemThoat.Location = new System.Drawing.Point(891, 455);
            this.btnTimKiemThoat.Name = "btnTimKiemThoat";
            this.btnTimKiemThoat.Size = new System.Drawing.Size(184, 59);
            this.btnTimKiemThoat.TabIndex = 6;
            this.btnTimKiemThoat.Text = "Thoát";
            this.btnTimKiemThoat.UseVisualStyleBackColor = true;
            this.btnTimKiemThoat.Click += new System.EventHandler(this.btnTimKiemThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(259, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(587, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tìm Kiếm Thông Tin Sinh Viên";
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
            this.NgayVaoDoan});
            this.dataGridView1.DataSource = this.sinhVienBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(65, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 256);
            this.dataGridView1.TabIndex = 4;
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
            // qLSVDataSet_TKSV
            // 
            this.qLSVDataSet_TKSV.DataSetName = "QLSVDataSet_TKSV";
            this.qLSVDataSet_TKSV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhVienBindingSource2
            // 
            this.sinhVienBindingSource2.DataMember = "SinhVien";
            this.sinhVienBindingSource2.DataSource = this.qLSVDataSet_TKSV;
            // 
            // sinhVienTableAdapter2
            // 
            this.sinhVienTableAdapter2.ClearBeforeFill = true;
            // 
            // TimKiemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 565);
            this.Controls.Add(this.groupBox1);
            this.Name = "TimKiemSV";
            this.Text = "TimKiemSV";
            this.Load += new System.EventHandler(this.TimKiemSV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet8BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet_TKSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimKiemSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiemThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource qLSVDataSet8BindingSource;
        private System.Windows.Forms.BindingSource sinhVienBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinhVienIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gioiTinhDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lopIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayVaoDoan;
        private QLSVDataSet_TKSV qLSVDataSet_TKSV;
        private System.Windows.Forms.BindingSource sinhVienBindingSource2;
        private QLSVDataSet_TKSVTableAdapters.SinhVienTableAdapter sinhVienTableAdapter2;
    }
}