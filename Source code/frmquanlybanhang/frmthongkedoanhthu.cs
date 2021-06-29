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
    public partial class frmthongkedoanhthu : Form
    {
        String sCon = @"Data Source=DESKTOP-90GGRF1\THANHNGUYEN;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        public frmthongkedoanhthu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string SQuery = "select sum(TongTien) as Tong_tien from HOA_DON_BAN where NgayBan between @tungay and @denngay";
            string sFrom = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string sTo = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            SqlCommand cmd = new SqlCommand(SQuery, con);
            cmd.Parameters.AddWithValue("@tungay", sFrom);
            cmd.Parameters.AddWithValue("@denngay", sTo);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()==true)
            {
                txtTongTien.Text = dr["Tong_tien"].ToString();
            }

        }

        private void frmthongkedoanhthu_Load(object sender, EventArgs e)
        {

        }
    }
}
