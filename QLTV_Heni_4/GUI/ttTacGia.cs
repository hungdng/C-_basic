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
    public partial class ttTacGia : UserControl
    {
        private TacGia_BLL tgBUS = new TacGia_BLL();
        private bool add = false, update = false;

        //Xóa dữ liệu trên textbox
        public void cleantxt()
        {
            txtTenTG.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            cboGioiTinh.Text = cboGioiTinh.EditValue.ToString();
            cboNgaySinh.Text = cboNgaySinh.EditValue.ToString();
        }

        //Binding dữ liệu lên textbox
        public void binding()
        {
            txtMaTG.DataBindings.Clear();
            txtMaTG.DataBindings.Add("Text", grid_tacgia.DataSource, "MaTG");
            txtTenTG.DataBindings.Clear();
            txtTenTG.DataBindings.Add("Text", grid_tacgia.DataSource, "HoTenTG");
            cboGioiTinh.DataBindings.Clear();
            cboGioiTinh.DataBindings.Add("Text", grid_tacgia.DataSource, "GioiTinhTG");
            cboNgaySinh.DataBindings.Clear();
            cboNgaySinh.DataBindings.Add("Text", grid_tacgia.DataSource, "NgaySinhTG");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", grid_tacgia.DataSource, "DiaChiTG");
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", grid_tacgia.DataSource, "DienThoaiTG");
        }

        //Lấy Thông tin Tác Giả
        private TacGia_DTO LayTTTG()
        {
            TacGia_DTO tg = new TacGia_DTO();
            tg.MaTG = txtMaTG.Text;
            tg.HoTenTG = txtTenTG.Text;
            tg.GioiTinhTG = (cboGioiTinh.Text == "Nam") ? 1 : 0;
            tg.NgaySinhTG = Convert.ToDateTime(cboNgaySinh.EditValue.ToString());
            tg.DiaChiTG = txtDiaChi.Text;
            tg.DienThoaiTG = txtDienThoai.Text;
            return tg;
        }
        private void ttTacGia_Load(object sender, EventArgs e)
        {
            //Load DataGrid
            grid_tacgia.DataSource = tgBUS.LayDanhSachTacGia();
            group_thongtin.Enabled = false;
            bt_sua.Enabled = true;
            bt_them.Enabled = true;
            bt_xoa.Enabled = true;
            binding();
        }
        public ttTacGia()
        {
            InitializeComponent();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            add = true; update = false;
            group_thongtin.Enabled = true;
            bt_sua.Enabled = false;
            bt_them.Enabled = true;
            bt_xoa.Enabled = false;
            // Load NextID len textbox MaSV
            txtMaTG.Text = tgBUS.NextID();
            cleantxt();
            txtTenTG.Focus();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            update = true; add = false;
            group_thongtin.Enabled = true;
            bt_sua.Enabled = true;
            bt_them.Enabled = false;
            bt_xoa.Enabled = false;
            txtMaTG.Enabled = false;
            txtTenTG.Focus();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            group_thongtin.Enabled = false;
            if (MessageBox.Show("Bạn có muốn xóa Tác Giả: " + txtTenTG.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (tgBUS.KiemTra(txtMaTG.Text))
                {
                    MessageBox.Show("Bạn phải xóa những loại sách có mã TG '" + txtMaTG.Text + "' trong bảng Tựa Sách trước !", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tgBUS.XoaTG(txtMaTG.Text);
                    ttTacGia_Load(sender, e);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TacGia_DTO tg = LayTTTG();
            if (add)
            {
                tgBUS.ThemTG(tg);
                ttTacGia_Load(sender, e);
            }
            if (update)
                tgBUS.SuaTG(tg);
            ttTacGia_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ttTacGia_Load(sender, e);
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }


    }
}
