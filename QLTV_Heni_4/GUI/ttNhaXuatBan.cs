using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLTV_Heni_4.BLL;
using QLTV_Heni_4.DTO;

namespace QLTV_Heni_4.GUI
{
    public partial class ttNhaXuatBan : UserControl
    {
        private NhaXuatBan_BLL nxbBUS = new NhaXuatBan_BLL();
        private bool add = false, update = false;

        //Xóa dữ liệu trên textbox
        public void cleantxt()
        {
            txtTenNXB.Text = "";
            txtDiaChi.Text = "";
            txtSdt.Text = "";
            txtWebsite.Text = "";
        }

        //Binding dữ liệu lên textbox
        public void binding()
        {
            txtMaNXB.DataBindings.Clear();
            txtMaNXB.DataBindings.Add("Text", grid_nxb.DataSource, "MaNXB");
            txtTenNXB.DataBindings.Clear();
            txtTenNXB.DataBindings.Add("Text", grid_nxb.DataSource, "TenNXB");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", grid_nxb.DataSource, "DiaChiNXB");
            txtSdt.DataBindings.Clear();
            txtSdt.DataBindings.Add("Text", grid_nxb.DataSource, "DienThoaiNXB");
            txtWebsite.DataBindings.Clear();
            txtWebsite.DataBindings.Add("Text", grid_nxb.DataSource, "Website");
        }

        //Lấy Thông tin NXB
        private NhaXuatBan_DTO LayTTNXB()
        {
            NhaXuatBan_DTO nxb = new NhaXuatBan_DTO();
            nxb.MaNXB = txtMaNXB.Text;
            nxb.TenNXB = txtTenNXB.Text;
            nxb.DiaChiNXB = txtDiaChi.Text;
            nxb.DienThoaiNXB = txtSdt.Text;
            nxb.Website = txtWebsite.Text;
            return nxb;
        }

        private void ttNhaXuatBan_Load(object sender, EventArgs e)
        {
            //Load DataGrid
            grid_nxb.DataSource = nxbBUS.LayDanhSachNXB();
            group_thongtin.Enabled = false;
            bt_them.Enabled = true;
            bt_sua.Enabled = true;
            bt_xoa.Enabled = true;
            binding();
        }

        public ttNhaXuatBan()
        {
            InitializeComponent();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            add = true; update = false;
            group_thongtin.Enabled = true;
            bt_them.Enabled = true;
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            // Load NextID len textbox MaNXB
            txtMaNXB.Text = nxbBUS.NextID();
            cleantxt();
            txtMaNXB.Focus();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            update = true; add = false;
            group_thongtin.Enabled = true;
            bt_them.Enabled = false;
            bt_sua.Enabled = true;
            bt_xoa.Enabled = false;
            txtMaNXB.Enabled = false;
            txtTenNXB.Focus();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            group_thongtin.Enabled = false;
            if (MessageBox.Show("Bạn có muốn xóa Nhà Xuất Bản: " + txtTenNXB.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (nxbBUS.KiemTra(txtMaNXB.Text))
                {
                    MessageBox.Show("Bạn phải xóa những sách có mã NXB '" + txtMaNXB.Text + "' trong bảng lô Sách trước !", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    nxbBUS.XoaNXB(txtMaNXB.Text);
                    ttNhaXuatBan_Load(sender, e);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhaXuatBan_DTO nxb = LayTTNXB();
            if (add)
            {
                nxbBUS.ThemNXB(nxb);
                ttNhaXuatBan_Load(sender, e);
            }
            if (update)
                nxbBUS.SuaNXB(nxb);
            ttNhaXuatBan_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ttNhaXuatBan_Load(sender, e);
        }
        #region Chir cho nhaapj SDT laf soos
        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion

    }
}
