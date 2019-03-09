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
using QLTV_Heni_4.DTO;
using QLTV_Heni_4.BLL;
using QLTV_Heni_4.DAL;

namespace QLTV_Heni_4.GUI
{
    public partial class ttNhanVien : UserControl
    {
        private NhanVien_BLL nvBUS = new NhanVien_BLL();
        ConnectDB conn = new ConnectDB();
        private bool add = false, update = false;

        private void cleantxt()
        {
            txtHoTenNV.Text = "";
            cboGioiTinh.Text = "";
            txtSdt.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            dateEdit1.Text =dateEdit1.EditValue.ToString();
            dateEdit2.Text = dateEdit2.EditValue.ToString();
            txtMatKhau.Text = "";
        }

        private void binding()
        {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", grid_nhanvien.DataSource, "MaNV");
            txtHoTenNV.DataBindings.Clear();
            txtHoTenNV.DataBindings.Add("Text", grid_nhanvien.DataSource, "HoTenNV");
            cboGioiTinh.DataBindings.Clear();
            cboGioiTinh.DataBindings.Add("Text", grid_nhanvien.DataSource, "GioiTinhNV");
            dateEdit1.DataBindings.Clear();
            dateEdit1.DataBindings.Add("Text", grid_nhanvien.DataSource, "NgaySinhNV");
            txtSdt.DataBindings.Clear();
            txtSdt.DataBindings.Add("Text", grid_nhanvien.DataSource, "DienThoaiNV");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", grid_nhanvien.DataSource, "DiaChiNV");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", grid_nhanvien.DataSource, "EmailNV");
            dateEdit2.DataBindings.Clear();
            dateEdit2.DataBindings.Add("Text", grid_nhanvien.DataSource, "NgayVaoLam");
           txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", grid_nhanvien.DataSource, "MatKhau");
            cboQuyenHan.DataBindings.Clear();
            cboQuyenHan.DataBindings.Add("Text", grid_nhanvien.DataSource, "QuyenHan");
        }

        //Lấy Thông tin nhân viên
        private NhanVien_DTO LayTTNV()
        {
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.MaNV = txtMaNV.Text;
            nv.HoTenNV = txtHoTenNV.Text;
            nv.GioiTinhNV = (cboGioiTinh.Text == "Nam") ? 1 : 0;
            nv.NgaySinhNV = Convert.ToDateTime(dateEdit1.EditValue.ToString());
            nv.DienThoaiNV = txtSdt.Text;
            nv.DiaChiNV = txtDiaChi.Text;
            nv.EmailNV = txtEmail.Text;
            nv.NgayVaoLam = Convert.ToDateTime(dateEdit2.EditValue.ToString());
            nv.MatKhau = txtMatKhau.Text;
            nv.QuyenHan = (cboQuyenHan.Text == "Quản Lý") ? 1 : 0;


            return nv;
            
        }
        private void ttNhanVien_Load(object sender, EventArgs e)
        {
            //Load DataGrid
            grid_nhanvien.DataSource = nvBUS.LayDanhSachNhanVien();
            group_thongtin.Enabled = false;
            bt_them.Enabled = true;
            bt_sua.Enabled = true;
            bt_xoa.Enabled = true;
            binding();
            hien_anh();
        }

        public ttNhanVien()
        {
            InitializeComponent();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            cleantxt();
            add = true; update = false;
            group_thongtin.Enabled = true;
            bt_them.Enabled = true;
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            // Load NextID len textbox MaSV
            txtMaNV.Text = nvBUS.NextID();
            
            dateEdit2.EditValue = DateTime.Now;
            pictureBox1.Image = global::QLTV_Heni_4.Properties.Resources.say_yes;
            
            txtHoTenNV.Focus();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
         
            update = true; add = false;
            group_thongtin.Enabled = true;
            bt_them.Enabled = false;
            bt_sua.Enabled = true;
            bt_xoa.Enabled = false;
            txtHoTenNV.Focus();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            group_thongtin.Enabled = false;
                if (MessageBox.Show("Bạn có muốn xóa Nhân Viên: " + txtHoTenNV.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    nvBUS.XoaNV(txtMaNV.Text);
                    ttNhanVien_Load(sender, e);
                }
        }
        public byte[] arrImage;
        private void bt_luu_Click(object sender, EventArgs e)
        {
            NhanVien_DTO nv = LayTTNV();
            MemoryStream mstr = new MemoryStream();
            pictureBox1.Image.Save(mstr, pictureBox1.Image.RawFormat);
            arrImage = mstr.GetBuffer();
            if (add)
            {
              //  MessageBox.Show("3");
                nvBUS.ThemNV(nv,arrImage);
              //  MessageBox.Show("4");
                ttNhanVien_Load(sender, e);
            }
            if (update)
                nvBUS.SuaNV(nv,arrImage);
            ttNhanVien_Load(sender, e);
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            ttNhanVien_Load(sender, e);
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        string name;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Pictures|*.bmp;*.gif;*.jpg|Bitmaps|*.bmp|GIFs|*.gi f|JPEGs|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(dlg.FileName);
                name = dlg.FileName.Substring(dlg.FileName.LastIndexOf(@"\") + 1, dlg.FileName.Length - dlg.FileName.LastIndexOf(@"\") - 1);
            }
        }

        private void txtMaNV_EditValueChanged(object sender, EventArgs e)
        {
            if(txtHoTenNV.Text!="")
            {
                hien_anh();
            }
            else
            {

            }
        }

        private void hien_anh()
        {
            string sql = "select AnhChup from NHANVIEN where MaNV='" + txtMaNV.Text + "'";
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
