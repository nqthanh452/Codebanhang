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

namespace frmquanlybanhang
{
    public partial class frmthongkehanghoa : Form
    {
        String sCon = @"Data Source=DESKTOP-90GGRF1\THANHNGUYEN;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        public frmthongkehanghoa()
        {
            InitializeComponent();
        }

        private void frmthongkehanghoa_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(sCon);
            //try
            //{
            //    con.Open();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            //}
            //string sQuery1 = "select MaH, TenH from HANG ";
            //SqlDataAdapter adapter1 = new SqlDataAdapter(sQuery1, con);
            //DataSet ds1 = new DataSet();
            //adapter1.Fill(ds1, "cbxtenhang");
            //cbxtenhang.DataSource = ds1.Tables["cbxtenhang"];
            //cbxtenhang.ValueMember = "MaH";
            //cbxtenhang.DisplayMember = "TenH";
            //con.Close();
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }

            String sQuery = " select*from HANG";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "HANG");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            dataGridView1.DataSource = ds.Tables["HANG"];
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(sCon);
            //try
            //{
            //    con.Open();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            //}

            //string SQuery = "select SoLuongTon from HANG where TenH='" + cbxtenhang.Text + "'";
            //SqlCommand cmd = new SqlCommand(SQuery, con);
            //SqlDataReader dr = cmd.ExecuteReader();
            //if (dr.Read() == true)
            //{
            //    string slt = dr["SoLuongTon"].ToString();
            //    txtsoluongton.Text = slt;
            //}
            //else
            //{
            //    txtsoluongton.Text = "";
            //    MessageBox.Show("Không có số lượng tồn của mặt hàng này");
            //}   

            //con.Close();
        }
    }
}
