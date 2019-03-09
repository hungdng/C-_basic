using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLTV_Heni_4.DTO;
using QLTV_Heni_4.BLL;

namespace QLTV_Heni_4.GUI
{
    public partial class ttTheLoai : UserControl
    {

        private TheLoai_BLL tlBUS = new TheLoai_BLL();
        private bool add = false, update = false;

        //Xóa dữ liệu trên textbox
        public void cleantxt()
        {
            txtTenTL.Text = "";
            txtGhiChu.Text = "";
        }

        //Binding dữ liệu lên textbox
        public void binding()
        {
            txtMaTL.DataBindings.Clear();
            txtMaTL.DataBindings.Add("Text", grid_theloai.DataSource, "MaTL");
            txtTenTL.DataBindings.Clear();
            txtTenTL.DataBindings.Add("Text", grid_theloai.DataSource, "TenTL");
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", grid_theloai.DataSource, "GhiChu");
        }

        //Lấy Thông tin Thể loại
        private TheLoai_DTO LayTTTL()
        {
            TheLoai_DTO tl = new TheLoai_DTO();
            tl.MaTL = txtMaTL.Text;
            tl.TenTL = txtTenTL.Text;
            tl.GhiChu = txtGhiChu.Text;
            return tl;
        }

        private void ttTheLoai_Load_1(object sender, EventArgs e)
        {
            //Load DataGrid
            grid_theloai.DataSource = tlBUS.LayDanhSachTheLoai();
            group_thongtin.Enabled = false;
            bt_them.Enabled = true;
            bt_sua.Enabled = true;
            bt_xoa.Enabled = true;
            binding();
        }

        public ttTheLoai()
        {
            InitializeComponent();
        }


        private void bt_them_Click_1(object sender, EventArgs e)
        {
            add = true; update = false;
            group_thongtin.Enabled = true;
            bt_them.Enabled = true;
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            // Load NextID len textbox MaTL
            txtMaTL.Text = tlBUS.NextID();
            cleantxt();
            txtTenTL.Focus();
        }

        private void bt_sua_Click_1(object sender, EventArgs e)
        {
           update = true; add = false;
            group_thongtin.Enabled = true;
            bt_them.Enabled = false;
            bt_sua.Enabled = true;
            bt_xoa.Enabled = false;
            txtMaTL.Enabled = false;
            txtTenTL.Focus();
        }

        private void bt_xoa_Click_1(object sender, EventArgs e)
        {
            group_thongtin.Enabled = false;
            if (MessageBox.Show("Bạn có muốn xóa Thể loại: " + txtTenTL.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (tlBUS.KiemTra(txtMaTL.Text))
                {
                    MessageBox.Show("Bạn phải xóa những loại sách có mã TG '" + txtMaTL.Text + "' trong bảng Sách trước !", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tlBUS.XoaTL(txtMaTL.Text);
                    ttTheLoai_Load_1(sender, e);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TheLoai_DTO tl = LayTTTL();
            if (update)
            {
                tlBUS.SuaTL(tl);
                ttTheLoai_Load_1(sender, e);
            }
            if (add)
            {
                tlBUS.ThemTL(tl);
                ttTheLoai_Load_1(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ttTheLoai_Load_1(sender, e);
        }

    }
}
