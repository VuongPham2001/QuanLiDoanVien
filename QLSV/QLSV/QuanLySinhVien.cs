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
    public partial class QuanLySinhVien : Form
    {
        SqlConnection connecton;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-RHJ3B39\SQL;Initial Catalog=QLSV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tableSinhVien = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataTable tableSinhVien1 = new DataTable();
        void LoadDataSinhVien()
        {
            command = connecton.CreateCommand();
            command.CommandText = "SELECT * FROM SinhVien ";
            adapter.SelectCommand = command;
            tableSinhVien.Clear();
            adapter.Fill(tableSinhVien);
            dataGridView1.DataSource = tableSinhVien;
            command = connecton.CreateCommand();
            command.CommandText = "SELECT * FROM Lop ";
            adapter1.SelectCommand = command;
            tableSinhVien1.Clear();
            adapter1.Fill(tableSinhVien1);
            cbbLop.DataSource = tableSinhVien1;
            cbbLop.DisplayMember = "TenLop";
            cbbLop.ValueMember = "LopID";
        }

        public QuanLySinhVien()
        {
            InitializeComponent();
        }

        private void QuanLySinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSet_Sinhvien.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter3.Fill(this.qLSVDataSet_Sinhvien.SinhVien);
            connecton = new SqlConnection(str);
            connecton.Open();
            LoadDataSinhVien();
            labTongSinhVien.Text = "Tổng Sinh viên: " + (dataGridView1.Rows.Count-1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtMaSinhVien.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtHoVaTen.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            dateNgaySinh.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            if (dataGridView1.Rows[i].Cells[3].Value.ToString() == "True")
            {
                cbbSinhVienGioiTinh.Text = "Nam";
            }else
            {
                cbbSinhVienGioiTinh.Text = "Nữ";
            }    
            txtDiaChi.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            string query = "SELECT TenLop FROM Lop WHERE LopID = @LopID";

            // Tạo đối tượng SqlCommand để thực thi truy vấn SQL
            SqlCommand command = new SqlCommand(query, connecton);

            // Thêm tham số cho truy vấn SQL
            command.Parameters.AddWithValue("@LopID", dataGridView1.Rows[i].Cells[7].Value.ToString());
            String TenLop = (String)command.ExecuteScalar();
            cbbLop.Text = TenLop;
            txtEmail.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtSoDienThoai.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            dtNgayVaoDoan.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            txtDonViQLSV.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            textChucVuQLSV.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
            labTongSinhVien.Text = "Tổng Sinh viên: " + (dataGridView1.Rows.Count - 1);

        }

        private void btnSVThem_Click(object sender, EventArgs e)
        {
            Boolean sex;
            if (cbbSinhVienGioiTinh.Text == "Nam")
            {
                sex = true;
            }else
            {
                sex = false;
            }

            // Tạo truy vấn SQL để tìm kiếm ID của lớp có TenLop trùng với giá trị được chọn trong ComboBox
            string query = "SELECT LopID FROM Lop WHERE TenLop = @TenLop";

            // Tạo đối tượng SqlCommand để thực thi truy vấn SQL
            SqlCommand command = new SqlCommand(query, connecton);

            // Thêm tham số cho truy vấn SQL
            command.Parameters.AddWithValue("@TenLop", cbbLop.Text);
            // Thực thi truy vấn SQL và lấy ra ID của lớp
            int lopID = (int)command.ExecuteScalar();
            command = connecton.CreateCommand();
            command.CommandText = "INSERT INTO SinhVien VALUES(N'" + txtHoVaTen.Text + "','" + dateNgaySinh.Text + "','" + sex + "',N'" + txtDiaChi.Text + "','" + txtEmail.Text + "','" + txtSoDienThoai.Text + "','" + dtNgayVaoDoan.Text + "','" + lopID + "',N'" + txtDonViQLSV.Text + "',N'" + textChucVuQLSV.Text + "')";
            command.ExecuteNonQuery();
            LoadDataSinhVien();
            MessageBox.Show("Thêm thành công ");
            txtMaSinhVien.Text = "";
            txtHoVaTen.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSoDienThoai.Text = "";
            txtDonViQLSV.Text = "";
            textChucVuQLSV.Text = "";
            labTongSinhVien.Text = "Tổng Sinh viên: " + (dataGridView1.Rows.Count - 1);
        }

        private void btnSVSua_Click(object sender, EventArgs e)
        {

            Boolean sex;
            if (cbbSinhVienGioiTinh.Text == "Nam")
            {
                sex = true;
            }
            else
            {
                sex = false;
            }

            // Tạo truy vấn SQL để tìm kiếm ID của lớp có TenLop trùng với giá trị được chọn trong ComboBox
            string query = "SELECT LopID FROM Lop WHERE TenLop = @TenLop";

            // Tạo đối tượng SqlCommand để thực thi truy vấn SQL
            SqlCommand command = new SqlCommand(query, connecton);

            // Thêm tham số cho truy vấn SQL
            command.Parameters.AddWithValue("@TenLop", cbbLop.Text);

            // Thực thi truy vấn SQL và lấy ra ID của lớp
            int lopID = (int)command.ExecuteScalar();
            command = connecton.CreateCommand();
            command.CommandText = "UPDATE SinhVien SET HoTen=N'" + txtHoVaTen.Text + "',NgaySinh='" + dateNgaySinh.Text + "',GioiTinh='" + sex + "',DiaChi=N'" + txtDiaChi.Text + "',Email='" + txtEmail.Text + "',DienThoai='" + txtSoDienThoai.Text + "',NgayVaoDoan='" + dtNgayVaoDoan.Text + "', LopID='" + lopID + "',DonVi=N'" + txtDonViQLSV.Text + "',ChucVu=N'" + textChucVuQLSV.Text + "' where SinhVienID = @SinhVienID";
            command.Parameters.AddWithValue("@SinhVienID", txtMaSinhVien.Text);
            command.ExecuteNonQuery();
            LoadDataSinhVien();
            MessageBox.Show("Sửa thành công ");
            txtMaSinhVien.Text = "";
            txtHoVaTen.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSoDienThoai.Text = "";
            txtDonViQLSV.Text = "";
            textChucVuQLSV.Text = "";
            labTongSinhVien.Text = "Tổng Sinh viên: " + (dataGridView1.Rows.Count - 1);
        }

        private void btnSVXoa_Click(object sender, EventArgs e)
        {
            command = connecton.CreateCommand();
            command.CommandText = "DELETE FROM SinhVien where SinhVienID='" + txtMaSinhVien.Text + "'";
            command.ExecuteNonQuery();
            LoadDataSinhVien();
            MessageBox.Show("Xóa thành công ");
            txtMaSinhVien.Text = "";
            txtHoVaTen.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSoDienThoai.Text = "";
            txtDonViQLSV.Text = "";
            textChucVuQLSV.Text = "";
            labTongSinhVien.Text = "Tổng Sinh viên: " + (dataGridView1.Rows.Count - 1);
        }

        private void btnSinhVienThoat_Click(object sender, EventArgs e)
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

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 1, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
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
