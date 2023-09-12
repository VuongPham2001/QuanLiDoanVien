using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using Excel = Microsoft.Office.Interop.Excel;

namespace QLSV
{
    public partial class DangVien : Form
    {
        SqlConnection connecton;
        SqlCommand command;
        string strDoanVien = @"Data Source=DESKTOP-RHJ3B39\SQL;Initial Catalog=QLSV;Integrated Security=True";
        SqlDataAdapter adapterDangVien = new SqlDataAdapter();
        DataTable tableDangVien = new DataTable();
        SqlDataAdapter adapterDangVien1 = new SqlDataAdapter();
        DataTable tableDangVien1 = new DataTable();
        void LoadDataDoanVien()
        {
            command = connecton.CreateCommand();
            command.CommandText = "SELECT * FROM DangVien ";
            adapterDangVien.SelectCommand = command;
            tableDangVien.Clear();
            adapterDangVien.Fill(tableDangVien);
            dataGridViewDoanVien.DataSource = tableDangVien;
            command = connecton.CreateCommand();
            command.CommandText = "SELECT * FROM SinhVien ";
            adapterDangVien1.SelectCommand = command;
            tableDangVien1.Clear();
            adapterDangVien1.Fill(tableDangVien1);
            cbbDVMaSinhVien.DataSource = tableDangVien1;
            cbbDVMaSinhVien.DisplayMember = "SinhVienID";
            cbbDVMaSinhVien.ValueMember = "SinhVienID";
        }
        public DangVien()
        {
            InitializeComponent();
        }

        private void DoanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSet_Dangvien.DangVien' table. You can move, or remove it, as needed.
            this.dangVienTableAdapter2.Fill(this.qLSVDataSet_Dangvien.DangVien);
            connecton = new SqlConnection(strDoanVien);
            connecton.Open();
            LoadDataDoanVien();
            txtTongDoanVien.Text = "Tổng Đảng Viên: " + (dataGridViewDoanVien.Rows.Count - 1);
        }

        private void btnDoanVienThoat_Click(object sender, EventArgs e)
        {
            QuanLy mfrm = new QuanLy();
            mfrm.Show();
            this.Hide();
            // Đóng Form1 và chạy Form2
            // Đóng Form1
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "Form1")
                {
                    f.Close();
                    break;
                }
            }
        }

        private void dataGridViewDoanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridViewDoanVien.CurrentRow.Index;
            txtMaDangvien.Text=dataGridViewDoanVien.Rows[i].Cells[0].Value.ToString();
            string query = "SELECT HoTen FROM SinhVien WHERE SinhVienID = @SinhVienID";

            // Tạo đối tượng SqlCommand để thực thi truy vấn SQL
            SqlCommand command = new SqlCommand(query, connecton);

            // Thêm tham số cho truy vấn SQL
            command.Parameters.AddWithValue("@SinhVienID", dataGridViewDoanVien.Rows[i].Cells[1].Value.ToString());
            String HoTen = (String)command.ExecuteScalar();
            cbbDVMaSinhVien.Text = dataGridViewDoanVien.Rows[i].Cells[1].Value.ToString();
            txtNgayVaoDoan.Text = dataGridViewDoanVien.Rows[i].Cells[2].Value.ToString();
            dtNgayVaoDang.Text = dataGridViewDoanVien.Rows[i].Cells[3].Value.ToString();
            txtDVDonVi.Text= dataGridViewDoanVien.Rows[i].Cells[4].Value.ToString();
            txtDVChucVu.Text= dataGridViewDoanVien.Rows[i].Cells[5].Value.ToString();
            txtDVTenSinhVien.Text = dataGridViewDoanVien.Rows[i].Cells[6].Value.ToString();
            txtTongDoanVien.Text = "Tổng Đảng Viên: " + (dataGridViewDoanVien.Rows.Count - 1);
        }

        private void btnDVThem_Click(object sender, EventArgs e)
        {
            command = connecton.CreateCommand();
            command.CommandText = "INSERT INTO DangVien VALUES(N'" + cbbDVMaSinhVien.Text + "',N'" + txtDVTenSinhVien.Text + "','" + txtNgayVaoDoan.Text + "','" + dtNgayVaoDang.Text + "',N'" + txtDVDonVi.Text + "',N'" + txtDVChucVu.Text + "')";
            command.ExecuteNonQuery();
            LoadDataDoanVien();
            MessageBox.Show("Thêm thành công");
            cbbDVMaSinhVien.Text = "";
            txtDVTenSinhVien.Text = "";
            txtMaDangvien.Text = "";
            dtNgayVaoDang.Text = "";
            txtDVDonVi.Text = "";
            txtDVChucVu.Text = "";
            txtTongDoanVien.Text = "Tổng Đảng Viên: " + (dataGridViewDoanVien.Rows.Count - 1);
        }

        private void btnDVSua_Click(object sender, EventArgs e)
        {
            command = connecton.CreateCommand();
            command.CommandText = "UPDATE DangVien SET ChucVu='" + txtDVChucVu.Text + "',DonVi='" + txtDVDonVi.Text + "',NgayKetNapDang='" + dtNgayVaoDang.Text + "' where DangVienID = @DangVienID";
            command.Parameters.AddWithValue("@DangVienID", txtMaDangvien.Text);
            command.ExecuteNonQuery();
            LoadDataDoanVien();
            MessageBox.Show("Sửa thành công ");
            cbbDVMaSinhVien.Text = "";
            txtMaDangvien.Text = "";
            dtNgayVaoDang.Text = "";
            txtDVDonVi.Text = "";
            txtDVChucVu.Text = "";
            txtTongDoanVien.Text = "Tổng Đoàn Viên: " + (dataGridViewDoanVien.Rows.Count - 1);
        }

        private void btnDVXoa_Click(object sender, EventArgs e)
        {
            command = connecton.CreateCommand();
            command.CommandText = "DELETE FROM DangVien where DangVienID='" + txtMaDangvien.Text + "'";
            command.ExecuteNonQuery();
            LoadDataDoanVien();
            MessageBox.Show("Xóa thành công ");
            cbbDVMaSinhVien.Text = "";
            txtMaDangvien.Text = "";
            dtNgayVaoDang.Text = "";
            txtDVDonVi.Text = "";
            txtDVChucVu.Text = "";
            txtTongDoanVien.Text = "Tổng Đảng Viên: " + (dataGridViewDoanVien.Rows.Count - 1);
        }

        private void DVSeclectChange(object sender, EventArgs e)
        {
            string query = "SELECT HoTen FROM SinhVien WHERE SinhVienID = @SinhVienID";
            SqlCommand command = new SqlCommand(query, connecton);
            if (cbbDVMaSinhVien.Text != "System.Data.DataRowView")
            {
                command.Parameters.AddWithValue("@SinhVienID", cbbDVMaSinhVien.Text);
                string TenSV = (string)command.ExecuteScalar();
                txtDVTenSinhVien.Text = TenSV;
            }
            query = "SELECT NgayVaoDoan FROM SinhVien WHERE SinhVienID = @SinhVienID";
            command = new SqlCommand(query, connecton);
            if (cbbDVMaSinhVien.Text != "System.Data.DataRowView")
            {
                command.Parameters.AddWithValue("@SinhVienID", cbbDVMaSinhVien.Text);
                string NgayVaoDoan = (string)command.ExecuteScalar();
                txtNgayVaoDoan.Text = NgayVaoDoan;
            }
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = null;

            try
            {
                worksheet = (Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet = (Excel.Worksheet)workbook.ActiveSheet;
                worksheet.Name = "ExportedFromDataGridView";

                for (int i = 0; i < dataGridViewDoanVien.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridViewDoanVien.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 1, j + 1] = dataGridViewDoanVien.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // Lưu workbook dưới dạng tệp Excel
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }
    }
}
