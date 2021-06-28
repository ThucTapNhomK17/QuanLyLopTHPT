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
    public partial class Form4 : Form
    {
        DataSet ds;
        SqlDataAdapter dap;
        
        public Form4()
        {
            InitializeComponent();
        }
        
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-G3E7L6G\SQLEXPRESS;Initial Catalog=QuanLyTHPT;Integrated Security=True");

        private void Loaddulieu(string sql)
        {
            ds = new DataSet();
            dap = new SqlDataAdapter(sql, con);
            dap.Fill(ds);
            dsHS.DataSource = ds.Tables[0];
           
        }

        private void cleartext()
        {
            cbbGT.Text = txtMHS.Text = cbbmalop.Text = txtNS.Text = dateTimePicker1.Text = txtTHS.Text = txtTim.Text = cbbHK.Text = "";
        }
        private void locktext()
        {
            cbbGT.Enabled = txtMHS.Enabled = cbbmalop.Enabled = txtNS.Enabled = dateTimePicker1.Enabled = txtTHS.Enabled  = cbbHK.Enabled  = false;
        }
        private void unlocktext()
        {
            cbbGT.Enabled = txtMHS.Enabled = cbbmalop.Enabled = txtNS.Enabled = dateTimePicker1.Enabled = txtTHS.Enabled = txtTim.Enabled = cbbHK.Enabled  = true;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyTHPTDataSet.hocsinh' table. You can move, or remove it, as needed.
            this.hocsinhTableAdapter.Fill(this.quanLyTHPTDataSet.hocsinh);
            
            con.Open();
            HienThi();
        }
        

        public void HienThi()
        {
            button2.Enabled = button3.Enabled = button5.Enabled = false;
            string sqlSELECT = "SELECT * FROM hocsinh";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dsHS.DataSource = dt;
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTHS.Text == "" || txtMHS.Text == "" || cbbmalop.Text == "" || dateTimePicker1.Text == "" || txtNS.Text == "" || cbbGT.Text =="" || cbbHK.Text =="")
            {
                MessageBox.Show("Nhập thiếu thông tin!");
            }
            else
            {
                string sqlINSERT = "INSERT INTO hocsinh VALUES(@mahs,@tenhs,@ngaysinh,@noisinh,@malop,@gt,@hanhkiem)";
                SqlCommand cmd = new SqlCommand(sqlINSERT, con);
                cmd.Parameters.AddWithValue("mahs", txtMHS.Text);
                cmd.Parameters.AddWithValue("tenhs", txtTHS.Text);
                cmd.Parameters.AddWithValue("ngaysinh", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("noisinh", txtNS.Text);
                cmd.Parameters.AddWithValue("malop", cbbmalop.Text);
                cmd.Parameters.AddWithValue("gt", cbbGT.Text);
                cmd.Parameters.AddWithValue("hanhkiem", cbbHK.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm học sinh thành công!");
                cleartext();
                HienThi();
            }          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button1.Enabled = false;
            unlocktext();
            txtMHS.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Xóa thông tin của học sinh này?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string sqldelete = "delete from hocsinh where mahs = @mahs";
                    SqlCommand cmd = new SqlCommand(sqldelete, con);
                    cmd.Parameters.AddWithValue("mahs", txtMHS.Text);
                    //cmd.Parameters.AddWithValue("tenhs", txtTHS.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xoá thành công!");
                    HienThi();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                cleartext();
                unlocktext();
                button1.Enabled = true;
            }
            
        }

        private void butTim_Click(object sender, EventArgs e)
        {
            string sql = "select * from hocsinh";
            string dk = "";
            if(txtTim.Text.Trim() != "")
            {
                dk += " tenhs like '%" + txtTim.Text + "'";
            }
            if(cbbTGT.Text.Trim() != "" && dk != "")
            {
                dk+=" and gt = '"+cbbTGT.Text+"'";
            }
            if(cbbTGT.Text.Trim() != "" && cbbTL.Text != "" && dk != "")
            {
                dk += " and malop = '" + cbbTL.Text + "'";
            }
            if(cbbTGT.Text.Trim() != "" && dk == "")
            {
                dk += " gt ='" + cbbTGT.Text + "'";
            }
            if(cbbTL.Text.Trim() != "" && dk == "")
            {
                dk += " malop ='" + cbbTL.Text + "'";
            }
            if(cbbTGT.Text.Trim() != "" && cbbTL.Text.Trim() != "" && dk !="" )
            {
                dk += "and malop = '" + cbbTL.Text + "' and gt = '" + cbbTGT.Text + "'";
            }
            if(dk != "")
            {
                sql += " where " + dk;
            }
            Loaddulieu(sql);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void dsHS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                int i;
                i = dsHS.CurrentRow.Index;
                txtMHS.Text = dsHS.Rows[i].Cells[0].Value.ToString();
                txtTHS.Text = dsHS.Rows[i].Cells[1].Value.ToString();
                dateTimePicker1.Text = dsHS.Rows[i].Cells[2].Value.ToString();
                txtNS.Text = dsHS.Rows[i].Cells[3].Value.ToString();
                cbbmalop.Text = dsHS.Rows[i].Cells[4].Value.ToString();
                cbbGT.Text = dsHS.Rows[i].Cells[5].Value.ToString();
                cbbHK.Text = dsHS.Rows[i].Cells[6].Value.ToString();

                button1.Enabled = false;
                button3.Enabled = button2.Enabled = true;
                locktext();

            }
            catch { }
        }

    
        private void button5_Click_1(object sender, EventArgs e)
        {
            if(txtTHS.Text == "" || txtMHS.Text == "" || cbbmalop.Text == "" || dateTimePicker1.Text == "" || txtNS.Text == "" || cbbGT.Text == "" || cbbHK.Text == "")
            {
                MessageBox.Show("Sửa thất bại!");
            }
            else
            {
                button1.Enabled = true;
                button3.Enabled = button2.Enabled = false;
                unlocktext();
                string sqlEDIT = "UPDATE hocsinh SET tenhs = @tenhs, ngaysinh = @ngaysinh, noisinh = @noisinh, malop = @malop, gt = @gt, hanhkiem = @hanhkiem WHERE mahs = @mahs";
                SqlCommand cmd = new SqlCommand(sqlEDIT, con);
                cmd.Parameters.AddWithValue("mahs", txtMHS.Text);
                cmd.Parameters.AddWithValue("tenhs", txtTHS.Text);
                cmd.Parameters.AddWithValue("ngaysinh",dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("noisinh", txtNS.Text);
                cmd.Parameters.AddWithValue("malop", cbbmalop.Text);
                cmd.Parameters.AddWithValue("gt", cbbGT.Text);
                cmd.Parameters.AddWithValue("hanhkiem", cbbHK.Text);
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!");
                cleartext();
                HienThi();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            txtTim.Text = cbbTGT.Text = cbbTL.Text ="";
        }

        public string tenhs;
        public string mahocsinh;
        private void btnNhapdiem_Click(object sender, EventArgs e)
        {
            tenhs = txtTHS.Text;
            mahocsinh = txtMHS.Text;
            Form6 form6 = new Form6(tenhs,mahocsinh);
            form6.Show();
        }
    }
}
