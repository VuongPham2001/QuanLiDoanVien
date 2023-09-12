
namespace QLSV
{
    partial class TimKiemDV
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
            this.txtTimKiemDV = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DangVienID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhVienIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayVaoDoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetNapDang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dangVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dangVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSet_TKDV = new QLSV.QLSVDataSet_TKDV();
            this.dangVienBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dangVienTableAdapter2 = new QLSV.QLSVDataSet_TKDVTableAdapters.DangVienTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet_TKDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangVienBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(81, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1169, 581);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTimKiemDV);
            this.groupBox2.Location = new System.Drawing.Point(175, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(846, 90);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập Thông Tin:";
            // 
            // txtTimKiemDV
            // 
            this.txtTimKiemDV.Location = new System.Drawing.Point(237, 41);
            this.txtTimKiemDV.Name = "txtTimKiemDV";
            this.txtTimKiemDV.Size = new System.Drawing.Size(481, 22);
            this.txtTimKiemDV.TabIndex = 3;
            this.txtTimKiemDV.TextChanged += new System.EventHandler(this.txtTimKiemDV_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(904, 509);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DangVienID,
            this.sinhVienIDDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.ngayVaoDoanDataGridViewTextBoxColumn,
            this.NgayKetNapDang,
            this.donViDataGridViewTextBoxColumn,
            this.chucVuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dangVienBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(118, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(955, 282);
            this.dataGridView1.TabIndex = 4;
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
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.Width = 125;
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(405, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm Kiếm Đảng Viên";
            // 
            // 
            // qLSVDataSet_TKDV
            // 
            this.qLSVDataSet_TKDV.DataSetName = "QLSVDataSet_TKDV";
            this.qLSVDataSet_TKDV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dangVienBindingSource2
            // 
            this.dangVienBindingSource2.DataMember = "DangVien";
            this.dangVienBindingSource2.DataSource = this.qLSVDataSet_TKDV;
            // 
            // dangVienTableAdapter2
            // 
            this.dangVienTableAdapter2.ClearBeforeFill = true;
            // 
            // TimKiemDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 662);
            this.Controls.Add(this.groupBox1);
            this.Name = "TimKiemDV";
            this.Text = "TimKiemDV";
            this.Load += new System.EventHandler(this.TimKiemDV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet_TKDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangVienBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimKiemDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource doanVienBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource dangVienBindingSource;
        private System.Windows.Forms.BindingSource dangVienBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DangVienID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinhVienIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayVaoDoanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetNapDang;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn;
        private QLSVDataSet_TKDV qLSVDataSet_TKDV;
        private System.Windows.Forms.BindingSource dangVienBindingSource2;
        private QLSVDataSet_TKDVTableAdapters.DangVienTableAdapter dangVienTableAdapter2;
    }
}