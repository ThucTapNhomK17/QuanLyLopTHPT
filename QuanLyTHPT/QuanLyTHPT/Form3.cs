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

        DataSet ds; // đối tượng chứa dữ liệu tại local
        SqlDataAdapter dap; // khai báo đối tượng kết nối datasource với dataset

        private void cleartext()
        {
            txtMAGV.Text = txtTGV.Text = txtluong.Text = dtpNS.Text = cbbmamon.Text = cbbGT.Text = "";
        }
        private void locktext()
        {
            txtMAGV.Enabled = txtTGV.Enabled = txtluong.Enabled = dtpNS.Enabled = cbbmamon.Enabled = cbbGT.Enabled = false;
        }
        private void unlocktext()
        {
            txtMAGV.Enabled = txtTGV.Enabled = txtluong.Enabled = dtpNS.Enabled = cbbmamon.Enabled = cbbGT.Enabled = true;
        }

        private void Loaddulieu(string sql)
        {
            ds = new DataSet();
            dap = new SqlDataAdapter(sql, con);
            dap.Fill(ds);
            dsGV.DataSource = ds.Tables[0];
        }

        //Tạo đối tượng connection
        //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-G3E7L6G\SQLEXPRESS;Initial Catalog=QuanLyTHPT;Integrated Security=True");

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
            btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void dsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dsGV.CurrentRow.Index;
            txtMAGV.Text = dsGV.Rows[i].Cells[0].Value.ToString();
            txtTGV.Text = dsGV.Rows[i].Cells[1].Value.ToString();
            dtpNS.Text = dsGV.Rows[i].Cells[2].Value.ToString();
            cbbGT.Text = dsGV.Rows[i].Cells[3].Value.ToString();
            cbbmamon.Text = dsGV.Rows[i].Cells[4].Value.ToString();
            txtluong.Text = dsGV.Rows[i].Cells[5].Value.ToString();

            btnThem.Enabled = false;
            btnSua.Enabled = btnXoa.Enabled = true;
            locktext();
            
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if(txtMAGV.Text == "" || txtTGV.Text == "" || txtluong.Text =="" || dtpNS.Text ==""|| cbbGT.Text=="" || cbbmamon.Text == "")
            {
                MessageBox.Show("Nhập thiếu thông tin!");
            }
            else
            {
                string sqlINSERT = "INSERT INTO giaovien VALUES(@magv,@tengv,@ngaysinh,@gioitinh,@mamon,@luong)";
                SqlCommand cmd = new SqlCommand(sqlINSERT, con);
                cmd.Parameters.AddWithValue("magv", txtMAGV.Text);
                cmd.Parameters.AddWithValue("tengv", txtTGV.Text);
                cmd.Parameters.AddWithValue("ngaysinh", dtpNS.Text);
                cmd.Parameters.AddWithValue("gioitinh", cbbGT.Text);
                cmd.Parameters.AddWithValue("mamon", cbbmamon.Text);
                cmd.Parameters.AddWithValue("luong", txtluong.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm giáo viên thành công!");
                cleartext();
                HienThi();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa thông tin của giáo viên này?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string sqldelete = "delete from giaovien where magv = @magv";
                    SqlCommand cmd = new SqlCommand(sqldelete, con);
                    cmd.Parameters.AddWithValue("magv", txtMAGV.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!");
                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                cleartext();
                unlocktext();
                btnThem.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            unlocktext();
            txtMAGV.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMAGV.Text == "" || txtTGV.Text == "" || txtluong.Text == "" || dtpNS.Text == "" || cbbGT.Text == "" || cbbmamon.Text == "")
            {
                MessageBox.Show("Sửa thất bại!");
            }
            else
            {
                btnThem.Enabled = true;
                btnXoa.Enabled = btnSua.Enabled = false;
                unlocktext();
                string sqlEdit = "UPDATE giaovien SET magv = @magv, tengv = @tengv,ngaysinh=@ngaysinh,gioitinh=@gioitinh,mamon=@mamon, luong = @luong WHERE magv=@magv";
                SqlCommand cmd = new SqlCommand(sqlEdit, con);
                cmd.Parameters.AddWithValue("magv", txtMAGV.Text);
                cmd.Parameters.AddWithValue("tengv", txtTGV.Text);
                cmd.Parameters.AddWithValue("ngaysinh", dtpNS.Text);
                cmd.Parameters.AddWithValue("gioitinh", cbbGT.Text);
                cmd.Parameters.AddWithValue("mamon", cbbmamon.Text);
                cmd.Parameters.AddWithValue("luong", txtluong.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!");
                cleartext();
                HienThi();

            }
        }

        private void butTim_Click(object sender, EventArgs e)
        {
            string sql = "select * from giaovien";
            string dk = "";
            if (txtTim.Text.Trim() != "")
            {
                dk += " tengv like '%" + txtTim.Text + "'";
            }
            if (cbbGT.Text.Trim() != "" && dk != "")
            {
                dk += " and gioitinh = '" + cbbTimGT.Text + "'";
            }
            if (cbbTimGT.Text.Trim() != "" && cbbTimMM.Text != "" && dk != "")
            {
                dk += " and mamon = '" + cbbTimMM.Text + "'";
            }
            if (cbbTimGT.Text.Trim() != "" && dk == "")
            {
                dk += " gioitinh ='" + cbbTimGT.Text + "'";
            }
            if (cbbTimMM.Text.Trim() != "" && dk == "")
            {
                dk += " mamon ='" + cbbTimMM.Text + "'";
            }
            if (cbbTimGT.Text.Trim() != "" && cbbTimMM.Text.Trim() != "" && dk != "")
            {
                dk += "and mamon = '" + cbbTimMM.Text + "' and gioitinh = '" + cbbTimGT.Text + "'";
            }
            if (dk != "")
            {
                sql += " where " + dk;
            }
            Loaddulieu(sql);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            txtTim.Text = cbbTimGT.Text = cbbTimMM.Text = "";
            cleartext();
        }
    }
}
