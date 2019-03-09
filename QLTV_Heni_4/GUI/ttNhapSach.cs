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
    public partial class ttNhapSach : UserControl
    {
        private TuaSach_BLL tsBUS = new TuaSach_BLL();
        private NhaXuatBan_BLL nxbBUS = new NhaXuatBan_BLL();
        private PhieuNhap_BLL pnBUS = new PhieuNhap_BLL();
        private LoSach_BLL lsBUS = new LoSach_BLL();
        private bool add = false, update = false;

        private void cleantxt()
        {
            cboMaPhieuNhap.Text = "";
            cboMaTuaSach.Text = "";
            cboNXB.Text = "";
            txtTaiBan.Text = "";
            txtNamXB.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";

        }
        private void binding()
        {
            txtMaPhieuNhap.DataBindings.Clear();
            txtMaPhieuNhap.DataBindings.Add("text", grid_phieunhap.DataSource, "MaPhieuNhap");
            cboNgayNhap.DataBindings.Clear();
            cboNgayNhap.DataBindings.Add("EditValue", grid_phieunhap.DataSource, "NgayNhap");

            txtMaLoSach.DataBindings.Clear();
            txtMaLoSach.DataBindings.Add("EditValue", grid_losach.DataSource, "MaLoSach");
            cboMaPhieuNhap.DataBindings.Clear();
            cboMaPhieuNhap.DataBindings.Add("EditValue", grid_losach.DataSource, "MaPhieuNhap");
            cboMaTuaSach.DataBindings.Clear();
            cboMaTuaSach.DataBindings.Add("EditValue", grid_losach.DataSource, "MaTuaSach");
            cboNXB.DataBindings.Clear();
            cboNXB.DataBindings.Add("EditValue", grid_losach.DataSource, "MaNXB");
            txtTaiBan.DataBindings.Clear();
            txtTaiBan.DataBindings.Add("text", grid_losach.DataSource, "TaiBan");
            txtNamXB.DataBindings.Clear();
            txtNamXB.DataBindings.Add("Text", grid_losach.DataSource, "NamXB");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", grid_losach.DataSource, "SoLuong");
            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", grid_losach.DataSource, "DonGia");

        }
        //Lấy thông tin phiếu nhập
        private PhieuNhap_DTO LayTTNhapSach()
        {
            PhieuNhap_DTO pn = new PhieuNhap_DTO();
            pn.MaPhieuNhap = txtMaPhieuNhap.Text;
            pn.NgayNhap = Convert.ToDateTime(cboNgayNhap.EditValue.ToString());
            return pn;
        }
        //Lấy thông tin lô sách
        private LoSach_DTO LayTTLoSach()
        {
            LoSach_DTO ls = new LoSach_DTO();
            ls.MaLoSach = txtMaLoSach.Text;
            ls.MaPhieuNhap = cboMaPhieuNhap.EditValue.ToString();
            ls.MaTuaSach = cboMaTuaSach.EditValue.ToString();
            ls.MaNXB = cboNXB.EditValue.ToString();
            ls.TaiBan = txtTaiBan.Text;
            ls.NamXB = txtNamXB.Text;
            ls.SoLuong = txtSoLuong.Text;
            ls.DonGia = txtDonGia.Text;
            return ls;
        }

        public ttNhapSach()
        {
            InitializeComponent();
        }
        #region Text chỉ cho nhập số
        private void txtTaiban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txtTaiBan_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txtNamXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion
        #region Load
        private void ttNhapSach_Load(object sender, EventArgs e)
        {
            // Load combobox Mã PN
            cboMaPhieuNhap.Properties.DataSource = pnBUS.LayDanhSachPhieuNhap();
            cboMaPhieuNhap.Properties.DisplayMember = "MaPhieuNhap";
            cboMaPhieuNhap.Properties.ValueMember = "MaPhieuNhap";
            // Load combobox Mã TS
            cboMaTuaSach.Properties.DataSource = tsBUS.LayDSTuaSach();
            cboMaTuaSach.Properties.DisplayMember = "TuaSach";
            cboMaTuaSach.Properties.ValueMember = "MaTuaSach";

            cboNXB.Properties.DataSource = nxbBUS.LayDanhSachNXB();
            cboNXB.Properties.DisplayMember = "TenNXB";
            cboNXB.Properties.ValueMember = "MaNXB";
            //Load DataGrid
            grid_phieunhap.DataSource = pnBUS.LayDanhSachPhieuNhap();
            grid_losach.DataSource = lsBUS.LayDanhSachLoSach(txtMaPhieuNhap.Text);
            panel_pn.Enabled = false;
            panel_ls.Enabled = false;
            bt_thempn.Enabled = true;
            bt_suapn.Enabled = true;
            bt_xoapn.Enabled = true;

            bt_themls.Enabled = true;
            bt_suals.Enabled = true;
            bt_xoals.Enabled = true;
            binding();
        }
        #endregion
        //Thêm phiếu nhập
        private void bt_thempn_Click(object sender, EventArgs e)
        {
            panel_pn.Enabled = true;
            add = true; update = false;
            bt_thempn.Enabled = true;
            bt_suapn.Enabled =false;
            bt_xoapn.Enabled = false;
            txtMaPhieuNhap.Text = pnBUS.NextID();
            cboNgayNhap.EditValue = DateTime.Now;
        }

        private void bt_huypn_Click(object sender, EventArgs e)
        {
            ttNhapSach_Load(sender, e);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            ttNhapSach_Load(sender, e);
        }

        private void bt_suapn_Click(object sender, EventArgs e)
        {
            panel_pn.Enabled = true;
            add = false; update = true;
            bt_thempn.Enabled = false;
            bt_suapn.Enabled = true;
            bt_xoapn.Enabled = false;
        }
// Xóa phiếu nhập
        private void bt_xoapn_Click(object sender, EventArgs e)
        {
            panel_pn.Enabled = false;
            panel_ls.Enabled = false;
            if (MessageBox.Show("Bạn có muốn xóa phiếu nhập : " + txtMaPhieuNhap.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (tsBUS.KiemTra(txtMaPhieuNhap.Text))
                {
                    MessageBox.Show("Bạn phải xóa những lô sách có mã tựa sách '" + txtMaPhieuNhap.Text + "' trong bảng lô Sách trước !", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pnBUS.XoaPN(txtMaPhieuNhap.Text);
                    ttNhapSach_Load(sender,e);
                }
            }
        }
        // Thêm sửa phiếu nhập
        private void bt_luuts_Click(object sender, EventArgs e)
        {
            PhieuNhap_DTO pn = LayTTNhapSach();
            if (add)
            {
                pnBUS.ThemPN(pn);
                ttNhapSach_Load(sender, e);
  //              bt_luuls_Click(sender, e);
            }
            if (update)
            {
                pnBUS.SuaPN(pn);
                ttNhapSach_Load(sender, e);
            }
        }

        private void bt_themls_Click(object sender, EventArgs e)
        {
            add = true; update = false;
            panel_ls.Enabled = true;
            bt_themls.Enabled = true;
            bt_suals.Enabled = false;
            bt_xoals.Enabled = false;
            txtMaLoSach.Text = lsBUS.NextID();
            cboMaPhieuNhap.EditValue = txtMaPhieuNhap.Text;
            cboMaTuaSach.Focus();
            cleantxt();
        }

        private void bt_suals_Click(object sender, EventArgs e)
        {
            add=false;update=true;
            panel_ls.Enabled = true;
            bt_themls.Enabled = false;
            bt_suals.Enabled = true;
            bt_xoals.Enabled = false;
            cboMaPhieuNhap.Focus();
        }

        private void bt_xoals_Click(object sender, EventArgs e)
        {
            panel_pn.Enabled = false;
            panel_ls.Enabled = false;
            if (MessageBox.Show("Bạn có muốn xóa lô sách : " + txtMaLoSach.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MessageBox.Show("Nếu xóa lô sách này thì sẽ tự động xóa các cuốn sách trong lô sách có mã : " + txtMaLoSach.Text + ". Có tiếp tục không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    {
                        lsBUS.XoaLoSach(txtMaLoSach.Text);
                        ttNhapSach_Load(sender, e);
                    }
                }
            }
        }

        private void bt_luuls_Click(object sender, EventArgs e)
        {
            LoSach_DTO ls = LayTTLoSach();
            if (add)
            {
                lsBUS.ThemLoSach(ls);
                ttNhapSach_Load(sender, e);
            }
            if (update)
            {
                lsBUS.SuaLoSach(ls);
                ttNhapSach_Load(sender, e);
            }
        }

        private void txtMaPhieuNhap_TextChanged(object sender, EventArgs e)
        {
            grid_losach.DataSource = lsBUS.LayDanhSachLoSach(txtMaPhieuNhap.Text);
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void grid_phieunhap_Click(object sender, EventArgs e)
        {

        }






    }
}
