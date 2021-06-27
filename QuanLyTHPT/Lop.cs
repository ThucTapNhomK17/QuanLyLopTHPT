using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTHPT
{
    public partial class Lop : Form
    {
        public Lop()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-G3E7L6G\SQLEXPRESS;Initial Catalog=QuanLyTHPT;Integrated Security=True");

        private void Lop_Load(object sender, EventArgs e)
        {
            con.Open();
            HienThi();
            HienThi2();
        }
        public void HienThi()
        {
            string sqlSELECT = "select l.malop, l.tenlop, count(h.mahs) as siso,g.magv, g.tengv as chunhiem " +
                "from(lop l join hocsinh h on l.malop = h.malop) join giaovien g on l.magv = g.magv " +
                "group by l.tenlop, l.malop,g.tengv,g.magv " +
                "order by l.tenlop";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dsLop.DataSource = dt;
            btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnSuaGVCN.Enabled = false;
        }
        public void HienThi2()
        {
            string sql = " Select magv, tengv from giaovien where chunhiem = 0";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dsCN.DataSource = dt;
            txtCN.Enabled = txtTenGVCN.Enabled = false;
        }
        private void cleartext()
        {
            txtML.Text = txtTL.Text = txtSS.Text = txtTim.Text = "";
        }
        private void locktext()
        {
            txtML.Enabled = txtTL.Enabled = txtSS.Enabled = false;
        }
        private void unlocktext()
        {
            txtML.Enabled = txtTL.Enabled = txtSS.Enabled = true ;
        }


        private void dsLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dsLop.CurrentRow.Index;
            txtML.Text = dsLop.Rows[i].Cells[0].Value.ToString();
            txtTL.Text = dsLop.Rows[i].Cells[1].Value.ToString();
            txtSS.Text = dsLop.Rows[i].Cells[2].Value.ToString();
            txtCN.Text = dsLop.Rows[i].Cells[3].Value.ToString();
            txtTenGVCN.Text = dsLop.Rows[i].Cells[4].Value.ToString();
            btnThem.Enabled = false;
            btnSua.Enabled = btnXoa.Enabled = true;
            locktext();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtML.Text == ""|| txtTL.Text == "")
            {
                MessageBox.Show("Nhập thiếu thông tin!");
            }
            else
            {
                string sqlINSERT = "INSERT INTO lop VALUES(@malop,@tenlop,@magv)";
                SqlCommand cmd = new SqlCommand(sqlINSERT, con);
                cmd.Parameters.AddWithValue("malop", txtML.Text);
                cmd.Parameters.AddWithValue("tenlop", txtTL.Text);
                
                cmd.Parameters.AddWithValue("magv", txtCN.Text);
                cmd.ExecuteNonQuery();
                cleartext();
                MessageBox.Show("Thêm thành công!");
                HienThi();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtML.Text == "" || txtTL.Text == "")
            {
                MessageBox.Show("Sửa thất bại!");
            }
            else
            {
                btnThem.Enabled = true;
                btnXoa.Enabled = btnSua.Enabled = false;
                string sqlUPDATE = "UPDATE lop SET malop = @malop, tenlop = @tenlop, magv = @magv WHERE malop = @malop; "
                + " update giaovien set chunhiem = 1 where magv = @magv";                   
                SqlCommand cmd = new SqlCommand(sqlUPDATE, con);
                cmd.Parameters.AddWithValue("malop", txtML.Text);
                cmd.Parameters.AddWithValue("tenlop", txtTL.Text);
                
                cmd.Parameters.AddWithValue("magv", txtCN.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!");

                cleartext();
                HienThi();
                HienThi2();
            }
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
    {       
            if (MessageBox.Show("Xóa thông tin của lớp này?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string sqldelete = "delete from lop where malop = @malop";
                    SqlCommand cmd = new SqlCommand(sqldelete, con);
                    cmd.Parameters.AddWithValue("malop", txtML.Text);
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
            btnLuu.Enabled = btnSuaGVCN.Enabled = true;
            btnThem.Enabled = false;
            unlocktext();
            txtML.Enabled = txtSS.Enabled = false;
        }

        private void butTim_Click_1(object sender, EventArgs e)
        {
            string sqlSEARCH = "SELECT * FROM lop WHERE tenlop LIKE '%" + txtTim.Text + "%'";
            SqlCommand cmd = new SqlCommand(sqlSEARCH, con);
            cmd.Parameters.AddWithValue("tenlop", txtTim.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dsLop.DataSource = dt;
            cleartext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cleartext();
            txtTim.Text = "";
        }

        private void dsCN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dsCN.CurrentRow.Index;
            txtCN.Text = dsCN.Rows[i].Cells[0].Value.ToString();
            txtTenGVCN.Text = dsCN.Rows[i].Cells[1].Value.ToString();
        }

        private void btnSuaGVCN_Click(object sender, EventArgs e)
        {
            string sql = "update giaovien set chunhiem = 0 where magv = @magv";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("magv", txtCN.Text);
            cmd.ExecuteNonQuery();
            txtCN.Text = txtTenGVCN.Text = "";
        }
    }
    
}
