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
    class TacGia_BLL
    {
        ConnectDB connData = new ConnectDB();
        // Tìm tác giả thoe mã, tên
        public DataTable Tim_TacGia(string MaTG, string TenTG)
        {
            string sql = "SELECT MaTG,HoTenTG,(CASE GioiTinhTG WHEN 'true' THEN N'Nam' ELSE N'Nữ' END) AS GioiTinhTG,NgaySinhTG,DienThoaiTG,DiaChiTG FROM TACGIA ";
            string sql1 = "SELECT MaTG,HoTenTG,(CASE GioiTinhTG WHEN 'true' THEN N'Nam' ELSE N'Nữ' END) AS GioiTinhTG,NgaySinhTG,DienThoaiTG,DiaChiTG FROM TACGIA ORDER BY MaTG DESC ";
            string d = "";
            if (MaTG == "" && TenTG == "")
            {
                d = sql;
            }
            if (MaTG != "" && TenTG == "")
            {
                d = sql + " where MaTG like N'%" + MaTG + "%' ORDER BY MaTG DESC";
            }
            if (MaTG == "" && TenTG != "")
            {
                d = sql + " where HoTenTG like N'%" + TenTG + "%' ORDER BY MaTG DESC";
            }
            if (MaTG != "" && TenTG != "")
            {
                d = sql + " where MaTG like N'%" + MaTG + "%' and HoTenTG like N'%" + TenTG + "%' ORDER BY MaTG DESC";
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


        //Lay danh sach sách theo tg
        public DataTable LayDSSachTheoTG(string MaTG)
        {
            string d = "select MaTuaSach,TuaSach,NDTT from TUASACH ORDER BY MaTuaSach DESC";
            string sql = "select TACGIASACH.MaTuaSach,TUASACH.TuaSach,TUASACH.NDTT from TACGIASACH,TUASACH where TACGIASACH.MaTG='" + MaTG + "' and TACGIASACH.MaTuaSach=TUASACH.MaTuaSach ORDER BY MaTuaSach DESC";
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

        //Hàm lấy tất cả danh sách để hiển thị
        public DataTable LayDanhSachTacGia()
        {
            string sql = "SELECT MaTG,HoTenTG,(CASE GioiTinhTG WHEN 'true' THEN N'Nam' ELSE N'Nữ' END) AS GioiTinhTG,NgaySinhTG,DienThoaiTG,DiaChiTG FROM TACGIA";
            return connData.getdata(sql);
        }

        // Lấy danh sách Tác Giả
        public DataTable LayDSTG()
        {
            string sql = "SELECT MaTG, HoTenTG FROM TACGIA";
            return connData.getdata(sql);
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(TacGia_DTO tg)
        {
            if (tg.MaTG.Equals(""))
            {
                MessageBox.Show("Mã Tác Giả không hợp lệ ! ");
                return false;
            }
            if (tg.HoTenTG.Equals(""))
            {
                MessageBox.Show("Tên Tác giả không hợp lệ ! ");
                return false;
            }
            return true;
        }

        //Kiểm tra sự tồn tại của Mã TG trong bảng sách
        public bool KiemTra(string matg)
        {
            if (connData.KiemTraTonTai("TACGIASACH", "MaTG", matg))
                return true;
            return false;
        }

        //Thêm Tác Giả vào CSDL
        public bool ThemTG(TacGia_DTO tg)
        {
            if (KiemTraTruocKhiLuu(tg))
            {
                string sql = string.Format("INSERT INTO TACGIA (MaTG, HoTenTG,GioiTinhTG,NgaySinhTG, DiaChiTG, DienThoaiTG)"
                    + " VALUES ('{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}')", tg.MaTG, tg.HoTenTG,tg.GioiTinhTG,tg.NgaySinhTG , tg.DienThoaiTG,tg.DiaChiTG);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Thêm Tác Giả thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }


        //Sửa Tác Giả vào CSDL
        public bool SuaTG(TacGia_DTO tg)
        {
            if (KiemTraTruocKhiLuu(tg))
            {
                string sql = string.Format("UPDATE TACGIA SET HoTenTG=N'{1}',GioiTinhTG=N'{2}',NgaySinhTG=N'{3}', DienThoaiTG=N'{3}', DiaChiTG=N'{5}' WHERE MaTG=N'{0}'", tg.MaTG, tg.HoTenTG, tg.GioiTinhTG, tg.NgaySinhTG, tg.DienThoaiTG, tg.DiaChiTG);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Sửa Tác Giả thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Xóa Tác Giả trong CSDL
        public bool XoaTG(string MaTG)
        {
            string sql = "DELETE FROM TACGIA WHERE MaTG='" + MaTG + "'";
             string s = "select MaTG from TACGIA";
            DataTable tb = connData.getdata(s);
            if (tb.Rows.Count > 1)
            {
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Xóa Tác Giả thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            MessageBox.Show("Tác giả cuối cùng khong thể xóa thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        //Lấy Mã TG kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connData.GetLastID("TACGIA", "MaTG"), "TG");
        }


        public string dem_tgSach()
        {
            string sql = "select COUNT(*) as tongtg from TG_SOSACH";
            DataTable lm = connData.getdata(sql);
            DataRow g = lm.Rows[0];
            string t = g["tongtg"].ToString();
            return t;
        }

        public DataTable Report_tacgia_sl(string sl)
        {
            string sql = "SELECT MaTG, HoTenTG, GioiTinhTG, NgaySinhTG, DienThoaiTG, DiaChiTG, ss_tg FROM dbo.TG_SOSACH ORDER BY ss_tg DESC";
            string d;
            if (sl != "")
            {
                int s = Convert.ToInt32(sl);
                d = "SELECT TOP " + s + " MaTG, HoTenTG, GioiTinhTG, NgaySinhTG, DienThoaiTG, DiaChiTG, ss_tg FROM dbo.TG_SOSACH ORDER BY ss_tg DESC";
            }
            else
            {
                d = "SELECT MaTG, HoTenTG, GioiTinhTG, NgaySinhTG, DienThoaiTG, DiaChiTG, ss_tg FROM dbo.TG_SOSACH ORDER BY ss_tg DESC";
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
