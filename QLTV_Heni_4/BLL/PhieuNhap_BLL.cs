using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QLTV_Heni_4.DAL;
using QLTV_Heni_4.DTO;

namespace QLTV_Heni_4.BLL
{
    class PhieuNhap_BLL
    {
        ConnectDB connData = new ConnectDB();

        public DataTable Lay_Report(string mpn)
        {
            string sql = "SELECT MaPhieuNhap, NgayNhap, MaLoSach, MaTuaSach, TuaSach, TenTL, TuSach, TenNXB, SoLuong FROM Report_NhapSach ORDER BY MaPhieuNhap DESC";
            string d;
            if (mpn != "")
            {
                d = mpn;
            }
            else
            {
                d = mpn;
            }
            DataTable t = connData.getdata(d);
            if (t.Rows.Count > 0)
            {
                return t;
            }
            else
            {
                return null;
                    //connData.getdata(sql);
            }
        }

        //Hàm lấy tất cả danh sách Thể loại để hiển thị
        public DataTable LayDanhSachPhieuNhap()
        {
            string sql = "SELECT MaPhieuNhap, NgayNhap FROM PHIEUNHAP ORDER BY MaPhieuNhap DESC";
            return connData.getdata(sql);
        }

        
        public DataTable LayDSPN()
        {
            string sql = "SELECT MaPhieuNhap, NgayNhap FROM PHIEUNHAP ORDER BY MaPhieuNhap DESC";
            return connData.getdata(sql);
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(PhieuNhap_DTO pn)
        {
            if (pn.NgayNhap.Equals(""))
            {
                MessageBox.Show("Ngày nhập không hợp lệ ! ");
                return false;
            }
            return true;
        }

        //Kiểm tra tồn tại của phiếu nhập
        public bool KiemTra(string mapn)
        {
            if (connData.KiemTraTonTai("LOSACH", "MaPhieuNhap", mapn))
                return true;
            return false;
        }

        //Thêm Thể loại vào CSDL
        public bool ThemPN(PhieuNhap_DTO pn)
        {
            if (KiemTraTruocKhiLuu(pn))
            {
                string sql = string.Format("INSERT INTO PHIEUNHAP (MaPhieuNhap, NgayNhap)"
                    + " VALUES ('{0}', N'{1}')", pn.MaPhieuNhap, pn.NgayNhap);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Thêm phiếu nhập mới thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }


        //Sửa Thể Loại vào CSDL
        public bool SuaPN(PhieuNhap_DTO pn)
        {
            if (KiemTraTruocKhiLuu(pn))
            {
                string sql = string.Format("UPDATE PHIEUNHAP SET NgayNhap=N'{0}' WHERE MaPhieuNhap='{1}'", pn.NgayNhap, pn.MaPhieuNhap);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Sửa phiếu nhập thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Xóa Thể loại trong CSDL
        public bool XoaPN(string MaPN)
        {
            string sql = "DELETE FROM PHIEUNHAP WHERE MaPhieuNhap='" + MaPN + "'";
            string s = "select MaPhieuNhap from PHIEUNHAP";
            DataTable tbTL = connData.getdata(s);
            if (tbTL.Rows.Count > 1)
            {
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Xóa phiếu nhập thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            MessageBox.Show("Phiếu nhập cuối cùng không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        //Lấy Mã TG kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connData.GetLastID("PHIEUNHAP", "MaPhieuNhap"), "PN");
        }
    }
}
