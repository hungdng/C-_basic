using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QLTV_Heni_4.DTO;
using QLTV_Heni_4.DAL;

namespace QLTV_Heni_4.BLL
{
    class PhieuMuon_BLL
    {
        ConnectDB connData = new ConnectDB();
        public DataTable Lay_report()
        {
            string sql = "SELECT MaPhieuMuon, MaDG, HoTenDG, GioiTinhDG, NgaySinhDG, NgayMuon, NgayHenTra, TinhTrangMuon FROM dbo.Report_QuaHan";
            return connData.getdata(sql);
        }
        //Hàm lấy tất cả danh sách Sách để hiển thị
        public DataTable LayDanhSachPhieuMuon()
        {
            string t = "Đang Mượn";
            string sql = " SELECT * FROM PHIEUMUON where TinhTrangMuon like N'%" + t + "%'";
            return connData.getdata(sql);
        }

        //Hàm lấy tất cả danh sách Sách để hiển thị cho Reports
        public DataTable LayDSPhieuMuonReport()
        {
            string sql = " SELECT * FROM PHIEUMUON ORDER BY MaPhieuMuon DESC";
            return connData.getdata(sql);
        }

        // Lấy danh lo Sách load lên Combobox
        public DataTable LayDSPhieuMuon()
        {
            string sql = "SELECT MaPhieuMuon,MaDG FROM PHIEUMUON ORDER BY MaPhieuMuon DESC";
            return connData.getdata(sql);
        }

        //// Lấy danh sách Sách theo Lo sách
        //public DataTable LayDSLoSachTheoPN(string MaPN)
        //{
        //    string sql = "SELECT MaPhieu, MaTuaSach FROM CT_PHIEUMUON WHERE MaPhieu='" + MaPN + "'";
        //    return connData.getdata(sql);
        //}

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(PhieuMuon_DTO pm)
        {
            if (pm.MaPhieuMuon.Equals(""))
            {
                MessageBox.Show("Phiếu mượn sách không hợp lệ ! ");
                return false;
            }
            if (pm.MaDG.Equals(""))
            {
                MessageBox.Show("Độc giả không hợp lệ ! ");
                return false;
            }

            if (pm.NgayHenTra.Equals(""))
            {
                MessageBox.Show("Ngày hẹn trả không hợp lệ ! ");
                return false;
            }
            if (pm.NgayMuon.Equals(""))
            {
                MessageBox.Show("Ngày mượn sách sách không hợp lệ ! ");
                return false;
            }

            return true;
        }
        private CuonSach_BLL cs = new CuonSach_BLL();
        //Thêm Sách vào CSDL
        public bool ThemPhieuMuon(PhieuMuon_DTO pm)
        {
            if (KiemTraTruocKhiLuu(pm))
            {
                string sql = string.Format("INSERT INTO PHIEUMUON (MaPhieuMuon,MaDG,NgayMuon, NgayHenTra, TinhTrangMuon)"
                    + " VALUES ('{0}', N'{1}', N'{2}', '{3}',N'{4}')",
                    pm.MaPhieuMuon, pm.MaDG, pm.NgayMuon, pm.NgayHenTra, pm.TinhTrangMuon);
                if (connData.ThucThiSQL(sql))
                {
                    
                    MessageBox.Show("Thêm phiếu mượn sách mới thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Sửa Sách vào CSDL
        public bool SuaPhieuMuon(PhieuMuon_DTO pm)
        {
            if (KiemTraTruocKhiLuu(pm))
            {
                string sql = string.Format("UPDATE PHIEUMUON SET MaDG=N'{1}', NgayMuon=N'{2}', NgayHenTra='{3}' WHERE MaPhieuMuon='{0}'",
                    pm.MaPhieuMuon, pm.MaDG, pm.NgayMuon, pm.NgayHenTra);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Sửa thông tin phiếu mượn thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }
        // Trả phiếu mượn
        public bool TraPhieuMuon(PhieuMuon_DTO pm)
        {
            if (KiemTraTruocKhiLuu(pm))
            {
                string sql = string.Format("UPDATE PHIEUMUON SET MaDG=N'{1}', NgayMuon=N'{2}', NgayHenTra='{3}',NgayTra='{4}',TinhTrangMuon=N'{5}' WHERE MaPhieuMuon='{0}'",
                    pm.MaPhieuMuon, pm.MaDG, pm.NgayMuon, pm.NgayHenTra,pm.NgayTra,pm.TinhTrangMuon);
                if (connData.ThucThiSQL(sql))
                {
                    string s = "update CHITIET_MUON set TinhTrangCTMuon=N'Đã trả' where MaPhieuMuon='"+pm.MaPhieuMuon+"'";
                    connData.ThucThiSQL(s);
                    string h = "select MaSach from CHITIET_MUON where MaPhieuMuon='" + pm.MaPhieuMuon + "'";
                    DataTable psm = connData.getdata(h);
                    int row = psm.Rows.Count;
                    for (int i = 0; i < row; i++)
                    {
                        DataRow k=psm.Rows[i];
                        string j = "update CUONSACH set TinhTrangSach= N'Chưa được mượn' where MaSach='"+k["MaSach"].ToString()+"'";
                        connData.ThucThiSQL(j);
                    }
                    MessageBox.Show("Trả phiếu mượn thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }
        //Xóa Sách trong CSDL
        public bool XoaPhieuMuon(string MaPhieuMuon)
        {
            string sql = "DELETE FROM PHIEUMUON WHERE MaPhieuMuon='" + MaPhieuMuon + "'";
            string s = "select * from PHIEUMUON";
            DataTable tbTL = connData.getdata(s);
            if (tbTL.Rows.Count > 1)
            {
                if (connData.ThucThiSQL(sql))
                {
                    string h = "DELETE from CHITIET_MUON where MaPhieuMuon = '" + MaPhieuMuon + "'";
                    if (connData.ThucThiSQL(h))
                    {
                        MessageBox.Show("Xóa phiếu mượn thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }
            }
            MessageBox.Show("Xóa phiếu mượn không thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }
        //Kiểm tra tồn tại của Mã tựa sách
        public bool KiemTra(string mpm)
        {
            if (connData.KiemTraTonTai("CHITIET_MUON", "MaPhieuMuon", mpm))
                return true;
            return false;
        }
        //Lấy Mã dg kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connData.GetLastID("PHIEUMUON", "MaPhieuMuon"), "PM");
        }

        //Tim kiem sach theo Tieu Chi
        public DataTable TimKiemLoSach(string DieuKien, string TieuChi)
        {
            string sql = " SELECT MaPhieuMuon,MaDG FROM PHIEUMUON WHERE " + DieuKien + " LIKE N'%" + TieuChi + "%'";
            return connData.getdata(sql);
        }
    }
}
