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
    public partial class frmquanlyhanghoa : Form
    {
        String sCon = @"Data Source=DESKTOP-90GGRF1\THANHNGUYEN;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        public frmquanlyhanghoa()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnhoadonbanhang_Click(object sender, EventArgs e)
        {
            frmhoadonbanhang hoadon = new frmhoadonbanhang();

            hoadon.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmthongkedoanhthu thongke = new frmthongkedoanhthu();
            thongke.Show();
        }

        private void btntim_Click(object sender, EventArgs e)
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

            String sQuery = " select*from HANG where TenH like N'%" + txtTim.Text +"%'";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();
            try
            {
                adapter.Fill(ds, "HANG");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            

            dataGridView1.DataSource = ds.Tables["HANG"];

            String sQuery1 = " select*from HANG";
            SqlDataAdapter adapter1 = new SqlDataAdapter(sQuery1, con);

            DataSet ds1 = new DataSet();

            adapter.Fill(ds1, "HANG");

            dataGridView1.DataSource = ds.Tables["HANG"];
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmquanlyhanghoa_Load(object sender, EventArgs e)
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

            String sQuery = " select*from HANG";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "HANG");

            dataGridView1.DataSource = ds.Tables["HANG"];
            
            con.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
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

            string sMaHang = txtMaH.Text;
            string sTenHang = txtTenH.Text;
            string sSoLuongTon = txtSoLuongTon.Text;
            string sDonGiaNhap = txtDonGiaNhap.Text;
            string sDonGiaBan = txtDonGiaBan.Text;

            string sQuery = "insert into HANG values(@MaH,@TenH,@SoLuongTon,@DonGiaNhap,@DonGiaBan)";
            SqlCommand cmd = new SqlCommand(sQuery,con);
            cmd.Parameters.AddWithValue("@MaH", sMaHang);
            cmd.Parameters.AddWithValue("@TenH", sTenHang);
            cmd.Parameters.AddWithValue("@SoLuongTon", sSoLuongTon);
            cmd.Parameters.AddWithValue("@DonGiaNhap", sDonGiaNhap);
            cmd.Parameters.AddWithValue("@DonGiaBan", sDonGiaBan);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!", "Thông báo!");
                txtDonGiaBan.Text = "";
                txtSoLuongTon.Text = "";
                txtDonGiaNhap.Text = "";
                txtTenH.Text = "";
                txtMaH.Text = "";
                txtMaH.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới!","Thông báo");
            }
            String sQuery1 = " select*from HANG";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery1, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "HANG");

            dataGridView1.DataSource = ds.Tables["HANG"];
            con.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaH.Text = dataGridView1.Rows[e.RowIndex].Cells["MaH"].Value.ToString();
            txtTenH.Text = dataGridView1.Rows[e.RowIndex].Cells["TenH"].Value.ToString();
            txtSoLuongTon.Text = dataGridView1.Rows[e.RowIndex].Cells["SoLuongTon"].Value.ToString();
            txtDonGiaNhap.Text = dataGridView1.Rows[e.RowIndex].Cells["DonGiaNhap"].Value.ToString();
            txtDonGiaBan.Text = dataGridView1.Rows[e.RowIndex].Cells["DonGiaBan"].Value.ToString();
            txtMaH.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
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

            string sMaHang = txtMaH.Text;
            string sTenHang = txtTenH.Text;
            string sSoLuongTon = txtSoLuongTon.Text;
            string sDonGiaNhap = txtDonGiaNhap.Text;
            string sDonGiaBan = txtDonGiaBan.Text;

            string sQuery = "update HANG set TenH=@TenH, SoLuongTon=@SoLuongTon, DonGiaNhap=@DonGiaNhap,DonGiaBan=@DonGiaBan where MaH=@MaH";

            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaH", sMaHang);
            cmd.Parameters.AddWithValue("@TenH", sTenHang);
            cmd.Parameters.AddWithValue("@SoLuongTon", sSoLuongTon);
            cmd.Parameters.AddWithValue("@DonGiaNhap", sDonGiaNhap);
            cmd.Parameters.AddWithValue("@DonGiaBan", sDonGiaBan);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!", "Thông báo!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình Cập nhật!", "Thông báo");
            }
            String sQuery1 = " select*from HANG";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery1, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "HANG");

            dataGridView1.DataSource = ds.Tables["HANG"];
            con.Close();


        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Có chắc chắn xóa không?", "Thông báo!", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
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

                string sMaHang = txtMaH.Text;
                string sQuery = "update HDBAN_CHI_TIET SET MaH = '999999' WHERE MaH = @MaH";
                string sQuery2 = "delete HANG where MaH = @MaH";

                SqlCommand cmd = new SqlCommand(sQuery, con);
                SqlCommand cmd2 = new SqlCommand(sQuery2, con);
                cmd.Parameters.AddWithValue("@MaH", sMaHang);
                cmd2.Parameters.AddWithValue("@MaH", sMaHang);


                try
                {
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!", "Thông báo!");
                    txtDonGiaBan.Text = "";
                    txtSoLuongTon.Text = "";
                    txtDonGiaNhap.Text = "";
                    txtTenH.Text = "";
                    txtMaH.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình Xóa!", "Thông báo");
                }
                String sQuery1 = " select*from HANG";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuery1, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "HANG");

                dataGridView1.DataSource = ds.Tables["HANG"];
                con.Close();



            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmthongkehanghoa thongkehang = new frmthongkehanghoa();
            thongkehang.Show();
        }

        private void txtMaH_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
