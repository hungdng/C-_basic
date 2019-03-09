using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QLTV_Heni_4.DAL;
using QLTV_Heni_4.DTO;

namespace QLTV_Heni_4.BLL
{
    class NhaXuatBan_BLL
    {
        ConnectDB connData = new ConnectDB();

        public DataTable LayDSNXB_Report_SL(string sl)
        {
            string sql = "SELECT MaNXB, TenNXB, DiaChiNXB, DienThoaiNXB, Website, ss_nxb FROM NXB_SOSACH ORDER BY ss_nxb DESC";
            string d;
            if (sl != "")
            {
                int s = Convert.ToInt32(sl);
                d = "SELECT top "+s+" MaNXB, TenNXB, DiaChiNXB, DienThoaiNXB, Website, ss_nxb FROM NXB_SOSACH ORDER BY ss_nxb DESC";
            }
            else
            {
                d = "SELECT MaNXB, TenNXB, DiaChiNXB, DienThoaiNXB, Website, ss_nxb FROM NXB_SOSACH ORDER BY ss_nxb DESC";
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

        public DataTable LayDSNXB_Report()
        {
            string sql = "SELECT MaNXB, TenNXB, DiaChiNXB, DienThoaiNXB, Website, ss_nxb FROM dbo.NXB_SOSACH ORDER BY ss_nxb DESC";
            return connData.getdata(sql);
        }

        public string dem_nxb()
        {
            string sql = "select COUNT(*) as TongNXB from NXB_SOSACH ";
            DataTable lm = connData.getdata(sql);
            DocGia_DTO dg = new DocGia_DTO();
            DataRow g = lm.Rows[0];
            string t = g["TongNXB"].ToString();
            return t;
        }
        // Tìm tác giả thoe mã, tên
        public DataTable Tim_NhaXuatBan(string MaNXB, string TenNXB)
        {
            string sql = "SELECT MaNXB, TenNXB, DiaChiNXB, DienThoaiNXB, Website FROM NHAXUATBAN";
            string sql1 = "SELECT MaNXB, TenNXB, DiaChiNXB, DienThoaiNXB, Website FROM NHAXUATBAN ORDER BY MaNXB DESC";
            string d = "";
            if (MaNXB == "" && TenNXB == "")
            {
                d = sql;
            }
            if (MaNXB != "" && TenNXB == "")
            {
                d = sql + " where MaNXB like N'%" + MaNXB + "%' ORDER BY MaNXB DESC";
            }
            if (MaNXB == "" && TenNXB != "")
            {
                d = sql + " where TenNXB like N'%" + TenNXB + "%' ORDER BY MaNXB DESC";
            }
            if (MaNXB != "" && TenNXB != "")
            {
                d = sql + " where MaNXB like N'%" + MaNXB + "%' and TenNXB like N'%" + TenNXB + "%' ORDER BY MaNXB DESC";
            }

            DataTable t = connData.getdata(d);
            if (t.Rows.Count > 0)
            {
                return t;
            }
            else
            {
                return connData.getdata(sql1);
            }
        }


        //Lay danh sach sách theo nxb
        public DataTable LayDSSachTheoNXB(string MaNXB)
        {
            string d = "select MaTuaSach,TuaSach,NDTT from TUASACH ORDER BY MaTuaSach DESC";
            string sql = "select LOSACH.MaTuaSach,TUASACH.TuaSach,TUASACH.NDTT from LOSACH,TUASACH where LOSACH.MaNXB='" + MaNXB + "' and LOSACH.MaTuaSach=TUASACH.MaTuaSach ORDER BY MaTuaSach DESC";
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


        //Hàm lấy tất cả danh sách NXB để hiển thị
        public DataTable LayDanhSachNXB()
        {
            string sql = "SELECT MaNXB, TenNXB, DiaChiNXB, DienThoaiNXB, Website FROM NHAXUATBAN ORDER BY MaNXB DESC";
            return connData.getdata(sql);
        }

        // Lấy danh sách NXB load sang Combobox
        public DataTable LayDSNXB()
        {
            string sql = "SELECT MaNXB, TenNXB FROM NHAXUATBAN ORDER BY MaNXB DESC";
            return connData.getdata(sql);
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(NhaXuatBan_DTO nxb)
        {
            if (nxb.MaNXB.Equals(""))
            {
                MessageBox.Show("Mã Nhà Xuất bản không hợp lệ ! ");
                return false;
            }
            if (nxb.TenNXB.Equals(""))
            {
                MessageBox.Show("Tên Nhà Xuất bản không hợp lệ ! ");
                return false;
            }
            if (nxb.DiaChiNXB.Equals(""))
            {
                MessageBox.Show("Địa chỉ Nhà Xuất bản không hợp lệ ! ");
                return false;
            }
            return true;
        }

        //Kiểm tra tồn tại của Mã NXB
        public bool KiemTra(string manxb)
        {
            if (connData.KiemTraTonTai("LOSACH", "MaNXB", manxb))
                return true;
            return false;
        }

        //Thêm Nhà Xuất Bản vào CSDL
        public bool ThemNXB(NhaXuatBan_DTO nxb)
        {
            if (KiemTraTruocKhiLuu(nxb))
            {
                string sql = string.Format("INSERT INTO NHAXUATBAN (MaNXB, TenNXB, DiaChiNXB, DienThoaiNXB, Website)"
                    + " VALUES ('{0}', N'{1}', N'{2}', N'{3}',N'{4}')", nxb.MaNXB, nxb.TenNXB, nxb.DiaChiNXB, nxb.DienThoaiNXB, nxb.Website);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Thêm Nhà Xuất Bản thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Sửa Nhà Xuất Bản vào CSDL
        public bool SuaNXB(NhaXuatBan_DTO nxb)
        {
            if (KiemTraTruocKhiLuu(nxb))
            {
                string sql = string.Format("UPDATE NHAXUATBAN SET TenNXB=N'{1}', DiaChiNXB=N'{2}', DienThoaiNXB=N'{3}', Website=N'{4}' WHERE MaNXB=N'{0}'", nxb.MaNXB, nxb.TenNXB, nxb.DiaChiNXB, nxb.DienThoaiNXB, nxb.Website);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Sửa Nhà Xuất Bản thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Xóa Nhà Xuất Bản trong CSDL
        public bool XoaNXB(string MaNXB)
        {
            string sql = "DELETE FROM NHAXUATBAN WHERE MaNXB='" + MaNXB + "'";
           string s = "select MaNXB from NHAXUATBAN";
            DataTable tb = connData.getdata(s);
            if (tb.Rows.Count > 1)
            {
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Xóa Nhà Xuất Bản thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            MessageBox.Show("Nhà xuất bản cuối cùng không thể xóa !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        //Lấy Mã NXB kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connData.GetLastID("NHAXUATBAN", "MaNXB"), "NXB");
        }
    }
}
