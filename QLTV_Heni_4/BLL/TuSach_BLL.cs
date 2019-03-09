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
    class TuSach_BLL
    {
        ConnectDB connData = new ConnectDB();

        //Hàm lấy tất cả danh sách Thể loại để hiển thị
        public DataTable LayDanhSachTuSach()
        {
            string sql = "SELECT MaTuSach, TuSach, GhiChu FROM TUSACH ORDER BY MaTuSach DESC";
            return connData.getdata(sql);
        }

        // Lấy danh sách TL cho load sang ComboBox Sach
        public DataTable LayDSTS()
        {
            string sql = "SELECT MaTuSach, TuSach FROM TUSACH ORDER BY MaTuSach DESC";
            return connData.getdata(sql);
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(TuSach_DTO ts)
        {
            if (ts.TuSach.Equals(""))
            {
                MessageBox.Show("Tủ sách không hợp lệ ! ");
                return false;
            }
            return true;
        }

        //Kiểm tra tồn tại của thể loại
        public bool KiemTra(string matusach)
        {
            if (connData.KiemTraTonTai("TUASACH", "MaTuSach", matusach))
                return true;
            return false;
        }

        //Thêm Thể loại vào CSDL
        public bool ThemTuSach(TuSach_DTO ts)
        {
            if (KiemTraTruocKhiLuu(ts))
            {
                string sql = string.Format("INSERT INTO TUSACH (MaTuSach, TuSach, GhiChu)"
                    + " VALUES ('{0}', N'{1}', N'{2}')", ts.MaTuSach, ts.TuSach, ts.GhiChu);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Thêm tủ sách mới thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }


        //Sửa Thể Loại vào CSDL
        public bool SuaTuSach(TuSach_DTO ts)
        {
            if (KiemTraTruocKhiLuu(ts))
            {
                string sql = string.Format("UPDATE TUSACH SET TuSach=N'{0}', GhiChu=N'{1}' WHERE MaTuSach='{2}'", ts.TuSach, ts.GhiChu, ts.MaTuSach);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Sửa tủ sách thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Xóa Thể loại trong CSDL
        public bool XoaTuSach(string MaTuSach)
        {
            string sql = "DELETE FROM TUSACH WHERE MaTuSach='" + MaTuSach + "'";
            string s = "select MaTuSach from TUSACH";
            DataTable tbTL = connData.getdata(s);
            if (tbTL.Rows.Count > 1)
            {
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Xóa tủ sách thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            MessageBox.Show("Không thể xóa tủ sách duy nhất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        //Lấy Mã TG kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connData.GetLastID("TUSACH", "MaTuSach"), "TU");
        }
    }
}
