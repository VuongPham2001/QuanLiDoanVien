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
    public partial class DangNhap : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RHJ3B39\SQL;Initial Catalog=QLSV;Integrated Security=True");
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                string tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                string sql = " select *from Admin where TaiKhoan='" + tk + "'and MatKhau='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show(" Đăng nhập thành công ");
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
                else if (txtTaiKhoan.Text == "")
                {
                    MessageBox.Show("Tài khoản không đuọc để trống!!!");
                }
                else if (txtMatKhau.Text == "")
                {
                    MessageBox.Show("Mật khẩu không đuọc để trống!!!");
                }
                else
                {
                    MessageBox.Show(" Đăng nhập thất bại !!! ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;

            traloi = MessageBox.Show("Bạn có chắc chắn!!!", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }
    }
}
