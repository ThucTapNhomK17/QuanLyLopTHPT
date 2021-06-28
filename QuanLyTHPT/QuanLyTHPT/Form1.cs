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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TJGABJT\MSSQLSERVER2706;Initial Catalog=QuanLyTHPT;Integrated Security=True");
     
        public string tk;
        public string mk;
  
        private void butDN_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                 tk = txtDN.Text;
                 mk = txtMK.Text;
                string sql ="select ten, taikhoan, matkhau from dangnhap where taikhoan = '"+tk+"' and matkhau  = '"+mk+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dta = cmd.ExecuteReader();
                
                if (dta.Read() == true)
                {                  
                    this.Hide();
                    Form2 form2 = new Form2(tk,mk);
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("ĐĂNG NHẬP THẤT BẠI!");
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Lỗi kết nối!");
            }
        }

        private void butThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /* public string Ten
         {
             set 
             {
                 SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TJGABJT\MSSQLSERVER2706;Initial Catalog=QuanLyTHPT;Integrated Security=True");
                 ten = "select ten from dangnhap where taikhoan = '" + txtDN.Text + "' and matkhau = '" + txtMK.Text + "'";
                 SqlCommand cmd = new SqlCommand(ten, con);
                 SqlDataReader dr = cmd.ExecuteReader();
                 Label label = new Label();

             }
             get { return ten;}
         }*/
    }
}
