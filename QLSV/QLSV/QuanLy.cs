using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySinhVien mfrm = new QuanLySinhVien();
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

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Khoa mfrm = new Khoa();
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

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lop mfrm = new Lop();
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

        private void quảnLýĐoànViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangVien mfrm = new DangVien();
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

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap mfrm = new DangNhap();
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

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemSV mfrm = new TimKiemSV();
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

        private void tìmKiếmĐoànViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemDV mfrm = new TimKiemDV();
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
    }
}
