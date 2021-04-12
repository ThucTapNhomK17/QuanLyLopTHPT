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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butDN_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TJGABJT\MSSQLSERVER2706;Initial Catalog=QuanLyTHPT;Integrated Security=True");
            try
            {
                con.Open();
                string tk = txtDN.Text;
                string mk = txtMK.Text;
                string sql ="select * from dangnhap where taikhoan = '"+tk+"' and matkhau  = '"+mk+"'";
                SqlCommand cmd = new SqlCommand(sql,con);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    this.Hide();
                    Form2 form2 = new Form2();
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("ĐĂNG NHẬP THẤT BẠI!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!");
            }
        }

        private void butThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
