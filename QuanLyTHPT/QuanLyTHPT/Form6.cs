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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        DataSet ds;
        SqlDataAdapter dap;
        private void Loaddulieu(string sql)
        {
            ds = new DataSet();
            dap = new SqlDataAdapter(sql, con);
            dap.Fill(ds);
            dgvDiem.DataSource = ds.Tables[0];
        }
        private string tenhocsinh;
        private string mahocsinh;
        public Form6(string ths,string mahs)
        {
            this.tenhocsinh = ths;
            this.mahocsinh = mahs;
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-G3E7L6G\SQLEXPRESS;Initial Catalog=QuanLyTHPT;Integrated Security=True");

        private void hienthi()
        {
            string sql = "Select m.mamon, m.tenmon as Môn, d.diemtb as Điểm from mon m inner join diem d on m.mamon = d.mamon where d.mahs = '" + mahocsinh + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvDiem.DataSource = dt;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            lblTenhs.Text = tenhocsinh;
            con.Open();
            hienthi();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "Select m.mamon, m.tenmon as Môn, d.diemtb as Điểm from mon m inner join diem d on m.mamon = d.mamon where d.mahs = '" + mahocsinh + "' and m.tenmon = '" + cbbMon.Text + "'";
            Loaddulieu(sql);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbbMon.Text = txtDiem.Text = "";
            hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update diem set diemtb = @diemtb from diem d inner join mon m on d.mamon = m.mamon where m.tenmon = @tenmon and d.mahs = '" + mahocsinh + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("diemtb", txtDiem.Text);
            cmd.Parameters.AddWithValue("tenmon", cbbMon.Text);
            cmd.ExecuteNonQuery();
            hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "Insert into diem values(@mahs,@mamon,@diemtb)";
         /*   SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("mamon", comboBox1.Text);
            cmd.Parameters.AddWithValue("mahs", mahocsinh);
            cmd.Parameters.AddWithValue("diemtb", txtDiem.Text);
            cmd.ExecuteNonQuery();
            hienthi();*/
            Loaddulieu(sql);

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string sql = "Select m.mamon, m.tenmon as Môn, d.diemtb as Điểm from mon m inner join diem d on m.mamon = d.mamon where d.mahs = '" + mahocsinh + "' and m.mamon = '" + comboBox1.Text + "'";
            Loaddulieu(sql);
        }
    }
}
