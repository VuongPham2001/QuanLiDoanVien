
namespace QLSV
{
    partial class Lop
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
            this.grbLop = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTongLop = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLopMaLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLopTenLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbLopKhoa = new System.Windows.Forms.ComboBox();
            this.btnLopThoat = new System.Windows.Forms.Button();
            this.dataGridViewLop = new System.Windows.Forms.DataGridView();
            this.lopIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnLopXoa = new System.Windows.Forms.Button();
            this.btnLopSua = new System.Windows.Forms.Button();
            this.btnLopThem = new System.Windows.Forms.Button();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSet_Lop = new QLSV.QLSVDataSet_Lop();
            this.lopBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lopTableAdapter2 = new QLSV.QLSVDataSet_LopTableAdapters.LopTableAdapter();
            this.grbLop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet_Lop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // grbLop
            // 
            this.grbLop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grbLop.Controls.Add(this.groupBox2);
            this.grbLop.Controls.Add(this.groupBox1);
            this.grbLop.Controls.Add(this.btnLopThoat);
            this.grbLop.Controls.Add(this.dataGridViewLop);
            this.grbLop.Controls.Add(this.btnLopXoa);
            this.grbLop.Controls.Add(this.btnLopSua);
            this.grbLop.Controls.Add(this.btnLopThem);
            this.grbLop.Location = new System.Drawing.Point(109, 43);
            this.grbLop.Name = "grbLop";
            this.grbLop.Size = new System.Drawing.Size(1065, 412);
            this.grbLop.TabIndex = 0;
            this.grbLop.TabStop = false;
            this.grbLop.Enter += new System.EventHandler(this.grbLop_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTongLop);
            this.groupBox2.Location = new System.Drawing.Point(523, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 81);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtTongLop
            // 
            this.txtTongLop.AutoSize = true;
            this.txtTongLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtTongLop.ForeColor = System.Drawing.Color.Red;
            this.txtTongLop.Location = new System.Drawing.Point(95, 18);
            this.txtTongLop.Name = "txtTongLop";
            this.txtTongLop.Size = new System.Drawing.Size(170, 39);
            this.txtTongLop.TabIndex = 10;
            this.txtTongLop.Text = "Tổng Lớp:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLopMaLop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLopTenLop);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbLopKhoa);
            this.groupBox1.Location = new System.Drawing.Point(49, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 213);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Lớp:";
            // 
            // txtLopMaLop
            // 
            this.txtLopMaLop.Location = new System.Drawing.Point(130, 42);
            this.txtLopMaLop.Name = "txtLopMaLop";
            this.txtLopMaLop.ReadOnly = true;
            this.txtLopMaLop.Size = new System.Drawing.Size(121, 22);
            this.txtLopMaLop.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Lớp:";
            // 
            // txtLopTenLop
            // 
            this.txtLopTenLop.Location = new System.Drawing.Point(130, 78);
            this.txtLopTenLop.Name = "txtLopTenLop";
            this.txtLopTenLop.Size = new System.Drawing.Size(121, 22);
            this.txtLopTenLop.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khoa:";
            // 
            // cbbLopKhoa
            // 
            this.cbbLopKhoa.FormattingEnabled = true;
            this.cbbLopKhoa.Location = new System.Drawing.Point(130, 154);
            this.cbbLopKhoa.Name = "cbbLopKhoa";
            this.cbbLopKhoa.Size = new System.Drawing.Size(121, 24);
            this.cbbLopKhoa.TabIndex = 5;
            // 
            // btnLopThoat
            // 
            this.btnLopThoat.Location = new System.Drawing.Point(900, 339);
            this.btnLopThoat.Name = "btnLopThoat";
            this.btnLopThoat.Size = new System.Drawing.Size(89, 40);
            this.btnLopThoat.TabIndex = 11;
            this.btnLopThoat.Text = "Thoát";
            this.btnLopThoat.UseVisualStyleBackColor = true;
            this.btnLopThoat.Click += new System.EventHandler(this.btnLopThoat_Click);
            // 
            // dataGridViewLop
            // 
            this.dataGridViewLop.AutoGenerateColumns = false;
            this.dataGridViewLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lopIDDataGridViewTextBoxColumn,
            this.tenLopDataGridViewTextBoxColumn,
            this.khoaIDDataGridViewTextBoxColumn});
            this.dataGridViewLop.DataSource = this.lopBindingSource2;
            this.dataGridViewLop.Location = new System.Drawing.Point(404, 99);
            this.dataGridViewLop.Name = "dataGridViewLop";
            this.dataGridViewLop.RowHeadersWidth = 51;
            this.dataGridViewLop.RowTemplate.Height = 24;
            this.dataGridViewLop.Size = new System.Drawing.Size(585, 213);
            this.dataGridViewLop.TabIndex = 9;
            this.dataGridViewLop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLop_CellContentClick);
            // 
            // lopIDDataGridViewTextBoxColumn
            // 
            this.lopIDDataGridViewTextBoxColumn.DataPropertyName = "LopID";
            this.lopIDDataGridViewTextBoxColumn.HeaderText = "LopID";
            this.lopIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lopIDDataGridViewTextBoxColumn.Name = "lopIDDataGridViewTextBoxColumn";
            this.lopIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.lopIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenLopDataGridViewTextBoxColumn
            // 
            this.tenLopDataGridViewTextBoxColumn.DataPropertyName = "TenLop";
            this.tenLopDataGridViewTextBoxColumn.HeaderText = "TenLop";
            this.tenLopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenLopDataGridViewTextBoxColumn.Name = "tenLopDataGridViewTextBoxColumn";
            this.tenLopDataGridViewTextBoxColumn.Width = 125;
            // 
            // khoaIDDataGridViewTextBoxColumn
            // 
            this.khoaIDDataGridViewTextBoxColumn.DataPropertyName = "KhoaID";
            this.khoaIDDataGridViewTextBoxColumn.HeaderText = "KhoaID";
            this.khoaIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.khoaIDDataGridViewTextBoxColumn.Name = "khoaIDDataGridViewTextBoxColumn";
            this.khoaIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // 
            // btnLopXoa
            // 
            this.btnLopXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLopXoa.Location = new System.Drawing.Point(311, 340);
            this.btnLopXoa.Name = "btnLopXoa";
            this.btnLopXoa.Size = new System.Drawing.Size(77, 40);
            this.btnLopXoa.TabIndex = 8;
            this.btnLopXoa.Text = "Xóa";
            this.btnLopXoa.UseVisualStyleBackColor = true;
            this.btnLopXoa.Click += new System.EventHandler(this.btnLopXoa_Click);
            // 
            // btnLopSua
            // 
            this.btnLopSua.Location = new System.Drawing.Point(179, 341);
            this.btnLopSua.Name = "btnLopSua";
            this.btnLopSua.Size = new System.Drawing.Size(76, 39);
            this.btnLopSua.TabIndex = 7;
            this.btnLopSua.Text = "Sửa";
            this.btnLopSua.UseVisualStyleBackColor = true;
            this.btnLopSua.Click += new System.EventHandler(this.btnLopSua_Click);
            // 
            // btnLopThem
            // 
            this.btnLopThem.Location = new System.Drawing.Point(49, 340);
            this.btnLopThem.Name = "btnLopThem";
            this.btnLopThem.Size = new System.Drawing.Size(83, 39);
            this.btnLopThem.TabIndex = 6;
            this.btnLopThem.Text = "Thêm";
            this.btnLopThem.UseVisualStyleBackColor = true;
            this.btnLopThem.Click += new System.EventHandler(this.btnLopThem_Click);
            // 
            // qLSVDataSet_Lop
            // 
            this.qLSVDataSet_Lop.DataSetName = "QLSVDataSet_Lop";
            this.qLSVDataSet_Lop.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lopBindingSource2
            // 
            this.lopBindingSource2.DataMember = "Lop";
            this.lopBindingSource2.DataSource = this.qLSVDataSet_Lop;
            // 
            // lopTableAdapter2
            // 
            this.lopTableAdapter2.ClearBeforeFill = true;
            // 
            // Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 500);
            this.Controls.Add(this.grbLop);
            this.Name = "Lop";
            this.Text = "Lop";
            this.Load += new System.EventHandler(this.Lop_Load);
            this.grbLop.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet_Lop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLop;
        private System.Windows.Forms.DataGridView dataGridViewLop;
        private System.Windows.Forms.Button btnLopXoa;
        private System.Windows.Forms.Button btnLopSua;
        private System.Windows.Forms.Button btnLopThem;
        private System.Windows.Forms.ComboBox cbbLopKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLopTenLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLopMaLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private System.Windows.Forms.BindingSource lopBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lopIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label txtTongLop;
        private System.Windows.Forms.Button btnLopThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private QLSVDataSet_Lop qLSVDataSet_Lop;
        private System.Windows.Forms.BindingSource lopBindingSource2;
        private QLSVDataSet_LopTableAdapters.LopTableAdapter lopTableAdapter2;
    }
}