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
    public partial class ttDocGia : UserControl
    {

        private DocGia_BLL dgBUS = new DocGia_BLL();
        private bool add = false, update = false;

        //Xóa dữ liệu trên textbox
        private void cleantxt()
        {
            txtMaDG.Text = "";
            txtTenDG.Text = "";
            txtSdt.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            cboNgaySinh.EditValue = "10 / 10 / 1992";
        //    cboNgaySinh.Text = "";
            cboNgayHetHan.EditValue = DateTime.Now;
            cboNgayLamThe.EditValue = DateTime.Now;

        }

        private void binding()
        {
            txtMaDG.DataBindings.Clear();
            txtMaDG.DataBindings.Add("Text", grid_docgia.DataSource, "MaDG");
            txtTenDG.DataBindings.Clear();
            txtTenDG.DataBindings.Add("Text", grid_docgia.DataSource, "HoTenDG");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", grid_docgia.DataSource, "EmailDG");
            cboGioiTinh.DataBindings.Clear();
            cboGioiTinh.DataBindings.Add("Text", grid_docgia.DataSource, "GioiTinhDG");
            cboNgaySinh.DataBindings.Clear();
            cboNgaySinh.DataBindings.Add("Text", grid_docgia.DataSource, "NgaySinhDG");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", grid_docgia.DataSource, "DiaChiDG");
            txtSdt.DataBindings.Clear();
            txtSdt.DataBindings.Add("Text", grid_docgia.DataSource, "DienThoaiDG");
            cboNgayLamThe.DataBindings.Clear();
            cboNgayLamThe.DataBindings.Add("Text", grid_docgia.DataSource, "NgayLamThe");
            cboNgayHetHan.DataBindings.Clear();
            cboNgayHetHan.DataBindings.Add("Text", grid_docgia.DataSource, "NgayHetHan");
        }

        //Lấy Thông tin Độc giả
        private DocGia_DTO LayTTDG()
        {
            DocGia_DTO dg = new DocGia_DTO();
            dg.MaDG = txtMaDG.Text;
            dg.HoTenDG = txtTenDG.Text;
            dg.EmailDG = txtEmail.Text;
            dg.GioiTinhDG = (cboGioiTinh.Text == "Nam") ? 1 : 0;
            dg.NgaySinhDG = Convert.ToDateTime(cboNgaySinh.EditValue.ToString());
            dg.DiaChiDG = txtDiaChi.Text;
            dg.DienThoaiDG = txtSdt.Text;
            dg.NgayLamThe = Convert.ToDateTime(cboNgayLamThe.EditValue.ToString());
            dg.NgayHetHan = Convert.ToDateTime(cboNgayHetHan.EditValue.ToString());
            return dg;
        }
        public ttDocGia()
        {
            InitializeComponent();
        }

        private void txtEmail_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ttDocGia_Load(object sender, EventArgs e)
        {
            //Load DataGrid
            grid_docgia.DataSource = dgBUS.LayDanhSachDocGia();
            group_thongtin.Enabled = false;
            bt_them.Enabled = true;
            bt_sua.Enabled = true;
            bt_xoa.Enabled = true;
            binding();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            add = true; update = false;
            group_thongtin.Enabled = true;
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;     
           // Load NextID len textbox MaSV
            cleantxt();
            txtMaDG.Focus();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            update = true; add = false;
            group_thongtin.Enabled = true;
            bt_them.Enabled = false;
            bt_xoa.Enabled = false;
            txtMaDG.Enabled = false;
            txtMaDG.Enabled = false;
            txtTenDG.Focus();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            group_thongtin.Enabled = false;
            if (MessageBox.Show("Bạn có muốn xóa Độc Giả: " + txtTenDG.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgBUS.KiemTra(txtMaDG.Text))
                {
                    MessageBox.Show("Bạn phải xóa những độc giả có mã : '" + txtMaDG.Text + "' trong bảng mượn sách trước !", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dgBUS.XoaDG(txtMaDG.Text);
                    ttDocGia_Load(sender, e);
                }
            }
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            DocGia_DTO tg = LayTTDG();
            if (add)
            {
                dgBUS.ThemDG(tg);
                ttDocGia_Load(sender, e);
            }
            if (update)
                dgBUS.SuaDG(tg);
            ttDocGia_Load(sender, e);   
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            ttDocGia_Load(sender, e);   

        }

        private void txtMaDG_KeyPress(object sender, KeyPressEventArgs e)
        {
            int cd = txtMaDG.Text.Length;
            if (cd > 9)
            {
                if (!Char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
        }

        private void txtSdt_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

    }
}
