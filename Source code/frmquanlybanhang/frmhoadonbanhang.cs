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
    public partial class frmhoadonbanhang : Form
    {

        String sCon = @"Data Source=DESKTOP-90GGRF1\THANHNGUYEN;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        public frmhoadonbanhang()
        {
            InitializeComponent();
           

        
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmhoadonbanhang_Load(object sender, EventArgs e)
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

            

            string sQuery1 = "select MaH, TenH from HANG ";
            SqlDataAdapter adapter1 = new SqlDataAdapter(sQuery1, con);
            DataSet ds1 = new DataSet();
            adapter1.Fill(ds1, "cbxhoadon");
            cbxmahanghoa.DataSource = ds1.Tables["cbxhoadon"];
            cbxmahanghoa.ValueMember = "MaH";
            cbxmahanghoa.DisplayMember = "TenH";
            con.Close();
            
        }

        private void btnthemhd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception )
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            int iMHD = Convert.ToInt16(txtMHD.Text);
            string sMHH = cbxmahanghoa.SelectedValue.ToString(); 
            string sNGAYBAN = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string sGIOBAN = dateTimePicker2.Value.ToString("HH:mm:ss");
            int sSOLUONGBAN = Convert.ToInt16(txtsoluongban.Text);
            string sTHANHTIEN = txtthanhtien.Text;
            string sTONGTIEN = txttongtien.Text;
            
            string sQuery = "insert into HOA_DON_BAN(MaHDB,NgayBan, GioBan,TongTien) values(@MaHDB,@ngayban,@gioban,@tongtien)";
            string sQuery2 = "update HANG set SoLuongTon = SoLuongTon - " + sSOLUONGBAN;

            
            SqlCommand cmd = new SqlCommand(sQuery, con);
            SqlCommand cmd2 = new SqlCommand(sQuery2, con);

            cmd.Parameters.AddWithValue("@ngayban", sNGAYBAN);
            cmd.Parameters.AddWithValue("@gioban", sGIOBAN);
            cmd.Parameters.AddWithValue("@MaHDB", iMHD);
            cmd.Parameters.AddWithValue("@tongtien", sTONGTIEN);
            
            try
            {
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //them vao bang hoa don chi tiet
            int iCount = dataGridView1.Rows.Count;
            for (int i = 0; i < iCount; i++)
            {
                string sQuery1 = "insert into HDBAN_CHI_TIET values(@MaHDB, @MaH, @soluongban, @thanhtien)";
                SqlCommand cmd1 = new SqlCommand(sQuery1, con);
                cmd1.Parameters.AddWithValue("@MaHDB", iMHD);
                cmd1.Parameters.AddWithValue("@MaH", dataGridView1.Rows[i].Cells[0].Value);
                cmd1.Parameters.AddWithValue("@soluongban", dataGridView1.Rows[i].Cells[3].Value);
                cmd1.Parameters.AddWithValue("@thanhtien", dataGridView1.Rows[i].Cells[4].Value );
                
                try
                {
                    cmd1.ExecuteNonQuery();
                  
                }
                    catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                MessageBox.Show("Thêm mới thành công!");
                txtdongia.Text = "";
                txtMHD.Text = "";
                txttongtien.Text = "";
                txtthanhtien.Text = "";
                txtsoluongban.Text = "";
               
               
            }
            
                con.Close();

        }

        private void cbxmahoadon_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sMHD="";
            //kiem tra xem ho da tim hoa don chua?
            if(txtMHD.Text =="")
            {
                
            }
            else 
                sMHD = txtMHD.Text;
           

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
                    MessageBox.Show(ex.ToString());
                }


                string sQuery = " delete HDBAN_CHI_TIET where MaHDB=@mahd";
                string sQuery1 = " delete HOA_DON_BAN where MaHDB=@mahd";
                
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@mahd", sMHD);


                SqlCommand cmd1 = new SqlCommand(sQuery1, con);
                cmd1.Parameters.AddWithValue("@mahd", sMHD);


                try
                {
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();

                    MessageBox.Show("Xóa thành công!", "Thông báo!");
                    txtdongia.Text = "";
                    txtMHD.Text = "";
                    txttongtien.Text = "";
                    txtthanhtien.Text = "";
                    txtsoluongban.Text = "";
                    txttimkiem.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                con.Close();

                
            }
        }

        private void cbxmahanghoa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            string sQuery = " select DonGiaBan from HANG where MaH = " + cbxmahanghoa.SelectedValue.ToString();
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "HANG");
            txtdongia.Text = ds.Tables["HANG"].Rows[0][0].ToString();

            con.Close();
        }

        private void txtsoluongban_TextChanged(object sender, EventArgs e)
        {
            if (txtsoluongban.Text != "")
            { 
                int iSOLUONGBAN = Convert.ToInt32(txtsoluongban.Text);
                int iDONGIA = Convert.ToInt32(txtdongia.Text);
                int iTHANHTIEN = iSOLUONGBAN * iDONGIA;
                txtthanhtien.Text = iTHANHTIEN.ToString();

                //kiem tra hang da ton tai trong gridview chua
                //neu ton tai --> cap nhat so luong
                int iCount = dataGridView1.Rows.Count;
                int ktra = 0;
                for (int i = 0; i < iCount; i++ )
                {
                    if(dataGridView1.Rows[i].Cells[0].Value.ToString() == cbxmahanghoa.ToString())
                    {
                        //cap nhat so luong
                        dataGridView1.Rows[i].Cells[3].Value = iSOLUONGBAN;
                        dataGridView1.Rows[i].Cells[3].Value = iSOLUONGBAN * iDONGIA;
                        ktra = 1;
                    }
                }
                    //neu chua ton tai
                if (ktra == 0)
                {
                    dataGridView1.Rows.Add(cbxmahanghoa.SelectedValue, cbxmahanghoa.Text, iDONGIA, iSOLUONGBAN, iTHANHTIEN);
                }

                //tinh tong tien
                long iTongTien;
                if (txttongtien.Text == "")
                    iTongTien = 0;
                else
                    iTongTien = Convert.ToInt32(txttongtien.Text);

                iTongTien = iTongTien + iTHANHTIEN;
                txttongtien.Text = iTongTien.ToString();

            }
        }



        private void btntimkiem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //1. select du lieu du vao phan thong tin chung - HOA_DON
 
           
            
            string sQuery = "select MaHDB, NgayBan, GioBan, TongTien from HOA_DON_BAN where MaHDB = '" + txttimkiem.Text + "'";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read() == true)
            {
                txtMHD.Text = rd["MaHDB"].ToString();
                txttongtien.Text = rd["TongTien"].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(rd["NgayBan"].ToString());
                dateTimePicker2.Value = Convert.ToDateTime(rd["GioBan"].ToString());
               
            }
            else
                MessageBox.Show("Không tìm thấy hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
             rd.Close();


            

            ////2. Lay du lieu tu HDB_CHI_TIET hien thij len gridview
             string SQuery1 = "select HDBAN_CHI_TIET.MaH, TenH, HANG.DonGiaBan, HDBAN_CHI_TIET.SoLuongBan, ThanhTien from HDBAN_CHI_TIET inner join HANG on HDBAN_CHI_TIET.MaH = HANG.MaH where HDBAN_CHI_TIET.MaHDB = @MaHD";
             SqlCommand cmd1 = new SqlCommand(SQuery1, con);
             cmd1.Parameters.AddWithValue("@MaHD", txttimkiem.Text);
             SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
             DataSet ds = new DataSet();
             adapter.Fill(ds, "HDCHITIET");
             int iRows = ds.Tables["HDCHITIET"].Rows.Count;
             for (int i = 0; i < iRows; i++ )
             {
                 dataGridView1.Rows.Add(ds.Tables["HDCHITIET"].Rows[i][0], ds.Tables["HDCHITIET"].Rows[i][1], ds.Tables["HDCHITIET"].Rows[i][2], ds.Tables["HDCHITIET"].Rows[i][3], ds.Tables["HDCHITIET"].Rows[i][4]);
             }

                
                 con.Close();


            

            

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
