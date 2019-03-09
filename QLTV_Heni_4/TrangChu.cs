using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using DevExpress.UserSkins;
using System.Windows.Forms;
using DevExpress.XtraBars.Controls;
using DevExpress.XtraBars.Forms;
using DevExpress.XtraBars;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using QLTV_Heni_4.DAL;
using QLTV_Heni_4.BLL;
using QLTV_Heni_4.DTO;
using QLTV_Heni_4.GUI;
using System.Diagnostics;

namespace QLTV_Heni_4
{
    public partial class TrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Khai báo chung
        AddTab.TabAdd clsAddTab = new AddTab.TabAdd(); 
        NhanVien_BLL nvBUS = new NhanVien_BLL();
        DocGia_BLL dgBUS = new DocGia_BLL();
        DangNhap dn = null;
        ConnectDB connect = new ConnectDB();
        #endregion

        public TrangChu()
        {
            InitializeComponent();
            InitSkinGallery();
        }

        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(skin, true);
        }
        private void TrangChu_Load(object sender, EventArgs e)
        {
            clsAddTab.AddTab(xtraTabControl1, "", "Welcome you", new GUI.About());

        }
        #region "Code cho nut Close xtraTabControl"
        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            xtraTabControl1.TabPages.RemoveAt(xtraTabControl1.SelectedTabPageIndex);
        }
        private void xtraTabControl1_ControlAdded(object sender, ControlEventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;
        }
        #endregion

        
        #region Khi nhấp vào button đăng nhập
        private void bt_dangnhap_ItemClick(object sender, ItemClickEventArgs e)
        {
        Cont:
          
            if (dn == null || dn.IsDisposed)
                dn = new DangNhap();
 
            if (dn.ShowDialog() == DialogResult.OK)
            {
                string MaNV = dn.txt_Name.Text;
                string matkhau = dn.txt_Pass.Text;

                if (MaNV.Equals(""))
                {
                    dn.lblTrangThaiLogin.Text = "Bạn chưa nhập Tên đăng nhập !";
                    goto Cont;
                }
                if (matkhau.Equals(""))
                {
                    dn.lblTrangThaiLogin.Text = "Bạn chưa nhập Mật khẩu !";
                    goto Cont;
                }
                Utilities.user = nvBUS.LayTTDangNhap(MaNV);
                if (Utilities.user.MaNV.Equals(""))
                {
                    // Gán thông báo cho label Thông báo
                    dn.lblTrangThaiLogin.Text = "Tên Đăng nhập không tồn tại!";
                    goto Cont;
                }
                if (Utilities.user.MatKhau!=matkhau)
                {
                    dn.lblTrangThaiLogin.Text = " Mật khẩu không đúng !";
                    goto Cont;
                }  
                AnMenu(true, Utilities.user.QuyenHan);
                String qh = "";
                if (Convert.ToString(Utilities.user.QuyenHan) == "1")
                {
                    qh = "Quản Lý";
                }
                else qh= "Nhân Viên";  
                siInfo.Caption = "Nhân Viên : ";
                nv.Caption = Utilities.user.MaNV;
                qnv.Caption = " ||Đăng nhập với quyền " + qh;
            }
     
        }

        #region Các hàm xử lý login và phân quyền

        public void AnMenu(bool logged, int QuyenHan = 1)
        {

            //
            bt_dangnhap.Enabled = !logged;
            bt_banthan.Enabled = logged;
            bt_doimatkhau.Enabled = logged;
            bt_dangxuat.Enabled = logged;
            //
            bt_qlts.Enabled = logged;
            bt_nhapsach.Enabled = logged;
            bt_ttsach.Enabled = logged;
            bt_tttacgia.Enabled = logged;
            bt_tttheloai.Enabled = logged;
            bt_ttnxb.Enabled = logged;
            bt_ttnhanvien.Enabled = logged;
            bt_docgia.Enabled = logged;
            bt_tusach.Enabled = logged;
            //
            //
            bt_phieumuon.Enabled = logged;
            //
            bt_dssach.Enabled = logged;
            bt_dstacgia.Enabled = logged;
            bt_dsnxb.Enabled = logged;
           
            bt_dsnv.Enabled = logged;
            bt_dsmuon.Enabled = logged;
           
            
           
            switch (QuyenHan)
            {
                case 1: break;
                case 0: HienThiNhanVien(); break;
            }
        }

        //Hiển thị Menu với nhóm "Nhân Viên"
        private void HienThiNhanVien()
        {
            bt_ttnhanvien.Enabled = false;
        }

        #endregion
        #endregion

        #region Khi nhấn đăng xuất
        private void bt_dangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Khởi tạo lại biến user dùng chung
            NhanVien_DTO user = new NhanVien_DTO();
            // Gọi lại Ẩn menu
            AnMenu(false);
            //Đóng tất cả các tab đang mở 
            xtraTabControl1.TabPages.Clear();
            MessageBox.Show("Bạn đã đăng xuất ra khỏi hệ thống !");
            dn = new DangNhap();
            dn.txt_Name.Text = "";
            dn.txt_Pass.Text = "";
            siInfo.Caption = "Chào mừng bạn đến với thư viện chúng tôi";
            nv.Caption = "";
            qnv.Caption = "";
            //Mở lại form đăng nhập
 //           bt_dangnhap_ItemClick(sender, e);
        }

        #endregion
       
        

        #region Khi nhấn vào thông tin bản thân
        private void bt_banthan_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Thông Tin Tài Khoản")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Thông Tin Tài Khoản", new GUI.ttBanThan());
            }

        }
        #endregion
        #region Khi nhấn đổi mật khẩu
        private void bt_doimatkhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Cập nhật Mật khẩu")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Cập nhật Mật khẩu", new GUI.doimatkhau());
            }
//            siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Đổi Mật khẩu";
        }
        #endregion
        #region Khi nhấn vào sinh viên thực hiện
        private void bt_svth_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Sinh viên thực hiện")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Sinh viên thực hiện", new GUI.About());
            }
 //           siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Sinh viên thực hiện đề tài";
        }
        #endregion


        #region Khi nhấn nút trang chủ
 
        #endregion
        #region Điều khiển của NavbarControl
        private void nav_nqtv_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Nội quy thư viện")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Nội quy thư viện", new GUI.NoiQuyThuVien());
            }
 //           siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Nội quy thư viện";
        }
        private void nav_quytrinhlamthe_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quy trình làm thẻ")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quy trình làm thẻ", new GUI.QuyTrinhLamThe());
            }
 //           siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Quy trình làm thẻ";
        }
        private void nav_quytrinhmuontrasach_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quy Định Mượn Trả Sách")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quy Định Mượn Trả Sách", new GUI.QuyDinhMuonTra());
            }
   //         siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Quy Định Mượn Trả Sách";
        }
        private void nav_nhac_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
        }
        #endregion
        
      


        #region Thao tác quan lý
        #region Thể loại
        private void bt_tttheloai_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản lý thể loại")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản lý thể loại", new GUI.ttTheLoai());
            }
  //          siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Quản lý thể loại";
        }
        #endregion
        #region Nhà xuất bản
        private void bt_ttnxb_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản lý Nhà xuất bản")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản lý Nhà xuất bản", new GUI.ttNhaXuatBan());
            }
 //          siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Quản lý Nhà xuất bản";
        }
        #endregion
        #region QUản lý nhân viên
        private void bt_ttnhanvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản lý Nhân viên")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản lý Nhân viên", new GUI.ttNhanVien());
            }
        }
        #endregion

        #region QUản lý tác giả
        private void bt_tttacgia_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản lý Tác Giả")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản lý Tác Giả", new GUI.ttTacGia());
            }
        }
        #endregion
        #region Quản lý độc giả
        private void bt_docgia_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản lý Độc giả")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản lý Độc Giả", new GUI.ttDocGia());
            }
        }
        #endregion
        #region Quản lý tựa sách
        private void bt_qlts_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản lý Tựa sách")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản lý Tựa sách", new GUI.ttTuaSach());
            }
        }
        #endregion
        #region Nhập lô sách 
        private void bt_nhapsach_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản lý nhập sách")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản lý nhập sách", new GUI.ttNhapSach());
            }
        }
        #endregion
        #region Quản lý tủ sách
        private void bt_tusach_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản lý tủ sách")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản lý tủ sách", new GUI.ttTuSach());
            }
        }
        #endregion
        #region Quản lý phiếu mượn sách
        private void bt_phieumuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản lý mượn sách")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản lý mượn sách", new GUI.ttPhieuMuonSach());
            }
        }
        #endregion
        #region Tìm kiếm sách
        private void bt_tksach_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Tìm kiếm sách")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Tìm kiếm sách", new GUI.tkSach());
            }
        }
        #endregion
        #region Tìm kiếm tác giả
        private void bt_tktacgia_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Tìm kiếm tác giả sách")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Tìm kiếm tác giả sách", new GUI.tkTacGia());
            }
        }
        #endregion
        #region Tìm kiếm nhà xuất bản
        private void bt_tknxb_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Tìm kiếm nhà xuất bản")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Tìm kiếm nhà xuất bản", new GUI.tkNhaXuatBan());
            }
        }
        #endregion
        #region tìm kiếm độc giả
        private void bt_tkdg_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Tìm kiếm độc giả")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Tìm kiếm độc giả", new GUI.tkDocGia());
            }
        }
        #endregion
        #region Lượt mượn sách
        private void bt_muonquahan_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Lượt mượn sách")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Lượt mượn sách", new GUI.dsTuaSach_LuotMuon());
            }
        }
        #endregion
        #region Lượt mượn độc giả
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Lượt mượn độc giả")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Lượt mượn độc giả", new GUI.dsDocGia_LuotMuon());
            }
        }
        #endregion
        #region Báo cáo độc giả
        private void bt_dsnguoimuonnhieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Báo cáo độc giả")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Báo cáo độc giả", new Report.Rp_DocGia());
            }
        }
        #endregion
        
        #endregion
        #region Thống kê nhà xuất bản
        private void bt_dsnxb_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Báo cáo về nhà xuất bản")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Báo cáo về nhà xuất bản", new Report.Rp_NhaXuatBan());
            }
        }
        #endregion
        #region Thống kê tác giả
        private void bt_dstacgia_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Báo cáo về tác giả sách")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Báo cáo về tác giả sách", new Report.Rp_TacGia());
            }
        }
        #endregion
        #region Thống kê nhân viên
        private void bt_dsnv_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Báo cáo thống kê nhân viên")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Báo cáo thống kê nhân viên", new Report.Rp_NhanVien());
            }
        }
        #endregion
        #region Thống kê nhập sách
        private void bt_dssach_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Báo cáo thống kê nhập sách")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Báo cáo thống kê nhập sách", new Report.Rp_PhieuNhapSach());
            }
        }
        #endregion
        #region Mượn sách quá hạn
        private void bt_dsmuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Báo cáo thống kê mượn quá hạn")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Báo cáo thống kê mượn quá hạn", new Report.Rp_MuonQuaHan());
            }
        }
        #endregion
        #region NavaBar Sách nỗi bậc
        private void nav_sachmuonnhieu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Sách được mượn nhiều")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Sách được mượn nhiều", new GUI.dsTuaSach_LuotMuon());
            }
        }
        #endregion
        private void bt_ttsach_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Thông tin cuốn sách")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Thông tin cuốn sách", new GUI.ttCuonSach());
            }
        }

        

        private void ribbon_Click(object sender, EventArgs e)
        {

        }



    }
}