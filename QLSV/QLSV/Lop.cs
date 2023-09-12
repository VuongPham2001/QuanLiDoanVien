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
namespace QLSV
{
    public partial class Lop : Form
    {
        SqlConnection connecton;
        SqlCommand command;
        string strLop = @"Data Source=DESKTOP-RHJ3B39\SQL;Initial Catalog=QLSV;Integrated Security=True";
        SqlDataAdapter adapterLop = new SqlDataAdapter();
        DataTable tableLop = new DataTable();
        SqlDataAdapter adapterLop1 = new SqlDataAdapter();
        DataTable tableLop1 = new DataTable();

        void LoadDataLop()
        {
            command = connecton.CreateCommand();
            command.CommandText = "SELECT * FROM Lop ";
            adapterLop.SelectCommand = command;
            tableLop.Clear();
            adapterLop.Fill(tableLop);
            dataGridViewLop.DataSource = tableLop;
            command = connecton.CreateCommand();
            command.CommandText = "SELECT * FROM Khoa ";
            adapterLop1.SelectCommand = command;
            tableLop1.Clear();
            adapterLop1.Fill(tableLop1);
            cbbLopKhoa.DataSource = tableLop1;
            cbbLopKhoa.DisplayMember = "TenKhoa";
            cbbLopKhoa.ValueMember = "KhoaID";
        }
        public Lop()
        {
            InitializeComponent();
        }

        private void Lop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSet_Lop.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter2.Fill(this.qLSVDataSet_Lop.Lop);
            connecton = new SqlConnection(strLop);
            connecton.Open();
            LoadDataLop();
            txtTongLop.Text = "Tổng lớp: " + (dataGridViewLop.Rows.Count - 1);
        }

        private void btnLopThoat_Click(object sender, EventArgs e)
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

        private void grbLop_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridViewLop.CurrentRow.Index;
            txtLopMaLop.Text = dataGridViewLop.Rows[i].Cells[0].Value.ToString();
            txtLopTenLop.Text = dataGridViewLop.Rows[i].Cells[1].Value.ToString();
            string query = "SELECT TenKhoa FROM Khoa WHERE KhoaID = @KhoaID";

            // Tạo đối tượng SqlCommand để thực thi truy vấn SQL
            SqlCommand command = new SqlCommand(query, connecton);

            // Thêm tham số cho truy vấn SQL
            command.Parameters.AddWithValue("@KhoaID", dataGridViewLop.Rows[i].Cells[2].Value.ToString());
            String TenKhoa = (String)command.ExecuteScalar();
            cbbLopKhoa.Text = TenKhoa;
            txtTongLop.Text = "Tổng lớp viên: " + (dataGridViewLop.Rows.Count - 1);
        }

        private void btnLopSua_Click(object sender, EventArgs e)
        {
            string query = "SELECT KhoaID FROM Khoa WHERE TenKhoa = @TenKhoa";

            // Tạo đối tượng SqlCommand để thực thi truy vấn SQL
            SqlCommand command = new SqlCommand(query, connecton);

            // Thêm tham số cho truy vấn SQL
            command.Parameters.AddWithValue("@TenKhoa", cbbLopKhoa.Text);

            // Thực thi truy vấn SQL và lấy ra ID của lớp
            int KhoaID = (int)command.ExecuteScalar();
            command = connecton.CreateCommand();
            command.CommandText = "UPDATE Lop SET TenLop=N'" + txtLopTenLop.Text + "',KhoaID='" + KhoaID + "' where LopID = @LopID";
            command.Parameters.AddWithValue("@LopID", txtLopMaLop.Text);
            command.ExecuteNonQuery();
            LoadDataLop();
            MessageBox.Show("Sửa thành công ");
            txtLopMaLop.Text = "";
            txtLopTenLop.Text = "";
            txtTongLop.Text = "Tổng lớp viên: " + (dataGridViewLop.Rows.Count - 1);
        }

        private void btnLopXoa_Click(object sender, EventArgs e)
        {
            command = connecton.CreateCommand();
            command.CommandText = "DELETE FROM Lop where LopID='" + txtLopMaLop.Text + "'";
            command.ExecuteNonQuery();
            LoadDataLop();
            MessageBox.Show("Xóa thành công ");
            txtLopMaLop.Text = "";
            txtLopTenLop.Text = "";
            txtTongLop.Text = "Tổng lớp viên: " + (dataGridViewLop.Rows.Count - 1);
        }

        private void btnLopThem_Click(object sender, EventArgs e)
        {
            string query = "SELECT KhoaID FROM Khoa WHERE TenKhoa = @TenKhoa";

            // Tạo đối tượng SqlCommand để thực thi truy vấn SQL
            SqlCommand command = new SqlCommand(query, connecton);

            // Thêm tham số cho truy vấn SQL
            command.Parameters.AddWithValue("@TenKhoa", cbbLopKhoa.Text);

            // Thực thi truy vấn SQL và lấy ra ID của lớp
            int KhoaID = (int)command.ExecuteScalar();
            command = connecton.CreateCommand();
            command.CommandText = "INSERT INTO Lop VALUES(N'" + txtLopTenLop.Text + "','" + KhoaID + "')";
            command.ExecuteNonQuery();
            LoadDataLop();
            MessageBox.Show("Thêm thành công ");
            txtLopMaLop.Text = "";
            txtLopTenLop.Text = "";
            txtTongLop.Text = "Tổng lớp viên: " + (dataGridViewLop.Rows.Count - 1);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
