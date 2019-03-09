using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QLTV_Heni_4.DTO;
using QLTV_Heni_4.DAL;
namespace QLTV_Heni_4.BLL
{
    class DocGia_BLL
    {
        ConnectDB connData = new ConnectDB();
        // tìm kiếm độc giả
        public DataTable TimKiem_DocGia(string MaDG, string TenDG)
        {
            string sql = "SELECT MaDG, HoTenDG, EmailDG, (CASE GioiTinhDG WHEN 'true' THEN N'Nam' ELSE N'Nữ' END) AS GioiTinhDG, NgaySinhDG, DiaChiDG, DienThoaiDG, NgayLamThe, NgayHetHan FROM DOCGIA";
       //     string sql1 = "SELECT MaTG,HoTenTG,(CASE GioiTinhTG WHEN 'true' THEN N'Nam' ELSE N'Nữ' END) AS GioiTinhTG,NgaySinhTG,DienThoaiTG,DiaChiTG FROM TACGIA ORDER BY MaTG DESC ";
            string d = "";
            if (MaDG == "" && TenDG == "")
            {
                d = sql;
            }
            if (MaDG != "" && TenDG == "")
            {
                d = sql + " where MaDG like N'%" + MaDG + "%'";
            }
            if (MaDG == "" && TenDG != "")
            {
                d = sql + " where HoTenDG like N'%" + TenDG + "%' ";
            }
            if (MaDG != "" && TenDG != "")
            {
                d = sql + " where MaDG like N'%" + MaDG + "%' and HoTenDG like N'%" + TenDG + "%' ";
            }

            DataTable t = connData.getdata(d);
            if (t.Rows.Count > 0)
            {
                return t;
            }
            else
            {
                return connData.getdata(sql);
            }
        }

        // Phiếu mượn sách theo độc giả
        public DataTable LayDS_PMTheoDG(string MaDG)
        {
            string d = "select MaPhieuMuon,NgayMuon,NgayTra,TinhTrangMuon from PHIEUMUON ORDER BY MaPhieuMuon DESC";
            string sql = "select MaPhieuMuon,NgayMuon,NgayTra,TinhTrangMuon from PHIEUMUON where MaDG='" + MaDG + "' ORDER BY MaPhieuMuon DESC";
            DataTable s = connData.getdata(sql);
            if (s.Rows.Count > 0)
            {
                return s;
            }
            else
            {
                return connData.getdata(d);
            }
        }

        public DataTable DSDG()
        {
            string sql = "SELECT MaDG, HoTenDG FROM DOCGIA,PHIEUMUON where (DOCGIA.MaDG=PHIEUMUON.MaDG and DOCGIA.MaDG != PHIEUMUON.MaDG)";
            DataTable dg=connData.getdata(sql);
            if (dg.Rows.Count > 0)
            {
                return dg;
            }
            else
            {
                string s = "SELECT MaDG, HoTenDG FROM DOCGIA";
                return connData.getdata(s);
            }
        }

        //Hàm lấy tất cả danh sách Độc giả để hiển thị
        public DataTable LayDanhSachDocGia()
        {
            string sql = "SELECT MaDG, HoTenDG, EmailDG, (CASE GioiTinhDG WHEN 'true' THEN N'Nam' ELSE N'Nữ' END) AS GioiTinhDG, NgaySinhDG, DiaChiDG, DienThoaiDG, NgayLamThe, NgayHetHan FROM DOCGIA";
            return connData.getdata(sql);
        }

        //Lấy Danh sách Độc giả load sang Reports Độc giả
        public DataTable Laydsdocgia()
        {
            string sql = "SELECT MaDG, HoTenDG, EmailDG, GioiTinhDG, NgaySinhDG, DiaChiDG, DienThoaiDG, NgayLamThe, NgayHetHan, HoatDong FROM DOCGIA ";
            return connData.getdata(sql);
        }

        // Lấy danh sách DG cho load sang ComboBox PM
        public DataTable LayDSDG()
        {
            string sql = "SELECT MaDG, HoTenDG FROM DOCGIA";
            return connData.getdata(sql);
        }

        //Kiểm tra tồn tại của Mã độc giả
        public bool KiemTra(string mts)
        {
            if (connData.KiemTraTonTai("PHIEUMUON", "MaDG", mts))
                return true;
            return false;
        }
        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(DocGia_DTO dg)
        {
            if (dg.HoTenDG.Equals(""))
            {
                MessageBox.Show("Tên Độc Giả không hợp lệ ! ");
                return false;
            }
            if (dg.NgaySinhDG.Equals(""))
            {
                MessageBox.Show("Ngày Sinh Độc Giả không hợp lệ ! ");
                return false;
            }
            if (dg.NgayLamThe.Equals(""))
            {
                MessageBox.Show("Ngày Làm thẻ Độc Giả không hợp lệ ! ");
                return false;
            }
            if (dg.NgayHetHan.Equals(""))
            {
                MessageBox.Show("Ngày Hết hạn thẻ không hợp lệ ! ");
                return false;
            }
            return true;
        }

        //Thêm Độc Giả vào CSDL
        public bool ThemDG(DocGia_DTO dg)
        {
            if (KiemTraTruocKhiLuu(dg))
            {
                string sql = string.Format("INSERT INTO DOCGIA (MaDG, HoTenDG, EmailDG, GioiTinhDG, NgaySinhDG, DiaChiDG, DienThoaiDG, NgayLamThe, NgayHetHan)"
                    + " VALUES ('{0}', N'{1}', N'{2}', '{3}',N'{4}', N'{5}', N'{6}', N'{7}', N'{8}')", dg.MaDG, dg.HoTenDG, dg.EmailDG, dg.GioiTinhDG, dg.NgaySinhDG, dg.DiaChiDG, dg.DienThoaiDG, dg.NgayLamThe, dg.NgayHetHan);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Thêm Độc Giả thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Sửa Độc Giả vào CSDL
        public bool SuaDG(DocGia_DTO dg)
        {
            if (KiemTraTruocKhiLuu(dg))
            {
                string sql = string.Format("UPDATE DOCGIA SET HoTenDG=N'{1}', EmailDG=N'{2}', GioiTinhDG={3}, NgaySinhDG=N'{4}', DiaChiDG=N'{5}', DienThoaiDG=N'{6}', NgayLamThe=N'{7}', NgayHetHan=N'{8}' WHERE MaDG=N'{0}'",
                    dg.MaDG, dg.HoTenDG, dg.EmailDG, dg.GioiTinhDG, dg.NgaySinhDG, dg.DiaChiDG, dg.DienThoaiDG, dg.NgayLamThe, dg.NgayHetHan);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Sửa Độc Giả thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Xóa Độc Giả trong CSDL
        public bool XoaDG(string MaDG)
        {
            string sql = "DELETE FROM DOCGIA WHERE MaDG='" + MaDG + "'";
           string s = "select * from DOCGIA";
            DataTable tbTL = connData.getdata(s);
            if (tbTL.Rows.Count > 1)
            {
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Xóa Độc Giả thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            MessageBox.Show("Xóa Độc Giả không thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        //Lấy Mã dg kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connData.GetLastID("DOCGIA", "MaDG"), "DG");
        }

        //Tim kiem sach theo Tieu Chi
        public DataTable TimKiemDG(string DieuKien, string TieuChi)
        {
            string sql = " SELECT MaDG, HoTenDG, EmailDG, (CASE GioiTinhDG WHEN 'true' THEN N'Nam' ELSE N'Nữ' END) AS GioiTinhDG, NgaySinhDG, DiaChiDG, DienThoaiDG, NgayLamThe, NgayHetHan FROM DOCGIA WHERE " + DieuKien + " LIKE N'%" + TieuChi + "%'";
            return connData.getdata(sql);
        }
        //đếm độc giả
        public string demdocgia()
        {
            string sql = "select * from TongDG";
            DataTable s = connData.getdata(sql);
            DocGia_DTO dg = new DocGia_DTO();
            DataRow g = s.Rows[0];
            string t = g["tongDG"].ToString();
            return t;
        }
        //  dem doc gia trong bang lượt mượn
        public string demDG_Luotmuon()
        {
            string sql = "select COUNT(*) as DG_LM from DocGia_TongMuon";
            DataTable lm = connData.getdata(sql);
            DocGia_DTO dg = new DocGia_DTO();
            DataRow g = lm.Rows[0];
            string t = g["DG_LM"].ToString();
            return t;
        }
        // Lượt mượn độc giả
        public DataTable LuotMuon_DocGia()
        {
            string sql = "SELECT MaDG, HoTenDG, EmailDG, (CASE GioiTinhDG WHEN 'true' THEN N'Nam' ELSE N'Nữ' END) AS GioiTinhDG, NgaySinhDG, DiaChiDG, DienThoaiDG, NgayLamThe, NgayHetHan,LanMuon FROM DocGia_TongMuon ORDER BY LanMuon DESC";
            return connData.getdata(sql);
        }

        // report dộc giả theo số lượng cần report
        public DataTable Report_docgia_sl(string sl)
        {
            string sql = "SELECT MaDG, HoTenDG, EmailDG, (CASE GioiTinhDG WHEN 'true' THEN N'Nam' ELSE N'Nữ' END) AS GioiTinhDG, NgaySinhDG, DienThoaiDG, NgayLamThe, NgayHetHan,LanMuon FROM DocGia_TongMuon ORDER BY LanMuon DESC";
            string d;
            if (sl !="")
            {
                int s = Convert.ToInt32(sl);
                d = "SELECT TOP " + s + " MaDG, HoTenDG, EmailDG, (CASE GioiTinhDG WHEN 'true' THEN N'Nam' ELSE N'Nữ' END) AS GioiTinhDG, NgaySinhDG, DienThoaiDG, NgayLamThe, NgayHetHan,LanMuon FROM DocGia_TongMuon ORDER BY LanMuon DESC";     
            }
            else
            {
                d = "SELECT MaDG, HoTenDG, EmailDG, (CASE GioiTinhDG WHEN 'true' THEN N'Nam' ELSE N'Nữ' END) AS GioiTinhDG, NgaySinhDG, DienThoaiDG, NgayLamThe, NgayHetHan,LanMuon FROM DocGia_TongMuon ORDER BY LanMuon DESC";
            }
            DataTable t = connData.getdata(d);
            if (t.Rows.Count > 0)
            {
                return t;
            }
            else
            {
                return connData.getdata(sql);
            }
        }
//Tìm kiếm độc giả trong lượt mượn
        public DataTable TimKiem_DocGia_LuotMuon(string MaDG, string TenDG)
        {
            string sql = "SELECT MaDG, HoTenDG, EmailDG, (CASE GioiTinhDG WHEN 'true' THEN N'Nam' ELSE N'Nữ' END) AS GioiTinhDG, NgaySinhDG, DiaChiDG, DienThoaiDG, NgayLamThe, NgayHetHan,LanMuon FROM DocGia_TongMuon";
           
            string d = "";
            if (MaDG == "" && TenDG == "")
            {
                d = sql;
            }
            if (MaDG != "" && TenDG == "")
            {
                d = sql + " where MaDG like N'%" + MaDG + "%'";
            }
            if (MaDG == "" && TenDG != "")
            {
                d = sql + " where HoTenDG like N'%" + TenDG + "%' ";
            }
            if (MaDG != "" && TenDG != "")
            {
                d = sql + " where MaDG like N'%" + MaDG + "%' and HoTenDG like N'%" + TenDG + "%' ";
            }

            DataTable t = connData.getdata(d);
            if (t.Rows.Count > 0)
            {
                return t;
            }
            else
            {
                return connData.getdata(sql);
            }
        }

    }
}
