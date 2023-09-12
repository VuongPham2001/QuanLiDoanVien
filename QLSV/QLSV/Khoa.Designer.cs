
namespace QLSV
{
    partial class Khoa
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
            this.grbKhoa = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTongKhoa = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtkhoaMaKhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKhoaTenKhoa = new System.Windows.Forms.TextBox();
            this.btnKhoaThoat = new System.Windows.Forms.Button();
            this.btnKhoaXoa = new System.Windows.Forms.Button();
            this.btnKhoaSua = new System.Windows.Forms.Button();
            this.btnKhoaThem = new System.Windows.Forms.Button();
            this.dataGridViewKhoa = new System.Windows.Forms.DataGridView();
            this.khoaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSet_Khoa = new QLSV.QLSVDataSet_Khoa();
            this.khoaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.khoaTableAdapter1 = new QLSV.QLSVDataSet_KhoaTableAdapters.KhoaTableAdapter();
            this.grbKhoa.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet_Khoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbKhoa
            // 
            this.grbKhoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grbKhoa.Controls.Add(this.groupBox2);
            this.grbKhoa.Controls.Add(this.groupBox1);
            this.grbKhoa.Controls.Add(this.btnKhoaThoat);
            this.grbKhoa.Controls.Add(this.btnKhoaXoa);
            this.grbKhoa.Controls.Add(this.btnKhoaSua);
            this.grbKhoa.Controls.Add(this.btnKhoaThem);
            this.grbKhoa.Controls.Add(this.dataGridViewKhoa);
            this.grbKhoa.Location = new System.Drawing.Point(49, 41);
            this.grbKhoa.Name = "grbKhoa";
            this.grbKhoa.Size = new System.Drawing.Size(1016, 372);
            this.grbKhoa.TabIndex = 0;
            this.grbKhoa.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTongKhoa);
            this.groupBox2.Location = new System.Drawing.Point(571, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 77);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // txtTongKhoa
            // 
            this.txtTongKhoa.AutoSize = true;
            this.txtTongKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtTongKhoa.ForeColor = System.Drawing.Color.Red;
            this.txtTongKhoa.Location = new System.Drawing.Point(26, 18);
            this.txtTongKhoa.Name = "txtTongKhoa";
            this.txtTongKhoa.Size = new System.Drawing.Size(184, 39);
            this.txtTongKhoa.TabIndex = 5;
            this.txtTongKhoa.Text = "Tổng Khóa";
            this.txtTongKhoa.Click += new System.EventHandler(this.txtTongKhoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtkhoaMaKhoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKhoaTenKhoa);
            this.groupBox1.Location = new System.Drawing.Point(41, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 171);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khoa:";
            // 
            // txtkhoaMaKhoa
            // 
            this.txtkhoaMaKhoa.Location = new System.Drawing.Point(113, 45);
            this.txtkhoaMaKhoa.Name = "txtkhoaMaKhoa";
            this.txtkhoaMaKhoa.ReadOnly = true;
            this.txtkhoaMaKhoa.Size = new System.Drawing.Size(268, 22);
            this.txtkhoaMaKhoa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khoa:";
            // 
            // txtKhoaTenKhoa
            // 
            this.txtKhoaTenKhoa.Location = new System.Drawing.Point(113, 101);
            this.txtKhoaTenKhoa.Name = "txtKhoaTenKhoa";
            this.txtKhoaTenKhoa.Size = new System.Drawing.Size(268, 22);
            this.txtKhoaTenKhoa.TabIndex = 3;
            // 
            // btnKhoaThoat
            // 
            this.btnKhoaThoat.Location = new System.Drawing.Point(869, 313);
            this.btnKhoaThoat.Name = "btnKhoaThoat";
            this.btnKhoaThoat.Size = new System.Drawing.Size(113, 35);
            this.btnKhoaThoat.TabIndex = 9;
            this.btnKhoaThoat.Text = "Thoát";
            this.btnKhoaThoat.UseVisualStyleBackColor = true;
            this.btnKhoaThoat.Click += new System.EventHandler(this.btnKhoaThoat_Click);
            // 
            // btnKhoaXoa
            // 
            this.btnKhoaXoa.Location = new System.Drawing.Point(335, 313);
            this.btnKhoaXoa.Name = "btnKhoaXoa";
            this.btnKhoaXoa.Size = new System.Drawing.Size(103, 35);
            this.btnKhoaXoa.TabIndex = 8;
            this.btnKhoaXoa.Text = "Xóa";
            this.btnKhoaXoa.UseVisualStyleBackColor = true;
            this.btnKhoaXoa.Click += new System.EventHandler(this.btnKhoaXoa_Click);
            // 
            // btnKhoaSua
            // 
            this.btnKhoaSua.Location = new System.Drawing.Point(196, 313);
            this.btnKhoaSua.Name = "btnKhoaSua";
            this.btnKhoaSua.Size = new System.Drawing.Size(107, 35);
            this.btnKhoaSua.TabIndex = 7;
            this.btnKhoaSua.Text = "Sửa";
            this.btnKhoaSua.UseVisualStyleBackColor = true;
            this.btnKhoaSua.Click += new System.EventHandler(this.btnKhoaSua_Click);
            // 
            // btnKhoaThem
            // 
            this.btnKhoaThem.Location = new System.Drawing.Point(59, 314);
            this.btnKhoaThem.Name = "btnKhoaThem";
            this.btnKhoaThem.Size = new System.Drawing.Size(106, 34);
            this.btnKhoaThem.TabIndex = 6;
            this.btnKhoaThem.Text = "Thêm";
            this.btnKhoaThem.UseVisualStyleBackColor = true;
            this.btnKhoaThem.Click += new System.EventHandler(this.btnKhoaThem_Click);
            // 
            // dataGridViewKhoa
            // 
            this.dataGridViewKhoa.AutoGenerateColumns = false;
            this.dataGridViewKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.khoaIDDataGridViewTextBoxColumn,
            this.tenKhoaDataGridViewTextBoxColumn});
            this.dataGridViewKhoa.DataSource = this.khoaBindingSource1;
            this.dataGridViewKhoa.Location = new System.Drawing.Point(496, 92);
            this.dataGridViewKhoa.Name = "dataGridViewKhoa";
            this.dataGridViewKhoa.RowHeadersWidth = 51;
            this.dataGridViewKhoa.RowTemplate.Height = 24;
            this.dataGridViewKhoa.Size = new System.Drawing.Size(486, 171);
            this.dataGridViewKhoa.TabIndex = 4;
            this.dataGridViewKhoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKhoa_CellContentClick);
            // 
            // khoaIDDataGridViewTextBoxColumn
            // 
            this.khoaIDDataGridViewTextBoxColumn.DataPropertyName = "KhoaID";
            this.khoaIDDataGridViewTextBoxColumn.HeaderText = "KhoaID";
            this.khoaIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.khoaIDDataGridViewTextBoxColumn.Name = "khoaIDDataGridViewTextBoxColumn";
            this.khoaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.khoaIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenKhoaDataGridViewTextBoxColumn
            // 
            this.tenKhoaDataGridViewTextBoxColumn.DataPropertyName = "TenKhoa";
            this.tenKhoaDataGridViewTextBoxColumn.HeaderText = "TenKhoa";
            this.tenKhoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenKhoaDataGridViewTextBoxColumn.Name = "tenKhoaDataGridViewTextBoxColumn";
            this.tenKhoaDataGridViewTextBoxColumn.Width = 125;
            // 
                     // 
            // qLSVDataSet_Khoa
            // 
            this.qLSVDataSet_Khoa.DataSetName = "QLSVDataSet_Khoa";
            this.qLSVDataSet_Khoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoaBindingSource1
            // 
            this.khoaBindingSource1.DataMember = "Khoa";
            this.khoaBindingSource1.DataSource = this.qLSVDataSet_Khoa;
            // 
            // khoaTableAdapter1
            // 
            this.khoaTableAdapter1.ClearBeforeFill = true;
            // 
            // Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 450);
            this.Controls.Add(this.grbKhoa);
            this.Name = "Khoa";
            this.Text = "Khoa";
            this.Load += new System.EventHandler(this.Khoa_Load);
            this.grbKhoa.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet_Khoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbKhoa;
        private System.Windows.Forms.DataGridView dataGridViewKhoa;
        private System.Windows.Forms.TextBox txtKhoaTenKhoa;
        private System.Windows.Forms.TextBox txtkhoaMaKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private System.Windows.Forms.Button btnKhoaXoa;
        private System.Windows.Forms.Button btnKhoaSua;
        private System.Windows.Forms.Button btnKhoaThem;
        private System.Windows.Forms.Label txtTongKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnKhoaThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private QLSVDataSet_Khoa qLSVDataSet_Khoa;
        private System.Windows.Forms.BindingSource khoaBindingSource1;
        private QLSVDataSet_KhoaTableAdapters.KhoaTableAdapter khoaTableAdapter1;
    }
}