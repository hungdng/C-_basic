using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLTV_Heni_4.DAL;
using QLTV_Heni_4.DTO;

namespace QLTV_Heni_4.BLL
{
    class LoSach_BLL
    {
        ConnectDB connData = new ConnectDB();

        public DataTable LayDSChoCuonSach()
        {
            string sql = "SELECT MaLoSach, MaTuaSach,SoLuong FROM LOSACH ORDER BY MaLoSach DESC";
            return connData.getdata(sql);
        }
        //Hàm lấy tất cả danh sách Sách để hiển thị
        public DataTable LayDanhSachLoSach(string mpn)
        {
            string df = "select * from LOSACH where MaPhieuNhap='" + mpn + "' ORDER BY MaLoSach DESC";
            DataTable d = connData.getdata(df);
            if (d.Rows.Count > 0)
            {
                return d;
            }
            else
            {
                string sql = " SELECT MaLoSach,MaPhieuNhap,MaTuaSach, MaNXB, TaiBan,NamXB,SoLuong,DonGia FROM LOSACH ORDER BY MaLoSach DESC";
                return connData.getdata(sql);
            }
        }

        //Hàm lấy tất cả danh sách Sách để hiển thị cho Reports
        public DataTable LayDSLoSachReport()
        {
            string sql = " SELECT MaLoSach,MaPhieuNhap,MaTuaSach, MaNXB, TaiBan,NamXB,SoLuong,DonGia FROM LOSACH ORDER BY MaLoSach DESC";
            return connData.getdata(sql);
        }

        // Lấy danh lo Sách load lên Combobox
        public DataTable LayDSLoSach()
        {
            string sql = "SELECT MaLoSach,MaPhieuNhap, MaTuaSach FROM TUASACH ORDER BY MaLoSach DESC";
            return connData.getdata(sql);
        }

        // Lấy danh sách Sách theo Lo sách
        public DataTable LayDSLoSachTheoPN(string MaPN)
        {
            string sql = "SELECT MaPhieu, MaTuaSach FROM CT_PHIEUMUON WHERE MaPhieu='" + MaPN + "'";
            return connData.getdata(sql);
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(LoSach_DTO ls)
        {
            if (ls.MaPhieuNhap.Equals(""))
            {
                MessageBox.Show("Phiếu nhập không hợp lệ ! ");
                return false;
            }
            if (ls.MaTuaSach.Equals(""))
            {
                MessageBox.Show("Tựa Sách không hợp lệ ! ");
                return false;
            }

            if (ls.MaNXB.Equals(""))
            {
                MessageBox.Show("Nhà xuất bản không hợp lệ ! ");
                return false;
            }
            if (ls.SoLuong.Equals(""))
            {
                MessageBox.Show("Số lượng sách không hợp lệ ! ");
                return false;
            }
            if (ls.SoLuong.Equals("0"))
            {
                MessageBox.Show("Số lượng sách không hợp lệ ! ");
                return false;
            }

            return true;
        }
        private CuonSach_BLL cs = new CuonSach_BLL();
        string tts = "Chưa được mượn";
        //Thêm Sách vào CSDL
        public bool ThemLoSach(LoSach_DTO ls)
        {
            if (KiemTraTruocKhiLuu(ls))
            {
                string sql = string.Format("INSERT INTO LOSACH (MaLoSach,MaPhieuNhap,MaTuaSach, MaNXB, TaiBan, NamXB,Soluong,DonGia)"
                    + " VALUES ('{0}', N'{1}', N'{2}', '{3}','{4}', N'{5}', '{6}', '{7}')",
                    ls.MaLoSach,ls.MaPhieuNhap,ls.MaTuaSach, ls.MaNXB, ls.TaiBan, ls.NamXB,ls.SoLuong,ls.DonGia);
                if (connData.ThucThiSQL(sql))
                {
                    
                    int sl=Convert.ToInt32(ls.SoLuong);
                    for (int i = 1; i<=sl; i++)
                    {

                        string s =string.Format( "insert into CUONSACH (MaSach,MaLoSach,TinhTrangSach)"+"values ('{0}',N'{1}',N'{2}')",cs.NextID(),ls.MaLoSach,tts);
                        connData.ThucThiSQL(s);
                    }
                    MessageBox.Show("Thêm lô sách mới thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Sửa Sách vào CSDL
        public bool SuaLoSach(LoSach_DTO ls)
        {
            if (KiemTraTruocKhiLuu(ls))
            {
                string sql = string.Format("UPDATE LOSACH SET MaPhieuNhap=N'{1}', MaTuaSach=N'{2}', MaNXB='{3}',TaiBan=N'{4}', NamXB=N'{5}', SoLuong='{6}',DonGia='{7}' WHERE MaLoSach='{0}'",
                    ls.MaLoSach,ls.MaPhieuNhap, ls.MaTuaSach, ls.MaNXB, ls.TaiBan,ls.NamXB,ls.SoLuong,ls.DonGia);
                if (connData.ThucThiSQL(sql))
                {
                    string c = "select * from CUONSACH where MaLoSach='" + ls.MaLoSach + "'";
                    DataTable css = connData.getdata(c);
                    int sl = Convert.ToInt32(ls.SoLuong);
                    if ((css.Rows.Count) != sl)
                    {
                        string xs = "delete from CUONSACH where MaLoSach='"+ ls.MaLoSach +"'";
                        connData.ThucThiSQL(xs);
                        for (int i = 1; i <= sl; i++)
                        {
                            string s = string.Format("insert into CUONSACH (MaSach,MaLoSach,TinhTrangSach)" + "values ('{0}','{1}')",cs.NextID(), ls.MaLoSach,tts);
                            connData.ThucThiSQL(s);
                        }
                    }
                    MessageBox.Show("Sửa thông tin lô Sách thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    return true;
                }
            }
            return false;
        }

        //Xóa Sách trong CSDL
        public bool XoaLoSach(string MaLoSach)
        {
            string sql = "DELETE FROM LOSACH WHERE MaLoSach='" + MaLoSach + "'";
            string s = "select * from LOSACH";
             DataTable tbTL = connData.getdata(s);
             if (tbTL.Rows.Count > 1)
             {
                 if (connData.ThucThiSQL(sql))
                 {
                     string cs = "DELETE FROM CUONSACH where MaLoSach='" + MaLoSach + "'";
                     connData.ThucThiSQL(cs);
                     MessageBox.Show("Xóa thông tin lô Sách thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     return true;
                 }
             }
             MessageBox.Show("Xóa thông tin lô Sách không thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }
        //Kiểm tra tồn tại của Mã tựa sách
        public bool KiemTra(string mts)
        {
            if (connData.KiemTraTonTai("PHIEUMUON", "MaTuaSach", mts))
                return true;
            return false;
        }
        //Lấy Mã dg kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connData.GetLastID("LOSACH", "MaLoSach"), "LS");
        }

        //Tim kiem sach theo Tieu Chi
        public DataTable TimKiemLoSach(string DieuKien, string TieuChi)
        {
            string sql = " SELECT MaLoSach,MaPhieuNhap,MaTuaSach, MaNXB FROM LOSACH WHERE " + DieuKien + " LIKE N'%" + TieuChi + "%'";
            return connData.getdata(sql);
        }
    }
}
