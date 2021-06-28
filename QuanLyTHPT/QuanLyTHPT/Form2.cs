using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyTHPT
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }
        private string taikhoan;
        private string matkhau;
        public Form2(string tk, string mk)
        {
            this.taikhoan = tk;
            this.matkhau = mk;
            InitializeComponent();
        }

        public Form activeForm = null;
        public void OpenChildForm(Form childform)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel1.Controls.Add(childform);
            panel1.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void btnGV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3());
            label2.Text = "GIÁO VIÊN";
        }
       
        private void btnHS_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form4());
            label2.Text = "HỌC SINH";
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Lop());
            label2.Text = "LỚP";
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form5(taikhoan,matkhau));
            label2.Text = "ĐỔI MẬT KHẨU";
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
 
        private void Form2_Load(object sender, EventArgs e)
        {
            label4.Text = taikhoan;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form7());
            label2.Text = "THỐNG KÊ";
        }
    }
}
