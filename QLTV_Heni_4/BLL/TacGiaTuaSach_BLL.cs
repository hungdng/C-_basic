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
    class TacGiaTuaSach_BLL
    {
        ConnectDB connData = new ConnectDB();
        //Lấy Mã ts kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connData.GetLastID("TACGIASACH", "id_tgs"), "TGS");
        }
        //Hàm lấy tất cả danh sách Thể loại để hiển thị
        public DataTable LayDanhSachTacGiaTuaSach()
        {
            string sql = "SELECT TUASACH.TuaSach,TACGIA.HoTenTG FROM TACGIASACH,TUASACH,TACGIA where TUASACH.MaTuaSach=TACGIASACH.MaTuaSach and TACGIA.MaTG=TACGIASACH.MaTG";
            return connData.getdata(sql);
        }

        // Lấy danh sách TL cho load sang ComboBox Sach
        public DataTable LayDSTGS(string MaTS)
        {
            string sql1 = "select id_tgs,MaTuaSach, MaTG FROM TACGIASACH where MaTuaSach='" + MaTS + "' ORDER BY id_tgs DESC ";
            DataTable tgs = connData.getdata(sql1);
            if (tgs.Rows.Count > 0)
            {
                return tgs;
            }
            else
            {
                string sql = "SELECT id_tgs,MaTuaSach, MaTG FROM TACGIASACH ORDER BY id_tgs DESC";
                return connData.getdata(sql);
            }
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(TacGiaTuaSach_DTO tgts)
        {
           
            if (tgts.MaTG.Equals(""))
            {
                MessageBox.Show("Tên tác giả không hợp lệ ! ");
                return false;
            }
            string sql = "select * from TACGIASACH where MaTuaSach='" + tgts.MaTuaSach + "' and MaTG ='" + tgts.MaTG + "'";
            DataTable tgs = connData.getdata(sql);
            if (tgs.Rows.Count > 0)
            {
                MessageBox.Show("Tựa sách với tác giả này đã có không thể thực hiện được", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        //Kiểm tra tồn tại của Mã sách
        public bool KiemTra(string matl)
        {
            if (connData.KiemTraTonTai("SACH", "MaTL", matl))
                return true;
            return false;
        }

        //Thêm Thể loại vào CSDL
        public bool ThemTGTS(TacGiaTuaSach_DTO tgts)
        {
            if (KiemTraTruocKhiLuu(tgts))
            {
                string sql = string.Format("INSERT INTO TACGIASACH (id_tgs,MaTuaSach, MaTG)"
                    + " VALUES ('{0}', N'{1}',N'{2}')",tgts.id_tgs, tgts.MaTuaSach, tgts.MaTG);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Thêm Tác giả tựa sách thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }


        //Sửa Tác giả sách vào CSDL
        public bool SuaTGTS(TacGiaTuaSach_DTO tgts)
        {
            if (KiemTraTruocKhiLuu(tgts))
            {
                string sql = string.Format("UPDATE TACGIASACH SET MaTuaSach=N'{0}', MaTG=N'{1}' WHERE id_tgs='{2}'", tgts.MaTuaSach, tgts.MaTG, tgts.id_tgs);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Sửa Tác giả tựa sách thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Xóa Tác giả sách trong CSDL
        public bool XoaTGTS(string id_tgs)
        {
            string sql = "DELETE FROM TACGIASACH WHERE id_tgs='" + id_tgs + "'";
            string s = "select * from TACGIASACH";
            DataTable tbTGS = connData.getdata(s);
            if (tbTGS.Rows.Count > 1)
            {
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Xóa tác giả sách thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            MessageBox.Show("Tác giả sách không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

    }
}
