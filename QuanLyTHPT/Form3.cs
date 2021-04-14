using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace QuanLyTHPT
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TJGABJT\MSSQLSERVER2706;Initial Catalog=QuanLyTHPT;Integrated Security=True");

        private void Form3_Load(object sender, EventArgs e)
        {
            con.Open();
            HienThi();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        public void HienThi()
        {
            string sqlSELECT = "SELECT * FROM giaovien";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dsGV.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO giaovien VALUES(@magv,@tengv,@ngaysinh,@gioitinh,@mamon)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            cmd.Parameters.AddWithValue("magv", txtMGV.Text);
            cmd.Parameters.AddWithValue("tengv", txtTGV.Text);
            cmd.Parameters.AddWithValue("ngaysinh", txtNSGV.Text);
            cmd.Parameters.AddWithValue("gioitinh", txtGT.Text);
            cmd.Parameters.AddWithValue("mamon", txtMM.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlEdit = "UPDATE giaovien SET tengv = @tengv,ngaysinh=@ngaysinh,gioitinh=@gioitinh,mamon=@mamon WHERE magv=@magv";
            SqlCommand cmd = new SqlCommand(sqlEdit, con);
            cmd.Parameters.AddWithValue("magv", txtMGV.Text);
            cmd.Parameters.AddWithValue("tengv", txtTGV.Text);
            cmd.Parameters.AddWithValue("ngaysinh", txtNSGV.Text);
            cmd.Parameters.AddWithValue("gioitinh", txtGT.Text);
            cmd.Parameters.AddWithValue("mamon", txtMM.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM giaovien WHERE magv = @magv";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("magv", txtMGV.Text);
            cmd.Parameters.AddWithValue("tengv", txtTGV.Text);
            cmd.Parameters.AddWithValue("ngaysinh", txtNSGV.Text);
            cmd.Parameters.AddWithValue("gioitinh", txtGT.Text);
            cmd.Parameters.AddWithValue("mamon", txtMM.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void butTim_Click(object sender, EventArgs e)
        {
            string sqlTimKiem ="SELECT * FROM giaovien WHERE magv = @magv";
            SqlCommand cmd = new SqlCommand(sqlTimKiem, con);
            cmd.Parameters.AddWithValue("magv", txtTim.Text);
            cmd.Parameters.AddWithValue("tengv", txtTGV.Text);
            cmd.Parameters.AddWithValue("ngaysinh", txtNSGV.Text);
            cmd.Parameters.AddWithValue("gioitinh", txtGT.Text);
            cmd.Parameters.AddWithValue("mamon", txtMM.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dsGV.DataSource = dt;
        }
    }
}
