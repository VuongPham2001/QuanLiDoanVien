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
    public partial class Khoa : Form
    {

        SqlConnection connecton;
        SqlCommand command;
        string strKhoa = @"Data Source=DESKTOP-RHJ3B39\SQL;Initial Catalog=QLSV;Integrated Security=True";
        SqlDataAdapter adapterKhoa = new SqlDataAdapter();
        DataTable tableKhoa = new DataTable();

        void LoadDataKhoa()
        {
            command = connecton.CreateCommand();
            command.CommandText = "SELECT * FROM Khoa ";
            adapterKhoa.SelectCommand = command;
            tableKhoa.Clear();
            adapterKhoa.Fill(tableKhoa);
            dataGridViewKhoa.DataSource = tableKhoa;
        }
        public Khoa()
        {
            InitializeComponent();
        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSet_Khoa.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter1.Fill(this.qLSVDataSet_Khoa.Khoa);
            connecton = new SqlConnection(strKhoa);
            connecton.Open();
            LoadDataKhoa();
            txtTongKhoa.Text = "Tổng khoa viên: " + (dataGridViewKhoa.Rows.Count - 1);
        }

        private void btnKhoaThoat_Click(object sender, EventArgs e)
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

        private void dataGridViewKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridViewKhoa.CurrentRow.Index;
            txtkhoaMaKhoa.Text = dataGridViewKhoa.Rows[i].Cells[0].Value.ToString();
            txtKhoaTenKhoa.Text = dataGridViewKhoa.Rows[i].Cells[1].Value.ToString();
            txtTongKhoa.Text = "Tổng khoa viên: " + (dataGridViewKhoa.Rows.Count - 1);
        }

        private void btnKhoaThem_Click(object sender, EventArgs e)
        {
            command = connecton.CreateCommand();
            command.CommandText = "INSERT INTO Khoa VALUES(N'" + txtKhoaTenKhoa.Text + "')";
            command.ExecuteNonQuery();
            LoadDataKhoa();
            MessageBox.Show("Thêm thành công ");
            txtkhoaMaKhoa.Text = "";
            txtKhoaTenKhoa.Text = "";
            txtTongKhoa.Text = "Tổng khoa viên: " + (dataGridViewKhoa.Rows.Count - 1);
        }

        private void btnKhoaSua_Click(object sender, EventArgs e)
        {
            command = connecton.CreateCommand();
            command.CommandText = "UPDATE Khoa SET TenKhoa='" + txtKhoaTenKhoa.Text + "'where KhoaID = @KhoaID";
            command.Parameters.AddWithValue("@KhoaID", txtkhoaMaKhoa.Text);
            command.ExecuteNonQuery();
            LoadDataKhoa();
            MessageBox.Show("Sửa thành công ");
            txtkhoaMaKhoa.Text = "";
            txtKhoaTenKhoa.Text = "";
            txtTongKhoa.Text = "Tổng khoa viên: " + (dataGridViewKhoa.Rows.Count - 1);
        }

        private void btnKhoaXoa_Click(object sender, EventArgs e)
        {
            command = connecton.CreateCommand();
            command.CommandText = "DELETE FROM Khoa where KhoaID='" + txtkhoaMaKhoa.Text + "'";
            command.ExecuteNonQuery();
            LoadDataKhoa();
            MessageBox.Show("Xóa thành công ");
            txtkhoaMaKhoa.Text = "";
            txtKhoaTenKhoa.Text = "";
            txtTongKhoa.Text = "Tổng khoa viên: " + (dataGridViewKhoa.Rows.Count - 1);
        }

        private void txtTongKhoa_Click(object sender, EventArgs e)
        {

        }
    }
}
