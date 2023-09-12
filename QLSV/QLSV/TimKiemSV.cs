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
using Excel = Microsoft.Office.Interop.Excel;
namespace QLSV
{
    public partial class TimKiemSV : Form
    {
        public TimKiemSV()
        {
            string connectionString = @"Data Source=DESKTOP-RHJ3B39\SQL;Initial Catalog=QLSV;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            InitializeComponent();
            string sqlQuery = "SELECT * FROM SinhVien WHERE HoTen LIKE '%" + txtTimKiemSV.Text + "%'";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void TimKiemSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSet_TKSV.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter2.Fill(this.qLSVDataSet_TKSV.SinhVien);

        }

        private void btnTimKiemThoat_Click(object sender, EventArgs e)
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


        private void txtTimKiemSV_TextChanged(object sender, EventArgs e)
        {

            string searchText = txtTimKiemSV.Text;
            if (!string.IsNullOrEmpty(searchText))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().Contains(searchText))
                        {
                            dataGridView1.ClearSelection();
                            row.Selected = true;
                            dataGridView1.CurrentCell = row.Cells[1];
                            return;
                        }
                    }
                }
            }
        }


    }
}
