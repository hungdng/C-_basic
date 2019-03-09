using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLTV_Heni_4.DAL;
using QLTV_Heni_4.DTO;
using QLTV_Heni_4.BLL;

namespace QLTV_Heni_4.GUI
{
    public partial class ttPhieuMuonSach : UserControl
    {
        private PhieuMuon_BLL pmBUS = new PhieuMuon_BLL();
        private DocGia_BLL dgBUS = new DocGia_BLL();
        private NhanVien_BLL nvBUS = new NhanVien_BLL();
        private CuonSach_BLL csBUS = new CuonSach_BLL();
        private CTMuon_BLL ctmBUS = new CTMuon_BLL();
        private bool add = false, update = false, tra = false;

        private void cleantxtPM()
        {
            cboMaDG.Text = "";
            cboNgayHenTra.Text = "";
            cboNgayTra.Text = "";
            cboNgayMuon.EditValue = DateTime.Now;
            txtTinhTrangMuon.Text = "Đang Mượn";
        }
        private void cleanCTM()
        {
           // txt_IDCTMuon.Text = "";
            cbo_MaPhieuMuon.EditValue = txtMaPhieuMuon.Text;
            cbo_MaPhieuMuon.Enabled = false;
            cboMaSach.Text = "";
            cbo_NgayTra.Text = "";
            cboTinhTrangCTMuon.Text = "Đang mượn";
        }
        private void binding()
        {
            txtMaPhieuMuon.DataBindings.Clear();
            txtMaPhieuMuon.DataBindings.Add("text", grid_phieumuon.DataSource, "MaPhieuMuon");
            cboNgayHenTra.DataBindings.Clear();
            cboNgayHenTra.DataBindings.Add("EditValue", grid_phieumuon.DataSource, "NgayHenTra");           
            cboMaDG.DataBindings.Clear();
            cboMaDG.DataBindings.Add("EditValue", grid_phieumuon.DataSource, "MaDG");
            cboNgayMuon.DataBindings.Clear();
            cboNgayMuon.DataBindings.Add("EditValue", grid_phieumuon.DataSource, "NgayMuon");
            cboNgayTra.DataBindings.Clear();
            cboNgayTra.DataBindings.Add("EditValue", grid_phieumuon.DataSource, "NgayTra");
            txtTinhTrangMuon.DataBindings.Clear();
            txtTinhTrangMuon.DataBindings.Add("text", grid_phieumuon.DataSource, "TinhTrangMuon");

        }

        private void build()
        {
            txt_IDCTMuon.DataBindings.Clear();
            txt_IDCTMuon.DataBindings.Add("Text", grid_CTMuon.DataSource, "id_CTMuon");
            cbo_MaPhieuMuon.DataBindings.Clear();
            cbo_MaPhieuMuon.DataBindings.Add("EditValue", grid_CTMuon.DataSource, "MaPhieuMuon");
            cboMaSach.DataBindings.Clear();
            cboMaSach.DataBindings.Add("EditValue", grid_CTMuon.DataSource, "MaSach");
            cbo_NgayTra.DataBindings.Clear();
            cbo_NgayTra.DataBindings.Add("EditValue", grid_CTMuon.DataSource, "NgayTra");
            cboTinhTrangCTMuon.DataBindings.Clear();
            cboTinhTrangCTMuon.DataBindings.Add("Text", grid_CTMuon.DataSource, "TinhTrangCTMuon");
        }
        private PhieuMuon_DTO LayTTPhieuMuon()
        {
            PhieuMuon_DTO pm = new PhieuMuon_DTO();
            pm.MaPhieuMuon = txtMaPhieuMuon.Text;
            pm.MaDG = cboMaDG.EditValue.ToString();
            pm.NgayHenTra = Convert.ToDateTime(cboNgayHenTra.EditValue.ToString());
            //pm.NgayTra = Convert.ToDateTime(cboNgayTra.EditValue.ToString());
            pm.NgayMuon = Convert.ToDateTime(cboNgayMuon.EditValue.ToString());
            pm.TinhTrangMuon = txtTinhTrangMuon.Text;
            return pm;
        }
        private PhieuMuon_DTO LayTTPhieuMuonTra()
        {
            PhieuMuon_DTO pm = new PhieuMuon_DTO();
            pm.MaPhieuMuon = txtMaPhieuMuon.Text;
            pm.MaDG = cboMaDG.EditValue.ToString();
            pm.NgayHenTra = Convert.ToDateTime(cboNgayHenTra.EditValue.ToString());
            pm.NgayTra = Convert.ToDateTime(cboNgayTra.EditValue.ToString());
            pm.NgayMuon = Convert.ToDateTime(cboNgayMuon.EditValue.ToString());
            pm.TinhTrangMuon = txtTinhTrangMuon.Text;
            return pm;
        }
        private CTMuon_DTO LayTTCTMuon()
        {
            CTMuon_DTO ctm = new CTMuon_DTO();
         ctm.id_CTMuon = txt_IDCTMuon.Text;
            ctm.MaPhieuMuon = cbo_MaPhieuMuon.EditValue.ToString();
            ctm.MaSach = cboMaSach.EditValue.ToString();
            //ctm.NgayTra = Convert.ToDateTime(cbo_NgayTra.EditValue.ToString());
            ctm.TinhTrangCTMuon = cboTinhTrangCTMuon.Text;
            return ctm;
        }
        private CTMuon_DTO LayTTCTMuonSua()
        {
            CTMuon_DTO ctm = new CTMuon_DTO();
                   ctm.id_CTMuon = txt_IDCTMuon.Text;
            ctm.MaPhieuMuon = cbo_MaPhieuMuon.EditValue.ToString();
            ctm.MaSach = cboMaSach.EditValue.ToString();
            //ctm.NgayTra = Convert.ToDateTime(cbo_NgayTra.EditValue.ToString());
            ctm.TinhTrangCTMuon = cboTinhTrangCTMuon.Text;
            return ctm;
        }
        private CTMuon_DTO LayTTCTMuonTra()
        {
            CTMuon_DTO ctm = new CTMuon_DTO();
           ctm.id_CTMuon = txt_IDCTMuon.Text;
            ctm.MaPhieuMuon = cbo_MaPhieuMuon.EditValue.ToString();
            ctm.MaSach = cboMaSach.EditValue.ToString();
            ctm.NgayTra = Convert.ToDateTime(cbo_NgayTra.EditValue.ToString());
            ctm.TinhTrangCTMuon = cboTinhTrangCTMuon.Text;
            return ctm;
        }
        public ttPhieuMuonSach()
        {
            InitializeComponent();
        }

        private void ttPhieuMuonSach_Load(object sender, EventArgs e)
        {
            // Load combobox Mã PM
            cbo_MaPhieuMuon.Properties.DataSource = pmBUS.LayDanhSachPhieuMuon();
            cbo_MaPhieuMuon.Properties.DisplayMember = "MaPhieuMuon";
            cbo_MaPhieuMuon.Properties.ValueMember = "MaPhieuMuon";

            cboMaSach.Properties.DataSource = csBUS.LayDSCuonSach();
            cboMaSach.Properties.DisplayMember = "TuaSach";
            cboMaSach.Properties.ValueMember = "MaSach";

            cboMaDG.Properties.DataSource = dgBUS.LayDSDG();
            cboMaDG.Properties.DisplayMember = "HoTenDG";
            cboMaDG.Properties.ValueMember = "MaDG";

            grid_phieumuon.DataSource=pmBUS.LayDanhSachPhieuMuon();
            grid_CTMuon.DataSource=ctmBUS.LayDSCTMuon(txtMaPhieuMuon.Text);

            panel_ctm.Enabled = false;
            panel_pm.Enabled = false;
            bt_luupm.Text = "Lưu lại";
            bt_luuctm.Text = "Lưu lại";
            bt_thempn.Enabled = true;
            bt_suapn.Enabled = true;
            bt_xoapn.Enabled = true;
            bt_themctm.Enabled = true;
            bt_suactm.Enabled = true;
            bt_xoactm.Enabled = true;

            cbo_MaPhieuMuon.Enabled = true;
            cboMaSach.Enabled = true;
            cboMaDG.Enabled = true;
            cboNgayHenTra.Enabled = true;
            binding();
            build();
        }

        private void bt_thempn_Click(object sender, EventArgs e)
        {
            add = true; update = false;
            panel_pm.Enabled = true;
            bt_suapn.Enabled = false;
            bt_TraPM.Enabled = false;
            bt_xoapn.Enabled = false;
            bt_TraPM.Enabled = false;
            cboMaDG.Properties.DataSource = dgBUS.LayDSDG();
            cboMaDG.Properties.DisplayMember = "HoTenDG";
            cboMaDG.Properties.ValueMember = "MaDG";
            cleantxtPM();
            txtMaPhieuMuon.Text = pmBUS.NextID();
            cboMaDG.Focus();
        }

        private void bt_suapn_Click(object sender, EventArgs e)
        {
            add = false; update = true;
            bt_TraPM.Enabled = false;
            panel_pm.Enabled = true;
        }

        private void bt_luupm_Click(object sender, EventArgs e)
        {
            PhieuMuon_DTO pm = LayTTPhieuMuon();
            
            if (add)
            {
                pmBUS.ThemPhieuMuon(pm);
                ttPhieuMuonSach_Load(sender, e);
                bt_themctm_Click(sender, e);
            }
            if (update)
            {
                pmBUS.SuaPhieuMuon(pm);
                ttPhieuMuonSach_Load(sender, e);
            }
            if (tra)
            {
                PhieuMuon_DTO p = LayTTPhieuMuonTra();
                pmBUS.TraPhieuMuon(p);
                ttPhieuMuonSach_Load(sender, e);
                
            }
        }

        private void bt_xoapn_Click(object sender, EventArgs e)
        {
            panel_ctm.Enabled = false;
            panel_pm.Enabled = false;
            if (MessageBox.Show("Bạn có muốn xóa phiếu mượn sách : " + txtMaPhieuMuon.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MessageBox.Show("Nếu xóa phiếu mượn này thì sẽ tự động xóa chi tiết mượn có mã : '" + txtMaPhieuMuon.Text + "'. Có tiếp tục không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    {
                        pmBUS.XoaPhieuMuon(txtMaPhieuMuon.Text);
                        ttPhieuMuonSach_Load(sender, e);
                    }
                }
            }
        }

        private void bt_themctm_Click(object sender, EventArgs e)
        {
            add = true; update = false; tra = false;
            panel_pm.Enabled = false;
            panel_ctm.Enabled = true;
            bt_xoactm.Enabled = false;
            simpleButton1.Enabled = false;
            simpleButton1.Enabled = false;
            bt_suactm.Enabled = false;
            cleanCTM();
            cboTinhTrangCTMuon.Enabled = false;
            txt_IDCTMuon.Text = ctmBUS.NextID();
            cboMaSach.Focus();
        }

        private void bt_suactm_Click(object sender, EventArgs e)
        {
            add = false; update = true; tra = false;
            cbo_MaPhieuMuon.Enabled = false;
            simpleButton1.Enabled = false;
            cboTinhTrangCTMuon.Enabled = false;
            panel_pm.Enabled = false;
            panel_ctm.Enabled = true;
        }

        private void bt_xoactm_Click(object sender, EventArgs e)
        {
            panel_pm.Enabled = false;
            panel_ctm.Enabled = false;
            CTMuon_DTO ctm = LayTTCTMuonSua();
            if (MessageBox.Show("Bạn có muốn xóa chi tiết mượn của phiếu mượn : " + cbo_MaPhieuMuon.EditValue.ToString() + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ctmBUS.XoaCTMuon(ctm);
                ttPhieuMuonSach_Load(sender, e);
            }
        }

        private void bt_TraPM_Click(object sender, EventArgs e)
        {
            tra = true; add = false; update = false;
            panel_pm.Enabled = true;
            cboMaDG.Enabled = false;
            cboNgayHenTra.Enabled = false;
            cboNgayTra.EditValue = DateTime.Now;
            txtTinhTrangMuon.Text = "Đã trả";
            bt_luupm.Text = "Trả phiếu";
        }

        private void bt_luuctm_Click(object sender, EventArgs e)
        {
            CTMuon_DTO ctmm = LayTTCTMuon();
            
            CTMuon_DTO ms = LayTTCTMuonSua();
            if (add)
            {
                ctmBUS.ThemCTMuon(ctmm);
                ttPhieuMuonSach_Load(sender, e);
            }
            if (update)
            {
                ctmBUS.SuaCTMuon(ms);
                ttPhieuMuonSach_Load(sender, e);
            }
            if (tra)
            {
                CTMuon_DTO ct = LayTTCTMuonTra();
                ctmBUS.TraCTMuon(ct);
                ttPhieuMuonSach_Load(sender, e);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            panel_ctm.Enabled = true;
            add = false; update = false; tra = true;
            cbo_MaPhieuMuon.Enabled = false;
            cboMaSach.Enabled = false;
            cbo_NgayTra.EditValue = DateTime.Now;
            cboTinhTrangCTMuon.Text = "Đã trả";
            cboTinhTrangCTMuon.Enabled = true;
            bt_luuctm.Text = "Trả sách";
        }

        private void btnHuyPM_Click(object sender, EventArgs e)
        {
            ttPhieuMuonSach_Load(sender, e);
        }

        private void btnHuyCTM_Click(object sender, EventArgs e)
        {
            ttPhieuMuonSach_Load(sender, e);
        }

        private void txtMaPhieuMuon_TextChanged(object sender, EventArgs e)
        {
            grid_CTMuon.DataSource = ctmBUS.LayDSCTMuon(txtMaPhieuMuon.Text);
            build();
        }

        private void txtTinhTrangMuon_TextChanged(object sender, EventArgs e)
        {
            if (txtTinhTrangMuon.Text == "Đã trả")
            {
                bt_TraPM.Enabled = false;
                bt_suapn.Enabled = false;
            }
            else
            {
                bt_TraPM.Enabled = true;
                bt_suapn.Enabled = true;
            }
        }

        private void cboTinhTrangCTMuon_TextChanged(object sender, EventArgs e)
        {
            if ((cboTinhTrangCTMuon.Text == "Đã trả") || (cboTinhTrangCTMuon.Text == "Đã mất"))
            {
                simpleButton1.Enabled = false;
                bt_suactm.Enabled = false;
            }
            if (cboTinhTrangCTMuon.Text == "Đang mượn")
            {
                simpleButton1.Enabled = true;
                bt_suactm.Enabled = true;
            }
        }

    }
}
