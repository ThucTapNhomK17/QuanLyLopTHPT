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

namespace QuanLyTHPT
{
    public partial class Form5 : Form
    {
        private string taikhoan;
        private string matkhau;
        public Form5()
        {
            InitializeComponent();
        }
        public Form5(string tk, string mk)
        {
            this.taikhoan = tk;
            this.matkhau = mk;
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TJGABJT\MSSQLSERVER2706;Initial Catalog=QuanLyTHPT;Integrated Security=True");
    
        private void btnLuu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            if(txtMKM.Text == txtMKM2.Text && txtMKC.Text.Equals(matkhau))
            {   
                string sql ="Update dangnhap set matkhau = @matkhau where taikhoan = '" + taikhoan + "'";
                SqlCommand cmd = new SqlCommand(sql,con);
                cmd.Parameters.AddWithValue("matkhau", txtMKM.Text);
                cmd.ExecuteNonQuery();                
                try
                {
                    MessageBox.Show("Đổi mật khẩu thành công!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txtMKC.Text = txtMKM.Text = txtMKM2.Text = "";
            }
            else if(txtMKC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ!");
            }
            else if(txtMKM.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!");
            }
            else if(txtMKM2.Text != txtMKM.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu mới không đúng!");
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!");
            }
        }


        private void Form5_Load(object sender, EventArgs e)
        {
            label5.Text = taikhoan;
            con.Open();
        }
    }
}
