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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TJGABJT\MSSQLSERVER2706;Initial Catalog=QuanLyTHPT;Integrated Security=True");

        DataSet ds;
        SqlDataAdapter dap;

        private void Loaddulieu(string sql)
        {
            ds = new DataSet();
            dap = new SqlDataAdapter(sql, con);
            dap.Fill(ds);
            dgvTKM.DataSource = ds.Tables[0];
        }
        private void Loaddulieu2(string sql)
        {
            ds = new DataSet();
            dap = new SqlDataAdapter(sql, con);
            dap.Fill(ds);
            dgvTKD11.DataSource = ds.Tables[0];
        }
        private void Loaddulieu3(string sql)
        {
            ds = new DataSet();
            dap = new SqlDataAdapter(sql, con);
            dap.Fill(ds);
            dgvTKD12.DataSource = ds.Tables[0];
        }
        public void HienThi()
        {
            string sqlSELECT = "SELECT * FROM TKHK2('')";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvTKHK.DataSource = dt;
        }
        public void HienThi2()
        {
            string sqlSELECT = "SELECT * FROM TKHK('')";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvTKHK11.DataSource = dt;
        }
        public void HienThi3()
        {
            string sqlSELECT = "SELECT * FROM TKHK3('')";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvTKHK12.DataSource = dt;
        }
        private void btnTimMon_Click(object sender, EventArgs e)
        {
            string sql;
            if (cbbMon.Text.Trim() == "Toan")
            {
                sql = "select * from TKD2('MM01')";
                Loaddulieu(sql);
            }
            if (cbbMon.Text.Trim() == "Ngu Van")
            {
                sql = "select * from TKD2('MM02')";
                Loaddulieu(sql);
            }
            if (cbbMon.Text.Trim() == "Ngoai Ngu")
            {
                sql = "select * from TKD2('MM03')";
                Loaddulieu(sql);
            }
            if (cbbMon.Text.Trim() == "Vat Ly")
            {
                sql = "select * from TKD2('MM04')";
                Loaddulieu(sql);
            }
            if (cbbMon.Text.Trim() == "Hoa Hoc")
            {
                sql = "select * from TKD2('MM05')";
                Loaddulieu(sql);
            }
            if (cbbMon.Text.Trim() == "The Duc")
            {
                sql = "select * from TKD2('MM06')";
                Loaddulieu(sql);
            }
            if (cbbMon.Text.Trim() == "Quoc Phong")
            {
                sql = "select * from TKD2('MM07')";
                Loaddulieu(sql);
            }
            if (cbbMon.Text.Trim() == "GDCD")
            {
                sql = "select * from TKD2('MM08')";
                Loaddulieu(sql);
            }
            if (cbbMon.Text.Trim() == "Lich Su")
            {
                sql = "select * from TKD2('MM09')";
                Loaddulieu(sql);
            }
            if (cbbMon.Text.Trim() == "Sinh Hoc")
            {
                sql = "select * from TKD2('MM10')";
                Loaddulieu(sql);
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            con.Open();
            HienThi2();
            HienThi();
            HienThi3();
        }

        private void btnTim11_Click(object sender, EventArgs e)
        {
            string sql;
            if (cbbMon11.Text.Trim() == "Toan")
            {
                sql = "select * from TKD('MM01')";
                Loaddulieu2(sql);
            }
            if (cbbMon11.Text.Trim() == "Ngu Van")
            {
                sql = "select * from TKD('MM02')";
                Loaddulieu2(sql);
            }
            if (cbbMon11.Text.Trim() == "Ngoai Ngu")
            {
                sql = "select * from TKD('MM03')";
                Loaddulieu2(sql);
            }
            if (cbbMon11.Text.Trim() == "Vat Ly")
            {
                sql = "select * from TKD('MM04')";
                Loaddulieu2(sql);
            }
            if (cbbMon11.Text.Trim() == "Hoa Hoc")
            {
                sql = "select * from TKD('MM05')";
                Loaddulieu2(sql);
            }
            if (cbbMon11.Text.Trim() == "The Duc")
            {
                sql = "select * from TKD('MM06')";
                Loaddulieu2(sql);
            }
            if (cbbMon11.Text.Trim() == "Quoc Phong")
            {
                sql = "select * from TKD('MM07')";
                Loaddulieu2(sql);
            }
            if (cbbMon11.Text.Trim() == "GDCD")
            {
                sql = "select * from TKD('MM08')";
                Loaddulieu2(sql);
            }
            if (cbbMon11.Text.Trim() == "Lich Su")
            {
                sql = "select * from TKD('MM09')";
                Loaddulieu2(sql);
            }
            if (cbbMon11.Text.Trim() == "Sinh Hoc")
            {
                sql = "select * from TKD('MM10')";
                Loaddulieu2(sql);
            }
        }

        private void btnTim12_Click(object sender, EventArgs e)
        {
            string sql;
            if (cbbMon12.Text.Trim() == "Toan")
            {
                sql = "select * from TKD3('MM01')";
                Loaddulieu3(sql);
            }
            if (cbbMon12.Text.Trim() == "Ngu Van")
            {
                sql = "select * from TKD3('MM02')";
                Loaddulieu3(sql);
            }
            if (cbbMon12.Text.Trim() == "Ngoai Ngu")
            {
                sql = "select * from TKD3('MM03')";
                Loaddulieu3(sql);
            }
            if (cbbMon12.Text.Trim() == "Vat Ly")
            {
                sql = "select * from TKD3('MM04')";
                Loaddulieu3(sql);
            }
            if (cbbMon12.Text.Trim() == "Hoa Hoc")
            {
                sql = "select * from TKD3('MM05')";
                Loaddulieu3(sql);
            }
            if (cbbMon12.Text.Trim() == "The Duc")
            {
                sql = "select * from TKD3('MM06')";
                Loaddulieu3(sql);
            }
            if (cbbMon12.Text.Trim() == "Quoc Phong")
            {
                sql = "select * from TKD3('MM07')";
                Loaddulieu3(sql);
            }
            if (cbbMon12.Text.Trim() == "GDCD")
            {
                sql = "select * from TKD3('MM08')";
                Loaddulieu3(sql);
            }
            if (cbbMon12.Text.Trim() == "Lich Su")
            {
                sql = "select * from TKD3('MM09')";
                Loaddulieu3(sql);
            }
            if (cbbMon12.Text.Trim() == "Sinh Hoc")
            {
                sql = "select * from TKD3('MM10')";
                Loaddulieu3(sql);
            }
        }
    }
}
