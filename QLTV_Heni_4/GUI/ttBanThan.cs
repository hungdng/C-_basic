using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using System.IO;
using QLTV_Heni_4.DAL;
using QLTV_Heni_4.BLL;

namespace QLTV_Heni_4.GUI
{
    public partial class ttBanThan : UserControl
    {
        NhanVien_BLL nvBUS = new NhanVien_BLL();
        ConnectDB conn = new ConnectDB();
        public ttBanThan()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
            Utilities.user = nvBUS.LayThongTinBanThan(Utilities.user.MaNV);
            lb_manv.Text = Utilities.user.MaNV;
            lb_tennv.Text = Utilities.user.HoTenNV;
            if (Convert.ToString(Utilities.user.GioiTinhNV) == "0")
            {
                lb_gtnv.Text = "Nam";
            }
            else lb_gtnv.Text = "Nữ";
            lb_nsnv.Text = Convert.ToString(Utilities.user.NgaySinhNV);
            lb_dtnv.Text = Utilities.user.DienThoaiNV;
            lb_dcnv.Text = Utilities.user.DiaChiNV;
            lb_emailnv.Text = Utilities.user.EmailNV;
            lb_nvl.Text = Convert.ToString(Utilities.user.NgayVaoLam);
            if (Convert.ToString(Utilities.user.QuyenHan) == "0")
            {
                lb_qh.Text = "Quản Lý";
            }
            else lb_qh.Text = "Nhân Viên";
            hien_anh();
        }
        private void hien_anh()
        {
            string sql = "select AnhChup from NHANVIEN where MaNV='" + lb_manv.Text + "'";
            SqlConnection cc = new SqlConnection(conn.strConnect);
            SqlCommand com = new SqlCommand(sql, cc);
            try
            {
                cc.Open();
                byte[] b = (byte[])com.ExecuteScalar(); // đọc dữ liệu kiểu byte 
                MemoryStream mem = new MemoryStream(b);
                pictureBox1.Image = Image.FromStream(mem);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                cc.Close();
            }
        }
    }
}
