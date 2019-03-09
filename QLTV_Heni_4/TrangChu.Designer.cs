using System.Windows.Forms;
namespace QLTV_Heni_4
{
    partial class TrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            System.Windows.Forms.DialogResult rs;
            rs = MessageBox.Show("Bạn có muốn thoát khỏi chương trình Quản lý thư viện không?", "THOÁT KHỎI CHƯƠNG TRÌNH?", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question);
            if (rs == System.Windows.Forms.DialogResult.Yes)
                base.Dispose(disposing);
            if (disposing && (components != null))
                components.Dispose();
        }
        
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.bt_dangnhap = new DevExpress.XtraBars.BarButtonItem();
            this.bt_doimatkhau = new DevExpress.XtraBars.BarButtonItem();
            this.bt_dangxuat = new DevExpress.XtraBars.BarButtonItem();
            this.skin = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.bt_nhapsach = new DevExpress.XtraBars.BarButtonItem();
            this.bt_ttsach = new DevExpress.XtraBars.BarButtonItem();
            this.bt_tttacgia = new DevExpress.XtraBars.BarButtonItem();
            this.bt_tttheloai = new DevExpress.XtraBars.BarButtonItem();
            this.bt_ttnxb = new DevExpress.XtraBars.BarButtonItem();
            this.bt_ttnhanvien = new DevExpress.XtraBars.BarButtonItem();
            this.bt_giangvien = new DevExpress.XtraBars.BarButtonItem();
            this.bt_phongban = new DevExpress.XtraBars.BarButtonItem();
            this.bt_sinhvien = new DevExpress.XtraBars.BarButtonItem();
            this.bt_lophoc = new DevExpress.XtraBars.BarButtonItem();
            this.bt_phieumuon = new DevExpress.XtraBars.BarButtonItem();
            this.bt_tksach = new DevExpress.XtraBars.BarButtonItem();
            this.bt_tktacgia = new DevExpress.XtraBars.BarButtonItem();
            this.bt_tknxb = new DevExpress.XtraBars.BarButtonItem();
            this.bt_tkdg = new DevExpress.XtraBars.BarButtonItem();
            this.bt_dssach = new DevExpress.XtraBars.BarButtonItem();
            this.bt_dstacgia = new DevExpress.XtraBars.BarButtonItem();
            this.bt_dsnxb = new DevExpress.XtraBars.BarButtonItem();
            this.bt_dsnv = new DevExpress.XtraBars.BarButtonItem();
            this.bt_dsmuon = new DevExpress.XtraBars.BarButtonItem();
            this.bt_svth = new DevExpress.XtraBars.BarButtonItem();
            this.bt_banthan = new DevExpress.XtraBars.BarButtonItem();
            this.tennv = new DevExpress.XtraBars.BarStaticItem();
            this.bt_tc = new DevExpress.XtraBars.BarButtonItem();
            this.siInfo = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.bt_docgia = new DevExpress.XtraBars.BarButtonItem();
            this.bt_qlts = new DevExpress.XtraBars.BarButtonItem();
            this.bt_tusach = new DevExpress.XtraBars.BarButtonItem();
            this.nv = new DevExpress.XtraBars.BarStaticItem();
            this.qnv = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.tab_hethong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tab_quanly = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tab_muontra = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tab_timkiem = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup13 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tab_thongke = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup15 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup16 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup17 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tab_morong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup18 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup19 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.splitContainerControlWin641 = new DevExpress.XtraCharts.Wizard.SplitContainerControlWin64();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.navBar = new DevExpress.XtraNavBar.NavBarControl();
            this.mn_gt = new DevExpress.XtraNavBar.NavBarGroup();
            this.nav_nqtv = new DevExpress.XtraNavBar.NavBarItem();
            this.nav_quytrinhlamthe = new DevExpress.XtraNavBar.NavBarItem();
            this.nav_quytrinhmuontrasach = new DevExpress.XtraNavBar.NavBarItem();
            this.nav_sachmuonnhieu = new DevExpress.XtraNavBar.NavBarItem();
            this.nav_web = new DevExpress.XtraNavBar.NavBarItem();
            this.nav_tthl = new DevExpress.XtraNavBar.NavBarItem();
            this.nav_tvdhdn = new DevExpress.XtraNavBar.NavBarItem();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlWin641)).BeginInit();
            this.splitContainerControlWin641.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.applicationMenu1;
            this.ribbon.ApplicationIcon = global::QLTV_Heni_4.Properties.Resources.hp_folder_book1;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bt_dangnhap,
            this.bt_doimatkhau,
            this.bt_dangxuat,
            this.skin,
            this.bt_nhapsach,
            this.bt_ttsach,
            this.bt_tttacgia,
            this.bt_tttheloai,
            this.bt_ttnxb,
            this.bt_ttnhanvien,
            this.bt_giangvien,
            this.bt_phongban,
            this.bt_sinhvien,
            this.bt_lophoc,
            this.bt_phieumuon,
            this.bt_tksach,
            this.bt_tktacgia,
            this.bt_tknxb,
            this.bt_tkdg,
            this.bt_dssach,
            this.bt_dstacgia,
            this.bt_dsnxb,
            this.bt_dsnv,
            this.bt_dsmuon,
            this.bt_svth,
            this.bt_banthan,
            this.tennv,
            this.bt_tc,
            this.siInfo,
            this.barStaticItem2,
            this.bt_docgia,
            this.bt_qlts,
            this.bt_tusach,
            this.nv,
            this.qnv,
            this.barButtonItem2,
            this.barButtonItem3});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 63;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.tab_hethong,
            this.tab_quanly,
            this.tab_muontra,
            this.tab_timkiem,
            this.tab_thongke,
            this.tab_morong});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemProgressBar1});
            this.ribbon.Size = new System.Drawing.Size(897, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ItemLinks.Add(this.bt_tc);
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbon;
            // 
            // bt_dangnhap
            // 
            this.bt_dangnhap.Caption = "Đăng nhập";
            this.bt_dangnhap.Id = 1;
            this.bt_dangnhap.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.dangnhap;
            this.bt_dangnhap.LargeWidth = 80;
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_dangnhap_ItemClick);
            // 
            // bt_doimatkhau
            // 
            this.bt_doimatkhau.Caption = "Đổi mật khẩu";
            this.bt_doimatkhau.Enabled = false;
            this.bt_doimatkhau.Id = 2;
            this.bt_doimatkhau.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.doimatkhau;
            this.bt_doimatkhau.LargeWidth = 80;
            this.bt_doimatkhau.Name = "bt_doimatkhau";
            this.bt_doimatkhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_doimatkhau_ItemClick);
            // 
            // bt_dangxuat
            // 
            this.bt_dangxuat.Caption = "Đăng xuất";
            this.bt_dangxuat.Enabled = false;
            this.bt_dangxuat.Id = 3;
            this.bt_dangxuat.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.dangxuat;
            this.bt_dangxuat.LargeWidth = 80;
            this.bt_dangxuat.Name = "bt_dangxuat";
            this.bt_dangxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_dangxuat_ItemClick);
            // 
            // skin
            // 
            this.skin.Id = 4;
            this.skin.Name = "skin";
            // 
            // bt_nhapsach
            // 
            this.bt_nhapsach.Caption = "Nhập lô sách";
            this.bt_nhapsach.Enabled = false;
            this.bt_nhapsach.Id = 6;
            this.bt_nhapsach.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.nhapsach;
            this.bt_nhapsach.LargeWidth = 80;
            this.bt_nhapsach.Name = "bt_nhapsach";
            this.bt_nhapsach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_nhapsach_ItemClick);
            // 
            // bt_ttsach
            // 
            this.bt_ttsach.Caption = "Thông tin sách";
            this.bt_ttsach.Enabled = false;
            this.bt_ttsach.Id = 7;
            this.bt_ttsach.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.thongtinsach;
            this.bt_ttsach.LargeWidth = 80;
            this.bt_ttsach.Name = "bt_ttsach";
            this.bt_ttsach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_ttsach_ItemClick);
            // 
            // bt_tttacgia
            // 
            this.bt_tttacgia.Caption = "Thông tin tác giả";
            this.bt_tttacgia.Enabled = false;
            this.bt_tttacgia.Id = 8;
            this.bt_tttacgia.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.edit_tacgia;
            this.bt_tttacgia.LargeWidth = 80;
            this.bt_tttacgia.Name = "bt_tttacgia";
            this.bt_tttacgia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_tttacgia_ItemClick);
            // 
            // bt_tttheloai
            // 
            this.bt_tttheloai.Caption = "Thể loại sách";
            this.bt_tttheloai.Enabled = false;
            this.bt_tttheloai.Id = 9;
            this.bt_tttheloai.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.theloai;
            this.bt_tttheloai.LargeWidth = 80;
            this.bt_tttheloai.Name = "bt_tttheloai";
            this.bt_tttheloai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_tttheloai_ItemClick);
            // 
            // bt_ttnxb
            // 
            this.bt_ttnxb.Caption = "Nhà xuất bản sách";
            this.bt_ttnxb.Enabled = false;
            this.bt_ttnxb.Id = 10;
            this.bt_ttnxb.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.nxb;
            this.bt_ttnxb.LargeWidth = 80;
            this.bt_ttnxb.Name = "bt_ttnxb";
            this.bt_ttnxb.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_ttnxb_ItemClick);
            // 
            // bt_ttnhanvien
            // 
            this.bt_ttnhanvien.Caption = "Nhân viên";
            this.bt_ttnhanvien.Enabled = false;
            this.bt_ttnhanvien.Id = 11;
            this.bt_ttnhanvien.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.nhanvien;
            this.bt_ttnhanvien.LargeWidth = 80;
            this.bt_ttnhanvien.Name = "bt_ttnhanvien";
            this.bt_ttnhanvien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_ttnhanvien_ItemClick);
            // 
            // bt_giangvien
            // 
            this.bt_giangvien.Caption = "Giảng viên";
            this.bt_giangvien.Enabled = false;
            this.bt_giangvien.Id = 13;
            this.bt_giangvien.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.giangvien;
            this.bt_giangvien.LargeWidth = 80;
            this.bt_giangvien.Name = "bt_giangvien";
            // 
            // bt_phongban
            // 
            this.bt_phongban.Caption = "Phòng ban";
            this.bt_phongban.Enabled = false;
            this.bt_phongban.Id = 14;
            this.bt_phongban.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.phongban;
            this.bt_phongban.LargeWidth = 80;
            this.bt_phongban.Name = "bt_phongban";
            // 
            // bt_sinhvien
            // 
            this.bt_sinhvien.Caption = "Sinh viên";
            this.bt_sinhvien.Enabled = false;
            this.bt_sinhvien.Id = 15;
            this.bt_sinhvien.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.student;
            this.bt_sinhvien.LargeWidth = 80;
            this.bt_sinhvien.Name = "bt_sinhvien";
            // 
            // bt_lophoc
            // 
            this.bt_lophoc.Caption = "Lớp học";
            this.bt_lophoc.Enabled = false;
            this.bt_lophoc.Id = 16;
            this.bt_lophoc.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.lophoc;
            this.bt_lophoc.LargeWidth = 80;
            this.bt_lophoc.Name = "bt_lophoc";
            // 
            // bt_phieumuon
            // 
            this.bt_phieumuon.Caption = "Phiếu mượn";
            this.bt_phieumuon.Enabled = false;
            this.bt_phieumuon.Id = 17;
            this.bt_phieumuon.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.pm;
            this.bt_phieumuon.LargeWidth = 80;
            this.bt_phieumuon.Name = "bt_phieumuon";
            this.bt_phieumuon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_phieumuon_ItemClick);
            // 
            // bt_tksach
            // 
            this.bt_tksach.Caption = "Tìm kiếm sách";
            this.bt_tksach.Id = 20;
            this.bt_tksach.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.find_book;
            this.bt_tksach.LargeWidth = 80;
            this.bt_tksach.Name = "bt_tksach";
            this.bt_tksach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_tksach_ItemClick);
            // 
            // bt_tktacgia
            // 
            this.bt_tktacgia.Caption = "Tìm kiếm tác giả";
            this.bt_tktacgia.Id = 22;
            this.bt_tktacgia.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.edit_tacgia;
            this.bt_tktacgia.LargeWidth = 80;
            this.bt_tktacgia.Name = "bt_tktacgia";
            this.bt_tktacgia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_tktacgia_ItemClick);
            // 
            // bt_tknxb
            // 
            this.bt_tknxb.Caption = "Tìm nhà xuất bản";
            this.bt_tknxb.Id = 23;
            this.bt_tknxb.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.nxb;
            this.bt_tknxb.LargeWidth = 80;
            this.bt_tknxb.Name = "bt_tknxb";
            this.bt_tknxb.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_tknxb_ItemClick);
            // 
            // bt_tkdg
            // 
            this.bt_tkdg.Caption = "Tìm độc giả";
            this.bt_tkdg.Id = 25;
            this.bt_tkdg.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.tracuugiaovien;
            this.bt_tkdg.LargeWidth = 80;
            this.bt_tkdg.Name = "bt_tkdg";
            this.bt_tkdg.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_tkdg_ItemClick);
            // 
            // bt_dssach
            // 
            this.bt_dssach.Caption = "Thống kê sách";
            this.bt_dssach.Enabled = false;
            this.bt_dssach.Id = 28;
            this.bt_dssach.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.report_sach;
            this.bt_dssach.LargeWidth = 80;
            this.bt_dssach.Name = "bt_dssach";
            this.bt_dssach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_dssach_ItemClick);
            // 
            // bt_dstacgia
            // 
            this.bt_dstacgia.Caption = "Danh sách tác giả";
            this.bt_dstacgia.Enabled = false;
            this.bt_dstacgia.Id = 29;
            this.bt_dstacgia.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.edit_tacgia;
            this.bt_dstacgia.LargeWidth = 80;
            this.bt_dstacgia.Name = "bt_dstacgia";
            this.bt_dstacgia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_dstacgia_ItemClick);
            // 
            // bt_dsnxb
            // 
            this.bt_dsnxb.Caption = "Danh sách nhà xuất bản";
            this.bt_dsnxb.Enabled = false;
            this.bt_dsnxb.Id = 30;
            this.bt_dsnxb.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.nxb;
            this.bt_dsnxb.LargeWidth = 80;
            this.bt_dsnxb.Name = "bt_dsnxb";
            this.bt_dsnxb.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_dsnxb_ItemClick);
            // 
            // bt_dsnv
            // 
            this.bt_dsnv.Caption = "Danh sách nhân viên";
            this.bt_dsnv.Enabled = false;
            this.bt_dsnv.Id = 33;
            this.bt_dsnv.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.nhanvien;
            this.bt_dsnv.LargeWidth = 80;
            this.bt_dsnv.Name = "bt_dsnv";
            this.bt_dsnv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_dsnv_ItemClick);
            // 
            // bt_dsmuon
            // 
            this.bt_dsmuon.Caption = "Thống kê mượn quá hạn";
            this.bt_dsmuon.Enabled = false;
            this.bt_dsmuon.Id = 34;
            this.bt_dsmuon.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.tramuon1;
            this.bt_dsmuon.LargeWidth = 90;
            this.bt_dsmuon.Name = "bt_dsmuon";
            this.bt_dsmuon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_dsmuon_ItemClick);
            // 
            // bt_svth
            // 
            this.bt_svth.Caption = "Sinh viên thực hiện";
            this.bt_svth.Id = 38;
            this.bt_svth.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.about;
            this.bt_svth.LargeWidth = 80;
            this.bt_svth.Name = "bt_svth";
            this.bt_svth.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_svth_ItemClick);
            // 
            // bt_banthan
            // 
            this.bt_banthan.Caption = "Thông tin tài khoản";
            this.bt_banthan.Enabled = false;
            this.bt_banthan.Id = 40;
            this.bt_banthan.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.info;
            this.bt_banthan.LargeWidth = 80;
            this.bt_banthan.Name = "bt_banthan";
            this.bt_banthan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_banthan_ItemClick);
            // 
            // tennv
            // 
            this.tennv.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.tennv.Caption = "Designed by : Lê Thị Minh Hiếu";
            this.tennv.Id = 46;
            this.tennv.Name = "tennv";
            this.tennv.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bt_tc
            // 
            this.bt_tc.Caption = "Trang chủ";
            this.bt_tc.Glyph = global::QLTV_Heni_4.Properties.Resources.tttruonghoc;
            this.bt_tc.Id = 47;
            this.bt_tc.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.tttruonghoc;
            this.bt_tc.Name = "bt_tc";
            // 
            // siInfo
            // 
            this.siInfo.Caption = "Chào mừng bạn đến với thư viện chúng tôi";
            this.siInfo.Id = 48;
            this.siInfo.Name = "siInfo";
            this.siInfo.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Thông tin  :  ";
            this.barStaticItem2.Id = 49;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bt_docgia
            // 
            this.bt_docgia.Caption = "Độc giả";
            this.bt_docgia.Enabled = false;
            this.bt_docgia.Id = 50;
            this.bt_docgia.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.pupils;
            this.bt_docgia.LargeWidth = 80;
            this.bt_docgia.Name = "bt_docgia";
            this.bt_docgia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_docgia_ItemClick);
            // 
            // bt_qlts
            // 
            this.bt_qlts.Caption = "QL Tựa sách";
            this.bt_qlts.Enabled = false;
            this.bt_qlts.Id = 51;
            this.bt_qlts.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.library_folder1;
            this.bt_qlts.LargeWidth = 80;
            this.bt_qlts.Name = "bt_qlts";
            this.bt_qlts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_qlts_ItemClick);
            // 
            // bt_tusach
            // 
            this.bt_tusach.Caption = "Tủ sách";
            this.bt_tusach.Enabled = false;
            this.bt_tusach.Id = 52;
            this.bt_tusach.LargeGlyph = global::QLTV_Heni_4.Properties.Resources.folder_home2;
            this.bt_tusach.LargeWidth = 80;
            this.bt_tusach.Name = "bt_tusach";
            this.bt_tusach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_tusach_ItemClick);
            // 
            // nv
            // 
            this.nv.Id = 54;
            this.nv.Name = "nv";
            this.nv.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // qnv
            // 
            this.qnv.Id = 55;
            this.qnv.Name = "qnv";
            this.qnv.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 56;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 57;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // tab_hethong
            // 
            this.tab_hethong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.tab_hethong.Name = "tab_hethong";
            this.tab_hethong.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bt_dangnhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.bt_banthan);
            this.ribbonPageGroup1.ItemLinks.Add(this.bt_doimatkhau);
            this.ribbonPageGroup1.ItemLinks.Add(this.bt_dangxuat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Hệ thống";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.skin);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Giao diện";
            // 
            // tab_quanly
            // 
            this.tab_quanly.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.tab_quanly.Name = "tab_quanly";
            this.tab_quanly.Text = "Quản lý";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.bt_qlts);
            this.ribbonPageGroup4.ItemLinks.Add(this.bt_nhapsach);
            this.ribbonPageGroup4.ItemLinks.Add(this.bt_ttsach);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.bt_tttacgia);
            this.ribbonPageGroup5.ItemLinks.Add(this.bt_tttheloai);
            this.ribbonPageGroup5.ItemLinks.Add(this.bt_ttnxb);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.ShowCaptionButton = false;
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.bt_ttnhanvien);
            this.ribbonPageGroup6.ItemLinks.Add(this.bt_docgia);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.ShowCaptionButton = false;
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.bt_tusach);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.ShowCaptionButton = false;
            // 
            // tab_muontra
            // 
            this.tab_muontra.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup9});
            this.tab_muontra.Name = "tab_muontra";
            this.tab_muontra.Text = "Mượn - Trả";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.bt_phieumuon);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.ShowCaptionButton = false;
            // 
            // tab_timkiem
            // 
            this.tab_timkiem.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup11,
            this.ribbonPageGroup12,
            this.ribbonPageGroup13});
            this.tab_timkiem.Name = "tab_timkiem";
            this.tab_timkiem.Text = "Tìm kiếm";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.bt_tksach);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            this.ribbonPageGroup11.ShowCaptionButton = false;
            // 
            // ribbonPageGroup12
            // 
            this.ribbonPageGroup12.ItemLinks.Add(this.bt_tktacgia);
            this.ribbonPageGroup12.ItemLinks.Add(this.bt_tknxb);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            this.ribbonPageGroup12.ShowCaptionButton = false;
            // 
            // ribbonPageGroup13
            // 
            this.ribbonPageGroup13.ItemLinks.Add(this.bt_tkdg);
            this.ribbonPageGroup13.Name = "ribbonPageGroup13";
            this.ribbonPageGroup13.ShowCaptionButton = false;
            // 
            // tab_thongke
            // 
            this.tab_thongke.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup15,
            this.ribbonPageGroup16,
            this.ribbonPageGroup17});
            this.tab_thongke.Name = "tab_thongke";
            this.tab_thongke.Text = "Thống kê - Báo cáo";
            // 
            // ribbonPageGroup15
            // 
            this.ribbonPageGroup15.ItemLinks.Add(this.bt_dssach);
            this.ribbonPageGroup15.ItemLinks.Add(this.bt_dstacgia);
            this.ribbonPageGroup15.ItemLinks.Add(this.bt_dsnxb);
            this.ribbonPageGroup15.Name = "ribbonPageGroup15";
            this.ribbonPageGroup15.ShowCaptionButton = false;
            // 
            // ribbonPageGroup16
            // 
            this.ribbonPageGroup16.ItemLinks.Add(this.bt_dsnv);
            this.ribbonPageGroup16.Name = "ribbonPageGroup16";
            this.ribbonPageGroup16.ShowCaptionButton = false;
            // 
            // ribbonPageGroup17
            // 
            this.ribbonPageGroup17.ItemLinks.Add(this.bt_dsmuon);
            this.ribbonPageGroup17.Name = "ribbonPageGroup17";
            this.ribbonPageGroup17.ShowCaptionButton = false;
            // 
            // tab_morong
            // 
            this.tab_morong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup18,
            this.ribbonPageGroup19});
            this.tab_morong.Name = "tab_morong";
            this.tab_morong.Text = "Mở rộng";
            // 
            // ribbonPageGroup18
            // 
            this.ribbonPageGroup18.ItemLinks.Add(this.bt_svth);
            this.ribbonPageGroup18.Name = "ribbonPageGroup18";
            this.ribbonPageGroup18.ShowCaptionButton = false;
            // 
            // ribbonPageGroup19
            // 
            this.ribbonPageGroup19.Name = "ribbonPageGroup19";
            this.ribbonPageGroup19.ShowCaptionButton = false;
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.tennv);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem2);
            this.ribbonStatusBar.ItemLinks.Add(this.siInfo);
            this.ribbonStatusBar.ItemLinks.Add(this.nv);
            this.ribbonStatusBar.ItemLinks.Add(this.qnv);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 543);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(897, 31);
            // 
            // splitContainerControlWin641
            // 
            this.splitContainerControlWin641.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControlWin641.Location = new System.Drawing.Point(0, 144);
            this.splitContainerControlWin641.Name = "splitContainerControlWin641";
            this.splitContainerControlWin641.Panel1.Controls.Add(this.pictureEdit1);
            this.splitContainerControlWin641.Panel1.Controls.Add(this.navBar);
            this.splitContainerControlWin641.Panel1.Text = "Panel1";
            this.splitContainerControlWin641.Panel2.Controls.Add(this.xtraTabControl1);
            this.splitContainerControlWin641.Panel2.Text = "Panel2";
            this.splitContainerControlWin641.Size = new System.Drawing.Size(897, 399);
            this.splitContainerControlWin641.SplitterPosition = 196;
            this.splitContainerControlWin641.TabIndex = 2;
            this.splitContainerControlWin641.Text = "splitContainerControlWin641";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(12, 145);
            this.pictureEdit1.MenuManager = this.ribbon;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Size = new System.Drawing.Size(181, 138);
            this.pictureEdit1.TabIndex = 1;
            // 
            // navBar
            // 
            this.navBar.ActiveGroup = this.mn_gt;
            this.navBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBar.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.mn_gt});
            this.navBar.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nav_nqtv,
            this.nav_quytrinhlamthe,
            this.nav_quytrinhmuontrasach,
            this.nav_sachmuonnhieu,
            this.nav_web,
            this.nav_tthl,
            this.nav_tvdhdn});
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Name = "navBar";
            this.navBar.OptionsNavPane.ExpandedWidth = 196;
            this.navBar.Size = new System.Drawing.Size(196, 399);
            this.navBar.SkinExplorerBarViewScrollStyle = DevExpress.XtraNavBar.SkinExplorerBarViewScrollStyle.Buttons;
            this.navBar.TabIndex = 0;
            this.navBar.Text = "navBarControl1";
            // 
            // mn_gt
            // 
            this.mn_gt.Caption = "Dành cho bạn đọc";
            this.mn_gt.Expanded = true;
            this.mn_gt.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nav_nqtv),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nav_quytrinhlamthe),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nav_quytrinhmuontrasach)});
            this.mn_gt.Name = "mn_gt";
            this.mn_gt.SmallImage = global::QLTV_Heni_4.Properties.Resources.logo;
            // 
            // nav_nqtv
            // 
            this.nav_nqtv.Caption = "Nội quy thư viện";
            this.nav_nqtv.Name = "nav_nqtv";
            this.nav_nqtv.SmallImage = global::QLTV_Heni_4.Properties.Resources.online0;
            this.nav_nqtv.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nav_nqtv_LinkClicked);
            // 
            // nav_quytrinhlamthe
            // 
            this.nav_quytrinhlamthe.Caption = "Quy trình làm thẻ";
            this.nav_quytrinhlamthe.Name = "nav_quytrinhlamthe";
            this.nav_quytrinhlamthe.SmallImage = global::QLTV_Heni_4.Properties.Resources.online0;
            this.nav_quytrinhlamthe.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nav_quytrinhlamthe_LinkClicked);
            // 
            // nav_quytrinhmuontrasach
            // 
            this.nav_quytrinhmuontrasach.Caption = "Quy định mượn - trả sách";
            this.nav_quytrinhmuontrasach.Name = "nav_quytrinhmuontrasach";
            this.nav_quytrinhmuontrasach.SmallImage = global::QLTV_Heni_4.Properties.Resources.online0;
            this.nav_quytrinhmuontrasach.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nav_quytrinhmuontrasach_LinkClicked);
            // 
            // nav_sachmuonnhieu
            // 
            this.nav_sachmuonnhieu.Caption = "Sách nổi bậc";
            this.nav_sachmuonnhieu.Name = "nav_sachmuonnhieu";
            this.nav_sachmuonnhieu.SmallImage = global::QLTV_Heni_4.Properties.Resources.online0;
            this.nav_sachmuonnhieu.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nav_sachmuonnhieu_LinkClicked);
            // 
            // nav_web
            // 
            this.nav_web.Caption = "Website của thư viện";
            this.nav_web.Name = "nav_web";
            this.nav_web.SmallImage = global::QLTV_Heni_4.Properties.Resources.online0;
            this.nav_web.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nav_nhac_LinkClicked);
            // 
            // nav_tthl
            // 
            this.nav_tthl.Caption = "Trung tâm học liệu";
            this.nav_tthl.Name = "nav_tthl";
            this.nav_tthl.SmallImage = global::QLTV_Heni_4.Properties.Resources.online0;
            // 
            // nav_tvdhdn
            // 
            this.nav_tvdhdn.Caption = "Thư viện Đại học Đà Nẵng";
            this.nav_tvdhdn.Name = "nav_tvdhdn";
            this.nav_tvdhdn.SmallImage = global::QLTV_Heni_4.Properties.Resources.online0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPagesAndTabControlHeader;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderButtons = DevExpress.XtraTab.TabButtons.Close;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.Size = new System.Drawing.Size(696, 399);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.CloseButtonClick += new System.EventHandler(this.xtraTabControl1_CloseButtonClick);
            this.xtraTabControl1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.xtraTabControl1_ControlAdded);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 574);
            this.Controls.Add(this.splitContainerControlWin641);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrangChu";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Phần mềm quản lý thư viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TrangChu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlWin641)).EndInit();
            this.splitContainerControlWin641.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage tab_hethong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem bt_dangnhap;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage tab_quanly;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPage tab_muontra;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPage tab_timkiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup13;
        private DevExpress.XtraBars.Ribbon.RibbonPage tab_thongke;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup15;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup16;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup17;
        private DevExpress.XtraBars.Ribbon.RibbonPage tab_morong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup18;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup19;
        private DevExpress.XtraBars.BarButtonItem bt_doimatkhau;
        private DevExpress.XtraBars.BarButtonItem bt_dangxuat;
        private DevExpress.XtraBars.RibbonGalleryBarItem skin;
        private DevExpress.XtraBars.BarButtonItem bt_nhapsach;
        private DevExpress.XtraBars.BarButtonItem bt_ttsach;
        private DevExpress.XtraBars.BarButtonItem bt_tttacgia;
        private DevExpress.XtraBars.BarButtonItem bt_tttheloai;
        private DevExpress.XtraBars.BarButtonItem bt_ttnxb;
        private DevExpress.XtraBars.BarButtonItem bt_ttnhanvien;
        private DevExpress.XtraBars.BarButtonItem bt_giangvien;
        private DevExpress.XtraBars.BarButtonItem bt_phongban;
        private DevExpress.XtraBars.BarButtonItem bt_sinhvien;
        private DevExpress.XtraBars.BarButtonItem bt_lophoc;
        private DevExpress.XtraBars.BarButtonItem bt_phieumuon;
        private DevExpress.XtraBars.BarButtonItem bt_tksach;
        private DevExpress.XtraBars.BarButtonItem bt_tktacgia;
        private DevExpress.XtraBars.BarButtonItem bt_tknxb;
        private DevExpress.XtraBars.BarButtonItem bt_tkdg;
        private DevExpress.XtraBars.BarButtonItem bt_dssach;
        private DevExpress.XtraBars.BarButtonItem bt_dstacgia;
        private DevExpress.XtraBars.BarButtonItem bt_dsnxb;
        private DevExpress.XtraBars.BarButtonItem bt_dsnv;
        private DevExpress.XtraBars.BarButtonItem bt_dsmuon;
        private DevExpress.XtraBars.BarButtonItem bt_svth;
        private DevExpress.XtraBars.BarButtonItem bt_banthan;
        private DevExpress.XtraBars.BarStaticItem tennv;
        private DevExpress.XtraCharts.Wizard.SplitContainerControlWin64 splitContainerControlWin641;
        private DevExpress.XtraNavBar.NavBarControl navBar;
        private DevExpress.XtraNavBar.NavBarGroup mn_gt;
        private DevExpress.XtraBars.BarButtonItem bt_tc;
        private DevExpress.XtraBars.BarStaticItem siInfo;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarButtonItem bt_docgia;
        private DevExpress.XtraNavBar.NavBarItem nav_nqtv;
        private DevExpress.XtraNavBar.NavBarItem nav_quytrinhlamthe;
        private DevExpress.XtraNavBar.NavBarItem nav_quytrinhmuontrasach;
        private DevExpress.XtraNavBar.NavBarItem nav_sachmuonnhieu;
        private DevExpress.XtraNavBar.NavBarItem nav_web;
        private DevExpress.XtraNavBar.NavBarItem nav_tthl;
        private DevExpress.XtraNavBar.NavBarItem nav_tvdhdn;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraBars.BarButtonItem bt_qlts;
        private DevExpress.XtraBars.BarButtonItem bt_tusach;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarStaticItem nv;
        private DevExpress.XtraBars.BarStaticItem qnv;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}